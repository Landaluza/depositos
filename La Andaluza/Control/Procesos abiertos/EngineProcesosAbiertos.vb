Public Class EngineProcesosAbiertos
    Private spProcesosAbiertos As spProcesosAbiertos

    Public Const TRASIEGO As Integer = 9
    Public Const CLARIFICACION As Integer = 2
    Public Const FERMENTACION As Integer = 3
    Public Const ENVASADO As Integer = 4
    Public Const MACERACION As Integer = 5
    Public Const GRANEL As Integer = 6
    Public Const TERMINADO As Integer = 7
    Public Const AJUDATE_COMERCIAL As Integer = 8
    Public Const AJUSTE_AGUA As Integer = 12
    Public Const FILTRACION As Integer = 10
    Public Const DIFERENCIAS As Integer = 11
    Public Const MERMAS As Integer = 16
    Public Const DESECHO As Integer = 9
    Public Const PIE_DE_CUBA As Integer = 9
    Public Const AJUSTE_DE_AGUA As Integer = 12
    Public Const COCCION_CONTROLADA As Integer = 9
    Public Const DESEMBOTE_NC As Integer = 18
    Public Const DESEMBOTES As Integer = 19
    Public Const COMPRA_MATERIAS_PRIMAS As Integer = 1

    Public Sub New()
        spProcesosAbiertos = New spProcesosAbiertos
    End Sub
    Public Sub SetValues(ByRef panel As FlowLayoutPanel, ByRef datagrid As DataGridView)
        Dim dt As DataTable = spProcesosAbiertos.devolverProcesosAbiertos
        Dim frm As frmTrasiego
        Dim separador As Panel
        Dim Generator As System.Random = New System.Random()

        If Not dt Is Nothing Then
            For Each dr As DataRow In dt.Rows

                frm = New frmTrasiego(Convert.ToInt32(dr.Item(0)))
                frm.WindowState = FormWindowState.Normal
                frm.TopLevel = False
                frm.FormBorderStyle = Windows.Forms.FormBorderStyle.None
                frm.Dock = DockStyle.None
                frm.Show()
                panel.Controls.Add(frm)

                separador = New Panel
                separador.BackColor = Color.Black
                separador.Height = 2
                separador.Width = 1020 + (Generator.Next(0, 9) * 10)
                panel.Controls.Add(separador)
            Next
            datagrid.DataSource = dt
        End If
    End Sub

    Public Sub añadir_Elemento(ByRef FlowLayoutPanel1 As FlowLayoutPanel, ByVal tipoproceso As Integer)
        Dim proceso As Integer = Me.spProcesosAbiertos.añadirProceso(tipoproceso)
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
