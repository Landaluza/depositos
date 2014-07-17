Public Class frmTrasiego
    Inherits frmProceso

    Private trasiegosEng As EngineTrasiegos

    Public Sub New(ByVal id As Integer)

        InitializeComponent()

        Me.pbIconoOperacion.Image = My.Resources.trasiego
        trasiegosEng = New EngineTrasiegos(id)

    End Sub


    Private Sub frmTrasiego_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        trasiegosEng.setvalues(Me.cboDepositoOrigen, Me.cboDepositoDestino, Me.txtCantidad, Me.cboProducto, cboLote)
    End Sub

    Private Sub autoguardado() Handles cboDepositoDestino.SelectedValueChanged, cboDepositoOrigen.SelectedValueChanged, cboLote.SelectedValueChanged, cboProducto.SelectedValueChanged, txtCantidad.TextChanged
        trasiegosEng.actualizar(Me.cboDepositoOrigen, Me.cboDepositoDestino, Me.txtCantidad, Me.cboProducto, Me.cboLote)
    End Sub

    Protected Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        If trasiegosEng.borrar_proceso_abierto() Then
            Me.Close()
        End If
    End Sub


    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Dim frm As New frmEntMovimientosCopy
        frm.Show()
        frm.CargarDatos(0, 0, New Date, CType(Me.txtCantidad.Text, Double), "", EngineProcesosAbiertos.TRASIEGO.ToString, cboDepositoDestino.SelectedValue.ToString, cboDepositoOrigen.SelectedValue.ToString, "", New DataBase(Config.Server))
        frm.cboProceso.SelectedValue = EngineProcesosAbiertos.TRASIEGO

    End Sub
End Class