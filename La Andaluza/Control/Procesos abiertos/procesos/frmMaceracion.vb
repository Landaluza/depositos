Public Class frmMaceracion
    Inherits frmProceso

    Private EngineMaceracion As EngineMaceracion

    Public Sub New(ByVal id As Integer)

        InitializeComponent()

        Me.pbIconoOperacion.Image = My.Resources.maceracion
        EngineMaceracion = New EngineMaceracion(id, Me)

    End Sub
End Class