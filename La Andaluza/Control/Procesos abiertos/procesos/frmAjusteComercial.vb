Public Class frmAjusteComercial
    Inherits frmProceso

    Private engineAjusteComercial As EngineAjusteComercial

    Public Sub New(ByVal id As Integer)

        InitializeComponent()

        Me.pbIconoOperacion.Image = My.Resources.ajustecomercial
        engineAjusteComercial = New EngineAjusteComercial(id, Me)

    End Sub
End Class