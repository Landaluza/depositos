Public Class frmProcesosAbiertos
    Private EngProcesosAbiertos As EngineProcesosAbiertos
   


    Public Sub New()

        InitializeComponent()

        Me.EngProcesosAbiertos = New EngineProcesosAbiertos
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

    Private Sub tsTrasiegos_Click(sender As Object, e As EventArgs) Handles tsTrasiegos.Click
        Me.EngProcesosAbiertos.añadir_Elemento(Me.FlowLayoutPanel1, EngineProcesosAbiertos.TRASIEGO)
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        tsDetallado_Click(Nothing, Nothing)
        Me.FlowLayoutPanel1.Controls(e.RowIndex).Focus()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.EngProcesosAbiertos.añadir_Elemento(Me.FlowLayoutPanel1, EngineProcesosAbiertos.COMPRA_MATERIAS_PRIMAS)
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.EngProcesosAbiertos.añadir_Elemento(Me.FlowLayoutPanel1, EngineProcesosAbiertos.FILTRACION)
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Me.EngProcesosAbiertos.añadir_Elemento(Me.FlowLayoutPanel1, EngineProcesosAbiertos.GRANEL)
    End Sub
End Class