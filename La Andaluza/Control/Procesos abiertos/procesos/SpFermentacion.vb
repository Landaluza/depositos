Public Class SpFermentacion
    Inherits DataBase

    Public Sub New()
        MyBase.New(Config.Server)
    End Sub

    Public Function devolver_depositos_ocupados() As DataTable
        Return Me.Consultar("devolverDepositosPartidas")
    End Function

    Public Function devolver_depositos() As DataTable
        Return Me.Consultar("devolverDepositosFinales") 'devolverDepositosPartidas
    End Function

    Public Function actualizar(ByVal origen As Integer, ByVal destino As Integer, ByVal cantidad As Double, ByVal id As Integer) As Boolean
        Return Me.ConsultaAlteraciones("update movimientosAbiertos set " & _
                               "entradepositoid=" & destino.ToString & "," & _
                                 "cantidad=" & cantidad.ToString.Replace(",", ".") & "," & _
                                "saledepositoid=" & origen.ToString & "" & _
                                " where movimientoid=" & id.ToString)
    End Function
End Class
