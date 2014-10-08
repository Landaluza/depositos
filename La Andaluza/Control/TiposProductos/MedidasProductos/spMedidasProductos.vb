

Public Class spMedidasProductos
    Inherits Connection.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[MedidasProductosSelect]", _
                        "[dbo].[MedidasProductosInsert]", _
                        "[dbo].[MedidasProductosUpdate]", _
                        "[dbo].[MedidasProductosDelete]", _
                        "[dbo].[MedidasProductosSelectDgv]", _
                        "[dbo].[MedidasProductosSelectDgvBy]")
    End Sub

    Public Overloads Function Select_Record(ByVal MedidaID As Int32, ByRef dtb As Connection.DataBase) As DBO_MedidasProductos
        Dim dbo As New DBO_MedidasProductos
        dbo.searchKey = dbo.item("MedidaID")
        dbo.searchKey.value = MedidaID
        MyBase.Select_Record(CType(dbo, DataBussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal MedidaID As Int32, ByRef dtb As Connection.DataBase) As Boolean
        Dim dbo As New DBO_MedidasProductos
        dbo.searchKey = dbo.item("MedidaID")
        dbo.searchKey.value = MedidaID
        Return MyBase.DeleteProcedure(CType(dbo, DataBussines), dtb)
    End Function

    Public Sub cargar_MedidasProductos(ByRef cbo As ComboBox)
        cbo.mam_DataSource("MedidasProductosCbo", False)
    End Sub

    Public Function devolver_MedidasProductos() As DataTable
        Dim dtb As New Connection.DataBase(Config.Server)
        Return dtb.Consultar("MedidasProductosCbo", True)
    End Function
End Class
