Public Class GuiCorrectorCantidad
    Public ReadOnly Property Cantidad As Double
        Get
            Return Convert.ToDouble(txtCantidad.Text)
        End Get
    End Property

    Public Sub New()
        InitializeComponent()

        Dim filter As New DecimalWatcher(Me.txtCantidad, 0)
    End Sub
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If txtCantidad.Text <> "" Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Hide()
        End If
    End Sub
End Class