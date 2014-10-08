Namespace Procesos
    Public Class SpTrasiegos
        Inherits Connection.DataBase

        Public Sub New()
            MyBase.New(Config.Server)
        End Sub
        Public Function devolver_productos() As DataTable
            Return Me.Consultar("TiposProductosSelectCboNoEnologicos") '"TiposProductosSelectCbo") '"TiposProductosSelectCboNoEnologicos")
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
                                   "entradepositoid=" & destino.ToString & "," & _
                                     "saledepositoid=" & origen.ToString & "," & _
                                     "cantidad=" & cantidad.ToString.Replace(",", ".") & "," & _
                                    "TipoProductoid=" & producto.ToString & "," & _
                                     "TipoLoteid=" & lote.ToString & _
                                    " where movimientoid=" & id.ToString)
        End Function


    End Class
End Namespace