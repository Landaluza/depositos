Public Class ctlCuadroDeTexto
    Private cls As New clsCuadroDeTexto

    Function Validar(ByVal ID As Integer, ByVal Campo As String, ByVal CampoValor As String, ByVal CampoID As String, ByVal Tabla As String, ByRef dtb As DataBase) As Boolean
        cls._ID = ID
        cls._Campo = Campo
        cls._CampoValor = CampoValor
        cls._CampoID = CampoID
        cls._Tabla = Tabla

        If ID = 0 Then
            Return cls.Validar(dtb)
        Else
            If cls.EsMio(dtb) Then
                Return False
            Else
                Return cls.Validar(dtb)
            End If
        End If
    End Function


End Class
