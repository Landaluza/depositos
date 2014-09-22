<Serializable()> _
Public Class contadorMovimientos

    Private indices As Integer()
    Private contadores As Integer()
    Public Sub New()
        indices = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19}
        contadores = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
    End Sub

    Public Sub incrementar(ByVal indice As Integer)
        contadores(indice) = contadores(indice) + 1
    End Sub

    Public Function order() As Integer()


        Dim maximos As Integer() = contadores.Clone
        Array.Sort(maximos)
        Array.Reverse(maximos)

        Dim indicesMaximos(6) As Integer
        For i As Integer = 0 To 4

            Dim index As Integer = 0
            For Each c As Integer In contadores
                If c = maximos(i) Then
                    indicesMaximos(i) = indices(index)
                End If

                index = index + 1
            Next
        Next

        Return indicesMaximos
    End Function

End Class
