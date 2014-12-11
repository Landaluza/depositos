Namespace Movimientos

Public Class BdDiferencia
        Inherits Movimientos.BdMovimientos



    Public Function crear_lote(ByVal nuevoCodigo As String, ByVal cantidad As Double, ByVal producto As Integer, ByVal tlote As Integer) As Boolean

        query = "INSERT INTO [dbo].[Lotes] " & _
                                           "([Fecha] " & _
                                           ",[CantidadRestante] " & _
                                           ",[TipoLoteID] " & _
                                           ",[TipoProductoID] " & _
                                           ",[CodigoLote] " & _
                                           ",[FechaModificacion] " & _
                                           ",[UsuarioModificacion]) " & _
                                        "VALUES( " & _
                                            "CURRENT_TIMESTAMP " & _
                                            ", @cantidad    " & _
                                            ", @tlote " & _
                                            ", @producto " & _
                                            ", @nuevoCodigo " & _
                                            ",CURRENT_TIMESTAMP " & _
                                            ",17 " & _
                                        ")"

        PrepararConsulta(query)
        AñadirParametroConsulta("@cantidad", cantidad)
        AñadirParametroConsulta("@tlote", tlote)
        AñadirParametroConsulta("@producto", producto)
        AñadirParametroConsulta("@nuevoCodigo", nuevoCodigo)

            Return Execute()

    End Function


    Public Function recuperar_ultimo_codigo_lote(ByVal codigosinletra As String) As String
        codigosinletra = codigosinletra & "1"
        query = "select isnull( (select codigolote from lotes where codigolote = @cod ) , '')"
        PrepararConsulta(query)
        AñadirParametroConsulta("@cod", codigosinletra)

        Return Convert.ToString(Consultar().Rows(0).Item(0))
    End Function


    ''*****************************************************************************************
    ''                         funciones de depositos
    ''*****************************************************************************************

    Public Function listar_depositos_ocupados() As DataTable
        query = "select " & _
                        "Depositos.Codigo,   " & _
                        "Lotes.CodigoLote,  " & _
                        "CASE  " & _
                        "        WHEN CodigoLote is NULL THEN dbo.DepositoLavado(Depositos.DepositoID)  " & _
                                "ELSE Lotes.Descripcion  " & _
                        "END AS Descripcion, " & _
                        "Depositos.Capacidad,  " & _
                        "Lotes.CantidadRestante,     " & _
                        "Depositos.depositoID, " & _
                        "Depositos.Listado,   " & _
                        "Lotes.TipoLoteID,  " & _
                        "Lotes.TipoProductoID, " & _
                        "TiposProductos.descripcion producto, " & _
                        "Lotes.loteid " & _
                "from  " & _
                        "TiposProductos " & _
                        "RIGHT OUTER JOIN Lotes  " & _
                        "ON Lotes.TipoProductoID = TiposProductos.TipoProductoID " & _
                        "inner JOIN  Depositos  " & _
                        "ON Lotes.DepositoID = Depositos.DepositoID " & _
                "where " & _
                        "Depositos.BotaID Is NULL  " & _
                        "and  " & _
                        "Depositos.Listado = 'TRUE' " & _
                        "ORDER BY " & _
                        "Depositos.Codigo "

        PrepararConsulta(query)

        Return Consultar()
    End Function

    ''*****************************************************************************************
    ''                         funciones de movimientos
    ''*****************************************************************************************
    Public Function guardar_movimiento(ByVal id_deposito_origen As Integer, ByVal id_deposito_destino As Integer, ByVal cantidad As Double) As Boolean
        query = "insert into movimientos(entraDepositoID, saleDepositoId, cantidad, procesoid, fecha) " & _
                        "values( @id_deposito_destino, " & _
                                "@id_deposito_origen, " & _
        "@cantidad, 1, CURRENT_TIMESTAMP)"

        PrepararConsulta(query)
        AñadirParametroConsulta("@id_deposito_destino", If(id_deposito_destino = 0, Convert.DBNull, id_deposito_destino))
        AñadirParametroConsulta("@id_deposito_origen", If(id_deposito_origen = 0, Convert.DBNull, id_deposito_origen))
        AñadirParametroConsulta("@cantidad", cantidad)

            Return Execute()


    End Function

    Public Function guardar_trazabilidad(ByVal codigoDestino As String, ByVal codigoOrigen As String, ByVal cantidad As Double) As Boolean
        query = "INSERT INTO [dbo].[CompuestoPor] " & _
                                                   "([LoteFinal] " & _
                                                   ",[LotePartida] " & _
                                                   ",[MovimientoID] " & _
                                                   ",[Cantidad] " & _
                                                   ",[FechaModificacion] " & _
                                                   ",[UsuarioModificacion])" & _
                                        "VALUES " & _
                                                    "( (select top 1 loteid from lotes where codigoLote = @codigoDestino ) " & _
                                                    ", (select top 1 loteid from lotes where codigoLote = @codigoOrigen ) " & _
                                                    ", (select max(movimientoid) from movimientos) " & _
                                                    ", @cantidad " & _
                                                    ", CURRENT_TIMESTAMP " & _
                                                    ", 17 )"
        PrepararConsulta(query)
        AñadirParametroConsulta("@codigoDestino", codigoDestino)
        AñadirParametroConsulta("@codigoOrigen", codigoOrigen)
        AñadirParametroConsulta("@cantidad", cantidad)

            Return Execute()



    End Function

End Class

End Namespace
