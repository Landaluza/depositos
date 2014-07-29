Public Class frmResumenBorradoDeposito

    Private engine As MovimientoDepositoEngine

    Public Sub New(ByVal movimientoid As Integer)

        InitializeComponent()

        engine = New MovimientoDepositoEngine(movimientoid)
    End Sub

    


    Public Sub eliminar()
        If engine.eliminar(cbDeposito.Checked, cbDeposito2.Checked, cbBorrarDestino.Checked) Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Public Sub setValues()

        engine.setGuiValues(Me)
    End Sub
    Private Sub frmResumenBorradoDeposito_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        setValues()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.eliminar()
    End Sub
End Class