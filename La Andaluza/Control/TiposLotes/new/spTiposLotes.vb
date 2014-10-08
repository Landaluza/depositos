

Public Class spTiposLotes
    Inherits Connection.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[TiposLotesSelect]",  _
                     "[dbo].[TiposLotesInsert]",  _
                     "[dbo].[TiposLotesUpdate]",  _
                     "[dbo].[TiposLotesDelete]",  _
                     "[dbo].[TiposLotesSelectDgv]",  _
                     "[dbo].[TiposLotesSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal TipoLoteID As Int32, ByRef dtb As Connection.DataBase) As DBO_TiposLotes
        Dim dbo As New DBO_TiposLotes
        dbo.searchKey = dbo.item("TipoLoteID")
        dbo.searchKey.value = TipoLoteID
        MyBase.Select_Record(CType(dbo, DataBussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal TipoLoteID As Int32, ByRef dtb As Connection.DataBase) As Boolean
        Dim dbo As New DBO_TiposLotes
        dbo.searchKey = dbo.item("TipoLoteID")
        dbo.searchKey.value = TipoLoteID
        Return MyBase.DeleteProcedure(CType(dbo, DataBussines), dtb)
    End Function

    Public Sub cargar_TiposLotes(ByRef cbo As ComboBox, Optional ByVal opcion As String = "")
        If opcion = String.Empty Then
            cbo.mam_DataSource("TiposLotesCbo", False)
        Else
            cbo.mam_DataSource("TiposLotesCbo", True, New Connection.DataBase(Config.Server), opcion)
        End If
    End Sub

    Public Function devolver_TiposLotes() As DataTable
        Dim dtb As New Connection.DataBase(Config.Server)
        Return dtb.Consultar("TiposLotesCbo", False)
    End Function

    Public Function DevolverPorDescripcion(ByVal Descripcion As String, ByRef dtb As Connection.DataBase) As DBO_TiposLotes
        Dim dbo As New DBO_TiposLotes
        dbo.searchKey = dbo.item("Descripcion")
        dbo.searchKey.value = Descripcion
        'MyBase.Select_Record(dbo, dtb)
        MyBase.Select_proc(CType(dbo, DataBussines), "TiposLotesByDescripcion", dtb)
        Return dbo
    End Function

End Class
