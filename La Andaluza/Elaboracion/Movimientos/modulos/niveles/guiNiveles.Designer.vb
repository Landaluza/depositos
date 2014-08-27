<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class guiNiveles
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.sep3 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lCantidad = New System.Windows.Forms.Label()
        Me.sep2 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lCapacidad = New System.Windows.Forms.Label()
        Me.sep1 = New System.Windows.Forms.Label()
        Me.lDescripcion = New System.Windows.Forms.Label()
        Me.lCodigoLote = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCantidadREal = New System.Windows.Forms.TextBox()
        Me.btnContinuar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 509)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(673, 81)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(409, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nivelar depositos"
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Image = Global.La_Andaluza_MovimientosDepositosPruebas.My.Resources.Resources.glyphicons_197_remove
        Me.btnCancelar.Location = New System.Drawing.Point(638, -2)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(35, 51)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(81, 42)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(511, 196)
        Me.Panel2.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.sep3)
        Me.Panel4.Controls.Add(Me.FlowLayoutPanel2)
        Me.Panel4.Controls.Add(Me.sep2)
        Me.Panel4.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel4.Controls.Add(Me.sep1)
        Me.Panel4.Controls.Add(Me.lDescripcion)
        Me.Panel4.Controls.Add(Me.lCodigoLote)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 53)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(509, 141)
        Me.Panel4.TabIndex = 1
        '
        'sep3
        '
        Me.sep3.BackColor = System.Drawing.SystemColors.Control
        Me.sep3.Dock = System.Windows.Forms.DockStyle.Top
        Me.sep3.Location = New System.Drawing.Point(0, 119)
        Me.sep3.Name = "sep3"
        Me.sep3.Size = New System.Drawing.Size(509, 1)
        Me.sep3.TabIndex = 8
        Me.sep3.Text = "Label8"
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.Label6)
        Me.FlowLayoutPanel2.Controls.Add(Me.lCantidad)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 66)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(509, 53)
        Me.FlowLayoutPanel2.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Label6.Size = New System.Drawing.Size(52, 18)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Cantidad:"
        '
        'lCantidad
        '
        Me.lCantidad.AutoSize = True
        Me.lCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lCantidad.Location = New System.Drawing.Point(61, 0)
        Me.lCantidad.Name = "lCantidad"
        Me.lCantidad.Size = New System.Drawing.Size(131, 54)
        Me.lCantidad.TabIndex = 7
        Me.lCantidad.Text = "5000"
        '
        'sep2
        '
        Me.sep2.BackColor = System.Drawing.Color.Black
        Me.sep2.Dock = System.Windows.Forms.DockStyle.Top
        Me.sep2.Location = New System.Drawing.Point(0, 64)
        Me.sep2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.sep2.Name = "sep2"
        Me.sep2.Size = New System.Drawing.Size(509, 2)
        Me.sep2.TabIndex = 5
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Label4)
        Me.FlowLayoutPanel1.Controls.Add(Me.lCapacidad)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 46)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(509, 18)
        Me.FlowLayoutPanel1.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.Label4.Size = New System.Drawing.Size(61, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Capacidad:"
        '
        'lCapacidad
        '
        Me.lCapacidad.AutoSize = True
        Me.lCapacidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lCapacidad.Location = New System.Drawing.Point(70, 0)
        Me.lCapacidad.Name = "lCapacidad"
        Me.lCapacidad.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.lCapacidad.Size = New System.Drawing.Size(35, 18)
        Me.lCapacidad.TabIndex = 4
        Me.lCapacidad.Text = "9200"
        '
        'sep1
        '
        Me.sep1.BackColor = System.Drawing.SystemColors.Control
        Me.sep1.Dock = System.Windows.Forms.DockStyle.Top
        Me.sep1.Location = New System.Drawing.Point(0, 45)
        Me.sep1.Name = "sep1"
        Me.sep1.Size = New System.Drawing.Size(509, 1)
        Me.sep1.TabIndex = 2
        '
        'lDescripcion
        '
        Me.lDescripcion.AutoSize = True
        Me.lDescripcion.Dock = System.Windows.Forms.DockStyle.Top
        Me.lDescripcion.Location = New System.Drawing.Point(0, 22)
        Me.lDescripcion.Name = "lDescripcion"
        Me.lDescripcion.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.lDescripcion.Size = New System.Drawing.Size(121, 23)
        Me.lDescripcion.TabIndex = 1
        Me.lDescripcion.Text = "Vinagre de jerez reserva"
        '
        'lCodigoLote
        '
        Me.lCodigoLote.AutoSize = True
        Me.lCodigoLote.Dock = System.Windows.Forms.DockStyle.Top
        Me.lCodigoLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lCodigoLote.Location = New System.Drawing.Point(0, 0)
        Me.lCodigoLote.Name = "lCodigoLote"
        Me.lCodigoLote.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.lCodigoLote.Size = New System.Drawing.Size(133, 22)
        Me.lCodigoLote.TabIndex = 0
        Me.lCodigoLote.Text = "1 - 2014VJRTEr1"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightGray
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(509, 53)
        Me.Panel3.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Datos originales"
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Controls.Add(Me.Label8)
        Me.FlowLayoutPanel3.Controls.Add(Me.txtCantidadREal)
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(84, 268)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(511, 132)
        Me.FlowLayoutPanel3.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Padding = New System.Windows.Forms.Padding(0, 5, 180, 0)
        Me.Label8.Size = New System.Drawing.Size(252, 18)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Cantidad real:"
        '
        'txtCantidadREal
        '
        Me.txtCantidadREal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCantidadREal.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadREal.Location = New System.Drawing.Point(261, 3)
        Me.txtCantidadREal.Name = "txtCantidadREal"
        Me.txtCantidadREal.Size = New System.Drawing.Size(244, 60)
        Me.txtCantidadREal.TabIndex = 1
        Me.txtCantidadREal.Text = "800000"
        Me.txtCantidadREal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnContinuar
        '
        Me.btnContinuar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnContinuar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnContinuar.Image = Global.La_Andaluza_MovimientosDepositosPruebas.My.Resources.Resources.glyphicons_198_ok
        Me.btnContinuar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnContinuar.Location = New System.Drawing.Point(0, 470)
        Me.btnContinuar.Name = "btnContinuar"
        Me.btnContinuar.Size = New System.Drawing.Size(673, 39)
        Me.btnContinuar.TabIndex = 3
        Me.btnContinuar.Text = "Continuar"
        Me.btnContinuar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnContinuar.UseVisualStyleBackColor = False
        '
        'guiNiveles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(673, 590)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnContinuar)
        Me.Controls.Add(Me.FlowLayoutPanel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "guiNiveles"
        Me.Text = "frmNiveles"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Panel2 As System.Windows.Forms.Panel
    Public WithEvents Panel4 As System.Windows.Forms.Panel
    Public WithEvents sep3 As System.Windows.Forms.Label
    Public WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents lCantidad As System.Windows.Forms.Label
    Public WithEvents sep2 As System.Windows.Forms.Label
    Public WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents lCapacidad As System.Windows.Forms.Label
    Public WithEvents sep1 As System.Windows.Forms.Label
    Public WithEvents lDescripcion As System.Windows.Forms.Label
    Public WithEvents lCodigoLote As System.Windows.Forms.Label
    Public WithEvents Panel3 As System.Windows.Forms.Panel
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents FlowLayoutPanel3 As System.Windows.Forms.FlowLayoutPanel
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents txtCantidadREal As System.Windows.Forms.TextBox
    Public WithEvents btnContinuar As System.Windows.Forms.Button
    Public WithEvents btnCancelar As System.Windows.Forms.Button
End Class
