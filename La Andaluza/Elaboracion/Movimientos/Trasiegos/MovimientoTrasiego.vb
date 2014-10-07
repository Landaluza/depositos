Public Class MovimientoTrasiego
    Protected gui As GuiTrasiego
    Protected bdTrasiego As BdTrasiego
    Protected listadoDepositos As DataTable
    Protected listadoDepositosDestino As DataTable
    Protected listadoTiposLotes As DataTable
    Protected listadoProductos As DataTable
    Protected trasiego As Trasiegos.Trasiego

    Protected hiloDatos As System.Threading.Thread
    Protected iniciohiloDatos As System.Threading.ThreadStart
    Protected invocador As MethodInvoker
    Protected invocadorDatosDestino As MethodInvoker
    Protected hiloDatosDestino As System.Threading.Thread
    Protected iniciohiloDatosDestino As System.Threading.ThreadStart
    Private TipoProceso As Integer

    Public ReadOnly Property Form As Form
        Get
            Return CType(gui, Form)
        End Get
    End Property

    Public Sub New(ByVal proceso As Integer)

        Me.TipoProceso = proceso
        bdTrasiego = New BdTrasiego
        trasiego = New Trasiegos.Trasiego(proceso)
        trasiego.loteFinal.tipo = Convert.ToInt32(bdTrasiego.seleccionar_tlote_por_proceso(Me.TipoProceso).Rows(0).Item(0))
        trasiego.loteFinal.muestra = Convert.ToBoolean(bdTrasiego.seleccionar_muestra_pro_proceso(Me.TipoProceso).Rows(0).Item(0))

        If trasiego.loteFinal.tipo <> 0 Then trasiego.Abreviatura = Convert.ToString(bdTrasiego.seleccionar_detalles_tlote(trasiego.loteFinal.tipo).Rows(0).Item(2))

        gui = New GuiTrasiego(trasiego)

        iniciohiloDatos = New System.Threading.ThreadStart(AddressOf cargardatos)
        invocador = New MethodInvoker(AddressOf mostrarDatos)

        iniciohiloDatosDestino = New System.Threading.ThreadStart(AddressOf solicitardatosDestino)
        invocadorDatosDestino = New MethodInvoker(AddressOf mostrarDatosDestino)

        cargarDatosuno()

        AddHandler gui.FormClosing, AddressOf cerrar
        AddHandler gui.btnGuardar.Click, AddressOf guardar
        AddHandler gui.CantidadIncorrecta, AddressOf cantidad_incorrecta
        AddHandler gui.ProductoIncorrecto, AddressOf producto_incorrecto
        AddHandler gui.dgvOrigen.SelectionChanged, AddressOf cargarDatosDestino
    End Sub

    Public Sub cargarDatosuno()
        hiloDatos = New System.Threading.Thread(iniciohiloDatos)
        hiloDatos.IsBackground = True
        hiloDatos.Name = "consultadatostrasiegos"
        hiloDatos.Start()
    End Sub

    Private Sub cargardatos()
        listadoDepositos = bdTrasiego.devolver_depositos_ocupados
        listadoDepositosDestino = bdTrasiego.devolver_depositos
        listadoProductos = bdTrasiego.listar_productos
        listadoTiposLotes = bdTrasiego.listar_tlotes
        gui.BeginInvoke(invocador)
    End Sub

    Private Sub mostrarDatos()
        gui.DestinoDatasource = listadoDepositosDestino
        gui.OrigenDatasource = listadoDepositos
        gui.TipoProductoDatasource = listadoProductos
        gui.TipoLoteDatasource = listadoTiposLotes
    End Sub

    Public Sub cargarDatosDestino()
        hiloDatosDestino = New System.Threading.Thread(iniciohiloDatosDestino)
        hiloDatosDestino.IsBackground = True
        hiloDatosDestino.Name = "consultadatosDestinotrasiegos"
        hiloDatosDestino.Start()
    End Sub

    Private Sub solicitardatosDestino()
        If Not gui.dgvOrigen.CurrentRow Is Nothing Then
            listadoDepositosDestino = bdTrasiego.devolver_depositos_excepto(Convert.ToString(gui.dgvOrigen.CurrentRow.Cells(0).Value))
        End If

        gui.BeginInvoke(invocadorDatosDestino)
    End Sub

    Private Sub mostrarDatosDestino()
        gui.DestinoDatasource = listadoDepositosDestino
    End Sub

    Private Sub cerrar()
        If hiloDatos.IsAlive Then hiloDatos.Abort()
    End Sub

    Protected Sub guardar()

        trasiego = gui.valores

        bdTrasiego.EmpezarTransaccion()
        Try

            Dim errores As String = trasiego.validar
            If errores <> String.Empty Then
                Throw New Exception("Se has encontrado los siguientes errores: " & Environment.NewLine & errores)
            End If

            'comprobaciones de los datos recibidos

            If trasiego.loteFinal.codigo_lote = "" And trasiego.loteFinal.id = 0 Then
                Dim dep As DataTable = bdTrasiego.seleccionar_detalles_deposito(trasiego.loteFinal.deposito)

                If dep.Rows(0).Item(1).ToString <> "" Then
                    Throw New Exception("Deposito en uso. El deposito de destino ya esta en uso.")
                End If
            Else

                Dim lote As DataTable = bdTrasiego.seleccionar_lote(trasiego.loteFinal.id)
                If trasiego.loteFinal.deposito <> Convert.ToInt32(lote.Rows(0).Item(5)) Then
                    Throw New Exception("El deposito de destino ya no contiene el lote que se selecciono.")
                End If

                'actualizamos la cantidad restante con los valores actuales
                trasiego.loteFinal.cantidad_restante = Convert.ToDouble(lote.Rows(0).Item(3))
            End If

            Dim producto As DataTable = bdTrasiego.seleccionar_detalles_producto(trasiego.loteFinal.producto)

            'si guardamos el lote que hubiera en el deposito de fin para añadir trazabilidad
            If trasiego.loteFinal.id = 0 Then
                'crear lote clonando el de trasiego, deposito vacio
                Dim tipoFinal As DataTable = bdTrasiego.seleccionar_detalles_tlote(trasiego.loteFinal.tipo)
                Dim codigoDestino As String = trasiego.fecha.ToString("yyyyMMdd") & producto.Rows(0).Item(2).ToString & tipoFinal.Rows(0).Item(2).ToString
                codigoDestino = bdTrasiego.calcular_codigo_lote(codigoDestino)

                If Not bdTrasiego.crear_lote(trasiego.lotePartida.codigo_lote, codigoDestino, trasiego.loteFinal.deposito, 0) Then
                    Throw New Exception("No se pudo crear el lote de destino")
                End If

                trasiego.loteFinal.codigo_lote = codigoDestino
            Else
                If trasiego.loteFinal.codigo_lote = "" Then
                    'loteAnterior = trasiego.loteFinal

                    'crear lote y guardar para trazabilidad el anterior
                    Dim productoFinal As DataTable = bdTrasiego.seleccionar_detalles_producto(trasiego.loteFinal.producto)
                    Dim tipoFinal As DataTable = bdTrasiego.seleccionar_detalles_tlote(trasiego.loteFinal.tipo)
                    Dim codigoDestino As String = trasiego.fecha.ToString("yyyyMMdd") & producto.Rows(0).Item(2).ToString & tipoFinal.Rows(0).Item(2).ToString
                    codigoDestino = bdTrasiego.calcular_codigo_lote(codigoDestino)

                    Dim detallesDepositoFinal As DataTable = bdTrasiego.seleccionar_detalles_deposito(trasiego.loteFinal.deposito)
                    trasiego.loteFinal.codigo_lote = detallesDepositoFinal.Rows(0).Item(1).ToString


                    If Not bdTrasiego.crear_lote(codigoDestino, trasiego.loteFinal.deposito, 0, trasiego.loteFinal.tipo, trasiego.loteFinal.producto) Then
                        Throw New Exception("No se pudo crear el lote de destino")
                    End If

                    If Not bdTrasiego.guardar_movimiento(trasiego.loteFinal.deposito, trasiego.loteFinal.deposito, trasiego.loteFinal.cantidad_restante, trasiego.proceso) Then
                        Throw New Exception("No se pudo guardar el movimiento del lote en el deposito de destino")
                    End If

                    If Not bdTrasiego.guardar_trazabilidad(codigoDestino, trasiego.loteFinal.codigo_lote, trasiego.loteFinal.cantidad_restante) Then
                        Throw New Exception("No se pudo guardar la trazabilidad del lote en el deposito de destino")
                    End If


                    'actualizar atributos
                    If Not bdTrasiego.sacar_lote(trasiego.loteFinal.codigo_lote) Then
                        Throw New Exception("No se pudo actualizar el deposito del lote en el deposito de destino")
                    End If

                    If Not bdTrasiego.actualizar_lote(trasiego.loteFinal.codigo_lote, 0) Then
                        Throw New Exception("No se pudo actualizar la cantidad del lote en el deposito de destino")
                    End If

                    If Not bdTrasiego.actualizar_lote(codigoDestino, trasiego.loteFinal.cantidad_restante) Then
                        Throw New Exception("No se pudo actualizar la cantidad del nuevo lote en el deposito de destino")
                    End If

                    trasiego.loteFinal.codigo_lote = codigoDestino

                    Dim lote As DataTable = bdTrasiego.seleccionar_lote_por_codigo(trasiego.loteFinal.codigo_lote)
                    'sobra, la cantidad restante es la que tenia el lote anterior
                    ' trasiego.loteFinal.cantidad_restante = Convert.ToDouble(lote.Rows(0).Item(1))
                Else
                    'no crear lote

                End If
            End If


            'realizar movimiento de trasiego a final
            If Not bdTrasiego.guardar_movimiento(trasiego.lotePartida.deposito, trasiego.loteFinal.deposito, If(trasiego.sumarAdestino, trasiego.cantidad, 0), trasiego.proceso) Then
                Throw New Exception("No se pudo guardar el movimiento del lote trasiego")
            End If

            'guardar trazabilidad
            If Not bdTrasiego.guardar_trazabilidad(trasiego.loteFinal.codigo_lote, trasiego.lotePartida.codigo_lote, If(trasiego.sumarAdestino, trasiego.cantidad, 0)) Then
                Throw New Exception("No se pudo guardar la trazabilidad del lote trasiego")
            End If

            If Not bdTrasiego.actualizar_lote(trasiego.lotePartida.codigo_lote, -trasiego.cantidad) Then
                Throw New Exception("No se pudo actualizar la cantidad del lote de partida")
            End If

            If trasiego.sumarAdestino Then
                If Not bdTrasiego.actualizar_lote(trasiego.loteFinal.codigo_lote, trasiego.cantidad) Then
                    Throw New Exception("No se pudo actualizar la cantidad del lote de destino")
                End If
            End If

            bdTrasiego.TerminarTransaccion()
            gui.Close()
        Catch ex As Exception
            bdTrasiego.CancelarTransaccion()
            MessageBox.Show("Error al guardar. " & ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        cargarDatosDestino()
    End Sub

End Class
