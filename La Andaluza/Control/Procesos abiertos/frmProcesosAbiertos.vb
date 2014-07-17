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
        Me.EngProcesosAbiertos.añadir_Elemento(Me.FlowLayoutPanel1)
    End Sub
End Class