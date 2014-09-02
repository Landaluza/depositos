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
        Dim compra As compras.Compra = gui.valores

        Dim errores As String = compra.validar
        If errores <> String.Empty Then
            MessageBox.Show("Se has encontrado los siguientes errores: " & Environment.NewLine & errores, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        bdCompra.EmpezarTransaccion()

        Try
            'comprobaciones de los datos recibidos

            If compra.loteFinal.codigo_lote = "" Then
                Dim dep As DataTable = bdCompra.seleccionar_detalles_deposito(compra.loteFinal.deposito)

                If dep.Rows(0).Item(1).ToString <> "" Then
                    bdCompra.CancelarTransaccion()
                    MessageBox.Show("Deposito en uso. El deposito de destino ya esta en uso.", "Operacion no permitida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return
                End If
            Else

                Dim lote As DataTable = bdCompra.seleccionar_lote_por_codigo(compra.loteFinal.codigo_lote)
                If compra.loteFinal.deposito <> Convert.ToInt32(lote.Rows(0).Item(5)) Then
                    bdCompra.CancelarTransaccion()
                    MessageBox.Show("El deposito de destino ya no contiene el lote que se selecciono.", "Operacion no permitida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return
                End If

                'actualizamos la cantidad restante con los valores actuales
                compra.loteFinal.cantidad_restante = Convert.ToDouble(lote.Rows(0).Item(1))
            End If

            Dim producto As DataTable = bdCompra.seleccionar_detalles_producto(compra.lotePartida.producto)            
            Dim codigoSinLetra As String = compra.fecha.ToString("yyyyMMdd") & producto.Rows(0).Item(2).ToString & compras.Compra.ABREVIATURA
            Dim codigo As String = bdCompra.calcular_codigo_lote(codigoSinLetra)

            'crear lote compra
            bdCompra.crear_lote_compra(codigo, compra.cantidad, compra.lotePartida.producto, compra.proveedorCompra)

            'si guardamos el lote que hubiera en el deposito de fin para añadir trazabilidad
            If compra.loteFinal.id = 0 Then

                'crear lote clonando el de compra, deposito vacio
                bdCompra.crear_lote(codigo, )
            Else
                If compra.loteFinal.codigo_lote = "" Then
                    'crear lote y guardar para trazabilidad el anterior
                Else
                    'no crear lote
                End If
            End If

            'realizar movimiento de compra a final

            'guardar trazabilidad

            bdCompra.TerminarTransaccion()
        Catch ex As Exception
            bdCompra.CancelarTransaccion()
        End Try
    End Sub
End Class
