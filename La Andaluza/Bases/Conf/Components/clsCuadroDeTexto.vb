
Public Class clsCuadroDeTexto

    Private ID As Integer
    Private Campo As String
    Private CampoValor As String
    Private CampoID As String
    Private Tabla As String

#Region "Propiedades"
    Public Property _ID() As Integer
        Get
            Return ID
        End Get

        Set(ByVal value As Integer)
            ID = value
        End Set
    End Property

    Public Property _Campo() As String
        Get
            Return Campo
        End Get

        Set(ByVal value As String)
            Campo = value
        End Set
    End Property

    Public Property _CampoValor() As String
        Get
            Return CampoValor
        End Get

        Set(ByVal value As String)
            CampoValor = value
        End Set
    End Property

    Public Property _CampoID() As String
        Get
            Return CampoID
        End Get

        Set(ByVal value As String)
            CampoID = value
        End Set
    End Property

    Public Property _Tabla() As String
        Get
            Return Tabla
        End Get

        Set(ByVal value As String)
            Tabla = value
        End Set
    End Property

#End Region

    Function EsMio(ByRef dtb As DataBase) As Boolean
        Try
            Return Convert.ToInt32(dtb.Consultar("select count(*) from " & Tabla & " where " & Campo & " = '" & CampoValor & "' and " & CampoID & " = " & Convert.ToString(ID), False).Rows(0).Item(0)) > 0
        Catch ex As Exception
            Return False
        End Try
    End Function

    Function Validar(ByRef dtb As DataBase) As Boolean
        Try
            Return Convert.ToInt32(dtb.Consultar("select count(*) as cuenta from " & Tabla & " where " & Campo & " = '" & CampoValor & "'", False).Rows(0).Item(0)) > 0
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
