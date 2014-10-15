Namespace Movimientos
    Public Class BdMovimientos
        Inherits Connection.DataBase
        Protected query As String
        Public Sub New()
            MyBase.New(Config.Server)
        End Sub


#Region "Procesos"
        ''*****************************************************************************************
        ''                         funciones de procesos
        ''*****************************************************************************************
        Public Function seleccionar_muestra_pro_proceso(ByVal proceso As Integer) As DataTable
            query = "select isnull(conmuestra, 'false') from procesos where procesoid= @id"
            PrepararConsulta(query)
            AñadirParametroConsulta("@id", proceso)
            Return Consultar()
        End Function

        Public Function seleccionar_tlote_por_proceso(ByVal proceso As Integer) As DataTable
            query = "select isnull(TipoLoteID, 0) from procesos where procesoid= @id"
            PrepararConsulta(query)
            AñadirParametroConsulta("@id", proceso)
            Return Consultar()
        End Function

        Public Function seleccionar_tipo_proceso(ByVal proceso As Integer) As DataTable
            query = "select descripcion, tipomovimientoID from procesos where procesoid = @proc"
            PrepararConsulta(query)
            AñadirParametroConsulta("@proc", proceso)
            Return Consultar()
        End Function
#End Region
        


#Region "Lotes"
        Public Function seleccionar_lote_por_codigo(ByVal codigo As String) As DataTable
            query = "select loteid, codigolote, descripcion, cantidadRestante, tipoproductoid, depositoid from lotes where codigoLote = @codigoLote"
            PrepararConsulta(query)
            AñadirParametroConsulta("@codigoLote", codigo)
            Return Consultar()
        End Function

        Public Function seleccionar_lote(ByVal id As Integer) As DataTable
            query = "select loteid, codigolote, descripcion, cantidadRestante, tipoproductoid, depositoid from lotes where loteid = @id"
            PrepararConsulta(query)
            AñadirParametroConsulta("@id", id)
            Return Consultar()
        End Function

        Public Function actualizar_lote(ByVal codigoLote As String, ByVal cantidad As Double) As Boolean
            If cantidad = 0 Then
                query = "update lotes set cantidadRestante= @cantidad where codigolote= @codigoLote"
            Else
                query = "update lotes set cantidadRestante=cantidadRestante + @cantidad where codigolote= @codigoLote"
            End If
            PrepararConsulta(query)
            AñadirParametroConsulta("@cantidad", cantidad)
            AñadirParametroConsulta("@codigoLote", codigoLote)

            Return Consultar(True)
        End Function

        Public Function sacar_lote(ByVal codigoLote As String) As Boolean
            query = "update lotes set depositoprevioid=depositoid, depositoid=null where codigolote= @codigoLote"

            PrepararConsulta(query)
            AñadirParametroConsulta("@codigoLote", codigoLote)

            Return Consultar(True)
        End Function

        Public Function actualizar_muestra_lote(ByVal codigolote As String) As Boolean
            query = "update lotes set referencia = (select max(referencia) from lotes)+1 where codigolote = @cod"
            PrepararConsulta(query)
            AñadirParametroConsulta("@cod", codigolote)
            Return Consultar(True)
        End Function

        Public Function calcular_codigo_lote(ByVal codigoSinLetra As String) As String
            query = "LotesSelectUltimoCodigo @codigoSinLetra"
            PrepararConsulta(query)
            AñadirParametroConsulta("@codigoSinLetra", codigoSinLetra)
            Dim dt As DataTable = Consultar()

            If dt.Rows.Count = 0 Then
                Return codigoSinLetra & "1"
            End If

            If dt.Rows(0).Item(0) Is Convert.DBNull Then
                Return codigoSinLetra & "1"
            End If

            Dim row As String = dt.Rows(0).Item(0).ToString
            Dim extra As String
            Dim ascii As Integer

            If row.Length > 14 Then
                extra = row.Substring(14, 1)
                ascii = Asc(extra) + 1

                If ascii = 58 Then
                    ascii = 65
                ElseIf ascii = 90 Then
                    ascii = 97
                End If


                Return codigoSinLetra & Chr(ascii)
            Else
                Return codigoSinLetra & "1"
            End If
        End Function
#End Region


#Region "Tipos lotes"

        ''*****************************************************************************************
        ''                         funciones de tiposLotes
        ''*****************************************************************************************       

        Public Function listar_tlotes() As DataTable
            query = "select TipoLoteID, Descripcion, Abreviatura from TiposLotes order by descripcion"
            PrepararConsulta(query)
            Return Consultar()
        End Function

        Public Function seleccionar_detalles_tlote(ByVal id As Integer) As DataTable
            query = "select TipoLoteID, Descripcion, Abreviatura from TiposLotes where TipoLoteid=@id"
            PrepararConsulta(query)
            AñadirParametroConsulta("@id", id)
            Return Consultar()
        End Function
#End Region

#Region "Tipos productos"
        ''*****************************************************************************************
        ''                         funciones de productos
        ''*****************************************************************************************        
        Public Function seleccionar_detalles_producto(ByVal id As Integer) As DataTable
            query = "select TipoProductoID, Descripcion, Abreviatura from TiposProductos where TipoProductoID=@id"
            PrepararConsulta(query)
            AñadirParametroConsulta("@id", id)
            Return Consultar()
        End Function

        Public Function listar_productos() As DataTable
            query = "select TipoProductoID, Descripcion, Abreviatura from TiposProductos order by descripcion"
            PrepararConsulta(query)

            Return Consultar()
        End Function
#End Region

    End Class
End Namespace
