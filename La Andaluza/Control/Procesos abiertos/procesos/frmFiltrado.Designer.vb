<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFiltrado
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
        Me.cboFiltro = New System.Windows.Forms.ComboBox()
        Me.cboDepositoDestino = New System.Windows.Forms.ComboBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.cboDepositoPartida = New System.Windows.Forms.ComboBox()
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(125, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Filtración"
        '
        'cboFiltro
        '
        Me.cboFiltro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboFiltro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboFiltro.FormattingEnabled = True
        Me.cboFiltro.Location = New System.Drawing.Point(225, 34)
        Me.cboFiltro.Name = "cboFiltro"
        Me.cboFiltro.Size = New System.Drawing.Size(175, 21)
        Me.cboFiltro.TabIndex = 32
        Me.ToolTip1.SetToolTip(Me.cboFiltro, "Tipo de filtro")
        '
        'cboDepositoDestino
        '
        Me.cboDepositoDestino.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboDepositoDestino.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboDepositoDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboDepositoDestino.FormattingEnabled = True
        Me.cboDepositoDestino.Location = New System.Drawing.Point(537, 34)
        Me.cboDepositoDestino.Name = "cboDepositoDestino"
        Me.cboDepositoDestino.Size = New System.Drawing.Size(81, 21)
        Me.cboDepositoDestino.TabIndex = 31
        Me.ToolTip1.SetToolTip(Me.cboDepositoDestino, "Deposito final")
        '
        'txtCantidad
        '
        Me.txtCantidad.AccessibleDescription = "Cantidad"
        Me.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCantidad.Location = New System.Drawing.Point(415, 34)
        Me.txtCantidad.Multiline = True
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(106, 21)
        Me.txtCantidad.TabIndex = 30
        Me.ToolTip1.SetToolTip(Me.txtCantidad, "Litros del movimiento")
        '
        'cboDepositoPartida
        '
        Me.cboDepositoPartida.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboDepositoPartida.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboDepositoPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboDepositoPartida.FormattingEnabled = True
        Me.cboDepositoPartida.Location = New System.Drawing.Point(128, 34)
        Me.cboDepositoPartida.Name = "cboDepositoPartida"
        Me.cboDepositoPartida.Size = New System.Drawing.Size(81, 21)
        Me.cboDepositoPartida.TabIndex = 35
        Me.ToolTip1.SetToolTip(Me.cboDepositoPartida, "Deposito de partida")
        '
        'frmFiltrado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 107)
        Me.Controls.Add(Me.cboDepositoPartida)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboFiltro)
        Me.Controls.Add(Me.cboDepositoDestino)
        Me.Controls.Add(Me.txtCantidad)
        Me.Name = "frmFiltrado"
        Me.Text = "frmFiltrado"
        Me.Controls.SetChildIndex(Me.txtCantidad, 0)
        Me.Controls.SetChildIndex(Me.cboDepositoDestino, 0)
        Me.Controls.SetChildIndex(Me.cboFiltro, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.cboDepositoPartida, 0)
        Me.Controls.SetChildIndex(Me.btnExportar, 0)
        Me.Controls.SetChildIndex(Me.btnBorrar, 0)
        Me.Controls.SetChildIndex(Me.pbIconoOperacion, 0)
        CType(Me.pbIconoOperacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents cboFiltro As System.Windows.Forms.ComboBox
    Public WithEvents cboDepositoDestino As System.Windows.Forms.ComboBox
    Public WithEvents txtCantidad As System.Windows.Forms.TextBox
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents cboDepositoPartida As System.Windows.Forms.ComboBox
End Class
