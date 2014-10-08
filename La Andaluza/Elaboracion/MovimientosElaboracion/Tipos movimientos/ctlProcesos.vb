Public Class ctlProcesos

    Private clsPro As clsProcesos

    Public Sub New()
        clsPro = New clsProcesos
    End Sub

    Public Sub SetProcesoID(ByVal ID As Integer)
        clsPro._ProcesoID = ID
    End Sub

    Public Function devolverTipoMovimientoPorDescripcion(ByVal Descrip As String, ByRef dtb As Connection.DataBase) As String
        clsPro._Descripcion = Descrip
        clsPro.devolverTipoMovimientoPorDescripcion(dtb)
        Return clsPro._TipoMovimiento
    End Function

    Public Sub cargarProceso(ByRef TipoProductoParaLote As String, ByRef TipoMovimiento As String, ByRef TipoLoteID As Integer, ByRef conMuestra As Boolean, ByRef dtb As Connection.DataBase)
        clsPro.Cargar(dtb)
        TipoProductoParaLote = clsPro._TipoProductoParaLote
        TipoMovimiento = clsPro._TipoMovimiento
        TipoLoteID = clsPro._TipoLoteID
        conMuestra = clsPro._ConMuestra
    End Sub

    Public Function devolverProcesosPorDescripcion(ByRef dtb As Connection.DataBase) As DataTable
        Return clsPro.devolverProcesosPorDescripcion(dtb)
    End Function

End Class
