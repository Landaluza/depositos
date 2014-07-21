Public Class ProcesosEngine
    Protected id As Integer
    Private sp As spProcesosAbiertos
    Public Sub New(ByVal id As Integer)
        Me.id = id
        sp = New spProcesosAbiertos
    End Sub

    Public Function borrar_proceso_abierto() As Boolean
        Return sp.borrar(id)
    End Function

    Public Function seleccionar() As DataTable
        Return sp.seleccionar(id)
    End Function


End Class
