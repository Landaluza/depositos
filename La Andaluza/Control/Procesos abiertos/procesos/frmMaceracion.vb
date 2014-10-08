Public Class frmMaceracion
    Inherits frmProceso

    Private EngineMaceracion As Procesos.EngineMaceracion

    Public Sub New(ByVal id As Integer)

        InitializeComponent()

        Me.pbIconoOperacion.Image = My.Resources.maceracion
        EngineMaceracion = New Procesos.EngineMaceracion(id, Me)

    End Sub
End Class