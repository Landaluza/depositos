Public Class DecimalWatcher
    Inherits Watcher
    Private minimo As Double
    Private maximo As Double
    Public Sub New(ByRef control As TextBox, Optional ByVal minimo As Double = -4.0R, Optional ByVal maximo As Double = 4.0R)
        MyBase.New(CType(control, Control))

        Me.filtro = "1234567890."
        Me.minimo = minimo
        Me.maximo = maximo
        AddHandler Me.control.KeyPress, AddressOf comprobar
        AddHandler Me.control.KeyUp, AddressOf comprobarContenido
    End Sub

    Private Sub comprobar(sender As Object, e As KeyPressEventArgs)
        If Not Me.filtro.Contains(e.KeyChar) And Asc(e.KeyChar) <> Keys.Delete Then
            e.Handled = True
            Return
        End If
    End Sub

    Private Sub comprobarContenido(sender As Object, e As KeyEventArgs)


        If Convert.ToDouble(control.Text) <= minimo Then
            control.BackColor = Color.Red
            tooltip.SetToolTip(control, "El valor minimo es " & minimo)
        Else
            control.BackColor = backcolor
            tooltip.SetToolTip(control, "valor correcto")
        End If
    End Sub
End Class
