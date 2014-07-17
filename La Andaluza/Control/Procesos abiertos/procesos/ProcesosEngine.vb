Public Class ProcesosEngine
    Protected id As Integer
    Public Sub New(ByVal id As Integer)
        Me.id = id
    End Sub

    Public Function borrar_proceso_abierto() As Boolean
        Dim sp As New spProcesosAbiertos
        Return sp.ConsultaAlteraciones("delete from movimientosabiertos where movimientoid =" & id)
    End Function
End Class
