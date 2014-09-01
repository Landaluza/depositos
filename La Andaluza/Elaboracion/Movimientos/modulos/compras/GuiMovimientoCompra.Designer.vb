<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GuiMovimientoCompra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GuiMovimientoCompra))
        Me.chbSuma = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnProductoDestinoIncorrecto = New System.Windows.Forms.Button()
        Me.btncantidadDestinoIncorrecta = New System.Windows.Forms.Button()
        Me.lDescripcionDestino = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.dgvDestino = New System.Windows.Forms.DataGridView()
        Me.cboProductoEntrada = New System.Windows.Forms.ComboBox()
        Me.cboProveedor = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboTipoLote = New System.Windows.Forms.ComboBox()
        Me.cboTipoProducto = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chbSuma
        '
        Me.chbSuma.AutoSize = True
        Me.chbSuma.Checked = True
        Me.chbSuma.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbSuma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbSuma.Location = New System.Drawing.Point(179, 171)
        Me.chbSuma.Name = "chbSuma"
        Me.chbSuma.Size = New System.Drawing.Size(50, 17)
        Me.chbSuma.TabIndex = 19
        Me.chbSuma.Text = "Suma"
        Me.chbSuma.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnProductoDestinoIncorrecto)
        Me.GroupBox2.Controls.Add(Me.btncantidadDestinoIncorrecta)
        Me.GroupBox2.Controls.Add(Me.lDescripcionDestino)
        Me.GroupBox2.Location = New System.Drawing.Point(77, 451)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(571, 165)
        Me.GroupBox2.TabIndex = 18
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
        'btnGuardar
        '
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Image = Global.La_Andaluza_MovimientosDepositos.My.Resources.Resources.glyphicons_198_ok
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.Location = New System.Drawing.Point(404, 640)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(244, 69)
        Me.btnGuardar.TabIndex = 16
        Me.btnGuardar.Text = "Continuar"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'txtCantidad
        '
        Me.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.txtCantidad.Location = New System.Drawing.Point(77, 640)
        Me.txtCantidad.Multiline = True
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(210, 69)
        Me.txtCantidad.TabIndex = 12
        Me.txtCantidad.Text = "30000000"
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
        Me.dgvDestino.Location = New System.Drawing.Point(77, 194)
        Me.dgvDestino.Name = "dgvDestino"
        Me.dgvDestino.ReadOnly = True
        Me.dgvDestino.RowHeadersVisible = False
        Me.dgvDestino.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDestino.Size = New System.Drawing.Size(571, 239)
        Me.dgvDestino.TabIndex = 15
        '
        'cboProductoEntrada
        '
        Me.cboProductoEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboProductoEntrada.FormattingEnabled = True
        Me.cboProductoEntrada.Location = New System.Drawing.Point(179, 63)
        Me.cboProductoEntrada.Name = "cboProductoEntrada"
        Me.cboProductoEntrada.Size = New System.Drawing.Size(469, 21)
        Me.cboProductoEntrada.TabIndex = 21
        '
        'cboProveedor
        '
        Me.cboProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboProveedor.FormattingEnabled = True
        Me.cboProveedor.Location = New System.Drawing.Point(179, 90)
        Me.cboProveedor.Name = "cboProveedor"
        Me.cboProveedor.Size = New System.Drawing.Size(469, 21)
        Me.cboProveedor.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(74, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Entrada"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(74, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Proveedor"
        '
        'cboTipoLote
        '
        Me.cboTipoLote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboTipoLote.FormattingEnabled = True
        Me.cboTipoLote.Location = New System.Drawing.Point(179, 117)
        Me.cboTipoLote.Name = "cboTipoLote"
        Me.cboTipoLote.Size = New System.Drawing.Size(469, 21)
        Me.cboTipoLote.TabIndex = 27
        '
        'cboTipoProducto
        '
        Me.cboTipoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboTipoProducto.FormattingEnabled = True
        Me.cboTipoProducto.Location = New System.Drawing.Point(179, 144)
        Me.cboTipoProducto.Name = "cboTipoProducto"
        Me.cboTipoProducto.Size = New System.Drawing.Size(469, 21)
        Me.cboTipoProducto.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(74, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Lote destino"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(74, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Producto destino"
        '
        'GuiMovimientoCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 758)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboTipoLote)
        Me.Controls.Add(Me.cboTipoProducto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboProductoEntrada)
        Me.Controls.Add(Me.cboProveedor)
        Me.Controls.Add(Me.chbSuma)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.dgvDestino)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "GuiMovimientoCompra"
        Me.Text = "Compra"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvDestino, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents chbSuma As System.Windows.Forms.CheckBox
    Friend WithEvents lDescripcionDestino As System.Windows.Forms.Label
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
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents Label4 As System.Windows.Forms.Label
End Class
