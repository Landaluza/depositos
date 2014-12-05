Namespace Movimientos

    Public Class Trasiego
        Inherits Movimientos.MovimientoBasico

        Public lotePartida As Lote
        Public loteFinal As Lote
        Public frecuencia_creacion_lote As Integer
        Public Abreviatura As String
        Public Sub New(ByVal proceso As Integer)
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
                Me.muestra = False
                codigo_lote = ""
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
