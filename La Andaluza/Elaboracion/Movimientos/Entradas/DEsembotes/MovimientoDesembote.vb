Public Class MovimientoDesembote
    Inherits Movimientos.MovimientoEntrada


    Public Sub New()
        MyBase.New(Movimientos.Entrada.DESEMBOTE)
        AddHandler gui.btnGuardar.Click, AddressOf guardar
    End Sub


    Private Overloads Sub guardar()
        MyBase.bdEntrada.EmpezarTransaccion()

        Try

            MyBase.guardar()

            MyBase.bdEntrada.TerminarTransaccion()
            Me.gui.Close()

        Catch ex As Exception
            MyBase.bdEntrada.CancelarTransaccion()
            MessageBox.Show(ex.Message, "Error al gaurdar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
End Class
