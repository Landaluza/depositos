Public Class EngineProcesosAbiertos
    Private spProcesosAbiertos As spProcesosAbiertos


    Public Const COMPRA_MATERIAS_PRIMAS As Integer = 1
    Public Const CLARIFICACION As Integer = 2
    Public Const FERMENTACION As Integer = 3
    Public Const ENVASADO As Integer = 4
    Public Const MACERACION As Integer = 5
    Public Const GRANEL As Integer = 6
    Public Const TERMINADO As Integer = 7
    Public Const AJUDATE_COMERCIAL As Integer = 8
    Public Const TRASIEGO As Integer = 9
    Public Const FILTRACION As Integer = 10
    Public Const DIFERENCIAS As Integer = 11
    Public Const AJUSTE_AGUA As Integer = 12
    Public Const LAVADO_DEPOSITO As Integer = 13
    Public Const PIE_DE_CUBA As Integer = 14
    Public Const DESECHO As Integer = 15
    Public Const MERMAS As Integer = 16
    Public Const COCCION_CONTROLADA As Integer = 17
    Public Const DESEMBOTE_NC As Integer = 18
    Public Const DESEMBOTES As Integer = 19


    Public Sub New()
        spProcesosAbiertos = New spProcesosAbiertos
    End Sub
    Public Sub SetValues(ByRef panel As FlowLayoutPanel, ByRef datagrid As DataGridView)
        Dim dt As DataTable = spProcesosAbiertos.devolverProcesosAbiertos
        Dim frm As frmProceso        

        If Not dt Is Nothing Then
            For Each dr As DataRow In dt.Rows

                frm = form_por_proceso(Convert.ToInt32(dr.Item(3)), Convert.ToInt32(dr.Item(0)))               

                frm.WindowState = FormWindowState.Normal
                frm.TopLevel = False
                frm.FormBorderStyle = Windows.Forms.FormBorderStyle.None
                frm.Dock = DockStyle.None
                frm.Show()
                panel.Controls.Add(frm)
            Next

            datagrid.DataSource = dt
            datagrid.Columns(3).Visible = False
            datagrid.Columns(0).Visible = False
        End If
    End Sub

    Public Sub añadir_Elemento(ByRef FlowLayoutPanel1 As FlowLayoutPanel, ByVal tipoproceso As Integer)
        Dim proceso As Integer = Me.spProcesosAbiertos.añadirProceso(tipoproceso)

        If proceso <> 0 Then
            Dim frm As frmProceso

            frm = form_por_proceso(tipoproceso, proceso)

            frm.WindowState = FormWindowState.Normal
            frm.TopLevel = False
            frm.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            frm.Dock = DockStyle.None
            frm.Show()
            FlowLayoutPanel1.Controls.Add(frm)
        End If

    End Sub

    Private Function form_por_proceso(ByVal tipoProceso As Integer, ByVal proceso As Integer) As frmProceso
        Select Case tipoProceso
            Case TRASIEGO
                Return New frmTrasiego(proceso)
            Case COMPRA_MATERIAS_PRIMAS
                Return New frmCompra(proceso)
            Case FILTRACION
                Return New frmFiltrado(proceso)
            Case GRANEL
                Return New frmGraneles(proceso)
            Case LAVADO_DEPOSITO
                Return New frmLavado(proceso)
            Case AJUSTE_AGUA
                Return New frmAjusteAgua(proceso)
            Case AJUDATE_COMERCIAL
                Return New frmAjusteComercial(proceso)
            Case CLARIFICACION
                Return New frmClarificacion(proceso)
            Case COCCION_CONTROLADA
                Return New frmCoccion(proceso)
            Case DESECHO
                Return New frmDesecho(proceso)
            Case DESEMBOTES
                Return New frmDesembote(proceso)
            Case DESEMBOTE_NC
                Return New frmDesemboteNC(proceso)
            Case DIFERENCIAS
                Return New frmDiferencias(proceso)
            Case ENVASADO
                Return New frmEnvasado(proceso)
            Case FERMENTACION
                Return New frmFermentacion(proceso)
            Case MACERACION
                Return New frmMaceracion(proceso)
            Case PIE_DE_CUBA
                Return New frmPieCuba(proceso)
            Case Else
                Return Nothing
        End Select
    End Function

End Class
