Public Class frmPieCuba
    Inherits frmProceso

    Private EnginePieCuba As Procesos.EnginePieCuba

    Public Sub New(ByVal id As Integer)

        InitializeComponent()

        Me.pbIconoOperacion.Image = My.Resources.piebota
        EnginePieCuba = New Procesos.EnginePieCuba(id, Me)

    End Sub
End Class