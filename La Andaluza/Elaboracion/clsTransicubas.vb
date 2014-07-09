Public Class clsTransicubas

#Region "Atributos"
    Private TransicubaID As Integer
    Private Descripcion As String
    Private Estado As Boolean
#End Region

    Public Property _TransicubaID() As Integer
        Get
            Return TransicubaID
        End Get

        Set(ByVal value As Integer)
            TransicubaID = value
        End Set
    End Property

    Public Function darDeBajaTransicuba(ByRef dtb As DataBase) As Boolean

        Return dtb.ConsultaAlteraciones("update Transicubas set " & _
                    "Estado='False' where TransicubaID=" & Convert.ToString(TransicubaID))


    End Function
  


End Class
