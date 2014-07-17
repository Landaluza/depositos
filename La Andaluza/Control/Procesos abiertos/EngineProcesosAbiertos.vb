Public Class EngineProcesosAbiertos
    Private spProcesosAbiertos As spProcesosAbiertos
    Public Sub New()
        spProcesosAbiertos = New spProcesosAbiertos
    End Sub
    Public Sub SetValues(ByRef panel As FlowLayoutPanel, ByRef datagrid As DataGridView)
        Dim dt As DataTable = spProcesosAbiertos.devolverProcesosAbiertos

        If Not dt Is Nothing Then
            For Each dr As DataRow In dt.Rows

            Next
            datagrid.DataSource = dt
        End If
    End Sub

    Public Sub añadir_Elemento(ByRef FlowLayoutPanel1 As FlowLayoutPanel)
        Dim proceso As Integer = Me.spProcesosAbiertos.añadirproceso
        If proceso <> 0 Then
            Dim frm As New frmTrasiego(proceso)
            frm.WindowState = FormWindowState.Normal
            frm.TopLevel = False
            frm.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            frm.Dock = DockStyle.None
            frm.Show()
            FlowLayoutPanel1.Controls.Add(frm)
        End If
    End Sub
End Class
