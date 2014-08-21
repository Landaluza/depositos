Public Class GuiNuevoMovimiento

    Private Sub btnTrasiego_Click(sender As Object, e As EventArgs) Handles btnTrasiego.Click
        Dim trasiego As New MovimientoTrasiego
        GUImain.añadirPestaña(trasiego.Form)
    End Sub
End Class