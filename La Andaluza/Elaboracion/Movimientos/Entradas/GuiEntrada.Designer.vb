Namespace Movimientos

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class GuiEntrada
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GuiEntrada))
            Me.chbSuma = New System.Windows.Forms.CheckBox()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.btnProductoDestinoIncorrecto = New System.Windows.Forms.Button()
            Me.btncantidadDestinoIncorrecta = New System.Windows.Forms.Button()
            Me.btnGuardar = New System.Windows.Forms.Button()
            Me.txtCantidad = New System.Windows.Forms.TextBox()
            Me.dgvDestino = New System.Windows.Forms.DataGridView()
            Me.cboProductoEntrada = New System.Windows.Forms.ComboBox()
            Me.cboProveedor = New System.Windows.Forms.ComboBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.lProveedor = New System.Windows.Forms.Label()
            Me.cboTipoLote = New System.Windows.Forms.ComboBox()
            Me.cboTipoProducto = New System.Windows.Forms.ComboBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.lTlote = New System.Windows.Forms.Label()
            Me.chbLoteNuevo = New System.Windows.Forms.CheckBox()
            Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
            Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
            Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
            Me.chbMuestra = New System.Windows.Forms.CheckBox()
            Me.GroupBox2.SuspendLayout()
            CType(Me.dgvDestino, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.FlowLayoutPanel1.SuspendLayout()
            Me.FlowLayoutPanel2.SuspendLayout()
            Me.SuspendLayout()
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
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.btnProductoDestinoIncorrecto)
            Me.GroupBox2.Controls.Add(Me.btncantidadDestinoIncorrecta)
            Me.GroupBox2.Location = New System.Drawing.Point(3, 470)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(571, 165)
            Me.GroupBox2.TabIndex = 11
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
            Me.btnProductoDestinoIncorrecto.TabIndex = 1
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
            Me.btncantidadDestinoIncorrecta.TabIndex = 2
            Me.btncantidadDestinoIncorrecta.Text = "Cantidad incorrecta"
            Me.btncantidadDestinoIncorrecta.UseVisualStyleBackColor = True
            '
            'btnGuardar
            '
            Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnGuardar.Image = Global.La_Andaluza_MovimientosDepositos.My.Resources.Resources.glyphicons_198_ok
            Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnGuardar.Location = New System.Drawing.Point(356, 677)
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(244, 69)
            Me.btnGuardar.TabIndex = 2
            Me.btnGuardar.Text = "Continuar"
            Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnGuardar.UseVisualStyleBackColor = True
            '
            'txtCantidad
            '
            Me.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
            Me.txtCantidad.Location = New System.Drawing.Point(23, 677)
            Me.txtCantidad.Multiline = True
            Me.txtCantidad.Name = "txtCantidad"
            Me.txtCantidad.Size = New System.Drawing.Size(210, 69)
            Me.txtCantidad.TabIndex = 1
            Me.txtCantidad.Text = "0"
            Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'dgvDestino
            '
            Me.dgvDestino.AllowUserToAddRows = False
            Me.dgvDestino.AllowUserToDeleteRows = False
            Me.dgvDestino.AllowUserToResizeRows = False
            Me.dgvDestino.BackgroundColor = System.Drawing.SystemColors.Control
            Me.dgvDestino.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            Me.dgvDestino.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvDestino.Location = New System.Drawing.Point(3, 109)
            Me.dgvDestino.Name = "dgvDestino"
            Me.dgvDestino.ReadOnly = True
            Me.dgvDestino.RowHeadersVisible = False
            Me.dgvDestino.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvDestino.Size = New System.Drawing.Size(571, 239)
            Me.dgvDestino.TabIndex = 5
            '
            'cboProductoEntrada
            '
            Me.cboProductoEntrada.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cboProductoEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cboProductoEntrada.FormattingEnabled = True
            Me.cboProductoEntrada.Location = New System.Drawing.Point(105, 42)
            Me.cboProductoEntrada.Name = "cboProductoEntrada"
            Me.cboProductoEntrada.Size = New System.Drawing.Size(469, 21)
            Me.cboProductoEntrada.TabIndex = 2
            '
            'cboProveedor
            '
            Me.cboProveedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cboProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cboProveedor.FormattingEnabled = True
            Me.cboProveedor.Location = New System.Drawing.Point(105, 82)
            Me.cboProveedor.Name = "cboProveedor"
            Me.cboProveedor.Size = New System.Drawing.Size(469, 21)
            Me.cboProveedor.TabIndex = 4
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(3, 26)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(44, 13)
            Me.Label1.TabIndex = 1
            Me.Label1.Text = "Entrada"
            '
            'lProveedor
            '
            Me.lProveedor.AutoSize = True
            Me.lProveedor.Location = New System.Drawing.Point(3, 66)
            Me.lProveedor.Name = "lProveedor"
            Me.lProveedor.Size = New System.Drawing.Size(56, 13)
            Me.lProveedor.TabIndex = 3
            Me.lProveedor.Text = "Proveedor"
            '
            'cboTipoLote
            '
            Me.cboTipoLote.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cboTipoLote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cboTipoLote.FormattingEnabled = True
            Me.cboTipoLote.Location = New System.Drawing.Point(105, 367)
            Me.cboTipoLote.Name = "cboTipoLote"
            Me.cboTipoLote.Size = New System.Drawing.Size(469, 21)
            Me.cboTipoLote.TabIndex = 7
            '
            'cboTipoProducto
            '
            Me.cboTipoProducto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cboTipoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cboTipoProducto.FormattingEnabled = True
            Me.cboTipoProducto.Location = New System.Drawing.Point(105, 407)
            Me.cboTipoProducto.Name = "cboTipoProducto"
            Me.cboTipoProducto.Size = New System.Drawing.Size(469, 21)
            Me.cboTipoProducto.TabIndex = 9
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(3, 351)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(65, 13)
            Me.Label3.TabIndex = 6
            Me.Label3.Text = "Lote destino"
            '
            'lTlote
            '
            Me.lTlote.AutoSize = True
            Me.lTlote.Location = New System.Drawing.Point(3, 391)
            Me.lTlote.Name = "lTlote"
            Me.lTlote.Size = New System.Drawing.Size(87, 13)
            Me.lTlote.TabIndex = 8
            Me.lTlote.Text = "Producto destino"
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
            'dtpFecha
            '
            Me.dtpFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFecha.Location = New System.Drawing.Point(468, 3)
            Me.dtpFecha.Name = "dtpFecha"
            Me.dtpFecha.Size = New System.Drawing.Size(106, 20)
            Me.dtpFecha.TabIndex = 0
            '
            'FlowLayoutPanel1
            '
            Me.FlowLayoutPanel1.Controls.Add(Me.dtpFecha)
            Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
            Me.FlowLayoutPanel1.Controls.Add(Me.cboProductoEntrada)
            Me.FlowLayoutPanel1.Controls.Add(Me.lProveedor)
            Me.FlowLayoutPanel1.Controls.Add(Me.cboProveedor)
            Me.FlowLayoutPanel1.Controls.Add(Me.dgvDestino)
            Me.FlowLayoutPanel1.Controls.Add(Me.Label3)
            Me.FlowLayoutPanel1.Controls.Add(Me.cboTipoLote)
            Me.FlowLayoutPanel1.Controls.Add(Me.lTlote)
            Me.FlowLayoutPanel1.Controls.Add(Me.cboTipoProducto)
            Me.FlowLayoutPanel1.Controls.Add(Me.FlowLayoutPanel2)
            Me.FlowLayoutPanel1.Controls.Add(Me.GroupBox2)
            Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
            Me.FlowLayoutPanel1.Location = New System.Drawing.Point(23, 12)
            Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(25, 3, 3, 3)
            Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
            Me.FlowLayoutPanel1.Size = New System.Drawing.Size(577, 644)
            Me.FlowLayoutPanel1.TabIndex = 0
            '
            'FlowLayoutPanel2
            '
            Me.FlowLayoutPanel2.Controls.Add(Me.chbSuma)
            Me.FlowLayoutPanel2.Controls.Add(Me.chbLoteNuevo)
            Me.FlowLayoutPanel2.Controls.Add(Me.chbMuestra)
            Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
            Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 434)
            Me.FlowLayoutPanel2.Margin = New System.Windows.Forms.Padding(3, 3, 3, 13)
            Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
            Me.FlowLayoutPanel2.Size = New System.Drawing.Size(568, 20)
            Me.FlowLayoutPanel2.TabIndex = 10
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
            Me.chbMuestra.TabIndex = 0
            Me.chbMuestra.Text = "Crear muestra"
            Me.chbMuestra.UseVisualStyleBackColor = True
            '
            'GuiEntrada
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(623, 759)
            Me.Controls.Add(Me.FlowLayoutPanel1)
            Me.Controls.Add(Me.btnGuardar)
            Me.Controls.Add(Me.txtCantidad)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "GuiEntrada"
            Me.Text = "Entrada"
            Me.GroupBox2.ResumeLayout(False)
            CType(Me.dgvDestino, System.ComponentModel.ISupportInitialize).EndInit()
            Me.FlowLayoutPanel1.ResumeLayout(False)
            Me.FlowLayoutPanel1.PerformLayout()
            Me.FlowLayoutPanel2.ResumeLayout(False)
            Me.FlowLayoutPanel2.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Public WithEvents btnGuardar As System.Windows.Forms.Button
        Public WithEvents txtCantidad As System.Windows.Forms.TextBox
        Public WithEvents dgvDestino As System.Windows.Forms.DataGridView
        Private WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Private WithEvents btnProductoDestinoIncorrecto As System.Windows.Forms.Button
        Private WithEvents btncantidadDestinoIncorrecta As System.Windows.Forms.Button
        Private WithEvents cboTipoLote As System.Windows.Forms.ComboBox
        Private WithEvents cboTipoProducto As System.Windows.Forms.ComboBox
        Private WithEvents cboProductoEntrada As System.Windows.Forms.ComboBox
        Private WithEvents cboProveedor As System.Windows.Forms.ComboBox
        Private WithEvents Label1 As System.Windows.Forms.Label
        Private WithEvents lProveedor As System.Windows.Forms.Label
        Private WithEvents Label3 As System.Windows.Forms.Label
        Private WithEvents lTlote As System.Windows.Forms.Label
        Private WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
        Private WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
        Private WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
        Private WithEvents chbMuestra As System.Windows.Forms.CheckBox
        Private WithEvents chbSuma As System.Windows.Forms.CheckBox
        Private WithEvents chbLoteNuevo As System.Windows.Forms.CheckBox
    End Class
End Namespace