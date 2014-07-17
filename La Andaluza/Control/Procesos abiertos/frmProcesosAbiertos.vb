Public Class frmProcesosAbiertos
    Private EngProcesosAbiertos As EngineProcesosAbiertos
    Public Sub New()

        InitializeComponent()

        Me.EngProcesosAbiertos = New EngineProcesosAbiertos

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

    Private Sub tsCompacto_Click(sender As Object, e As EventArgs) Handles tsCompacto.Click
        Me.FlowLayoutPanel1.Visible = False
    End Sub

    Private Sub tsDetallado_Click(sender As Object, e As EventArgs) Handles tsDetallado.Click
        Me.FlowLayoutPanel1.Visible = True
    End Sub

    Private Sub frmProcesosAbiertos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.EngProcesosAbiertos.SetValues(Me.FlowLayoutPanel1, Me.DataGridView1)
    End Sub
End Class