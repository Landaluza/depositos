Public Class frmDesembote
    Inherits frmProceso

    Private engineDesembote As Procesos.EngineDesembote

    Public Sub New(ByVal id As Integer)

        InitializeComponent()

        Me.pbIconoOperacion.Image = My.Resources.desembote
        engineDesembote = New Procesos.EngineDesembote(id, Me)

    End Sub
End Class