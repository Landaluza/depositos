Public Class MovimientoDiferencia
    Protected gui As GuiDiferencia
    Protected bdDiferencia As BdDiferencia
    Protected listadoDepositos As DataTable
    Protected diferencia As Diferencias.Diferencia

    Protected hiloDatos As System.Threading.Thread
    Protected iniciohiloDatos As System.Threading.ThreadStart
    Protected invocador As MethodInvoker
    Private TipoProceso As Integer

    Public ReadOnly Property Form As Form
        Get
            Return CType(gui, Form)
        End Get
    End Property

    Public Sub New(ByVal tipoDiferencia As Integer)

        Me.TipoProceso = tipoDiferencia
        bdDiferencia = New BdDiferencia
        diferencia = New Diferencias.Diferencia(tipoDiferencia)
        diferencia.lotePartida.tipo = Convert.ToInt32(bdDiferencia.seleccionar_tlote_por_proceso(Me.TipoProceso).Rows(0).Item(0))
        diferencia.lotePartida.muestra = Convert.ToBoolean(bdDiferencia.seleccionar_muestra_pro_proceso(Me.TipoProceso).Rows(0).Item(0))

        gui = New GuiDiferencia(diferencia)

        iniciohiloDatos = New System.Threading.ThreadStart(AddressOf cargardatos)
        invocador = New MethodInvoker(AddressOf mostrarDatos)

        cargarDatosuno()

        AddHandler gui.FormClosing, AddressOf cerrar
        AddHandler gui.btnGuardar.Click, AddressOf guardar
        AddHandler gui.CantidadIncorrecta, AddressOf cantidad_incorrecta
        AddHandler gui.ProductoIncorrecto, AddressOf producto_incorrecto
    End Sub

    Public Sub cargarDatosuno()
        hiloDatos = New System.Threading.Thread(iniciohiloDatos)
        hiloDatos.IsBackground = True
        hiloDatos.Name = "consultadatosCompras"
        hiloDatos.Start()
    End Sub

    Private Sub cargardatos()
        listadoDepositos = bdDiferencia.listar_depositos_ocupados

        gui.BeginInvoke(invocador)
    End Sub

    Private Sub mostrarDatos()
        gui.DestinoDatasource = listadoDepositos

    End Sub

    Private Sub cerrar()
        If hiloDatos.IsAlive Then hiloDatos.Abort()
    End Sub

    Protected Sub guardar()

        diferencia = gui.valores

        bdDiferencia.EmpezarTransaccion()
        Try

            Dim errores As String = diferencia.validar
            If errores <> String.Empty Then
                Throw New Exception("Se has encontrado los siguientes errores: " & Environment.NewLine & errores)
            End If


            'comprobaciones de los datos recibidos
            Dim lote As DataTable = bdDiferencia.seleccionar_lote(diferencia.lotePartida.id)
            If diferencia.lotePartida.deposito <> Convert.ToInt32(lote.Rows(0).Item(5)) Then
                Throw New Exception("El deposito de destino ya no contiene el lote que se selecciono.")
            End If

            'actualizamos la cantidad restante con los valores actuales
            diferencia.lotePartida.cantidad_restante = Convert.ToDouble(lote.Rows(0).Item(3))

            'preaparacion del lote final
            Dim producto As DataTable = bdDiferencia.seleccionar_detalles_producto(diferencia.lotePartida.producto)
            Dim fechaDiferencias As Date
            Dim codigoSinLetra As String

            If Me.diferencia.frecuencia_creacion_lote = Diferencias.Diferencia.FRECUENCIA_MENSUAL Then
                fechaDiferencias = New Date(diferencia.fecha.Year, diferencia.fecha.Month, 1)

                codigoSinLetra = fechaDiferencias.ToString("yyyyMMdd") & producto.Rows(0).Item(2).ToString & Entradas.Entrada.ABREVIATURA_ENTRADA
                diferencia.loteFinal.codigo_lote = bdDiferencia.recuperar_ultimo_codigo_lote(codigoSinLetra)
            Else
                fechaDiferencias = diferencia.fecha

                codigoSinLetra = fechaDiferencias.ToString("yyyyMMdd") & producto.Rows(0).Item(2).ToString & Entradas.Entrada.ABREVIATURA_ENTRADA
            End If

            If diferencia.loteFinal.codigo_lote = "" Then
                diferencia.loteFinal.codigo_lote = bdDiferencia.calcular_codigo_lote(codigoSinLetra)

                If Not bdDiferencia.crear_lote(diferencia.loteFinal.codigo_lote, diferencia.cantidad, diferencia.loteFinal.producto, diferencia.loteFinal.tipo) Then
                    Throw New Exception("No se pudo crear el lote de entrada")
                End If
            End If

            'realizar movimiento de compra a final
            If Not bdDiferencia.guardar_movimiento(diferencia.lotePartida.deposito, diferencia.loteFinal.deposito, diferencia.cantidad) Then
                Throw New Exception("No se pudo guardar el movimiento del lote compra")
            End If

            'guardar trazabilidad
            If Not bdDiferencia.guardar_trazabilidad(diferencia.loteFinal.codigo_lote, diferencia.lotePartida.codigo_lote, diferencia.cantidad) Then
                Throw New Exception("No se pudo guardar la trazabilidad del lote compra")
            End If

            If Not bdDiferencia.actualizar_lote(diferencia.lotePartida.codigo_lote, -diferencia.cantidad) Then
                Throw New Exception("No se pudo actualizar la cantidad del lote de partida")
            End If

            If Not bdDiferencia.actualizar_lote(diferencia.loteFinal.codigo_lote, diferencia.cantidad) Then
                Throw New Exception("No se pudo actualizar la cantidad del lote de destino")
            End If

            bdDiferencia.TerminarTransaccion()
        Catch ex As Exception
            bdDiferencia.CancelarTransaccion()
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cantidad_incorrecta(ByVal lote As Integer, e As EventArgs)
        'Pantalla.mostrarDialogo(CType(New CorrectorCantidad(lote), Form))
        Dim corrector As New CorrectorCantidad(lote)
        cargarDatosuno()
    End Sub

    Private Sub producto_incorrecto(ByVal lote As Integer, e As EventArgs)
        'Pantalla.mostrarDialogo(CType(New CorrectorProducto(lote), Form))
        Dim corrector As New CorrectorProducto(lote)
        cargarDatosuno()
    End Sub

End Class