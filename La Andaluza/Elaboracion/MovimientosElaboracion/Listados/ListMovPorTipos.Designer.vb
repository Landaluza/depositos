<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListMovPorTipos
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
        Me.C1PrintPreviewControl1 = New C1.Win.C1Preview.C1PrintPreviewControl()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.cboProcesos = New System.Windows.Forms.ComboBox()
        Me.rdbLitros = New System.Windows.Forms.RadioButton()
        Me.rdbGrados = New System.Windows.Forms.RadioButton()
        Me.chbAlcohol = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnVer = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        CType(Me.C1PrintPreviewControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1PrintPreviewControl1.PreviewPane, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1PrintPreviewControl1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'C1PrintPreviewControl1
        '
        Me.C1PrintPreviewControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1PrintPreviewControl1.Location = New System.Drawing.Point(0, 0)
        Me.C1PrintPreviewControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.C1PrintPreviewControl1.Name = "C1PrintPreviewControl1"
        Me.C1PrintPreviewControl1.NavigationPanelVisible = False
        '
        'C1PrintPreviewControl1.OutlineView
        '
        Me.C1PrintPreviewControl1.PreviewOutlineView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1PrintPreviewControl1.PreviewOutlineView.Location = New System.Drawing.Point(0, 0)
        Me.C1PrintPreviewControl1.PreviewOutlineView.Margin = New System.Windows.Forms.Padding(4)
        Me.C1PrintPreviewControl1.PreviewOutlineView.Name = "OutlineView"
        Me.C1PrintPreviewControl1.PreviewOutlineView.Size = New System.Drawing.Size(165, 424)
        Me.C1PrintPreviewControl1.PreviewOutlineView.TabIndex = 0
        Me.C1PrintPreviewControl1.PreviewOutlineView.Visible = False
        '
        'C1PrintPreviewControl1.PreviewPane
        '
        Me.C1PrintPreviewControl1.PreviewPane.IntegrateExternalTools = True
        Me.C1PrintPreviewControl1.PreviewPane.TabIndex = 0
        Me.C1PrintPreviewControl1.PreviewPane.ZoomMode = C1.Win.C1Preview.ZoomModeEnum.PageWidth
        '
        'C1PrintPreviewControl1.PreviewTextSearchPanel
        '
        Me.C1PrintPreviewControl1.PreviewTextSearchPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.C1PrintPreviewControl1.PreviewTextSearchPanel.Location = New System.Drawing.Point(815, 0)
        Me.C1PrintPreviewControl1.PreviewTextSearchPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.C1PrintPreviewControl1.PreviewTextSearchPanel.MinimumSize = New System.Drawing.Size(267, 295)
        Me.C1PrintPreviewControl1.PreviewTextSearchPanel.Name = "PreviewTextSearchPanel"
        Me.C1PrintPreviewControl1.PreviewTextSearchPanel.Size = New System.Drawing.Size(267, 644)
        Me.C1PrintPreviewControl1.PreviewTextSearchPanel.TabIndex = 0
        Me.C1PrintPreviewControl1.PreviewTextSearchPanel.Visible = False
        '
        'C1PrintPreviewControl1.ThumbnailView
        '
        Me.C1PrintPreviewControl1.PreviewThumbnailView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1PrintPreviewControl1.PreviewThumbnailView.Location = New System.Drawing.Point(0, 0)
        Me.C1PrintPreviewControl1.PreviewThumbnailView.Margin = New System.Windows.Forms.Padding(4)
        Me.C1PrintPreviewControl1.PreviewThumbnailView.Name = "ThumbnailView"
        Me.C1PrintPreviewControl1.PreviewThumbnailView.Size = New System.Drawing.Size(165, 424)
        Me.C1PrintPreviewControl1.PreviewThumbnailView.TabIndex = 0
        Me.C1PrintPreviewControl1.PreviewThumbnailView.UseImageAsThumbnail = False
        Me.C1PrintPreviewControl1.PreviewThumbnailView.Visible = False
        Me.C1PrintPreviewControl1.Size = New System.Drawing.Size(1599, 490)
        Me.C1PrintPreviewControl1.TabIndex = 1
        Me.C1PrintPreviewControl1.Text = "C1PrintPreviewControl1"
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.File.Open.Name = "btnFileOpen"
        Me.C1PrintPreviewControl1.ToolBars.File.Open.Size = New System.Drawing.Size(16, 22)
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.File.PageSetup.Name = "btnPageSetup"
        Me.C1PrintPreviewControl1.ToolBars.File.PageSetup.Size = New System.Drawing.Size(23, 22)
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.File.Print.Name = "btnPrint"
        Me.C1PrintPreviewControl1.ToolBars.File.Print.Size = New System.Drawing.Size(23, 22)
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.File.Reflow.Name = "btnReflow"
        Me.C1PrintPreviewControl1.ToolBars.File.Reflow.Size = New System.Drawing.Size(23, 22)
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.File.Save.Name = "btnFileSave"
        Me.C1PrintPreviewControl1.ToolBars.File.Save.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.File.ToolTipFileOpen = ""
        Me.C1PrintPreviewControl1.ToolBars.File.ToolTipFileSave = ""
        Me.C1PrintPreviewControl1.ToolBars.File.ToolTipPageSetup = ""
        Me.C1PrintPreviewControl1.ToolBars.File.ToolTipPrint = ""
        Me.C1PrintPreviewControl1.ToolBars.File.ToolTipReflow = ""
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoFirst.Name = "btnGoFirst"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoFirst.Size = New System.Drawing.Size(23, 22)
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoLast.Name = "btnGoLast"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoLast.Size = New System.Drawing.Size(23, 22)
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoNext.Name = "btnGoNext"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoNext.Size = New System.Drawing.Size(23, 22)
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoPrev.Name = "btnGoPrev"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.GoPrev.Size = New System.Drawing.Size(23, 22)
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Navigation.HistoryNext.Name = "btnHistoryNext"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.HistoryNext.Size = New System.Drawing.Size(16, 22)
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Navigation.HistoryPrev.Name = "btnHistoryPrev"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.HistoryPrev.Size = New System.Drawing.Size(16, 22)
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Navigation.LblOfPages.Name = "lblOfPages"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.LblOfPages.Size = New System.Drawing.Size(0, 22)
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Navigation.LblPage.Name = "lblPage"
        Me.C1PrintPreviewControl1.ToolBars.Navigation.LblPage.Size = New System.Drawing.Size(0, 22)
        Me.C1PrintPreviewControl1.ToolBars.Navigation.ToolTipGoToFirstPage = ""
        Me.C1PrintPreviewControl1.ToolBars.Navigation.ToolTipGoToLastPage = ""
        Me.C1PrintPreviewControl1.ToolBars.Navigation.ToolTipGoToNextPage = ""
        Me.C1PrintPreviewControl1.ToolBars.Navigation.ToolTipGoToPrevPage = ""
        Me.C1PrintPreviewControl1.ToolBars.Navigation.ToolTipHistoryNext = ""
        Me.C1PrintPreviewControl1.ToolBars.Navigation.ToolTipHistoryPrev = ""
        Me.C1PrintPreviewControl1.ToolBars.Navigation.ToolTipPageNo = Nothing
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Page.Continuous.Name = "btnPageContinuous"
        Me.C1PrintPreviewControl1.ToolBars.Page.Continuous.Size = New System.Drawing.Size(23, 22)
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Page.Facing.Name = "btnPageFacing"
        Me.C1PrintPreviewControl1.ToolBars.Page.Facing.Size = New System.Drawing.Size(23, 22)
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Page.FacingContinuous.Name = "btnPageFacingContinuous"
        Me.C1PrintPreviewControl1.ToolBars.Page.FacingContinuous.Size = New System.Drawing.Size(23, 22)
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Page.Single.Name = "btnPagedouble"
        Me.C1PrintPreviewControl1.ToolBars.Page.Single.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.Page.ToolTipViewContinuous = ""
        Me.C1PrintPreviewControl1.ToolBars.Page.ToolTipViewFacing = ""
        Me.C1PrintPreviewControl1.ToolBars.Page.ToolTipViewFacingContinuous = ""
        Me.C1PrintPreviewControl1.ToolBars.Page.ToolTipViewSinglePage = ""
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Text.Find.Name = "btnFind"
        Me.C1PrintPreviewControl1.ToolBars.Text.Find.Size = New System.Drawing.Size(23, 22)
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Text.Hand.Name = "btnHandTool"
        Me.C1PrintPreviewControl1.ToolBars.Text.Hand.Size = New System.Drawing.Size(23, 22)
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Text.SelectText.Name = "btnSelectTextTool"
        Me.C1PrintPreviewControl1.ToolBars.Text.SelectText.Size = New System.Drawing.Size(23, 22)
        Me.C1PrintPreviewControl1.ToolBars.Text.ToolTipFind = ""
        Me.C1PrintPreviewControl1.ToolBars.Text.ToolTipToolHand = ""
        Me.C1PrintPreviewControl1.ToolBars.Text.ToolTipToolTextSelect = ""
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ToolTipToolZoomIn = Nothing
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ToolTipToolZoomOut = Nothing
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ToolTipZoomFactor = Nothing
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ToolTipZoomIn = ""
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ToolTipZoomOut = ""
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ToolTipZoomTool = ""
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomIn.Name = "btnZoomIn"
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomIn.Size = New System.Drawing.Size(23, 22)
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomInTool.Name = "itemZoomInTool"
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomInTool.Size = New System.Drawing.Size(68, 22)
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomOut.Name = "btnZoomOut"
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomOut.Size = New System.Drawing.Size(23, 22)
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomOutTool.Name = "itemZoomOutTool"
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomOutTool.Size = New System.Drawing.Size(68, 22)
        '
        '
        '
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomTool.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomInTool, Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomOutTool})
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomTool.Name = "btnZoomTool"
        Me.C1PrintPreviewControl1.ToolBars.Zoom.ZoomTool.Size = New System.Drawing.Size(16, 22)
        Me.C1PrintPreviewControl1.Visible = False
        '
        'dtpDesde
        '
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesde.Location = New System.Drawing.Point(873, 20)
        Me.dtpDesde.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(124, 22)
        Me.dtpDesde.TabIndex = 1
        Me.dtpDesde.Value = New Date(2009, 1, 1, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(811, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Desde:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1043, 25)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Hasta:"
        '
        'dtpHasta
        '
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHasta.Location = New System.Drawing.Point(1101, 20)
        Me.dtpHasta.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(124, 22)
        Me.dtpHasta.TabIndex = 2
        '
        'cboProcesos
        '
        Me.cboProcesos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProcesos.FormattingEnabled = True
        Me.cboProcesos.Location = New System.Drawing.Point(105, 18)
        Me.cboProcesos.Margin = New System.Windows.Forms.Padding(4)
        Me.cboProcesos.Name = "cboProcesos"
        Me.cboProcesos.Size = New System.Drawing.Size(289, 24)
        Me.cboProcesos.TabIndex = 0
        '
        'rdbLitros
        '
        Me.rdbLitros.AutoSize = True
        Me.rdbLitros.Checked = True
        Me.rdbLitros.Location = New System.Drawing.Point(423, 7)
        Me.rdbLitros.Margin = New System.Windows.Forms.Padding(4)
        Me.rdbLitros.Name = "rdbLitros"
        Me.rdbLitros.Size = New System.Drawing.Size(80, 21)
        Me.rdbLitros.TabIndex = 6
        Me.rdbLitros.TabStop = True
        Me.rdbLitros.Text = "En litros"
        Me.rdbLitros.UseVisualStyleBackColor = True
        '
        'rdbGrados
        '
        Me.rdbGrados.AutoSize = True
        Me.rdbGrados.Location = New System.Drawing.Point(423, 36)
        Me.rdbGrados.Margin = New System.Windows.Forms.Padding(4)
        Me.rdbGrados.Name = "rdbGrados"
        Me.rdbGrados.Size = New System.Drawing.Size(94, 21)
        Me.rdbGrados.TabIndex = 7
        Me.rdbGrados.TabStop = True
        Me.rdbGrados.Text = "En grados"
        Me.rdbGrados.UseVisualStyleBackColor = True
        '
        'chbAlcohol
        '
        Me.chbAlcohol.AutoSize = True
        Me.chbAlcohol.Location = New System.Drawing.Point(528, 37)
        Me.chbAlcohol.Margin = New System.Windows.Forms.Padding(4)
        Me.chbAlcohol.Name = "chbAlcohol"
        Me.chbAlcohol.Size = New System.Drawing.Size(116, 21)
        Me.chbAlcohol.TabIndex = 8
        Me.chbAlcohol.Text = "Incluir alcohol"
        Me.chbAlcohol.UseVisualStyleBackColor = True
        Me.chbAlcohol.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 25)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Proceso:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1599, 425)
        Me.DataGridView1.TabIndex = 10
        '
        'btnVer
        '
        Me.btnVer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVer.FlatAppearance.BorderSize = 0
        Me.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVer.Image = Global.La_Andaluza_MovimientosDepositosPruebas.My.Resources.Resources.glyphicons_027_search
        Me.btnVer.Location = New System.Drawing.Point(1233, 19)
        Me.btnVer.Margin = New System.Windows.Forms.Padding(4)
        Me.btnVer.Name = "btnVer"
        Me.btnVer.Size = New System.Drawing.Size(73, 23)
        Me.btnVer.TabIndex = 11
        Me.btnVer.Text = "Ver"
        Me.btnVer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnVer.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rdbGrados)
        Me.Panel1.Controls.Add(Me.btnVer)
        Me.Panel1.Controls.Add(Me.dtpDesde)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.dtpHasta)
        Me.Panel1.Controls.Add(Me.chbAlcohol)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cboProcesos)
        Me.Panel1.Controls.Add(Me.rdbLitros)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1599, 69)
        Me.Panel1.TabIndex = 12
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 69)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.DataGridView1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.C1PrintPreviewControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1599, 945)
        Me.SplitContainer1.SplitterDistance = 425
        Me.SplitContainer1.SplitterWidth = 30
        Me.SplitContainer1.TabIndex = 13
        '
        'BackgroundWorker1
        '
        '
        'ListMovPorTipos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1599, 1014)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(1397, 1007)
        Me.Name = "ListMovPorTipos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Movimientos por tipo entre fechas"
        CType(Me.C1PrintPreviewControl1.PreviewPane, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1PrintPreviewControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1PrintPreviewControl1.ResumeLayout(False)
        Me.C1PrintPreviewControl1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents C1PrintPreviewControl1 As C1.Win.C1Preview.C1PrintPreviewControl
    Private WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
    Private WithEvents cboProcesos As System.Windows.Forms.ComboBox
    Private WithEvents rdbLitros As System.Windows.Forms.RadioButton
    Private WithEvents rdbGrados As System.Windows.Forms.RadioButton
    Private WithEvents chbAlcohol As System.Windows.Forms.CheckBox
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Private WithEvents btnVer As System.Windows.Forms.Button
    Private WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Private WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
