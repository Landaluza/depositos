Public Class frmAjusteAgua
    Inherits frmProceso

    Private engineAjusteAgua As Procesos.EngineAjusteAgua

    Public Sub New(ByVal id As Integer)

        InitializeComponent()

        Me.pbIconoOperacion.Image = My.Resources.ajusteagua
        engineAjusteAgua = New Procesos.EngineAjusteAgua(id, Me)

    End Sub
End Class