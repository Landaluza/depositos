Public Class MovimientoMaceracion
    Protected gui As GuiMAceracion
    Protected bdmaceracion As BdMAceracion
    Protected listadoDepositos As DataTable
    Protected listadoTiposLotes As DataTable
    Protected listadoProductos As DataTable
    Protected listadoLotes As DataTable
    Protected maceracion As Maceraciones.Maceracion

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
        Bdmaceracion = New Bdmaceracion
        maceracion = New Maceraciones.Maceracion(tipoDiferencia)
        maceracion.lotePartida.tipo = Convert.ToInt32(bdmaceracion.seleccionar_tlote_por_proceso(Me.TipoProceso).Rows(0).Item(0))
        maceracion.lotePartida.muestra = Convert.ToBoolean(bdmaceracion.seleccionar_muestra_pro_proceso(Me.TipoProceso).Rows(0).Item(0))

        If maceracion.lotePartida.tipo <> 0 Then maceracion.Abreviatura = Convert.ToString(bdmaceracion.seleccionar_detalles_tlote(maceracion.lotePartida.tipo).Rows(0).Item(2))

        gui = New Guimaceracion(maceracion)

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
        listadoDepositos = bdmaceracion.listar_depositos_libres
        listadoProductos = bdmaceracion.listar_productos
        listadoTiposLotes = bdmaceracion.listar_tlotes
        listadoLotes = bdmaceracion.devolver_depositos_ocupados
        gui.BeginInvoke(invocador)
    End Sub

    Private Sub mostrarDatos()
        gui.DestinoDatasource = listadoDepositos
        gui.OrigenDatasource = listadoLotes
        gui.TipoProductoEntradaDatasource = listadoProductos
        gui.TipoLoteDatasource = listadoTiposLotes
    End Sub

    Private Sub cerrar()
        If hiloDatos.IsAlive Then hiloDatos.Abort()
    End Sub

    Protected Sub guardar()

        maceracion = gui.valores

        bdmaceracion.EmpezarTransaccion()
        Try

            Dim errores As String = maceracion.validar
            If errores <> String.Empty Then
                Throw New Exception("Se has encontrado los siguientes errores: " & Environment.NewLine & errores)
            End If


            'comprobaciones de los datos recibidos
            Dim lote As DataTable = bdmaceracion.seleccionar_lote(maceracion.lotePartida.id)
            If maceracion.lotePartida.deposito <> Convert.ToInt32(lote.Rows(0).Item(5)) Then
                Throw New Exception("El deposito de destino ya no contiene el lote que se selecciono.")
            End If

            'actualizamos la cantidad restante con los valores actuales
            maceracion.lotePartida.cantidad_restante = Convert.ToDouble(lote.Rows(0).Item(3))

            'preaparacion del lote final
            Dim producto As DataTable = bdmaceracion.seleccionar_detalles_producto(maceracion.lotePartida.producto)
            Dim fechaDiferencias As Date
            Dim codigoSinLetra As String

            'If Me.maceracion.frecuencia_creacion_lote = Diferencias.Diferencia.FRECUENCIA_MENSUAL Then
            '    fechaDiferencias = New Date(maceracion.fecha.Year, maceracion.fecha.Month, 1)

            '    codigoSinLetra = fechaDiferencias.ToString("yyyyMMdd") & producto.Rows(0).Item(2).ToString & Me.maceracion.Abreviatura
            '    maceracion.loteFinal.codigo_lote = bdmaceracion.recuperar_ultimo_codigo_lote(codigoSinLetra)
            'Else
            fechaDiferencias = maceracion.fecha

            codigoSinLetra = fechaDiferencias.ToString("yyyyMMdd") & producto.Rows(0).Item(2).ToString & Me.maceracion.Abreviatura
            ' End If


            If maceracion.loteFinal.codigo_lote.Replace(" ", "") = "" Then
                maceracion.loteFinal.codigo_lote = bdmaceracion.calcular_codigo_lote(codigoSinLetra)

                If Not bdmaceracion.crear_lote(maceracion.loteFinal.codigo_lote, maceracion.cantidad, maceracion.loteFinal.producto, maceracion.loteFinal.tipo) Then
                    Throw New Exception("No se pudo crear el lote de entrada")
                End If
            End If


            ''??
            'realizar movimiento de compra a final
            If Not bdmaceracion.guardar_movimiento(maceracion.lotePartida.deposito, maceracion.loteFinal.deposito, maceracion.cantidad) Then
                Throw New Exception("No se pudo guardar el movimiento del lote compra")
            End If

            'guardar trazabilidad
            If Not bdmaceracion.guardar_trazabilidad(maceracion.loteFinal.codigo_lote, maceracion.lotePartida.codigo_lote, maceracion.cantidad) Then
                Throw New Exception("No se pudo guardar la trazabilidad del lote compra")
            End If

            If Not bdmaceracion.actualizar_lote(maceracion.lotePartida.codigo_lote, -maceracion.cantidad) Then
                Throw New Exception("No se pudo actualizar la cantidad del lote de partida")
            End If

            If Me.maceracion.cantidad = Me.maceracion.lotePartida.cantidad_restante Then
                bdmaceracion.sacar_lote(maceracion.lotePartida.codigo_lote)
            End If


            If Not bdmaceracion.actualizar_lote(maceracion.loteFinal.codigo_lote, maceracion.cantidad) Then
                Throw New Exception("No se pudo actualizar la cantidad del lote de destino")
            End If

            bdmaceracion.TerminarTransaccion()
            gui.Close()
        Catch ex As Exception
            bdmaceracion.CancelarTransaccion()
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
