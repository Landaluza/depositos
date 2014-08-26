Public Class DecimalChecker
    Inherits Checker
    Public Function check_decimal(name As String, value As Double) As Boolean
        Dim cad As String = value.ToString
        Dim decimales As String = NUMEROS & "."

        For Each ch As Char In cad.ToCharArray
            If Not decimales.Contains(ch) Then
                message = "El campo " & name & " contiene el caracter no permitido -" & ch & "-. Debe ser un numero decimal"
                Return False
            End If
        Next

        Return True
    End Function

    Public Function check_decimal(name As String, value As Double, min As Double) As Boolean
        Dim cad As String = value.ToString
        Dim decimales As String = NUMEROS & "."

        For Each ch As Char In cad.ToCharArray
            If Not decimales.Contains(ch) Then
                message = "El campo " & name & " contiene el caracter no permitido -" & ch & "-. Debe ser un numero decimal"
                Return False
            End If
        Next

        If value <= min Then
            message = "El campo " & name & " contiene debe tener un valor minimo de " & min
            Return False
        End If


        Return True
    End Function


    Public Function check_decimal(name As String, value As Double, min As Double, max As Double) As Boolean
        Dim cad As String = value.ToString
        Dim decimales As String = NUMEROS & "."

        For Each ch As Char In cad.ToCharArray
            If Not decimales.Contains(ch) Then
                message = "El campo " & name & " contiene el caracter no permitido -" & ch & "-. Debe ser un numero decimal"
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
