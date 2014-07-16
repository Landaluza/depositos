Public Class frmProcesosAbiertos

    Public Sub New()

        InitializeComponent()


        Me.SuspendLayout()
        For i As Integer = 0 To 10

            Dim frm As New frmTrasiego
            frm.WindowState = FormWindowState.Normal
            frm.TopLevel = False
            frm.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            frm.Dock = DockStyle.None
            frm.Show()            
            Me.FlowLayoutPanel1.Controls.Add(frm)
            Me.Refresh()
        Next
        Me.ResumeLayout()
    End Sub
End Class