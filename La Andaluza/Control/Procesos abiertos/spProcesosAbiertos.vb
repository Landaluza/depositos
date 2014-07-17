Public Class spProcesosAbiertos
    Inherits DataBase

    Public Sub New()
        MyBase.New(Config.Server)
    End Sub
    Public Function devolverProcesosAbiertos() As DataTable
        Return Me.Consultar("select MovimientoID,Fecha,Observaciones,Cantidad,ProcesoID,EntraDepositoID,SaleDepositoID,LoteID,FiltroID from procesosabiertos", False)
    End Function
    

    Public Function añadirProceso(ByVal proceso As Integer) As Integer
        Me.EmpezarTransaccion()
        Try
            If Not Me.ConsultaAlteraciones("insert into MovimientosAbiertos(procesoid) values(" & proceso & ")") Then
                Me.CancelarTransaccion()
                Return 0
            End If

            Dim dt As DataTable = Me.Consultar("select max(movimientoid) from movimientosAbiertos", False)
            If dt Is Nothing Then
                Me.CancelarTransaccion()
                Return 0
            End If

            Me.TerminarTransaccion()
            Return Convert.ToInt32(dt.Rows(0).Item(0))
        Catch ex As Exception
            Me.CancelarTransaccion()
            Return 0
        End Try
    End Function
End Class
