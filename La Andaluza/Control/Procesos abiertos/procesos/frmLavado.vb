Public Class frmLavado
    Inherits frmProceso

    Private engineLavado As EngineLavado

    Public Sub New(ByVal id As Integer)

        InitializeComponent()

        Me.pbIconoOperacion.Image = My.Resources.lavado
        engineLavado = New EngineLavado(id, Me)

    End Sub
End Class