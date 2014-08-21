Public Class bdTrasiego
    Inherits DataBase

    Private query As String
    Public Sub New()
        MyBase.New(Config.Server)
    End Sub


    Public Function seleccionar_lote_por_codigo(ByVal codigo As String) As DataTable
        query = "select loteid, codigolote, descripcion, cantidadRestante, tipoproductoid from lotes where codigoLote = @codigoLote"
        PrepararConsulta(query)
        AñadirParametroConsulta("@codigoLote", codigo)
        Return Consultar()
    End Function

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
                                            ",' @nuevoCodigo' " & _
                                            ", @depositoDestino " & _
                                            ",'True' " & _
                                            ",CURRENT_TIMESTAMP " & _
                                            ",17 " & _
                                        ")"

        'prep
        Return True
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
                                            ",'@nuevoCodigo'   " & _
                                            ",@depositoDestino  " & _
                                            ",'True' " & _
                                            ",CURRENT_TIMESTAMP " & _
                                            ",17 " & _
                                        "from lotes " & _
                                        "where codigoLote = '@codigoLote'"
        'prep

        Return True
    End Function
        */

    Public Function actualizar_lote(ByVal codigoLote As String, ByVal cantidad As Double) As Boolean
        query = "update lotes set cantidadRestante=cantidadRestante+@cantidad where codigolote='@codigoLote'"
        Return Consultar()
    End Function

    Public Function actualizar_lote_origen(ByVal codigoLote As String, ByVal cantidad As Double) As Boolean
        query = "update lotes set cantidadRestante=cantidadRestante-@cantidad where codigolote='@codigoLote'"
        Return Consultar()
    End Function

    Public Function sacar_lote(ByVal codigoLote As String) As Boolean
        query = "update lotes set depositoprevioid=depositoid, depositoid=null where codigolote='@codigoLote'"
        Return Consultar()
    End Function

    Public Function calcular_codigo_lote(ByVal codigoSinLetra As String) As DataTable
        query = "exec LotesSelectUltimoCodigo '@codigoSinLetra'"
            this->result = consultar

            if ( row = mssql_fetch_array(this->result) )
                if (strlen(row[0]) > 14)
                    extra = substr(row[0],14, 1)                        
                ascii = ord(extra) + 1

                     If ( ascii == 58 )
                    ascii = 65
                     Else If ( ascii ==  90 )
                    ascii = 97



                    Return codigoSinLetra.chr(ascii)
                End Subelse
                    return row[0].'1'
    End Function
            End Subelse
                return codigoSinLetra . '1'
            End Sub
        End Sub
    ''*****************************************************************************************
    ''                         funciones de productos
    ''*****************************************************************************************        
    Public Function seleccionar_detalles_producto(ByVal id As Integer) As DataTable
        query = "select TipoProductoID, Descripcion, Abreviatura from TiposProductos where TipoProductoID=@id"
        Return Consultar()
    End Function

    Public Function listar_productos() As DataTable
        query = "select TipoProductoID, Descripcion, Abreviatura from TiposProductos order by descripcion"
        Return consultar
    End Function
    ''*****************************************************************************************
    ''                         funciones de tiposLotes
    ''*****************************************************************************************        
    Public Function seleccionar_detalles_tlote(ByVal id As Integer) As DataTable
        query = "select TipoLoteID, Descripcion, Abreviatura from TiposLotes where tipoloteid=@id"
        Return Consultar()
    End Function

    Public Function listar_tlotes() As DataTable
        query = "select TipoLoteID, Descripcion, Abreviatura from TiposLotes order by descripcion"
        Return consultar
    End Function
    ''*****************************************************************************************
    ''                         funciones de depositos
    ''*****************************************************************************************

    Public Function listar_depositos() As DataTable
        query = "select "
                                    Depositos.Codigo,  
                                    Lotes.CodigoLote, 
                                    CASE 
                                            WHEN CodigoLote is NULL THEN dbo.DepositoLavado(Depositos.DepositoID) 
                                            ELSE Lotes.Descripcion 
                                    END AS Descripcion,
                                    Depositos.Capacidad, 
                                    Lotes.CantidadRestante,                                                                                                          
                                    Depositos.depositoID,
                                    Depositos.Listado,  
                                    Lotes.TipoLoteID,                                                                                                            
                                    Lotes.TipoProductoID,
                                    TiposProductos.descripcion producto
        from()
        TiposProductos()
                                    RIGHT OUTER JOIN Lotes 
                                            ON Lotes.TipoProductoID = TiposProductos.TipoProductoID
                                    RIGHT OUTER JOIN  Depositos 
                                            ON Lotes.DepositoID = Depositos.DepositoID
        where()
                                    Depositos.BotaID Is NULL 
                            and 
                                    Depositos.Listado = 'TRUE'
        ORDER BY
        Depositos.Codigo ""

        Return consultar
    End Function

    Public Function listar_depositos_excepto(ByVal id As Integer) As DataTable
        query = "select "
                                    Depositos.Codigo,  
                                    Lotes.CodigoLote, 
                                    CASE 
                                            WHEN CodigoLote is NULL THEN dbo.DepositoLavado(Depositos.DepositoID) 
                                            ELSE Lotes.Descripcion 
                                    END AS Descripcion,
                                    Depositos.Capacidad, 
                                    Lotes.CantidadRestante,                                                                                                          
                                    Depositos.depositoID,
                                    Depositos.Listado,  
                                    Lotes.TipoLoteID,                                                                                                            
                                    Lotes.TipoProductoID,
                                    TiposProductos.descripcion producto
        from()
        TiposProductos()
                                    RIGHT OUTER JOIN Lotes 
                                            ON Lotes.TipoProductoID = TiposProductos.TipoProductoID
                                    RIGHT OUTER JOIN  Depositos 
                                            ON Lotes.DepositoID = Depositos.DepositoID
        where()
                                    Depositos.BotaID Is NULL 
                            and 
                                    Depositos.Listado = 'TRUE' 
                            and
                                    depositos.depositoid <> ". (id) ."
        ORDER BY
        Depositos.Codigo ""
        Return Consultar()
    End Function

    Public Function seleccionar_detalles_deposito(ByVal id_deposito As Integer) As DataTable
        query = "select "
                                    Depositos.Codigo,  
                                    Lotes.CodigoLote, 
                                    CASE 
                                            WHEN CodigoLote is NULL THEN dbo.DepositoLavado(Depositos.DepositoID) 
                                            ELSE Lotes.Descripcion 
                                    END AS Descripcion,
                                    Depositos.Capacidad, 
                                    Lotes.CantidadRestante,                                                                                                          
                                    Depositos.depositoID,
                                    Depositos.Listado,  
                                    Lotes.TipoLoteID,                                                                                                            
                                    Lotes.TipoProductoID,
                                    TiposProductos.descripcion producto
        from()
        TiposProductos()
                                    RIGHT OUTER JOIN Lotes 
                                            ON Lotes.TipoProductoID = TiposProductos.TipoProductoID
                                    RIGHT OUTER JOIN  Depositos 
                                            ON Lotes.DepositoID = Depositos.DepositoID
        where()
                                    Depositos.BotaID Is NULL 
                            and 
                                    Depositos.Listado = 'TRUE'
                            and
        depositos.depositoid = ". (id_deposito) ."
        ORDER BY
        Depositos.Codigo ""

        Return Consultar()
    End Function


    ''*****************************************************************************************
    ''                         funciones de movimientos
    ''*****************************************************************************************
    Public Function guardar_movimiento(ByVal id_deposito_origen As Integer, ByVal id_deposito_destino As Integer, ByVal cantidad As Double) As Boolean
        query = "insert into movimientos(entraDepositoID, saleDepositoId, cantidad, procesoid, fecha)"
                        values( ". (id_deposito_destino) .",
                                ". (id_deposito_origen) .",
                                '". (cantidad) ."', 9, CURRENT_TIMESTAMP)"
        ''echo query
        Return Consultar()
    End Function

    Public Function guardar_trazabilidad(ByVal codigoDestino As String, ByVal codigoOrigen As String, ByVal cantidad As Double) As Boolean
        query = "INSERT INTO [dbo].[CompuestoPor]"
                                                   ([LoteFinal]
                                                   ,[LotePartida]
                                                   ,[MovimientoID]
                                                   ,[Cantidad]
                                                   ,[FechaModificacion]
                                                   ,[UsuarioModificacion])
        VALUES()
                                                   ( (select top 1 loteid from lotes where codigoLote = '" . (codigoDestino) . "')
                                                   , (select top 1 loteid from lotes where codigoLote = '" . (codigoOrigen) . "')
                                                   , (select max(movimientoid) from movimientos)
                                                   ," . (cantidad) . "
                                                   , CURRENT_TIMESTAMP
                                                   , 17 )"

        Return Consultar()

    End Function
End Class
