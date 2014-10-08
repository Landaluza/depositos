Public Class frmDiferencias
    Inherits frmProceso

    Private engineDiferencias As Procesos.EngineDiferencias

    Public Sub New(ByVal id As Integer)

        InitializeComponent()

        Me.pbIconoOperacion.Image = My.Resources.diferencia
        engineDiferencias = New Procesos.EngineDiferencias(id, Me)

    End Sub
End Class