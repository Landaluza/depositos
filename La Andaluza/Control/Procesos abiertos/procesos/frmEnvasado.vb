Public Class frmEnvasado
    Inherits frmProceso

    Private EngineEnvasado As Procesos.EngineEnvasado

    Public Sub New(ByVal id As Integer)

        InitializeComponent()

        Me.pbIconoOperacion.Image = My.Resources.envasado
        EngineEnvasado = New Procesos.EngineEnvasado(id, Me)

    End Sub
End Class