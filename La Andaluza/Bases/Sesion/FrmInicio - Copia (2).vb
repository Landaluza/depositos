Public Class FrmInicio
    'Private ctrSes As New ctlUsuarios
    'Public Const CAMBIO_SESION As Integer = 0
    'Public Const acceso As Integer = 1    
    Private Gform As GUIstandar
    Private Calendar As Calendar
    Public Sub New()

        InitializeComponent()
        Calendar = New Calendar
        Calendar.testDateTime = False
        Me.Gform = New GUIstandar(Me)
        AddHandler Gform.FormClosed, AddressOf Me.Close
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        iniciar()
    End Sub

    Private Sub ButtonCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub iniciar()

        If My.Computer.Name = "MAM1" Or My.Computer.Name = "GERENTE1" Or My.Computer.Name = "MAM2-PC" Or My.Computer.Name = "MAMVAIO" Then
            If txtLogin.Text.Length = 0 And txtPassword.Text.Length = 0 Then
                txtLogin.Text = "mam"
                txtPassword.Text = "trucha0121"
            End If
        End If

        If comprobarCampos() Then            
            Me.Enabled = False
            If Not Me.BackgroundWorker1.IsBusy Then
                Me.BackgroundWorker1.RunWorkerAsync()
            End If
        Else
            MessageBox.Show("Error. Los datos no son correctos", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Function comprobarCampos() As Boolean

        Dim respuesta As Boolean = True
        If txtLogin.Text.Contains("'") Then
            If Not Me.LblLoginIssue.Visible Then Me.LblLoginIssue.Visible = True
            If respuesta Then respuesta = False
        Else
            If Me.LblLoginIssue.Visible Then Me.LblLoginIssue.Visible = False
        End If
        If txtLogin.Text = "" Then
            If Not Me.LblLoginIssue.Visible Then Me.LblLoginIssue.Visible = True
            If respuesta Then respuesta = False
        Else
            If Me.LblLoginIssue.Visible Then Me.LblLoginIssue.Visible = False
        End If
        If txtPassword.Text = "" Then
            If Not Me.lblPasswordIssue.Visible Then Me.lblPasswordIssue.Visible = True
            If respuesta Then respuesta = False
        Else
            If Me.lblPasswordIssue.Visible Then Me.lblPasswordIssue.Visible = False
        End If
       

        Return respuesta
    End Function

    Private Sub FrmInicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setValores()
    End Sub

    Private Sub setValores()
        Me.Text = Config.Version_seriada
    End Sub

    Private Sub FrmInicio_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = 13 Then
            iniciar()
        End If
    End Sub

    Private Sub FrmInicio_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
               Me.txtLogin.Text = ""
        Me.txtPassword.Text = ""
        Me.BringToFront()
    End Sub

    Private Sub FrmInicio_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Not Me.Gform Is Nothing Then Me.Gform.stopGUI()
        Environment.Exit(0)
    End Sub

    Private Sub txtLogin_Enter(sender As System.Object, e As System.EventArgs) Handles txtLogin.Enter
        Me.txtLogin.SelectAll()
    End Sub

    Private Sub txtPassword_Enter(sender As System.Object, e As System.EventArgs) Handles txtPassword.Enter
        Me.txtPassword.SelectAll()
    End Sub

    Private Sub txtLogin_Click(sender As System.Object, e As System.EventArgs) Handles txtLogin.Click
        Me.txtLogin.SelectAll()
    End Sub

    Private Sub txtPassword_Click(sender As System.Object, e As System.EventArgs) Handles txtPassword.Click
        Me.txtPassword.SelectAll()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        DataBase.buildConnectionString(Config.Server)
        Dim spUsuarios As New spUsuarios

        If Not Calendar.TestDate() Then
            Config.User = -1
        Else
            If Not spUsuarios.autentificar(txtLogin.Text, txtPassword.Text) Then
                Config.User = 0
            End If
        End If
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As System.Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        If Config.User = 0 Then
            MessageBox.Show("Error en datos", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.Enabled = True
        Else
            If Config.User = -1 Then
                MessageBox.Show("No se pudo conectar a la base de datos, vuelva a intentarlo en unos minutos. Si el problema persiste contacte con su administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Enabled = True
            Else
                Me.Hide()
                SplashScreen1.show_loading()

                Gform.terminarDeIniciar("LA", "SERVIDOR", Me.txtLogin.Text, txtLogin.Text)

                Me.Enabled = True
                Me.DialogResult = Windows.Forms.DialogResult.OK
                SplashScreen1.hide_loading()
                Gform.Show()
            End If
        End If
    End Sub
End Class
