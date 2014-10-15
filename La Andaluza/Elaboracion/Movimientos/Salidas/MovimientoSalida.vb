Namespace Movimientos
    Public Class MovimientoSalida
        Protected gui As Movimientos.GuiSalida
        Protected bdSalida As Movimientos.BdSalida
        Protected listadoDepositos As DataTable
        Protected listadoRecipientes As DataTable
        Protected listadoTransicubas As DataTable
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
            listadoRecipientes = bdSalida.listar_recipientes
            listadoTransicubas = bdSalida.listar_transicubas_activas
            gui.BeginInvoke(invocador)
        End Sub

        Private Sub mostrarDatos()
            gui.TransicubasDatasource = listadoTransicubas
            gui.RecipientesDatasource = listadoRecipientes
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
                

                Dim lote As DataTable = bdSalida.seleccionar_lote(salida.lotePartida.id)
                If salida.lotePartida.deposito <> Convert.ToInt32(lote.Rows(0).Item(5)) Then
                    Throw New Exception("El deposito de origen ya no contiene el lote que se selecciono.")
                End If

                    'actualizamos la cantidad restante con los valores actuales
                salida.lotePartida.cantidad_restante = Convert.ToDouble(lote.Rows(0).Item(3))
                If salida.lotePartida.cantidad_restante < salida.cantidad Then
                    Throw New Exception("SE intenta mover mas cantidad de la que posee el lote en el deposito.")
                End If

                Dim producto As DataTable = bdSalida.seleccionar_detalles_producto(salida.loteFinal.producto)


                'crear lote y guardar para trazabilidad el anterior
                Dim productoFinal As DataTable = bdSalida.seleccionar_detalles_producto(salida.loteFinal.producto)
                Dim tipoFinal As DataTable = bdSalida.seleccionar_detalles_tlote(salida.loteFinal.tipo)
                Dim codigoDestino As String = salida.fecha.ToString("yyyyMMdd") & producto.Rows(0).Item(2).ToString & tipoFinal.Rows(0).Item(2).ToString
                codigoDestino = bdSalida.calcular_codigo_lote(codigoDestino)


                If Not bdSalida.crear_lote(codigoDestino, salida.loteFinal.deposito, 0, salida.loteFinal.tipo, salida.loteFinal.producto) Then
                    Throw New Exception("No se pudo crear el lote de destino")
                End If


                salida.loteFinal.codigo_lote = codigoDestino

                If salida.recipiente <> 0 Then
                    If Not bdSalida.actualizar_recipiente(codigoDestino, salida.recipiente) Then
                        Throw New Exception("No se pudo crear el lote de destino")
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

                If salida.lotePartida.cantidad_restante - salida.cantidad <= 0 Then
                    If Not bdSalida.sacar_lote(salida.lotePartida.codigo_lote) Then
                        Throw New Exception("No se pudo sacar el lote del deposito")
                    End If

                    If Not bdSalida.actualizar_lote(salida.lotePartida.codigo_lote, 0) Then
                        Throw New Exception("No se pudo actualizar la cantidad del lote de partida")
                    End If
                Else
                    If Not bdSalida.actualizar_lote(salida.lotePartida.codigo_lote, -salida.cantidad) Then
                        Throw New Exception("No se pudo actualizar la cantidad del lote de partida")
                    End If
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