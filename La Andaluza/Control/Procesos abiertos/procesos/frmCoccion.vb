Public Class frmCoccion
    Inherits frmProceso

    Private engineCoccion As EngineCoccion

    Public Sub New(ByVal id As Integer)

        InitializeComponent()

        Me.pbIconoOperacion.Image = My.Resources.coccion
        engineCoccion = New EngineCoccion(id, Me)

    End Sub
End Class