Public Class contadorMovimientos
    Private indices As Integer()
    Private contadores As Integer()
    Public Sub New()
        indices = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19}
        contadores = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
    End Sub

    Public Sub incrementar(ByVal indice As Integer)
        contadores(indice) = contadores(indice) + 1
    End Sub

    Public Sub order()


        Dim maximos As Integer() = contadores.Clone()
        Array.Sort(maximos)

        For i As Integer = 1 To 5



        Next

    End Sub

End Class
