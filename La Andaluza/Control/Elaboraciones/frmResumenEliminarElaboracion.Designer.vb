﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResumenEliminarElaboracion
    Inherits System.Windows.Forms.Form

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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.chbTerminado = New System.Windows.Forms.CheckBox()
        Me.lOperaciones = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.butCancelar = New System.Windows.Forms.Button()
        Me.butConfirmar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'chbTerminado
        '
        Me.chbTerminado.AutoSize = True
        Me.chbTerminado.Dock = System.Windows.Forms.DockStyle.Top
        Me.chbTerminado.Location = New System.Drawing.Point(0, 0)
        Me.chbTerminado.Name = "chbTerminado"
        Me.chbTerminado.Size = New System.Drawing.Size(753, 21)
        Me.chbTerminado.TabIndex = 0
        Me.chbTerminado.Text = "intentar eliminar el lote terminado"
        Me.chbTerminado.UseVisualStyleBackColor = True
        '
        'lOperaciones
        '
        Me.lOperaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lOperaciones.Location = New System.Drawing.Point(0, 21)
        Me.lOperaciones.Name = "lOperaciones"
        Me.lOperaciones.Size = New System.Drawing.Size(753, 321)
        Me.lOperaciones.TabIndex = 1
        Me.lOperaciones.Text = "operaciones"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.butCancelar)
        Me.Panel1.Controls.Add(Me.butConfirmar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 342)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(753, 69)
        Me.Panel1.TabIndex = 2
        '
        'butCancelar
        '
        Me.butCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.butCancelar.Image = Global.La_Andaluza_MovimientosDepositosPruebas.My.Resources.Resources.dialog_cancel_3
        Me.butCancelar.Location = New System.Drawing.Point(12, 8)
        Me.butCancelar.Name = "butCancelar"
        Me.butCancelar.Size = New System.Drawing.Size(130, 55)
        Me.butCancelar.TabIndex = 1
        Me.butCancelar.Text = "Cancelar"
        Me.butCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.butCancelar.UseVisualStyleBackColor = True
        '
        'butConfirmar
        '
        Me.butConfirmar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.butConfirmar.Image = Global.La_Andaluza_MovimientosDepositosPruebas.My.Resources.Resources.dialog_ok_3
        Me.butConfirmar.Location = New System.Drawing.Point(612, 8)
        Me.butConfirmar.Name = "butConfirmar"
        Me.butConfirmar.Size = New System.Drawing.Size(130, 55)
        Me.butConfirmar.TabIndex = 0
        Me.butConfirmar.Text = "Confirmar"
        Me.butConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.butConfirmar.UseVisualStyleBackColor = True
        '
        'frmResumenEliminarElaboracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 411)
        Me.Controls.Add(Me.lOperaciones)
        Me.Controls.Add(Me.chbTerminado)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmResumenEliminarElaboracion"
        Me.Text = "frmResumenEliminarElaboracion"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents chbTerminado As System.Windows.Forms.CheckBox
    Private WithEvents lOperaciones As System.Windows.Forms.Label
    Private WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents butCancelar As System.Windows.Forms.Button
    Private WithEvents butConfirmar As System.Windows.Forms.Button
End Class
