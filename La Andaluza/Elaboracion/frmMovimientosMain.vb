Public Class frmMovimientosMain
    Private frmMovimientos As frmMovimientos
    Private frmExistenciasPorDepositoFecha As InformesDepositos.frmExistenciasPorDepositoFecha
    Private frmProcesos As Movimientos.Procesos.frmProcesos
    Private frmTiposMovimientos As Movimientos.Tipos.frm
    Public Sub New()

        InitializeComponent()

        frmMovimientos = New frmMovimientos
        frmExistenciasPorDepositoFecha = New InformesDepositos.frmExistenciasPorDepositoFecha(Config.connectionString)
        frmProcesos = New Movimientos.Procesos.frmProcesos
        frmTiposMovimientos = New Movimientos.Tipos.frm

        Engine_LA.FormEnPestaña(frmMovimientos, TabPage1)
        Engine_LA.FormEnPestaña(frmExistenciasPorDepositoFecha, TabPage4)
        Engine_LA.FormEnPestaña(frmProcesos, tpProcesos)
        Engine_LA.FormEnPestaña(frmTiposMovimientos, tpTiposProcesos)
    End Sub

  
End Class