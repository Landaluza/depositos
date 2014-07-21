Public Class frmCompra
    Inherits frmProceso

    Private trasiegosEng As EngineCompra

    Public Sub New(ByVal id As Integer)

        InitializeComponent()

        Me.pbIconoOperacion.Image = My.Resources.compra
        trasiegosEng = New EngineCompra(id, Me)

    End Sub
End Class