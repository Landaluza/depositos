Public Class MovimientoDepositoEngine
    'Private codigoLotePartida As String
    'Private codigoLotePartida2 As String
    'Private codigoLoteDestino As String
    'Private deposito As Integer
    'Private depositoPrevio As Integer
    'Private deposito2 As Integer
    'Private depositoPrevio2 As Integer
    'Private trazabilidadLote As Boolean


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
    '                        If Not mov.actualizarDepositoLote(mov.lotePartida.ID) Then
    '                            mov.CancelarTransaccion()
    '                            MessageBox.Show("Error al realizar la operacion. No se pudo actualizar el lote", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                            Exit Function
    '                        End If
    '                    End If
    '                Else

    '                    If Not mov.actualizarCantidadLote(mov.lotePartida.ID, mov.MovimientoID) Then
    '                        mov.CancelarTransaccion()
    '                        MessageBox.Show("Error al realizar la operacion. No se pudo actualizar el lote", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                        Exit Function
    '                    End If
    '                End If

    '            Else
    '                If mov.revertirDepositos Then
    '                    If Not mov.actualizarValoresLote(mov.lotePartida.ID, mov.MovimientoID) Then
    '                        mov.CancelarTransaccion()
    '                        MessageBox.Show("Error al realizar la operacion. No se pudo actualizar el lote", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                        Exit Function
    '                    End If

    '                Else
    '                    If Not mov.actualizarCantidadLoteTrazabilidadMulti(mov.lotePartida.ID, mov.MovimientoID, mov.lotePartida.ID) Then
    '                        mov.CancelarTransaccion()
    '                        MessageBox.Show("Error al realizar la operacion. No se pudo actualizar el lote", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                        Exit Function
    '                    End If
    '                End If

    '                If Not mov.borrarTrazabilidad(mov.lotePartida.ID, mov.MovimientoID) Then
    '                    mov.CancelarTransaccion()
    '                    MessageBox.Show("Error al realizar la operacion. No se pudo actualizar el lote", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                    Exit Function
    '                End If

    '                If mov.lotePartida2.ID > 0 Then
    '                    If mov.revertirDepositos2 Then
    '                        If Not mov.actualizarValoresLote(mov.lotePartida2.ID, mov.MovimientoID) Then
    '                            mov.CancelarTransaccion()
    '                            MessageBox.Show("Error al realizar la operacion. No se pudo actualizar el lote", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                            Exit Function
    '                        End If

    '                    Else
    '                        If Not mov.actualizarCantidadLoteTrazabilidadMulti(mov.lotePartida2.ID, mov.MovimientoID, mov.lotePartida2.ID) Then
    '                            mov.CancelarTransaccion()
    '                            MessageBox.Show("Error al realizar la operacion. No se pudo actualizar el lote", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                            Exit Function
    '                        End If
    '                    End If

    '                    If Not mov.borrarTrazabilidad(mov.lotePartida2.ID, mov.MovimientoID) Then
    '                        mov.CancelarTransaccion()
    '                        MessageBox.Show("Error al realizar la operacion. No se pudo actualizar el lote", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                        Exit Function
    '                    End If
    '                End If

    '                If mov.destinoEliminable Then
    '                    If mov.eliminarDestino Then
    '                        If Not mov.borrarLote(mov.loteDestinoID) Then
    '                            mov.CancelarTransaccion()
    '                            MessageBox.Show("Error al realizar la operacion. No se pudo actualizar el lote destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                            Exit Function
    '                        End If
    '                    Else
    '                        If Not mov.actualizarCantidadLoteTrazabilidadMulti(mov.loteDestinoID, mov.MovimientoID, mov.lotePartida.ID, True) Then
    '                            mov.CancelarTransaccion()
    '                            MessageBox.Show("Error al realizar la operacion. No se pudo actualizar el lote destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                            Exit Function
    '                        End If

    '                        If mov.lotePartida2.ID > 0 Then
    '                            If Not mov.actualizarCantidadLoteTrazabilidadMulti(mov.loteDestinoID, mov.MovimientoID, mov.lotePartida2.ID, True) Then
    '                                mov.CancelarTransaccion()
    '                                MessageBox.Show("Error al realizar la operacion. No se pudo actualizar el lote destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                                Exit Function
    '                            End If
    '                        End If
    '                    End If
    '                Else
    '                    If Not mov.actualizarCantidadLoteTrazabilidadMulti(mov.loteDestinoID, mov.MovimientoID, mov.lotePartida.ID, True) Then
    '                        mov.CancelarTransaccion()
    '                        MessageBox.Show("Error al realizar la operacion. No se pudo actualizar el lote destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                        Exit Function
    '                    End If

    '                    If mov.lotePartida2.ID > 0 Then
    '                        If Not mov.actualizarCantidadLoteTrazabilidadMulti(mov.loteDestinoID, mov.MovimientoID, mov.lotePartida2.ID, True) Then
    '                            mov.CancelarTransaccion()
    '                            MessageBox.Show("Error al realizar la operacion. No se pudo actualizar el lote destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                            Exit Function
    '                        End If
    '                    End If
    '                End If
    '            End If

    '        Else

    '            If mov.lotePartida.ID > 0 Then
    '                If mov.revertirDepositos Then

    '                    If Not mov.actualizarValoresLote(mov.lotePartida.ID, mov.MovimientoID) Then
    '                        mov.CancelarTransaccion()
    '                        MessageBox.Show("Error al realizar la operacion. No se pudo actualizar el lote", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                        Exit Function
    '                    End If
    '                Else

    '                    If Not mov.actualizarCantidadLote(mov.lotePartida.ID, mov.MovimientoID) Then
    '                        mov.CancelarTransaccion()
    '                        MessageBox.Show("Error al realizar la operacion. No se pudo actualizar el lote", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                        Exit Function
    '                    End If

    '                    If Not mov.actualizarDepositoPrevioLote(mov.lotePartida.ID) Then
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
        mov.lotePartida.revertirDepositos = revertirDepositos
        mov.lotePartida2.revertirDepositos = revertirDepositos2
        mov.eliminarDestino = borrardestino

        mov.EmpezarTransaccion()

        Try

            If mov.trazabilidad Then
                If Not mov.borrarTrazabilidad(mov.lotePartida.Id, mov.MovimientoID) Then
                    Throw New Exception("Error al realizar la operacion. No se pudo actualizar el lote")
                End If

                If mov.movimientoReflexivo Then

                    If mov.movimientoReflexivoEntreDepositos Then
                        If mov.lotePartida.revertirDepositos Then
                            If Not mov.actualizarDepositoLote(mov.lotePartida.Id) Then
                                Throw New Exception("Error al realizar la operacion. No se pudo actualizar el lote")
                            End If
                        End If
                    Else

                        If Not mov.actualizarCantidadLote(mov.lotePartida.Id, mov.MovimientoID) Then
                            Throw New Exception("Error al realizar la operacion. No se pudo actualizar el lote")
                        End If
                    End If

                Else
                    If mov.lotePartida.revertirDepositos Then
                        If Not mov.actualizarValoresLote(mov.lotePartida.Id, mov.MovimientoID) Then
                            Throw New Exception("Error al realizar la operacion. No se pudo actualizar el lote")
                        End If

                    Else
                        If Not mov.actualizarCantidadLoteTrazabilidadMulti(mov.lotePartida.Id, mov.MovimientoID, mov.lotePartida.Id) Then
                            Throw New Exception("Error al realizar la operacion. No se pudo actualizar el lote")
                        End If
                    End If

                    'If Not mov.borrarTrazabilidad(mov.lotePartida.Id, mov.MovimientoID) Then
                    '    Throw New Exception("Error al realizar la operacion. No se pudo actualizar el lote")
                    'End If

                    If mov.lotePartida2.Id > 0 Then
                        If mov.lotePartida2.revertirDepositos Then
                            If Not mov.actualizarValoresLote(mov.lotePartida2.Id, mov.MovimientoID) Then
                                Throw New Exception("Error al realizar la operacion. No se pudo actualizar el lote")
                            End If

                        Else
                            If Not mov.actualizarCantidadLoteTrazabilidadMulti(mov.lotePartida2.Id, mov.MovimientoID, mov.lotePartida2.Id) Then
                                Throw New Exception("Error al realizar la operacion. No se pudo actualizar el lote")
                            End If
                        End If

                        If Not mov.borrarTrazabilidad(mov.lotePartida2.Id, mov.MovimientoID) Then
                            Throw New Exception("Error al realizar la operacion. No se pudo actualizar el lote")
                        End If
                    End If

                    If mov.loteDestino.eliminable Then
                        If mov.eliminarDestino Then
                            If Not mov.borrarLote(mov.loteDestino.Id) Then
                                Throw New Exception("Error al realizar la operacion. No se pudo actualizar el lote destino")
                            End If
                        Else
                            If Not mov.actualizarCantidadLoteTrazabilidadMulti(mov.loteDestino.Id, mov.MovimientoID, mov.lotePartida.Id, True) Then
                                Throw New Exception("Error al realizar la operacion. No se pudo actualizar el lote destino")
                            End If

                            If mov.lotePartida2.Id > 0 Then
                                If Not mov.actualizarCantidadLoteTrazabilidadMulti(mov.loteDestino.Id, mov.MovimientoID, mov.lotePartida2.Id, True) Then
                                    Throw New Exception("Error al realizar la operacion. No se pudo actualizar el lote destino")
                                End If
                            End If
                        End If
                    Else
                        If Not mov.actualizarCantidadLoteTrazabilidadMulti(mov.loteDestino.Id, mov.MovimientoID, mov.lotePartida.Id, True) Then
                            Throw New Exception("Error al realizar la operacion. No se pudo actualizar el lote destino")
                        End If

                        If mov.lotePartida2.Id > 0 Then
                            If Not mov.actualizarCantidadLoteTrazabilidadMulti(mov.loteDestino.Id, mov.MovimientoID, mov.lotePartida2.Id, True) Then
                                Throw New Exception("Error al realizar la operacion. No se pudo actualizar el lote destino")
                            End If
                        End If
                    End If
                End If

            Else

                If mov.lotePartida.Id > 0 Then
                    If mov.lotePartida.revertirDepositos Then

                        If Not mov.actualizarValoresLote(mov.lotePartida.Id, mov.MovimientoID) Then
                            Throw New Exception("Error al realizar la operacion. No se pudo actualizar el lote")
                        End If
                    Else

                        If Not mov.actualizarCantidadLote(mov.lotePartida.Id, mov.MovimientoID) Then
                            Throw New Exception("Error al realizar la operacion. No se pudo actualizar el lote")
                        End If

                        If Not mov.actualizarDepositoPrevioLote(mov.lotePartida.Id) Then
                            Throw New Exception("Error al realizar la operacion. No se pudo actualizar el lote")
                        End If
                    End If

                    'si no fuera el caso seria un movimiento donde no existe ningun tipo de trazabilidad y se puede borrar
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
    '        lmov.loteDestino.Text = mov.recuperarCodigoLoteTrazabilidad(mov.MovimientoID)
    '        mov.loteDestinoID = mov.recuperarLoteTrazabilidad(mov.MovimientoID)
    '        mov.trazabilidad = True

    '        mov.movimientoReflexivo = mov.esReflexivo(mov.MovimientoID)

    '        If mov.movimientoReflexivo Then
    '            lBorrarDestinoReflexivo.Visible = True
    '            mov.lotePartida.ID = mov.loteDestinoID
    '            lLoteOrigen.Text = lmov.loteDestino.Text
    '        Else
    '            If mov.tieneTrazabilidadMultiLote(mov.MovimientoID) Then
    '                mov.lotePartida2.ID = mov.recuperarSegundoLotePartidaTrazabilidad(mov.MovimientoID)
    '                lLoteOrigen2.Text = mov.recuperarSegundoCodigoLotePartidaTrazabilidad(mov.MovimientoID)
    '            End If

    '            mov.lotePartida.ID = mov.recuperarLotePartidaTrazabilidad(mov.MovimientoID)
    '            lLoteOrigen.Text = mov.recuperarCodigoLotePartidaTrazabilidad(mov.MovimientoID)

    '            If mov.tieneTrazabilidadLote(mov.loteDestinoID, mov.MovimientoID) Then
    '                lBorrarDestino.Visible = True
    '            Else
    '                cbBorrarDestino.Visible = True
    '                mov.destinoEliminable = True
    '            End If
    '        End If

    '    Else
    '        lLoteOrigen.Text = mov.recuperarCodigoLoteMovimiento(mov.MovimientoID)
    '        lmov.loteDestino.Text = lLoteOrigen.Text
    '        mov.loteDestinoID = mov.recuperarLoteMovimiento(mov.MovimientoID)
    '        mov.lotePartida.ID = mov.loteDestinoID
    '        mov.trazabilidad = False
    '        lBorrarDestinoTrazabilidad.Visible = True
    '    End If


    '    If mov.lotePartida.ID > 0 Then
    '        cboDeposito.mam_DataSource(mov.devolverDepositos, False, False)
    '        cboDepositoPrevio.mam_DataSource(mov.devolverDepositos, False, False)
    '        Dim depPrev As Integer = mov.seleccionarDepositoPrevio(mov.lotePartida.ID)
    '        Dim dep As Integer = mov.seleccionarDepositoActual(mov.lotePartida.ID)

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
    '            If mov.lotePartida2.ID > 0 Then
    '                cboDeposito2.mam_DataSource(mov.devolverDepositos, False, False)
    '                cboDepositoPrevio2.mam_DataSource(mov.devolverDepositos, False, False)

    '                depPrev = mov.seleccionarDepositoPrevio(mov.lotePartida2.ID)
    '                dep = mov.seleccionarDepositoActual(mov.lotePartida2.ID)

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
            mov.loteDestino.codigoLote = mov.recuperarCodigoLoteTrazabilidad(mov.MovimientoID)
            mov.loteDestino.Id = mov.recuperarLoteTrazabilidad(mov.MovimientoID)
            mov.trazabilidad = True

            mov.movimientoReflexivo = mov.esReflexivo(mov.MovimientoID)

            If mov.movimientoReflexivo Then
                mov.lotePartida.ID = mov.loteDestino.Id
                mov.lotePartida.codigoLote = mov.loteDestino.codigoLote
            Else
                If mov.tieneTrazabilidadMultiLote(mov.MovimientoID) Then
                    mov.lotePartida2.ID = mov.recuperarSegundoLotePartidaTrazabilidad(mov.MovimientoID)
                    mov.lotePartida2.codigoLote = mov.recuperarSegundoCodigoLotePartidaTrazabilidad(mov.MovimientoID)
                End If

                mov.lotePartida.ID = mov.recuperarLotePartidaTrazabilidad(mov.MovimientoID)
                mov.lotePartida.codigoLote = mov.recuperarCodigoLotePartidaTrazabilidad(mov.MovimientoID)

                mov.loteDestino.trazabilidadLote = mov.tieneTrazabilidadLote(mov.loteDestino.Id, mov.MovimientoID)

            End If

        Else
            mov.lotePartida.codigoLote = mov.recuperarCodigoLoteMovimiento(mov.MovimientoID)
            mov.loteDestino.codigoLote = mov.lotePartida.codigoLote
            mov.loteDestino.Id = mov.recuperarLoteMovimiento(mov.MovimientoID)
            mov.lotePartida.ID = mov.loteDestino.Id
            mov.trazabilidad = False
        End If


        If mov.lotePartida.ID > 0 Then
            mov.lotePartida.depositoPrevio = mov.seleccionarDepositoPrevio(mov.lotePartida.ID)
            mov.lotePartida.deposito = mov.seleccionarDepositoActual(mov.lotePartida.ID)

            mov.lotePartida.depositoOcupado = mov.estaOcupado(mov.lotePartida.depositoPrevio)

            If mov.lotePartida.depositoPrevio <> mov.lotePartida.deposito Then
                If mov.lotePartida2.ID > 0 Then
                    mov.lotePartida2.depositoPrevio = mov.seleccionarDepositoPrevio(mov.lotePartida2.ID)
                    mov.lotePartida2.depositoPrevio = mov.seleccionarDepositoActual(mov.lotePartida2.ID)

                    mov.lotePartida2.depositoOcupado = mov.estaOcupado(mov.lotePartida2.depositoPrevio)
                End If
            End If
        End If
    End Sub

    Public Sub setGuiValues(ByRef frm As frmResumenBorradoDeposito)
        If mov.trazabilidad Then
            frm.lLoteDestino.Text = mov.loteDestino.codigoLote

            If mov.movimientoReflexivo Then
                frm.lBorrarDestinoReflexivo.Visible = True
                frm.lLoteOrigen.Text = frm.lLoteDestino.Text
            Else
                If mov.lotePartida2.ID > 0 Then
                    frm.lLoteOrigen2.Text = mov.lotePartida2.codigoLote
                End If

                frm.lLoteOrigen.Text = mov.lotePartida.codigoLote

                If mov.loteDestino.trazabilidadLote Then
                    frm.lBorrarDestino.Visible = True
                Else
                    frm.cbBorrarDestino.Visible = True
                    mov.loteDestino.eliminable = True
                End If
            End If

        Else
            frm.lLoteOrigen.Text = mov.lotePartida.codigoLote
            frm.lLoteDestino.Text = mov.loteDestino.codigoLote
            frm.lBorrarDestinoTrazabilidad.Visible = True
        End If


        If mov.lotePartida.ID > 0 Then
            frm.cboDeposito.mam_DataSource(mov.devolverDepositos, False, False)
            frm.cboDepositoPrevio.mam_DataSource(mov.devolverDepositos, False, False)

            frm.cboDeposito.SelectedValue = mov.lotePartida.deposito
            frm.cboDepositoPrevio.SelectedValue = mov.lotePartida.depositoPrevio

            mov.lotePartida.depositoOcupado = mov.estaOcupado(mov.lotePartida.depositoPrevio)

            If mov.lotePartida.depositoOcupado Then
                frm.ldepositoDuplicado.Visible = True
            End If

            If mov.lotePartida.depositoPrevio > 0 Then
                frm.gbDeposito.Enabled = True
            End If

            If mov.lotePartida.depositoPrevio = mov.lotePartida.deposito Then
                frm.cbDeposito.Enabled = False
            Else
                If mov.lotePartida2.ID > 0 Then
                    frm.cboDeposito2.mam_DataSource(mov.devolverDepositos, False, False)
                    frm.cboDepositoPrevio2.mam_DataSource(mov.devolverDepositos, False, False)

                    frm.cboDeposito2.SelectedValue = mov.lotePartida2.deposito
                    frm.cboDepositoPrevio2.SelectedValue = mov.lotePartida2.depositoPrevio

                    mov.lotePartida2.depositoOcupado = mov.estaOcupado(mov.lotePartida2.depositoPrevio)

                    If mov.lotePartida.depositoOcupado Then
                        frm.ldepositoDuplicado2.Visible = True
                    End If

                    If mov.lotePartida2.depositoPrevio > 0 Then
                        frm.gbDeposito2.Enabled = True
                    End If

                    If mov.lotePartida2.depositoPrevio = mov.lotePartida2.depositoPrevio Then
                        frm.cbDeposito.Enabled = False
                    End If
                End If
            End If

        End If
    End Sub
End Class
