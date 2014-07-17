Public Class ProcesosEngine
    Protected id As Integer
    Public Sub New(ByVal id As Integer)
        Me.id = id
    End Sub

    Public Function borrar_proceso_abierto() As Boolean
        Dim sp As New spProcesosAbiertos
        Return sp.borrar(id)
    End Function

    Public Function seleccionar() As DataTable
        Dim sp As New spProcesosAbiertos
        Return sp.seleccionar(id)
    End Function
End Class
