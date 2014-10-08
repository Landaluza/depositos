Public Class frmClarificacion
    Inherits frmProceso

    Private engineClarificacion As Procesos.EngineClarificacion

    Public Sub New(ByVal id As Integer)

        InitializeComponent()

        Me.pbIconoOperacion.Image = My.Resources.clarificacion
        engineClarificacion = New Procesos.EngineClarificacion(id, Me)

    End Sub
End Class