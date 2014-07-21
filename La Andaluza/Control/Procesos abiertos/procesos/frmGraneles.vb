Public Class frmGraneles
    Inherits frmProceso

    Private engineGraneles As EngineGraneles

    Public Sub New(ByVal id As Integer)

        InitializeComponent()

        Me.pbIconoOperacion.Image = My.Resources.venta
        engineGraneles = New EngineGraneles(id, Me)

    End Sub
End Class