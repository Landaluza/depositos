Public Class GUIstandar
    Inherits GUImain

    Public Sub New(ByRef frm As FrmInicio)
        MyBase.new(frm)
        ' This call is required by the designer.
        InitializeComponent()
        Me.Text = Config.Version_seriada
    End Sub

    'Public Overrides Sub terminarDeIniciar(ByVal tablausada As String, ByVal ServidorUsado As String, ByVal UsuarioUsado As String, ByVal usua As String)
    '    MyBase.terminarDeIniciar(tablausada, ServidorUsado, UsuarioUsado, usua)


    '            AddHandler tsNavegacion.MouseEnter, AddressOf ToolStripLabel1_ClicknoFocus
    '            AddHandler Me.SplitContainer1.Panel1.MouseLeave, AddressOf ToolStripLabel1_ClicknoFocus        

    '    Me.Show()

    'End Sub



    'Private Sub GUIstandar_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
    '    ' If Not Me.controlador Is Nothing Then


    '    BackgroundWorker1.RunWorkerAsync()
    '    'End If
    'End Sub


End Class