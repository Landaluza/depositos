<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResumenBorradoDeposito
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
        Me.gbDeposito = New System.Windows.Forms.GroupBox()
        Me.ldepositoDuplicado = New System.Windows.Forms.Label()
        Me.cbDeposito = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboDepositoPrevio = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboDeposito = New System.Windows.Forms.ComboBox()
        Me.lLoteOrigen = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.cbBorrarDestino = New System.Windows.Forms.CheckBox()
        Me.lBorrarDestino = New System.Windows.Forms.Label()
        Me.lBorrarDestinoReflexivo = New System.Windows.Forms.Label()
        Me.gbDestino = New System.Windows.Forms.GroupBox()
        Me.lBorrarDestinoTrazabilidad = New System.Windows.Forms.Label()
        Me.lLoteDestino = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gbDeposito2 = New System.Windows.Forms.GroupBox()
        Me.ldepositoDuplicado2 = New System.Windows.Forms.Label()
        Me.cbDeposito2 = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboDepositoPrevio2 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboDeposito2 = New System.Windows.Forms.ComboBox()
        Me.lLoteOrigen2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.gbDeposito.SuspendLayout()
        Me.gbDestino.SuspendLayout()
        Me.gbDeposito2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbDeposito
        '
        Me.gbDeposito.Controls.Add(Me.ldepositoDuplicado)
        Me.gbDeposito.Controls.Add(Me.cbDeposito)
        Me.gbDeposito.Controls.Add(Me.Label2)
        Me.gbDeposito.Controls.Add(Me.cboDepositoPrevio)
        Me.gbDeposito.Controls.Add(Me.Label1)
        Me.gbDeposito.Controls.Add(Me.cboDeposito)
        Me.gbDeposito.Enabled = False
        Me.gbDeposito.Location = New System.Drawing.Point(30, 12)
        Me.gbDeposito.Name = "gbDeposito"
        Me.gbDeposito.Size = New System.Drawing.Size(466, 134)
        Me.gbDeposito.TabIndex = 0
        Me.gbDeposito.TabStop = False
        Me.gbDeposito.Text = "Depositos del origen"
        '
        'ldepositoDuplicado
        '
        Me.ldepositoDuplicado.AutoSize = True
        Me.ldepositoDuplicado.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ldepositoDuplicado.ForeColor = System.Drawing.Color.DarkRed
        Me.ldepositoDuplicado.Location = New System.Drawing.Point(107, 97)
        Me.ldepositoDuplicado.Name = "ldepositoDuplicado"
        Me.ldepositoDuplicado.Size = New System.Drawing.Size(159, 9)
        Me.ldepositoDuplicado.TabIndex = 5
        Me.ldepositoDuplicado.Text = "El deposito se encuentra ocupado por otro lote"
        Me.ldepositoDuplicado.Visible = False
        '
        'cbDeposito
        '
        Me.cbDeposito.AutoSize = True
        Me.cbDeposito.Location = New System.Drawing.Point(290, 75)
        Me.cbDeposito.Name = "cbDeposito"
        Me.cbDeposito.Size = New System.Drawing.Size(161, 17)
        Me.cbDeposito.TabIndex = 4
        Me.cbDeposito.Text = "Devolver al deposito anterior"
        Me.cbDeposito.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Deposito previo"
        '
        'cboDepositoPrevio
        '
        Me.cboDepositoPrevio.Enabled = False
        Me.cboDepositoPrevio.FormattingEnabled = True
        Me.cboDepositoPrevio.Location = New System.Drawing.Point(109, 73)
        Me.cboDepositoPrevio.Name = "cboDepositoPrevio"
        Me.cboDepositoPrevio.Size = New System.Drawing.Size(164, 21)
        Me.cboDepositoPrevio.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Deposito actual"
        '
        'cboDeposito
        '
        Me.cboDeposito.Enabled = False
        Me.cboDeposito.FormattingEnabled = True
        Me.cboDeposito.Location = New System.Drawing.Point(109, 46)
        Me.cboDeposito.Name = "cboDeposito"
        Me.cboDeposito.Size = New System.Drawing.Size(164, 21)
        Me.cboDeposito.TabIndex = 0
        '
        'lLoteOrigen
        '
        Me.lLoteOrigen.AutoSize = True
        Me.lLoteOrigen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lLoteOrigen.Location = New System.Drawing.Point(802, 78)
        Me.lLoteOrigen.Name = "lLoteOrigen"
        Me.lLoteOrigen.Size = New System.Drawing.Size(10, 13)
        Me.lLoteOrigen.TabIndex = 7
        Me.lLoteOrigen.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(621, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Lote final"
        '
        'btnAceptar
        '
        Me.btnAceptar.FlatAppearance.BorderSize = 0
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Image = Global.La_Andaluza_MovimientosDepositosPruebas.My.Resources.Resources.glyphicons_198_ok
        Me.btnAceptar.Location = New System.Drawing.Point(833, 17)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(133, 64)
        Me.btnAceptar.TabIndex = 1
        Me.btnAceptar.Text = "Confirmar"
        Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Image = Global.La_Andaluza_MovimientosDepositosPruebas.My.Resources.Resources.glyphicons_197_remove
        Me.btnCancelar.Location = New System.Drawing.Point(678, 17)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(133, 64)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'cbBorrarDestino
        '
        Me.cbBorrarDestino.AutoSize = True
        Me.cbBorrarDestino.Location = New System.Drawing.Point(19, 50)
        Me.cbBorrarDestino.Name = "cbBorrarDestino"
        Me.cbBorrarDestino.Size = New System.Drawing.Size(137, 17)
        Me.cbBorrarDestino.TabIndex = 3
        Me.cbBorrarDestino.Text = "Borrar el lote de destino"
        Me.cbBorrarDestino.UseVisualStyleBackColor = True
        Me.cbBorrarDestino.Visible = False
        '
        'lBorrarDestino
        '
        Me.lBorrarDestino.AutoSize = True
        Me.lBorrarDestino.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lBorrarDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lBorrarDestino.ForeColor = System.Drawing.Color.DarkRed
        Me.lBorrarDestino.Location = New System.Drawing.Point(3, 113)
        Me.lBorrarDestino.Name = "lBorrarDestino"
        Me.lBorrarDestino.Size = New System.Drawing.Size(307, 13)
        Me.lBorrarDestino.TabIndex = 4
        Me.lBorrarDestino.Text = "El lote de destino contiene trazabilidad y no puede ser eliminado"
        Me.lBorrarDestino.Visible = False
        '
        'lBorrarDestinoReflexivo
        '
        Me.lBorrarDestinoReflexivo.AutoSize = True
        Me.lBorrarDestinoReflexivo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lBorrarDestinoReflexivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lBorrarDestinoReflexivo.ForeColor = System.Drawing.Color.DarkRed
        Me.lBorrarDestinoReflexivo.Location = New System.Drawing.Point(3, 100)
        Me.lBorrarDestinoReflexivo.Name = "lBorrarDestinoReflexivo"
        Me.lBorrarDestinoReflexivo.Size = New System.Drawing.Size(317, 13)
        Me.lBorrarDestinoReflexivo.TabIndex = 5
        Me.lBorrarDestinoReflexivo.Text = "El movimiento es reflexivo y no se pudede borrar el lote de destino"
        Me.lBorrarDestinoReflexivo.Visible = False
        '
        'gbDestino
        '
        Me.gbDestino.Controls.Add(Me.lBorrarDestinoTrazabilidad)
        Me.gbDestino.Controls.Add(Me.cbBorrarDestino)
        Me.gbDestino.Controls.Add(Me.lBorrarDestinoReflexivo)
        Me.gbDestino.Controls.Add(Me.lBorrarDestino)
        Me.gbDestino.Location = New System.Drawing.Point(30, 297)
        Me.gbDestino.Name = "gbDestino"
        Me.gbDestino.Size = New System.Drawing.Size(466, 129)
        Me.gbDestino.TabIndex = 6
        Me.gbDestino.TabStop = False
        Me.gbDestino.Text = "Destino"
        '
        'lBorrarDestinoTrazabilidad
        '
        Me.lBorrarDestinoTrazabilidad.AutoSize = True
        Me.lBorrarDestinoTrazabilidad.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lBorrarDestinoTrazabilidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lBorrarDestinoTrazabilidad.ForeColor = System.Drawing.Color.DarkRed
        Me.lBorrarDestinoTrazabilidad.Location = New System.Drawing.Point(3, 87)
        Me.lBorrarDestinoTrazabilidad.Name = "lBorrarDestinoTrazabilidad"
        Me.lBorrarDestinoTrazabilidad.Size = New System.Drawing.Size(169, 13)
        Me.lBorrarDestinoTrazabilidad.TabIndex = 6
        Me.lBorrarDestinoTrazabilidad.Text = "El movimiento no tiene trazabilidad"
        Me.lBorrarDestinoTrazabilidad.Visible = False
        '
        'lLoteDestino
        '
        Me.lLoteDestino.AutoSize = True
        Me.lLoteDestino.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lLoteDestino.Location = New System.Drawing.Point(802, 55)
        Me.lLoteDestino.Name = "lLoteDestino"
        Me.lLoteDestino.Size = New System.Drawing.Size(10, 13)
        Me.lLoteDestino.TabIndex = 9
        Me.lLoteDestino.Text = "-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(621, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Lote origen"
        '
        'gbDeposito2
        '
        Me.gbDeposito2.Controls.Add(Me.ldepositoDuplicado2)
        Me.gbDeposito2.Controls.Add(Me.cbDeposito2)
        Me.gbDeposito2.Controls.Add(Me.Label6)
        Me.gbDeposito2.Controls.Add(Me.cboDepositoPrevio2)
        Me.gbDeposito2.Controls.Add(Me.Label7)
        Me.gbDeposito2.Controls.Add(Me.cboDeposito2)
        Me.gbDeposito2.Enabled = False
        Me.gbDeposito2.Location = New System.Drawing.Point(30, 157)
        Me.gbDeposito2.Name = "gbDeposito2"
        Me.gbDeposito2.Size = New System.Drawing.Size(466, 134)
        Me.gbDeposito2.TabIndex = 10
        Me.gbDeposito2.TabStop = False
        Me.gbDeposito2.Text = "Depositos del segundo origen"
        '
        'ldepositoDuplicado2
        '
        Me.ldepositoDuplicado2.AutoSize = True
        Me.ldepositoDuplicado2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ldepositoDuplicado2.ForeColor = System.Drawing.Color.DarkRed
        Me.ldepositoDuplicado2.Location = New System.Drawing.Point(107, 97)
        Me.ldepositoDuplicado2.Name = "ldepositoDuplicado2"
        Me.ldepositoDuplicado2.Size = New System.Drawing.Size(159, 9)
        Me.ldepositoDuplicado2.TabIndex = 5
        Me.ldepositoDuplicado2.Text = "El deposito se encuentra ocupado por otro lote"
        Me.ldepositoDuplicado2.Visible = False
        '
        'cbDeposito2
        '
        Me.cbDeposito2.AutoSize = True
        Me.cbDeposito2.Location = New System.Drawing.Point(290, 75)
        Me.cbDeposito2.Name = "cbDeposito2"
        Me.cbDeposito2.Size = New System.Drawing.Size(161, 17)
        Me.cbDeposito2.TabIndex = 4
        Me.cbDeposito2.Text = "Devolver al deposito anterior"
        Me.cbDeposito2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Deposito previo"
        '
        'cboDepositoPrevio2
        '
        Me.cboDepositoPrevio2.Enabled = False
        Me.cboDepositoPrevio2.FormattingEnabled = True
        Me.cboDepositoPrevio2.Location = New System.Drawing.Point(109, 73)
        Me.cboDepositoPrevio2.Name = "cboDepositoPrevio2"
        Me.cboDepositoPrevio2.Size = New System.Drawing.Size(164, 21)
        Me.cboDepositoPrevio2.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Deposito actual"
        '
        'cboDeposito2
        '
        Me.cboDeposito2.Enabled = False
        Me.cboDeposito2.FormattingEnabled = True
        Me.cboDeposito2.Location = New System.Drawing.Point(109, 46)
        Me.cboDeposito2.Name = "cboDeposito2"
        Me.cboDeposito2.Size = New System.Drawing.Size(164, 21)
        Me.cboDeposito2.TabIndex = 0
        '
        'lLoteOrigen2
        '
        Me.lLoteOrigen2.AutoSize = True
        Me.lLoteOrigen2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lLoteOrigen2.Location = New System.Drawing.Point(802, 104)
        Me.lLoteOrigen2.Name = "lLoteOrigen2"
        Me.lLoteOrigen2.Size = New System.Drawing.Size(10, 13)
        Me.lLoteOrigen2.TabIndex = 11
        Me.lLoteOrigen2.Text = "-"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(621, 104)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(121, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Segundo lote origen"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.btnAceptar)
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 477)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(998, 94)
        Me.Panel1.TabIndex = 13
        '
        'frmResumenBorradoDeposito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(998, 571)
        Me.Controls.Add(Me.lLoteOrigen2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.gbDeposito2)
        Me.Controls.Add(Me.lLoteDestino)
        Me.Controls.Add(Me.gbDestino)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lLoteOrigen)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.gbDeposito)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmResumenBorradoDeposito"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Resumen eliminar movimiento"
        Me.gbDeposito.ResumeLayout(False)
        Me.gbDeposito.PerformLayout()
        Me.gbDestino.ResumeLayout(False)
        Me.gbDestino.PerformLayout()
        Me.gbDeposito2.ResumeLayout(False)
        Me.gbDeposito2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents btnAceptar As System.Windows.Forms.Button
    Private WithEvents btnCancelar As System.Windows.Forms.Button
    Public WithEvents gbDeposito As System.Windows.Forms.GroupBox
    Public WithEvents cbDeposito As System.Windows.Forms.CheckBox
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents cboDepositoPrevio As System.Windows.Forms.ComboBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents cboDeposito As System.Windows.Forms.ComboBox
    Public WithEvents ldepositoDuplicado As System.Windows.Forms.Label
    Public WithEvents cbBorrarDestino As System.Windows.Forms.CheckBox
    Public WithEvents lBorrarDestino As System.Windows.Forms.Label
    Public WithEvents gbDestino As System.Windows.Forms.GroupBox
    Public WithEvents lBorrarDestinoReflexivo As System.Windows.Forms.Label
    Public WithEvents lBorrarDestinoTrazabilidad As System.Windows.Forms.Label
    Public WithEvents lLoteOrigen As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents lLoteDestino As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents gbDeposito2 As System.Windows.Forms.GroupBox
    Public WithEvents ldepositoDuplicado2 As System.Windows.Forms.Label
    Public WithEvents cbDeposito2 As System.Windows.Forms.CheckBox
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents cboDepositoPrevio2 As System.Windows.Forms.ComboBox
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents cboDeposito2 As System.Windows.Forms.ComboBox
    Public WithEvents lLoteOrigen2 As System.Windows.Forms.Label
    Public WithEvents Label9 As System.Windows.Forms.Label
    Private WithEvents Panel1 As System.Windows.Forms.Panel
End Class
