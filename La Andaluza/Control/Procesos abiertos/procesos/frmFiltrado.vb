Public Class frmFiltrado
    Inherits frmProceso

    Private EngineFiltrado As EngineFiltrado

    Public Sub New(ByVal id As Integer)

        InitializeComponent()

        Me.pbIconoOperacion.Image = My.Resources.filtrado
        EngineFiltrado = New EngineFiltrado(id, Me)

    End Sub
End Class