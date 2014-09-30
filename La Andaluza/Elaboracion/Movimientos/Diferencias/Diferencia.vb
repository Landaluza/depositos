Namespace Diferencias

    Public Class Diferencia
        Public Const DIFERENCIA As Integer = 11
        Public Const LAVADO As Integer = 13

        Public lotePartida As Lote
        Public loteFinal As Lote
        Public cantidad As Double
        Public fecha As Date

        Public frecuencia_creacion_lote As Integer
        Public Const FRECUENCIA_MENSUAL As Integer = 1
        Public Const FRECUENCIA_STANDAR As Integer = 2
        Public proceso As Integer
        Public Abreviatura As String
        Public Sub New(ByVal proceso As Integer)
            Me.proceso = proceso

            If proceso = Diferencias.Diferencia.DIFERENCIA Then
                Me.frecuencia_creacion_lote = Diferencias.Diferencia.FRECUENCIA_MENSUAL
            Else
                Me.frecuencia_creacion_lote = Diferencias.Diferencia.FRECUENCIA_STANDAR
            End If

            Me.lotePartida = New Lote()
            Me.loteFinal = New Lote(proceso)
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

            Public Sub New(Optional ByVal tipo As Integer = 0)
                Me.tipo = tipo
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

