Public Class frmCompra
    Inherits frmProceso

    Private EngineCompra As EngineCompra

    Public Sub New(ByVal id As Integer)

        InitializeComponent()

        Me.pbIconoOperacion.Image = My.Resources.compra
        EngineCompra = New EngineCompra(id, Me)

    End Sub
End Class