Public Class frmTrasiego
    Inherits frmProceso

    Private trasiegosEng As EngineTrasiegos
    Public Sub New()

        InitializeComponent()

        Me.pbIconoOperacion.Image = My.Resources.trasiego
        trasiegosEng = New EngineTrasiegos

    End Sub


    Private Sub frmTrasiego_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        trasiegosEng.setvalues(Me.cboDepositoOrigen, Me.cboDepositoDestino, Me.txtCantidad, Me.cboProducto, cboLote)
    End Sub
End Class