Public Class spProcesosAbiertos
    Inherits DataBase

    Public Sub New()
        MyBase.New(Config.Server)
    End Sub
    Public Function devolverProcesosAbiertos() As DataTable
        Return Me.Consultar("select MovimientoID,Fecha,procesos.Descripcion + ' de ' + convert(varchar, Cantidad) +' litros del deposito ' + convert(varchar,dep.codigo) + ' al deposito ' + convert(varchar,dep2.codigo) , movimientosAbiertos.ProcesoID " & _
                            "from movimientosAbiertos inner join procesos on movimientosAbiertos.procesoid = procesos.ProcesoID " & _
                            "left join  depositos dep on  movimientosAbiertos.SaleDepositoID  = dep.DepositoID " & _
                            "left join depositos dep2 on movimientosAbiertos.EntraDepositoID = dep2.DepositoID  ", False)
    End Function
    

    Public Function añadirProceso(ByVal proceso As Integer) As Integer
        Me.EmpezarTransaccion()
        Try
            If Not Me.ConsultaAlteraciones("insert into MovimientosAbiertos(procesoid, fecha) values(" & proceso & ", CURRENT_TIMESTAMP)") Then
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

    Public Function borrar(ByVal id As Integer) As Boolean
        Return ConsultaAlteraciones("delete from movimientosabiertos where movimientoid =" & id)
    End Function

    Public Function seleccionar(ByVal id As Integer) As DataTable
        Return Consultar("select MovimientoID,Fecha,Observaciones,Cantidad,ProcesoID,EntraDepositoID,SaleDepositoID,LoteID,FiltroID, tipoProductoid, tipoloteid, ProveedorID, TipoProductobID, TipoRecipienteID from movimientosabiertos where movimientoid=" & id, False)
    End Function
End Class
