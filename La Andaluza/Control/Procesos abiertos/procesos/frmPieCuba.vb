Public Class frmPieCuba
    Inherits frmProceso

    Private EnginePieCuba As EnginePieCuba

    Public Sub New(ByVal id As Integer)

        InitializeComponent()

        Me.pbIconoOperacion.Image = My.Resources.xx
        EnginePieCuba = New EnginePieCuba(id, Me)

    End Sub
End Class