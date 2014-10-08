Public Class clsAnaliticas

#Region "Atributos"
    Private AnaliticaID As Integer
    Private Nombre As String
    Private LoteID As Integer
    Private AnalistaID As String
    Private CatadorID As String

#End Region

#Region "Propiedades"
    Public Property _AnaliticaID() As Integer
        Get
            Return AnaliticaID
        End Get

        Set(ByVal value As Integer)
            AnaliticaID = value
        End Set
    End Property

    Public Property _Nombre() As String
        Get
            Return Nombre
        End Get

        Set(ByVal value As String)
            Nombre = value
        End Set
    End Property

    Public Property _LoteID() As Integer
        Get
            Return LoteID
        End Get

        Set(ByVal value As Integer)
            LoteID = value
        End Set
    End Property

    Public Property _AnalistaID() As Integer
        Get
            If AnalistaID = "null" Then
                Return 0
            Else
                Return Convert.ToInt32(AnalistaID)
            End If
        End Get

        Set(ByVal value As Integer)
            If value = 0 Then
                AnalistaID = "null"
            Else
                AnalistaID = value.ToString
            End If
        End Set
    End Property

    Public Property _CatadorID() As Integer
        Get
            If CatadorID = "null" Then
                Return 0
            Else
                Return Convert.ToInt32(CatadorID)
            End If
        End Get

        Set(ByVal value As Integer)
            If value = 0 Then
                CatadorID = "null"
            Else
                CatadorID = value.ToString
            End If
        End Set
    End Property
#End Region

#Region "Metodos"
   

    Public Function DevolverPorMuestra(ByRef dtb As Connection.DataBase) As DataTable
        Return dtb.Consultar("select AnaliticaID, Nombre from Analiticas where LoteID = " & Convert.ToString(LoteID), False)
    End Function



    Public Function Eliminar(ByRef dtb As Connection.DataBase) As Boolean
        Return dtb.ConsultaAlteraciones("delete from Analiticas where AnaliticaID = " & AnaliticaID)
    End Function
#End Region
End Class