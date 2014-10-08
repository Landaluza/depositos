Public Class frmGraneles
    Inherits frmProceso

    Private engineGraneles As Procesos.EngineGraneles

    Public Sub New(ByVal id As Integer)

        InitializeComponent()

        Me.pbIconoOperacion.Image = My.Resources.venta
        engineGraneles = New Procesos.EngineGraneles(id, Me)

    End Sub
End Class