Public Class frmFiltrado
    Inherits frmProceso

    Private EngineFiltrado As Procesos.EngineFiltrado

    Public Sub New(ByVal id As Integer)

        InitializeComponent()

        Me.pbIconoOperacion.Image = My.Resources.filtrado
        EngineFiltrado = New Procesos.EngineFiltrado(id, Me)

    End Sub
End Class