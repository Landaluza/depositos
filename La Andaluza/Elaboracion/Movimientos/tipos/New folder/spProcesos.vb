
Public Class spProcesos
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[ProcesosSelect]",  _
                     "[dbo].[ProcesosInsert]",  _
                     "[dbo].[ProcesosUpdate]",  _
                     "[dbo].[ProcesosDelete]",  _
                     "[dbo].[ProcesosSelectDgv]",  _
                     "[dbo].[ProcesosSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal ProcesoID As Integer, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_Procesos
       Dim dbo As New DBO_Procesos
       dbo.searchKey = dbo.item("ProcesoID")
       dbo.searchKey.value = ProcesoID
       MyBase.Select_Record(ctype(dbo, BasesParaCompatibilidad.Databussines), trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal ProcesoID As Integer, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
       Dim dbo As New DBO_Procesos
       dbo.searchKey = dbo.item("ProcesoID")
       dbo.searchKey.value = ProcesoID
       return MyBase.DeleteProcedure(ctype(dbo, BasesParaCompatibilidad.Databussines), trans)
   End Function

    Public Sub cargar_Procesos(ByRef cbo As ComboBox)
        cbo.mam_DataSource("ProcesosCbo", False)
    End Sub
    Public Sub cargar_ProcesosMovimientos(ByRef cbo As ComboBox)
        cbo.mam_DataSource("ProcesosCboMovimientos", False)
    End Sub
End Class
