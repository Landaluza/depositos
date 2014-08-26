Public Class frmMovimientosMain
    Private frmMovimientos As frmMovimientos
    Private frmExistenciasPorDepositoFecha As InformesDepositos.frmExistenciasPorDepositoFecha

    Public Sub New()

        InitializeComponent()

        frmMovimientos = New frmMovimientos
        frmExistenciasPorDepositoFecha = New InformesDepositos.frmExistenciasPorDepositoFecha(Config.connectionString)

        Engine_LA.FormEnPestaña(frmMovimientos, TabPage1)
        Engine_LA.FormEnPestaña(frmExistenciasPorDepositoFecha, TabPage4)
    End Sub

  
End Class