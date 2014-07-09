
Public Class spFiltros
Inherits StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[FiltrosSelect]",  _
                     "[dbo].[FiltrosInsert]",  _
                     "[dbo].[FiltrosUpdate]",  _
                     "[dbo].[FiltrosDelete]",  _
                     "[dbo].[FiltrosSelectDgv]",  _
                     "[dbo].[FiltrosSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal FiltroID As Integer, ByRef dtb As DataBase) As DBO_Filtros
        Dim dbo As New DBO_Filtros
        dbo.searchKey = dbo.item("FiltroID")
        dbo.searchKey.value = FiltroID
        MyBase.Select_Record(CType(dbo, DataBussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal FiltroID As Integer, ByRef dtb As DataBase) As Boolean
        Dim dbo As New DBO_Filtros
        dbo.searchKey = dbo.item("FiltroID")
        dbo.searchKey.value = FiltroID
        Return MyBase.DeleteProcedure(CType(dbo, DataBussines), dtb)
    End Function

   Public Sub cargar_Filtros(ByRef cbo As ComboBox)
       cbo.mam_DataSource("FiltrosCbo", False)
   End Sub

End Class
