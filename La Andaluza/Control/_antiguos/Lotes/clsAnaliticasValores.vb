Public Class clsAnaliticasValores
#Region "Atributos"
    Private AnaliticaID As Integer
    Private ParametroID As Integer
    Private Valor As Double
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

    Public Property _Valor() As Double
        Get
            Return Valor
        End Get

        Set(ByVal value As Double)
            Valor = value
        End Set
    End Property

    Public Property _ParametroID() As Integer
        Get
            Return ParametroID
        End Get

        Set(ByVal value As Integer)
            ParametroID = value
        End Set
    End Property
#End Region




   

End Class
