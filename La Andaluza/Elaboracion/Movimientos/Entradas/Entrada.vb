Namespace Entradas

    Public Class Entrada
        Public Const ABREVIATURA_ENTRADA As String = "Rec"
        Public Const COMPRA As Integer = 1
        Public Const DDESEMBOTE As Integer = 2
        Public Const DESEMBOTE_NO_COMFORME As Integer = 3

        Public lotePartida As Lote
        Public loteFinal As Lote
        Public cantidad As Double
        Public proveedorCompra As Integer
        Public sumarAdestino As Boolean
        Public fecha As Date

        Public Function validar() As String
            Dim ch As New DecimalChecker
            ch.check_decimal("cantidad", cantidad, 0)

            Return ch.mensaje
        End Function

        'Public Class Deposito
        '    Public numero As String
        '    Public codigo_lote As String
        '    Public descripcion As String
        '    Public capacidad As Double
        '    Public cantidad As Double
        '    Public producto As Trasiego.Producto
        '    Public id As Integer
        'End Class

        Public Class Lote
            Public codigo_lote As String
            Public id As Integer
            Public descripcion As String
            Public cantidad_restante As Double
            Public producto As Integer
            Public tipo As Integer
            Public deposito As Integer

            Public Sub New()
                tipo = 0
            End Sub
            Public Function validar() As String
                Return ""
            End Function
        End Class

        Public Class TipoLote
            Public nombre As String
            Public id As Integer
            Public abreviatura As String

            Public Function validar() As String
                Return ""
            End Function
        End Class

        Public Class Producto
            Public nombre As String
            Public id As Integer

            Public Function validar() As String
                Return ""
            End Function
        End Class


    End Class

End Namespace

