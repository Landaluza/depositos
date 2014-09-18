Imports BasesParaCompatibilidad.ComboBoxExtension 

Public Class spTiposMovimientos
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[TiposMovimientosSelect]",  _
                     "[dbo].[TiposMovimientosInsert]",  _
                     "[dbo].[TiposMovimientosUpdate]",  _
                     "[dbo].[TiposMovimientosDelete]",  _
                     "[dbo].[TiposMovimientosSelectDgv]",  _
                     "[dbo].[TiposMovimientosSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal Id As Integer, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_TiposMovimientos
       Dim dbo As New DBO_TiposMovimientos
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       MyBase.Select_Record(ctype(dbo, BasesParaCompatibilidad.Databussines), trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal Id As Integer, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
       Dim dbo As New DBO_TiposMovimientos
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       return MyBase.DeleteProcedure(ctype(dbo, BasesParaCompatibilidad.Databussines), trans)
   End Function

   Public Sub cargar_TiposMovimientos(ByRef cbo As ComboBox)
       cbo.mam_DataSource("TiposMovimientosCbo", False)
   End Sub

End Class
