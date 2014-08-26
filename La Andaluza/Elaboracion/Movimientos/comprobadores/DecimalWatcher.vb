Public Class DecimalWatcher
    Inherits Watcher
    Public Sub New(ByRef control As TextBox)
        Me.control = control
        Me.filtro = "1234567890."
        AddHandler Me.control.KeyPress, AddressOf comprobar
    End Sub

    Private Sub comprobar(sender As Object, e As KeyPressEventArgs)
        If Not Me.filtro.Contains(e.KeyChar) Then
            e.Handled = True
            Return
        End If
    End Sub
End Class
