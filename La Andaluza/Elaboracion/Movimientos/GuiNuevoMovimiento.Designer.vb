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
        Me.btnCompra = New System.Windows.Forms.Button()
        Me.btnVenta = New System.Windows.Forms.Button()
        Me.btnFiltrado = New System.Windows.Forms.Button()
        Me.btnNiveles = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnEnvasar = New System.Windows.Forms.Button()
        Me.btnAjustesComerciales = New System.Windows.Forms.Button()
        Me.btnAjustesAgua = New System.Windows.Forms.Button()
        Me.btnClarificacion = New System.Windows.Forms.Button()
        Me.btnCoccionControlada = New System.Windows.Forms.Button()
        Me.btnDesecho = New System.Windows.Forms.Button()
        Me.btnDesemboteNC = New System.Windows.Forms.Button()
        Me.btnDiferencia = New System.Windows.Forms.Button()
        Me.btnFermentados = New System.Windows.Forms.Button()
        Me.btnFiltrados = New System.Windows.Forms.Button()
        Me.btnLavado = New System.Windows.Forms.Button()
        Me.btnMigracion = New System.Windows.Forms.Button()
        Me.btnPieCuba = New System.Windows.Forms.Button()
        Me.btnDEsembote = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnTrasiego
        '
        Me.btnTrasiego.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTrasiego.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTrasiego.Image = Global.La_Andaluza_MovimientosDepositosPruebas.My.Resources.Resources.trasiego
        Me.btnTrasiego.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnTrasiego.Location = New System.Drawing.Point(3, 3)
        Me.btnTrasiego.Name = "btnTrasiego"
        Me.btnTrasiego.Size = New System.Drawing.Size(306, 150)
        Me.btnTrasiego.TabIndex = 0
        Me.btnTrasiego.Tag = "1"
        Me.btnTrasiego.Text = "Trasiego"
        Me.btnTrasiego.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnTrasiego.UseVisualStyleBackColor = True
        '
        'btnCompra
        '
        Me.btnCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompra.Image = Global.La_Andaluza_MovimientosDepositosPruebas.My.Resources.Resources.compra
        Me.btnCompra.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCompra.Location = New System.Drawing.Point(315, 3)
        Me.btnCompra.Name = "btnCompra"
        Me.btnCompra.Size = New System.Drawing.Size(150, 150)
        Me.btnCompra.TabIndex = 1
        Me.btnCompra.Tag = "2"
        Me.btnCompra.Text = "Compras"
        Me.btnCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnCompra.UseVisualStyleBackColor = True
        '
        'btnVenta
        '
        Me.btnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVenta.Image = Global.La_Andaluza_MovimientosDepositosPruebas.My.Resources.Resources.venta
        Me.btnVenta.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnVenta.Location = New System.Drawing.Point(471, 3)
        Me.btnVenta.Name = "btnVenta"
        Me.btnVenta.Size = New System.Drawing.Size(150, 150)
        Me.btnVenta.TabIndex = 2
        Me.btnVenta.Tag = "3"
        Me.btnVenta.Text = "Ventas"
        Me.btnVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnVenta.UseVisualStyleBackColor = True
        '
        'btnFiltrado
        '
        Me.btnFiltrado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFiltrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFiltrado.Image = Global.La_Andaluza_MovimientosDepositosPruebas.My.Resources.Resources.filtrado
        Me.btnFiltrado.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnFiltrado.Location = New System.Drawing.Point(939, 3)
        Me.btnFiltrado.Name = "btnFiltrado"
        Me.btnFiltrado.Size = New System.Drawing.Size(150, 150)
        Me.btnFiltrado.TabIndex = 3
        Me.btnFiltrado.Tag = "5"
        Me.btnFiltrado.Text = "Filtrados"
        Me.btnFiltrado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnFiltrado.UseVisualStyleBackColor = True
        '
        'btnNiveles
        '
        Me.btnNiveles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNiveles.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNiveles.Image = Global.La_Andaluza_MovimientosDepositosPruebas.My.Resources.Resources.glyphicons_040_stats
        Me.btnNiveles.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNiveles.Location = New System.Drawing.Point(3, 159)
        Me.btnNiveles.Name = "btnNiveles"
        Me.btnNiveles.Size = New System.Drawing.Size(150, 150)
        Me.btnNiveles.TabIndex = 4
        Me.btnNiveles.Tag = "6"
        Me.btnNiveles.Text = "Niveles"
        Me.btnNiveles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnNiveles.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.Controls.Add(Me.btnTrasiego)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnCompra)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnVenta)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnEnvasar)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnFiltrado)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnNiveles)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnAjustesComerciales)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnAjustesAgua)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnClarificacion)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnCoccionControlada)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnDesecho)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnDiferencia)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnFermentados)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnFiltrados)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnLavado)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnMigracion)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnPieCuba)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnDesemboteNC)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnDEsembote)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1147, 516)
        Me.FlowLayoutPanel1.TabIndex = 5
        '
        'btnEnvasar
        '
        Me.btnEnvasar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnvasar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnvasar.Image = Global.La_Andaluza_MovimientosDepositosPruebas.My.Resources.Resources.envasado
        Me.btnEnvasar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEnvasar.Location = New System.Drawing.Point(627, 3)
        Me.btnEnvasar.Name = "btnEnvasar"
        Me.btnEnvasar.Size = New System.Drawing.Size(306, 150)
        Me.btnEnvasar.TabIndex = 15
        Me.btnEnvasar.Tag = "4"
        Me.btnEnvasar.Text = "Envasar"
        Me.btnEnvasar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnEnvasar.UseVisualStyleBackColor = True
        '
        'btnAjustesComerciales
        '
        Me.btnAjustesComerciales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAjustesComerciales.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAjustesComerciales.Image = Global.La_Andaluza_MovimientosDepositosPruebas.My.Resources.Resources.ajustecomercial
        Me.btnAjustesComerciales.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAjustesComerciales.Location = New System.Drawing.Point(159, 159)
        Me.btnAjustesComerciales.Name = "btnAjustesComerciales"
        Me.btnAjustesComerciales.Size = New System.Drawing.Size(150, 150)
        Me.btnAjustesComerciales.TabIndex = 5
        Me.btnAjustesComerciales.Tag = "7"
        Me.btnAjustesComerciales.Text = "Ajustes comerciales"
        Me.btnAjustesComerciales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnAjustesComerciales.UseVisualStyleBackColor = True
        '
        'btnAjustesAgua
        '
        Me.btnAjustesAgua.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAjustesAgua.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAjustesAgua.Image = Global.La_Andaluza_MovimientosDepositosPruebas.My.Resources.Resources.ajusteagua
        Me.btnAjustesAgua.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAjustesAgua.Location = New System.Drawing.Point(315, 159)
        Me.btnAjustesAgua.Name = "btnAjustesAgua"
        Me.btnAjustesAgua.Size = New System.Drawing.Size(150, 150)
        Me.btnAjustesAgua.TabIndex = 6
        Me.btnAjustesAgua.Tag = "8"
        Me.btnAjustesAgua.Text = "Ajustes agua"
        Me.btnAjustesAgua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnAjustesAgua.UseVisualStyleBackColor = True
        '
        'btnClarificacion
        '
        Me.btnClarificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClarificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClarificacion.Image = Global.La_Andaluza_MovimientosDepositosPruebas.My.Resources.Resources.clarificacion
        Me.btnClarificacion.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnClarificacion.Location = New System.Drawing.Point(471, 159)
        Me.btnClarificacion.Name = "btnClarificacion"
        Me.btnClarificacion.Size = New System.Drawing.Size(150, 150)
        Me.btnClarificacion.TabIndex = 7
        Me.btnClarificacion.Tag = "9"
        Me.btnClarificacion.Text = "Clarificacion"
        Me.btnClarificacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnClarificacion.UseVisualStyleBackColor = True
        '
        'btnCoccionControlada
        '
        Me.btnCoccionControlada.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCoccionControlada.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCoccionControlada.Image = Global.La_Andaluza_MovimientosDepositosPruebas.My.Resources.Resources.coccion
        Me.btnCoccionControlada.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCoccionControlada.Location = New System.Drawing.Point(627, 159)
        Me.btnCoccionControlada.Name = "btnCoccionControlada"
        Me.btnCoccionControlada.Size = New System.Drawing.Size(150, 150)
        Me.btnCoccionControlada.TabIndex = 8
        Me.btnCoccionControlada.Tag = "10"
        Me.btnCoccionControlada.Text = "Coccion controlada"
        Me.btnCoccionControlada.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnCoccionControlada.UseVisualStyleBackColor = True
        '
        'btnDesecho
        '
        Me.btnDesecho.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDesecho.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDesecho.Image = Global.La_Andaluza_MovimientosDepositosPruebas.My.Resources.Resources.desecho
        Me.btnDesecho.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDesecho.Location = New System.Drawing.Point(783, 159)
        Me.btnDesecho.Name = "btnDesecho"
        Me.btnDesecho.Size = New System.Drawing.Size(150, 150)
        Me.btnDesecho.TabIndex = 11
        Me.btnDesecho.Tag = "11"
        Me.btnDesecho.Text = "Desecho"
        Me.btnDesecho.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnDesecho.UseVisualStyleBackColor = True
        '
        'btnDesemboteNC
        '
        Me.btnDesemboteNC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDesemboteNC.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDesemboteNC.Image = Global.La_Andaluza_MovimientosDepositosPruebas.My.Resources.Resources.desembotenc
        Me.btnDesemboteNC.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDesemboteNC.Location = New System.Drawing.Point(783, 315)
        Me.btnDesemboteNC.Name = "btnDesemboteNC"
        Me.btnDesemboteNC.Size = New System.Drawing.Size(150, 150)
        Me.btnDesemboteNC.TabIndex = 12
        Me.btnDesemboteNC.Tag = "18"
        Me.btnDesemboteNC.Text = "Desembote NC"
        Me.btnDesemboteNC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnDesemboteNC.UseVisualStyleBackColor = True
        '
        'btnDiferencia
        '
        Me.btnDiferencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDiferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDiferencia.Image = Global.La_Andaluza_MovimientosDepositosPruebas.My.Resources.Resources.diferencia
        Me.btnDiferencia.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDiferencia.Location = New System.Drawing.Point(939, 159)
        Me.btnDiferencia.Name = "btnDiferencia"
        Me.btnDiferencia.Size = New System.Drawing.Size(150, 150)
        Me.btnDiferencia.TabIndex = 13
        Me.btnDiferencia.Tag = "12"
        Me.btnDiferencia.Text = "Diferencia"
        Me.btnDiferencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnDiferencia.UseVisualStyleBackColor = True
        '
        'btnFermentados
        '
        Me.btnFermentados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFermentados.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFermentados.Image = Global.La_Andaluza_MovimientosDepositosPruebas.My.Resources.Resources.fermentacion
        Me.btnFermentados.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnFermentados.Location = New System.Drawing.Point(3, 315)
        Me.btnFermentados.Name = "btnFermentados"
        Me.btnFermentados.Size = New System.Drawing.Size(150, 150)
        Me.btnFermentados.TabIndex = 16
        Me.btnFermentados.Tag = "13"
        Me.btnFermentados.Text = "Fermentados"
        Me.btnFermentados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnFermentados.UseVisualStyleBackColor = True
        '
        'btnFiltrados
        '
        Me.btnFiltrados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFiltrados.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFiltrados.Image = Global.La_Andaluza_MovimientosDepositosPruebas.My.Resources.Resources.filtrado
        Me.btnFiltrados.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnFiltrados.Location = New System.Drawing.Point(159, 315)
        Me.btnFiltrados.Name = "btnFiltrados"
        Me.btnFiltrados.Size = New System.Drawing.Size(150, 150)
        Me.btnFiltrados.TabIndex = 17
        Me.btnFiltrados.Tag = "14"
        Me.btnFiltrados.Text = "Filtrados"
        Me.btnFiltrados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnFiltrados.UseVisualStyleBackColor = True
        '
        'btnLavado
        '
        Me.btnLavado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLavado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLavado.Image = Global.La_Andaluza_MovimientosDepositosPruebas.My.Resources.Resources.lavado
        Me.btnLavado.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLavado.Location = New System.Drawing.Point(315, 315)
        Me.btnLavado.Name = "btnLavado"
        Me.btnLavado.Size = New System.Drawing.Size(150, 150)
        Me.btnLavado.TabIndex = 18
        Me.btnLavado.Tag = "15"
        Me.btnLavado.Text = "Lavados"
        Me.btnLavado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnLavado.UseVisualStyleBackColor = True
        '
        'btnMigracion
        '
        Me.btnMigracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMigracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMigracion.Image = Global.La_Andaluza_MovimientosDepositosPruebas.My.Resources.Resources.maceracion
        Me.btnMigracion.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnMigracion.Location = New System.Drawing.Point(471, 315)
        Me.btnMigracion.Name = "btnMigracion"
        Me.btnMigracion.Size = New System.Drawing.Size(150, 150)
        Me.btnMigracion.TabIndex = 19
        Me.btnMigracion.Tag = "16"
        Me.btnMigracion.Text = "Maceracion"
        Me.btnMigracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnMigracion.UseVisualStyleBackColor = True
        '
        'btnPieCuba
        '
        Me.btnPieCuba.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPieCuba.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPieCuba.Image = Global.La_Andaluza_MovimientosDepositosPruebas.My.Resources.Resources.piebota
        Me.btnPieCuba.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPieCuba.Location = New System.Drawing.Point(627, 315)
        Me.btnPieCuba.Name = "btnPieCuba"
        Me.btnPieCuba.Size = New System.Drawing.Size(150, 150)
        Me.btnPieCuba.TabIndex = 21
        Me.btnPieCuba.Tag = "17"
        Me.btnPieCuba.Text = "Pies de cuba"
        Me.btnPieCuba.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnPieCuba.UseVisualStyleBackColor = True
        '
        'btnDEsembote
        '
        Me.btnDEsembote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDEsembote.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDEsembote.Image = Global.La_Andaluza_MovimientosDepositosPruebas.My.Resources.Resources.desembote
        Me.btnDEsembote.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDEsembote.Location = New System.Drawing.Point(939, 315)
        Me.btnDEsembote.Name = "btnDEsembote"
        Me.btnDEsembote.Size = New System.Drawing.Size(150, 150)
        Me.btnDEsembote.TabIndex = 22
        Me.btnDEsembote.Tag = "19"
        Me.btnDEsembote.Text = "Desembote NC"
        Me.btnDEsembote.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnDEsembote.UseVisualStyleBackColor = True
        '
        'GuiNuevoMovimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1147, 516)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Name = "GuiNuevoMovimiento"
        Me.Text = "NuevoMovimiento"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents btnTrasiego As System.Windows.Forms.Button
    Private WithEvents btnCompra As System.Windows.Forms.Button
    Private WithEvents btnVenta As System.Windows.Forms.Button
    Private WithEvents btnFiltrado As System.Windows.Forms.Button
    Private WithEvents btnNiveles As System.Windows.Forms.Button
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Private WithEvents btnEnvasar As System.Windows.Forms.Button
    Private WithEvents btnAjustesComerciales As System.Windows.Forms.Button
    Private WithEvents btnAjustesAgua As System.Windows.Forms.Button
    Private WithEvents btnClarificacion As System.Windows.Forms.Button
    Private WithEvents btnCoccionControlada As System.Windows.Forms.Button
    Private WithEvents btnDesecho As System.Windows.Forms.Button
    Private WithEvents btnDesemboteNC As System.Windows.Forms.Button
    Private WithEvents btnDiferencia As System.Windows.Forms.Button
    Private WithEvents btnFermentados As System.Windows.Forms.Button
    Private WithEvents btnFiltrados As System.Windows.Forms.Button
    Private WithEvents btnLavado As System.Windows.Forms.Button
    Private WithEvents btnMigracion As System.Windows.Forms.Button
    Private WithEvents btnPieCuba As System.Windows.Forms.Button
    Private WithEvents btnDEsembote As System.Windows.Forms.Button
End Class
