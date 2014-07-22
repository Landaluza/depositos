<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFermentacion
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboDepositoPartida = New System.Windows.Forms.ComboBox()
        Me.cboDepositoDestino = New System.Windows.Forms.ComboBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(366, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 9)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Deposito final"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(232, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 9)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Cantidad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(122, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 9)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Deposito"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(74, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Fermentación"
        '
        'cboDepositoPartida
        '
        Me.cboDepositoPartida.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboDepositoPartida.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboDepositoPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboDepositoPartida.FormattingEnabled = True
        Me.cboDepositoPartida.Location = New System.Drawing.Point(124, 38)
        Me.cboDepositoPartida.Name = "cboDepositoPartida"
        Me.cboDepositoPartida.Size = New System.Drawing.Size(81, 21)
        Me.cboDepositoPartida.TabIndex = 50
        Me.ToolTip1.SetToolTip(Me.cboDepositoPartida, "Deposito de partida")
        '
        'cboDepositoDestino
        '
        Me.cboDepositoDestino.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboDepositoDestino.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboDepositoDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboDepositoDestino.FormattingEnabled = True
        Me.cboDepositoDestino.Location = New System.Drawing.Point(368, 38)
        Me.cboDepositoDestino.Name = "cboDepositoDestino"
        Me.cboDepositoDestino.Size = New System.Drawing.Size(81, 21)
        Me.cboDepositoDestino.TabIndex = 47
        Me.ToolTip1.SetToolTip(Me.cboDepositoDestino, "Deposito final")
        '
        'txtCantidad
        '
        Me.txtCantidad.AccessibleDescription = "Cantidad"
        Me.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCantidad.Location = New System.Drawing.Point(234, 38)
        Me.txtCantidad.Multiline = True
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(106, 21)
        Me.txtCantidad.TabIndex = 46
        Me.ToolTip1.SetToolTip(Me.txtCantidad, "Litros del movimiento")
        '
        'frmFermentacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 107)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboDepositoPartida)
        Me.Controls.Add(Me.cboDepositoDestino)
        Me.Controls.Add(Me.txtCantidad)
        Me.Name = "frmFermentacion"
        Me.Text = "frmFermentacion"
        Me.Controls.SetChildIndex(Me.btnExportar, 0)
        Me.Controls.SetChildIndex(Me.btnBorrar, 0)
        Me.Controls.SetChildIndex(Me.pbIconoOperacion, 0)
        Me.Controls.SetChildIndex(Me.txtCantidad, 0)
        Me.Controls.SetChildIndex(Me.cboDepositoDestino, 0)
        Me.Controls.SetChildIndex(Me.cboDepositoPartida, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        CType(Me.pbIconoOperacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents cboDepositoPartida As System.Windows.Forms.ComboBox
    Public WithEvents cboDepositoDestino As System.Windows.Forms.ComboBox
    Public WithEvents txtCantidad As System.Windows.Forms.TextBox
End Class
