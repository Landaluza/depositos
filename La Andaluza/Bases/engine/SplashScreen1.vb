Public NotInheritable Class SplashScreen1
    Private c As Config

    Public Sub New()

        InitializeComponent()

        Version.Text = My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Build   'System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.MajorRevision)
        Copyright.Text = My.Application.Info.Copyright
    End Sub
    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Set up the dialog text at runtime according to the application's assembly information.  

        'TODO: Customize the application's assembly information in the "Application" pane of the project 
        '  properties dialog (under the "Project" menu).

        ''Application title
        'If My.Application.Info.Title <> String.Empty Then
        '    ApplicationTitle.Text = My.Application.Info.Title
        'Else
        '    'If the application title is missing, use the application name, without the extension
        '    ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        'End If

        'Format the version information using the text set into the Version control at design time as the
        '  formatting string.  This allows for effective localization if desired.
        '  Build and revision information could be included by using the following code and changing the 
        '  Version control's designtime text to "Version {0}.{1:00}.{2}.{3}" or something similar.  See
        '  String.Format() in Help for more information.
        '
        '    Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)


        'Copyright info
        Me.BackgroundWorker1.RunWorkerAsync()

    End Sub

    Private Sub SplashScreen1_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        'If Not Me.ProgressBar1.Enabled Then
        '    'If source <> LOCAL Then
        '    Dim c As New Config
        '    c.checkFiles()
        '    'If Not c.checkFiles Then messageBox.show("No se pudieron cargar algunos archivos, es probable que algunas caracteristicas no funcionen correctamente",String.Empty, MessageBoxButtons.OK ,MessageBoxIcon.Information ))
        '    'End If

        '    'Config.PrintDialogEtiquetas = New PrintDialog()
        '    'Config.PageSetupDialogEtiquetas = New PageSetupDialog
        '    'Config.documentoImpresoraEtiquetas = New System.Drawing.Printing.PrintDocument
        '    'Config.documentoImpresoraEtiquetas.OriginAtMargins = True
        '    'Config.PageSetupDialogEtiquetas.Document = Config.documentoImpresoraEtiquetas
        '    'Config.PrintDialogEtiquetas.Document = Config.documentoImpresoraEtiquetas
        'End If
    End Sub

    Public Sub show_loading()
        Me.ProgressBar1.Enabled = True
        'Me.ProgressBar1.Visible = True
        Me.Show()
    End Sub

    Public Sub hide_loading()
        Me.Hide()
        Me.ProgressBar1.Enabled = False
        Me.ProgressBar1.Visible = False
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        If Not Me.ProgressBar1.Enabled Then
            'If source <> LOCAL Then
            Config.CArgar_Ajustes_Predeterminados()
            c = New Config
            'c.checkFiles()
            c.calcular_version()
            'If Not c.checkFiles Then messageBox.show("No se pudieron cargar algunos archivos, es probable que algunas caracteristicas no funcionen correctamente",String.Empty, MessageBoxButtons.OK ,MessageBoxIcon.Information ))
            'End If

            'Config.PrintDialogEtiquetas = New PrintDialog()
            'Config.PageSetupDialogEtiquetas = New PageSetupDialog
            'Config.documentoImpresoraEtiquetas = New System.Drawing.Printing.PrintDocument
            'Config.documentoImpresoraEtiquetas.OriginAtMargins = True
            'Config.PageSetupDialogEtiquetas.Document = Config.documentoImpresoraEtiquetas
            'Config.PrintDialogEtiquetas.Document = Config.documentoImpresoraEtiquetas
        End If
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As System.Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

    End Sub

End Class
