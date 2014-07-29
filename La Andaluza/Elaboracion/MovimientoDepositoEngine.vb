Public Class MovimientoDepositoEngine
    Private codigoLotePartida As String
    Private codigoLotePartida2 As String
    Private codigoLoteDestino As String
    Private deposito As Integer
    Private depositoPrevio As Integer
    Private deposito2 As Integer
    Private depositoPrevio2 As Integer
    Private trazabilidadLote As Boolean

    Private mov As MovimientoDeposito

    Public Sub New(ByVal movimientoid As Integer)
        mov = New MovimientoDeposito()
        mov.MovimientoID = movimientoid
        setValues()
    End Sub

    'Public Function eliminar(ByVal revertirDepositos As Boolean, ByVal revertirDepositos2 As Boolean, ByVal borrardestino As Boolean) As Boolean
    '    mov.revertirDepositos = revertirDepositos
    '    mov.revertirDepositos2 = revertirDepositos2
    '    mov.eliminarDestino = borrardestino

    '    mov.EmpezarTransaccion()

    '    Try


    '        If mov.trazabilidad Then
    '            If mov.movimientoReflexivo Then

    '                If mov.movimientoReflexivoEntreDepositos Then
    '                    If mov.revertirDepositos Then
    '                        If Not mov.actualizarDepositoLote(mov.lotePartida) Then
    '                            mov.CancelarTransaccion()
    '                            MessageBox.Show("Error al realizar la operacion. No se pudo actualizar el lote", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                            Exit Function
    '                        End If
    '                    End If
    '                Else

    '                    If Not mov.actualizarCantidadLote(mov.lotePartida, mov.MovimientoID) Then
    '                        mov.CancelarTransaccion()
    '                        MessageBox.Show("Error al realizar la operacion. No se pudo actualizar el lote", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                        Exit Function
    '                    End If
    '                End If

    '            Else
    '                If mov.revertirDepositos Then
    '                    If Not mov.actualizarValoresLote(mov.lotePartida, mov.MovimientoID) Then
    '                        mov.CancelarTransaccion()
    '                        MessageBox.Show("Error al realizar la operacion. No se pudo actualizar el lote", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                        Exit Function
    '                    End If

    '                Else
    '                    If Not mov.actualizarCantidadLoteTrazabilidadMulti(mov.lotePartida, mov.MovimientoID, mov.lotePartida) Then
    '                        mov.CancelarTransaccion()
    '                        MessageBox.Show("Error al realizar la operacion. No se pudo actualizar el lote", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                        Exit Function
    '                    End If
    '                End If

    '                If Not mov.borrarTrazabilidad(mov.lotePartida, mov.MovimientoID) Then
    '                    mov.CancelarTransaccion()
    '                    MessageBox.Show("Error al realizar la operacion. No se pudo actualizar el lote", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                    Exit Function
    '                End If

    '                If mov.lotePartida2 > 0 Then
    '                    If mov.revertirDepositos2 Then
    '                        If Not mov.actualizarValoresLote(mov.lotePartida2, mov.MovimientoID) Then
    '                            mov.CancelarTransaccion()
    '                            MessageBox.Show("Error al realizar la operacion. No se pudo actualizar el lote", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                            Exit Function
    '                        End If

    '                    Else
    '                        If Not mov.actualizarCantidadLoteTrazabilidadMulti(mov.lotePartida2, mov.MovimientoID, mov.lotePartida2) Then
    '                            mov.CancelarTransaccion()
    '                            MessageBox.Show("Error al realizar la operacion. No se pudo actualizar el lote", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                            Exit Function
    '                        End If
    '                    End If

    '                    If Not mov.borrarTrazabilidad(mov.lotePartida2, mov.MovimientoID) Then
    '                        mov.CancelarTransaccion()
    '                        MessageBox.Show("Error al realizar la operacion. No se pudo actualizar el lote", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                        Exit Function
    '                    End If
    '                End If

    '                If mov.destinoEliminable Then
    '                    If mov.eliminarDestino Then
    '                        If Not mov.borrarLote(mov.loteDestino) Then
    '                            mov.CancelarTransaccion()
    '                            MessageBox.Show("Error al realizar la operacion. No se pudo actualizar el lote destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                            Exit Function
    '                        End If
    '                    Else
    '                        If Not mov.actualizarCantidadLoteTrazabilidadMulti(mov.loteDestino, mov.MovimientoID, mov.lotePartida, True) Then
    '                            mov.CancelarTransaccion()
    '                            MessageBox.Show("Error al realizar la operacion. No se pudo actualizar el lote destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                            Exit Function
    '                        End If

    '                        If mov.lotePartida2 > 0 Then
    '                            If Not mov.actualizarCantidadLoteTrazabilidadMulti(mov.loteDestino, mov.MovimientoID, mov.lotePartida2, True) Then
    '                                mov.CancelarTransaccion()
    '                                MessageBox.Show("Error al realizar la operacion. No se pudo actualizar el lote destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                                Exit Function
    '                            End If
    '                        End If
    '                    End If
    '                Else
    '                    If Not mov.actualizarCantidadLoteTrazabilidadMulti(mov.loteDestino, mov.MovimientoID, mov.lotePartida, True) Then
    '                        mov.CancelarTransaccion()
    '                        MessageBox.Show("Error al realizar la operacion. No se pudo actualizar el lote destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                        Exit Function
    '                    End If

    '                    If mov.lotePartida2 > 0 Then
    '                        If Not mov.actualizarCantidadLoteTrazabilidadMulti(mov.loteDestino, mov.MovimientoID, mov.lotePartida2, True) Then
    '                            mov.CancelarTransaccion()
    '                            MessageBox.Show("Error al realizar la operacion. No se pudo actualizar el lote destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                            Exit Function
    '                        End If
    '                    End If
    '                End If
    '            End If

    '        Else

    '            If mov.lotePartida > 0 Then
    '                If mov.revertirDepositos Then

    '                    If Not mov.actualizarValoresLote(mov.lotePartida, mov.MovimientoID) Then
    '                        mov.CancelarTransaccion()
    '                        MessageBox.Show("Error al realizar la operacion. No se pudo actualizar el lote", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                        Exit Function
    '                    End If
    '                Else

    '                    If Not mov.actualizarCantidadLote(mov.lotePartida, mov.MovimientoID) Then
    '                        mov.CancelarTransaccion()
    '                        MessageBox.Show("Error al realizar la operacion. No se pudo actualizar el lote", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                        Exit Function
    '                    End If

    '                    If Not mov.actualizarDepositoPrevioLote(mov.lotePartida) Then
    '                        mov.CancelarTransaccion()
    '                        MessageBox.Show("Error al realizar la operacion. No se pudo actualizar el lote", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                        Exit Function
    '                    End If
    '                End If

    '            Else
    '                mov.CancelarTransaccion()
    '                MessageBox.Show("caso no contemplado, no se podra borrar el movimiento. Contactar con el administrador", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                Exit Function
    '            End If
    '        End If

    '        If Not mov.borrarMovimiento(mov.MovimientoID) Then
    '            mov.CancelarTransaccion()
    '            MessageBox.Show("Error al realizar la operacion. No se pudo borrar el movimiento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            Exit Function
    '        End If

    '        mov.TerminarTransaccion()
    '        Return True
    '    Catch ex As Exception
    '        mov.CancelarTransaccion()
    '        MessageBox.Show("Error al realizar la operacion. Detalles:" & mov.MovimientoID & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Return False
    '    End Try
    'End Function

    Public Function eliminar(ByVal revertirDepositos As Boolean, ByVal revertirDepositos2 As Boolean, ByVal borrardestino As Boolean) As Boolean
        mov.revertirDepositos = revertirDepositos
        mov.revertirDepositos2 = revertirDepositos2
        mov.eliminarDestino = borrardestino

        mov.EmpezarTransaccion()

        Try

            If mov.trazabilidad Then
                If mov.movimientoReflexivo Then

                    If mov.movimientoReflexivoEntreDepositos Then
                        If mov.revertirDepositos Then
                            If Not mov.actualizarDepositoLote(mov.lotePartida) Then
                                Throw New Exception("Error al realizar la operacion. No se pudo actualizar el lote")
                            End If
                        End If
                    Else

                        If Not mov.actualizarCantidadLote(mov.lotePartida, mov.MovimientoID) Then
                            Throw New Exception("Error al realizar la operacion. No se pudo actualizar el lote")
                        End If
                    End If

                Else
                    If mov.revertirDepositos Then
                        If Not mov.actualizarValoresLote(mov.lotePartida, mov.MovimientoID) Then
                            Throw New Exception("Error al realizar la operacion. No se pudo actualizar el lote")
                        End If

                    Else
                        If Not mov.actualizarCantidadLoteTrazabilidadMulti(mov.lotePartida, mov.MovimientoID, mov.lotePartida) Then
                            Throw New Exception("Error al realizar la operacion. No se pudo actualizar el lote")
                        End If
                    End If

                    If Not mov.borrarTrazabilidad(mov.lotePartida, mov.MovimientoID) Then
                        Throw New Exception("Error al realizar la operacion. No se pudo actualizar el lote")
                    End If

                    If mov.lotePartida2 > 0 Then
                        If mov.revertirDepositos2 Then
                            If Not mov.actualizarValoresLote(mov.lotePartida2, mov.MovimientoID) Then
                                Throw New Exception("Error al realizar la operacion. No se pudo actualizar el lote")
                            End If

                        Else
                            If Not mov.actualizarCantidadLoteTrazabilidadMulti(mov.lotePartida2, mov.MovimientoID, mov.lotePartida2) Then
                                Throw New Exception("Error al realizar la operacion. No se pudo actualizar el lote")
                            End If
                        End If

                        If Not mov.borrarTrazabilidad(mov.lotePartida2, mov.MovimientoID) Then
                            Throw New Exception("Error al realizar la operacion. No se pudo actualizar el lote")
                        End If
                    End If

                    If mov.destinoEliminable Then
                        If mov.eliminarDestino Then
                            If Not mov.borrarLote(mov.loteDestino) Then
                                Throw New Exception("Error al realizar la operacion. No se pudo actualizar el lote destino")
                            End If
                        Else
                            If Not mov.actualizarCantidadLoteTrazabilidadMulti(mov.loteDestino, mov.MovimientoID, mov.lotePartida, True) Then
                                Throw New Exception("Error al realizar la operacion. No se pudo actualizar el lote destino")
                            End If

                            If mov.lotePartida2 > 0 Then
                                If Not mov.actualizarCantidadLoteTrazabilidadMulti(mov.loteDestino, mov.MovimientoID, mov.lotePartida2, True) Then
                                    Throw New Exception("Error al realizar la operacion. No se pudo actualizar el lote destino")
                                End If
                            End If
                        End If
                    Else
                        If Not mov.actualizarCantidadLoteTrazabilidadMulti(mov.loteDestino, mov.MovimientoID, mov.lotePartida, True) Then
                            Throw New Exception("Error al realizar la operacion. No se pudo actualizar el lote destino")
                        End If

                        If mov.lotePartida2 > 0 Then
                            If Not mov.actualizarCantidadLoteTrazabilidadMulti(mov.loteDestino, mov.MovimientoID, mov.lotePartida2, True) Then
                                Throw New Exception("Error al realizar la operacion. No se pudo actualizar el lote destino")
                            End If
                        End If
                    End If
                End If

            Else

                If mov.lotePartida > 0 Then
                    If mov.revertirDepositos Then

                        If Not mov.actualizarValoresLote(mov.lotePartida, mov.MovimientoID) Then
                            Throw New Exception("Error al realizar la operacion. No se pudo actualizar el lote")
                        End If
                    Else

                        If Not mov.actualizarCantidadLote(mov.lotePartida, mov.MovimientoID) Then
                            Throw New Exception("Error al realizar la operacion. No se pudo actualizar el lote")
                        End If

                        If Not mov.actualizarDepositoPrevioLote(mov.lotePartida) Then
                            Throw New Exception("Error al realizar la operacion. No se pudo actualizar el lote")
                        End If
                    End If

                Else
                    Throw New Exception("caso no contemplado, no se podra borrar el movimiento. Contactar con el administrador")
                End If
            End If

            If Not mov.borrarMovimiento(mov.MovimientoID) Then
                Throw New Exception("Error al realizar la operacion. No se pudo borrar el movimiento")
            End If

            mov.TerminarTransaccion()
            Return True
        Catch ex As Exception
            mov.CancelarTransaccion()
            Throw ex
            Return False
        End Try
    End Function

    'Public Sub setValues()
    '    If mov.tieneTrazabilidad(mov.MovimientoID) Then
    '        lLoteDestino.Text = mov.recuperarCodigoLoteTrazabilidad(mov.MovimientoID)
    '        mov.loteDestino = mov.recuperarLoteTrazabilidad(mov.MovimientoID)
    '        mov.trazabilidad = True

    '        mov.movimientoReflexivo = mov.esReflexivo(mov.MovimientoID)

    '        If mov.movimientoReflexivo Then
    '            lBorrarDestinoReflexivo.Visible = True
    '            mov.lotePartida = mov.loteDestino
    '            lLoteOrigen.Text = lLoteDestino.Text
    '        Else
    '            If mov.tieneTrazabilidadMultiLote(mov.MovimientoID) Then
    '                mov.lotePartida2 = mov.recuperarSegundoLotePartidaTrazabilidad(mov.MovimientoID)
    '                lLoteOrigen2.Text = mov.recuperarSegundoCodigoLotePartidaTrazabilidad(mov.MovimientoID)
    '            End If

    '            mov.lotePartida = mov.recuperarLotePartidaTrazabilidad(mov.MovimientoID)
    '            lLoteOrigen.Text = mov.recuperarCodigoLotePartidaTrazabilidad(mov.MovimientoID)

    '            If mov.tieneTrazabilidadLote(mov.loteDestino, mov.MovimientoID) Then
    '                lBorrarDestino.Visible = True
    '            Else
    '                cbBorrarDestino.Visible = True
    '                mov.destinoEliminable = True
    '            End If
    '        End If

    '    Else
    '        lLoteOrigen.Text = mov.recuperarCodigoLoteMovimiento(mov.MovimientoID)
    '        lLoteDestino.Text = lLoteOrigen.Text
    '        mov.loteDestino = mov.recuperarLoteMovimiento(mov.MovimientoID)
    '        mov.lotePartida = mov.loteDestino
    '        mov.trazabilidad = False
    '        lBorrarDestinoTrazabilidad.Visible = True
    '    End If


    '    If mov.lotePartida > 0 Then
    '        cboDeposito.mam_DataSource(mov.devolverDepositos, False, False)
    '        cboDepositoPrevio.mam_DataSource(mov.devolverDepositos, False, False)
    '        Dim depPrev As Integer = mov.seleccionarDepositoPrevio(mov.lotePartida)
    '        Dim dep As Integer = mov.seleccionarDepositoActual(mov.lotePartida)

    '        cboDeposito.SelectedValue = dep
    '        cboDepositoPrevio.SelectedValue = depPrev

    '        mov.depositoOcupado = mov.estaOcupado(depPrev)

    '        If mov.depositoOcupado Then
    '            ldepositoDuplicado.Visible = True
    '        End If

    '        If depPrev > 0 Then
    '            Me.gbDeposito.Enabled = True
    '        End If

    '        If dep = depPrev Then
    '            Me.cbDeposito.Enabled = False
    '        Else
    '            If mov.lotePartida2 > 0 Then
    '                cboDeposito2.mam_DataSource(mov.devolverDepositos, False, False)
    '                cboDepositoPrevio2.mam_DataSource(mov.devolverDepositos, False, False)

    '                depPrev = mov.seleccionarDepositoPrevio(mov.lotePartida2)
    '                dep = mov.seleccionarDepositoActual(mov.lotePartida2)

    '                cboDeposito2.SelectedValue = dep
    '                cboDepositoPrevio2.SelectedValue = depPrev

    '                mov.depositoOcupado2 = mov.estaOcupado(depPrev)

    '                If mov.depositoOcupado Then
    '                    ldepositoDuplicado2.Visible = True
    '                End If

    '                If depPrev > 0 Then
    '                    Me.gbDeposito2.Enabled = True
    '                End If

    '                If dep = depPrev Then
    '                    Me.cbDeposito.Enabled = False
    '                End If
    '            End If
    '        End If

    '    End If
    'End Sub

    Public Sub setValues()
        If mov.tieneTrazabilidad(mov.MovimientoID) Then
            codigoLoteDestino = mov.recuperarCodigoLoteTrazabilidad(mov.MovimientoID)
            mov.loteDestino = mov.recuperarLoteTrazabilidad(mov.MovimientoID)
            mov.trazabilidad = True

            mov.movimientoReflexivo = mov.esReflexivo(mov.MovimientoID)

            If mov.movimientoReflexivo Then
                mov.lotePartida = mov.loteDestino
                codigoLotePartida = codigoLoteDestino
            Else
                If mov.tieneTrazabilidadMultiLote(mov.MovimientoID) Then
                    mov.lotePartida2 = mov.recuperarSegundoLotePartidaTrazabilidad(mov.MovimientoID)
                    codigoLotePartida2 = mov.recuperarSegundoCodigoLotePartidaTrazabilidad(mov.MovimientoID)
                End If

                mov.lotePartida = mov.recuperarLotePartidaTrazabilidad(mov.MovimientoID)
                codigolotepartida = mov.recuperarCodigoLotePartidaTrazabilidad(mov.MovimientoID)

                trazabilidadLote = mov.tieneTrazabilidadLote(mov.loteDestino, mov.MovimientoID)

            End If

        Else
            codigoLotePartida = mov.recuperarCodigoLoteMovimiento(mov.MovimientoID)
            codigoLoteDestino = codigoLotePartida
            mov.loteDestino = mov.recuperarLoteMovimiento(mov.MovimientoID)
            mov.lotePartida = mov.loteDestino
            mov.trazabilidad = False
        End If


        If mov.lotePartida > 0 Then            
            depositoPrevio = mov.seleccionarDepositoPrevio(mov.lotePartida)
            deposito = mov.seleccionarDepositoActual(mov.lotePartida)

            mov.depositoOcupado = mov.estaOcupado(depositoPrevio)

            If deposito <> depositoPrevio Then
                If mov.lotePartida2 > 0 Then
                    depositoPrevio2 = mov.seleccionarDepositoPrevio(mov.lotePartida2)
                    deposito2 = mov.seleccionarDepositoActual(mov.lotePartida2)

                    mov.depositoOcupado2 = mov.estaOcupado(depositoPrevio2)
                End If
            End If
        End If
    End Sub

    Public Sub setGuiValues(ByRef frm As frmResumenBorradoDeposito)
        If mov.trazabilidad Then
            frm.lLoteDestino.Text = codigoLoteDestino

            If mov.movimientoReflexivo Then
                frm.lBorrarDestinoReflexivo.Visible = True
                frm.lLoteOrigen.Text = frm.lLoteDestino.Text
            Else
                If mov.lotePartida2 > 0 Then
                    frm.lLoteOrigen2.Text = codigoLotePartida2
                End If

                frm.lLoteOrigen.Text = codigoLotePartida

                If trazabilidadLote Then
                    frm.lBorrarDestino.Visible = True
                Else
                    frm.cbBorrarDestino.Visible = True
                    mov.destinoEliminable = True
                End If
            End If

        Else
            frm.lLoteOrigen.Text = codigoLotePartida
            frm.lLoteDestino.Text = codigoLotePartida
            frm.lBorrarDestinoTrazabilidad.Visible = True
        End If


        If mov.lotePartida > 0 Then
            frm.cboDeposito.mam_DataSource(mov.devolverDepositos, False, False)
            frm.cboDepositoPrevio.mam_DataSource(mov.devolverDepositos, False, False)            

            frm.cboDeposito.SelectedValue = deposito
            frm.cboDepositoPrevio.SelectedValue = depositoPrevio

            mov.depositoOcupado = mov.estaOcupado(depositoPrevio)

            If mov.depositoOcupado Then
                frm.ldepositoDuplicado.Visible = True
            End If

            If depositoPrevio > 0 Then
                frm.gbDeposito.Enabled = True
            End If

            If deposito = depositoPrevio Then
                frm.cbDeposito.Enabled = False
            Else
                If mov.lotePartida2 > 0 Then
                    frm.cboDeposito2.mam_DataSource(mov.devolverDepositos, False, False)
                    frm.cboDepositoPrevio2.mam_DataSource(mov.devolverDepositos, False, False)

                    frm.cboDeposito2.SelectedValue = deposito2
                    frm.cboDepositoPrevio2.SelectedValue = depositoPrevio2

                    mov.depositoOcupado2 = mov.estaOcupado(depositoPrevio2)

                    If mov.depositoOcupado Then
                        frm.ldepositoDuplicado2.Visible = True
                    End If

                    If depositoPrevio2 > 0 Then
                        frm.gbDeposito2.Enabled = True
                    End If

                    If deposito2 = depositoPrevio2 Then
                        frm.cbDeposito.Enabled = False
                    End If
                End If
            End If

        End If
    End Sub
End Class
