<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProcesosAbiertos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProcesosAbiertos))
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsCompacto = New System.Windows.Forms.ToolStripButton()
        Me.tsDetallado = New System.Windows.Forms.ToolStripButton()
        Me.tsTrasiegos = New System.Windows.Forms.ToolStripButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 25)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(768, 415)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsCompacto, Me.tsDetallado, Me.tsTrasiegos})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(768, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsCompacto
        '
        Me.tsCompacto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsCompacto.Image = Global.La_Andaluza_MovimientosDepositos.My.Resources.Resources.emblem_documents
        Me.tsCompacto.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsCompacto.Name = "tsCompacto"
        Me.tsCompacto.Size = New System.Drawing.Size(23, 22)
        Me.tsCompacto.Text = "Vista simple"
        Me.tsCompacto.ToolTipText = "Vsita simple"
        '
        'tsDetallado
        '
        Me.tsDetallado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsDetallado.Image = CType(resources.GetObject("tsDetallado.Image"), System.Drawing.Image)
        Me.tsDetallado.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsDetallado.Name = "tsDetallado"
        Me.tsDetallado.Size = New System.Drawing.Size(23, 22)
        Me.tsDetallado.Text = "Vista detallada"
        '
        'tsTrasiegos
        '
        Me.tsTrasiegos.Image = CType(resources.GetObject("tsTrasiegos.Image"), System.Drawing.Image)
        Me.tsTrasiegos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsTrasiegos.Name = "tsTrasiegos"
        Me.tsTrasiegos.Size = New System.Drawing.Size(77, 22)
        Me.tsTrasiegos.Text = "Trasiegos"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.ColumnHeadersVisible = False
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 25)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(768, 415)
        Me.DataGridView1.TabIndex = 2
        '
        'frmProcesosAbiertos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 440)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmProcesosAbiertos"
        Me.Text = "Movimientos Abiertos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Private WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsCompacto As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsDetallado As System.Windows.Forms.ToolStripButton
    Private WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents tsTrasiegos As System.Windows.Forms.ToolStripButton
End Class
