
Public Class GUImain

    Protected Shared LAengine As Engine_LA
    Protected frmIni As FrmInicio
    Protected frmNews As frmNews
    Protected Event extras_showed()
    Protected frmProcesos As frmProcesosAbiertos

    'Public Sub New()
    '    MyBase.new()
    '    ' This call is required by the designer.
    '    InitializeComponent()

    '    ' Add any initialization after the InitializeComponent() call.
    '    LAengine = New Engine_LA(Me)        
    '    Me.Icon = My.Resources.LogoBandejaLa21
    '    Me.NotifyIcon1 = New NotifyIcon
    '    Me.NotifyIcon1.Icon = My.Resources.LogoBandejaLa21
    '    Me.NotifyIcon1.Visible = True
    '    Me.NotifyIcon1.ContextMenuStrip = Me.cmsNotificaciones
    'End Sub

    Public Sub New()

        InitializeComponent()

        ' Environment.Exit(69)
    End Sub
    Public Sub New(ByRef frm As FrmInicio)
        InitializeComponent()
        'segundaSesion = False
        LAengine = New Engine_LA(Me)
        'Me.frmNews = New frmNews
        'añadirPestañaSinCierre(frmNews)

        Me.frmIni = frm
        GUImain.LAengine.Target_Cerrar_Pestana = CreateGraphics.MeasureString(TabManager.CIERRE_PESTAÑA, TabControl1.Font)


        Me.SuspendLayout()

        Me.frmNews = New frmNews
        añadirPestañaSinCierre(CType(frmNews, Form))
        cargarAgenda()
        Me.ResumeLayout()

        MovimientosToolStripMenuItem_Click(Me, Nothing)
        ElaboracionesToolStripMenuItem_Click(Me, Nothing)

        Dim scr As New Pantalla
        If Not scr.isMultiScreen Then
            Me.Monitor2ToolStripMenuItem.Enabled = False
        End If

        Me.NotifyIcon1.Icon = My.Resources.folder_development
    End Sub

    Public Sub CambiarSesion()
        Dim frm As New frmEspera("Cerrando sesión")
        frm.Show()
        stopGUI()
        FrmInicio.Show()
        frm.Close()
        Me.Hide()
    End Sub

    Public Overridable Sub terminarDeIniciar(ByVal tablausada As String, ByVal ServidorUsado As String, ByVal UsuarioUsado As String, ByVal usua As String)
        Me.ToolTip1.SetToolTip(Me.lServ, "Usuario: " & UsuarioUsado & Environment.NewLine & "Base de datos: " & tablausada & Environment.NewLine & "Servidor: " & ServidorUsado)
        Me.ToolTip1.SetToolTip(Me.lUser, "Usuario conectado: " & usua & Environment.NewLine & "click para acceder a la configuración de usuario")
        ProcesosAbiertosToolStripMenuItem_Click(Nothing, Nothing)
        Me.Show()
    End Sub

    Public Sub cerrarPestaña()
        Try
            'Me.TabControl1.SelectedTab.Controls.Clear()
            Me.TabControl1.TabPages.Remove(Me.TabControl1.SelectedTab)
            LAengine.volverApestañaPrevia()
        Catch ex As Exception
        End Try
    End Sub

    Protected Sub TabControl1_MouseUp(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles TabControl1.MouseUp
        If Not TabControl1.SelectedTab.Tag Is Nothing Then
            If CType(TabControl1.SelectedTab.Tag, Byte) <> TabManager.PESTAÑA_SIN_CIERRE Then
                'If .SelectedTab.Text.EndsWith("   x") Then
                Dim ItemRect As Rectangle = TabControl1.GetTabRect(TabControl1.SelectedIndex)
                If ItemRect.Contains(e.Location) Then
                    If e.Location.X > (ItemRect.Right - GUImain.LAengine.Target_Cerrar_Pestana.Width) Then
                        ' Code you want to happen when the x is selected.
                        TabControl1.TabPages.Remove(TabControl1.SelectedTab)
                        ' cerrarPestaña()
                        LAengine.volverApestañaPrevia()
                    End If
                End If
                'End If
            End If
        End If
    End Sub

    Protected Sub TabControl1_MouseMove(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles TabControl1.MouseMove

        If e.Button <> Windows.Forms.MouseButtons.Left Then
            Try
                If Not TabControl1.SelectedTab.Tag Is Nothing Then
                    If CType(TabControl1.SelectedTab.Tag, Byte) <> TabManager.PESTAÑA_SIN_CIERRE Then
                        'If .SelectedTab.Text.EndsWith("   x") Then
                        Dim ItemRect As Rectangle = TabControl1.GetTabRect(TabControl1.SelectedIndex)
                        If ItemRect.Contains(e.Location) Then
                            If e.Location.X > (ItemRect.Right - GUImain.LAengine.Target_Cerrar_Pestana.Width) Then
                                Dim df As Graphics = Me.TabControl1.CreateGraphics
                                df.DrawRectangle(Pens.LightSteelBlue, New Rectangle(ItemRect.Right - 15, 5, 11, 11))
                                df.Dispose()
                            End If
                        End If
                        ' End If
                    End If
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub

    Public Sub ToolStripLabel1_ClicknoFocus(sender As System.Object, e As System.EventArgs)
        If Me.SplitContainer1.Panel1Collapsed Then
            Me.SplitContainer1.Panel1Collapsed = False
        Else
            Me.SplitContainer1.Panel1Collapsed = True
        End If
    End Sub

    Public Sub ToolStripLabel1_Clickfocused(sender As System.Object, e As System.EventArgs)
        If Me.SplitContainer1.Panel1Collapsed Then
            Me.SplitContainer1.Panel1Collapsed = False
            Me.SplitContainer1.Panel1.Focus()
        Else
            Me.SplitContainer1.Panel1Collapsed = True
        End If
    End Sub

    Protected Function findToolStripItem(ByVal text As String, tool As ToolStrip) As ToolStripItem
        For Each t As ToolStripItem In tool.Items
            If t.Text = text Then
                Return t
            End If
        Next
        Return Nothing
    End Function

    Protected Sub ToolStrip2_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles tsCustomMenu.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub

    Protected Sub TabControl1_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles TabControl1.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub

    Protected Sub TabControl1_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles TabControl1.DragDrop

        If sender Is TabControl1 Then

            Try
                Dim ts As ToolStripItem = CType(e.Data.GetData("System.Windows.Forms.ToolStripItem"), ToolStripItem)
                Dim t As ToolStripItem = findToolStripItem(ts.Text, tsCustomMenu)
                tsCustomMenu.Items.Remove(t)
            Catch ex As Exception

            End Try
        End If
    End Sub

    Protected Sub FrmPrincipal_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.stopGUI()
    End Sub

    Public Overridable Sub stopGUI()
        Try
            Me.TabControl1.TabPages.Clear()
            Me.TabControl2.TabPages.Clear()
        Catch ex As Exception
        End Try
    End Sub

    Protected Sub FrmPrincipal_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        cerrarPestaña()
        Environment.Exit(0)
    End Sub


    Protected Sub TabControl2_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles TabControl2.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub

    Protected Sub TabControl2_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles TabControl2.DragDrop

        Try
            Dim ts As TabPage = CType(e.Data.GetData("System.Windows.Forms.TabPage"), TabPage)
            Me.TabControl2.TabPages.Add(ts)

            Me.TabControl1.Invalidate()
            Me.TabControl2.Invalidate()
        Catch ex As Exception

        End Try

    End Sub

    Protected Sub TabControl2_MouseUp(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles TabControl2.MouseUp
        If sender Is TabControl2 Then
            With TabControl2
                'If .SelectedTab.Text.EndsWith("   x") Then
                Dim ItemRect As Rectangle = .GetTabRect(.SelectedIndex)
                If ItemRect.Contains(e.Location) Then
                    If e.Location.X > (ItemRect.Right - GUImain.LAengine.Target_Cerrar_Pestana.Width) Then
                        ' Code you want to happen when the x is selected.
                        .TabPages.Remove(.SelectedTab)
                        ' cerrarPestaña()
                        LAengine.volverApestañaPrevia(True)

                        If Me.TabControl2.TabPages.Count = 0 Then
                            Me.scExtra.Panel2Collapsed = True
                        End If
                    End If
                End If
                'End If
            End With
        Else
        End If
    End Sub

    Protected Sub TabControl2_MouseMove(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles TabControl2.MouseMove

        Try
            With TabControl2
                Dim ItemRect As Rectangle = .GetTabRect(.SelectedIndex)
                If ItemRect.Contains(e.Location) Then
                    If e.Location.X > (ItemRect.Right - GUImain.LAengine.Target_Cerrar_Pestana.Width) Then
                        Dim df As Graphics = Me.TabControl2.CreateGraphics
                        df.DrawRectangle(Pens.LightSteelBlue, New Rectangle(ItemRect.Right - 15, 5, 11, 11))
                        df.Dispose()
                    End If
                End If
            End With

        Catch ex As Exception
        End Try
    End Sub


    Protected Sub salir()
        Application.Exit()
    End Sub

   

    Protected Sub tsPetañalateral_Click(sender As System.Object, e As System.EventArgs) Handles tsPetañalateral.Click
        If Me.scExtra.Panel2Collapsed Then
            Me.scExtra.Panel2Collapsed = False

            If Me.TabControl2.TabPages.Count = 0 Then
                Dim pan As New Panel
                pan.Dock = DockStyle.Fill
                pan.BackColor = Color.LightSteelBlue

                Dim tb As New TabPage
                tb.Text = "Arrastra aquí  x"
                tb.Name = "Arrastra aquí  x"

                TabControl2.TabPages.Add(tb)
                pan.Parent = tb

                Dim l As New Label
                l.Text = "Para una vista dual"
                l.Dock = DockStyle.Top

                Dim l2 As New Label
                l2.Text = "Arrastra aquí"
                l2.Dock = DockStyle.Top

                pan.Controls.Add(l)
                pan.Controls.Add(l2)
            End If
        Else
            Me.scExtra.Panel2Collapsed = True
        End If
    End Sub

    Protected Sub lAyuda_Click(sender As System.Object, e As System.EventArgs) Handles lAyuda.Click
        Dim url As String = Config.HelpUrl & "?cat=" & Me.TabControl1.SelectedTab.Text.Replace(TabManager.CIERRE_PESTAÑA, "").Replace(" ", "_")
        LAengine.ayuda(url)

    End Sub

    Shared Sub OpenHelp(ByVal categoria As String)
        Dim url As String = Config.HelpUrl & "?cat=" & categoria
        LAengine.ayuda(url)
    End Sub

    Shared Sub añadirPestañaSinCierre(ByRef frmEnt As Form)
        LAengine.añadirPestañasinCierre(frmEnt)
    End Sub

    Shared Sub añadirPestaña(ByRef frmEnt As Form)
        LAengine.añadirPestañaAutonoma(frmEnt)
    End Sub

    Shared Sub añadirPestañaCentrada(ByRef frmEnt As Form)
        LAengine.añadirPestañaAutonomaCentrada(frmEnt)
    End Sub

    Shared Sub añadirPestaña_standar(ByRef frmEnt As Form)
        LAengine.AñadirPestaña(frmEnt)
    End Sub

    Private Sub LAgenda_Click(sender As System.Object, e As System.EventArgs) Handles LAgenda.Click
        mAgenda.Show(LAgenda, LAgenda.Location)
    End Sub

    Protected Sub cargarAgenda()
        Dim dtb As New DataBase(Config.Server)
        Dim dt As DataTable = dtb.Consultar("exec ComunicacionesSelectDgv", True)
        If Not dt Is Nothing Then
            Me.mAgenda.Items.Clear()
            Dim sms2 As ToolStripMenuItem

            For Each row As DataRow In dt.Rows
                sms2 = New ToolStripMenuItem
                sms2.Text = Convert.ToString(row.Item(1)) & "  " & _
                        If(Convert.IsDBNull(row.Item(4)), "-", Convert.ToString(row.Item(4))) & " " & _
                        If(Convert.IsDBNull(row.Item(3)), "-", Convert.ToString(row.Item(3))) & " " & _
                        If(Convert.IsDBNull(row.Item(2)), "-", Convert.ToString(row.Item(2)))

                Me.mAgenda.Items.Add(sms2)
            Next
        End If
    End Sub

    Private Sub MovimientosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MovimientosToolStripMenuItem.Click
        Dim frmMovimientosMain As frmMovimientosMain = New frmMovimientosMain
        GUImain.añadirPestaña(CType(frmMovimientosMain, Form))
    End Sub

    Private Sub ElaboracionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ElaboracionesToolStripMenuItem.Click
        Dim frmElaboraciones As New frmElaboraciones
        GUImain.añadirPestaña(CType(frmElaboraciones, Form))
    End Sub

    Private Sub FiltrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FiltrosToolStripMenuItem.Click
        Dim frm As New frmFiltros
        GUImain.añadirPestaña(CType(frm, Form))
    End Sub

    Private Sub ProcesosAbiertosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProcesosAbiertosToolStripMenuItem.Click
        If Not frmProcesos Is Nothing Then
            frmProcesos.Close()
        End If

        Me.frmProcesos = New frmProcesosAbiertos
        frmProcesos.Show()
        Dim screen As New Pantalla
        If screen.isMultiScreen Then
            frmProcesos.WindowState = FormWindowState.Normal
            screen.reubicar_formulario_en_pantalla_primaria(CType(frmProcesos, Form))
            frmProcesos.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub NuevoMovimientoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoMovimientoToolStripMenuItem.Click
        Dim frm As New GuiNuevoMovimiento
        LAengine.AñadirPestaña(CType(frm, Form))
    End Sub

    Private Sub Monitor1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Monitor1ToolStripMenuItem.Click
        Config.activeScreen = 0
    End Sub

    Private Sub Monitor2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Monitor2ToolStripMenuItem.Click
        Config.activeScreen = 1
    End Sub
End Class

