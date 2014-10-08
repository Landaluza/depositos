Namespace Movimientos
    Public Class BdMovimientos
        Inherits Connection.DataBase
        Private query As String
        Public Sub New()
            MyBase.New(Config.Server)
        End Sub


        Public Function seleccionar_tipo_proceso(ByVal proceso As Integer) As DataTable
            query = "select descripcion, tipomovimientoID from procesos where procesoid = @proc"
            PrepararConsulta(query)
            AñadirParametroConsulta("@proc", proceso)
            Return Consultar()
        End Function
    End Class
End Namespace
