﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.cbBorrarDestino = New System.Windows.Forms.CheckBox()
        Me.lBorrarDestino = New System.Windows.Forms.Label()
        Me.lBorrarDestinoReflexivo = New System.Windows.Forms.Label()
        Me.gbDestino = New System.Windows.Forms.GroupBox()
        Me.lBorrarDestinoTrazabilidad = New System.Windows.Forms.Label()
        Me.gbDeposito.SuspendLayout()
        Me.gbDestino.SuspendLayout()
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
        Me.gbDeposito.Location = New System.Drawing.Point(30, 25)
        Me.gbDeposito.Name = "gbDeposito"
        Me.gbDeposito.Size = New System.Drawing.Size(466, 121)
        Me.gbDeposito.TabIndex = 0
        Me.gbDeposito.TabStop = False
        Me.gbDeposito.Text = "Deposito"
        '
        'ldepositoDuplicado
        '
        Me.ldepositoDuplicado.AutoSize = True
        Me.ldepositoDuplicado.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ldepositoDuplicado.ForeColor = System.Drawing.Color.DarkRed
        Me.ldepositoDuplicado.Location = New System.Drawing.Point(76, 80)
        Me.ldepositoDuplicado.Name = "ldepositoDuplicado"
        Me.ldepositoDuplicado.Size = New System.Drawing.Size(159, 9)
        Me.ldepositoDuplicado.TabIndex = 5
        Me.ldepositoDuplicado.Text = "El deposito se encuentra ocupado por otro lote"
        Me.ldepositoDuplicado.Visible = False
        '
        'cbDeposito
        '
        Me.cbDeposito.AutoSize = True
        Me.cbDeposito.Location = New System.Drawing.Point(288, 58)
        Me.cbDeposito.Name = "cbDeposito"
        Me.cbDeposito.Size = New System.Drawing.Size(161, 17)
        Me.cbDeposito.TabIndex = 4
        Me.cbDeposito.Text = "Devolver al deposiot anterior"
        Me.cbDeposito.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Previo"
        '
        'cboDepositoPrevio
        '
        Me.cboDepositoPrevio.Enabled = False
        Me.cboDepositoPrevio.FormattingEnabled = True
        Me.cboDepositoPrevio.Location = New System.Drawing.Point(78, 56)
        Me.cboDepositoPrevio.Name = "cboDepositoPrevio"
        Me.cboDepositoPrevio.Size = New System.Drawing.Size(164, 21)
        Me.cboDepositoPrevio.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Actual"
        '
        'cboDeposito
        '
        Me.cboDeposito.Enabled = False
        Me.cboDeposito.FormattingEnabled = True
        Me.cboDeposito.Location = New System.Drawing.Point(78, 29)
        Me.cboDeposito.Name = "cboDeposito"
        Me.cboDeposito.Size = New System.Drawing.Size(164, 21)
        Me.cboDeposito.TabIndex = 0
        '
        'btnAceptar
        '
        Me.btnAceptar.FlatAppearance.BorderSize = 0
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Image = Global.La_Andaluza_MovimientosDepositos.My.Resources.Resources.dialog_ok_3
        Me.btnAceptar.Location = New System.Drawing.Point(597, 349)
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
        Me.btnCancelar.Image = Global.La_Andaluza_MovimientosDepositos.My.Resources.Resources.dialog_cancel_3
        Me.btnCancelar.Location = New System.Drawing.Point(442, 349)
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
        Me.cbBorrarDestino.Location = New System.Drawing.Point(19, 30)
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
        Me.lBorrarDestino.Location = New System.Drawing.Point(16, 50)
        Me.lBorrarDestino.Name = "lBorrarDestino"
        Me.lBorrarDestino.Size = New System.Drawing.Size(308, 13)
        Me.lBorrarDestino.TabIndex = 4
        Me.lBorrarDestino.Text = "El lote de destino contiene trazabilidad y no puede ser eliminado"
        Me.lBorrarDestino.Visible = False
        '
        'lBorrarDestinoReflexivo
        '
        Me.lBorrarDestinoReflexivo.AutoSize = True
        Me.lBorrarDestinoReflexivo.Location = New System.Drawing.Point(16, 67)
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
        Me.gbDestino.Location = New System.Drawing.Point(30, 152)
        Me.gbDestino.Name = "gbDestino"
        Me.gbDestino.Size = New System.Drawing.Size(466, 112)
        Me.gbDestino.TabIndex = 6
        Me.gbDestino.TabStop = False
        Me.gbDestino.Text = "Lote destino"
        '
        'lBorrarDestinoTrazabilidad
        '
        Me.lBorrarDestinoTrazabilidad.AutoSize = True
        Me.lBorrarDestinoTrazabilidad.Location = New System.Drawing.Point(16, 82)
        Me.lBorrarDestinoTrazabilidad.Name = "lBorrarDestinoTrazabilidad"
        Me.lBorrarDestinoTrazabilidad.Size = New System.Drawing.Size(169, 13)
        Me.lBorrarDestinoTrazabilidad.TabIndex = 6
        Me.lBorrarDestinoTrazabilidad.Text = "El movimiento no tiene trazabilidad"
        Me.lBorrarDestinoTrazabilidad.Visible = False
        '
        'frmResumenBorradoDeposito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(760, 425)
        Me.Controls.Add(Me.gbDestino)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.gbDeposito)
        Me.Name = "frmResumenBorradoDeposito"
        Me.Text = "frmResumenBorradoDeposito"
        Me.gbDeposito.ResumeLayout(False)
        Me.gbDeposito.PerformLayout()
        Me.gbDestino.ResumeLayout(False)
        Me.gbDestino.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents gbDeposito As System.Windows.Forms.GroupBox
    Private WithEvents cbDeposito As System.Windows.Forms.CheckBox
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents cboDepositoPrevio As System.Windows.Forms.ComboBox
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents cboDeposito As System.Windows.Forms.ComboBox
    Private WithEvents ldepositoDuplicado As System.Windows.Forms.Label
    Private WithEvents btnAceptar As System.Windows.Forms.Button
    Private WithEvents btnCancelar As System.Windows.Forms.Button
    Private WithEvents cbBorrarDestino As System.Windows.Forms.CheckBox
    Friend WithEvents lBorrarDestino As System.Windows.Forms.Label
    Friend WithEvents gbDestino As System.Windows.Forms.GroupBox
    Private WithEvents lBorrarDestinoReflexivo As System.Windows.Forms.Label
    Private WithEvents lBorrarDestinoTrazabilidad As System.Windows.Forms.Label
End Class
