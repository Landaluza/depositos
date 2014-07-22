Public Class frmDesemboteNC
    Inherits frmProceso

    Private engineDesemboteNC As EngineDesemboteNC

    Public Sub New(ByVal id As Integer)

        InitializeComponent()

        Me.pbIconoOperacion.Image = My.Resources.desembotenc
        EngineDesemboteNC = New EngineDesemboteNC(id, Me)

    End Sub
End Class