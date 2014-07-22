<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDesecho
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboDepositoPArtida = New System.Windows.Forms.ComboBox()
        Me.cboRecipiente = New System.Windows.Forms.ComboBox()
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(243, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 9)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Cantidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(374, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 9)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Recipiente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(136, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 9)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Deposito"
        '
        'cboDepositoPArtida
        '
        Me.cboDepositoPArtida.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboDepositoPArtida.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboDepositoPArtida.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboDepositoPArtida.FormattingEnabled = True
        Me.cboDepositoPArtida.Location = New System.Drawing.Point(138, 38)
        Me.cboDepositoPArtida.Name = "cboDepositoPArtida"
        Me.cboDepositoPArtida.Size = New System.Drawing.Size(81, 21)
        Me.cboDepositoPArtida.TabIndex = 46
        Me.ToolTip1.SetToolTip(Me.cboDepositoPArtida, "Producto de entrada")
        '
        'cboRecipiente
        '
        Me.cboRecipiente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboRecipiente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboRecipiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboRecipiente.FormattingEnabled = True
        Me.cboRecipiente.Location = New System.Drawing.Point(376, 38)
        Me.cboRecipiente.Name = "cboRecipiente"
        Me.cboRecipiente.Size = New System.Drawing.Size(188, 21)
        Me.cboRecipiente.TabIndex = 45
        Me.ToolTip1.SetToolTip(Me.cboRecipiente, "Deposito")
        '
        'txtCantidad
        '
        Me.txtCantidad.AccessibleDescription = "Cantidad"
        Me.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCantidad.Location = New System.Drawing.Point(245, 38)
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
        Me.Label5.Location = New System.Drawing.Point(76, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Desechos"
        '
        'frmDesecho
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 107)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboDepositoPArtida)
        Me.Controls.Add(Me.cboRecipiente)
        Me.Controls.Add(Me.txtCantidad)
        Me.Name = "frmDesecho"
        Me.Text = "frmDesecho"
        Me.Controls.SetChildIndex(Me.btnExportar, 0)
        Me.Controls.SetChildIndex(Me.btnBorrar, 0)
        Me.Controls.SetChildIndex(Me.pbIconoOperacion, 0)
        Me.Controls.SetChildIndex(Me.txtCantidad, 0)
        Me.Controls.SetChildIndex(Me.cboRecipiente, 0)
        Me.Controls.SetChildIndex(Me.cboDepositoPArtida, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        CType(Me.pbIconoOperacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents cboDepositoPArtida As System.Windows.Forms.ComboBox
    Public WithEvents cboRecipiente As System.Windows.Forms.ComboBox
    Public WithEvents txtCantidad As System.Windows.Forms.TextBox
    Public WithEvents Label5 As System.Windows.Forms.Label
End Class
