Public Class Checker
    Protected message As String

    Public Const NUMEROS As String = "1234567890"

    Public Const CP As Integer = 0
    Public Const TLF As Integer = 1
    Public Const NIF As Integer = 2
    Public Const CODIGO_LOTE As Integer = 3
    Public Const NOMBRE As Integer = 4
    Public Const MAIL As Integer = 4


    Public ReadOnly Property mensaje As String
        Get
            Return message
        End Get
    End Property

    Public Function check(name As String, value As Object, type As Integer) As Boolean
        Return True
    End Function

    Public Function check_cp(name As String, value As String) As Boolean
        Return True
    End Function

    Public Function check_tlf(name As String, value As String) As Boolean
        Return True
    End Function

    Public Function check_nif(name As String, value As String) As Boolean
        Return True
    End Function

    Public Function check_nombre(name As String, value As String) As Boolean
        Return True
    End Function

    Public Function check_codigo_lote(name As String, value As String) As Boolean
        Return True
    End Function

    Public Function check_mail(name As String, value As String) As Boolean
        Return True
    End Function

    

End Class
