Namespace Movimientos
    Public Class BdFiltrado
        Inherits Movimientos.BdMovimientos



        Public Function crear_lote(ByVal nuevoCodigo As String, ByVal depositoDestino As Integer, ByVal cantidad As Double, ByVal tlote As Integer, ByVal producto As Integer) As Boolean

            query = "INSERT INTO [dbo].[Lotes] " & _
                                               "([Fecha] " & _
                                               ",[CantidadRestante] " & _
                                               ",[TipoLoteID] " & _
                                               ",[TipoProductoID] " & _
                                               ",[CodigoLote] " & _
                                               ",[DepositoID] " & _
                                               ",[Revisar] " & _
                                               ",[FechaModificacion] " & _
                                               ",[UsuarioModificacion]) " & _
                                            "VALUES( " & _
                                                "CURRENT_TIMESTAMP " & _
                                                ", @cantidad    " & _
                                                ", @tlote " & _
                                                ", @producto " & _
                                                ", @nuevoCodigo " & _
                                                ", @depositoDestino " & _
                                                ",'True' " & _
                                                ",CURRENT_TIMESTAMP " & _
                                                ",17 " & _
                                            ")"

            PrepararConsulta(query)
            AñadirParametroConsulta("@cantidad", cantidad)
            AñadirParametroConsulta("@tlote", tlote)
            AñadirParametroConsulta("@producto", producto)
            AñadirParametroConsulta("@nuevoCodigo", nuevoCodigo)
            AñadirParametroConsulta("@depositoDestino", depositoDestino)

            Return Consultar(True)

        End Function


        Public Function crear_lote(ByVal codigoLote As String, ByVal nuevoCodigo As String, ByVal depositoDestino As Integer, ByVal cantidad As Double) As Boolean

            query = "INSERT INTO [dbo].[Lotes] " & _
                                               "([Fecha] " & _
                                               ",[CantidadRestante] " & _
                                               ",[Observacion] " & _
                                               ",[TipoLoteID] " & _
                                               ",[TipoProductoID] " & _
                                               ",[CodigoLote] " & _
                                               ",[DepositoID] " & _
                                               ",[Revisar] " & _
                                               ",[FechaModificacion] " & _
                                               ",[UsuarioModificacion]) " & _
                                            "select " & _
                                                "CURRENT_TIMESTAMP " & _
                                                ",@cantidad " & _
                                                ",Observacion " & _
                                                ",TipoLoteID " & _
                                                ",TipoProductoID " & _
                                                ",@nuevoCodigo   " & _
                                                ",@depositoDestino  " & _
                                                ",'True' " & _
                                                ",CURRENT_TIMESTAMP " & _
                                                ",17 " & _
                                            "from lotes " & _
                                            "where codigoLote = @codigoLote"
            PrepararConsulta(query)
            AñadirParametroConsulta("@cantidad", cantidad)
            AñadirParametroConsulta("@nuevoCodigo", nuevoCodigo)
            AñadirParametroConsulta("@depositoDestino", depositoDestino)
            AñadirParametroConsulta("@codigoLote", codigoLote)

            Return Consultar(True)


        End Function



        ''*****************************************************************************************
        ''                         funciones de filtros
        ''*****************************************************************************************     
        Public Function devolver_Filtros() As DataTable
            query = ("FiltrosCbo")
            PrepararConsulta(query)
            Return Consultar()
        End Function


        ''*****************************************************************************************
        ''                         funciones de depositos
        ''*****************************************************************************************
        Public Function devolver_depositos_excepto(ByVal codigo As String) As DataTable
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
                           "right JOIN  Depositos  " & _
                           "ON Lotes.DepositoID = Depositos.DepositoID " & _
                   "where " & _
                           "Depositos.BotaID Is NULL  " & _
                           "and  Depositos.Codigo <> @cod and " & _
                           "Depositos.Listado = 'TRUE' " & _
                           "ORDER BY " & _
                           "Depositos.Codigo "

            PrepararConsulta(query)
            AñadirParametroConsulta("@cod", codigo)
            Return Me.Consultar()
        End Function

        Public Function listar_depositos() As DataTable
            ' query = "devolverDepositosFinales"
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
                           "right JOIN  Depositos  " & _
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

        Public Function seleccionar_detalles_deposito(ByVal id_deposito As Integer) As DataTable
            query = "select " & _
                        "Depositos.Codigo,   " & _
                        "Lotes.CodigoLote,  " & _
                        "CASE  " & _
                        "        WHEN CodigoLote is NULL THEN dbo.DepositoLavado(Depositos.DepositoID)  " & _
                        "        ELSE Lotes.Descripcion  " & _
                        "END AS Descripcion, " & _
                        "Depositos.Capacidad,  " & _
                        "Lotes.CantidadRestante, " & _
                        "Depositos.depositoID, " & _
                        "Depositos.Listado,   " & _
                        "Lotes.TipoLoteID, " & _
                        "Lotes.TipoProductoID, " & _
                        "TiposProductos.descripcion producto " & _
                    "from " & _
                        "TiposProductos " & _
                        "RIGHT OUTER JOIN Lotes  " & _
                        "ON Lotes.TipoProductoID = TiposProductos.TipoProductoID " & _
                        "RIGHT OUTER JOIN  Depositos  " & _
                        "ON Lotes.DepositoID = Depositos.DepositoID " & _
                    "where " & _
                        "Depositos.BotaID Is NULL  " & _
                        "and  " & _
                        "Depositos.Listado = 'TRUE' " & _
                        "and " & _
                        "depositos.depositoid = @id_deposito " & _
                    "ORDER BY " & _
                        "Depositos.Codigo "

            PrepararConsulta(query)
            AñadirParametroConsulta("@id_deposito", id_deposito)
            Return Consultar()
        End Function


        Public Function devolver_depositos_ocupados() As DataTable
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

            PrepararConsulta(query) '"devolverDepositosPartidas")
            Return Me.Consultar()
        End Function
        ''*****************************************************************************************
        ''                         funciones de movimientos
        ''*****************************************************************************************
        Public Function guardar_movimiento(ByVal id_deposito_origen As Integer, ByVal id_deposito_destino As Integer, ByVal cantidad As Double, proceso As Integer) As Boolean
            query = "insert into movimientos(entraDepositoID, saleDepositoId, cantidad, procesoid, fecha) " & _
                            "values( @id_deposito_destino, " & _
                                    "@id_deposito_origen, " & _
            "@cantidad, @proc, CURRENT_TIMESTAMP)"

            PrepararConsulta(query)
            AñadirParametroConsulta("@id_deposito_destino", If(id_deposito_destino = 0, Convert.DBNull, id_deposito_destino))
            AñadirParametroConsulta("@id_deposito_origen", If(id_deposito_origen = 0, Convert.DBNull, id_deposito_origen))
            AñadirParametroConsulta("@cantidad", cantidad)
            AñadirParametroConsulta("@proc", proceso)

            Return Consultar(True)


        End Function

        Public Function actualizar_filtro(filtro As Integer) As Boolean
            query = "update movimientos set filtroID = @fil where movimientoid = (select max(movimientoid) from movimientos)"

            PrepararConsulta(query)
            AñadirParametroConsulta("@fil", filtro)

            Return Consultar(True)


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

            Return Consultar(True)



        End Function

    End Class


End Namespace