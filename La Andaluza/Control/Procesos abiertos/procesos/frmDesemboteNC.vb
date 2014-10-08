Public Class frmDesemboteNC
    Inherits frmProceso

    Private engineDesemboteNC As Procesos.EngineDesemboteNC

    Public Sub New(ByVal id As Integer)

        InitializeComponent()

        Me.pbIconoOperacion.Image = My.Resources.desembotenc
        engineDesemboteNC = New Procesos.EngineDesemboteNC(id, Me)

    End Sub
End Class