Public Class MovimientoFiltrado
    Protected gui As GuiFiltrado
    Protected bdfiltrado As bdfiltrado
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

    Public Sub New(ByVal tipoDiferencia As Integer)

        Me.TipoProceso = tipoDiferencia
        bdfiltrado = New bdfiltrado
        filtrado = New Filtrados.Filtrado(tipoDiferencia)
        filtrado.lotePartida.tipo = Convert.ToInt32(bdfiltrado.seleccionar_tlote_por_proceso(Me.TipoProceso).Rows(0).Item(0))
        filtrado.lotePartida.muestra = Convert.ToBoolean(bdfiltrado.seleccionar_muestra_pro_proceso(Me.TipoProceso).Rows(0).Item(0))

        If filtrado.lotePartida.tipo <> 0 Then filtrado.Abreviatura = Convert.ToString(bdfiltrado.seleccionar_detalles_tlote(filtrado.lotePartida.tipo).Rows(0).Item(2))

        gui = New GuiFiltrado(filtrado)

        iniciohiloDatos = New System.Threading.ThreadStart(AddressOf cargardatos)
        invocador = New MethodInvoker(AddressOf mostrarDatos)

        cargarDatosuno()

        AddHandler gui.FormClosing, AddressOf cerrar
        AddHandler gui.btnGuardar.Click, AddressOf guardar
        AddHandler gui.CantidadIncorrecta, AddressOf cantidad_incorrecta
        AddHandler gui.ProductoIncorrecto, AddressOf producto_incorrecto
    End Sub

    Public Sub cargarDatosuno()
        hiloDatos = New System.Threading.Thread(iniciohiloDatos)
        hiloDatos.IsBackground = True
        hiloDatos.Name = "consultadatosCompras"
        hiloDatos.Start()
    End Sub

    Private Sub cargardatos()
        listadoDepositos = bdfiltrado.listar_depositos_libres
        listadoProductos = bdfiltrado.listar_productos
        listadoFiltros = bdfiltrado.devolver_Filtros
        listadoLotes = bdfiltrado.devolver_depositos_ocupados
        gui.BeginInvoke(invocador)
    End Sub

    Private Sub mostrarDatos()
        gui.DestinoDatasource = listadoDepositos
        gui.OrigenDatasource = listadoLotes
        gui.TipoProductoEntradaDatasource = listadoProductos
        gui.FiltroDatasource = listadoFiltros
    End Sub

    Private Sub cerrar()
        If hiloDatos.IsAlive Then hiloDatos.Abort()
    End Sub

    Protected Sub guardar()

        filtrado = gui.valores

        bdfiltrado.EmpezarTransaccion()
        Try

            Dim errores As String = filtrado.validar
            If errores <> String.Empty Then
                Throw New Exception("Se has encontrado los siguientes errores: " & Environment.NewLine & errores)
            End If


            'comprobaciones de los datos recibidos
            Dim lote As DataTable = bdfiltrado.seleccionar_lote(filtrado.lotePartida.id)
            If filtrado.lotePartida.deposito <> Convert.ToInt32(lote.Rows(0).Item(5)) Then
                Throw New Exception("El deposito de destino ya no contiene el lote que se selecciono.")
            End If

            'actualizamos la cantidad restante con los valores actuales
            filtrado.lotePartida.cantidad_restante = Convert.ToDouble(lote.Rows(0).Item(3))

            'preaparacion del lote final
            Dim producto As DataTable = bdfiltrado.seleccionar_detalles_producto(filtrado.lotePartida.producto)
            Dim fechaDiferencias As Date
            Dim codigoSinLetra As String

            'If Me.filtrado.frecuencia_creacion_lote = Diferencias.Diferencia.FRECUENCIA_MENSUAL Then
            '    fechaDiferencias = New Date(filtrado.fecha.Year, filtrado.fecha.Month, 1)

            '    codigoSinLetra = fechaDiferencias.ToString("yyyyMMdd") & producto.Rows(0).Item(2).ToString & Me.filtrado.Abreviatura
            '    filtrado.loteFinal.codigo_lote = bdfiltrado.recuperar_ultimo_codigo_lote(codigoSinLetra)
            'Else
            fechaDiferencias = filtrado.fecha

            codigoSinLetra = fechaDiferencias.ToString("yyyyMMdd") & producto.Rows(0).Item(2).ToString & Me.filtrado.Abreviatura
            ' End If


            If filtrado.loteFinal.codigo_lote.Replace(" ", "") = "" Then
                filtrado.loteFinal.codigo_lote = bdfiltrado.calcular_codigo_lote(codigoSinLetra)

                If Not bdfiltrado.crear_lote(filtrado.loteFinal.codigo_lote, filtrado.cantidad, filtrado.loteFinal.producto, filtrado.loteFinal.tipo) Then
                    Throw New Exception("No se pudo crear el lote de entrada")
                End If
            End If


            ''??
            'realizar movimiento de compra a final
            If Not bdfiltrado.guardar_movimiento(filtrado.lotePartida.deposito, filtrado.loteFinal.deposito, filtrado.cantidad) Then
                Throw New Exception("No se pudo guardar el movimiento del lote compra")
            End If

            'guardar trazabilidad
            If Not bdfiltrado.guardar_trazabilidad(filtrado.loteFinal.codigo_lote, filtrado.lotePartida.codigo_lote, filtrado.cantidad) Then
                Throw New Exception("No se pudo guardar la trazabilidad del lote compra")
            End If

            If Not bdfiltrado.actualizar_lote(filtrado.lotePartida.codigo_lote, -filtrado.cantidad) Then
                Throw New Exception("No se pudo actualizar la cantidad del lote de partida")
            End If

            If Me.filtrado.cantidad = Me.filtrado.lotePartida.cantidad_restante Then
                bdfiltrado.sacar_lote(filtrado.lotePartida.codigo_lote)
            End If


            If Not bdfiltrado.actualizar_lote(filtrado.loteFinal.codigo_lote, filtrado.cantidad) Then
                Throw New Exception("No se pudo actualizar la cantidad del lote de destino")
            End If

            bdfiltrado.TerminarTransaccion()
            gui.Close()
        Catch ex As Exception
            bdfiltrado.CancelarTransaccion()
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cantidad_incorrecta(ByVal lote As Integer, e As EventArgs)
        'Pantalla.mostrarDialogo(CType(New CorrectorCantidad(lote), Form))
        Dim corrector As New CorrectorCantidad(lote)
        cargarDatosuno()
    End Sub

    Private Sub producto_incorrecto(ByVal lote As Integer, e As EventArgs)
        'Pantalla.mostrarDialogo(CType(New CorrectorProducto(lote), Form))
        Dim corrector As New CorrectorProducto(lote)
        cargarDatosuno()
    End Sub

End Class
