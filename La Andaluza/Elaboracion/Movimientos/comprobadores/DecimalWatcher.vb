Public Class DecimalWatcher
    Inherits Watcher
    Private minimo As Double
    Private maximo As Double
    'Private formatstr As String
    'Private nfi As System.Globalization.NumberFormatInfo
    Public Sub New(ByRef control As TextBox, Optional ByVal minimo As Double = -1.7976931348623157 * 10 ^ 308, Optional ByVal maximo As Double = 1.7976931348623157 * 10 ^ 308)
        MyBase.New(CType(control, Control))

        Me.filtro = "1234567890-."
        Me.minimo = minimo
        Me.maximo = maximo
        AddHandler Me.control.KeyPress, AddressOf comprobar
        AddHandler Me.control.KeyUp, AddressOf comprobarContenido
        'formatstr = "N2"
        'nfi = New System.Globalization.CultureInfo("es-ES", False).NumberFormat
    End Sub

    Private Sub comprobar(sender As Object, e As KeyPressEventArgs)
        If Not Me.filtro.Contains(e.KeyChar) And Asc(e.KeyChar) <> Keys.Delete And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> Keys.OemMinus Then
            e.Handled = True
            Return
        End If

        'Dim d As Double = Convert.ToDouble(Me.control.Text)
        'Me.control.Text = d.ToString(formatstr, nfi)
    End Sub

    Private Sub comprobarContenido(sender As Object, e As KeyEventArgs)

        If control.Text = "" Then
            control.BackColor = Color.Red
            tooltip.SetToolTip(control, "El valor debe estar comprendido entre " & minimo & " y " & maximo)
        ElseIf Convert.ToDouble(control.Text) <= minimo Then
            control.BackColor = Color.Red
            tooltip.SetToolTip(control, "El valor debe estar comprendido entre " & minimo & " y " & maximo)
        ElseIf Convert.ToDouble(control.Text) >= maximo Then
            control.BackColor = Color.Red
            tooltip.SetToolTip(control, "El valor debe estar comprendido entre " & minimo & " y " & maximo)
        Else
            control.BackColor = backcolor
            tooltip.SetToolTip(control, "valor correcto")
        End If
    End Sub
End Class
