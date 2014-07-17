Public Class spProcesosAbiertos
    Inherits DataBase

    Public Sub New()
        MyBase.New(Config.Server)
    End Sub
    Public Function devolverProcesosAbiertos() As DataTable
        Return Me.Consultar("select MovimientoID,Fecha,Observaciones,Cantidad,ProcesoID,EntraDepositoID,SaleDepositoID,LoteID,FiltroID from procesosabiertos")
    End Function

    Public Function borrar_proceso_abierto() As Boolean
        Return Me.ConsultaAlteraciones("delete from procesosabiertos where movimientoid =")
    End Function
End Class
