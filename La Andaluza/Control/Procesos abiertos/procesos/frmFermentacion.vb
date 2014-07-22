Public Class frmFermentacion
    Inherits frmProceso

    Private EngineFermentacion As EngineFermentacion

    Public Sub New(ByVal id As Integer)

        InitializeComponent()

        Me.pbIconoOperacion.Image = My.Resources.filtrado
        EngineFermentacion = New EngineFermentacion(id, Me)

    End Sub
End Class