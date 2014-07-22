Public Class frmDiferencias
    Inherits frmProceso

    Private engineDiferencias As EngineDiferencias

    Public Sub New(ByVal id As Integer)

        InitializeComponent()

        Me.pbIconoOperacion.Image = My.Resources.diferencia
        engineDiferencias = New EngineDiferencias(id, Me)

    End Sub
End Class