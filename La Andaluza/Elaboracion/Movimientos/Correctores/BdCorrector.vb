Public Class BdCorrector
    Inherits DataBase
    Private query As String

    Public Sub New()
        MyBase.New(Config.Server)
    End Sub

    Public Function guardarCantidad(ByVal loteid As Integer, ByVal cantidad As Double) As Boolean
        query = "update lotes set cantidadrestante= @cant where loteid = @id"

        Me.PrepararConsulta(query)
        Me.AñadirParametroConsulta("@cant", cantidad)
        Me.AñadirParametroConsulta("@id", loteid)

        Return Consultar(True)
    End Function

    Public Function guardarProducto(ByVal loteid As Integer, ByVal producto As Integer) As Boolean
        query = "update lotes set tipoproductoid= @prod where loteid = @id"

        Me.PrepararConsulta(query)
        Me.AñadirParametroConsulta("@prod", producto)
        Me.AñadirParametroConsulta("@id", loteid)

        Return Consultar(True)
    End Function

    Public Function guardarCodigo(ByVal loteid As Integer, ByVal codigo As String) As Boolean
        query = "update lotes set codigolote= @cod where loteid = @id"

        Me.PrepararConsulta(query)
        Me.AñadirParametroConsulta("@cod", codigo)
        Me.AñadirParametroConsulta("@id", loteid)

        Return Consultar(True)
    End Function

    Public Function seleccionar_lote(ByVal id As Integer) As DataTable
        query = "select loteid, codigolote, descripcion, tipoloteid, tipoproductoid, depositoid from lotes where loteid = @id"
        PrepararConsulta(query)
        AñadirParametroConsulta("@id", id)
        Return Consultar()
    End Function

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
End Class
