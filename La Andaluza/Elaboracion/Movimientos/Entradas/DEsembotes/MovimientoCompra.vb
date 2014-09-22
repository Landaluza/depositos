Public Class MovimientoCompra
    Inherits MovimientoEntrada

    Public ReadOnly Property Form As Form
        Get
            Return CType(gui, Form)
        End Get
    End Property

    Public Sub New()
        MyBase.New()
        gui = New GuiEntrada(Entradas.Entrada.COMPRA)

    End Sub


    Private Sub guardar()
        Dim compra As Entradas.Entrada = gui.valores

        Dim errores As String = compra.validar
        If errores <> String.Empty Then
            MessageBox.Show("Se has encontrado los siguientes errores: " & Environment.NewLine & errores, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        bdEntrada.EmpezarTransaccion()

        Try
            'comprobaciones de los datos recibidos

            If compra.loteFinal.codigo_lote = "" And compra.loteFinal.id = 0 Then
                Dim dep As DataTable = bdEntrada.seleccionar_detalles_deposito(compra.loteFinal.deposito)

                If dep.Rows(0).Item(1).ToString <> "" Then
                    bdEntrada.CancelarTransaccion()
                    MessageBox.Show("Deposito en uso. El deposito de destino ya esta en uso.", "Operacion no permitida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return
                End If
            Else

                Dim lote As DataTable = bdEntrada.seleccionar_lote(compra.loteFinal.id)
                If compra.loteFinal.deposito <> Convert.ToInt32(lote.Rows(0).Item(5)) Then
                    bdEntrada.CancelarTransaccion()
                    MessageBox.Show("El deposito de destino ya no contiene el lote que se selecciono.", "Operacion no permitida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return
                End If

                'actualizamos la cantidad restante con los valores actuales
                compra.loteFinal.cantidad_restante = Convert.ToDouble(lote.Rows(0).Item(3))
            End If

            Dim producto As DataTable = bdEntrada.seleccionar_detalles_producto(compra.lotePartida.producto)
            Dim codigoSinLetra As String = compra.fecha.ToString("yyyyMMdd") & producto.Rows(0).Item(2).ToString & Entradas.Entrada.ABREVIATURA
            compra.lotePartida.codigo_lote = bdEntrada.calcular_codigo_lote(codigoSinLetra)
            'Dim loteAnterior As compras.Compra.Lote

            'crear lote compra
            If Not bdEntrada.crear_lote_entrada(compra.lotePartida.codigo_lote, compra.cantidad, compra.lotePartida.producto) Then
                bdEntrada.CancelarTransaccion()
                MessageBox.Show(".", "Operacion no permitida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If

            'si guardamos el lote que hubiera en el deposito de fin para añadir trazabilidad
            If compra.loteFinal.id = 0 Then
                'crear lote clonando el de compra, deposito vacio
                Dim tipoFinal As DataTable = bdEntrada.seleccionar_detalles_tlote(compra.loteFinal.tipo)
                codigoSinLetra = compra.fecha.ToString("yyyyMMdd") & producto.Rows(0).Item(2).ToString & tipoFinal.Rows(0).Item(2).ToString
                Dim codigoDestino As String = bdEntrada.calcular_codigo_lote(codigoSinLetra)


                If Not bdEntrada.crear_lote(compra.lotePartida.codigo_lote, codigoDestino, compra.loteFinal.deposito, 0) Then
                    bdEntrada.CancelarTransaccion()
                    MessageBox.Show(".", "Operacion no permitida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return
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
                        bdEntrada.CancelarTransaccion()
                        MessageBox.Show(".", "Operacion no permitida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Return
                    End If

                    If Not bdEntrada.guardar_movimiento(compra.loteFinal.deposito, compra.loteFinal.deposito, compra.loteFinal.cantidad_restante) Then
                        bdEntrada.CancelarTransaccion()
                        MessageBox.Show(".", "Operacion no permitida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Return
                    End If

                    If Not bdEntrada.guardar_trazabilidad(codigoDestino, compra.loteFinal.codigo_lote, compra.loteFinal.cantidad_restante) Then
                        bdEntrada.CancelarTransaccion()
                        MessageBox.Show(".", "Operacion no permitida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Return
                    End If

                    'If Not bdCompra.guardar_trazabilidad_ultimo_lote(compra.loteFinal.codigo_lote, compra.loteFinal.cantidad_restante) Then
                    '    bdCompra.CancelarTransaccion()
                    '    MessageBox.Show(".", "Operacion no permitida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    '    Return
                    'End If

                    'actualizar atributos
                    If Not bdEntrada.sacar_lote(compra.loteFinal.codigo_lote) Then
                        bdEntrada.CancelarTransaccion()
                        MessageBox.Show(".", "Operacion no permitida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Return
                    End If

                    If Not bdEntrada.actualizar_lote(compra.loteFinal.codigo_lote, 0) Then
                        bdEntrada.CancelarTransaccion()
                        MessageBox.Show(".", "Operacion no permitida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Return
                    End If

                    If Not bdEntrada.actualizar_lote(codigoDestino, compra.loteFinal.cantidad_restante) Then
                        bdEntrada.CancelarTransaccion()
                        MessageBox.Show(".", "Operacion no permitida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Return
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
                bdEntrada.CancelarTransaccion()
                MessageBox.Show(".", "Operacion no permitida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If

            'guardar trazabilidad
            If Not bdEntrada.guardar_trazabilidad(compra.loteFinal.codigo_lote, compra.lotePartida.codigo_lote, If(compra.sumarAdestino, compra.cantidad, 0)) Then
                bdEntrada.CancelarTransaccion()
                MessageBox.Show(".", "Operacion no permitida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If

            If Not bdEntrada.actualizar_lote(compra.lotePartida.codigo_lote, -compra.cantidad) Then
                bdEntrada.CancelarTransaccion()
                MessageBox.Show(".", "Operacion no permitida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If

            If compra.sumarAdestino Then
                If Not bdEntrada.actualizar_lote(compra.loteFinal.codigo_lote, compra.cantidad) Then
                    bdEntrada.CancelarTransaccion()
                    MessageBox.Show(".", "Operacion no permitida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return
                End If
            End If

            bdEntrada.TerminarTransaccion()
            Me.gui.Close()
        Catch ex As Exception
            bdEntrada.CancelarTransaccion()
            MessageBox.Show("Error al guardar. " & Environment.NewLine & ex.Message, "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
