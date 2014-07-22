Public Class frmFermentacion
    Inherits frmProceso

    Private EngineFermentacion As EngineFermentacion

    Public Sub New(ByVal id As Integer)

        InitializeComponent()

        Me.pbIconoOperacion.Image = My.Resources.fermentacion
        EngineFermentacion = New EngineFermentacion(id, Me)

    End Sub
End Class