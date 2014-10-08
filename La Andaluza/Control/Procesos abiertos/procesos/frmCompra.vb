Public Class frmCompra
    Inherits frmProceso

    Private EngineCompra As Procesos.EngineCompra

    Public Sub New(ByVal id As Integer)

        InitializeComponent()

        Me.pbIconoOperacion.Image = My.Resources.compra
        EngineCompra = New Procesos.EngineCompra(id, Me)

    End Sub
End Class