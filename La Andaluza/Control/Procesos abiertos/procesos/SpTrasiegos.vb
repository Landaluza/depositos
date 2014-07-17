Public Class SpTrasiegos
    Inherits DataBase

    Public Sub New()
        MyBase.New(Config.Server)
    End Sub
    Public Function devolver_productos() As DataTable
        Return Me.Consultar("TiposProductosSelectCbo") '"TiposProductosSelectCboNoEnologicos")
    End Function

    Public Function devolver_tipos_de_lotes() As DataTable
        Return Me.Consultar("TiposLotesCbo")
    End Function

    Public Function devolver_depositos_ocupados() As DataTable
        Return Me.Consultar("devolverDepositosPartidas")
    End Function

    Public Function devolver_depositos() As DataTable
        Return Me.Consultar("devolverDepositosFinales") 'devolverDepositosPartidas
    End Function

    Public Function actualizar(ByVal origen As Integer, ByVal destino As Integer, ByVal cantidad As Double, ByVal producto As Integer, ByVal lote As Integer, ByVal id As Integer) As Boolean
        Return Me.ConsultaAlteraciones("update movimientosAbiertos set " & _
                               "entradepositoid=" & destino & "," & _
                                 "saledepositoid=" & origen & "," & _
                                 "cantidad=" & cantidad & "," & _
                                "TipoProductoid=" & producto & "," & _
                                 "TipoLoteid=" & lote & _
                                " where movimientoid=" & id)
    End Function
End Class
