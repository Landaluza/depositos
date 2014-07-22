Public Class frmMaceracion
    Inherits frmProceso

    Private EngineMaceracion As EngineMaceracion

    Public Sub New(ByVal id As Integer)

        InitializeComponent()

        Me.pbIconoOperacion.Image = My.Resources.xx
        EngineMaceracion = New EngineMaceracion(id, Me)

    End Sub
End Class