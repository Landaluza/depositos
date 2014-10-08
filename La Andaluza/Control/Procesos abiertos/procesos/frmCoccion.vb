Public Class frmCoccion
    Inherits frmProceso

    Private engineCoccion As Procesos.EngineCoccion

    Public Sub New(ByVal id As Integer)

        InitializeComponent()

        Me.pbIconoOperacion.Image = My.Resources.coccion
        engineCoccion = New Procesos.EngineCoccion(id, Me)

    End Sub
End Class