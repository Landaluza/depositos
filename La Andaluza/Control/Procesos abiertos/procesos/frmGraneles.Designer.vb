﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGraneles
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
        Me.cboDepositoPArtida = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboRecipiente = New System.Windows.Forms.ComboBox()
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
        'cboDepositoPArtida
        '
        Me.cboDepositoPArtida.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboDepositoPArtida.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboDepositoPArtida.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboDepositoPArtida.FormattingEnabled = True
        Me.cboDepositoPArtida.Location = New System.Drawing.Point(131, 29)
        Me.cboDepositoPArtida.Name = "cboDepositoPArtida"
        Me.cboDepositoPArtida.Size = New System.Drawing.Size(81, 21)
        Me.cboDepositoPArtida.TabIndex = 35
        Me.ToolTip1.SetToolTip(Me.cboDepositoPArtida, "Producto de entrada")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(128, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Ventas"
        '
        'cboRecipiente
        '
        Me.cboRecipiente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboRecipiente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboRecipiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboRecipiente.FormattingEnabled = True
        Me.cboRecipiente.Location = New System.Drawing.Point(369, 29)
        Me.cboRecipiente.Name = "cboRecipiente"
        Me.cboRecipiente.Size = New System.Drawing.Size(188, 21)
        Me.cboRecipiente.TabIndex = 31
        Me.ToolTip1.SetToolTip(Me.cboRecipiente, "Deposito")
        '
        'txtCantidad
        '
        Me.txtCantidad.AccessibleDescription = "Cantidad"
        Me.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCantidad.Location = New System.Drawing.Point(238, 29)
        Me.txtCantidad.Multiline = True
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(106, 21)
        Me.txtCantidad.TabIndex = 30
        Me.ToolTip1.SetToolTip(Me.txtCantidad, "Litros del movimiento")
        '
        'frmGraneles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 107)
        Me.Controls.Add(Me.cboDepositoPArtida)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboRecipiente)
        Me.Controls.Add(Me.txtCantidad)
        Me.Name = "frmGraneles"
        Me.Text = "frmGraneles"
        Me.Controls.SetChildIndex(Me.btnExportar, 0)
        Me.Controls.SetChildIndex(Me.btnBorrar, 0)
        Me.Controls.SetChildIndex(Me.pbIconoOperacion, 0)
        Me.Controls.SetChildIndex(Me.txtCantidad, 0)
        Me.Controls.SetChildIndex(Me.cboRecipiente, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.cboDepositoPArtida, 0)
        CType(Me.pbIconoOperacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents cboDepositoPArtida As System.Windows.Forms.ComboBox
    Public WithEvents cboRecipiente As System.Windows.Forms.ComboBox
    Public WithEvents txtCantidad As System.Windows.Forms.TextBox
    Public WithEvents Label5 As System.Windows.Forms.Label
End Class