Public Class frmAjusteAgua
    Inherits frmProceso

    Private engineAjusteAgua As EngineAjusteAgua

    Public Sub New(ByVal id As Integer)

        InitializeComponent()

        Me.pbIconoOperacion.Image = My.Resources.ajusteagua
        engineAjusteAgua = New EngineAjusteAgua(id, Me)

    End Sub
End Class