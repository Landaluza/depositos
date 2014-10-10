Namespace Movimientos
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class GuiSalida
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GuiSalida))
            Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
            Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
            Me.lProveedor = New System.Windows.Forms.Label()
            Me.dgvOrigen = New System.Windows.Forms.DataGridView()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.cboRecipiente = New System.Windows.Forms.ComboBox()
            Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
            Me.chbSuma = New System.Windows.Forms.CheckBox()
            Me.chbMuestra = New System.Windows.Forms.CheckBox()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.btnProductoOrigenncorrecto = New System.Windows.Forms.Button()
            Me.btncantidadOrigenIncorrecta = New System.Windows.Forms.Button()
            Me.lDescripcionDestino = New System.Windows.Forms.Label()
            Me.btnGuardar = New System.Windows.Forms.Button()
            Me.txtCantidad = New System.Windows.Forms.TextBox()
            Me.btnTodo = New System.Windows.Forms.Button()
            Me.FlowLayoutPanel1.SuspendLayout()
            CType(Me.dgvOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.FlowLayoutPanel2.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.SuspendLayout()
            '
            'FlowLayoutPanel1
            '
            Me.FlowLayoutPanel1.Controls.Add(Me.dtpFecha)
            Me.FlowLayoutPanel1.Controls.Add(Me.lProveedor)
            Me.FlowLayoutPanel1.Controls.Add(Me.dgvOrigen)
            Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
            Me.FlowLayoutPanel1.Controls.Add(Me.cboRecipiente)
            Me.FlowLayoutPanel1.Controls.Add(Me.FlowLayoutPanel2)
            Me.FlowLayoutPanel1.Controls.Add(Me.GroupBox2)
            Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
            Me.FlowLayoutPanel1.Location = New System.Drawing.Point(34, 34)
            Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(25, 3, 3, 3)
            Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
            Me.FlowLayoutPanel1.Size = New System.Drawing.Size(577, 545)
            Me.FlowLayoutPanel1.TabIndex = 36
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
            'lProveedor
            '
            Me.lProveedor.AutoSize = True
            Me.lProveedor.Location = New System.Drawing.Point(3, 26)
            Me.lProveedor.Name = "lProveedor"
            Me.lProveedor.Size = New System.Drawing.Size(49, 13)
            Me.lProveedor.TabIndex = 24
            Me.lProveedor.Text = "Deposito"
            '
            'dgvOrigen
            '
            Me.dgvOrigen.AllowUserToAddRows = False
            Me.dgvOrigen.AllowUserToDeleteRows = False
            Me.dgvOrigen.AllowUserToResizeRows = False
            Me.dgvOrigen.BackgroundColor = System.Drawing.SystemColors.Control
            Me.dgvOrigen.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            Me.dgvOrigen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvOrigen.Location = New System.Drawing.Point(3, 42)
            Me.dgvOrigen.Name = "dgvOrigen"
            Me.dgvOrigen.ReadOnly = True
            Me.dgvOrigen.RowHeadersVisible = False
            Me.dgvOrigen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvOrigen.Size = New System.Drawing.Size(571, 239)
            Me.dgvOrigen.TabIndex = 15
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(3, 289)
            Me.Label1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(58, 13)
            Me.Label1.TabIndex = 35
            Me.Label1.Text = "Recipiente"
            '
            'cboRecipiente
            '
            Me.cboRecipiente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cboRecipiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cboRecipiente.FormattingEnabled = True
            Me.cboRecipiente.Location = New System.Drawing.Point(105, 305)
            Me.cboRecipiente.Name = "cboRecipiente"
            Me.cboRecipiente.Size = New System.Drawing.Size(469, 21)
            Me.cboRecipiente.TabIndex = 34
            '
            'FlowLayoutPanel2
            '
            Me.FlowLayoutPanel2.Controls.Add(Me.chbSuma)
            Me.FlowLayoutPanel2.Controls.Add(Me.chbMuestra)
            Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
            Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 332)
            Me.FlowLayoutPanel2.Margin = New System.Windows.Forms.Padding(3, 3, 3, 13)
            Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
            Me.FlowLayoutPanel2.Size = New System.Drawing.Size(568, 20)
            Me.FlowLayoutPanel2.TabIndex = 33
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
            'chbMuestra
            '
            Me.chbMuestra.AutoSize = True
            Me.chbMuestra.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.chbMuestra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.chbMuestra.Location = New System.Drawing.Point(384, 3)
            Me.chbMuestra.Margin = New System.Windows.Forms.Padding(25, 3, 3, 3)
            Me.chbMuestra.Name = "chbMuestra"
            Me.chbMuestra.Size = New System.Drawing.Size(88, 17)
            Me.chbMuestra.TabIndex = 32
            Me.chbMuestra.Text = "Crear muestra"
            Me.chbMuestra.UseVisualStyleBackColor = True
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.btnProductoOrigenncorrecto)
            Me.GroupBox2.Controls.Add(Me.btncantidadOrigenIncorrecta)
            Me.GroupBox2.Controls.Add(Me.lDescripcionDestino)
            Me.GroupBox2.Location = New System.Drawing.Point(3, 368)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(571, 165)
            Me.GroupBox2.TabIndex = 18
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Detalles"
            '
            'btnProductoOrigenncorrecto
            '
            Me.btnProductoOrigenncorrecto.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.btnProductoOrigenncorrecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnProductoOrigenncorrecto.Image = CType(resources.GetObject("btnProductoOrigenncorrecto.Image"), System.Drawing.Image)
            Me.btnProductoOrigenncorrecto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnProductoOrigenncorrecto.Location = New System.Drawing.Point(3, 91)
            Me.btnProductoOrigenncorrecto.Name = "btnProductoOrigenncorrecto"
            Me.btnProductoOrigenncorrecto.Size = New System.Drawing.Size(565, 37)
            Me.btnProductoOrigenncorrecto.TabIndex = 4
            Me.btnProductoOrigenncorrecto.Text = "Producto incorrecto"
            Me.btnProductoOrigenncorrecto.UseVisualStyleBackColor = True
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
            Me.btnGuardar.Location = New System.Drawing.Point(367, 613)
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
            Me.txtCantidad.Location = New System.Drawing.Point(34, 613)
            Me.txtCantidad.Multiline = True
            Me.txtCantidad.Name = "txtCantidad"
            Me.txtCantidad.Size = New System.Drawing.Size(200, 69)
            Me.txtCantidad.TabIndex = 34
            Me.txtCantidad.Text = "0"
            Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'btnTodo
            '
            Me.btnTodo.FlatAppearance.BorderSize = 0
            Me.btnTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnTodo.Image = Global.La_Andaluza_MovimientosDepositos.My.Resources.Resources.glyphicons_414_disk_save
            Me.btnTodo.Location = New System.Drawing.Point(237, 613)
            Me.btnTodo.Name = "btnTodo"
            Me.btnTodo.Size = New System.Drawing.Size(31, 69)
            Me.btnTodo.TabIndex = 39
            Me.btnTodo.UseVisualStyleBackColor = True
            '
            'GuiSalida
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(646, 702)
            Me.Controls.Add(Me.btnTodo)
            Me.Controls.Add(Me.FlowLayoutPanel1)
            Me.Controls.Add(Me.btnGuardar)
            Me.Controls.Add(Me.txtCantidad)
            Me.Name = "GuiSalida"
            Me.Text = "GuiSalida"
            Me.FlowLayoutPanel1.ResumeLayout(False)
            Me.FlowLayoutPanel1.PerformLayout()
            CType(Me.dgvOrigen, System.ComponentModel.ISupportInitialize).EndInit()
            Me.FlowLayoutPanel2.ResumeLayout(False)
            Me.FlowLayoutPanel2.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Private WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
        Private WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
        Private WithEvents lProveedor As System.Windows.Forms.Label
        Public WithEvents dgvOrigen As System.Windows.Forms.DataGridView
        Private WithEvents Label1 As System.Windows.Forms.Label
        Private WithEvents cboRecipiente As System.Windows.Forms.ComboBox
        Private WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
        Private WithEvents chbSuma As System.Windows.Forms.CheckBox
        Private WithEvents chbMuestra As System.Windows.Forms.CheckBox
        Private WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Private WithEvents btnProductoOrigenncorrecto As System.Windows.Forms.Button
        Private WithEvents btncantidadOrigenIncorrecta As System.Windows.Forms.Button
        Friend WithEvents lDescripcionDestino As System.Windows.Forms.Label
        Public WithEvents btnGuardar As System.Windows.Forms.Button
        Public WithEvents txtCantidad As System.Windows.Forms.TextBox
        Private WithEvents btnTodo As System.Windows.Forms.Button
    End Class
End Namespace