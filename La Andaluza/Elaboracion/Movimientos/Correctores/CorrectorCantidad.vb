Public Class CorrectorCantidad
    Private gui As GuiCorrectorCantidad
    Private bdcorrector As BdCorrector
    Public Sub New(ByVal loteID As Integer)
        bdcorrector = New BdCorrector
        gui = New GuiCorrectorCantidad

        'If gui.ShowDialog = DialogResult.OK Then
        If Pantalla.mostrarDialogo(gui) = DialogResult.OK Then
            Try
                If Not bdcorrector.guardarCantidad(loteID, gui.Cantidad) Then
                    MessageBox.Show("No se pudo guardar la nueva cantidad", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("No se pudo guardar la nueva cantidad. Detalles: " & ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

  
End Class
