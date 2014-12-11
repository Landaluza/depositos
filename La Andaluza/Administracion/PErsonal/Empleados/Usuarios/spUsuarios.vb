

Public Class spUsuarios
    Inherits Connection.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[UsuariosSelect]", _
                        "[dbo].[UsuariosInsert]", _
                        "[dbo].[UsuariosUpdate]", _
                        "[dbo].[UsuariosDelete]", _
                        "[dbo].[UsuariosSelectDgv]", _
                        "[dbo].[UsuariosSelectDgvBy]")
    End Sub

    Public Overrides Function Delete(ByVal UsuarioID As Int32, ByRef dtb As Connection.DataBase) As Boolean
        Dim dbo As New DBO_Usuarios
        dbo.searchKey = dbo.item("UsuarioID")
        dbo.searchKey.value = UsuarioID
        Return MyBase.DeleteProcedure(CType(dbo, DataBussines), dtb)
    End Function

    Public Function select_record_by_usuario(ByVal usuario As String, ByRef dtb As Connection.DataBase) As DBO_Usuarios
        Dim dbo As New DBO_Usuarios
        dbo.searchKey = dbo.item("Usuario")
        dbo.searchKey.value = usuario
        MyBase.Select_proc(CType(dbo, DataBussines), "UsuariosSelectByUsuario", dtb)
        Return dbo
    End Function

    Public Function autentificar(ByVal login As String, ByVal pass As String) As Boolean
        Dim dbo As DBO_Usuarios
        Dim dt As DataTable
        Dim spTiposUsuarios As New spTiposUsuarios

        Try

            dt = dtb.Consultar("exec [UsuariosValidar] " & login & ", " & pass, False)

            If Convert.ToInt32(dt.Rows(0).Item(0)) > 0 Then
                dbo = select_record_by_usuario(login, dtb)

                Config.User = dbo.ID
                Config.UserType = dbo.TipoUsuarioID

                Config.dataFillNotificaction = False
                dtb.Consultar("select id from empleados where id_usuario= @id")
                dtb.AñadirParametroConsulta("@id", Config.User)
                Config.Worker = Convert.ToInt32(dtb.Consultar().Rows(0).Item(0))

                Return True
            Else
                ' messagebox.show("Contraseña incorrecta")
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
