Public Class frmTrasiego
    Inherits frmProceso

    Private trasiegosEng As Procesos.EngineTrasiegos

    Public Sub New(ByVal id As Integer)

        InitializeComponent()

        Me.pbIconoOperacion.Image = My.Resources.trasiego
        trasiegosEng = New Procesos.EngineTrasiegos(id, Me)

    End Sub

End Class