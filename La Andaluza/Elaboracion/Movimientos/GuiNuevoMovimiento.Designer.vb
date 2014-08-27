<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GuiNuevoMovimiento
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
        Me.btnTrasiego = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnNiveles = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnTrasiego
        '
        Me.btnTrasiego.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTrasiego.Location = New System.Drawing.Point(49, 45)
        Me.btnTrasiego.Name = "btnTrasiego"
        Me.btnTrasiego.Size = New System.Drawing.Size(255, 23)
        Me.btnTrasiego.TabIndex = 0
        Me.btnTrasiego.Text = "Trasiego"
        Me.btnTrasiego.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(49, 74)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(255, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Compras"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(49, 103)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(255, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Ventas"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(49, 132)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(255, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Filtrados"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnNiveles
        '
        Me.btnNiveles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNiveles.Location = New System.Drawing.Point(49, 161)
        Me.btnNiveles.Name = "btnNiveles"
        Me.btnNiveles.Size = New System.Drawing.Size(255, 23)
        Me.btnNiveles.TabIndex = 4
        Me.btnNiveles.Text = "Niveles"
        Me.btnNiveles.UseVisualStyleBackColor = True
        '
        'GuiNuevoMovimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 303)
        Me.Controls.Add(Me.btnNiveles)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnTrasiego)
        Me.Name = "GuiNuevoMovimiento"
        Me.Text = "NuevoMovimiento"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents btnTrasiego As System.Windows.Forms.Button
    Private WithEvents Button1 As System.Windows.Forms.Button
    Private WithEvents Button2 As System.Windows.Forms.Button
    Private WithEvents Button3 As System.Windows.Forms.Button
    Private WithEvents btnNiveles As System.Windows.Forms.Button
End Class
