<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDesemboteNC
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboProductoFin = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboProveedor = New System.Windows.Forms.ComboBox()
        Me.cboProductoEntrada = New System.Windows.Forms.ComboBox()
        Me.cboDepositoDestino = New System.Windows.Forms.ComboBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.pbIconoOperacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbIconoOperacion
        '
        Me.pbIconoOperacion.Size = New System.Drawing.Size(94, 94)
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(113, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 9)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Producto final"
        '
        'cboProductoFin
        '
        Me.cboProductoFin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboProductoFin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboProductoFin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboProductoFin.FormattingEnabled = True
        Me.cboProductoFin.Location = New System.Drawing.Point(115, 65)
        Me.cboProductoFin.Name = "cboProductoFin"
        Me.cboProductoFin.Size = New System.Drawing.Size(202, 21)
        Me.cboProductoFin.TabIndex = 52
        Me.ToolTip1.SetToolTip(Me.cboProductoFin, "Producto de entrada")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(734, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 9)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Deposito"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(599, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 9)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Cantidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(352, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 9)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Proveedor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(113, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 9)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Producto entrada"
        '
        'cboProveedor
        '
        Me.cboProveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboProveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboProveedor.FormattingEnabled = True
        Me.cboProveedor.Location = New System.Drawing.Point(354, 44)
        Me.cboProveedor.Name = "cboProveedor"
        Me.cboProveedor.Size = New System.Drawing.Size(217, 21)
        Me.cboProveedor.TabIndex = 47
        Me.ToolTip1.SetToolTip(Me.cboProveedor, "Proveedor")
        '
        'cboProductoEntrada
        '
        Me.cboProductoEntrada.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboProductoEntrada.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboProductoEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboProductoEntrada.FormattingEnabled = True
        Me.cboProductoEntrada.Location = New System.Drawing.Point(115, 25)
        Me.cboProductoEntrada.Name = "cboProductoEntrada"
        Me.cboProductoEntrada.Size = New System.Drawing.Size(202, 21)
        Me.cboProductoEntrada.TabIndex = 46
        Me.ToolTip1.SetToolTip(Me.cboProductoEntrada, "Producto de entrada")
        '
        'cboDepositoDestino
        '
        Me.cboDepositoDestino.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboDepositoDestino.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboDepositoDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboDepositoDestino.FormattingEnabled = True
        Me.cboDepositoDestino.Location = New System.Drawing.Point(736, 44)
        Me.cboDepositoDestino.Name = "cboDepositoDestino"
        Me.cboDepositoDestino.Size = New System.Drawing.Size(81, 21)
        Me.cboDepositoDestino.TabIndex = 45
        Me.ToolTip1.SetToolTip(Me.cboDepositoDestino, "Deposito")
        '
        'txtCantidad
        '
        Me.txtCantidad.AccessibleDescription = "Cantidad"
        Me.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCantidad.Location = New System.Drawing.Point(601, 44)
        Me.txtCantidad.Multiline = True
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(106, 21)
        Me.txtCantidad.TabIndex = 44
        Me.ToolTip1.SetToolTip(Me.txtCantidad, "Litros del movimiento")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(61, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 79
        Me.Label5.Text = "DesemboteNC"
        '
        'frmDesemboteNC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 107)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboProductoFin)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboProveedor)
        Me.Controls.Add(Me.cboProductoEntrada)
        Me.Controls.Add(Me.cboDepositoDestino)
        Me.Controls.Add(Me.txtCantidad)
        Me.Name = "frmDesemboteNC"
        Me.Text = "frmDesemboteNC"
        Me.Controls.SetChildIndex(Me.btnExportar, 0)
        Me.Controls.SetChildIndex(Me.btnBorrar, 0)
        Me.Controls.SetChildIndex(Me.pbIconoOperacion, 0)
        Me.Controls.SetChildIndex(Me.txtCantidad, 0)
        Me.Controls.SetChildIndex(Me.cboDepositoDestino, 0)
        Me.Controls.SetChildIndex(Me.cboProductoEntrada, 0)
        Me.Controls.SetChildIndex(Me.cboProveedor, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.cboProductoFin, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        CType(Me.pbIconoOperacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents cboProductoFin As System.Windows.Forms.ComboBox
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents cboProveedor As System.Windows.Forms.ComboBox
    Public WithEvents cboProductoEntrada As System.Windows.Forms.ComboBox
    Public WithEvents cboDepositoDestino As System.Windows.Forms.ComboBox
    Public WithEvents txtCantidad As System.Windows.Forms.TextBox
    Private WithEvents Label5 As System.Windows.Forms.Label
End Class
