Public Class frmMovimientosMain
    Private frmMovimientos As frmMovimientos
    Private ListMovPorTipos As ListMovPorTipos
    Private frmExistenciasPorDepositoFecha As InformesDepositos.frmExistenciasPorDepositoFecha

    Public Sub New()

        InitializeComponent()

        frmMovimientos = New frmMovimientos
        ListMovPorTipos = New ListMovPorTipos
        frmExistenciasPorDepositoFecha = New InformesDepositos.frmExistenciasPorDepositoFecha(Config.connectionString)

        Engine_LA.FormEnPestaña(frmMovimientos, TabPage1)
        Engine_LA.FormEnPestaña(ListMovPorTipos, TabPage3)
        Engine_LA.FormEnPestaña(frmExistenciasPorDepositoFecha, TabPage4)
        Engine_LA.FormEnPestaña(CType(ListMovPorTipos, Form), TabPage2)
    End Sub

  
End Class