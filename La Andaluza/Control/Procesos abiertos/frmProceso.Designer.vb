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
        Me.components = New System.ComponentModel.Container()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.pbIconoOperacion = New System.Windows.Forms.PictureBox()
        Me.Panseparador = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.pbIconoOperacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBorrar
        '
        Me.btnBorrar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnBorrar.FlatAppearance.BorderSize = 0
        Me.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrar.Image = Global.La_Andaluza_MovimientosDepositosPruebas.My.Resources.Resources.glyphicons_197_remove
        Me.btnBorrar.Location = New System.Drawing.Point(618, 0)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 249)
        Me.btnBorrar.TabIndex = 12
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnExportar
        '
        Me.btnExportar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnExportar.FlatAppearance.BorderSize = 0
        Me.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportar.Image = Global.La_Andaluza_MovimientosDepositosPruebas.My.Resources.Resources.glyphicons_198_ok
        Me.btnExportar.Location = New System.Drawing.Point(693, 0)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(75, 249)
        Me.btnExportar.TabIndex = 13
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'pbIconoOperacion
        '
        Me.pbIconoOperacion.Dock = System.Windows.Forms.DockStyle.Left
        Me.pbIconoOperacion.Enabled = False
        Me.pbIconoOperacion.Image = Global.La_Andaluza_MovimientosDepositosPruebas.My.Resources.Resources.trasiego
        Me.pbIconoOperacion.Location = New System.Drawing.Point(0, 0)
        Me.pbIconoOperacion.Name = "pbIconoOperacion"
        Me.pbIconoOperacion.Size = New System.Drawing.Size(94, 249)
        Me.pbIconoOperacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbIconoOperacion.TabIndex = 14
        Me.pbIconoOperacion.TabStop = False
        '
        'Panseparador
        '
        Me.Panseparador.BackColor = System.Drawing.Color.Black
        Me.Panseparador.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panseparador.Enabled = False
        Me.Panseparador.Location = New System.Drawing.Point(0, 260)
        Me.Panseparador.Name = "Panseparador"
        Me.Panseparador.Size = New System.Drawing.Size(768, 2)
        Me.Panseparador.TabIndex = 15
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 249)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(768, 11)
        Me.Panel1.TabIndex = 16
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
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panseparador)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "frmProceso"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "frmProceso"
        CType(Me.pbIconoOperacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Protected WithEvents pbIconoOperacion As System.Windows.Forms.PictureBox
    Private WithEvents Panseparador As System.Windows.Forms.Panel
    Private WithEvents Panel1 As System.Windows.Forms.Panel
    Protected WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents btnBorrar As System.Windows.Forms.Button
    Public WithEvents btnExportar As System.Windows.Forms.Button
End Class
