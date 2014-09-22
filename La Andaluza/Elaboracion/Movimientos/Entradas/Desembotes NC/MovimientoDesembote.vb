Public Class MovimientoDesemboteNC
    Inherits MovimientoEntrada


    Public Sub New()
        MyBase.New(Entradas.Entrada.DESEMBOTE_NO_COMFORME)
    End Sub


    Private Overloads Sub guardar()
        MyBase.bdEntrada.EmpezarTransaccion()

        Try

            MyBase.guardar()

            MyBase.bdEntrada.TerminarTransaccion()
            Me.gui.Close()

        Catch ex As Exception
            MyBase.bdEntrada.CancelarTransaccion()
        End Try
    End Sub
End Class
