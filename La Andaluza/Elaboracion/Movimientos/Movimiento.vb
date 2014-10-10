Namespace Movimientos
    Public Class Movimiento
        Private proceso As Movimientos.Proceso
        Private gui As Form
        Private bdmovimientos As BdMovimientos
        Public ReadOnly Property Form As Form
            Get
                Return CType(gui, Form)
            End Get
        End Property

        Public Sub New(ByVal proceso As Integer)

            Me.bdmovimientos = New BdMovimientos
            Me.proceso = New Movimientos.Proceso

            Me.proceso.identificador = proceso

            Dim dtproceso As DataTable = bdmovimientos.seleccionar_tipo_proceso(proceso)
            Me.proceso.nombre = Convert.ToString(dtproceso.Rows(0).Item(0))
            Me.proceso.tipo = Convert.ToInt32(dtproceso.Rows(0).Item(1))

            Select Case Me.proceso.tipo
                Case 6
                    Dim mov As New MovimientoEntrada(Me.proceso.identificador)
                    Me.gui = mov.Form
                    Me.gui.Text = Me.proceso.nombre
                Case 2
                    Dim mov As New MovimientoFiltrado(Me.proceso.identificador)
                    Me.gui = mov.Form
                    Me.gui.Text = Me.proceso.nombre
                Case 5
                    Dim mov As New MovimientoSalida(Me.proceso.identificador)
                    Me.gui = mov.Form
                    Me.gui.Text = Me.proceso.nombre
                Case 8
                    Dim mov As New MovimientoDiferencia(Me.proceso.identificador)
                    Me.gui = mov.Form
                    Me.gui.Text = Me.proceso.nombre
                Case Else
                    Dim mov As New MovimientoTrasiego(Me.proceso.identificador)
                    Me.gui = mov.Form
                    Me.gui.Text = Me.proceso.nombre
            End Select
        End Sub
    End Class
End Namespace
