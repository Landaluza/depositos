Public Class frmElaboraciones
    Private dt As DataTable
    Private dtb As Connection.DataBase
    Private frmMovimientos As frmMovimientos

    Public Sub New()
        InitializeComponent()

        dtb = New Connection.DataBase(Config.Server)
        dt = dtb.Consultar("SelectLotesElaboraciones", True)
        Me.frmMovimientos = New frmMovimientos
    End Sub

    Private Sub frmElaboraciones_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.dgvFill(dt)
    End Sub

    Private Sub dgvFill(Optional dt As DataTable = Nothing)
        If dt Is Nothing Then
            dt = dtb.Consultar("SelectLotesElaboraciones", True)
        End If

        If Not dt Is Nothing Then
            With DataGridView1
                .DataSource = dt

                .Columns("LoteID").Visible = False
                .FormatoColumna("Fecha", TiposColumna.FechaCorta, , 0)
                .FormatoColumna("CodigoLote", TiposColumna.Izquierda, 114, 1)
                .FormatoColumna("Descripcion", TiposColumna.Izquierda, 280, 2)
                .FormatoColumna("Deposito previo", TiposColumna.Derecha, 56, 3)
                .FormatoColumna("Deposito", "Deposito final", TiposColumna.Derecha, 56, 4)
                .FormatoColumna("CantidadRestante", "Restante", TiposColumna.Miles, 65, 5)
                .FormatoColumna("Observacion", TiposColumna.Izquierda, 520, 6)
                .FormatoGeneral()
                .MoveLast()
            End With
        End If
    End Sub

    Private Sub tsEliminar_Click(sender As System.Object, e As System.EventArgs) Handles tsEliminar.Click
        If Not DataGridView1.CurrentRow Is Nothing Then
            Dim res As DialogResult = MessageBox.Show("¿Eliminar todos los registros?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If res = Windows.Forms.DialogResult.Yes Then
                If eliminar_elaboracion(Convert.ToInt32(Me.DataGridView1.CurrentRow.Cells("LoteID").Value)) Then
                    dgvFill()
                End If
            End If
        End If
    End Sub

    Private Function eliminar_elaboracion(ByVal loteId As Integer) As Boolean
        'Dim frm As New frmResumenEliminarElaboracion(loteId)
        'frm.ShowDialog()
        'Return frm.retorno
        Cursor = Cursors.WaitCursor
        dtb.EmpezarTransaccion()


        Try
            If Not frmMovimientos.EliminarTodos(dtb) Then Throw New Exception("Fallo al eliminar los movimientos de la elaboracion")
            ' Me.frmMovimientos.Eliminar()
            If Not dtb.ConsultaAlteraciones("exec EliminarElaboracionDesdeLote " & loteId) Then Throw New Exception("Fallo eliminando la elaboracion")
            dtb.TerminarTransaccion()
            Return True
        Catch ex As Exception
            dtb.CancelarTransaccion()
            MessageBox.Show("No se pudo completar la operación. Detalles: " & Environment.NewLine & ex.Message)
            Return False
        Finally
            Cursor = Cursors.Default
        End Try
    End Function

    Private Sub DataGridView1_SelectionChanged(sender As System.Object, e As System.EventArgs)
        If Not DataGridView1.CurrentRow Is Nothing Then
            frmMovimientos.cargar_por_lote(Convert.ToInt32(Me.DataGridView1.CurrentRow.Cells("LoteID").Value))
        End If
    End Sub

    Private Sub frmElaboraciones_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        Engine_LA.FormEnPestaña(Me.frmMovimientos, Me.SplitContainer1.Panel2)
        AddHandler DataGridView1.SelectionChanged, AddressOf DataGridView1_SelectionChanged
        If Not DataGridView1.CurrentRow Is Nothing Then
            frmMovimientos.cargar_por_lote(Convert.ToInt32(Me.DataGridView1.CurrentRow.Cells("LoteID").Value))
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        dgvFill()
    End Sub
End Class