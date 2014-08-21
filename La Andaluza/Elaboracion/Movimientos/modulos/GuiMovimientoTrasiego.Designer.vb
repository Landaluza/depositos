<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GuiMovimientoTrasiego
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GuiMovimientoTrasiego))
        Me.dgvorigen = New System.Windows.Forms.DataGridView()
        Me.dgvDestino = New System.Windows.Forms.DataGridView()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnProductoOrigenIncorrecto = New System.Windows.Forms.Button()
        Me.btnCantidadOrigenIncorrecta = New System.Windows.Forms.Button()
        Me.lDescripcionOrigen = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnProductoDestinoIncorrecto = New System.Windows.Forms.Button()
        Me.btncantidadDestinoIncorrecta = New System.Windows.Forms.Button()
        Me.lDescripcionDestino = New System.Windows.Forms.Label()
        CType(Me.dgvorigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvorigen
        '
        Me.dgvorigen.AllowUserToAddRows = False
        Me.dgvorigen.AllowUserToDeleteRows = False
        Me.dgvorigen.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvorigen.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvorigen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvorigen.Location = New System.Drawing.Point(42, 101)
        Me.dgvorigen.Name = "dgvorigen"
        Me.dgvorigen.ReadOnly = True
        Me.dgvorigen.RowHeadersVisible = False
        Me.dgvorigen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvorigen.Size = New System.Drawing.Size(578, 239)
        Me.dgvorigen.TabIndex = 0
        '
        'dgvDestino
        '
        Me.dgvDestino.AllowUserToAddRows = False
        Me.dgvDestino.AllowUserToDeleteRows = False
        Me.dgvDestino.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvDestino.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvDestino.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDestino.Location = New System.Drawing.Point(626, 101)
        Me.dgvDestino.Name = "dgvDestino"
        Me.dgvDestino.ReadOnly = True
        Me.dgvDestino.RowHeadersVisible = False
        Me.dgvDestino.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDestino.Size = New System.Drawing.Size(571, 239)
        Me.dgvDestino.TabIndex = 4
        '
        'txtCantidad
        '
        Me.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.txtCantidad.Location = New System.Drawing.Point(712, 678)
        Me.txtCantidad.Multiline = True
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(210, 69)
        Me.txtCantidad.TabIndex = 1
        Me.txtCantidad.Text = "30000000"
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.FlatAppearance.BorderSize = 0
        Me.RadioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton1.Location = New System.Drawing.Point(712, 597)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(152, 17)
        Me.RadioButton1.TabIndex = 2
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Mantener el lote de destino"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.FlatAppearance.BorderSize = 0
        Me.RadioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton2.Location = New System.Drawing.Point(712, 620)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(117, 17)
        Me.RadioButton2.TabIndex = 3
        Me.RadioButton2.Text = "Crear un nuevo lote"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.La_Andaluza_MovimientosDepositosPruebas.My.Resources.Resources.glyphicons_198_ok
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(953, 678)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(244, 69)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Continuar"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnProductoOrigenIncorrecto)
        Me.GroupBox1.Controls.Add(Me.btnCantidadOrigenIncorrecta)
        Me.GroupBox1.Controls.Add(Me.lDescripcionOrigen)
        Me.GroupBox1.Location = New System.Drawing.Point(42, 358)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(578, 165)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalles"
        '
        'btnProductoOrigenIncorrecto
        '
        Me.btnProductoOrigenIncorrecto.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnProductoOrigenIncorrecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProductoOrigenIncorrecto.Image = Global.La_Andaluza_MovimientosDepositosPruebas.My.Resources.Resources.glyphicons_196_circle_exclamation_mark
        Me.btnProductoOrigenIncorrecto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProductoOrigenIncorrecto.Location = New System.Drawing.Point(3, 91)
        Me.btnProductoOrigenIncorrecto.Name = "btnProductoOrigenIncorrecto"
        Me.btnProductoOrigenIncorrecto.Size = New System.Drawing.Size(572, 37)
        Me.btnProductoOrigenIncorrecto.TabIndex = 2
        Me.btnProductoOrigenIncorrecto.Text = "Producto incorrecto"
        Me.btnProductoOrigenIncorrecto.UseVisualStyleBackColor = True
        '
        'btnCantidadOrigenIncorrecta
        '
        Me.btnCantidadOrigenIncorrecta.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnCantidadOrigenIncorrecta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCantidadOrigenIncorrecta.Image = CType(resources.GetObject("btnCantidadOrigenIncorrecta.Image"), System.Drawing.Image)
        Me.btnCantidadOrigenIncorrecta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCantidadOrigenIncorrecta.Location = New System.Drawing.Point(3, 128)
        Me.btnCantidadOrigenIncorrecta.Name = "btnCantidadOrigenIncorrecta"
        Me.btnCantidadOrigenIncorrecta.Size = New System.Drawing.Size(572, 34)
        Me.btnCantidadOrigenIncorrecta.TabIndex = 1
        Me.btnCantidadOrigenIncorrecta.Text = "Cantidad incorrecta"
        Me.btnCantidadOrigenIncorrecta.UseVisualStyleBackColor = True
        '
        'lDescripcionOrigen
        '
        Me.lDescripcionOrigen.Dock = System.Windows.Forms.DockStyle.Top
        Me.lDescripcionOrigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lDescripcionOrigen.Location = New System.Drawing.Point(3, 16)
        Me.lDescripcionOrigen.Name = "lDescripcionOrigen"
        Me.lDescripcionOrigen.Size = New System.Drawing.Size(572, 72)
        Me.lDescripcionOrigen.TabIndex = 0
        Me.lDescripcionOrigen.Text = "-"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnProductoDestinoIncorrecto)
        Me.GroupBox2.Controls.Add(Me.btncantidadDestinoIncorrecta)
        Me.GroupBox2.Controls.Add(Me.lDescripcionDestino)
        Me.GroupBox2.Location = New System.Drawing.Point(626, 358)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(571, 165)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalles"
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
        'btncantidadDestinoIncorrecta
        '
        Me.btncantidadDestinoIncorrecta.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btncantidadDestinoIncorrecta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncantidadDestinoIncorrecta.Image = CType(resources.GetObject("btncantidadDestinoIncorrecta.Image"), System.Drawing.Image)
        Me.btncantidadDestinoIncorrecta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncantidadDestinoIncorrecta.Location = New System.Drawing.Point(3, 128)
        Me.btncantidadDestinoIncorrecta.Name = "btncantidadDestinoIncorrecta"
        Me.btncantidadDestinoIncorrecta.Size = New System.Drawing.Size(565, 34)
        Me.btncantidadDestinoIncorrecta.TabIndex = 3
        Me.btncantidadDestinoIncorrecta.Text = "Cantidad incorrecta"
        Me.btncantidadDestinoIncorrecta.UseVisualStyleBackColor = True
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
        'GuiMovimientoTrasiego
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1240, 780)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.dgvDestino)
        Me.Controls.Add(Me.dgvorigen)
        Me.Name = "GuiMovimientoTrasiego"
        Me.Text = "Trasiego"
        CType(Me.dgvorigen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDestino, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents txtCantidad As System.Windows.Forms.TextBox
    Public WithEvents Button1 As System.Windows.Forms.Button
    Public WithEvents dgvorigen As System.Windows.Forms.DataGridView
    Public WithEvents dgvDestino As System.Windows.Forms.DataGridView
    Public WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Public WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Public WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lDescripcionOrigen As System.Windows.Forms.Label
    Friend WithEvents lDescripcionDestino As System.Windows.Forms.Label
    Public WithEvents btnProductoOrigenIncorrecto As System.Windows.Forms.Button
    Public WithEvents btnCantidadOrigenIncorrecta As System.Windows.Forms.Button
    Public WithEvents btnProductoDestinoIncorrecto As System.Windows.Forms.Button
    Public WithEvents btncantidadDestinoIncorrecta As System.Windows.Forms.Button
End Class
