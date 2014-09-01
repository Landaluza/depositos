Public Class MovimientoCompra
    Private gui As GuiMovimientoCompra
    Private bdCompra As BdCompra
    Private listadoDepositos As DataTable
    Private listadoProductos As DataTable
    Private listadoLotes As DataTable
    Private listadoProveedores As DataTable

    Private hiloDatos As System.Threading.Thread
    Private hiloDatosDestino As System.Threading.Thread
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
        gui = New GuiMovimientoCompra
        bdCompra = New BdCompra


        iniciohiloDatos = New System.Threading.ThreadStart(AddressOf cargardatos)
        iniciohiloSecundarios = New System.Threading.ThreadStart(AddressOf cargarDatosSecundarios)
        invocador = New MethodInvoker(AddressOf mostrarDatos)
        invocadorSecundario = New MethodInvoker(AddressOf mostrarDatosSecundarios)

        cargarDatosOrigen()


        AddHandler gui.FormClosing, AddressOf cerrar
        AddHandler gui.btnGuardar.Click, AddressOf guardar
    End Sub

    Public Sub cargarDatosOrigen()


        hiloDatos = New System.Threading.Thread(iniciohiloDatos)
        hiloDatos.IsBackground = True
        hiloDatos.Name = "consultadatos"
        hiloDatos.Start()
    End Sub

    Public Sub cargarDatosDestino()


        hiloDatosDestino = New System.Threading.Thread(iniciohiloSecundarios)
        hiloDatosDestino.IsBackground = True
        hiloDatosDestino.Name = "consultadatosSecundarios"
        hiloDatosDestino.Start()
    End Sub

    Private Sub cargardatos()
        listadoDepositos = bdCompra.listar_depositos()
        listadoLotes = bdCompra.listar_tlotes
        listadoProductos = bdCompra.listar_productos
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

    Private Sub cerrar()
        If hiloDatosDestino.IsAlive Then hiloDatosDestino.Abort()
        If hiloDatos.IsAlive Then hiloDatos.Abort()
    End Sub

    Private Sub guardar()
        Dim trasiego As Trasiego = gui.valores

        Dim errores As String = trasiego.validar
        If errores <> String.Empty Then
            MessageBox.Show("Se has encontrado los siguientes errores: " & Environment.NewLine & errores, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If


    End Sub
End Class
