Public Class MovimientoSalida
    Protected gui As Guifiltrado
    Protected bdfiltrado As BdFiltrado
    Protected listadoDepositos As DataTable
    Protected listadoFiltros As DataTable
    Protected listadoProductos As DataTable
    Protected listadoLotes As DataTable
    Protected filtrado As Filtrados.Filtrado

    Protected hiloDatos As System.Threading.Thread
    Protected iniciohiloDatos As System.Threading.ThreadStart
    Protected invocador As MethodInvoker
    Private TipoProceso As Integer

    Public ReadOnly Property Form As Form
        Get
            Return CType(gui, Form)
        End Get
    End Property
    Public Sub New(ByVal proceso As Integer)

    End Sub
End Class
