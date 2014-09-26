Public Class frmMovimientos
    Inherits FrmAheredarOld

    Private ctlMov As ctlMovimientos
    Private dtsMov As dtsMovimientos.MovimientosDataTable
    Private btnRefresh As ToolStripItem
    Private FrmEnt As frmEntMovimientosCopy

    Public Sub New()
        MyBase.New()
        InitializeComponent()

        spSelectDgv = "MovimientosSelectDgv2_300"
        ctlMov = New ctlMovimientos
        dtsMov = New dtsMovimientos.MovimientosDataTable

        btnRefresh = Me.bdnGeneral.Items.Add("Mostrar todos los registros")
        btnRefresh.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
        btnRefresh.Text = "Mostrar todos los registros"
        btnRefresh.TextDirection = ToolStripTextDirection.Horizontal
        btnRefresh.TextAlign = ContentAlignment.MiddleRight
        'refresh100.DisplayStyle = ToolStripItemDisplayStyle.Image
        btnRefresh.Image = My.Resources.glyphicons_080_retweet
        AddHandler btnRefresh.Click, AddressOf toolStripRefresh_Click
    End Sub
    Private Sub frmMovimientos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        butVer.Visible = False
        butModificar.Visible = False
    End Sub

    Protected Overrides Sub cargar_datos()
        dataSource = dtb.Consultar(spSelectDgv)
    End Sub
    Protected Overrides Sub BindDataSource()

        If Not dataSource Is Nothing Then
            GeneralBindingSource.DataSource = dataSource

            With dgvGeneral
                .DataSource = GeneralBindingSource
                .Columns("MovimientoID").Visible = False

                .FormatoColumna("Fecha", "Fecha", TiposColumna.FechaCorta, , 0)
                .FormatoColumna("DepositosSalida", "De", TiposColumna.Derecha, 110, 1)
                .FormatoColumna("Cantidad", "Cantidad", TiposColumna.Miles, 65, 2)
                .FormatoColumna("DepositosEntrada", "A", TiposColumna.Derecha, 110, 3)
                .FormatoColumna("Procesos", "Proceso", TiposColumna.Izquierda, 142, 4)
                .FormatoColumna("Observaciones", "Observaciones", TiposColumna.Izquierda, 280, 5)
                .FormatoColumna("Lotes", "Producto", TiposColumna.Izquierda, 183, 6)
                .FormatoColumna("Descripcion", TiposColumna.Izquierda, True, 7)
            End With
            'GeneralBindingSource.Position = dgvGeneral.RowCount - 1

        End If
    End Sub

    Overrides Sub Insertar()
        FrmEnt = New frmEntMovimientosCopy
        FrmEnt.Text = "Insertar Movimientos"
        FrmEnt.CargarDatos(0, 0, Today, 0, "", "0", "0", "0", "0", dtb)
        'FrmEnt.ShowDialog()
        Pantalla.mostrarDialogo(FrmEnt)
        'ctlMov.mostrarTodosMovimientos(dtsMov)
        Me.dgvFill()
        ' GeneralBindingSource.Position = 1
        ' GeneralBindingSource.Position = 0
    End Sub

    Overrides Sub Eliminar()

        'Me.Cursor = Cursors.WaitCursor

        'Dim Posicion As Integer = GeneralBindingSource.Position
        'If Posicion >= 0 Then
        '    Dim response As DialogResult
        '    response = MessageBox.Show(" ¿Realmente desea eliminar este registro? ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        '    If response = DialogResult.Yes Then
        '        ctlMov.SetMovimientoID(Convert.ToInt32(dgvGeneral.Rows(Posicion).Cells(0).Value))

        '        If ctlMov.EliminarMovimiento() Then
        '            ctlMov.mostrarTodosMovimientos(dtsMov, dtb)
        '            Dim ctlPro As New ctlProcesos

        '            If ctlPro.devolverTipoMovimientoPorDescripcion(dgvGeneral.Rows(Posicion).Cells(4).Value.ToString, dtb) = "E" Then
        '                MessageBox.Show("Por favor verificar manualmente la necesidad del lote de recepcion " & Convert.ToString(dgvGeneral.Rows(Posicion).Cells(5).Value))
        '            End If

        '            If Posicion > 0 Then
        '                GeneralBindingSource.Position = Posicion - 1
        '            Else
        '                GeneralBindingSource.Position = 0
        '            End If
        '        Else
        '            MessageBox.Show("No se pudo eliminar el movimiento", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '        End If
        '    End If
        'Else
        '    MessageBox.Show("Seleccionar alguna celda", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        'End If

        'Me.Cursor = Cursors.Default

        'PRUEBA
        'Dim dtb As New DataBase(Config.Server)
        'Dim dt As DataTable = dtb.Consultar("select movimientoid from movimientos", False)
        'Dim frm As frmResumenBorradoDeposito

        'For Each row As DataRow In dt.Rows
        '    frm = New frmResumenBorradoDeposito(Convert.ToInt32(row.Item(0)))
        '    frm.setValues()
        '    frm.eliminar()
        'Next

        'VERSION PRODUCCION
        If Not dgvGeneral.CurrentRow.Cells(0).Value Is Nothing Then

            If MessageBox.Show(" ¿Realmente desea eliminar este registro? ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                Dim frm As New frmResumenBorradoDeposito(Convert.ToInt32(dgvGeneral.CurrentRow.Cells(0).Value))
                Dim result As DialogResult = frm.ShowDialog()
                If result <> Windows.Forms.DialogResult.Cancel Then
                    Me.dgvFill()
                End If
            End If
        Else
            MessageBox.Show("Seleccionar un registro", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Function EliminarTodos(ByRef dtb As DataBase) As Boolean
        Dim ctlPro As New ctlProcesos

        For Each row As DataGridViewRow In dgvGeneral.Rows
            ctlMov.SetMovimientoID(Convert.ToInt32(row.Cells(0).Value))

            If Not ctlMov.EliminarMovimiento(dtb) Then
                Return False
            End If
        Next


        Return True
    End Function

    Private Sub toolStripRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.btnRefresh.Text = "Mostrar todos los registros" Then
            Me.spSelectDgv = "MovimientosSelectDgv2"
            Me.dgvFill()
            Me.btnRefresh.Text = "Mostrar los ultimos 300 registros"
        Else
            Me.spSelectDgv = "MovimientosSelectDgv2_300"
            Me.dgvFill()
            Me.btnRefresh.Text = "Mostrar todos los registros"
        End If
    End Sub

    Sub cargar_por_lote(lote As Integer)
        Me.spSelectDgv = "MovimientosSelectDgv2ByLote " & lote
        Me.dgvFill()
    End Sub
End Class
