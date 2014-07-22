Public Class frmDesembote
    Inherits frmProceso

    Private engineDesembote As EngineDesembote

    Public Sub New(ByVal id As Integer)

        InitializeComponent()

        Me.pbIconoOperacion.Image = My.Resources.desembote
        engineDesembote = New EngineDesembote(id, Me)

    End Sub
End Class