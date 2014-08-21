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
        'NuevoMovimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 303)
        Me.Controls.Add(Me.btnTrasiego)
        Me.Name = "NuevoMovimiento"
        Me.Text = "NuevoMovimiento"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents btnTrasiego As System.Windows.Forms.Button
End Class
