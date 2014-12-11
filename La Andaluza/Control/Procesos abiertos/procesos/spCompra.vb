Namespace Procesos
    Public Class spCompra
        Inherits Connection.DataBase

        Public Sub New()
            MyBase.New(Config.Server)
        End Sub
        Public Function devolver_productos() As DataTable
            PrepararConsulta("TiposProductosSelectCbo")
            Return Me.Consultar() '"TiposProductosSelectCboNoEnologicos")
        End Function
        Public Function devolver_productos_no_enologicos() As DataTable
            PrepararConsulta("TiposProductosSelectCboNoEnologicos")
            Return Me.Consultar()
        End Function

        Public Function devolver_tipos_de_lotes() As DataTable
            PrepararConsulta("TiposLotesCbo")
            Return Me.Consultar()
        End Function

        Public Function devolver_depositos_ocupados() As DataTable
            PrepararConsulta("devolverDepositosPartidas")
            Return Me.Consultar()
        End Function

        Public Function devolver_depositos() As DataTable
            PrepararConsulta("devolverDepositosFinales")
            Return Me.Consultar() 'devolverDepositosPartidas
        End Function
        Public Function devolver_proveedores() As DataTable
            PrepararConsulta("Proveedores1CboPorTipo @id")
            AñadirParametroConsulta("@id", 3)
            Return Me.Consultar()
        End Function


        Public Function actualizar(ByVal proveedor As Integer, ByVal productoDestino As Integer, ByVal destino As Integer, ByVal cantidad As Double, ByVal producto As Integer, ByVal lote As Integer, ByVal id As Integer) As Boolean
            Return Me.ConsultaAlteraciones("update movimientosAbiertos set " & _
                                   "entradepositoid=" & destino.ToString & "," & _
                                     "cantidad=" & cantidad.ToString.Replace(",", ".") & "," & _
                                    "TipoProductoid=" & producto.ToString & "," & _
                                    "TipoProductobid=" & productoDestino.ToString & "," & _
                                    "ProveedorId=" & proveedor.ToString & "," & _
                                     "TipoLoteid=" & lote.ToString & _
                                    " where movimientoid=" & id.ToString)
        End Function

    End Class
End Namespace