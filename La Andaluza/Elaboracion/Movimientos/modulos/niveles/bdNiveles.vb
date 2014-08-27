Public Class bdNiveles
    'Inherits DataBase
    'Private query As String
    'Private result As DataTable
    'Public Sub New()
    '    MyBase.New(Config.Server)
    'End Sub


    'Public Function recuperar_lote_diferencia(codigoLote As String, producto As Integer)



    '    query = "select loteid from lotes " & _
    '"where tipoloteid = 42 " & _
    '     "               and substring(codigolote,0,7)=substring('" & codigoLote & "',0,7)  " & _
    '      "              and substring(codigolote,9,3)=substring('" & codigoLote & "',9,3)"
    '    result = Consultar(query)

    '    If result.Rows.Count > 0 Then


    '        If result.row(0) Is Nothing Then
    '                codigoLote = substr(codigoLote, 0,6). "01" . substr(codigoLote, 8,3)

    '                if  (me.crear_lote_diferencia(producto, codigoLote) ){
    '                query = "select max(loteId) from lotes"
    '                result = Consultar(query)

    '                    if ( row = mssql_fetch_array(result) ){
    '                        return row[0]
    '                End If
    '            End If
    '        Else
    '                return row[0]
    '        End If
    '    Else
    '        If (Me.crear_lote_diferencia(producto, codigoLote)) Then
    '            query = "select max(loteId) from lotes"
    '            result = Consultar(query)

    '                if ( row = mssql_fetch_array(result) ){
    '                    return row[0]
    '            End If
    '        End If
    '    End If

    '    Return Nothing
    'End Function

    '    public function crear_lote_diferencia( producto, codigoLote){
    '    query = "insert into Lotes"
    '                            ( tipoLoteId, tipoProductoId, CodigoLote, depositoID, fecha)
    '    values()
    '                            ( 42, ". me.ms_escape_string(producto) .", '"
    '                                    . me.ms_escape_string(codigoLote) ."', nothing, CURRENT_TIMESTAMP)"

    '    If (consultar(query)) Then
    '        Return True
    '    Else
    '        Return False
    '    }

    '    public function sacar_lote(codigoLote){
    '        me.query = "update lotes set depositoprevioid=depositoid, depositoid=nothing where codigolote='" . me.ms_escape_string(codigoLote) . "'"
    '    echo Me.query
    '    Return Consultar(query)
    '    }

    '    public function seleccionar_lote_por_codigo(codigo){
    '        me.query = "select loteid, codigolote, descripcion, cantidadRestante, tipoproductoid, depositoid from lotes where codigoLote='" . me.ms_escape_string(codigo) . "'"
    '    Return consultar(query)
    '    }

    '    public function actualizar_lote(codigoLote, cantidad){
    '        me.query = "update lotes set cantidadRestante=cantidadRestante+" . me.ms_escape_string(cantidad) . " where codigolote='" . me.ms_escape_string(codigoLote) . "'"
    '    Return consultar(query)
    '    }


    '    '//*****************************************************************************************
    '    '//                         funciones de productos
    '    '//*****************************************************************************************
    '    public function listar_tipos_productos(){
    '    Me.query = "select TipoProductoID, Descripcion from TiposProductos order by Descripcion"
    '    Return Consultar(query)
    '    }
    '    public function seleccionar_detalles_producto(id){
    '    Me.query = "select TipoProductoID, Descripcion from TiposProductos where TipoProductoID=".me.ms_escape_string(id)
    '    Return consultar(query)
    '    }

    '    '//*****************************************************************************************
    '    '//                         funciones de depositos
    '    '//*****************************************************************************************

    '    public function listar_depositos_ocupados(){
    '    Me.query = "select "
    '                    Depositos.Codigo,  
    '                                Lotes.CodigoLote, 
    '                                CASE 
    '                                        WHEN CodigoLote is nothing THEN dbo.DepositoLavado(Depositos.DepositoID) 
    '                                        ELSE Lotes.Descripcion 
    '                                END AS Descripcion,
    '                                Depositos.Capacidad, 
    '                                Lotes.CantidadRestante,                                                                       
    '                                dbo.DevolerValorParametroDeLote(Lotes.LoteID, 'Acidez') as Acidez,
    '                                dbo.DevolerValorParametroDeLote(Lotes.LoteID, 'Alcohol') as Alcohol, 
    '                                dbo.DevolerValorParametroDeLote(Lotes.LoteID, 'Densidad') as Densidad, 
    '                                dbo.DevolerValorParametroDeLote(Lotes.LoteID, 'Sulfuroso') as Sulfuroso,                                    
    '    Depositos.depositoID()
    '    from()
    '                                Lotes inner JOIN  Depositos 
    '                                        ON Lotes.DepositoID = Depositos.DepositoID
    '    where()
    '                                Depositos.BotaID Is nothing 
    '                        and 
    '                                Depositos.Listado = 'TRUE' 
    '    ORDER BY
    '    Depositos.Codigo ""
    '    Return Consultar(query)
    '    }       

    '    public function seleccionar_detalles_deposito(id_deposito){
    '    Me.query = "select "
    '                                Depositos.Codigo,  
    '                                Lotes.CodigoLote, 
    '                                CASE 
    '                                        WHEN CodigoLote is nothing THEN dbo.DepositoLavado(Depositos.DepositoID) 
    '                                        ELSE Lotes.Descripcion 
    '                                END AS Descripcion,
    '                                Depositos.Capacidad, 
    '                                Lotes.CantidadRestante,                                                                       
    '                                dbo.DevolerValorParametroDeLote(Lotes.LoteID, 'Acidez') as Acidez,
    '                                dbo.DevolerValorParametroDeLote(Lotes.LoteID, 'Alcohol') as Alcohol, 
    '                                dbo.DevolerValorParametroDeLote(Lotes.LoteID, 'Densidad') as Densidad, 
    '                                dbo.DevolerValorParametroDeLote(Lotes.LoteID, 'Sulfuroso') as Sulfuroso,                                    
    '    Depositos.depositoID,
    '    Depositos.Listado,
    '    Lotes.TipoLoteID,
    '    Lotes.TipoProductoID
    '    from()
    '                                Lotes RIGHT OUTER JOIN  Depositos 
    '                                        ON Lotes.DepositoID = Depositos.DepositoID
    '    where()
    '                                Depositos.BotaID Is nothing 
    '                        and 
    '                                Depositos.Listado = 'TRUE'
    '                        and
    '    depositos.depositoid = ". me.ms_escape_string(id_deposito) ."
    '    ORDER BY
    '    Depositos.Codigo ""

    '    Return consultar(query)
    '    }

    '    public function seleccionar_lote_por_deposito(id_deposito){
    '    Me.query = "select loteid, cantidadrestante from lotes where depositoid = ".me.ms_escape_string(id_deposito)

    '    Return Consultar(query)
    '    }
    '    '//*****************************************************************************************
    '    '//                         funciones de movimientos
    '    '//*****************************************************************************************
    '    public function guardar_movimiento(id_deposito_origen, cantidad, observaciones) {
    '    Me.query = "insert into movimientos(entraDepositoID, saleDepositoId, cantidad, observaciones, procesoid, fecha)"
    '                    values( ". me.ms_escape_string(id_deposito_origen) .",
    '                            ". me.ms_escape_string(id_deposito_origen) .",
    '                            '". me.ms_escape_string(cantidad) ."',
    '    '". me.ms_escape_string(observaciones) ."', 11, CURRENT_TIMESTAMP)"
    '    '//echo me.query
    '    Return Consultar(query)
    '    }

    '     public function guardar_trazabilidad(loteDestino, codigoOrigen, cantidad){
    '    Me.query = "INSERT INTO [dbo].[CompuestoPor]"
    '                                               ([LoteFinal]
    '                                               ,[LotePartida]
    '                                               ,[MovimientoID]
    '                                               ,[Cantidad]
    '                                               ,[FechaModificacion]
    '                                               ,[UsuarioModificacion])
    '    VALUES()
    '                                               ( " . me.ms_escape_string(loteDestino) . " 
    '                                               , (select top 1 loteid from lotes where codigoLote = '" . me.ms_escape_string(codigoOrigen) . "')
    '                                               , (select max(movimientoid) from movimientos)
    '                                               ," . me.ms_escape_string(cantidad) . "
    '                                               , CURRENT_TIMESTAMP
    '                                               , 17 )"

    '    Return consultar(query)

    '    }
End Class
