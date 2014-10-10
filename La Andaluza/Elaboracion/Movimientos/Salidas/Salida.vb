Namespace Movimientos

Public Class Salida
        Public lotePartida As Lote
        Public loteFinal As Lote
        Public cantidad As Double
        Public proveedorCompra As Integer
        Public sumarAdestino As Boolean
        Public fecha As Date
        Public proceso As Integer
        Public recipiente As Integer
        Public transicuba As Integer
        Public Abreviatura As String
        Public Sub New(ByVal proceso As Integer)
            proveedorCompra = 0
            Me.proceso = proceso

            Me.lotePartida = New Lote()
            Me.loteFinal = New Lote()
        End Sub

        Public Function validar() As String
            Dim ch As New DecimalChecker
            ch.check_decimal("cantidad", cantidad, 0)

            Return ch.mensaje & loteFinal.validar & lotePartida.validar
        End Function

        Public Class Lote
            Public codigo_lote As String
            Public id As Integer
            Public descripcion As String
            Public cantidad_restante As Double
            Public producto As Integer
            Public tipo As Integer
            Public deposito As Integer
            Public muestra As Boolean

            Public Sub New()
                Me.tipo = 0
                Me.muestra = False
            End Sub
            Public Function validar() As String
                Dim msg As String = ""

                If tipo <= 0 Then
                    msg = "El tipo del lote no es valido"
                End If

                If producto <= 0 Then
                    msg &= "El producto no es valido"
                End If

                Return msg
            End Function
        End Class

End Class
End Namespace
