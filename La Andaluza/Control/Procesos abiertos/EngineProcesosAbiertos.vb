Public Class EngineProcesosAbiertos
    Private spProcesosAbiertos As spProcesosAbiertos
    Public Sub New()
        spProcesosAbiertos = New spProcesosAbiertos
    End Sub
    Public Sub SetValues(ByRef panel As FlowLayoutPanel, ByRef datagrid As DataGridView)
        Dim dt As DataTable = spProcesosAbiertos.devolverProcesosAbiertos

    End Sub

End Class
