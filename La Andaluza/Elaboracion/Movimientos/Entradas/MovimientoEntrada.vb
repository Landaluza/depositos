Namespace Movimientos
    Public Class MovimientoEntrada
        Protected gui As GuiEntrada
        Protected bdEntrada As BdEntrada
        Protected listadoDepositos As DataTable
        Protected listadoProductos As DataTable
        Protected listadoLotes As DataTable
        Protected listadoProveedores As DataTable
        Protected compra As Movimientos.Entrada

        Protected hiloDatos As System.Threading.Thread
        Protected iniciohiloDatos As System.Threading.ThreadStart
        Protected invocador As MethodInvoker

        Public ReadOnly Property Form As Form
            Get
                Return CType(gui, Form)
            End Get
        End Property

        Public Sub New(ByVal proceso As Integer)

            bdEntrada = New BdEntrada
            compra = New Movimientos.Entrada(proceso)
            compra.loteFinal.tipo = Convert.ToInt32(bdEntrada.seleccionar_tlote_por_proceso(Me.compra.proceso).Rows(0).Item(0))
            compra.loteFinal.muestra = Convert.ToBoolean(bdEntrada.seleccionar_muestra_pro_proceso(Me.compra.proceso).Rows(0).Item(0))
            compra.lotePartida.tipo = Movimientos.Entrada.Lote_ENTRADA


            gui = New GuiEntrada(compra)

            iniciohiloDatos = New System.Threading.ThreadStart(AddressOf cargardatos)
            invocador = New MethodInvoker(AddressOf mostrarDatos)

            cargarDatosuno()

            AddHandler gui.FormClosing, AddressOf cerrar
            AddHandler gui.CantidadIncorrecta, AddressOf cantidad_incorrecta
            AddHandler gui.ProductoIncorrecto, AddressOf producto_incorrecto

            If proceso = Movimientos.Entrada.COMPRA Then
                AddHandler gui.btnGuardar.Click, AddressOf guardar_compra
            Else
                AddHandler gui.btnGuardar.Click, AddressOf guardar_entrada
            End If
        End Sub

        Public Sub cargarDatosuno()
            hiloDatos = New System.Threading.Thread(iniciohiloDatos)
            hiloDatos.IsBackground = True
            hiloDatos.Name = "consultadatosCompras"
            hiloDatos.Start()
        End Sub

        Private Sub cargardatos()
            listadoProveedores = bdEntrada.listar_proveedores()
            listadoLotes = bdEntrada.listar_tlotes
            listadoProductos = bdEntrada.listar_productos
            listadoDepositos = bdEntrada.listar_depositos

            gui.BeginInvoke(invocador)
        End Sub

        Private Sub mostrarDatos()
            gui.TipoProductoDatasource = listadoProductos
            gui.TipoLoteDatasource = listadoLotes
            gui.ProveedorEntradaDatasource = listadoProveedores
            gui.TipoProductoEntradaDatasource = listadoProductos
            gui.DestinoDatasource = listadoDepositos

        End Sub

        Private Sub cerrar()
            If hiloDatos.IsAlive Then hiloDatos.Abort()
        End Sub


        Private Overloads Sub guardar_compra()
            bdEntrada.EmpezarTransaccion()

            Try

                guardar()

                If Not bdEntrada.actualizar_proveedor_lote(compra.lotePartida.codigo_lote, compra.proveedorCompra) Then
                    Throw New Exception("No se pudo guardar el proveedor del lote compra")
                End If

                bdEntrada.TerminarTransaccion()
                Me.gui.Close()

            Catch ex As Exception
                bdEntrada.CancelarTransaccion()
                MessageBox.Show(ex.Message, "Error al gaurdar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End Sub

        Private Overloads Sub guardar_entrada()
            bdEntrada.EmpezarTransaccion()

            Try

                guardar()

                bdEntrada.TerminarTransaccion()
                Me.gui.Close()

            Catch ex As Exception
                bdEntrada.CancelarTransaccion()
                MessageBox.Show(ex.Message, "Error al gaurdar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End Sub


        Protected Sub guardar()

            compra = gui.valores


            Dim errores As String = compra.validar
            If errores <> String.Empty Then
                Throw New Exception("Se has encontrado los siguientes errores: " & Environment.NewLine & errores)
            End If

            'comprobaciones de los datos recibidos

            If compra.loteFinal.codigo_lote = "" And compra.loteFinal.id = 0 Then
                Dim dep As DataTable = bdEntrada.seleccionar_detalles_deposito(compra.loteFinal.deposito)

                If dep.Rows(0).Item(1).ToString <> "" Then
                    Throw New Exception("Deposito en uso. El deposito de destino ya esta en uso.")
                End If
            Else

                Dim lote As DataTable = bdEntrada.seleccionar_lote(compra.loteFinal.id)
                If compra.loteFinal.deposito <> Convert.ToInt32(lote.Rows(0).Item(5)) Then
                    Throw New Exception("El deposito de destino ya no contiene el lote que se selecciono.")
                End If

                'actualizamos la cantidad restante con los valores actuales
                compra.loteFinal.cantidad_restante = Convert.ToDouble(lote.Rows(0).Item(3))
            End If

            Dim producto As DataTable = bdEntrada.seleccionar_detalles_producto(compra.lotePartida.producto)
            Dim tlote As DataTable = bdEntrada.seleccionar_detalles_tlote(compra.lotePartida.tipo)
            Dim codigoSinLetra As String = compra.fecha.ToString("yyyyMMdd") & producto.Rows(0).Item(2).ToString & Convert.ToString(tlote.Rows(0).Item(2)) 'Movimientos.Entrada.ABREVIATURA_ENTRADA
            compra.lotePartida.codigo_lote = bdEntrada.calcular_codigo_lote(codigoSinLetra)
            'Dim loteAnterior As compras.Compra.Lote

            'crear lote compra
            If Not bdEntrada.crear_lote_entrada(compra.lotePartida.codigo_lote, compra.cantidad, compra.lotePartida.producto) Then
                Throw New Exception("No se pudo crear el lote de entrada")
            End If



            'si guardamos el lote que hubiera en el deposito de fin para añadir trazabilidad
            If compra.loteFinal.id = 0 Then
                'crear lote clonando el de compra, deposito vacio
                Dim tipoFinal As DataTable = bdEntrada.seleccionar_detalles_tlote(compra.loteFinal.tipo)
                codigoSinLetra = compra.fecha.ToString("yyyyMMdd") & producto.Rows(0).Item(2).ToString & tipoFinal.Rows(0).Item(2).ToString
                Dim codigoDestino As String = bdEntrada.calcular_codigo_lote(codigoSinLetra)


                If Not bdEntrada.crear_lote(compra.lotePartida.codigo_lote, codigoDestino, compra.loteFinal.deposito, 0) Then
                    Throw New Exception("No se pudo crear el lote de destino")
                End If

                compra.loteFinal.codigo_lote = codigoDestino
            Else
                If compra.loteFinal.codigo_lote = "" Then
                    'loteAnterior = compra.loteFinal

                    'crear lote y guardar para trazabilidad el anterior
                    Dim productoFinal As DataTable = bdEntrada.seleccionar_detalles_producto(compra.loteFinal.producto)
                    Dim tipoFinal As DataTable = bdEntrada.seleccionar_detalles_tlote(compra.loteFinal.tipo)
                    Dim codigoDestino As String = compra.fecha.ToString("yyyyMMdd") & producto.Rows(0).Item(2).ToString & tipoFinal.Rows(0).Item(2).ToString
                    codigoDestino = bdEntrada.calcular_codigo_lote(codigoDestino)

                    Dim detallesDepositoFinal As DataTable = bdEntrada.seleccionar_detalles_deposito(compra.loteFinal.deposito)
                    compra.loteFinal.codigo_lote = detallesDepositoFinal.Rows(0).Item(1).ToString


                    If Not bdEntrada.crear_lote(codigoDestino, compra.loteFinal.deposito, 0, compra.loteFinal.tipo, compra.loteFinal.producto) Then
                        Throw New Exception("No se pudo crear el lote de destino")
                    End If

                    If Not bdEntrada.guardar_movimiento(compra.loteFinal.deposito, compra.loteFinal.deposito, compra.loteFinal.cantidad_restante) Then
                        Throw New Exception("No se pudo guardar el movimiento del lote en el deposito de destino")
                    End If

                    If Not bdEntrada.guardar_trazabilidad(codigoDestino, compra.loteFinal.codigo_lote, compra.loteFinal.cantidad_restante) Then
                        Throw New Exception("No se pudo guardar la trazabilidad del lote en el deposito de destino")
                    End If


                    'actualizar atributos
                    If Not bdEntrada.sacar_lote(compra.loteFinal.codigo_lote) Then
                        Throw New Exception("No se pudo actualizar el deposito del lote en el deposito de destino")
                    End If

                    If Not bdEntrada.actualizar_lote(compra.loteFinal.codigo_lote, 0) Then
                        Throw New Exception("No se pudo actualizar la cantidad del lote en el deposito de destino")
                    End If

                    If Not bdEntrada.actualizar_lote(codigoDestino, compra.loteFinal.cantidad_restante) Then
                        Throw New Exception("No se pudo actualizar la cantidad del nuevo lote en el deposito de destino")
                    End If

                    compra.loteFinal.codigo_lote = codigoDestino

                    Dim lote As DataTable = bdEntrada.seleccionar_lote_por_codigo(compra.loteFinal.codigo_lote)
                    'sobra, la cantidad restante es la que tenia el lote anterior
                    ' compra.loteFinal.cantidad_restante = Convert.ToDouble(lote.Rows(0).Item(1))
                Else
                    'no crear lote

                End If
            End If


            'realizar movimiento de compra a final
            If Not bdEntrada.guardar_movimiento(compra.lotePartida.deposito, compra.loteFinal.deposito, If(compra.sumarAdestino, compra.cantidad, 0)) Then
                Throw New Exception("No se pudo guardar el movimiento del lote compra")
            End If

            'guardar trazabilidad
            If Not bdEntrada.guardar_trazabilidad(compra.loteFinal.codigo_lote, compra.lotePartida.codigo_lote, If(compra.sumarAdestino, compra.cantidad, 0)) Then
                Throw New Exception("No se pudo guardar la trazabilidad del lote compra")
            End If

            If Not bdEntrada.actualizar_lote(compra.lotePartida.codigo_lote, -compra.cantidad) Then
                Throw New Exception("No se pudo actualizar la cantidad del lote de partida")
            End If

            If compra.sumarAdestino Then
                If Not bdEntrada.actualizar_lote(compra.loteFinal.codigo_lote, compra.cantidad) Then
                    Throw New Exception("No se pudo actualizar la cantidad del lote de destino")
                End If
            End If

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

End Namespace

