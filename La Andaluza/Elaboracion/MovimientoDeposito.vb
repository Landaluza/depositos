Public Class MovimientoDeposito
    Private dtb As DataBase

    Public Sub New()
        dtb = New DataBase(Config.Server)
    End Sub



    Public Function tieneTrazabilidad(ByVal movimientoid As Integer) As Boolean
        Dim dt As DataTable = dtb.Consultar("select count(*) from compuestoPor where movimientoid = " & movimientoid, False)

        If dt Is Nothing Then Return False

        If Convert.ToInt32(dt.Rows(0).Item(0)) > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function recuperarLoteMovimiento(ByVal movimientoId As Integer) As Integer
        Dim dt As DataTable = dtb.Consultar("select loteid from movimientos where movimientoid = " & movimientoId, False)

        If dt Is Nothing Then Return 0

        Return Convert.ToInt32(dt.Rows(0).Item(0))
    End Function

    Public Function actualizarValoresLote(ByVal loteid As Integer, ByVal movimientoid As Integer) As Boolean
        If Not dtb.ConsultaAlteraciones("update lotes set cantidadrestante = cantidadrestante+(select cantidad from movimientos where movimientoid = " & movimientoid & ") where loteid=" & loteid) Then
            Return False
        End If

        If Not dtb.ConsultaAlteraciones("update lotes set depositoid = depositoprevioid where loteid=" & loteid) Then
            Return False
        End If

        Return True
    End Function

    Public Function borrarMovimiento(ByVal movimientoid As Integer) As Boolean
        If Not dtb.ConsultaAlteraciones("delete from movimientos where movimientoid=" & movimientoid) Then
            Return False
        End If

        Return True
    End Function
End Class
