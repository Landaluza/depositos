Public Class frmClarificacion
    Inherits frmProceso

    Private engineClarificacion As EngineClarificacion

    Public Sub New(ByVal id As Integer)

        InitializeComponent()

        Me.pbIconoOperacion.Image = My.Resources.clarificacion
        engineClarificacion = New EngineClarificacion(id, Me)

    End Sub
End Class