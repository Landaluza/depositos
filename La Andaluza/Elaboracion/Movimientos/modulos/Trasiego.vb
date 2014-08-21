Public Class Trasiego


    Public Class Deposito
        Public numero As String
        Public codigo_lote As String
        Public descripcion As String
        Public capacidad As Double
        Public cantidad As Double
        Public producto As Trasiego.Producto
        Public id As Integer
    End Class

    Public Class Lote
        Public codigo_lote As String
        Public id As Integer
        Public descripcion As String
        Public cantidad_restante As Double
        Public producto As Trasiego.Producto
    End Class

    Public Class TipoLote
        Public nombre As String
        Public id As Integer
        Public abreviatura As String
    End Class

    Public Class Producto
        Public nombre As String
        Public id As Integer
    End Class
End Class
