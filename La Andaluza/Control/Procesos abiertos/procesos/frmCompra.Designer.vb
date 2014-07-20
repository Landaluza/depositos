<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompra
    Inherits frmProceso

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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboLote = New System.Windows.Forms.ComboBox()
        Me.cboProducto = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboDepositoDestino = New System.Windows.Forms.ComboBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.pbIconoOperacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBorrar
        '
        Me.btnBorrar.FlatAppearance.BorderSize = 0
        Me.btnBorrar.Location = New System.Drawing.Point(870, 0)
        Me.btnBorrar.Size = New System.Drawing.Size(75, 94)
        '
        'btnExportar
        '
        Me.btnExportar.FlatAppearance.BorderSize = 0
        Me.btnExportar.Location = New System.Drawing.Point(945, 0)
        Me.btnExportar.Size = New System.Drawing.Size(75, 94)
        '
        'pbIconoOperacion
        '
        Me.pbIconoOperacion.Size = New System.Drawing.Size(94, 94)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(113, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Compra"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(421, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(11, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(615, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(11, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "-"
        '
        'cboLote
        '
        Me.cboLote.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboLote.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboLote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboLote.FormattingEnabled = True
        Me.cboLote.Location = New System.Drawing.Point(635, 38)
        Me.cboLote.Name = "cboLote"
        Me.cboLote.Size = New System.Drawing.Size(175, 21)
        Me.cboLote.TabIndex = 25
        Me.ToolTip1.SetToolTip(Me.cboLote, "Tipo de lote de la salida")
        '
        'cboProducto
        '
        Me.cboProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboProducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboProducto.FormattingEnabled = True
        Me.cboProducto.Location = New System.Drawing.Point(438, 38)
        Me.cboProducto.Name = "cboProducto"
        Me.cboProducto.Size = New System.Drawing.Size(168, 21)
        Me.cboProducto.TabIndex = 23
        Me.ToolTip1.SetToolTip(Me.cboProducto, "Tipo de producto de la salida")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(329, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(11, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "-"
        '
        'cboDepositoDestino
        '
        Me.cboDepositoDestino.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboDepositoDestino.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboDepositoDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboDepositoDestino.FormattingEnabled = True
        Me.cboDepositoDestino.Location = New System.Drawing.Point(348, 38)
        Me.cboDepositoDestino.Name = "cboDepositoDestino"
        Me.cboDepositoDestino.Size = New System.Drawing.Size(70, 21)
        Me.cboDepositoDestino.TabIndex = 21
        Me.ToolTip1.SetToolTip(Me.cboDepositoDestino, "Deposito de entrada")
        '
        'txtCantidad
        '
        Me.txtCantidad.AccessibleDescription = "Cantidad"
        Me.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCantidad.Location = New System.Drawing.Point(214, 38)
        Me.txtCantidad.Multiline = True
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(106, 21)
        Me.txtCantidad.TabIndex = 19
        Me.ToolTip1.SetToolTip(Me.txtCantidad, "Litros del movimiento")
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(116, 34)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(168, 21)
        Me.ComboBox1.TabIndex = 27
        Me.ToolTip1.SetToolTip(Me.ComboBox1, "Tipo de producto de la salida")
        '
        'frmCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 107)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboLote)
        Me.Controls.Add(Me.cboProducto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboDepositoDestino)
        Me.Controls.Add(Me.txtCantidad)
        Me.MinimizeBox = False
        Me.Name = "frmCompra"
        Me.Text = "frmCompra"
        Me.Controls.SetChildIndex(Me.btnExportar, 0)
        Me.Controls.SetChildIndex(Me.btnBorrar, 0)
        Me.Controls.SetChildIndex(Me.pbIconoOperacion, 0)
        Me.Controls.SetChildIndex(Me.txtCantidad, 0)
        Me.Controls.SetChildIndex(Me.cboDepositoDestino, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.cboProducto, 0)
        Me.Controls.SetChildIndex(Me.cboLote, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.ComboBox1, 0)
        CType(Me.pbIconoOperacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents cboLote As System.Windows.Forms.ComboBox
    Private WithEvents cboProducto As System.Windows.Forms.ComboBox
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents cboDepositoDestino As System.Windows.Forms.ComboBox
    Private WithEvents txtCantidad As System.Windows.Forms.TextBox
    Private WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
