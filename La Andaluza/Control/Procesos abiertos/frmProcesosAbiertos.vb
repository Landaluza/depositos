Public Class frmProcesosAbiertos

    Public Sub New()

        InitializeComponent()


        Dim frm As New frmTrasiego
        Dim pan As New Panel
        Engine_LA.FormEnPestaña(frm, pan)
        Me.FlowLayoutPanel1.Controls.Add(frm)

        'For i As Integer = 0 To 10

        '    Dim frm As New frmTrasiego
        '    frm.WindowState = FormWindowState.Normal
        '    frm.TopLevel = False
        '    frm.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        '    frm.Dock = DockStyle.Fill
        '    frm.Show()
        '    Me.FlowLayoutPanel1.Controls.Add(frm)

        'Next

    End Sub
End Class