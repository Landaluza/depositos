Namespace Movimientos
    Public Class MovimientoCompra
        Inherits MovimientoEntrada


        Public Sub New()
            MyBase.New(Movimientos.Entrada.COMPRA)
            AddHandler gui.btnGuardar.Click, AddressOf guardar
        End Sub


        Private Overloads Sub guardar()
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
                MessageBox.Show(ex.Message, "Error al gaurdar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End Sub
    End Class
End Namespace
