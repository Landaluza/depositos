
Namespace Movimientos
    Namespace Tipos

Public Class Db
    Inherits StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[TiposMovimientosSelect]", _
                      "[dbo].[TiposMovimientosInsert]", _
                      "[dbo].[TiposMovimientosUpdate]", _
                      "[dbo].[TiposMovimientosDelete]", _
                      "[dbo].[TiposMovimientosSelectDgv]", _
                      "[dbo].[TiposMovimientosSelectDgvBy]")
    End Sub

    Public Overloads Function Select_Record(ByVal Id As Integer, Optional ByRef dtb As DataBase = Nothing) As Tipos
        If dtb Is Nothing Then dtb = New DataBase(Config.Server)
        Dim dbo As New Tipos
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(CType(dbo, DataBussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Integer, ByRef dtb As DataBase) As Boolean
        Dim dbo As New Tipos
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        Return MyBase.DeleteProcedure(CType(dbo, DataBussines), dtb)
    End Function

    Public Sub cargar_TiposMovimientos(ByRef cbo As ComboBox)
        cbo.mam_DataSource("TiposMovimientosCbo", False)
    End Sub

End Class
    End Namespace

End Namespace
