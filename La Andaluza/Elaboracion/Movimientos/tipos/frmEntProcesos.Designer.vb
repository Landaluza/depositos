<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntProcesos
    Inherits DetailedSimpleForm

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntProcesos))
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtTipoProductoParaLote = New System.Windows.Forms.TextBox()
        Me.txtTipoMovimiento = New System.Windows.Forms.TextBox()
        Me.cboTipoLote = New System.Windows.Forms.ComboBox()
        Me.chbConMuestra = New System.Windows.Forms.CheckBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblTipoProductoParaLote = New System.Windows.Forms.Label()
        Me.lblTipoMovimiento = New System.Windows.Forms.Label()
        Me.lblTipoLoteID = New System.Windows.Forms.Label()
        Me.lblConMuestra = New System.Windows.Forms.Label()
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMiddle.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(149, 18)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(200, 21)
        Me.txtDescripcion.TabIndex = 0
        '
        'txtTipoProductoParaLote
        '
        Me.txtTipoProductoParaLote.BackColor = System.Drawing.SystemColors.Window
        Me.txtTipoProductoParaLote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoProductoParaLote.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTipoProductoParaLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoProductoParaLote.Location = New System.Drawing.Point(149, 45)
        Me.txtTipoProductoParaLote.MaxLength = 1
        Me.txtTipoProductoParaLote.Name = "txtTipoProductoParaLote"
        Me.txtTipoProductoParaLote.Size = New System.Drawing.Size(200, 21)
        Me.txtTipoProductoParaLote.TabIndex = 1
        '
        'txtTipoMovimiento
        '
        Me.txtTipoMovimiento.BackColor = System.Drawing.SystemColors.Window
        Me.txtTipoMovimiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoMovimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTipoMovimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoMovimiento.Location = New System.Drawing.Point(149, 72)
        Me.txtTipoMovimiento.MaxLength = 1
        Me.txtTipoMovimiento.Name = "txtTipoMovimiento"
        Me.txtTipoMovimiento.Size = New System.Drawing.Size(200, 21)
        Me.txtTipoMovimiento.TabIndex = 2
        '
        'cboTipoLote
        '
        Me.cboTipoLote.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboTipoLote.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTipoLote.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboTipoLote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboTipoLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoLote.Location = New System.Drawing.Point(149, 99)
        Me.cboTipoLote.Name = "cboTipoLote"
        Me.cboTipoLote.Size = New System.Drawing.Size(200, 23)
        Me.cboTipoLote.TabIndex = 3
        '
        'chbConMuestra
        '
        Me.chbConMuestra.BackColor = System.Drawing.SystemColors.Control
        Me.chbConMuestra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chbConMuestra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbConMuestra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbConMuestra.Location = New System.Drawing.Point(149, 128)
        Me.chbConMuestra.Name = "chbConMuestra"
        Me.chbConMuestra.Size = New System.Drawing.Size(200, 21)
        Me.chbConMuestra.TabIndex = 4
        Me.chbConMuestra.UseVisualStyleBackColor = False
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDescripcion.Location = New System.Drawing.Point(23, 15)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(120, 27)
        Me.lblDescripcion.TabIndex = 0
        Me.lblDescripcion.Text = "Descripcion"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTipoProductoParaLote
        '
        Me.lblTipoProductoParaLote.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTipoProductoParaLote.Location = New System.Drawing.Point(23, 42)
        Me.lblTipoProductoParaLote.Name = "lblTipoProductoParaLote"
        Me.lblTipoProductoParaLote.Size = New System.Drawing.Size(120, 27)
        Me.lblTipoProductoParaLote.TabIndex = 1
        Me.lblTipoProductoParaLote.Text = "Tipo producto para lote"
        Me.lblTipoProductoParaLote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTipoMovimiento
        '
        Me.lblTipoMovimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTipoMovimiento.Location = New System.Drawing.Point(23, 69)
        Me.lblTipoMovimiento.Name = "lblTipoMovimiento"
        Me.lblTipoMovimiento.Size = New System.Drawing.Size(120, 27)
        Me.lblTipoMovimiento.TabIndex = 2
        Me.lblTipoMovimiento.Text = "Tipo movimiento"
        Me.lblTipoMovimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTipoLoteID
        '
        Me.lblTipoLoteID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTipoLoteID.Location = New System.Drawing.Point(23, 96)
        Me.lblTipoLoteID.Name = "lblTipoLoteID"
        Me.lblTipoLoteID.Size = New System.Drawing.Size(120, 29)
        Me.lblTipoLoteID.TabIndex = 3
        Me.lblTipoLoteID.Text = "Tipolote"
        Me.lblTipoLoteID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblConMuestra
        '
        Me.lblConMuestra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblConMuestra.Location = New System.Drawing.Point(23, 125)
        Me.lblConMuestra.Name = "lblConMuestra"
        Me.lblConMuestra.Size = New System.Drawing.Size(120, 27)
        Me.lblConMuestra.TabIndex = 6
        Me.lblConMuestra.Text = "Con muestra"
        Me.lblConMuestra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpMiddle
        '
        Me.tlpMiddle.AutoSize = True
        Me.tlpMiddle.ColumnCount = 8
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98.0!))
        Me.tlpMiddle.Controls.Add(Me.lblDescripcion, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.txtDescripcion, 2, 0)
        Me.tlpMiddle.Controls.Add(Me.lblTipoProductoParaLote, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.txtTipoProductoParaLote, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.lblTipoMovimiento, 1, 2)
        Me.tlpMiddle.Controls.Add(Me.txtTipoMovimiento, 2, 2)
        Me.tlpMiddle.Controls.Add(Me.lblTipoLoteID, 1, 3)
        Me.tlpMiddle.Controls.Add(Me.cboTipoLote, 2, 3)
        Me.tlpMiddle.Controls.Add(Me.lblConMuestra, 1, 4)
        Me.tlpMiddle.Controls.Add(Me.chbConMuestra, 2, 4)
        Me.tlpMiddle.Location = New System.Drawing.Point(0, 25)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.Padding = New System.Windows.Forms.Padding(0, 15, 0, 0)
        Me.tlpMiddle.RowCount = 6
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(450, 172)
        Me.tlpMiddle.TabIndex = 8
        '
        'frmEntProcesos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(434, 228)
        Me.Controls.Add(Me.tlpMiddle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(450, 217)
        Me.Name = "frmEntProcesos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Procesos"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Private WithEvents txtTipoProductoParaLote As System.Windows.Forms.TextBox
    Private WithEvents txtTipoMovimiento As System.Windows.Forms.TextBox
    Private WithEvents cboTipoLote As System.Windows.Forms.ComboBox
    Private WithEvents chbConMuestra As System.Windows.Forms.CheckBox
    Private WithEvents lblDescripcion As System.Windows.Forms.Label
    Private WithEvents lblTipoProductoParaLote As System.Windows.Forms.Label
    Private WithEvents lblTipoMovimiento As System.Windows.Forms.Label
    Private WithEvents lblTipoLoteID As System.Windows.Forms.Label
    Private WithEvents lblConMuestra As System.Windows.Forms.Label
    Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel
End Class