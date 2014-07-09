Public Class ctlCompuestoPor
    Private clsCom As clsCompuestoPor

    Public Sub New()
        clsCom = New clsCompuestoPor
    End Sub
    Public Function GetLoteFinal() As Integer
        Return clsCom._LoteFinal
    End Function

    Public Sub SetLoteFinal(ByVal ID As Integer)
        clsCom._LoteFinal = ID
    End Sub

    Public Sub SetLotePartida(ByVal ID As Integer)
        clsCom._LotePartida = ID
    End Sub

    Public Function GetCantidad() As Double
        Return clsCom._Cantidad
    End Function

    Public Sub SetCantidad(ByVal Cantidad As Double)
        clsCom._Cantidad = Cantidad
    End Sub

    Public Function GuardarCompuestoPor(ByVal LoteFinal As Integer, _
                                   ByVal LotePartida As Integer, _
                                   ByVal MovimientoID As Integer, _
                                   ByVal Cantidad As Double, ByRef dtb As DataBase) As Boolean

        clsCom._LoteFinal = LoteFinal
        clsCom._LotePartida = LotePartida
        clsCom._MovimientoID = MovimientoID
        clsCom._Cantidad = Cantidad
        Return clsCom.Insertar(dtb)
    End Function

    Public Function RevertirMovimiento(ByRef dtb As DataBase) As Boolean
        Return clsCom.RevertirMovimiento(dtb)
    End Function

    Public Function DevolverCompuestosPorMovimiento(ByVal MovID As Integer, ByRef dtb As DataBase) As DataTable
        clsCom._MovimientoID = MovID
        Return clsCom.DevolverPorMovimiento(dtb)
    End Function

    Public Function EliminarCompuestoPor(ByRef dtb As DataBase) As Boolean
        Return clsCom.Eliminar(dtb)
    End Function
End Class
