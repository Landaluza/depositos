<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProceso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProceso))
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.pbIconoOperacion = New System.Windows.Forms.PictureBox()
        CType(Me.pbIconoOperacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBorrar
        '
        Me.btnBorrar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnBorrar.FlatAppearance.BorderSize = 0
        Me.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrar.Image = CType(resources.GetObject("btnBorrar.Image"), System.Drawing.Image)
        Me.btnBorrar.Location = New System.Drawing.Point(618, 0)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 262)
        Me.btnBorrar.TabIndex = 12
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnExportar
        '
        Me.btnExportar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnExportar.FlatAppearance.BorderSize = 0
        Me.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
        Me.btnExportar.Location = New System.Drawing.Point(693, 0)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(75, 262)
        Me.btnExportar.TabIndex = 13
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'pbIconoOperacion
        '
        Me.pbIconoOperacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbIconoOperacion.Dock = System.Windows.Forms.DockStyle.Left
        Me.pbIconoOperacion.Enabled = False
        Me.pbIconoOperacion.Image = Global.La_Andaluza_MovimientosDepositos.My.Resources.Resources.trasiego
        Me.pbIconoOperacion.Location = New System.Drawing.Point(0, 0)
        Me.pbIconoOperacion.Name = "pbIconoOperacion"
        Me.pbIconoOperacion.Size = New System.Drawing.Size(94, 262)
        Me.pbIconoOperacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbIconoOperacion.TabIndex = 14
        Me.pbIconoOperacion.TabStop = False
        '
        'frmProceso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 262)
        Me.ControlBox = False
        Me.Controls.Add(Me.pbIconoOperacion)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnExportar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "frmProceso"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "frmProceso"
        CType(Me.pbIconoOperacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Protected WithEvents btnBorrar As System.Windows.Forms.Button
    Protected WithEvents btnExportar As System.Windows.Forms.Button
    Protected WithEvents pbIconoOperacion As System.Windows.Forms.PictureBox
End Class
