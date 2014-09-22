Public Class MovimientoCompra
    Inherits MovimientoEntrada


    Public Sub New()
        MyBase.New(Entradas.Entrada.COMPRA)
    End Sub


    Private Sub guardar()
        MyBase.bdEntrada.EmpezarTransaccion()

        Try

            MyBase.guardar()

            If Not bdEntrada.actualizar_proveedor_lote(compra.lotePartida.codigo_lote, compra.proveedorCompra) Then
                Throw New Exception("No se pudo guardar el proveedor del lote compra")
            End If

            MyBase.bdEntrada.TerminarTransaccion()
            Me.gui.Close()

        Catch ex As Exception
            MyBase.bdEntrada.CancelarTransaccion()
        End Try
    End Sub
End Class
