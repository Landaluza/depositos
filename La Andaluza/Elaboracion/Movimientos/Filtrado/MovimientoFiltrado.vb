Public Class MovimientoFiltrado
    Protected gui As GuiFiltrado
    Protected bdfiltrado As bdfiltrado
    Protected listadoDepositos As DataTable
    Protected listadoFiltros As DataTable
    Protected listadoProductos As DataTable
    Protected listadoLotes As DataTable
    Protected filtrado As Filtrados.Filtrado

    Protected hiloDatos As System.Threading.Thread
    Protected iniciohiloDatos As System.Threading.ThreadStart
    Protected invocador As MethodInvoker
    Private TipoProceso As Integer

    Public ReadOnly Property Form As Form
        Get
            Return CType(gui, Form)
        End Get
    End Property

    Public Sub New(ByVal proceso As Integer)

        Me.TipoProceso = proceso
        bdfiltrado = New BdFiltrado
        filtrado = New Filtrados.Filtrado(proceso)
        filtrado.loteFinal.tipo = Convert.ToInt32(bdfiltrado.seleccionar_tlote_por_proceso(Me.TipoProceso).Rows(0).Item(0))
        filtrado.loteFinal.muestra = Convert.ToBoolean(bdfiltrado.seleccionar_muestra_pro_proceso(Me.TipoProceso).Rows(0).Item(0))

        If filtrado.lotePartida.tipo <> 0 Then filtrado.Abreviatura = Convert.ToString(bdfiltrado.seleccionar_detalles_tlote(filtrado.lotePartida.tipo).Rows(0).Item(2))

        gui = New Guifiltrado(filtrado)

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
        listadoDepositos = bdfiltrado.listar_depositos
        listadoProductos = bdfiltrado.listar_productos
        listadoFiltros = bdfiltrado.devolver_Filtros
        listadoLotes = bdfiltrado.devolver_depositos_ocupados
        gui.BeginInvoke(invocador)
    End Sub

    Private Sub mostrarDatos()
        gui.DestinoDatasource = listadoDepositos
        gui.OrigenDatasource = listadoLotes
        gui.TipoProductoEntradaDatasource = listadoProductos
        gui.FiltroDatasource = listadoFiltros
    End Sub

    Private Sub cerrar()
        If hiloDatos.IsAlive Then hiloDatos.Abort()
    End Sub

    Protected Sub guardar()

        filtrado = gui.valores

        bdfiltrado.EmpezarTransaccion()
        Try

            Dim errores As String = filtrado.validar
            If errores <> String.Empty Then
                Throw New Exception("Se has encontrado los siguientes errores: " & Environment.NewLine & errores)
            End If

            'comprobaciones de los datos recibidos

            If filtrado.loteFinal.codigo_lote = "" And filtrado.loteFinal.id = 0 Then ' uno de los dos valores llega mal
                Dim dep As DataTable = bdfiltrado.seleccionar_detalles_deposito(filtrado.loteFinal.deposito)

                If dep.Rows(0).Item(1).ToString <> "" Then
                    Throw New Exception("Deposito en uso. El deposito de destino ya esta en uso.")
                End If
            Else

                Dim lote As DataTable = bdfiltrado.seleccionar_lote(filtrado.loteFinal.id)
                If filtrado.loteFinal.deposito <> Convert.ToInt32(lote.Rows(0).Item(5)) Then
                    Throw New Exception("El deposito de destino ya no contiene el lote que se selecciono.")
                End If

                'actualizamos la cantidad restante con los valores actuales
                filtrado.loteFinal.cantidad_restante = Convert.ToDouble(lote.Rows(0).Item(3))
            End If

            Dim producto As DataTable = bdfiltrado.seleccionar_detalles_producto(filtrado.loteFinal.producto)

            'si guardamos el lote que hubiera en el deposito de fin para añadir trazabilidad
            If filtrado.loteFinal.id = 0 Then
                'crear lote clonando el de trasiego, deposito vacio
                Dim tipoFinal As DataTable = bdfiltrado.seleccionar_detalles_tlote(filtrado.loteFinal.tipo)
                Dim codigoDestino As String = filtrado.fecha.ToString("yyyyMMdd") & producto.Rows(0).Item(2).ToString & tipoFinal.Rows(0).Item(2).ToString
                codigoDestino = bdfiltrado.calcular_codigo_lote(codigoDestino)

                If Not bdfiltrado.crear_lote(filtrado.lotePartida.codigo_lote, codigoDestino, filtrado.loteFinal.deposito, 0) Then
                    Throw New Exception("No se pudo crear el lote de destino")
                End If

                filtrado.loteFinal.codigo_lote = codigoDestino
            Else
                If filtrado.loteFinal.codigo_lote = "" Then
                    'loteAnterior = trasiego.loteFinal

                    'crear lote y guardar para trazabilidad el anterior
                    Dim productoFinal As DataTable = bdfiltrado.seleccionar_detalles_producto(filtrado.loteFinal.producto)
                    Dim tipoFinal As DataTable = bdfiltrado.seleccionar_detalles_tlote(filtrado.loteFinal.tipo)
                    Dim codigoDestino As String = filtrado.fecha.ToString("yyyyMMdd") & producto.Rows(0).Item(2).ToString & tipoFinal.Rows(0).Item(2).ToString
                    codigoDestino = bdfiltrado.calcular_codigo_lote(codigoDestino)

                    Dim detallesDepositoFinal As DataTable = bdfiltrado.seleccionar_detalles_deposito(filtrado.loteFinal.deposito)
                    filtrado.loteFinal.codigo_lote = detallesDepositoFinal.Rows(0).Item(1).ToString


                    If Not bdfiltrado.crear_lote(codigoDestino, filtrado.loteFinal.deposito, 0, filtrado.loteFinal.tipo, filtrado.loteFinal.producto) Then
                        Throw New Exception("No se pudo crear el lote de destino")
                    End If

                    If Not bdfiltrado.guardar_movimiento(filtrado.loteFinal.deposito, filtrado.loteFinal.deposito, filtrado.loteFinal.cantidad_restante, filtrado.proceso) Then
                        Throw New Exception("No se pudo guardar el movimiento del lote en el deposito de destino")
                    End If

                    If Not bdfiltrado.guardar_trazabilidad(codigoDestino, filtrado.loteFinal.codigo_lote, filtrado.loteFinal.cantidad_restante) Then
                        Throw New Exception("No se pudo guardar la trazabilidad del lote en el deposito de destino")
                    End If


                    'actualizar atributos
                    If Not bdfiltrado.sacar_lote(filtrado.loteFinal.codigo_lote) Then
                        Throw New Exception("No se pudo actualizar el deposito del lote en el deposito de destino")
                    End If

                    If Not bdfiltrado.actualizar_lote(filtrado.loteFinal.codigo_lote, 0) Then
                        Throw New Exception("No se pudo actualizar la cantidad del lote en el deposito de destino")
                    End If

                    If Not bdfiltrado.actualizar_lote(codigoDestino, filtrado.loteFinal.cantidad_restante) Then
                        Throw New Exception("No se pudo actualizar la cantidad del nuevo lote en el deposito de destino")
                    End If

                    filtrado.loteFinal.codigo_lote = codigoDestino

                    Dim lote As DataTable = bdfiltrado.seleccionar_lote_por_codigo(filtrado.loteFinal.codigo_lote)
                    'sobra, la cantidad restante es la que tenia el lote anterior
                    ' trasiego.loteFinal.cantidad_restante = Convert.ToDouble(lote.Rows(0).Item(1))
                Else
                    'no crear lote

                End If
            End If


            'realizar movimiento de trasiego a final
            If Not bdfiltrado.guardar_movimiento(filtrado.lotePartida.deposito, filtrado.loteFinal.deposito, If(filtrado.sumarAdestino, filtrado.cantidad, 0), filtrado.proceso) Then
                Throw New Exception("No se pudo guardar el movimiento del lote trasiego")
            End If

            'guardar trazabilidad
            If Not bdfiltrado.guardar_trazabilidad(filtrado.loteFinal.codigo_lote, filtrado.lotePartida.codigo_lote, If(filtrado.sumarAdestino, filtrado.cantidad, 0)) Then
                Throw New Exception("No se pudo guardar la trazabilidad del lote trasiego")
            End If

            If Not bdfiltrado.actualizar_lote(filtrado.lotePartida.codigo_lote, -filtrado.cantidad) Then
                Throw New Exception("No se pudo actualizar la cantidad del lote de partida")
            End If

            If filtrado.sumarAdestino Then
                If Not bdfiltrado.actualizar_lote(filtrado.loteFinal.codigo_lote, filtrado.cantidad) Then
                    Throw New Exception("No se pudo actualizar la cantidad del lote de destino")
                End If
            End If

            bdfiltrado.TerminarTransaccion()
            gui.Close()
        Catch ex As Exception
            bdfiltrado.CancelarTransaccion()
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
