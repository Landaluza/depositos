Namespace Movimientos

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GuiTrasiego
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GuiTrasiego))
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.dgvOrigen = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnProductoOrigenIncorrecto = New System.Windows.Forms.Button()
        Me.btncantidadOrigenIncorrecta = New System.Windows.Forms.Button()
            Me.btnGuardar = New System.Windows.Forms.Button()
            Me.txtCantidad = New System.Windows.Forms.TextBox()
            Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
            Me.dgvDestino = New System.Windows.Forms.DataGridView()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.btnProductoDestinaIncorrecto = New System.Windows.Forms.Button()
            Me.btncantidadDestinoIncorrecta = New System.Windows.Forms.Button()
            Me.lTipoLote = New System.Windows.Forms.Label()
            Me.cboTiplote = New System.Windows.Forms.ComboBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.cboTipoProducto = New System.Windows.Forms.ComboBox()
            Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
            Me.chbSuma = New System.Windows.Forms.CheckBox()
            Me.chbLoteNuevo = New System.Windows.Forms.CheckBox()
            Me.chbMuetra = New System.Windows.Forms.CheckBox()
            Me.btnTodo = New System.Windows.Forms.Button()
            Me.FlowLayoutPanel1.SuspendLayout()
            CType(Me.dgvOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox2.SuspendLayout()
            Me.FlowLayoutPanel3.SuspendLayout()
            CType(Me.dgvDestino, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            Me.FlowLayoutPanel4.SuspendLayout()
            Me.SuspendLayout()
            '
            'FlowLayoutPanel1
            '
            Me.FlowLayoutPanel1.Controls.Add(Me.dtpFecha)
            Me.FlowLayoutPanel1.Controls.Add(Me.dgvOrigen)
            Me.FlowLayoutPanel1.Controls.Add(Me.GroupBox2)
            Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
            Me.FlowLayoutPanel1.Location = New System.Drawing.Point(34, 20)
            Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(25, 3, 3, 3)
            Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
            Me.FlowLayoutPanel1.Size = New System.Drawing.Size(577, 455)
            Me.FlowLayoutPanel1.TabIndex = 0
            '
            'dtpFecha
            '
            Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFecha.Location = New System.Drawing.Point(3, 3)
            Me.dtpFecha.Name = "dtpFecha"
            Me.dtpFecha.Size = New System.Drawing.Size(106, 20)
            Me.dtpFecha.TabIndex = 0
            '
            'dgvOrigen
            '
            Me.dgvOrigen.AllowUserToAddRows = False
            Me.dgvOrigen.AllowUserToDeleteRows = False
            Me.dgvOrigen.AllowUserToResizeRows = False
            Me.dgvOrigen.BackgroundColor = System.Drawing.SystemColors.Control
            Me.dgvOrigen.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            Me.dgvOrigen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvOrigen.Location = New System.Drawing.Point(3, 29)
            Me.dgvOrigen.Name = "dgvOrigen"
            Me.dgvOrigen.ReadOnly = True
            Me.dgvOrigen.RowHeadersVisible = False
            Me.dgvOrigen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvOrigen.Size = New System.Drawing.Size(571, 239)
            Me.dgvOrigen.TabIndex = 1
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.btnProductoOrigenIncorrecto)
            Me.GroupBox2.Controls.Add(Me.btncantidadOrigenIncorrecta)
            Me.GroupBox2.Location = New System.Drawing.Point(3, 274)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(571, 165)
            Me.GroupBox2.TabIndex = 2
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
            Me.btnProductoOrigenIncorrecto.TabIndex = 1
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
            Me.btncantidadOrigenIncorrecta.TabIndex = 2
            Me.btncantidadOrigenIncorrecta.Text = "Cantidad incorrecta"
            Me.btncantidadOrigenIncorrecta.UseVisualStyleBackColor = True
            '
            'btnGuardar
            '
            Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnGuardar.Image = Global.La_Andaluza_MovimientosDepositos.My.Resources.Resources.glyphicons_198_ok
            Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnGuardar.Location = New System.Drawing.Point(963, 607)
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(244, 69)
            Me.btnGuardar.TabIndex = 4
            Me.btnGuardar.Text = "Continuar"
            Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnGuardar.UseVisualStyleBackColor = True
            '
            'txtCantidad
            '
            Me.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
            Me.txtCantidad.Location = New System.Drawing.Point(630, 607)
            Me.txtCantidad.Multiline = True
            Me.txtCantidad.Name = "txtCantidad"
            Me.txtCantidad.Size = New System.Drawing.Size(210, 69)
            Me.txtCantidad.TabIndex = 2
            Me.txtCantidad.Text = "0"
            Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'FlowLayoutPanel3
            '
            Me.FlowLayoutPanel3.Controls.Add(Me.dgvDestino)
            Me.FlowLayoutPanel3.Controls.Add(Me.GroupBox1)
            Me.FlowLayoutPanel3.Controls.Add(Me.lTipoLote)
            Me.FlowLayoutPanel3.Controls.Add(Me.cboTiplote)
            Me.FlowLayoutPanel3.Controls.Add(Me.Label4)
            Me.FlowLayoutPanel3.Controls.Add(Me.cboTipoProducto)
            Me.FlowLayoutPanel3.Controls.Add(Me.FlowLayoutPanel4)
            Me.FlowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
            Me.FlowLayoutPanel3.Location = New System.Drawing.Point(630, 20)
            Me.FlowLayoutPanel3.Margin = New System.Windows.Forms.Padding(25, 3, 3, 3)
            Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
            Me.FlowLayoutPanel3.Size = New System.Drawing.Size(577, 581)
            Me.FlowLayoutPanel3.TabIndex = 1
            '
            'dgvDestino
            '
            Me.dgvDestino.AllowUserToAddRows = False
            Me.dgvDestino.AllowUserToDeleteRows = False
            Me.dgvDestino.AllowUserToResizeRows = False
            Me.dgvDestino.BackgroundColor = System.Drawing.SystemColors.Control
            Me.dgvDestino.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            Me.dgvDestino.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvDestino.Location = New System.Drawing.Point(3, 29)
            Me.dgvDestino.Margin = New System.Windows.Forms.Padding(3, 29, 3, 3)
            Me.dgvDestino.Name = "dgvDestino"
            Me.dgvDestino.ReadOnly = True
            Me.dgvDestino.RowHeadersVisible = False
            Me.dgvDestino.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvDestino.Size = New System.Drawing.Size(571, 239)
            Me.dgvDestino.TabIndex = 0
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.btnProductoDestinaIncorrecto)
            Me.GroupBox1.Controls.Add(Me.btncantidadDestinoIncorrecta)
            Me.GroupBox1.Location = New System.Drawing.Point(3, 274)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(571, 165)
            Me.GroupBox1.TabIndex = 1
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Detalles"
            '
            'btnProductoDestinaIncorrecto
            '
            Me.btnProductoDestinaIncorrecto.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.btnProductoDestinaIncorrecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnProductoDestinaIncorrecto.Image = CType(resources.GetObject("btnProductoDestinaIncorrecto.Image"), System.Drawing.Image)
            Me.btnProductoDestinaIncorrecto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnProductoDestinaIncorrecto.Location = New System.Drawing.Point(3, 91)
            Me.btnProductoDestinaIncorrecto.Name = "btnProductoDestinaIncorrecto"
            Me.btnProductoDestinaIncorrecto.Size = New System.Drawing.Size(565, 37)
            Me.btnProductoDestinaIncorrecto.TabIndex = 1
            Me.btnProductoDestinaIncorrecto.Text = "Producto incorrecto"
            Me.btnProductoDestinaIncorrecto.UseVisualStyleBackColor = True
            '
            'btncantidadDestinoIncorrecta
            '
            Me.btncantidadDestinoIncorrecta.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.btncantidadDestinoIncorrecta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btncantidadDestinoIncorrecta.Image = CType(resources.GetObject("btncantidadDestinoIncorrecta.Image"), System.Drawing.Image)
            Me.btncantidadDestinoIncorrecta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btncantidadDestinoIncorrecta.Location = New System.Drawing.Point(3, 128)
            Me.btncantidadDestinoIncorrecta.Name = "btncantidadDestinoIncorrecta"
            Me.btncantidadDestinoIncorrecta.Size = New System.Drawing.Size(565, 34)
            Me.btncantidadDestinoIncorrecta.TabIndex = 2
            Me.btncantidadDestinoIncorrecta.Text = "Cantidad incorrecta"
            Me.btncantidadDestinoIncorrecta.UseVisualStyleBackColor = True
            '
            'lTipoLote
            '
            Me.lTipoLote.AutoSize = True
            Me.lTipoLote.Location = New System.Drawing.Point(3, 452)
            Me.lTipoLote.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
            Me.lTipoLote.Name = "lTipoLote"
            Me.lTipoLote.Size = New System.Drawing.Size(65, 13)
            Me.lTipoLote.TabIndex = 2
            Me.lTipoLote.Text = "Lote destino"
            '
            'cboTiplote
            '
            Me.cboTiplote.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cboTiplote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cboTiplote.FormattingEnabled = True
            Me.cboTiplote.Location = New System.Drawing.Point(105, 468)
            Me.cboTiplote.Name = "cboTiplote"
            Me.cboTiplote.Size = New System.Drawing.Size(469, 21)
            Me.cboTiplote.TabIndex = 3
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(3, 492)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(87, 13)
            Me.Label4.TabIndex = 4
            Me.Label4.Text = "Producto destino"
            '
            'cboTipoProducto
            '
            Me.cboTipoProducto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cboTipoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cboTipoProducto.FormattingEnabled = True
            Me.cboTipoProducto.Location = New System.Drawing.Point(105, 508)
            Me.cboTipoProducto.Name = "cboTipoProducto"
            Me.cboTipoProducto.Size = New System.Drawing.Size(469, 21)
            Me.cboTipoProducto.TabIndex = 5
            '
            'FlowLayoutPanel4
            '
            Me.FlowLayoutPanel4.Controls.Add(Me.chbSuma)
            Me.FlowLayoutPanel4.Controls.Add(Me.chbLoteNuevo)
            Me.FlowLayoutPanel4.Controls.Add(Me.chbMuetra)
            Me.FlowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
            Me.FlowLayoutPanel4.Location = New System.Drawing.Point(3, 535)
            Me.FlowLayoutPanel4.Margin = New System.Windows.Forms.Padding(3, 3, 3, 13)
            Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
            Me.FlowLayoutPanel4.Size = New System.Drawing.Size(568, 20)
            Me.FlowLayoutPanel4.TabIndex = 6
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
            Me.chbSuma.TabIndex = 2
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
            Me.chbLoteNuevo.TabIndex = 1
            Me.chbLoteNuevo.Text = "No crear lote nuevo"
            Me.chbLoteNuevo.UseVisualStyleBackColor = True
            '
            'chbMuetra
            '
            Me.chbMuetra.AutoSize = True
            Me.chbMuetra.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.chbMuetra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.chbMuetra.Location = New System.Drawing.Point(224, 3)
            Me.chbMuetra.Margin = New System.Windows.Forms.Padding(25, 3, 3, 3)
            Me.chbMuetra.Name = "chbMuetra"
            Me.chbMuetra.Size = New System.Drawing.Size(88, 17)
            Me.chbMuetra.TabIndex = 0
            Me.chbMuetra.Text = "Crear muestra"
            Me.chbMuetra.UseVisualStyleBackColor = True
            '
            'btnTodo
            '
            Me.btnTodo.FlatAppearance.BorderSize = 0
            Me.btnTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnTodo.Image = Global.La_Andaluza_MovimientosDepositos.My.Resources.Resources.glyphicons_414_disk_save
            Me.btnTodo.Location = New System.Drawing.Point(843, 607)
            Me.btnTodo.Name = "btnTodo"
            Me.btnTodo.Size = New System.Drawing.Size(31, 69)
            Me.btnTodo.TabIndex = 3
            Me.btnTodo.UseVisualStyleBackColor = True
            '
            'GuiTrasiego
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1231, 691)
            Me.Controls.Add(Me.btnTodo)
            Me.Controls.Add(Me.FlowLayoutPanel3)
            Me.Controls.Add(Me.FlowLayoutPanel1)
            Me.Controls.Add(Me.btnGuardar)
            Me.Controls.Add(Me.txtCantidad)
            Me.Name = "GuiTrasiego"
            Me.Text = "GuiTrasiego"
            Me.FlowLayoutPanel1.ResumeLayout(False)
            CType(Me.dgvOrigen, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox2.ResumeLayout(False)
            Me.FlowLayoutPanel3.ResumeLayout(False)
            Me.FlowLayoutPanel3.PerformLayout()
            CType(Me.dgvDestino, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            Me.FlowLayoutPanel4.ResumeLayout(False)
            Me.FlowLayoutPanel4.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
    Private WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Private WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Public WithEvents dgvOrigen As System.Windows.Forms.DataGridView
    Private WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents btnProductoOrigenIncorrecto As System.Windows.Forms.Button
    Private WithEvents btncantidadOrigenIncorrecta As System.Windows.Forms.Button
    Public WithEvents btnGuardar As System.Windows.Forms.Button
    Public WithEvents txtCantidad As System.Windows.Forms.TextBox
    Private WithEvents FlowLayoutPanel3 As System.Windows.Forms.FlowLayoutPanel
    Public WithEvents dgvDestino As System.Windows.Forms.DataGridView
    Private WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents btnProductoDestinaIncorrecto As System.Windows.Forms.Button
    Private WithEvents btncantidadDestinoIncorrecta As System.Windows.Forms.Button
        Private WithEvents lTipoLote As System.Windows.Forms.Label
    Private WithEvents cboTiplote As System.Windows.Forms.ComboBox
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents cboTipoProducto As System.Windows.Forms.ComboBox
    Private WithEvents FlowLayoutPanel4 As System.Windows.Forms.FlowLayoutPanel
    Private WithEvents chbSuma As System.Windows.Forms.CheckBox
    Private WithEvents chbLoteNuevo As System.Windows.Forms.CheckBox
    Private WithEvents chbMuetra As System.Windows.Forms.CheckBox
        Private WithEvents btnTodo As System.Windows.Forms.Button
End Class
End Namespace
