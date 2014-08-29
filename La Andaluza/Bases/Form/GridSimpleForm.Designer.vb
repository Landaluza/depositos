<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gridsimpleform
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(gridsimpleform))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.eparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.butNuevo = New System.Windows.Forms.ToolStripButton()
        Me.butModificar = New System.Windows.Forms.ToolStripButton()
        Me.butVer = New System.Windows.Forms.ToolStripButton()
        Me.butEliminar = New System.Windows.Forms.ToolStripButton()
        Me.Separator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.butImprimir = New System.Windows.Forms.ToolStripButton()
        Me.butGuardar = New System.Windows.Forms.ToolStripButton()
        Me.butSalir = New System.Windows.Forms.ToolStripButton()
        Me.bdnGeneral = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.GeneralBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.butRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.butWord = New System.Windows.Forms.ToolStripButton()
        Me.butExcel = New System.Windows.Forms.ToolStripButton()
        Me.dgvGeneral = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.MyToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        CType(Me.bdnGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bdnGeneral.SuspendLayout()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = Global.La_Andaluza_MovimientosDepositos.My.Resources.Resources.glyphicons_171_fast_backward
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        resources.ApplyResources(Me.BindingNavigatorMoveFirstItem, "BindingNavigatorMoveFirstItem")
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = Global.La_Andaluza_MovimientosDepositos.My.Resources.Resources.glyphicons_170_step_backward
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        resources.ApplyResources(Me.BindingNavigatorMovePreviousItem, "BindingNavigatorMovePreviousItem")
        '
        'BindingNavigatorPositionItem
        '
        resources.ApplyResources(Me.BindingNavigatorPositionItem, "BindingNavigatorPositionItem")
        Me.BindingNavigatorPositionItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BindingNavigatorPositionItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        resources.ApplyResources(Me.BindingNavigatorCountItem, "BindingNavigatorCountItem")
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = Global.La_Andaluza_MovimientosDepositos.My.Resources.Resources.glyphicons_178_step_forward
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        resources.ApplyResources(Me.BindingNavigatorMoveNextItem, "BindingNavigatorMoveNextItem")
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = Global.La_Andaluza_MovimientosDepositos.My.Resources.Resources.glyphicons_177_fast_forward
        Me.BindingNavigatorMoveLastItem.Margin = New System.Windows.Forms.Padding(0, 1, 15, 2)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        resources.ApplyResources(Me.BindingNavigatorMoveLastItem, "BindingNavigatorMoveLastItem")
        '
        'eparator2
        '
        Me.eparator2.Name = "eparator2"
        resources.ApplyResources(Me.eparator2, "eparator2")
        '
        'butNuevo
        '
        resources.ApplyResources(Me.butNuevo, "butNuevo")
        Me.butNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.butNuevo.Image = Global.La_Andaluza_MovimientosDepositos.My.Resources.Resources.glyphicons_432_plus
        Me.butNuevo.Name = "butNuevo"
        '
        'butModificar
        '
        resources.ApplyResources(Me.butModificar, "butModificar")
        Me.butModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.butModificar.Image = Global.La_Andaluza_MovimientosDepositos.My.Resources.Resources.glyphicons_030_pencil
        Me.butModificar.Name = "butModificar"
        '
        'butVer
        '
        resources.ApplyResources(Me.butVer, "butVer")
        Me.butVer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.butVer.Image = Global.La_Andaluza_MovimientosDepositos.My.Resources.Resources.glyphicons_027_search
        Me.butVer.Name = "butVer"
        '
        'butEliminar
        '
        resources.ApplyResources(Me.butEliminar, "butEliminar")
        Me.butEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.butEliminar.Image = Global.La_Andaluza_MovimientosDepositos.My.Resources.Resources.glyphicons_433_minus
        Me.butEliminar.Name = "butEliminar"
        '
        'Separator3
        '
        Me.Separator3.Name = "Separator3"
        resources.ApplyResources(Me.Separator3, "Separator3")
        '
        'butImprimir
        '
        resources.ApplyResources(Me.butImprimir, "butImprimir")
        Me.butImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.butImprimir.Image = Global.La_Andaluza_MovimientosDepositos.My.Resources.Resources.glyphicons_015_print
        Me.butImprimir.Name = "butImprimir"
        '
        'butGuardar
        '
        resources.ApplyResources(Me.butGuardar, "butGuardar")
        Me.butGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.butGuardar.Image = Global.La_Andaluza_MovimientosDepositos.My.Resources.Resources.glyphicons_446_floppy_save
        Me.butGuardar.Name = "butGuardar"
        '
        'butSalir
        '
        Me.butSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        resources.ApplyResources(Me.butSalir, "butSalir")
        Me.butSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.butSalir.Image = Global.La_Andaluza_MovimientosDepositos.My.Resources.Resources.glyphicons_388_exit
        Me.butSalir.Name = "butSalir"
        '
        'bdnGeneral
        '
        Me.bdnGeneral.AddNewItem = Nothing
        resources.ApplyResources(Me.bdnGeneral, "bdnGeneral")
        Me.bdnGeneral.BackColor = System.Drawing.Color.White
        Me.bdnGeneral.BindingSource = Me.GeneralBindingSource
        Me.bdnGeneral.CountItem = Me.BindingNavigatorCountItem
        Me.bdnGeneral.DeleteItem = Nothing
        Me.bdnGeneral.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.bdnGeneral.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.butSalir, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorMoveNextItem, Me.butNuevo, Me.butModificar, Me.butEliminar, Me.eparator2, Me.butRefrescar, Me.butVer, Me.Separator3, Me.butImprimir, Me.butWord, Me.butGuardar, Me.butExcel, Me.BindingNavigatorCountItem, Me.BindingNavigatorPositionItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorMoveFirstItem})
        Me.bdnGeneral.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.bdnGeneral.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.bdnGeneral.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.bdnGeneral.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.bdnGeneral.Name = "bdnGeneral"
        Me.bdnGeneral.PositionItem = Me.BindingNavigatorPositionItem
        '
        'butRefrescar
        '
        resources.ApplyResources(Me.butRefrescar, "butRefrescar")
        Me.butRefrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.butRefrescar.Image = Global.La_Andaluza_MovimientosDepositos.My.Resources.Resources.glyphicons_080_retweet
        Me.butRefrescar.Name = "butRefrescar"
        '
        'butWord
        '
        resources.ApplyResources(Me.butWord, "butWord")
        Me.butWord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.butWord.Image = Global.La_Andaluza_MovimientosDepositos.My.Resources.Resources.glyphicons_039_notes
        Me.butWord.Name = "butWord"
        '
        'butExcel
        '
        resources.ApplyResources(Me.butExcel, "butExcel")
        Me.butExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.butExcel.Image = Global.La_Andaluza_MovimientosDepositos.My.Resources.Resources.glyphicons_040_stats
        Me.butExcel.Name = "butExcel"
        '
        'dgvGeneral
        '
        Me.dgvGeneral.AllowUserToAddRows = False
        Me.dgvGeneral.AllowUserToDeleteRows = False
        Me.dgvGeneral.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvGeneral.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvGeneral.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvGeneral.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvGeneral.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        resources.ApplyResources(Me.dgvGeneral, "dgvGeneral")
        Me.dgvGeneral.Name = "dgvGeneral"
        Me.dgvGeneral.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvGeneral.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvGeneral.RowHeadersVisible = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.NullValue = Nothing
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvGeneral.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvGeneral.RowTemplate.Height = 18
        Me.dgvGeneral.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImprimirToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        resources.ApplyResources(Me.ContextMenuStrip1, "ContextMenuStrip1")
        '
        'ImprimirToolStripMenuItem
        '
        Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        resources.ApplyResources(Me.ImprimirToolStripMenuItem, "ImprimirToolStripMenuItem")
        '
        'PrintDocument1
        '
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'gridsimpleform
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ControlBox = False
        Me.Controls.Add(Me.dgvGeneral)
        Me.Controls.Add(Me.bdnGeneral)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "gridsimpleform"
        CType(Me.bdnGeneral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bdnGeneral.ResumeLayout(False)
        Me.bdnGeneral.PerformLayout()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvGeneral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Protected WithEvents GeneralBindingSource As System.Windows.Forms.BindingSource
    Protected WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Protected WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Protected WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Protected WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Protected WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Protected WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Protected WithEvents eparator2 As System.Windows.Forms.ToolStripSeparator
    Protected WithEvents butNuevo As System.Windows.Forms.ToolStripButton
    Protected WithEvents butModificar As System.Windows.Forms.ToolStripButton
    Protected WithEvents butVer As System.Windows.Forms.ToolStripButton
    Protected WithEvents butEliminar As System.Windows.Forms.ToolStripButton
    Protected WithEvents Separator3 As System.Windows.Forms.ToolStripSeparator
    Protected WithEvents butImprimir As System.Windows.Forms.ToolStripButton
    Protected WithEvents butGuardar As System.Windows.Forms.ToolStripButton
    Protected WithEvents butSalir As System.Windows.Forms.ToolStripButton
    Protected WithEvents bdnGeneral As System.Windows.Forms.BindingNavigator
    Protected WithEvents dgvGeneral As System.Windows.Forms.DataGridView
    Protected WithEvents butExcel As System.Windows.Forms.ToolStripButton
    Protected WithEvents butWord As System.Windows.Forms.ToolStripButton
    Protected WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Protected WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Protected WithEvents ImprimirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Protected WithEvents MyToolTip As System.Windows.Forms.ToolTip
    Protected WithEvents butRefrescar As System.Windows.Forms.ToolStripButton
    Protected WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
