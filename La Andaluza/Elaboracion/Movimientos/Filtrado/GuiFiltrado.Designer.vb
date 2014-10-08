<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Guifiltrado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GuiFiltrado))
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.dgvOrigen = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnProductoOrigenIncorrecto = New System.Windows.Forms.Button()
        Me.btncantidadOrigenIncorrecta = New System.Windows.Forms.Button()
        Me.lDescripcionDestino = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.dgvDestino = New System.Windows.Forms.DataGridView()
        Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
        Me.chbSuma = New System.Windows.Forms.CheckBox()
        Me.chbLoteNuevo = New System.Windows.Forms.CheckBox()
        Me.chbMuestra = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnProductoDestinoIncorrecto = New System.Windows.Forms.Button()
        Me.btnCantidadDestinoIncorrecta = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.cboProducto = New System.Windows.Forms.ComboBox()
        Me.lProducto = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboFiltro = New System.Windows.Forms.ComboBox()
        Me.btnTodo = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.dgvOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        CType(Me.dgvDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.dtpFecha)
        Me.FlowLayoutPanel1.Controls.Add(Me.dgvOrigen)
        Me.FlowLayoutPanel1.Controls.Add(Me.GroupBox2)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(22, 38)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(25, 3, 3, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(577, 553)
        Me.FlowLayoutPanel1.TabIndex = 36
        '
        'dgvOrigen
        '
        Me.dgvOrigen.AllowUserToAddRows = False
        Me.dgvOrigen.AllowUserToDeleteRows = False
        Me.dgvOrigen.AllowUserToResizeRows = False
        Me.dgvOrigen.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvOrigen.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvOrigen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrigen.Location = New System.Drawing.Point(3, 43)
        Me.dgvOrigen.Margin = New System.Windows.Forms.Padding(3, 17, 3, 3)
        Me.dgvOrigen.Name = "dgvOrigen"
        Me.dgvOrigen.ReadOnly = True
        Me.dgvOrigen.RowHeadersVisible = False
        Me.dgvOrigen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOrigen.Size = New System.Drawing.Size(571, 239)
        Me.dgvOrigen.TabIndex = 15
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnProductoOrigenIncorrecto)
        Me.GroupBox2.Controls.Add(Me.btncantidadOrigenIncorrecta)
        Me.GroupBox2.Controls.Add(Me.lDescripcionDestino)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 288)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(571, 165)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalles"
        '
        'btnProductoOrigenIncorrecto
        '
        Me.btnProductoOrigenIncorrecto.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnProductoOrigenIncorrecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProductoOrigenIncorrecto.Image = CType(resources.GetObject("btnProductoOrigenIncorrecto.Image"), System.Drawing.Image)
        Me.btnProductoOrigenIncorrecto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProductoOrigenIncorrecto.Location = New System.Drawing.Point(3, 91)
        Me.btnProductoOrigenIncorrecto.Name = "btnProductoOrigenIncorrecto"
        Me.btnProductoOrigenIncorrecto.Size = New System.Drawing.Size(565, 37)
        Me.btnProductoOrigenIncorrecto.TabIndex = 4
        Me.btnProductoOrigenIncorrecto.Text = "Producto incorrecto"
        Me.btnProductoOrigenIncorrecto.UseVisualStyleBackColor = True
        '
        'btncantidadOrigenIncorrecta
        '
        Me.btncantidadOrigenIncorrecta.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btncantidadOrigenIncorrecta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncantidadOrigenIncorrecta.Image = CType(resources.GetObject("btncantidadOrigenIncorrecta.Image"), System.Drawing.Image)
        Me.btncantidadOrigenIncorrecta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncantidadOrigenIncorrecta.Location = New System.Drawing.Point(3, 128)
        Me.btncantidadOrigenIncorrecta.Name = "btncantidadOrigenIncorrecta"
        Me.btncantidadOrigenIncorrecta.Size = New System.Drawing.Size(565, 34)
        Me.btncantidadOrigenIncorrecta.TabIndex = 3
        Me.btncantidadOrigenIncorrecta.Text = "Cantidad incorrecta"
        Me.btncantidadOrigenIncorrecta.UseVisualStyleBackColor = True
        '
        'lDescripcionDestino
        '
        Me.lDescripcionDestino.Dock = System.Windows.Forms.DockStyle.Top
        Me.lDescripcionDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lDescripcionDestino.Location = New System.Drawing.Point(3, 16)
        Me.lDescripcionDestino.Name = "lDescripcionDestino"
        Me.lDescripcionDestino.Size = New System.Drawing.Size(565, 72)
        Me.lDescripcionDestino.TabIndex = 1
        Me.lDescripcionDestino.Text = "-"
        '
        'btnGuardar
        '
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Image = Global.La_Andaluza_MovimientosDepositos.My.Resources.Resources.glyphicons_198_ok
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.Location = New System.Drawing.Point(954, 625)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(244, 69)
        Me.btnGuardar.TabIndex = 35
        Me.btnGuardar.Text = "Continuar"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'txtCantidad
        '
        Me.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.txtCantidad.Location = New System.Drawing.Point(624, 625)
        Me.txtCantidad.Multiline = True
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(210, 69)
        Me.txtCantidad.TabIndex = 34
        Me.txtCantidad.Text = "0"
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Controls.Add(Me.Label4)
        Me.FlowLayoutPanel3.Controls.Add(Me.cboFiltro)
        Me.FlowLayoutPanel3.Controls.Add(Me.dgvDestino)
        Me.FlowLayoutPanel3.Controls.Add(Me.GroupBox1)
        Me.FlowLayoutPanel3.Controls.Add(Me.lProducto)
        Me.FlowLayoutPanel3.Controls.Add(Me.cboProducto)
        Me.FlowLayoutPanel3.Controls.Add(Me.FlowLayoutPanel4)
        Me.FlowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(621, 38)
        Me.FlowLayoutPanel3.Margin = New System.Windows.Forms.Padding(25, 3, 3, 3)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(577, 553)
        Me.FlowLayoutPanel3.TabIndex = 37
        '
        'dgvDestino
        '
        Me.dgvDestino.AllowUserToAddRows = False
        Me.dgvDestino.AllowUserToDeleteRows = False
        Me.dgvDestino.AllowUserToResizeRows = False
        Me.dgvDestino.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvDestino.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvDestino.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDestino.Location = New System.Drawing.Point(3, 43)
        Me.dgvDestino.Name = "dgvDestino"
        Me.dgvDestino.ReadOnly = True
        Me.dgvDestino.RowHeadersVisible = False
        Me.dgvDestino.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDestino.Size = New System.Drawing.Size(571, 239)
        Me.dgvDestino.TabIndex = 15
        '
        'FlowLayoutPanel4
        '
        Me.FlowLayoutPanel4.Controls.Add(Me.chbSuma)
        Me.FlowLayoutPanel4.Controls.Add(Me.chbLoteNuevo)
        Me.FlowLayoutPanel4.Controls.Add(Me.chbMuestra)
        Me.FlowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel4.Location = New System.Drawing.Point(3, 499)
        Me.FlowLayoutPanel4.Margin = New System.Windows.Forms.Padding(3, 3, 3, 13)
        Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        Me.FlowLayoutPanel4.Size = New System.Drawing.Size(568, 20)
        Me.FlowLayoutPanel4.TabIndex = 33
        '
        'chbSuma
        '
        Me.chbSuma.AutoSize = True
        Me.chbSuma.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chbSuma.Checked = True
        Me.chbSuma.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbSuma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbSuma.Location = New System.Drawing.Point(515, 3)
        Me.chbSuma.Margin = New System.Windows.Forms.Padding(40, 3, 3, 3)
        Me.chbSuma.Name = "chbSuma"
        Me.chbSuma.Size = New System.Drawing.Size(50, 17)
        Me.chbSuma.TabIndex = 19
        Me.chbSuma.Text = "Suma"
        Me.chbSuma.UseVisualStyleBackColor = True
        '
        'chbLoteNuevo
        '
        Me.chbLoteNuevo.AutoSize = True
        Me.chbLoteNuevo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chbLoteNuevo.Checked = True
        Me.chbLoteNuevo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbLoteNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbLoteNuevo.Location = New System.Drawing.Point(355, 3)
        Me.chbLoteNuevo.Margin = New System.Windows.Forms.Padding(40, 3, 3, 3)
        Me.chbLoteNuevo.Name = "chbLoteNuevo"
        Me.chbLoteNuevo.Size = New System.Drawing.Size(117, 17)
        Me.chbLoteNuevo.TabIndex = 31
        Me.chbLoteNuevo.Text = "No crear lote nuevo"
        Me.chbLoteNuevo.UseVisualStyleBackColor = True
        '
        'chbMuestra
        '
        Me.chbMuestra.AutoSize = True
        Me.chbMuestra.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chbMuestra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbMuestra.Location = New System.Drawing.Point(224, 3)
        Me.chbMuestra.Margin = New System.Windows.Forms.Padding(25, 3, 3, 3)
        Me.chbMuestra.Name = "chbMuestra"
        Me.chbMuestra.Size = New System.Drawing.Size(88, 17)
        Me.chbMuestra.TabIndex = 32
        Me.chbMuestra.Text = "Crear muestra"
        Me.chbMuestra.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnProductoDestinoIncorrecto)
        Me.GroupBox1.Controls.Add(Me.btnCantidadDestinoIncorrecta)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 288)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(571, 165)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalles"
        '
        'btnProductoDestinoIncorrecto
        '
        Me.btnProductoDestinoIncorrecto.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnProductoDestinoIncorrecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProductoDestinoIncorrecto.Image = CType(resources.GetObject("btnProductoDestinoIncorrecto.Image"), System.Drawing.Image)
        Me.btnProductoDestinoIncorrecto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProductoDestinoIncorrecto.Location = New System.Drawing.Point(3, 91)
        Me.btnProductoDestinoIncorrecto.Name = "btnProductoDestinoIncorrecto"
        Me.btnProductoDestinoIncorrecto.Size = New System.Drawing.Size(565, 37)
        Me.btnProductoDestinoIncorrecto.TabIndex = 4
        Me.btnProductoDestinoIncorrecto.Text = "Producto incorrecto"
        Me.btnProductoDestinoIncorrecto.UseVisualStyleBackColor = True
        '
        'btnCantidadDestinoIncorrecta
        '
        Me.btnCantidadDestinoIncorrecta.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnCantidadDestinoIncorrecta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCantidadDestinoIncorrecta.Image = CType(resources.GetObject("btnCantidadDestinoIncorrecta.Image"), System.Drawing.Image)
        Me.btnCantidadDestinoIncorrecta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCantidadDestinoIncorrecta.Location = New System.Drawing.Point(3, 128)
        Me.btnCantidadDestinoIncorrecta.Name = "btnCantidadDestinoIncorrecta"
        Me.btnCantidadDestinoIncorrecta.Size = New System.Drawing.Size(565, 34)
        Me.btnCantidadDestinoIncorrecta.TabIndex = 3
        Me.btnCantidadDestinoIncorrecta.Text = "Cantidad incorrecta"
        Me.btnCantidadDestinoIncorrecta.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Location = New System.Drawing.Point(3, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(565, 72)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "-"
        '
        'dtpFecha
        '
        Me.dtpFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(468, 3)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(106, 20)
        Me.dtpFecha.TabIndex = 32
        '
        'cboProducto
        '
        Me.cboProducto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboProducto.FormattingEnabled = True
        Me.cboProducto.Location = New System.Drawing.Point(105, 472)
        Me.cboProducto.Name = "cboProducto"
        Me.cboProducto.Size = New System.Drawing.Size(469, 21)
        Me.cboProducto.TabIndex = 28
        '
        'lProducto
        '
        Me.lProducto.AutoSize = True
        Me.lProducto.Location = New System.Drawing.Point(3, 456)
        Me.lProducto.Name = "lProducto"
        Me.lProducto.Size = New System.Drawing.Size(87, 13)
        Me.lProducto.TabIndex = 30
        Me.lProducto.Text = "Producto destino"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Filtro"
        '
        'cboFiltro
        '
        Me.cboFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboFiltro.FormattingEnabled = True
        Me.cboFiltro.Location = New System.Drawing.Point(105, 16)
        Me.cboFiltro.Name = "cboFiltro"
        Me.cboFiltro.Size = New System.Drawing.Size(469, 21)
        Me.cboFiltro.TabIndex = 22
        '
        'btnTodo
        '
        Me.btnTodo.FlatAppearance.BorderSize = 0
        Me.btnTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTodo.Image = Global.La_Andaluza_MovimientosDepositos.My.Resources.Resources.glyphicons_414_disk_save
        Me.btnTodo.Location = New System.Drawing.Point(837, 625)
        Me.btnTodo.Name = "btnTodo"
        Me.btnTodo.Size = New System.Drawing.Size(31, 69)
        Me.btnTodo.TabIndex = 38
        Me.btnTodo.UseVisualStyleBackColor = True
        '
        'GuiFiltrado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1218, 724)
        Me.Controls.Add(Me.btnTodo)
        Me.Controls.Add(Me.FlowLayoutPanel3)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtCantidad)
        Me.Name = "GuiFiltrado"
        Me.Text = "GuiFiltrado"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.dgvOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel3.PerformLayout()
        CType(Me.dgvDestino, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel4.ResumeLayout(False)
        Me.FlowLayoutPanel4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Public WithEvents dgvOrigen As System.Windows.Forms.DataGridView
    Private WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents btnProductoOrigenIncorrecto As System.Windows.Forms.Button
    Private WithEvents btncantidadOrigenIncorrecta As System.Windows.Forms.Button
    Friend WithEvents lDescripcionDestino As System.Windows.Forms.Label
    Public WithEvents btnGuardar As System.Windows.Forms.Button
    Public WithEvents txtCantidad As System.Windows.Forms.TextBox
    Private WithEvents FlowLayoutPanel3 As System.Windows.Forms.FlowLayoutPanel
    Public WithEvents dgvDestino As System.Windows.Forms.DataGridView
    Private WithEvents FlowLayoutPanel4 As System.Windows.Forms.FlowLayoutPanel
    Private WithEvents chbSuma As System.Windows.Forms.CheckBox
    Private WithEvents chbLoteNuevo As System.Windows.Forms.CheckBox
    Private WithEvents chbMuestra As System.Windows.Forms.CheckBox
    Private WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents btnProductoDestinoIncorrecto As System.Windows.Forms.Button
    Private WithEvents btnCantidadDestinoIncorrecta As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents cboFiltro As System.Windows.Forms.ComboBox
    Private WithEvents lProducto As System.Windows.Forms.Label
    Private WithEvents cboProducto As System.Windows.Forms.ComboBox
    Private WithEvents btnTodo As System.Windows.Forms.Button
End Class
