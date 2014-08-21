Public Class frmNoticias2
    Inherits GridSimpleForm

    Private dboNoticias2 As DBO_Noticias

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spNoticias, MaestroID.ToString)
        InitializeComponent()

        dboNoticias2 = New DBO_Noticias


        'sp.DataGridViewStoredProcedure = sp.DataGridViewStoredProcedureForFilteredSelect & "'" & Me.m_MaestroID & "'"
        MyBase.newRegForm = CType(New frmEntNoticias2(gridsimpleform.ACCION_VER, CType(sp, spNoticias)), DetailedSimpleForm)

        Me.dgvGeneral.RowHeadersVisible = False
        Me.dgvGeneral.ColumnHeadersVisible = False
        Me.dgvGeneral.CellBorderStyle = DataGridViewCellBorderStyle.None
        Me.dgvGeneral.DefaultCellStyle.BackColor = Color.White
        'Me.dgvGeneral.DefaultCellStyle.ForeColor = Control.DefaultBackColor
        Me.dgvGeneral.DefaultCellStyle.SelectionBackColor = Color.White
        'Me.dgvGeneral.DefaultCellStyle.SelectionForeColor = Color.Transparent
        Me.dgvGeneral.BackgroundColor = Color.White
        Me.dgvGeneral.SelectionMode = DataGridViewSelectionMode.CellSelect
        dgvGeneral.GridColor = Color.White
        dgvGeneral.BorderStyle = BorderStyle.None
        dgvGeneral.AllowUserToResizeColumns = False
        dgvGeneral.AllowUserToResizeRows = False
        dgvGeneral.MultiSelect = False
    End Sub

    Private Sub frmNoticias2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MyBase.bdnGeneral.Visible = False
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        EventHandeld = True
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboNoticias2 = CType(sp, spNoticias).Select_Record(CType(dgvGeneral.CurrentRow.Cells("Id").Value, Integer), dtb)
        If Not dboNoticias2 Is Nothing Then
            newRegForm.SetDataBussinesObject(CType(Me.dboNoticias2, databussines))
        Else
            MyBase.EventHandeld = True
            Messagebox.show("No se pudo recuperar los datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Protected Overrides Sub BindDataSource()

        If Not dataSource Is Nothing Then
            GeneralBindingSource.DataSource = datasource
            With dgvGeneral
                .DataSource = GeneralBindingSource
                .Columns("Id").Visible = False
                .Columns("Texto").Visible = False
                .Columns("Vigente").Visible = False
                .FormatoColumna("Titulo", TiposColumna.Izquierda, True, 2)
                .FormatoColumna("Fecha", TiposColumna.FechaCorta, 100, 1)

            End With
        End If

        For Each row As DataGridViewRow In dgvGeneral.Rows
            For Each cell As DataGridViewCell In row.Cells
                cell.ToolTipText = row.Cells("Texto").Value.ToString
            Next
        Next

    End Sub

    Public Sub refrescar()
        dgvFill()
    End Sub
End Class
