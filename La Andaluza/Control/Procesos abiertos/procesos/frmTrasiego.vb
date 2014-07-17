Public Class frmTrasiego
    Inherits frmProceso

    Private trasiegosEng As EngineTrasiegos

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal id As Integer)

        InitializeComponent()

        Me.pbIconoOperacion.Image = My.Resources.trasiego
        trasiegosEng = New EngineTrasiegos(id)

    End Sub


    Private Sub frmTrasiego_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        trasiegosEng.setvalues(Me.cboDepositoOrigen, Me.cboDepositoDestino, Me.txtCantidad, Me.cboProducto, cboLote)
    End Sub

    Private Sub autoguardado() Handles cboDepositoDestino.SelectedValueChanged, cboDepositoOrigen.SelectedValueChanged, cboLote.SelectedValueChanged, cboProducto.SelectedValueChanged, txtCantidad.TextChanged
        trasiegosEng.actualizar(Me.cboDepositoOrigen, Me.cboDepositoDestino, Me.txtCantidad, Me.cboProducto, Me.cboLote)
    End Sub
End Class