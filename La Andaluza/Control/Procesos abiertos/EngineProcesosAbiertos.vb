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
    Public Const LAVADO_DEPOSITO As Integer = 13
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
        Dim frm As frmProceso
        

        If Not dt Is Nothing Then
            For Each dr As DataRow In dt.Rows

                Select Case Convert.ToInt32(dr.Item(3))
                    Case TRASIEGO
                        frm = New frmTrasiego(Convert.ToInt32(dr.Item(0)))
                    Case COMPRA_MATERIAS_PRIMAS
                        frm = New frmCompra(Convert.ToInt32(dr.Item(0)))
                    Case FILTRACION
                        frm = New frmFiltrado(Convert.ToInt32(dr.Item(0)))
                    Case GRANEL
                        frm = New frmGraneles(Convert.ToInt32(dr.Item(0)))
                    Case LAVADO_DEPOSITO
                        frm = New frmLavado(Convert.ToInt32(dr.Item(0)))
                    Case Else
                        frm = Nothing
                End Select


                frm.WindowState = FormWindowState.Normal
                frm.TopLevel = False
                frm.FormBorderStyle = Windows.Forms.FormBorderStyle.None
                frm.Dock = DockStyle.None
                frm.Show()
                panel.Controls.Add(frm)

            Next
            datagrid.DataSource = dt
            datagrid.Columns(3).Visible = False
        End If
    End Sub

    Public Sub añadir_Elemento(ByRef FlowLayoutPanel1 As FlowLayoutPanel, ByVal tipoproceso As Integer)
        Dim proceso As Integer = Me.spProcesosAbiertos.añadirProceso(tipoproceso)

        If proceso <> 0 Then
            Dim frm As frmProceso

            Select Case tipoproceso
                Case TRASIEGO
                    frm = New frmTrasiego(proceso)
                Case COMPRA_MATERIAS_PRIMAS
                    frm = New frmCompra(proceso)
                Case FILTRACION
                    frm = New frmFiltrado(proceso)
                Case GRANEL
                    frm = New frmGraneles(proceso)
                Case LAVADO_DEPOSITO
                    frm = New frmLavado(proceso)
                Case Else
                    frm = Nothing
            End Select

            frm.WindowState = FormWindowState.Normal
            frm.TopLevel = False
            frm.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            frm.Dock = DockStyle.None
            frm.Show()
            FlowLayoutPanel1.Controls.Add(frm)
        End If



    End Sub

   
End Class
