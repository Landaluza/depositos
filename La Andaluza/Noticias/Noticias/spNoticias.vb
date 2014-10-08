

Public Class spNoticias
    Inherits Connection.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[NoticiasSelect]",  _
                     "[dbo].[NoticiasInsert]",  _
                     "[dbo].[NoticiasUpdate]",  _
                     "[dbo].[NoticiasDelete]",  _
                     "[dbo].[NoticiasSelectDgv]",  _
                     "[dbo].[NoticiasSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal Id As Int32, ByRef dtb As Connection.DataBase) As DBO_Noticias
        Dim dbo As New DBO_Noticias
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(CType(dbo, DataBussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Int32, ByRef dtb As Connection.DataBase) As Boolean
        Dim dbo As New DBO_Noticias
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        Return MyBase.DeleteProcedure(CType(dbo, DataBussines), dtb)
    End Function

End Class
