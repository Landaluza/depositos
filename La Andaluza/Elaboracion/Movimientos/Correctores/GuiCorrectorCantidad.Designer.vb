<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GuiCorrectorCantidad
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
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAceptar
        '
        Me.btnAceptar.FlatAppearance.BorderSize = 0
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Image = Global.La_Andaluza_MovimientosDepositos.My.Resources.Resources.glyphicons_198_ok
        Me.btnAceptar.Location = New System.Drawing.Point(365, 148)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(39, 39)
        Me.btnAceptar.TabIndex = 7
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Image = Global.La_Andaluza_MovimientosDepositos.My.Resources.Resources.glyphicons_197_remove
        Me.btnCancelar.Location = New System.Drawing.Point(320, 148)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(39, 39)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txtCantidad
        '
        Me.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCantidad.Location = New System.Drawing.Point(191, 75)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidad.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(92, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Nueva cantidad"
        '
        'GuiCorrectorCantidad
        '
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(419, 192)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "GuiCorrectorCantidad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents TextBox1 As System.Windows.Forms.TextBox
    Private WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Private WithEvents Button1 As System.Windows.Forms.Button
    Private WithEvents Button2 As System.Windows.Forms.Button
    Private WithEvents btnAceptar As System.Windows.Forms.Button
    Private WithEvents btnCancelar As System.Windows.Forms.Button
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents txtCantidad As System.Windows.Forms.TextBox
End Class
