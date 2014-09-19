Public Class frmMovimientosMain
    Private frmMovimientos As frmMovimientos
    Private frmExistenciasPorDepositoFecha As InformesDepositos.frmExistenciasPorDepositoFecha
    Private frmProcesos As frmProcesos
    Private frmTiposMovimientos As frmTiposMovimientos
    Public Sub New()

        InitializeComponent()

        frmMovimientos = New frmMovimientos
        frmExistenciasPorDepositoFecha = New InformesDepositos.frmExistenciasPorDepositoFecha(Config.connectionString)
        frmProcesos = New frmProcesos
        frmTiposMovimientos = New frmTiposMovimientos

        Engine_LA.FormEnPestaña(frmMovimientos, TabPage1)
        Engine_LA.FormEnPestaña(frmExistenciasPorDepositoFecha, TabPage4)
        Engine_LA.FormEnPestaña(frmProcesos, tpProcesos)
        Engine_LA.FormEnPestaña(frmTiposMovimientos, tpTiposProcesos)
    End Sub

  
End Class