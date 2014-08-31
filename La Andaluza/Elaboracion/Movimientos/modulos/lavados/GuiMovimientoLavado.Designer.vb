<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GuiMovimientoLavado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GuiMovimientoLavado))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnProductoOrigenIncorrecto = New System.Windows.Forms.Button()
        Me.btnCantidadOrigenIncorrecta = New System.Windows.Forms.Button()
        Me.lDescripcionOrigen = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.dgvorigen = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvorigen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnProductoOrigenIncorrecto)
        Me.GroupBox1.Controls.Add(Me.btnCantidadOrigenIncorrecta)
        Me.GroupBox1.Controls.Add(Me.lDescripcionOrigen)
        Me.GroupBox1.Location = New System.Drawing.Point(100, 317)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(578, 165)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalles"
        '
        'btnProductoOrigenIncorrecto
        '
        Me.btnProductoOrigenIncorrecto.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnProductoOrigenIncorrecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProductoOrigenIncorrecto.Image = Global.La_Andaluza_MovimientosDepositos.My.Resources.Resources.glyphicons_196_circle_exclamation_mark
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
        'btnGuardar
        '
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Image = Global.La_Andaluza_MovimientosDepositos.My.Resources.Resources.glyphicons_198_ok
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.Location = New System.Drawing.Point(424, 655)
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
        Me.txtCantidad.Location = New System.Drawing.Point(103, 655)
        Me.txtCantidad.Multiline = True
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(210, 69)
        Me.txtCantidad.TabIndex = 12
        Me.txtCantidad.Text = "30000000"
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgvorigen
        '
        Me.dgvorigen.AllowUserToAddRows = False
        Me.dgvorigen.AllowUserToDeleteRows = False
        Me.dgvorigen.AllowUserToResizeRows = False
        Me.dgvorigen.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvorigen.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvorigen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvorigen.Location = New System.Drawing.Point(100, 60)
        Me.dgvorigen.Name = "dgvorigen"
        Me.dgvorigen.ReadOnly = True
        Me.dgvorigen.RowHeadersVisible = False
        Me.dgvorigen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvorigen.Size = New System.Drawing.Size(578, 239)
        Me.dgvorigen.TabIndex = 11
        '
        'GuiMovimientoLavado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 772)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.dgvorigen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "GuiMovimientoLavado"
        Me.Text = "GuiMovimientoLavado"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvorigen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents btnProductoOrigenIncorrecto As System.Windows.Forms.Button
    Public WithEvents btnCantidadOrigenIncorrecta As System.Windows.Forms.Button
    Friend WithEvents lDescripcionOrigen As System.Windows.Forms.Label
    Public WithEvents btnGuardar As System.Windows.Forms.Button
    Public WithEvents txtCantidad As System.Windows.Forms.TextBox
    Public WithEvents dgvorigen As System.Windows.Forms.DataGridView
End Class
