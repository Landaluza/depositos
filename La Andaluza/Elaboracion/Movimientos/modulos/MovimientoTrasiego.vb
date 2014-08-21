Public Class MovimientoTrasiego
    Private gui As GuiMovimientoTrasiego
    Private bdTrasiego As bdTrasiego
    Private listadoDepositos As DataTable
    Private listadoProductos As DataTable
    Private listadoLotes As DataTable

    Private iniciohiloDatos As System.Threading.ThreadStart
    Private iniciohiloSecundarios As System.Threading.ThreadStart
    Private invocador As MethodInvoker
    Private invocadorSecundario As MethodInvoker

    Public ReadOnly Property Form As Form
        Get
            Return CType(gui, Form)
        End Get
    End Property

    Public Sub New()
        gui = New GuiMovimientoTrasiego
        bdTrasiego = New bdTrasiego


        iniciohiloDatos = New System.Threading.ThreadStart(AddressOf cargardatos)
        iniciohiloSecundarios = New System.Threading.ThreadStart(AddressOf cargarDatosSecundarios)
        invocador = New MethodInvoker(AddressOf mostrarDatos)
        invocadorSecundario = New MethodInvoker(AddressOf mostrarDatosSecundarios)

        cargarDatosOrigen()

        AddHandler gui.dgvorigen.SelectionChanged, AddressOf cargarDatosDestino
    End Sub

    Public Sub cargarDatosOrigen()
        Dim hilo As System.Threading.Thread

        hilo = New System.Threading.Thread(iniciohiloDatos)
        hilo.IsBackground = True
        hilo.Name = "consultadatos"
        hilo.Start()
    End Sub

    Public Sub cargarDatosDestino()
        Dim hilo As System.Threading.Thread

        hilo = New System.Threading.Thread(iniciohiloSecundarios)
        hilo.IsBackground = True
        hilo.Name = "consultadatosSecundarios"
        hilo.Start()
    End Sub

    Private Sub cargardatos()
        listadoDepositos = bdTrasiego.listar_depositos()
        listadoLotes = bdTrasiego.listar_tlotes
        listadoProductos = bdTrasiego.listar_productos
        gui.BeginInvoke(invocador)
    End Sub

    Private Sub mostrarDatos()
        gui.OrigenDataSource = listadoDepositos
        gui.TipoLoteDatasource = listadoLotes
        gui.TipoProductoDatasource = listadoProductos
    End Sub
    Private Sub cargarDatosSecundarios()
        listadoDepositos = bdTrasiego.listar_depositos_excepto(Convert.ToInt32(gui.dgvorigen.CurrentRow.Cells(0).Value))
        gui.BeginInvoke(invocadorSecundario)
    End Sub

    Private Sub mostrarDatosSecundarios()
        gui.DestinoDataSource = listadoDepositos
    End Sub
End Class
