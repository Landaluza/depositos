Public Class frmAjusteComercial
    Inherits frmProceso

    Private engineAjusteComercial As Procesos.EngineAjusteComercial

    Public Sub New(ByVal id As Integer)

        InitializeComponent()

        Me.pbIconoOperacion.Image = My.Resources.ajustecomercial
        engineAjusteComercial = New Procesos.EngineAjusteComercial(id, Me)

    End Sub
End Class