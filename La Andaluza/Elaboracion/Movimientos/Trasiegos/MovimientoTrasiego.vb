Public Class MovimientoTrasiego
    Protected gui As GuiTrasiego
    Protected bdTrasiego As BdTrasiego
    Protected listadoDepositos As DataTable
    Protected listadoTiposLotes As DataTable
    Protected listadoProductos As DataTable
    Protected listadoLotes As DataTable
    Protected trasiego As Trasiegos.Trasiego

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
        bdTrasiego = New BdTrasiego
        trasiego = New Trasiegos.Trasiego(tipoDiferencia)
        trasiego.lotePartida.tipo = Convert.ToInt32(bdTrasiego.seleccionar_tlote_por_proceso(Me.TipoProceso).Rows(0).Item(0))
        trasiego.lotePartida.muestra = Convert.ToBoolean(bdTrasiego.seleccionar_muestra_pro_proceso(Me.TipoProceso).Rows(0).Item(0))

        If trasiego.lotePartida.tipo <> 0 Then trasiego.Abreviatura = Convert.ToString(Bdtrasiego.seleccionar_detalles_tlote(trasiego.lotePartida.tipo).Rows(0).Item(2))

        gui = New Guitrasiego(trasiego)

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
        listadoDepositos = bdtrasiego.listar_depositos_libres
        listadoProductos = bdtrasiego.listar_productos
        listadoTiposLotes = bdtrasiego.listar_tlotes
        listadoLotes = bdtrasiego.devolver_depositos_ocupados
        gui.BeginInvoke(invocador)
    End Sub

    Private Sub mostrarDatos()
        gui.DestinoDatasource = listadoDepositos
        gui.OrigenDatasource = listadoLotes
        gui.TipoProductoDatasource = listadoProductos
        gui.TipoLoteDatasource = listadoTiposLotes
    End Sub

    Private Sub cerrar()
        If hiloDatos.IsAlive Then hiloDatos.Abort()
    End Sub

    Protected Sub guardar()

        trasiego = gui.valores

        bdtrasiego.EmpezarTransaccion()
        Try

            Dim errores As String = trasiego.validar
            If errores <> String.Empty Then
                Throw New Exception("Se has encontrado los siguientes errores: " & Environment.NewLine & errores)
            End If


            'comprobaciones de los datos recibidos
            Dim lote As DataTable = Bdtrasiego.seleccionar_lote(trasiego.lotePartida.id)
            If trasiego.lotePartida.deposito <> Convert.ToInt32(lote.Rows(0).Item(5)) Then
                Throw New Exception("El deposito de destino ya no contiene el lote que se selecciono.")
            End If

            'actualizamos la cantidad restante con los valores actuales
            trasiego.lotePartida.cantidad_restante = Convert.ToDouble(lote.Rows(0).Item(3))

            'preaparacion del lote final
            Dim producto As DataTable = bdtrasiego.seleccionar_detalles_producto(trasiego.lotePartida.producto)
            Dim fechaDiferencias As Date
            Dim codigoSinLetra As String

            'If Me.trasiego.frecuencia_creacion_lote = Diferencias.Diferencia.FRECUENCIA_MENSUAL Then
            '    fechaDiferencias = New Date(trasiego.fecha.Year, trasiego.fecha.Month, 1)

            '    codigoSinLetra = fechaDiferencias.ToString("yyyyMMdd") & producto.Rows(0).Item(2).ToString & Me.trasiego.Abreviatura
            '    trasiego.loteFinal.codigo_lote = bdtrasiego.recuperar_ultimo_codigo_lote(codigoSinLetra)
            'Else
            fechaDiferencias = trasiego.fecha

            codigoSinLetra = fechaDiferencias.ToString("yyyyMMdd") & producto.Rows(0).Item(2).ToString & Me.trasiego.Abreviatura
            ' End If


            If trasiego.loteFinal.codigo_lote.Replace(" ", "") = "" Then
                trasiego.loteFinal.codigo_lote = bdtrasiego.calcular_codigo_lote(codigoSinLetra)

                If Not bdtrasiego.crear_lote(trasiego.loteFinal.codigo_lote, trasiego.cantidad, trasiego.loteFinal.producto, trasiego.loteFinal.tipo) Then
                    Throw New Exception("No se pudo crear el lote de entrada")
                End If
            End If


            ''??
            'realizar movimiento de compra a final
            If Not bdtrasiego.guardar_movimiento(trasiego.lotePartida.deposito, trasiego.loteFinal.deposito, trasiego.cantidad) Then
                Throw New Exception("No se pudo guardar el movimiento del lote compra")
            End If

            'guardar trazabilidad
            If Not bdtrasiego.guardar_trazabilidad(trasiego.loteFinal.codigo_lote, trasiego.lotePartida.codigo_lote, trasiego.cantidad) Then
                Throw New Exception("No se pudo guardar la trazabilidad del lote compra")
            End If

            If Not bdtrasiego.actualizar_lote(trasiego.lotePartida.codigo_lote, -trasiego.cantidad) Then
                Throw New Exception("No se pudo actualizar la cantidad del lote de partida")
            End If

            If Me.trasiego.cantidad = Me.trasiego.lotePartida.cantidad_restante Then
                bdtrasiego.sacar_lote(trasiego.lotePartida.codigo_lote)
            End If


            If Not bdtrasiego.actualizar_lote(trasiego.loteFinal.codigo_lote, trasiego.cantidad) Then
                Throw New Exception("No se pudo actualizar la cantidad del lote de destino")
            End If

            bdtrasiego.TerminarTransaccion()
            gui.Close()
        Catch ex As Exception
            bdtrasiego.CancelarTransaccion()
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
