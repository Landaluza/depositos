<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntTiposMovimientos
    Inherits DetailedSimpleForm

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntTiposMovimientos))
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.lblAbreviatura = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()
        Me.txtAbreviatura = New System.Windows.Forms.TextBox()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMiddle.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(113, 44)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(200, 21)
        Me.txtDescripcion.TabIndex = 1
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tlpMiddle.SetColumnSpan(Me.txtObservaciones, 4)
        Me.txtObservaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(113, 71)
        Me.txtObservaciones.MaxLength = 3000
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(280, 21)
        Me.txtObservaciones.TabIndex = 2
        '
        'lblAbreviatura
        '
        Me.lblAbreviatura.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAbreviatura.Location = New System.Drawing.Point(23, 15)
        Me.lblAbreviatura.Name = "lblAbreviatura"
        Me.lblAbreviatura.Size = New System.Drawing.Size(84, 26)
        Me.lblAbreviatura.TabIndex = 0
        Me.lblAbreviatura.Text = "Abreviatura"
        Me.lblAbreviatura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDescripcion.Location = New System.Drawing.Point(23, 41)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(84, 27)
        Me.lblDescripcion.TabIndex = 1
        Me.lblDescripcion.Text = "Descripcion"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblObservaciones.Location = New System.Drawing.Point(23, 68)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(84, 27)
        Me.lblObservaciones.TabIndex = 2
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpMiddle
        '
        Me.tlpMiddle.AutoSize = True
        Me.tlpMiddle.ColumnCount = 8
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47.0!))
        Me.tlpMiddle.Controls.Add(Me.lblAbreviatura, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.lblDescripcion, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.txtDescripcion, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.lblObservaciones, 1, 2)
        Me.tlpMiddle.Controls.Add(Me.txtObservaciones, 2, 2)
        Me.tlpMiddle.Controls.Add(Me.txtAbreviatura, 2, 0)
        Me.tlpMiddle.Location = New System.Drawing.Point(0, 25)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.Padding = New System.Windows.Forms.Padding(0, 15, 0, 0)
        Me.tlpMiddle.RowCount = 4
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(443, 115)
        Me.tlpMiddle.TabIndex = 8
        '
        'txtAbreviatura
        '
        Me.txtAbreviatura.Location = New System.Drawing.Point(113, 18)
        Me.txtAbreviatura.MaxLength = 1
        Me.txtAbreviatura.Name = "txtAbreviatura"
        Me.txtAbreviatura.Size = New System.Drawing.Size(100, 20)
        Me.txtAbreviatura.TabIndex = 3
        '
        'frmEntTiposMovimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(427, 344)
        Me.Controls.Add(Me.tlpMiddle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(443, 134)
        Me.Name = "frmEntTiposMovimientos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "TiposMovimientos"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Private WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Private WithEvents lblAbreviatura As System.Windows.Forms.Label
    Private WithEvents lblDescripcion As System.Windows.Forms.Label
    Private WithEvents lblObservaciones As System.Windows.Forms.Label
    Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel
    Private WithEvents txtAbreviatura As System.Windows.Forms.TextBox
End Class
