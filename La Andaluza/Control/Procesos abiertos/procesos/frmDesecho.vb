Public Class frmDesecho
    Inherits frmProceso

    Private engineDesecho As EngineDesecho

    Public Sub New(ByVal id As Integer)

        InitializeComponent()

        Me.pbIconoOperacion.Image = My.Resources.desecho
        engineDesecho = New EngineDesecho(id, Me)

    End Sub
End Class