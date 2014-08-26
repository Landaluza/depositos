Public Class TextChecker
    Inherits Checker

    Public Const LETRAS As String = "qwertyuiopasdfghjklñzxcvbnmáéíóúü"
    Public Const NUMEROS As String = "1234567890"
    Public Const CARACTERES_ESPECIALES As String = ",.:-_"""

    Public Overloads Function check(nombreCampo As String, value As String, min As Integer, max As Integer, caracteresPermitidos As String) As Boolean
        If value.Length <= min Then
            message = "La longitud minima de " & nombreCampo & " es de " & min & " caracteres"
            Return False
        End If

        If value.Length >= max Then
            message = "La longitud maxima de " & nombreCampo & " es de " & max & " caracteres"
            Return False
        End If


        For Each ch As Char In value.ToCharArray
            If Not caracteresPermitidos.Contains(ch) Then
                message = "El campo " & nombreCampo & " contiene el caracter no permitido " & ch
                Return False
            End If
        Next

        Return True
    End Function
End Class
