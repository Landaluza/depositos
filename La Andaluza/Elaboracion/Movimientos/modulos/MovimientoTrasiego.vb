Public Class MovimientoTrasiego
    Private gui As GuiMovimientoTrasiego
    Private bdTrasiego As bdTrasiego
    Private listadoDepositos As DataTable

    Private iniciohilo As System.Threading.ThreadStart
    Private invocador As MethodInvoker

    Public ReadOnly Property Form As Form
        Get
            Return CType(gui, Form)
        End Get
    End Property

    Public Sub New()
        gui = New GuiMovimientoTrasiego
        bdTrasiego = New bdTrasiego


        iniciohilo = New System.Threading.ThreadStart(AddressOf cargardatos)
        invocador = New MethodInvoker(AddressOf mostrardatos)

        cargarDatosOrigen()

        AddHandler gui.dgvorigen.SelectionChanged, AddressOf cargarDatosSecundarios
    End Sub

    Public Sub cargarDatosOrigen()
        Dim hilo As System.Threading.Thread


        hilo = New System.Threading.Thread(iniciohilo)
        hilo.IsBackground = True
        hilo.Name = "consultadatos"
        hilo.Start()
    End Sub
    Public Sub cargardatos()
        listadoDepositos = bdTrasiego.listar_depositos()
        gui.BeginInvoke(invocador)
    End Sub

    Public Sub mostrarDatos()
        gui.OrigenDataSource = listadoDepositos
    End Sub
    Public Sub cargarDatosSecundarios()
        listadoDepositos = bdTrasiego.listar_depositos_excepto(Convert.ToInt32(gui.dgvorigen.CurrentRow.Cells(0).Value))
        gui.DestinoDataSource = listadoDepositos
    End Sub

End Class
