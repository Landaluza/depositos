Public Class IntegerChecker
    Inherits Checker
    Public Function check_entero(name As String, value As Integer) As Boolean
        Dim cad As String = value.ToString

        For Each ch As Char In cad.ToCharArray
            If Not NUMEROS.Contains(ch) Then
                message = "El campo " & name & " contiene el caracter no permitido -" & ch & "-. Debe ser un numero entero"
                Return False
            End If
        Next

        Return True
    End Function

    Public Function check_entero(name As String, value As Integer, min As Integer) As Boolean
        Dim cad As String = value.ToString

        For Each ch As Char In cad.ToCharArray
            If Not NUMEROS.Contains(ch) Then
                message = "El campo " & name & " contiene el caracter no permitido -" & ch & "-. Debe ser un numero entero"
                Return False
            End If
        Next

        If value <= min Then
            message = "El campo " & name & " contiene debe tener un valor minimo de " & min
            Return False
        End If


        Return True
    End Function


    Public Function check_entero(name As String, value As Integer, min As Integer, max As Integer) As Boolean
        Dim cad As String = value.ToString

        For Each ch As Char In cad.ToCharArray
            If Not NUMEROS.Contains(ch) Then
                message = "El campo " & name & " contiene el caracter no permitido -" & ch & "-. Debe ser un numero entero"
                Return False
            End If
        Next

        If value <= min Then
            message = "El campo " & name & " contiene debe tener un valor minimo de " & min
            Return False
        End If

        If value >= max Then
            message = "El campo " & name & " contiene debe tener un valor maximo de " & max
            Return False
        End If

        Return True
    End Function
End Class
