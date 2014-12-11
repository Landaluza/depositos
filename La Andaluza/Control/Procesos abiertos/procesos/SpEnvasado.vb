Namespace Procesos
    Public Class SpEnvasado
        Inherits Connection.DataBase

        Public Sub New()
            MyBase.New(Config.Server)
        End Sub

        Public Function devolver_depositos_ocupados() As DataTable
            PrepararConsulta("devolverDepositosPartidas")
            Return Me.Consultar()
        End Function

        Public Function devolver_depositos() As DataTable
            PrepararConsulta("devolverDepositosFinales")
            Return Me.Consultar() 'devolverDepositosPartidas
        End Function

        Public Function actualizar(ByVal destino As Integer, ByVal cantidad As Double, ByVal id As Integer) As Boolean
            Return Me.ConsultaAlteraciones("update movimientosAbiertos set " & _
                                     "saledepositoid=" & destino.ToString & "," & _
                                     "cantidad=" & cantidad.ToString.Replace(",", ".") & _
                                    " where movimientoid=" & id.ToString)
        End Function
    End Class
End Namespace