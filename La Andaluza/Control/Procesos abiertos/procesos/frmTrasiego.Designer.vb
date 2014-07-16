<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrasiego
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
        Me.cboDepositoOrigen = New System.Windows.Forms.ComboBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.cboDepositoDestino = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.cboProducto = New System.Windows.Forms.ComboBox()
        Me.cboLote = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnExportar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboDepositoOrigen
        '
        Me.cboDepositoOrigen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboDepositoOrigen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboDepositoOrigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboDepositoOrigen.FormattingEnabled = True
        Me.cboDepositoOrigen.Location = New System.Drawing.Point(105, 33)
        Me.cboDepositoOrigen.Name = "cboDepositoOrigen"
        Me.cboDepositoOrigen.Size = New System.Drawing.Size(73, 21)
        Me.cboDepositoOrigen.TabIndex = 0
        '
        'txtCantidad
        '
        Me.txtCantidad.AccessibleDescription = "Cantidad"
        Me.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCantidad.Location = New System.Drawing.Point(205, 33)
        Me.txtCantidad.Multiline = True
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(106, 21)
        Me.txtCantidad.TabIndex = 1
        '
        'cboDepositoDestino
        '
        Me.cboDepositoDestino.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboDepositoDestino.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboDepositoDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboDepositoDestino.FormattingEnabled = True
        Me.cboDepositoDestino.Location = New System.Drawing.Point(339, 33)
        Me.cboDepositoDestino.Name = "cboDepositoDestino"
        Me.cboDepositoDestino.Size = New System.Drawing.Size(70, 21)
        Me.cboDepositoDestino.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.La_Andaluza_MovimientosDepositos.My.Resources.Resources.trasiego
        Me.PictureBox1.Location = New System.Drawing.Point(11, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(87, 76)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(186, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(11, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(320, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(11, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "-"
        '
        'btnBorrar
        '
        Me.btnBorrar.FlatAppearance.BorderSize = 0
        Me.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrar.Image = Global.La_Andaluza_MovimientosDepositos.My.Resources.Resources.emblem_unreadable
        Me.btnBorrar.Location = New System.Drawing.Point(829, 12)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 63)
        Me.btnBorrar.TabIndex = 6
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'cboProducto
        '
        Me.cboProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboProducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboProducto.FormattingEnabled = True
        Me.cboProducto.Location = New System.Drawing.Point(429, 33)
        Me.cboProducto.Name = "cboProducto"
        Me.cboProducto.Size = New System.Drawing.Size(168, 21)
        Me.cboProducto.TabIndex = 7
        '
        'cboLote
        '
        Me.cboLote.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboLote.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboLote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboLote.FormattingEnabled = True
        Me.cboLote.Location = New System.Drawing.Point(626, 33)
        Me.cboLote.Name = "cboLote"
        Me.cboLote.Size = New System.Drawing.Size(175, 21)
        Me.cboLote.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(606, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(11, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(412, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(11, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "-"
        '
        'btnExportar
        '
        Me.btnExportar.FlatAppearance.BorderSize = 0
        Me.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportar.Image = Global.La_Andaluza_MovimientosDepositos.My.Resources.Resources.emblem_symbolic_link_2
        Me.btnExportar.Location = New System.Drawing.Point(933, 12)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(75, 63)
        Me.btnExportar.TabIndex = 11
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'frmTrasiego
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 96)
        Me.Controls.Add(Me.btnExportar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboLote)
        Me.Controls.Add(Me.cboProducto)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cboDepositoDestino)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.cboDepositoOrigen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTrasiego"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "frmTrasiego"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents cboDepositoOrigen As System.Windows.Forms.ComboBox
    Private WithEvents txtCantidad As System.Windows.Forms.TextBox
    Private WithEvents cboDepositoDestino As System.Windows.Forms.ComboBox
    Private WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents btnBorrar As System.Windows.Forms.Button
    Private WithEvents cboProducto As System.Windows.Forms.ComboBox
    Private WithEvents cboLote As System.Windows.Forms.ComboBox
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents btnExportar As System.Windows.Forms.Button
End Class
