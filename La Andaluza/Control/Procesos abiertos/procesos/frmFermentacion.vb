Public Class frmFermentacion
    Inherits frmProceso

    Private EngineFermentacion As Procesos.EngineFermentacion

    Public Sub New(ByVal id As Integer)

        InitializeComponent()

        Me.pbIconoOperacion.Image = My.Resources.fermentacion
        EngineFermentacion = New Procesos.EngineFermentacion(id, Me)

    End Sub
End Class