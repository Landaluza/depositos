Public Class frmResumenBorradoDeposito
    Private mov As MovimientoDeposito
    Public Sub New(ByVal movimientoid As Integer)

        InitializeComponent()

        mov = New MovimientoDeposito()
        mov.MovimientoID = movimientoid
    End Sub

    Private Sub eliminar()
        mov.revertirDepositos = cbDeposito.Checked
        mov.revertirDepositos2 = cbDeposito2.Checked
        mov.eliminarDestino = cbBorrarDestino.Checked

        mov.EmpezarTransaccion()

        Try


            If mov.trazabilidad Then
                If mov.movimientoReflexivo Then

                    If mov.movimientoReflexivoEntreDepositos Then
                        If mov.revertirDepositos Then
                            If Not mov.actualizarDepositoLote(mov.lotePartida) Then
                                mov.CancelarTransaccion()
                                MessageBox.Show("Error al realizar la operacion. No se pudo actualizar el lote", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Exit Sub
                            End If
                        End If
                    Else

                        If Not mov.actualizarCantidadLote(mov.lotePartida, mov.MovimientoID) Then
                            mov.CancelarTransaccion()
                            MessageBox.Show("Error al realizar la operacion. No se pudo actualizar el lote", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End If
                    End If

                Else
                    If mov.revertirDepositos Then
                        If Not mov.actualizarValoresLote(mov.lotePartida, mov.MovimientoID) Then
                            mov.CancelarTransaccion()
                            MessageBox.Show("Error al realizar la operacion. No se pudo actualizar el lote", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End If

                    Else
                        If Not mov.actualizarCantidadLote(mov.lotePartida, mov.MovimientoID) Then
                            mov.CancelarTransaccion()
                            MessageBox.Show("Error al realizar la operacion. No se pudo actualizar el lote", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End If
                    End If

                    If Not mov.borrarTrazabilidad(mov.lotePartida, mov.MovimientoID) Then
                        mov.CancelarTransaccion()
                        MessageBox.Show("Error al realizar la operacion. No se pudo actualizar el lote", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If

                    If mov.lotePartida2 > 0 Then
                        If mov.revertirDepositos2 Then
                            If Not mov.actualizarValoresLote(mov.lotePartida2, mov.MovimientoID) Then
                                mov.CancelarTransaccion()
                                MessageBox.Show("Error al realizar la operacion. No se pudo actualizar el lote", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Exit Sub
                            End If

                        Else
                            If Not mov.actualizarCantidadLote(mov.lotePartida2, mov.MovimientoID) Then
                                mov.CancelarTransaccion()
                                MessageBox.Show("Error al realizar la operacion. No se pudo actualizar el lote", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Exit Sub
                            End If
                        End If

                        If Not mov.borrarTrazabilidad(mov.lotePartida2, mov.MovimientoID) Then
                            mov.CancelarTransaccion()
                            MessageBox.Show("Error al realizar la operacion. No se pudo actualizar el lote", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End If
                    End If

                    If mov.destinoEliminable Then
                        If mov.eliminarDestino Then
                            If Not mov.borrarLote(mov.loteDestino) Then
                                mov.CancelarTransaccion()
                                MessageBox.Show("Error al realizar la operacion. No se pudo actualizar el lote destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Exit Sub
                            End If
                        Else
                            If Not mov.actualizarCantidadLote(mov.loteDestino, mov.MovimientoID, True) Then
                                mov.CancelarTransaccion()
                                MessageBox.Show("Error al realizar la operacion. No se pudo actualizar el lote destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Exit Sub
                            End If
                        End If
                    Else
                        If Not mov.actualizarCantidadLote(mov.loteDestino, mov.MovimientoID, True) Then
                            mov.CancelarTransaccion()
                            MessageBox.Show("Error al realizar la operacion. No se pudo actualizar el lote destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End If
                    End If
                End If

            Else

                If mov.lotePartida > 0 Then
                    If mov.revertirDepositos Then

                        If Not mov.actualizarValoresLote(mov.lotePartida, mov.MovimientoID) Then
                            mov.CancelarTransaccion()
                            MessageBox.Show("Error al realizar la operacion. No se pudo actualizar el lote", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End If
                    Else

                        If Not mov.actualizarCantidadLote(mov.lotePartida, mov.MovimientoID) Then
                            mov.CancelarTransaccion()
                            MessageBox.Show("Error al realizar la operacion. No se pudo actualizar el lote", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End If

                        If Not mov.actualizarDepositoPrevioLote(mov.lotePartida) Then
                            mov.CancelarTransaccion()
                            MessageBox.Show("Error al realizar la operacion. No se pudo actualizar el lote", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End If
                    End If

                Else
                    mov.CancelarTransaccion()
                    MessageBox.Show("caso no contemplado, no se podra borrar el movimiento. Contactar con el administrador", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            End If

            If Not mov.borrarMovimiento(mov.MovimientoID) Then
                mov.CancelarTransaccion()
                MessageBox.Show("Error al realizar la operacion. No se pudo borrar el movimiento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            mov.TerminarTransaccion()
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            mov.CancelarTransaccion()
            MessageBox.Show("Error al realizar la operacion. Detalles:" & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub setValues()

        If mov.tieneTrazabilidad(mov.MovimientoID) Then
            lLoteDestino.Text = mov.recuperarCodigoLoteTrazabilidad(mov.MovimientoID)
            mov.loteDestino = mov.recuperarLoteTrazabilidad(mov.MovimientoID)
            mov.trazabilidad = True

            mov.movimientoReflexivo = mov.esReflexivo(mov.MovimientoID)

            If mov.movimientoReflexivo Then
                lBorrarDestinoReflexivo.Visible = True
                mov.lotePartida = mov.loteDestino
                lLoteOrigen.Text = lLoteDestino.Text
            Else
                If mov.tieneTrazabilidadMultiLote(mov.MovimientoID) Then
                    mov.lotePartida2 = mov.recuperarSegundoLotePartidaTrazabilidad(mov.MovimientoID)
                    lLoteOrigen2.Text = mov.recuperarSegundoCodigoLotePartidaTrazabilidad(mov.MovimientoID)
                End If

                mov.lotePartida = mov.recuperarLotePartidaTrazabilidad(mov.MovimientoID)
                lLoteOrigen.Text = mov.recuperarCodigoLotePartidaTrazabilidad(mov.MovimientoID)

                If mov.tieneTrazabilidadLote(mov.loteDestino, mov.MovimientoID) Then
                    lBorrarDestino.Visible = True
                Else
                    cbBorrarDestino.Visible = True
                    mov.destinoEliminable = True
                End If
            End If

        Else
            lLoteOrigen.Text = mov.recuperarCodigoLoteMovimiento(mov.MovimientoID)
            lLoteDestino.Text = lLoteOrigen.Text
            mov.loteDestino = mov.recuperarLoteMovimiento(mov.MovimientoID)
            mov.lotePartida = mov.loteDestino
            mov.trazabilidad = False
            lBorrarDestinoTrazabilidad.Visible = True
        End If


        If mov.lotePartida > 0 Then
            cboDeposito.mam_DataSource(mov.devolverDepositos, False, False)
            cboDepositoPrevio.mam_DataSource(mov.devolverDepositos, False, False)
            Dim depPrev As Integer = mov.seleccionarDepositoPrevio(mov.lotePartida)
            Dim dep As Integer = mov.seleccionarDepositoActual(mov.lotePartida)

            cboDeposito.SelectedValue = dep
            cboDepositoPrevio.SelectedValue = depPrev

            mov.depositoOcupado = mov.estaOcupado(depPrev)

            If mov.depositoOcupado Then
                ldepositoDuplicado.Visible = True
            End If

            If depPrev > 0 Then
                Me.gbDeposito.Enabled = True
            End If

            If dep = depPrev Then
                Me.cbDeposito.Enabled = False
            Else
                If mov.lotePartida2 > 0 Then
                    cboDeposito2.mam_DataSource(mov.devolverDepositos, False, False)
                    cboDepositoPrevio2.mam_DataSource(mov.devolverDepositos, False, False)

                    depPrev = mov.seleccionarDepositoPrevio(mov.lotePartida2)
                    dep = mov.seleccionarDepositoActual(mov.lotePartida2)

                    cboDeposito2.SelectedValue = dep
                    cboDepositoPrevio2.SelectedValue = depPrev

                    mov.depositoOcupado2 = mov.estaOcupado(depPrev)

                    If mov.depositoOcupado Then
                        ldepositoDuplicado2.Visible = True
                    End If

                    If depPrev > 0 Then
                        Me.gbDeposito2.Enabled = True
                    End If

                    If dep = depPrev Then
                        Me.cbDeposito.Enabled = False
                    End If
                End If
            End If

        End If
    End Sub
    Private Sub frmResumenBorradoDeposito_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        setValues()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.eliminar()
    End Sub
End Class