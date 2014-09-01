Public Class MovimientoCompra
    Private gui As GuiMovimientoCompra
    Private bdCompra As BdCompra
    Private listadoDepositos As DataTable
    Private listadoProductos As DataTable
    Private listadoLotes As DataTable
    Private listadoProveedores As DataTable

    Private hiloDatos As System.Threading.Thread
    Private iniciohiloDatos As System.Threading.ThreadStart
    Private invocador As MethodInvoker

    Public ReadOnly Property Form As Form
        Get
            Return CType(gui, Form)
        End Get
    End Property

    Public Sub New()
        gui = New GuiMovimientoCompra
        bdCompra = New BdCompra

        iniciohiloDatos = New System.Threading.ThreadStart(AddressOf cargardatos)
        invocador = New MethodInvoker(AddressOf mostrarDatos)

        cargarDatosuno()

        AddHandler gui.FormClosing, AddressOf cerrar
        AddHandler gui.btnGuardar.Click, AddressOf guardar
    End Sub

    Public Sub cargarDatosuno()
        hiloDatos = New System.Threading.Thread(iniciohiloDatos)
        hiloDatos.IsBackground = True
        hiloDatos.Name = "consultadatosCompras"
        hiloDatos.Start()
    End Sub

    Private Sub cargardatos()
        listadoProveedores = bdCompra.listar_proveedores()
        listadoLotes = bdCompra.listar_tlotes
        listadoProductos = bdCompra.listar_productos
        listadoDepositos = bdCompra.listar_depositos

        gui.BeginInvoke(invocador)
    End Sub

    Private Sub mostrarDatos()
        gui.TipoProductoDatasource = listadoProductos
        gui.TipoLoteDatasource = listadoLotes
        gui.ProveedorEntradaDatasource = listadoProveedores
        gui.TipoProductoEntradaDatasource = listadoProductos
        gui.DestinoDatasource = listadoDepositos

    End Sub

    Private Sub cerrar()
        If hiloDatos.IsAlive Then hiloDatos.Abort()
    End Sub

    Private Sub guardar()
        Dim compra As Compra = gui.valores

        Dim errores As String = Compra.validar
        If errores <> String.Empty Then
            MessageBox.Show("Se has encontrado los siguientes errores: " & Environment.NewLine & errores, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If


    End Sub
End Class
