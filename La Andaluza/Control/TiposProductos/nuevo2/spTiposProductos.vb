

Public Class spTiposProductos
    Inherits Connection.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[TiposProductosSelect]",  _
                     "[dbo].[TiposProductosInsert]",  _
                     "[dbo].[TiposProductosUpdate]",  _
                     "[dbo].[TiposProductosDelete]",  _
                     "[dbo].[TiposProductosSelectDgv]",  _
                     "[dbo].[TiposProductosSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal TipoProductoID As Int32, ByRef dtb As Connection.DataBase) As DBO_TiposProductos
        Dim dbo As New DBO_TiposProductos
        dbo.searchKey = dbo.item("TipoProductoID")
        dbo.searchKey.value = TipoProductoID
        MyBase.Select_Record(CType(dbo, DataBussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal TipoProductoID As Int32, ByRef dtb As Connection.DataBase) As Boolean
        Dim dbo As New DBO_TiposProductos
        dbo.searchKey = dbo.item("TipoProductoID")
        dbo.searchKey.value = TipoProductoID
        Return MyBase.DeleteProcedure(CType(dbo, DataBussines), dtb)
    End Function

    Public Sub cargar_ComboBox_Enologicos(ByRef cbo As ComboBox, Optional ByVal primeraCelda As String = "")
        If primeraCelda = String.Empty Then
            cbo.mam_DataSource("[TiposProductosSelectCboEnologicos]", False)
        Else
            cbo.mam_DataSource("[TiposProductosSelectCboEnologicos]", True, New Connection.DataBase(Config.Server), primeraCelda)
        End If
    End Sub

    Public Sub cargar_ComboBox(ByRef cbo As ComboBox, Optional ByVal primeracelda As String = "")
        If primeracelda = String.Empty Then
            cbo.mam_DataSource("TiposProductosSelectCbo", False)
        Else
            cbo.mam_DataSource("TiposProductosSelectCbo", False, New Connection.DataBase(Config.Server), primeracelda)
        End If
    End Sub

    Public Sub cargar_ComboBox_datos_completos(ByRef cbo As ComboBox)
        cbo.mam_DataSource("[dbo].[TiposProductosSelectDgv]", False)
    End Sub

    Public Function devolver_TiposProductos_Cbo(ByRef dtb As Connection.DataBase) As DataTable
        Return dtb.Consultar("TiposProductosSelectCbo", True)
    End Function

    Public Function devolver_TiposProductos_No_enologicos(ByRef dtb As Connection.DataBase) As DataTable

        Return dtb.Consultar("TiposProductosSelectCboNoEnologicos", True)
    End Function

    Public Function devolver_TiposProductos_Enologicos(ByRef dtb As Connection.DataBase) As DataTable

        Return dtb.Consultar("TiposProductosSelectCboEnologicos", True)
    End Function

    Public Function devolver_TiposProductos(ByRef dtb As Connection.DataBase) As DataTable

        Return dtb.Consultar("[dbo].[TiposProductosSelectDgv]", True)
    End Function

    Public Sub cargar_ComboBox_No_enologicos(ByRef cbo As ComboBox, Optional ByVal primeraCelda As String = "")
        If primeraCelda = String.Empty Then
            cbo.mam_DataSource("[TiposProductosSelectCboNoEnologicos]", False)
        Else
            cbo.mam_DataSource("[TiposProductosSelectCboNoEnologicos]", True, New Connection.DataBase(Config.Server), primeraCelda)
        End If
    End Sub

    Public Sub cargar_ComboBox_para_envasado(ByRef cbo As ComboBox, ByVal formatoLinea As Integer)
        cbo.mam_DataSource("TiposProductosCboFormatosEnvasados " & formatoLinea, False)
    End Sub

    Public Sub cargar_ComboBox_para_envasado_por_Linea(ByRef cbo As ComboBox, ByVal Linea As Integer)
        cbo.mam_DataSource("TiposProductosCboFormatosEnvasadosAll " & Linea, False)
    End Sub

    Sub cargar_MedidasProductos(ByRef cbo As ComboBox)
        cbo.mam_DataSource("MedidasProductosSelectCbo", False)
    End Sub

End Class
