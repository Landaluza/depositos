Public Class frmMovimientosMain
    Private frmMovimientos As frmMovimientos
    Private frmExistenciasPorDepositoFecha As InformesDepositos.frmExistenciasPorDepositoFecha
    Private frmProcesos As frmProcesos
    Public Sub New()

        InitializeComponent()

        frmMovimientos = New frmMovimientos
        frmExistenciasPorDepositoFecha = New InformesDepositos.frmExistenciasPorDepositoFecha(Config.connectionString)
        frmProcesos = New frmProcesos

        Engine_LA.FormEnPestaña(frmMovimientos, TabPage1)
        Engine_LA.FormEnPestaña(frmExistenciasPorDepositoFecha, TabPage4)
        Engine_LA.FormEnPestaña(frmProcesos, tpTipos)
    End Sub

  
End Class