Namespace Movimientos
    Namespace Procesos

        Public Class spProcesos
            Inherits Connection.StoredProcedure

            Public Sub New()
                MyBase.New("[dbo].[ProcesosSelect]", _
                              "[dbo].[ProcesosInsert]", _
                              "[dbo].[ProcesosUpdate]", _
                              "[dbo].[ProcesosDelete]", _
                              "[dbo].[ProcesosSelectDgv]", _
                              "[dbo].[ProcesosSelectDgvBy]")
            End Sub

            Public Overloads Function Select_Record(ByVal ProcesoID As Integer, Optional ByRef dtb As Connection.DataBase = Nothing) As Movimientos.Procesos.DBO_Procesos
                If dtb Is Nothing Then dtb = New Connection.DataBase(Config.Server)
                Dim dbo As New Movimientos.Procesos.DBO_Procesos
                dbo.searchKey = dbo.item("ProcesoID")
                dbo.searchKey.value = ProcesoID
                MyBase.Select_Record(CType(dbo, DataBussines), dtb)
                Return dbo
            End Function

            Public Overrides Function Delete(ByVal ProcesoID As Integer, ByRef dtb As Connection.DataBase) As Boolean
                Dim dbo As New Movimientos.Procesos.DBO_Procesos
                dbo.searchKey = dbo.item("ProcesoID")
                dbo.searchKey.value = ProcesoID
                Return MyBase.DeleteProcedure(CType(dbo, DataBussines), dtb)
            End Function

            Public Sub cargar_Procesos(ByRef cbo As ComboBox)
                cbo.mam_DataSource("ProcesosCbo", False)
            End Sub
            Public Sub cargar_ProcesosMovimientos(ByRef cbo As ComboBox)
                cbo.mam_DataSource("ProcesosCboMovimientos", False)
            End Sub
        End Class
    End Namespace
End Namespace