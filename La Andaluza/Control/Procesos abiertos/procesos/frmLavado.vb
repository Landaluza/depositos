Public Class frmLavado
    Inherits frmProceso

    Private engineLavado As Procesos.EngineLavado

    Public Sub New(ByVal id As Integer)

        InitializeComponent()

        Me.pbIconoOperacion.Image = My.Resources.lavado
        engineLavado = New Procesos.EngineLavado(id, Me)

    End Sub
End Class