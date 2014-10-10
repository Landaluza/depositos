Namespace Movimientos
    Public Class MovimientoSalida
        Protected gui As Movimientos.GuiSalida
        Protected bdSalida As Movimientos.BdSalida
        Protected listadoDepositos As DataTable
        Protected listadoRecipientes As DataTable
        Protected salida As Movimientos.Salida

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
            bdSalida = New BdSalida
            salida = New Movimientos.Salida(proceso)
            salida.loteFinal.tipo = Convert.ToInt32(bdSalida.seleccionar_tlote_por_proceso(Me.TipoProceso).Rows(0).Item(0))
            salida.loteFinal.muestra = Convert.ToBoolean(bdSalida.seleccionar_muestra_pro_proceso(Me.TipoProceso).Rows(0).Item(0))

            If salida.loteFinal.tipo <> 0 Then salida.Abreviatura = Convert.ToString(bdSalida.seleccionar_detalles_tlote(salida.loteFinal.tipo).Rows(0).Item(2))

            gui = New GuiSalida(salida)

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
            hiloDatos.Name = "consultadatostrasiegos"
            hiloDatos.Start()
        End Sub

        Private Sub cargardatos()
            listadoDepositos = bdSalida.devolver_depositos_ocupados
            
            gui.BeginInvoke(invocador)
        End Sub

        Private Sub mostrarDatos()
            ' gui.DestinoDatasource = listadoDepositosDestino
            gui.OrigenDatasource = listadoDepositos
        End Sub


        Private Sub cerrar()          
            If hiloDatos.IsAlive Then hiloDatos.Abort()           
        End Sub

        Protected Sub guardar()

            salida = gui.valores

            bdSalida.EmpezarTransaccion()
            Try

                Dim errores As String = salida.validar
                If errores <> String.Empty Then
                    Throw New Exception("Se has encontrado los siguientes errores: " & Environment.NewLine & errores)
                End If

                'comprobaciones de los datos recibidos

                If salida.loteFinal.codigo_lote = "" And salida.loteFinal.id = 0 Then
                    Dim dep As DataTable = bdSalida.seleccionar_detalles_deposito(salida.loteFinal.deposito)

                    If dep.Rows(0).Item(1).ToString <> "" Then
                        Throw New Exception("Deposito en uso. El deposito de destino ya esta en uso.")
                    End If
                Else

                    Dim lote As DataTable = bdSalida.seleccionar_lote(salida.loteFinal.id)
                    If salida.loteFinal.deposito <> Convert.ToInt32(lote.Rows(0).Item(5)) Then
                        Throw New Exception("El deposito de destino ya no contiene el lote que se selecciono.")
                    End If

                    'actualizamos la cantidad restante con los valores actuales
                    salida.loteFinal.cantidad_restante = Convert.ToDouble(lote.Rows(0).Item(3))
                End If

                Dim producto As DataTable = bdSalida.seleccionar_detalles_producto(salida.loteFinal.producto)

                'si guardamos el lote que hubiera en el deposito de fin para añadir trazabilidad
                If salida.loteFinal.id = 0 Then
                    'crear lote clonando el de trasiego, deposito vacio
                    Dim tipoFinal As DataTable = bdSalida.seleccionar_detalles_tlote(salida.loteFinal.tipo)
                    Dim codigoDestino As String = salida.fecha.ToString("yyyyMMdd") & producto.Rows(0).Item(2).ToString & tipoFinal.Rows(0).Item(2).ToString
                    codigoDestino = bdSalida.calcular_codigo_lote(codigoDestino)

                    If Not bdSalida.crear_lote(salida.lotePartida.codigo_lote, codigoDestino, salida.loteFinal.deposito, 0) Then
                        Throw New Exception("No se pudo crear el lote de destino")
                    End If

                    salida.loteFinal.codigo_lote = codigoDestino
                Else
                    If salida.loteFinal.codigo_lote = "" Then
                        'loteAnterior = trasiego.loteFinal

                        'crear lote y guardar para trazabilidad el anterior
                        Dim productoFinal As DataTable = bdSalida.seleccionar_detalles_producto(salida.loteFinal.producto)
                        Dim tipoFinal As DataTable = bdSalida.seleccionar_detalles_tlote(salida.loteFinal.tipo)
                        Dim codigoDestino As String = salida.fecha.ToString("yyyyMMdd") & producto.Rows(0).Item(2).ToString & tipoFinal.Rows(0).Item(2).ToString
                        codigoDestino = bdSalida.calcular_codigo_lote(codigoDestino)

                        Dim detallesDepositoFinal As DataTable = bdSalida.seleccionar_detalles_deposito(salida.loteFinal.deposito)
                        salida.loteFinal.codigo_lote = detallesDepositoFinal.Rows(0).Item(1).ToString


                        If Not bdSalida.crear_lote(codigoDestino, salida.loteFinal.deposito, 0, salida.loteFinal.tipo, salida.loteFinal.producto) Then
                            Throw New Exception("No se pudo crear el lote de destino")
                        End If

                        If Not bdSalida.guardar_movimiento(salida.loteFinal.deposito, salida.loteFinal.deposito, salida.loteFinal.cantidad_restante, salida.proceso) Then
                            Throw New Exception("No se pudo guardar el movimiento del lote en el deposito de destino")
                        End If

                        If Not bdSalida.guardar_trazabilidad(codigoDestino, salida.loteFinal.codigo_lote, salida.loteFinal.cantidad_restante) Then
                            Throw New Exception("No se pudo guardar la trazabilidad del lote en el deposito de destino")
                        End If


                        'actualizar atributos
                        If Not bdSalida.sacar_lote(salida.loteFinal.codigo_lote) Then
                            Throw New Exception("No se pudo actualizar el deposito del lote en el deposito de destino")
                        End If

                        If Not bdSalida.actualizar_lote(salida.loteFinal.codigo_lote, 0) Then
                            Throw New Exception("No se pudo actualizar la cantidad del lote en el deposito de destino")
                        End If

                        If Not bdSalida.actualizar_lote(codigoDestino, salida.loteFinal.cantidad_restante) Then
                            Throw New Exception("No se pudo actualizar la cantidad del nuevo lote en el deposito de destino")
                        End If

                        salida.loteFinal.codigo_lote = codigoDestino

                        Dim lote As DataTable = bdSalida.seleccionar_lote_por_codigo(salida.loteFinal.codigo_lote)
                        'sobra, la cantidad restante es la que tenia el lote anterior
                        ' trasiego.loteFinal.cantidad_restante = Convert.ToDouble(lote.Rows(0).Item(1))
                    Else
                        'no crear lote

                    End If
                End If


                'realizar movimiento de trasiego a final
                If Not bdSalida.guardar_movimiento(salida.lotePartida.deposito, salida.loteFinal.deposito, If(salida.sumarAdestino, salida.cantidad, 0), salida.proceso) Then
                    Throw New Exception("No se pudo guardar el movimiento del lote trasiego")
                End If

                'guardar trazabilidad
                If Not bdSalida.guardar_trazabilidad(salida.loteFinal.codigo_lote, salida.lotePartida.codigo_lote, If(salida.sumarAdestino, salida.cantidad, 0)) Then
                    Throw New Exception("No se pudo guardar la trazabilidad del lote trasiego")
                End If

                If Not bdSalida.actualizar_lote(salida.lotePartida.codigo_lote, -salida.cantidad) Then
                    Throw New Exception("No se pudo actualizar la cantidad del lote de partida")
                End If

                If salida.sumarAdestino Then
                    If Not bdSalida.actualizar_lote(salida.loteFinal.codigo_lote, salida.cantidad) Then
                        Throw New Exception("No se pudo actualizar la cantidad del lote de destino")
                    End If
                End If

                bdSalida.TerminarTransaccion()
                gui.Close()
            Catch ex As Exception
                bdSalida.CancelarTransaccion()
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
            cargarDatosuno()
        End Sub
    End Class
End Namespace