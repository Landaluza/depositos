Public Class frmDesecho
    Inherits frmProceso

    Private engineDesecho As Procesos.EngineDesecho

    Public Sub New(ByVal id As Integer)

        InitializeComponent()

        Me.pbIconoOperacion.Image = My.Resources.desecho
        engineDesecho = New Procesos.EngineDesecho(id, Me)

    End Sub
End Class