Public Class GuiNuevoMovimiento

    Private Sub btnTrasiego_Click(sender As Object, e As EventArgs) Handles btnTrasiego.Click
        Dim frm As New GuiTrasiego
        GUImain.añadirPestaña(CType(frm, Form))
    End Sub
End Class