<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntProcesos
    Inherits BasesParaCompatibilidad.DetailedSimpleForm

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
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtTipoProductoParaLote = New System.Windows.Forms.TextBox()
        Me.cboTipoLote = New System.Windows.Forms.ComboBox()
        Me.butVerTipoLoteID = New System.Windows.Forms.Button()
        Me.butAddTipoLoteID = New System.Windows.Forms.Button()
        Me.chbConMuestra = New System.Windows.Forms.CheckBox()
        Me.cboTipoMovimiento = New System.Windows.Forms.ComboBox()
        Me.butVerTipoMovimientoID = New System.Windows.Forms.Button()
        Me.butAddTipoMovimientoID = New System.Windows.Forms.Button()
        Me.lblDescripcion = New System.Windows.Forms.Label
        Me.lblTipoProductoParaLote = New System.Windows.Forms.Label
        Me.lblTipoLoteID = New System.Windows.Forms.Label
        Me.lblConMuestra = New System.Windows.Forms.Label
        Me.lblTipoMovimientoID = New System.Windows.Forms.Label
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel
        Me.tlpMiddle.SuspendLayout()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Name = "txtDescripcion
        Me.txtDescripcion.TabIndex = 0
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Size = New System.Drawing.Size(200,42)
        '
        'txtTipoProductoParaLote
        '
        Me.txtTipoProductoParaLote.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTipoProductoParaLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoProductoParaLote.Name = "txtTipoProductoParaLote
        Me.txtTipoProductoParaLote.TabIndex = 1
        Me.txtTipoProductoParaLote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoProductoParaLote.BackColor = System.Drawing.SystemColors.Window
        Me.txtTipoProductoParaLote.MaxLength = 1
        Me.txtTipoProductoParaLote.Size = New System.Drawing.Size(200,42)
        '
        'cboTipoLote
        '
        Me.cboTipoLote.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboTipoLote.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTipoLote.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.cboTipoLote.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboTipoLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoLote.Name = "cboTipoLote
        Me.cboTipoLote.TabIndex = 2
        Me.cboTipoLote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboTipoLote.Size = New System.Drawing.Size(200,21)
        '
        'butVerTipoLoteID
        '
        Me.butVerTipoLoteID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butVerTipoLoteID.FlatAppearance.BorderSize = 0
        Me.butVerTipoLoteID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerTipoLoteID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerTipoLoteID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerTipoLoteID.Name = "butVerTipoLoteID
        Me.butVerTipoLoteID.Image = Global.La_Andaluza.My.Resources.Resources.agenda
        Me.butVerTipoLoteID.TabStop = False
        Me.butVerTipoLoteID.Size = New System.Drawing.Size(20, 20)
        'butAddTipoLoteID
        '
        Me.butAddTipoLoteID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butAddTipoLoteID.FlatAppearance.BorderSize = 0
        Me.butAddTipoLoteID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddTipoLoteID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddTipoLoteID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddTipoLoteID.Image = Global.La_Andaluza.My.Resources.edit_add_2
        Me.butAddTipoLoteID.Name = "butAddTipoLoteID
        Me.butAddTipoLoteID.TabStop = False
        Me.butAddTipoLoteID.Size = New System.Drawing.Size(20, 20)
        '
        '
        'chbConMuestra
        '
        Me.chbConMuestra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chbConMuestra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbConMuestra.Name = "chbConMuestra
        Me.chbConMuestra.TabIndex = 3
        Me.chbConMuestra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbConMuestra.BackColor = System.Drawing.SystemColors.Control
        Me.chbConMuestra.UseVisualStyleBackColor = False
        Me.chbConMuestra.Size = New System.Drawing.Size(16,21)
        '
        'cboTipoMovimiento
        '
        Me.cboTipoMovimiento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboTipoMovimiento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTipoMovimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.cboTipoMovimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboTipoMovimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoMovimiento.Name = "cboTipoMovimiento
        Me.cboTipoMovimiento.TabIndex = 4
        Me.cboTipoMovimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboTipoMovimiento.Size = New System.Drawing.Size(200,21)
        '
        'butVerTipoMovimientoID
        '
        Me.butVerTipoMovimientoID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butVerTipoMovimientoID.FlatAppearance.BorderSize = 0
        Me.butVerTipoMovimientoID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerTipoMovimientoID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerTipoMovimientoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerTipoMovimientoID.Name = "butVerTipoMovimientoID
        Me.butVerTipoMovimientoID.Image = Global.La_Andaluza.My.Resources.Resources.agenda
        Me.butVerTipoMovimientoID.TabStop = False
        Me.butVerTipoMovimientoID.Size = New System.Drawing.Size(20, 20)
        'butAddTipoMovimientoID
        '
        Me.butAddTipoMovimientoID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butAddTipoMovimientoID.FlatAppearance.BorderSize = 0
        Me.butAddTipoMovimientoID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddTipoMovimientoID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddTipoMovimientoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddTipoMovimientoID.Image = Global.La_Andaluza.My.Resources.edit_add_2
        Me.butAddTipoMovimientoID.Name = "butAddTipoMovimientoID
        Me.butAddTipoMovimientoID.TabStop = False
        Me.butAddTipoMovimientoID.Size = New System.Drawing.Size(20, 20)
        '
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDescripcion.Name = "lblDescripcion
        Me.lblDescripcion.Text = "Descripcion
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDescripcion.Size = New System.Drawing.Size(120,21)
        Me.lblDescripcion.Location = New System.Drawing.Point(20,40)
        '
        'lblTipoProductoParaLote
        '
        Me.lblTipoProductoParaLote.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTipoProductoParaLote.Name = "lblTipoProductoParaLote
        Me.lblTipoProductoParaLote.Text = "Tipoproductoparalote
        Me.lblTipoProductoParaLote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTipoProductoParaLote.Size = New System.Drawing.Size(120,21)
        Me.lblTipoProductoParaLote.Location = New System.Drawing.Point(20,40)
        '
        'lblTipoLoteID
        '
        Me.lblTipoLoteID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTipoLoteID.Name = "lblTipoLoteID
        Me.lblTipoLoteID.Text = "Tipolote
        Me.lblTipoLoteID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTipoLoteID.Size = New System.Drawing.Size(120,21)
        Me.lblTipoLoteID.Location = New System.Drawing.Point(20,40)
        '
        'lblConMuestra
        '
        Me.lblConMuestra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblConMuestra.Name = "lblConMuestra
        Me.lblConMuestra.Text = "Conmuestra
        Me.lblConMuestra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblConMuestra.Size = New System.Drawing.Size(120,21)
        Me.lblConMuestra.Location = New System.Drawing.Point(20,40)
        '
        'lblTipoMovimientoID
        '
        Me.lblTipoMovimientoID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTipoMovimientoID.Name = "lblTipoMovimientoID
        Me.lblTipoMovimientoID.Text = "Tipomovimiento
        Me.lblTipoMovimientoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTipoMovimientoID.Size = New System.Drawing.Size(120,21)
        Me.lblTipoMovimientoID.Location = New System.Drawing.Point(20,40)
        '
        'tlpMiddle
        '
        Me.tlpMiddle.ColumnCount = 8
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMiddle.Controls.Add(Me.lblDescripcion, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.txtDescripcion, 2, 0)
        Me.tlpMiddle.Controls.Add(Me.lblTipoProductoParaLote, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.txtTipoProductoParaLote, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.lblTipoLoteID, 1, 2)
        Me.tlpMiddle.Controls.Add(Me.cboTipoLote, 2, 2)
        Me.tlpMiddle.Controls.Add(Me.butVerTipoLoteID, 3, 2)
        Me.tlpMiddle.Controls.Add(Me.butAddTipoLoteID, 4, 2)
        Me.tlpMiddle.Controls.Add(Me.lblConMuestra, 1, 3)
        Me.tlpMiddle.Controls.Add(Me.chbConMuestra, 2, 3)
        Me.tlpMiddle.Controls.Add(Me.lblTipoMovimientoID, 1, 4)
        Me.tlpMiddle.Controls.Add(Me.cboTipoMovimiento, 2, 4)
        Me.tlpMiddle.Controls.Add(Me.butVerTipoMovimientoID, 3, 4)
        Me.tlpMiddle.Controls.Add(Me.butAddTipoMovimientoID, 4, 4)
        Me.tlpMiddle.Location = New System.Drawing.Point(0, 25)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.RowCount = 6
        Me.tlpMiddle.Padding = New System.Windows.Forms.Padding(0, 15, 0, 0)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(450, 139)
        '
        '
        'frmEntProcesos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Controls.Add(Me.tlpMiddle)
        Me.ClientSize = New System.Drawing.Size(450, 219)
        Me.MinimumSize = New System.Drawing.Size(450, 219)
        Me.Name = "frmEntProcesos
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Procesos"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.Dock = System.Windows.Forms.DockStyle.None
        Me.tlpMiddle.Autosize = True
        Me.Size = new Size(450,1251)
        Me.tlpMiddle.PerformLayout()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

       End Sub

    Private WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Private WithEvents txtTipoProductoParaLote As System.Windows.Forms.TextBox
    Private WithEvents cboTipoLote As System.Windows.Forms.ComboBox
    Private WithEvents butVerTipoLoteID As System.Windows.Forms.Button
    Private WithEvents butAddTipoLoteID As System.Windows.Forms.Button
    Private WithEvents chbConMuestra As System.Windows.Forms.CheckBox
    Private WithEvents cboTipoMovimiento As System.Windows.Forms.ComboBox
    Private WithEvents butVerTipoMovimientoID As System.Windows.Forms.Button
    Private WithEvents butAddTipoMovimientoID As System.Windows.Forms.Button
    Private WithEvents lblDescripcion As System.Windows.Forms.Label
    Private WithEvents lblTipoProductoParaLote As System.Windows.Forms.Label
    Private WithEvents lblTipoLoteID As System.Windows.Forms.Label
    Private WithEvents lblConMuestra As System.Windows.Forms.Label
    Private WithEvents lblTipoMovimientoID As System.Windows.Forms.Label
    Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel
End Class
