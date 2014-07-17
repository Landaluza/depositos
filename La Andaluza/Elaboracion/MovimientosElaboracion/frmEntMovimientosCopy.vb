Public Class frmEntMovimientosCopy
    Inherits FrmAHeredarEntOld

    Private Const ABREVIATURA_TIPO_LOTE_ENVASADO As String = "ENV"
    Private Const DESCRIPCION_PROCESO_DIFERENCIAS As String = "Diferencias"
    Private Const DESCRIPCION_TIPO_LOTE_RECEPCION As String = "Recepcion"
    Private Const DESCRIPCION_TIPO_LOTE_DEHECHOS As String = "Agua lavado"

    Private dtsMov As dtsMovimientos.MovimientosDataTable
    Private ctlMov As ctlMovimientos
    Private ctlPro As ctlProcesos
    Private ctlDep As ctlDepositos
    Private ctlLot As ctlLotes
    'Private ctlTipPro As New ctlTiposProductos
    

    Private dboTiposLotes As DBO_TiposLotes
    Private ctlComPor As ctlCompuestoPor
    Private ctlFil As spFiltros
    ' Private ctlRecSal As  ctlRecipientesSalidas

    Private spRecipientesSalidas As spRecipientesSalidas
    Private spProveedores As spProveedores
    Private spTiposProductos As spTiposProductos
    Private spMedidasProductos As spMedidasProductos
    Private spTiposLotes As spTiposLotes
    Public Shared dtb As DataBase
    Private codigoLote As CodigoLote

    

    Private OldLib As OldLib

    Private LoteFinalID As Integer
    Private Capacidad As Double
    Private TipoMovimientoCompra As String
    Private TipoLoteCompraID As Integer
    Private LotePartidaID As Integer

    Private TipodProductoParaLote As String
    Private TipoMovimiento As String
    Private TipoLoteID As Integer
    Private ConMuestra As Boolean

    Private LoteCompraID As Integer
    Private bandera As Boolean = False
    Private DiferenciasLoteID As Integer

    Private banderaCantidadMover As Boolean
    'Private autodiferencia As Boolean = False


    Public Sub New()
        InitializeComponent()

        dtpFecha.activarFoco()
        spProveedores = New spProveedores
        spRecipientesSalidas = New spRecipientesSalidas
        spTiposProductos = New spTiposProductos
        spMedidasProductos = New spMedidasProductos
        spTiposLotes = New spTiposLotes
        codigoLote = New CodigoLote
        dtb = New DataBase(Config.Server)
        dtsMov = New dtsMovimientos.MovimientosDataTable
        ctlMov = New ctlMovimientos
        ctlPro = New ctlProcesos
        ctlDep = New ctlDepositos
        ctlLot = New ctlLotes
        dboTiposLotes = New DBO_TiposLotes
        ctlComPor = New ctlCompuestoPor
        ctlFil = New spFiltros
        OldLib = New OldLib

        TipodProductoParaLote = ""
        TipoMovimiento = ""
        TipoLoteID = 0
        DiferenciasLoteID = 0
        banderaCantidadMover = False
    End Sub
    Public Sub CargarDatos(ByVal Pos As Integer, _
                                ByVal MovimientoID As Integer, _
                                ByVal Fecha As DateTime, _
                                ByVal Cantidad As Double, _
                                ByVal Observaciones As String, _
                                ByVal ProcesoI As String, _
                                ByVal EntraDepositoID As String, _
                                ByVal SaleDepositoID As String, _
                                ByVal LoteID As String, ByRef dtb As DataBase)

        bandera = False
        banderaCantidadMover = False

        Dim tablaproceso As DataTable = ctlPro.devolverProcesosPorDescripcion(dtb)
        cboProceso.DataSource = OldLib.HacerTablasNoObligatorias(tablaproceso)
        cboProceso.ValueMember = "ID"
        cboProceso.DisplayMember = "Display"
        cboProceso.MaxDropDownItems = cboProceso.Items.Count

        Dim spTiposLotes As New spTiposLotes
        spTiposLotes.cargar_TiposLotes(cboTipoLoteCompra)
        'Dim tablaTiposLotes As DataTable = ctlTipLot.devolverTiposLotesPorDescripcion
        'cboTipoLoteCompra.DataSource = OldLib.HacerTablasNoObligatorias(tablaTiposLotes)
        'cboTipoLoteCompra.ValueMember = "ID"
        'cboTipoLoteCompra.DisplayMember = "Display"

        spTiposLotes.cargar_TiposLotes(cboDiferenciasTipoLote)
        'cboDiferenciasTipoLote.DataSource = OldLib.HacerTablasNoObligatorias(tablaTiposLotes)
        'cboDiferenciasTipoLote.ValueMember = "ID"
        'cboDiferenciasTipoLote.DisplayMember = "Display"

        spProveedores.cargar_Proveedores_Compras(cboCompraProveedor)
        ' cboCompraProveedor.DataSource = OldLib.HacerTablasNoObligatorias(ctlprov.devolverProveedoresParaCompra)
        'cboCompraProveedor.ValueMember = "ID"
        '  cboCompraProveedor.DisplayMember = "Display"

        cboFinalDepositoID.DataSource = OldLib.HacerTablasNoObligatorias(ctlDep.devolverDepositosFinales(dtb))
        cboFinalDepositoID.ValueMember = "ID"
        cboFinalDepositoID.DisplayMember = "Display"
        cboFinalDepositoID.Text = EntraDepositoID

        cboPartidaDepositoID.DataSource = OldLib.HacerTablasNoObligatorias(ctlDep.devolverDepositosPartidas(dtb))
        cboPartidaDepositoID.ValueMember = "ID"
        cboPartidaDepositoID.DisplayMember = "Display"
        cboPartidaDepositoID.Text = SaleDepositoID

        cboAjusteLotes.ValueMember = "ID"
        cboAjusteLotes.DisplayMember = "Display"
        cboAjusteLotes.Text = LoteID

        Dim tablaProductos As DataTable = spTiposProductos.devolver_TiposProductos_No_enologicos(dtb)
        'Dim tablaProductos As DataTable = ctlTipPro.devolverTiposProductosPorDescripcionNoEnologicos
        cboPartidaTipoProducto.DataSource = OldLib.HacerTablasNoObligatorias(tablaProductos)
        cboPartidaTipoProducto.ValueMember = "ID"
        cboPartidaTipoProducto.DisplayMember = "Display"

        tablaProductos = spTiposProductos.devolver_TiposProductos_No_enologicos(dtb)
        cboFinalTipoProductoActual.DataSource = OldLib.HacerTablasNoObligatorias(tablaProductos)
        cboFinalTipoProductoActual.ValueMember = "ID"
        cboFinalTipoProductoActual.DisplayMember = "Display"

        tablaProductos = spTiposProductos.devolver_TiposProductos_No_enologicos(dtb)
        cboCompraProducto.DataSource = OldLib.HacerTablasNoObligatorias(tablaProductos)
        cboCompraProducto.ValueMember = "ID"
        cboCompraProducto.DisplayMember = "Display"

        tablaProductos = spTiposProductos.devolver_TiposProductos_No_enologicos(dtb)
        cboFinalTipoProductoFinal.DataSource = OldLib.HacerTablasNoObligatorias(tablaProductos)
        cboFinalTipoProductoFinal.ValueMember = "ID"
        cboFinalTipoProductoFinal.DisplayMember = "Display"

        spTiposProductos.cargar_ComboBox(cboAdicionProducto)
        'cboAdicionProducto.DataSource = OldLib.HacerTablasNoObligatorias(ctlTipPro.devolverTiposProductosPorDescripcion)
        'cboAdicionProducto.ValueMember = "ID"
        'cboAdicionProducto.DisplayMember = "Display"

        ctlFil.cargar_Filtros(cbFiltros)
        'cbFiltros.DataSource = OldLib.HacerTablasNoObligatorias(ctlFil.devolverFiltros(dtb))
        'cbFiltros.ValueMember = "ID"
        'cbFiltros.DisplayMember = "Display"

        cboSalidaProducto.DataSource = OldLib.HacerTablasNoObligatorias(tablaProductos)
        cboSalidaProducto.ValueMember = "ID"
        cboSalidaProducto.DisplayMember = "Display"

        Dim tablaTodosProductos As DataTable = spTiposProductos.devolver_TiposProductos(dtb)  'ctlTipPro.DevolverTiposProductos
        'cboPartidaTipoProducto.DataSource = OldLib.HacerTablasObligatorias(tablaTodosProductos)
        'cboPartidaTipoProducto.ValueMember = "ID"
        'cboPartidaTipoProducto.DisplayMember = "Display"

        tablaTodosProductos = spTiposProductos.devolver_TiposProductos(dtb)
        cboDiferenciaProducto.DataSource = OldLib.HacerTablasNoObligatorias(tablaTodosProductos)
        cboDiferenciaProducto.ValueMember = "ID"
        cboDiferenciaProducto.DisplayMember = "Display"

        spRecipientesSalidas.cargar_RecipientesSalidas(cboSalidaRecipiente)
        'cboSalidaRecipiente.DataSource = OldLib.HacerTablasNoObligatorias(ctlRecSal.devolverRecipientesSalidas)
        'cboSalidaRecipiente.ValueMember = "ID"
        'cboSalidaRecipiente.DisplayMember = "Display"

        cboSalidaTransicubas.DataSource = OldLib.HacerTablasNoObligatorias(ctlDep.devolverTransicubasActivas(dtb))
        cboSalidaTransicubas.ValueMember = "ID"
        cboSalidaTransicubas.DisplayMember = "Display"

        Posicion = Pos
        ctlMov.SetMovimientoID(MovimientoID)

        dtpFecha.Value = Fecha
        cboProceso.Text = ProcesoI
        cboPartidaDepositoID.Text = SaleDepositoID
        cboFinalDepositoID.Text = EntraDepositoID
        txtCantidad.Text = Cantidad.ToString
        txtObservaciones.Text = Observaciones
        'cboAjusteLotes.Text = LoteID
    End Sub

    Private Sub frmEntMovimientos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.dboTiposLotes = spTiposLotes.DevolverPorDescripcion(DESCRIPCION_TIPO_LOTE_RECEPCION, dtb)
        If dboTiposLotes Is Nothing Then
            messagebox.show("Por favor verificar que exista el tipo de lote 'Recepcion'", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If dboTiposLotes.ID = 0 Then
                messagebox.show("Por favor verificar que exista el tipo de lote 'Recepcion'", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If


        Me.dboTiposLotes = spTiposLotes.DevolverPorDescripcion(DESCRIPCION_TIPO_LOTE_DEHECHOS, dtb)
        If dboTiposLotes Is Nothing Then
            messagebox.show("Por favor verificar que exista el tipo de lote 'Agua lavado'", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If dboTiposLotes.ID = 0 Then
                messagebox.show("Por favor verificar que exista el tipo de lote 'Agua lavado'", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If


        ModificarBindingNavigator()
        If Me.Text.Substring(0, 3) = "Ver" Then
            ctlMov.mostrarTodosMovimientos(dtsMov, dtb)
            GeneralBindingSource.DataSource = dtsMov
            GeneralBindingSource.Position = Posicion
        End If

        butGuardar.Visible = False
        bandera = True
        banderaCantidadMover = True
    End Sub


    Private Sub cboProceso_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProceso.SelectedIndexChanged
        If Convert.ToString(cboProceso.SelectedValue) <> "System.Data.DataRowView" Then
            If Not cboProceso.SelectedValue Is Nothing Then
                Try
                    cboTipoLoteCompra.Enabled = True

                    If CType(cboProceso.SelectedValue, Integer) = 0 Then
                        gbPartida.Visible = False
                        gbLotes.Visible = False
                        gbFinal.Visible = False
                        gbCompra.Visible = False
                        gbDiferencias.Visible = False
                        gbSalidas.Visible = False
                    End If

                    chbSumaEnologico.Checked = True
                    cbFiltros.SelectedValue = 0
                    lblFiltros.Visible = False
                    cbFiltros.Visible = False
                    cboTipoLoteCompra.Visible = False
                    lblProcesoCompra.Visible = False

                    'Set Procesos.ProcesoID 
                    Dim procid As Integer = Convert.ToInt32(cboProceso.SelectedValue)
                    ctlPro.SetProcesoID(procid)
                    'Asigno las valores dependiendo del Proceso a cada una de las variables
                    'Estoy confundiendo Procesos con TiposMovimientos
                    'La tabla Procesos en Solution Explorer esta en MovimientosElaboracion->Tipos movimientos
                    'En el menu principal se mantiene desde Bodega->Movimientos->Tipos movimientos.
                    ctlPro.cargarProceso(TipodProductoParaLote, TipoMovimiento, TipoLoteID, ConMuestra, dtb)

                    spTiposProductos.cargar_ComboBox_No_enologicos(cboFinalTipoProductoFinal)
                    'cboFinalTipoProductoFinal.DataSource = OldLib.HacerTablasObligatorias(ctlTipPro.devolverTiposProductosPorDescripcionNoEnologicos())
                    'cboFinalTipoProductoFinal.ValueMember = "ID"
                    'cboFinalTipoProductoFinal.DisplayMember = "Display"

                    If TipoLoteID = 0 Then
                        cboTipoLoteCompra.Visible = True
                        lblProcesoCompra.Visible = True
                    End If

                    Select Case TipoMovimiento
                        Case "D"
                            'TipoMovimiento = "Diferencias"
                            gbPartida.Visible = True
                            gbLotes.Visible = False
                            gbFinal.Visible = False
                            gbCompra.Visible = False
                            gbDiferencias.Visible = True
                            gbSalidas.Visible = False
                            cboDiferenciasTipoLote.SelectedValue = TipoLoteID
                            cboTipoLoteCompra.Enabled = False
                        Case "J"
                            'TipoMovimiento = "Ajuste"
                            MessageBox.Show("No hay ajustes", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Case "A"
                            'TipoMovimiento = "Adicion"
                            gbPartida.Visible = False
                            gbLotes.Visible = True
                            gbFinal.Visible = True
                            gbCompra.Visible = False
                            gbDiferencias.Visible = False
                            gbSalidas.Visible = False
                            cboAjusteLotes.DataSource = OldLib.HacerTablasObligatorias(ctlLot.devolverLotesEnologicosParaMovimientoPorProceso(Convert.ToInt32(cboProceso.SelectedValue), dtb))
                            cboAjusteLotes.ValueMember = "ID"
                            cboAjusteLotes.DisplayMember = "Display"
                            spTiposProductos.cargar_ComboBox_datos_completos(cboFinalTipoProductoFinal)
                            'cboFinalTipoProductoFinal.DataSource = OldLib.HacerTablasObligatorias(ctlTipPro.DevolverTiposProductos())
                            'cboFinalTipoProductoFinal.ValueMember = "ID"
                            'cboFinalTipoProductoFinal.DisplayMember = "Display"
                            chbConMuestra.Checked = ConMuestra
                        Case "E"
                            'TipoMovimiento = "Entrada"
                            gbPartida.Visible = False
                            gbLotes.Visible = False
                            gbFinal.Visible = True
                            gbCompra.Visible = True
                            gbSalidas.Visible = False
                            gbDiferencias.Visible = False
                            gbSalidas.Visible = False
                            GenerarCodigoLoteCompra()
                            chbConMuestra.Checked = ConMuestra
                        Case "S"
                            'TipoMovimiento = "Salida". Envasado
                            gbPartida.Visible = True
                            gbLotes.Visible = False
                            gbFinal.Visible = False
                            gbCompra.Visible = False
                            gbDiferencias.Visible = False
                            gbSalidas.Visible = True
                            chbSalidaMuestra.Checked = ConMuestra

                            If spTiposLotes.Select_Record(TipoLoteID, dtb).Abreviatura.ToUpper = ABREVIATURA_TIPO_LOTE_ENVASADO Then
                                txtSalidaCantidadReal.Visible = True
                                lblSalidaCantidadReal.Visible = True
                                cboSalidaRecipiente.Visible = False
                                lblSalidasRecipientes.Visible = False
                            Else
                                txtSalidaCantidadReal.Visible = False
                                lblSalidaCantidadReal.Visible = False
                                cboSalidaRecipiente.Visible = True
                                lblSalidasRecipientes.Visible = True
                            End If
                        Case "T"
                            'TipoMovimiento = "Trasiego"
                            gbPartida.Visible = True
                            gbLotes.Visible = False
                            gbFinal.Visible = True
                            gbCompra.Visible = False
                            gbDiferencias.Visible = False
                            gbSalidas.Visible = False
                            chbConMuestra.Checked = ConMuestra
                        Case "M"
                            'TipoMovimiento = "Macerado"
                            gbPartida.Visible = False
                            gbLotes.Visible = True
                            gbFinal.Visible = True
                            gbCompra.Visible = False
                            chbSumaEnologico.Checked = False
                            gbDiferencias.Visible = False
                            gbSalidas.Visible = False
                            cboAjusteLotes.DataSource = OldLib.HacerTablasObligatorias(ctlLot.devolverLotesEnologicosParaMovimientoPorProceso(Convert.ToInt32(cboProceso.SelectedValue), dtb))
                            cboAjusteLotes.ValueMember = "ID"
                            cboAjusteLotes.DisplayMember = "Display"
                            chbConMuestra.Checked = ConMuestra
                        Case "F"
                            'TipoMovimiento = "Filtrado"
                            chbFiltroDeshechos.Checked = False
                            gbPartida.Visible = True
                            gbLotes.Visible = False
                            gbFinal.Visible = True
                            gbCompra.Visible = False
                            gbSalidas.Visible = False
                            gbDiferencias.Visible = False
                            lblFiltros.Visible = True
                            cbFiltros.Visible = True
                            chbConMuestra.Checked = ConMuestra
                    End Select

                    'Select Case tabla.Rows(i).Item(2)
                    '    Case "I"
                    '        reg.TipoProductoParaLote = "Hay que introducirlo"
                    '    Case "H"
                    '        reg.TipoProductoParaLote = "Lo hereda"
                    '    Case "D"
                    '        reg.TipoProductoParaLote = "Depende del producto inicial"
                    'End Select

                    cboPartidaDepositoID.SelectedValue = 0

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

                If Not Me.butActualizar.Enabled Then Me.butActualizar.Enabled = True

                If Convert.ToInt32(Me.cboProceso.SelectedValue) = 8 Then
                    Me.cboTipoLoteCompra.Enabled = False
                Else
                    Me.cboTipoLoteCompra.Enabled = True
                End If
            Else
                Me.gbCompra.Visible = False
                Me.gbDiferencias.Visible = False
                Me.gbFinal.Visible = False
                Me.gbLotes.Visible = False
                Me.gbPartida.Visible = False
                Me.gbSalidas.Visible = False
            End If
        Else
            Me.gbCompra.Visible = False
            Me.gbDiferencias.Visible = False
            Me.gbFinal.Visible = False
            Me.gbLotes.Visible = False
            Me.gbPartida.Visible = False
            Me.gbSalidas.Visible = False
        End If


    End Sub


    Private Sub cboProcesoCompra_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoLoteCompra.SelectedValueChanged
        If Convert.ToString(cboTipoLoteCompra.SelectedValue) <> "System.Data.DataRowView" Then
            If Not cboTipoLoteCompra.SelectedValue Is Nothing Then
                Dim tipoLot As Integer = Convert.ToInt32(cboTipoLoteCompra.SelectedValue)
                TipoLoteCompraID = tipoLot
                TipoLoteID = tipoLot
                TipoMovimientoCompra = "T"
                TipodProductoParaLote = "I"
            End If
        End If
        generarLoteProcesoCompra()

    End Sub


    Private Sub PartidaDepositoIDComboMAM_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPartidaDepositoID.SelectedValueChanged
        If Convert.ToString(cboPartidaDepositoID.SelectedValue) <> "System.Data.DataRowView" Then
            If Not cboPartidaDepositoID.SelectedValue Is Nothing Then
                Try
                    Dim DepositoID As Integer = Convert.ToInt32(cboPartidaDepositoID.SelectedValue)
                    ctlLot.CargarParaMovimiento(DepositoID, LotePartidaID, txtPartidaLoteActual.Text, Convert.ToInt32(cboPartidaTipoProducto.SelectedValue), txtPartidaDescripcion.Text, txtPartidaObservacion.Text, txtPartidaCantidadActual.Text, dtb)
                    cboPartidaTipoProducto.SelectedValue = ctlLot.Controlador_Lote._TipoProductoID

                    If cboPartidaDepositoID.SelectedValue Is cboFinalDepositoID.SelectedValue And gbFinal.Visible And gbPartida.Visible Then
                        txtCantidad.Text = txtFinalCantidadActual.Text
                    Else
                        txtCantidad.Text = "0"
                    End If

                    If TipodProductoParaLote = "H" Then
                        cboFinalTipoProductoFinal.SelectedIndex = 1
                        cboFinalTipoProductoFinal.SelectedValue = cboPartidaTipoProducto.SelectedValue
                    End If

                    RefrescarCantidadAmover()

                    If TipodProductoParaLote = "H" Then
                        cboSalidaProducto_SelectedValueChanged(Nothing, Nothing)
                    End If
                    cboPartidaTipoProducto_SelectedValueChanged(Nothing, Nothing)
                Catch ex As Exception
                    MessageBox.Show("No se pudo recuperar la informacion del lote")
                End Try
            End If
        End If
    End Sub


    Private Sub FinalDepositoIDComboMAM_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFinalDepositoID.SelectedValueChanged
        If Convert.ToString(cboFinalDepositoID.SelectedValue) <> "System.Data.DataRowView" Then
            If Not cboFinalDepositoID.SelectedValue Is Nothing Then
                Try

                    Dim DepositoID As Integer = Convert.ToInt32(cboFinalDepositoID.SelectedValue)
                    ctlLot.CargarParaMovimiento(DepositoID, LoteFinalID, txtFinalLoteActual.Text, Convert.ToInt32(cboFinalTipoProductoActual.SelectedValue), _
                                                txtFinalDescripcionActual.Text, txtFinalObservacionActual.Text, txtFinalCantidadActual.Text, dtb)

                    ctlDep.SetDepositoID(DepositoID)
                    ctlDep.CargarDepositos(dtb)
                    Capacidad = ctlDep.devolverCapacidadDeposito()
                    cboFinalTipoProductoActual.SelectedValue = ctlLot.Controlador_Lote._TipoProductoID ' experimental

                    If (LoteFinalID = 0) Then
                        chbNuevoLote.Checked = True
                    End If

                    If Not chbNuevoLote.Checked Then
                        txtFinalLoteFinal.Text = txtFinalLoteActual.SelectedText
                        cboFinalTipoProductoFinal.SelectedValue = cboFinalTipoProductoActual.SelectedValue
                    End If

                    If gbCompra.Visible Then
                        cboFinalTipoProductoFinal.SelectedValue = cboCompraProducto.SelectedValue
                        chbNuevoLote.Checked = True
                    End If

                    If cboPartidaDepositoID.SelectedValue Is cboFinalDepositoID.SelectedValue And gbFinal.Visible And gbPartida.Visible Then
                        txtCantidad.Text = txtFinalCantidadActual.Text
                    Else
                        txtCantidad.Text = "0"
                    End If
                    Dim aux As Integer
                    RefrescarCantidadAmover()

                    If TipoMovimiento = "E" Then
                        aux = Convert.ToInt32(cboCompraProducto.SelectedValue)
                        cboCompraProducto.SelectedValue = 999
                        cboCompraProducto.SelectedValue = aux
                    End If

                Catch ex As Exception
                    MessageBox.Show("Error final deposito." & ex.Message)
                End Try

                Try
                    If Convert.ToInt32(Me.cboProceso.SelectedValue) = 8 Then
                        Dim dtb As New DataBase(Config.Server)
                        Dim dt As DataTable = dtb.Consultar("select tipoloteid from lotes where codigoLote = '" & txtFinalLoteActual.Text & "'", False)
                        If Not dt Is Nothing Then
                            cboTipoLoteCompra.SelectedValue = dt.Rows(0).Item(0)
                        End If
                    End If
                Catch ex As Exception
                End Try
            End If
        End If
    End Sub

    Private Sub RefrescarCantidadAmover()
        Try
            If TipodProductoParaLote = "H" Then
                cboFinalTipoProductoFinal.SelectedValue = cboPartidaTipoProducto.SelectedValue
                cboFinalTipoProductoFinal.Enabled = False
            End If

            If TipodProductoParaLote = "I" Then
                cboFinalTipoProductoFinal.Enabled = True
            End If

            If TipodProductoParaLote = "D" Then
                cboFinalTipoProductoFinal.SelectedValue = cboFinalTipoProductoActual.SelectedValue
                cboFinalTipoProductoFinal.Enabled = False
                txtDiferenciasCodigoLote.Text = codigoLote.GenerarCodigoDiferencias(dtpFecha.Value, Convert.ToInt32(cboDiferenciaProducto.SelectedValue), TipoLoteID, dtb)
            End If

            Dim CantPartidaActual As Double = Convert.Todouble(txtPartidaCantidadActual.Text)
            Dim CantAMover As Double = Convert.Todouble(txtCantidad.Text)
            Dim CantFinalActual As Double = Convert.Todouble(txtFinalCantidadActual.Text)

            If bandera Then
                If gbPartida.Visible Then
                    If CantPartidaActual = 0 Then

                        If Convert.ToInt32(cboPartidaDepositoID.SelectedValue) > 0 Then
                            MessageBox.Show("Por favor seleccionar un deposito valido", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End If

                    ElseIf cboPartidaDepositoID.SelectedValue Is cboFinalDepositoID.SelectedValue And gbFinal.Visible And gbPartida.Visible Then
                        txtFinalCantidadFinal.Text = CantFinalActual.ToString
                    Else
                        If gbLotes.Visible Then
                            If chbSumaEnologico.Checked Then
                                txtFinalCantidadFinal.Text = (CantFinalActual + CantAMover).ToString
                            Else
                                txtFinalCantidadFinal.Text = CantFinalActual.ToString
                            End If
                        Else
                            If (CantAMover <= CantPartidaActual) Then
                                txtFinalCantidadFinal.Text = (CantFinalActual + CantAMover).ToString
                            Else
                                messagebox.show("La cantidad maxima para mover es de : " & CantPartidaActual, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            End If
                        End If
                    End If

                End If
            End If

            GenerarCodigoLote()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub guardar_movimiento()
        'autodiferencia = False

        If CType(Me.cboProceso.SelectedValue, Integer) = 4 Then
            If Not Convert.ToInt32(cboPartidaTipoProducto.SelectedValue) = Convert.ToInt32(cboSalidaProducto.SelectedValue) Then
                MessageBox.Show("Productos distintos")
                Return
            End If
        End If

        dtb.EmpezarTransaccion()
        Try
            MOVER()
            dtb.TerminarTransaccion()
            messagebox.show("Movimiento Correcto", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.reiniciar()
        Catch ex As Exception
            dtb.CancelarTransaccion()
            bandera = True
            messagebox.show("Error: " & ex.Message)
            'reiniciar()
        End Try
    End Sub

    Sub MOVER()

        If TipoMovimiento = "E" Then
            'guardar movimiento de entrada
            If If(txtCompraCantidad.Text = "" Or IsDBNull(txtCompraCantidad.Text), 0, Convert.Todouble(txtCompraCantidad.Text)) <> 0 Then
                If LoteCompraID > 0 Then
                    Dim LoteID As Integer = ctlLot.guardarLoteDesdeMovimiento(LoteCompraID, LoteFinalID, txtFinalLoteFinal.Text, (Convert.ToDouble(txtCompraCantidad.Text) - Convert.ToDouble(txtCantidad.Text)), _
                                                                              dtpFecha.Value, Convert.ToDouble(txtFinalCantidadFinal.Text), Convert.ToInt32(cboFinalDepositoID.SelectedValue), _
                                                                              Convert.ToInt32(cboFinalTipoProductoFinal.SelectedValue), TipoLoteID, chbNuevoLote.Checked, txtCompraDescripcion.Text, txtCompraObservacion.Text, chbConMuestra.Checked, 0, 0, dtb)

                    If LoteID > 0 Then
                        If Not ctlMov.GuardarMovimiento(dtpFecha.Value, txtObservaciones.Text, _
                                                    Convert.ToDouble(txtCantidad.Text), Convert.ToInt32(cboProceso.SelectedValue), _
                                                    Convert.ToInt32(cboFinalDepositoID.SelectedValue), 0, 0, 0, chbSumaEnologico.Checked, _
                                                    chbNuevoLote.Checked, dtb) Then

                            Throw New Exception("Error al guardar el movimiento")
                        End If

                        If ctlMov.GetMovimientoID > 0 Then
                            If Not ctlComPor.GuardarCompuestoPor(LoteID, LoteCompraID, ctlMov.GetMovimientoID, Convert.ToDouble(txtCantidad.Text), dtb) Then
                                Throw New Exception("Error al guardar la trazabilidad del lote compra")
                            End If

                            If LoteFinalID > 0 And chbNuevoLote.Checked Then
                                If Not ctlComPor.GuardarCompuestoPor(LoteID, LoteFinalID, ctlMov.GetMovimientoID, Convert.ToDouble(txtFinalCantidadActual.Text), dtb) Then
                                    Throw New Exception("Error al guardar la trazabilidad del lote final")
                                End If
                            End If
                            'messagebox.show("Movimiento Correcto", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            txtCompraCantidad.Text = (Convert.Todouble(txtCompraCantidad.Text) - Convert.Todouble(txtCantidad.Text)).ToString

                            If txtCompraCantidad.Text = "0" Then
                                LoteCompraID = 0
                            End If

                            Dim findep As Integer = Convert.ToInt32(cboFinalDepositoID.SelectedValue)
                            Dim partdep As Integer = Convert.ToInt32(cboPartidaDepositoID.SelectedValue)
                            txtCantidad.Text = "0"
                            cboFinalDepositoID.DataSource = OldLib.HacerTablasObligatorias(ctlDep.devolverDepositosFinales(dtb))
                            cboFinalDepositoID.ValueMember = "ID"
                            cboFinalDepositoID.DisplayMember = "Display"
                            cboFinalDepositoID.SelectedValue = findep
                            cboPartidaDepositoID.DataSource = OldLib.HacerTablasObligatorias(ctlDep.devolverDepositosPartidas(dtb))
                            cboPartidaDepositoID.ValueMember = "ID"
                            cboPartidaDepositoID.DisplayMember = "Display"
                            cboPartidaDepositoID.SelectedValue = partdep
                            ctlMov = New ctlMovimientos
                        Else
                            Throw New Exception("No se pudo guardar el movimiento")
                        End If
                    Else
                        Throw New Exception("No se pudo guardar el lote")
                    End If
                Else
                    Dim response As DialogResult = MessageBox.Show("Se creara un nuevo lote de compra, desea proceder ?", " Movimiento ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If response = DialogResult.Yes Then
                        'crear lote de compra
                        Me.dboTiposLotes = spTiposLotes.DevolverPorDescripcion(DESCRIPCION_TIPO_LOTE_RECEPCION, dtb)
                        If Not ctlLot.GuardarLoteCompra(Convert.ToInt32(cboCompraProducto.SelectedValue), dboTiposLotes.ID, Convert.ToInt32(cboCompraProveedor.SelectedValue), Convert.ToDouble(txtCompraCantidad.Text), dtpFecha.Value, txtCompraLote.Text, txtCompraDescripcion.Text, txtCompraObservacion.Text, dtb) Then
                            Throw New Exception("Error al guardar el lote compra")
                        End If

                        LoteCompraID = ctlLot.LoteId
                        ' txtFinalLoteFinal.Text = txtFinalLoteFinal.Text
                        If LoteCompraID > 0 Then
                            Dim LoteID As Integer = ctlLot.guardarLoteDesdeMovimiento(LoteCompraID, LoteFinalID, txtFinalLoteFinal.Text, _
                                                                                      Convert.ToDouble(txtCompraCantidad.Text) - Convert.ToDouble(txtCantidad.Text), _
                                                                                      dtpFecha.Value, Convert.ToDouble(txtFinalCantidadFinal.Text), _
                                                                                      Convert.ToInt32(cboFinalDepositoID.SelectedValue), Convert.ToInt32(cboFinalTipoProductoFinal.SelectedValue), _
                                                                                      TipoLoteID, chbNuevoLote.Checked, txtFinalDescripcionFinal.Text, txtFinalObservacionFinal.Text, chbConMuestra.Checked, 0, 0, dtb)

                            If LoteID > 0 Then
                                If Not ctlMov.GuardarMovimiento(dtpFecha.Value, txtObservaciones.Text, Convert.ToDouble(txtCantidad.Text), _
                                                                Convert.ToInt32(cboProceso.SelectedValue), Convert.ToInt32(cboFinalDepositoID.SelectedValue), _
                                                                0, 0, 0, chbSumaEnologico.Checked, chbNuevoLote.Checked, dtb) Then
                                    Throw New Exception("Error al guardar el movimiento del nuevo lote compra")
                                End If

                                If ctlMov.GetMovimientoID > 0 Then
                                    If Not ctlComPor.GuardarCompuestoPor(LoteID, LoteCompraID, ctlMov.GetMovimientoID, Convert.ToDouble(txtCantidad.Text), dtb) Then
                                        Throw New Exception("Error al guardar la trazabilidad del lote compra")
                                    End If

                                    If LoteFinalID > 0 And chbNuevoLote.Checked Then
                                        If Not ctlComPor.GuardarCompuestoPor(LoteID, LoteFinalID, ctlMov.GetMovimientoID, Convert.ToDouble(txtFinalCantidadActual.Text), dtb) Then
                                            Throw New Exception("Error al guardar la trabilidad del lote final")
                                        End If
                                    End If
                                    'messagebox.show("Movimiento Correcto", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                    Me.Close()
                                Else
                                    Throw New Exception("Error al guardar el movimiento del nuevo lote compra")
                                End If
                            Else
                                Throw New Exception("Error al guardar el nuevo lote compra")
                            End If
                        Else
                            Throw New Exception("Error al gaurdar el lote compra")
                        End If
                    End If
                End If
                If txtCompraCantidad.Text = "0" Then
                    Dim prodcom As Integer = Convert.ToInt32(cboCompraProducto.SelectedValue)
                    cboCompraProducto.SelectedValue = 0
                    cboCompraProducto.SelectedValue = prodcom
                End If
            Else
                Throw New Exception("No se pudo llevar a cabo el movimiento, no hay Litros a mover")
            End If
        Else ' If TipoMovimiento = "E" Then
            'guardar movimiento de trasiego
            If TipoMovimiento = "F" And Convert.ToInt32(cbFiltros.SelectedValue) = 0 Then
                Throw New Exception("Por favor seleccionar el filtro.")
                Return
            End If
            Dim LoteID As Integer

            If TipoMovimiento = "S" Then
                If txtSalidaCantidadReal.Visible Then 'Es un lote de Envasado, si es Envasado Se guarda txtSalidaCantidadReal de lo contrario se guarda txtSalidaCantidad
                    If If(txtSalidaCantidadReal.Text = "" Or IsDBNull(txtSalidaCantidadReal.Text), 0, Convert.Todouble(txtSalidaCantidadReal.Text)) > 0 Then
                        LoteID = ctlLot.guardarLoteDesdeMovimiento(LotePartidaID _
                                                                    , 0 _
                                                                    , txtSalidaCodigoLote.Text _
                                                                    , (Convert.ToDouble(txtPartidaCantidadActual.Text) - Convert.ToDouble(txtSalidaCantidadReal.Text)) _
                                                                    , dtpFecha.Value _
                                                                    , Convert.ToDouble(txtSalidaCantidadReal.Text) _
                                                                    , 0 _
                                                                    , Convert.ToInt32(cboSalidaProducto.SelectedValue) _
                                                                    , TipoLoteID _
                                                                    , True _
                                                                    , txtSalidaDescripcion.Text _
                                                                    , txtSalidaObservacion.Text _
                                                                    , chbSalidaMuestra.Checked _
                                                                    , Convert.ToInt32(cboSalidaRecipiente.SelectedValue) _
                                                                    , Convert.ToInt32(cboSalidaTransicubas.SelectedValue), dtb)

                        If LoteID = 0 Then
                            Throw New Exception("Error al guardar los datos del lote")
                        End If
                    Else
                        Throw New Exception("Por favor seleccionar la cantidad real del movimiento.")
                        Return
                    End If
                Else
                    'Hace los graneles al reves, cambiado partida y salida
                    LoteID = ctlLot.guardarLoteDesdeMovimiento(LotePartidaID _
                                                                , 0 _
                                                                , txtSalidaCodigoLote.Text _
                                                                , Convert.ToDouble(txtPartidaCantidadActual.Text) - Convert.ToDouble(If(txtSalidaCantidad.Text = "", txtCantidad.Text, txtSalidaCantidad.Text)) _
                                                                , dtpFecha.Value _
                                                                , Convert.ToDouble(If(txtSalidaCantidad.Text = "", txtCantidad.Text, txtSalidaCantidad.Text)) _
                                                                , 0 _
                                                                , Convert.ToInt32(cboSalidaProducto.SelectedValue) _
                                                                , TipoLoteID _
                                                                , True _
                                                                , txtSalidaDescripcion.Text _
                                                                , txtSalidaObservacion.Text _
                                                                , chbSalidaMuestra.Checked _
                                                                , Convert.ToInt32(cboSalidaRecipiente.SelectedValue) _
                                                                , Convert.ToInt32(cboSalidaTransicubas.SelectedValue), dtb)

                    If LoteID = 0 Then
                        Throw New Exception("Error al guardar el lote")
                    End If
                End If

            ElseIf TipoMovimiento = "A" Or TipoMovimiento = "M" Then
                LoteID = ctlLot.guardarLoteDesdeMovimiento(Convert.ToInt32(cboAjusteLotes.SelectedValue), LoteFinalID, txtFinalLoteFinal.Text, _
                                                           Convert.ToDouble(txtAjusteCantidadActual.Text) - Convert.ToDouble(txtCantidad.Text), _
                                                           dtpFecha.Value, Convert.ToDouble(txtFinalCantidadFinal.Text), Convert.ToInt32(cboFinalDepositoID.SelectedValue), _
                                                           Convert.ToInt32(cboFinalTipoProductoFinal.SelectedValue), TipoLoteID, chbNuevoLote.Checked, _
                                                           txtFinalDescripcionFinal.Text, txtFinalObservacionFinal.Text, chbConMuestra.Checked, 0, 0, dtb)
                If LoteID = 0 Then
                    Throw New Exception("Error al guardar el lote")
                End If
            ElseIf TipoMovimiento = "D" Then
                LoteID = ctlLot.guardarLoteDesdeMovimiento(LotePartidaID, DiferenciasLoteID, txtDiferenciasCodigoLote.Text, _
                                                           Convert.ToDouble(txtPartidaCantidadActual.Text) - Convert.ToDouble(txtCantidad.Text), _
                                                           dtpFecha.Value, Convert.ToDouble(txtDiferenciasCantidadFinal.Text), 0, Convert.ToInt32(cboDiferenciaProducto.SelectedValue), _
                                                           TipoLoteID, DiferenciasLoteID = 0, txtDiferenciasDescripcionFinal.Text, txtdiferenciaObservaciones.Text, False, 0, 0, dtb)
                If LoteID = 0 Then
                    Throw New Exception("Error al guardar el lote")
                End If
            Else 'tipoproducto 0
                LoteID = ctlLot.guardarLoteDesdeMovimiento(LotePartidaID, LoteFinalID, txtFinalLoteFinal.Text, Convert.ToDouble(txtPartidaCantidadActual.Text) - Convert.ToDouble(txtCantidad.Text), _
                                                           dtpFecha.Value, Convert.ToDouble(txtFinalCantidadFinal.Text), Convert.ToInt32(cboFinalDepositoID.SelectedValue), _
                                                           Convert.ToInt32(cboFinalTipoProductoFinal.SelectedValue), TipoLoteID, chbNuevoLote.Checked, _
                                                           txtFinalDescripcionFinal.Text, txtFinalObservacionFinal.Text, chbConMuestra.Checked, 0, 0, dtb)
                If LoteID = 0 Then
                    Throw New Exception("Error al guardar el lote")
                End If
            End If

            If LoteID > 0 Then
                If TipoMovimiento = "S" Then
                    If txtSalidaCantidadReal.Visible Then
                        If Not ctlMov.GuardarMovimiento(dtpFecha.Value _
                                                    , txtObservaciones.Text _
                                                    , Convert.ToDouble(txtSalidaCantidadReal.Text) _
                                                    , Convert.ToInt32(cboProceso.SelectedValue) _
                                                    , 0 _
                                                    , Convert.ToInt32(cboPartidaDepositoID.SelectedValue) _
                                                    , 0 _
                                                    , 0 _
                                                    , chbSumaEnologico.Checked, _
                                                    chbNuevoLote.Checked, dtb) Then

                            Throw New Exception("Error guardando el movimiento")
                        End If
                    Else
                        If Not ctlMov.GuardarMovimiento(dtpFecha.Value, txtObservaciones.Text, Convert.ToDouble(txtCantidad.Text), Convert.ToInt32(cboProceso.SelectedValue), 0, _
                                                    Convert.ToInt32(cboPartidaDepositoID.SelectedValue), 0, 0, chbSumaEnologico.Checked, chbNuevoLote.Checked, dtb) Then
                            Throw New Exception("Error guardando el movimiento")
                        End If
                    End If

                ElseIf TipoMovimiento = "A" Or TipoMovimiento = "M" Then
                    If Not ctlMov.GuardarMovimiento(dtpFecha.Value, txtObservaciones.Text, Convert.ToDouble(txtCantidad.Text), Convert.ToInt32(cboProceso.SelectedValue),
                                                Convert.ToInt32(cboFinalDepositoID.SelectedValue), 0, Convert.ToInt32(cboAjusteLotes.SelectedValue), 0, _
                                                chbSumaEnologico.Checked, chbNuevoLote.Checked, dtb) Then
                        Throw New Exception("Error guardando el movimiento")
                    End If
                    LotePartidaID = Convert.ToInt32(cboAjusteLotes.SelectedValue)
                ElseIf TipoMovimiento = "D" Then
                    If Not ctlMov.GuardarMovimiento(dtpFecha.Value.Date, txtObservaciones.Text, Convert.ToDouble(txtCantidad.Text), Convert.ToInt32(cboProceso.SelectedValue), _
                                                                   0, Convert.ToInt32(cboPartidaDepositoID.SelectedValue), 0, 0, True, (DiferenciasLoteID = 0), dtb) Then
                        Throw New Exception("Error guardando el movimiento")
                    End If

                    Dim mov As Integer = ctlMov.GetMovimientoID
                    If mov = 0 Then
                        Throw New Exception("Error guardando el movimiento")
                    End If

                    If Not dtb.ConsultaAlteraciones("update movimientos set lotesaleid=" & LoteID & " where movimientoid=" & mov) Then
                        Throw New Exception("Error actualizando el movimiento")
                    End If
                Else
                    If Not ctlMov.GuardarMovimiento(dtpFecha.Value, txtObservaciones.Text, Convert.ToDouble(txtCantidad.Text), _
                                                Convert.ToInt32(cboProceso.SelectedValue), Convert.ToInt32(cboFinalDepositoID.SelectedValue), _
                                                Convert.ToInt32(cboPartidaDepositoID.SelectedValue), 0, Convert.ToInt32(cbFiltros.SelectedValue), _
                                                chbSumaEnologico.Checked, chbNuevoLote.Checked, dtb) Then
                        Throw New Exception("Error guardando el movimiento")
                    End If
                End If

                If ctlMov.GetMovimientoID > 0 Then
                    If TipoMovimiento = "D" And Convert.ToDouble(txtCantidad.Text) < 0 Then
                        If Not ctlComPor.GuardarCompuestoPor(LotePartidaID, LoteID, ctlMov.GetMovimientoID, Convert.ToDouble(txtCantidad.Text) * (-1), dtb) Then
                            Throw New Exception("Error al guardar la trazabilidad del lote")
                        End If
                    Else

                        If TipoMovimiento = "S" And txtSalidaCantidadReal.Visible Then
                            If Not ctlComPor.GuardarCompuestoPor(LoteID _
                                                            , LotePartidaID _
                                                            , ctlMov.GetMovimientoID _
                                                            , Convert.ToDouble(txtSalidaCantidadReal.Text), dtb) Then
                                Throw New Exception("Error al guardar la trazabilidad del lote")
                            End If
                        Else
                            If Not ctlComPor.GuardarCompuestoPor(LoteID, LotePartidaID, ctlMov.GetMovimientoID, Convert.ToDouble(txtCantidad.Text), dtb) Then
                                Throw New Exception("Error al guardar la trazabilidad del lote")
                            End If
                        End If

                        If LoteFinalID > 0 And chbNuevoLote.Checked And Not cboPartidaDepositoID.SelectedValue Is cboFinalDepositoID.SelectedValue Then
                            If Not ctlComPor.GuardarCompuestoPor(LoteID, LoteFinalID, ctlMov.GetMovimientoID, Convert.ToDouble(txtFinalCantidadActual.Text), dtb) Then
                                Throw New Exception("Error al guardar la trazabilidad del lote final")
                            End If
                        End If
                    End If

                    Dim cant1, cant2 As Double
                    If TipoMovimiento = "S" And txtSalidaCantidadReal.Visible Then
                        cant1 = Convert.ToDouble(txtSalidaCantidadReal.Text)
                        cant2 = Convert.ToDouble(txtCantidad.Text)

                        If (cant1 < cant2) Then
                            ctlMov = New ctlMovimientos
                            Dim depPar As Integer = Convert.ToInt32(cboPartidaDepositoID.SelectedValue)
                            Dim cant As Double = Convert.ToDouble(txtCantidad.Text) - Convert.ToDouble(txtSalidaCantidadReal.Text)
                            bandera = False
                            txtCantidad.Text = "0"
                            cboProceso.Text = DESCRIPCION_PROCESO_DIFERENCIAS
                            'Me.autodiferencia = True

                            If cboProceso.Text = DESCRIPCION_PROCESO_DIFERENCIAS Then
                                cboPartidaDepositoID.SelectedValue = depPar
                                bandera = True
                                txtCantidad.Text = cant.ToString
                                bandera = False
                                txtObservaciones.Text = "Diferencia de Envasado"
                                GenerarLoteDiferencias()
                                MOVER()
                                txtSalidaCantidadReal.Text = "0"
                                txtSalidaCantidad.Text = "0"
                                txtSalidaDescripcion.Text = ""
                                txtSalidaObservacion.Text = ""
                                bandera = True

                                Return
                            Else
                                MessageBox.Show("crear proceso de diferencias", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                Return
                            End If
                        Else
                            txtSalidaCantidadReal.Text = "0"
                            txtSalidaCantidad.Text = "0"
                            txtSalidaDescripcion.Text = ""
                            txtSalidaObservacion.Text = ""
                        End If
                    End If

                    'messagebox.show("Movimiento Correcto", "", MessageBoxButtons.OK, MessageBoxIcon.Information)                    
                    bandera = True
                Else
                    Throw New Exception("Error al gaurdar el movimiento")
                End If
            Else
                Throw New Exception("Error al guardar el lote")
            End If
        End If
    End Sub

    Private Sub reiniciar()
        'If autodiferencia = True Then
        '    return
        'End If

        Dim proceso As Integer = Convert.ToInt32(cboProceso.SelectedValue)
        txtPartidaLoteActual.Text = ""
        txtSalidaCodigoLote.Text = ""
        txtFinalLoteActual.Text = ""
        txtDiferenciasCodigoLote.Text = ""
        txtFinalLoteFinal.Text = ""
        txtCompraLote.Text = ""

        cboProceso.SelectedValue = 0
        'cboProceso.SelectedValue = proceso

        CargarDatos(0, 0, Today, 0, "", "0", "0", "0", "0", dtb)
        bandera = False
        Dim findep As Integer = Convert.ToInt32(cboFinalDepositoID.SelectedValue)
        Dim partdep As Integer = Convert.ToInt32(cboPartidaDepositoID.SelectedValue)

        txtCantidad.Text = "0"
        cboFinalDepositoID.DataSource = OldLib.HacerTablasNoObligatorias(ctlDep.devolverDepositosFinales(dtb))
        cboFinalDepositoID.ValueMember = "ID"
        cboFinalDepositoID.DisplayMember = "Display"
        'cboFinalDepositoID.SelectedValue = findep
        cbFiltros.SelectedValue = 0

        '''
        cboFinalDepositoID.SelectedValue = 0
        cboPartidaDepositoID.SelectedValue = 0
        ''''

        ctlMov = New ctlMovimientos
        ctlPro = New ctlProcesos
        ctlDep = New ctlDepositos
        ctlLot = New ctlLotes
        'ctlTipPro = New spTiposProductos
        spTiposLotes = New spTiposLotes
        dboTiposLotes = New DBO_TiposLotes
        ctlComPor = New ctlCompuestoPor

        ctlFil = New spFiltros

        codigoLote = New CodigoLote
        ctlMov = New ctlMovimientos
        LoteFinalID = 0
        Capacidad = 0
        TipoMovimientoCompra = ""
        TipoLoteCompraID = 0
        LotePartidaID = 0

        TipodProductoParaLote = ""
        TipoMovimiento = ""
        TipoLoteID = 0


        LoteCompraID = 0

        DiferenciasLoteID = 0



        If TipoMovimiento = "A" Or TipoMovimiento = "M" Then
            cboAjusteLotes.DataSource = OldLib.HacerTablasObligatorias(ctlLot.devolverLotesEnologicosParaMovimientoPorProceso(Convert.ToInt32(cboProceso.SelectedValue), dtb))
            cboAjusteLotes.ValueMember = "ID"
            cboAjusteLotes.DisplayMember = "Display"
        End If

        cboPartidaDepositoID.DataSource = OldLib.HacerTablasNoObligatorias(ctlDep.devolverDepositosPartidas(dtb))
        cboPartidaDepositoID.ValueMember = "ID"
        cboPartidaDepositoID.DisplayMember = "Display"
        'cboPartidaDepositoID.SelectedValue = partdep

        If TipoMovimiento = "D" Then
            DiferenciasLoteID = ctlLot.validarLoteDiferencia(txtDiferenciasCodigoLote.Text, Convert.ToDouble(txtDiferenciasCantidad.Text), txtDiferenciasDescripcion.Text, dtb)
            txtDiferenciasCantidadFinal.Text = "0"
        End If

        If TipoMovimiento = "S" Then
            txtSalidaCantidadReal.Text = "0"
            txtSalidaCantidad.Text = "0"
            txtSalidaDescripcion.Text = ""
            txtSalidaObservacion.Text = ""
        End If


        cboProceso.SelectedValue = proceso
    End Sub
    Private Sub butActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butActualizar.Click
        Try
            bandera = False
            If gbFinal.Visible Then
                Dim Cant As Double = Convert.Todouble(txtFinalCantidadFinal.Text)
                If Cant > Capacidad Then
                    messagebox.show("La cantidad Final supera la capacidad maxima de " & Capacidad & " litros del deposito " & cboFinalDepositoID.Text, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Try
                End If
            End If

            If TipoMovimiento = "S" And txtSalidaCantidadReal.Visible Then
                Dim Cant1 As Double = Convert.Todouble(txtCantidad.Text)
                Dim Cant2 As Double = Convert.Todouble(txtSalidaCantidadReal.Text)
                If Cant1 < Cant2 Then
                    messagebox.show("La cantidad real no pude ser mayor que la cantidad a transferir", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Try
                End If
            End If

            If TipoMovimiento <> "D" And Convert.ToDouble(txtCantidad.Text) < 0 Then
                MessageBox.Show("Solo las diferencias aceptan numeros negativos", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Try
            End If

            If TipoMovimiento <> "D" Then
                If (txtFinalLoteFinal.Text.Length = 15) Then
                    If If(txtCantidad.Text = "" Or IsDBNull(txtCantidad.Text), 0, Convert.Todouble(txtCantidad.Text)) <> 0 Then
                        If Not cboFinalTipoProductoFinal.SelectedValue Is cboFinalTipoProductoActual.SelectedValue And CType(cboFinalTipoProductoActual.SelectedValue, Integer) <> 0 Then
                            Dim response As DialogResult
                            response = MessageBox.Show("Se está pasando " & cboFinalTipoProductoActual.Text & " a " & cboFinalTipoProductoFinal.Text & ", desea proceder ?", " Movimiento ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            If response = DialogResult.Yes Then
                                guardar_movimiento()
                            End If
                        Else
                            guardar_movimiento()
                        End If
                    Else
                        MessageBox.Show("No se pudo llevar a cabo el movimiento, especificar cantidad a mover", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If

                Else
                    messagebox.show("Revisar datos, el lote final no posee la codificacion requerida", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                If (txtDiferenciasCodigoLote.Text.Length = 15) Then
                    If If(txtCantidad.Text = "" Or IsDBNull(txtCantidad.Text), 0, Convert.Todouble(txtCantidad.Text)) <> 0 Then
                        guardar_movimiento()
                    Else
                        MessageBox.Show("No se pudo llevar a cabo el movimiento, especificar cantidad a mover", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If

                Else
                    messagebox.show("Revisar datos, el lote final no posee la codificacion requerida", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
        Catch ex As Exception
            messagebox.show("No se pudo llevar a cabo el movimiento, " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        bandera = True
    End Sub

    Private Sub cboFinalTipoProductoFinal_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFinalTipoProductoFinal.SelectedValueChanged
        Try
            If TipoMovimiento = "E" Then

                txtFinalLoteFinal.Text = codigoLote.GenerarCodigoLoteFinal(dtpFecha.Value, Convert.ToInt32(cboFinalTipoProductoFinal.SelectedValue), TipoLoteID, dtb)
            Else
                GenerarCodigoLote()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboCompraProducto_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCompraProducto.SelectedValueChanged
        Try
            GenerarCodigoLoteCompra()
            cboFinalTipoProductoFinal.SelectedValue = 999
            cboFinalTipoProductoFinal.SelectedValue = cboCompraProducto.SelectedValue

            cbMedidacompra.Text = Me.spMedidasProductos.Select_Record(spTiposProductos.Select_Record(CType(cboCompraProducto.SelectedValue, Integer), dtb).MedidaID, dtb).Descripcion
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtCompraLote_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCompraLote.TextChanged
        If txtCompraLote.Text <> Nothing Then
            If txtCompraLote.Text <> "" Then

                codigoLote.validarCodigoLote(txtCompraLote.EsUnicoCampo, txtCompraLote.EsUnicoCampoID, _
                                     txtCompraLote.EsUnicoTabla, txtCompraLote.EsUnicoID.ToString, txtCompraLote.Text)
            End If
        End If


        'txtCompraLote.validarCodigoLote()
    End Sub

    Private Sub txtFinalLoteFinal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFinalLoteFinal.TextChanged
        validar3erLote()
        If (TipoMovimiento = "E" And txtCompraLote.Text = txtFinalLoteFinal.Text) Then
            txtFinalLoteFinal.Text = txtFinalLoteFinal.Text.Substring(0, 14) & (Convert.ToInt32(txtFinalLoteFinal.Text.Substring(14, 1)) + 1).ToString
        End If
    End Sub

    Private Sub cboLotes_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAjusteLotes.SelectedValueChanged
        If Not cboAjusteLotes.SelectedValue Is Nothing Then
            Try
                ctlLot.devolverLotesEnologicosParaMovimientosPorLoteID(Convert.ToInt32(cboAjusteLotes.SelectedValue), txtAjusteCantidadActual.Text, _
                                                                        Convert.ToInt32(cboAdicionProducto.SelectedValue), "", dtb)
                RefrescarCantidadAmover()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Sub CantidadAMover()
        Dim CantAMover As Double

        If txtCantidad.Text = "" Then
            CantAMover = 0
        Else
            CantAMover = Convert.Todouble(txtCantidad.Text)
            banderaCantidadMover = True
        End If

        If bandera And banderaCantidadMover Then
            banderaCantidadMover = False

            'Añadido por MAM 05/12/2011
            If Not chbSumaEnologico.Checked Then
                CantAMover = 0
            End If

            Try
                Dim CantPartidaActual As Double
                If TipoMovimiento = "E" Then 'Entrada
                    CantPartidaActual = Convert.Todouble(txtCompraCantidad.Text)
                ElseIf TipoMovimiento = "A" Or TipoMovimiento = "M" Then 'adicion o Macerado
                    CantPartidaActual = Convert.Todouble(txtAjusteCantidadActual.Text)
                Else
                    CantPartidaActual = Convert.Todouble(txtPartidaCantidadActual.Text)
                End If

                Dim CantFinalActual As Double
                If TipoMovimiento = "D" Then 'Diferencia
                    CantFinalActual = Convert.Todouble(txtDiferenciasCantidad.Text)
                Else
                    CantFinalActual = Convert.Todouble(txtFinalCantidadActual.Text)
                End If

                If CantPartidaActual = 0 Then
                    messagebox.show("Por favor seleccionar un deposito valido", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                ElseIf (CantAMover <= CantPartidaActual) Then
                    If TipoMovimiento = "M" Then 'Macerado
                        txtFinalCantidadFinal.Text = (CantFinalActual).ToString
                    Else
                        If cboPartidaDepositoID.SelectedValue Is cboFinalDepositoID.SelectedValue And gbFinal.Visible And gbPartida.Visible Then
                            txtFinalCantidadFinal.Text = CantFinalActual.ToString
                        Else
                            If gbLotes.Visible Then
                                'If chbSumaEnologico.Checked Then
                                txtFinalCantidadFinal.Text = (CantFinalActual + CantAMover).ToString
                                'Else
                                '    txtFinalCantidadFinal.Text = CantFinalActual
                                'End If
                            ElseIf TipoMovimiento = "D" Then 'Diferencia
                                txtDiferenciasCantidadFinal.Text = (CantFinalActual + CantAMover).ToString
                            ElseIf TipoMovimiento = "S" Then 'Salida envasado
                                txtSalidaCantidad.Text = CantAMover.ToString
                            Else
                                txtFinalCantidadFinal.Text = (CantFinalActual + CantAMover).ToString
                            End If
                        End If
                    End If
                Else
                    Dim response As DialogResult
                    response = MessageBox.Show("La cantidad maxima para mover es de : " & CantPartidaActual & ", Desea realizar una diferencia automatica? ", _
                                               " Eliminar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If response = DialogResult.Yes Then
                        RealizarDiferenciaAutomatica()
                    End If
                End If
            Catch ex As Exception
                banderaCantidadMover = True
            End Try
            banderaCantidadMover = True
        End If
    End Sub

    Private Sub cboAjutesProducto_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAdicionProducto.SelectedValueChanged
        Try
            cbMedidaLote.Text = Me.spMedidasProductos.Select_Record(spTiposProductos.Select_Record(CType(cboAdicionProducto.SelectedValue, Integer), dtb).MedidaID, dtb).Descripcion
            'cbMedidaLote.Text = ctlTipPro.DevolverMedida(cboAdicionProducto.SelectedValue)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboPartidaTipoProducto_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPartidaTipoProducto.SelectedValueChanged
        Try
            cbMedidaPartida.Text = Me.spMedidasProductos.Select_Record(spTiposProductos.Select_Record(CType(cboPartidaTipoProducto.SelectedValue, Integer), dtb).MedidaID, dtb).Descripcion
            'cbMedidaPartida.Text = ctlTipPro.DevolverMedida(cboPartidaTipoProducto.SelectedValue)
            If TipoMovimiento = "D" Then
                cboDiferenciaProducto.SelectedValue = cboPartidaTipoProducto.SelectedValue
            End If
            If TipoMovimiento = "S" Then
                cboSalidaProducto.SelectedValue = cboPartidaTipoProducto.SelectedValue
            End If
        Catch ex As Exception

        End Try
    End Sub

    Sub validar3erLote()
        Try
            If Not chbNuevoLote.Checked Then
                txtFinalLoteFinal.Text = txtFinalLoteActual.Text
                cboFinalTipoProductoFinal.SelectedValue = cboFinalTipoProductoActual.SelectedValue
            Else
                If txtFinalLoteFinal.Text <> Nothing Then
                    If txtFinalLoteFinal.Text <> "" Then
                        codigoLote.validarCodigoLote(txtFinalLoteFinal.EsUnicoCampo, txtFinalLoteFinal.EsUnicoCampoID, _
                                             txtFinalLoteFinal.EsUnicoTabla, txtFinalLoteFinal.EsUnicoID.ToString, txtFinalLoteFinal.Text)
                    End If
                End If

                'txtFinalLoteFinal.validarCodigoLote()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub chb3erLote_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbNuevoLote.CheckedChanged
        validar3erLote()
        If chbNuevoLote.Checked Then
            If TipodProductoParaLote = "H" Then
                cboFinalTipoProductoFinal.SelectedValue = 999
                If TipoMovimiento = "E" Then
                    cboFinalTipoProductoFinal.SelectedValue = cboCompraProducto.SelectedValue
                ElseIf TipoMovimiento = "A" Then
                    cboFinalTipoProductoFinal.SelectedValue = cboAdicionProducto.SelectedValue
                Else
                    cboFinalTipoProductoFinal.SelectedValue = cboPartidaTipoProducto.SelectedValue
                End If
            Else
                'If TipodProductoParaLote = "D" Then
                '    cboTipoLoteCompra.SelectedValue = cboPartidaTipoProducto.SelectedValue
                'End If
            End If

            GenerarCodigoLote()
        End If
        chbConMuestra.Checked = ConMuestra
        chbConMuestra.Visible = chbNuevoLote.Checked
    End Sub

    Private Sub txtFinalLoteActual_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFinalLoteActual.TextChanged
        If txtFinalLoteActual.Text = "" Then
            chbNuevoLote.Checked = True
        End If
    End Sub

    Private Sub dtpFecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFecha.ValueChanged
        GenerarCodigoLote()
        GenerarCodigoLoteCompra()
        If TipoMovimiento = "D" Then
            txtDiferenciasCodigoLote.Text = codigoLote.GenerarCodigoDiferencias(dtpFecha.Value, Convert.ToInt32(cboDiferenciaProducto.SelectedValue), TipoLoteID, dtb)
        End If
        If TipoMovimiento = "S" Then
            generarCodigoLotesalida()
        End If
    End Sub

    Private Sub VerificarEntradas_OnChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProceso.SelectedValueChanged, cboFinalDepositoID.SelectedValueChanged
        Try
            If TipoMovimiento = "E" And txtFinalLoteActual.Text = "" Then
                chbNuevoLote.Checked = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub chbSumaEnologico_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbSumaEnologico.CheckedChanged
        If TipoMovimiento = "M" Then
            chbSumaEnologico.Checked = False
        Else
            CantidadAMover()
        End If
    End Sub

    Private Sub txtCantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantidad.TextChanged
        Try

            CantidadAMover()
            If txtSalidaCantidadReal.Visible And TipoMovimiento = "S" Then
                txtSalidaCantidad.Text = txtSalidaCantidadReal.Text
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click 'ButTodo
        If gbCompra.Visible Then
            txtCantidad.Text = txtCompraCantidad.Text
        ElseIf gbLotes.Visible Then
            txtCantidad.Text = txtAjusteCantidadActual.Text
        ElseIf gbPartida.Visible Then
            txtCantidad.Text = txtPartidaCantidadActual.Text
        End If
    End Sub

    Private Sub cboDiferenciaProducto_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDiferenciaProducto.SelectedValueChanged
        Try
            txtDiferenciasCodigoLote.Text = codigoLote.GenerarCodigoDiferencias(dtpFecha.Value, Convert.ToInt32(cboDiferenciaProducto.SelectedValue), TipoLoteID, dtb)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtDiferenciasCodigoLote_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDiferenciasCodigoLote.TextChanged
        Try
            txtDiferenciasCantidad.Text = "0"
            DiferenciasLoteID = ctlLot.validarLoteDiferencia(txtDiferenciasCodigoLote.Text, Convert.ToDouble(txtDiferenciasCantidad.Text), txtDiferenciasDescripcion.Text, dtb)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtDiferenciasCantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDiferenciasCantidad.TextChanged
        CantidadAMover()
    End Sub

    Private Sub txtDiferenciasDescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDiferenciasDescripcion.TextChanged
        txtDiferenciasDescripcionFinal.Text = txtDiferenciasDescripcion.Text
    End Sub

    Private Sub txtFinalDescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFinalDescripcionActual.TextChanged
        txtFinalDescripcionFinal.Text = txtFinalDescripcionActual.Text
    End Sub

    Private Sub cboSalidaProducto_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSalidaProducto.SelectedValueChanged
        Try
            generarCodigoLotesalida()
        Catch ex As Exception
            messagebox.show(ex.Message)
        End Try
    End Sub

    Private Sub txtSalidaCodigoLote_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSalidaCodigoLote.TextChanged
        If txtSalidaCodigoLote.Text <> Nothing Then
            If txtSalidaCodigoLote.Text <> "" Then
                codigoLote.validarCodigoLote(txtSalidaCodigoLote.EsUnicoCampo, txtSalidaCodigoLote.EsUnicoCampoID, _
                                     txtSalidaCodigoLote.EsUnicoTabla, txtSalidaCodigoLote.EsUnicoID.ToString, txtSalidaCodigoLote.Text)
            End If
        End If

        'txtSalidaCodigoLote.validarCodigoLote()
    End Sub

    Private Sub txtFinalObservacionActual_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFinalObservacionActual.TextChanged
        txtFinalObservacionFinal.Text = txtFinalObservacionActual.Text
    End Sub

    Private Sub txtSalidaCantidadReal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSalidaCantidadReal.TextChanged
        If txtSalidaCantidadReal.Visible Then
            txtSalidaCantidad.Text = txtSalidaCantidadReal.Text
        End If
    End Sub

    Private Sub cbFiltros_VisibleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFiltros.VisibleChanged
        Dim aux As Boolean
        aux = cbFiltros.Visible
        chbFiltroDeshechos.Visible = aux
    End Sub

    Private Sub chbFiltroDeshechos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbFiltroDeshechos.CheckedChanged
        Try
            If chbFiltroDeshechos.Checked Then
                TipoMovimiento = "D"
                gbFinal.Visible = False
                gbDiferencias.Visible = True
                cboDiferenciasTipoLote.Text = DESCRIPCION_TIPO_LOTE_DEHECHOS
                TipoLoteID = Convert.ToInt32(cboDiferenciasTipoLote.SelectedValue)
                cboDiferenciaProducto.SelectedValue = cboPartidaTipoProducto.SelectedValue
                'GenerarCodigoDiferencias()
            Else
                TipoMovimiento = "F"
                gbFinal.Visible = True
                gbDiferencias.Visible = False
                ctlPro.SetProcesoID(Convert.ToInt32(cboProceso.SelectedValue))
                ctlPro.cargarProceso(TipodProductoParaLote, TipoMovimiento, TipoLoteID, ConMuestra, dtb)
                GenerarCodigoLote()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Sub RealizarDiferenciaAutomatica()
        Dim dif As New frmEntMovimientosCopy
        Dim cant1, cant2 As Double
        Dim depPar As String = cboPartidaDepositoID.Text
        cant1 = Convert.Todouble(txtCantidad.Text)
        cant2 = Convert.Todouble(txtPartidaCantidadActual.Text)
        dif.CargarDatos(0, 0, Today, cant2 - cant1, "Diferencia Automatica", DESCRIPCION_PROCESO_DIFERENCIAS, "", depPar, "", dtb)
        dif.Show()
        dif.CantidadAMover()
        dif.bandera = False
        dif.banderaCantidadMover = False
        dif.MOVER()
        dif.Close()
        txtCantidad.Text = "0"
        cboPartidaDepositoID.Text = ""
        cboPartidaDepositoID.Text = depPar
        txtCantidad.Text = txtPartidaCantidadActual.Text
    End Sub

    Private Sub cboSalidaRecipiente_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSalidaRecipiente.SelectedValueChanged
        Try
            If cboSalidaRecipiente.Visible And cboSalidaRecipiente.Text.ToUpper = "TRANSICUBA" Then
                cboSalidaTransicubas.Visible = True
                lblTransicubas.Visible = True
            Else
                cboSalidaTransicubas.Visible = False
                lblTransicubas.Visible = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Overrides Sub Salir()
        If gbCompra.Visible And LoteCompraID > 0 And If(txtCompraCantidad.Text = "" Or IsDBNull(txtCompraCantidad.Text), 0, Convert.ToInt32(txtCompraCantidad.Text)) > 0 Then
            MessageBox.Show("no se puede salir hasta que todo el lote de compra este en algun deposito", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Close()
        End If
    End Sub

#Region "generacion de codigosLote"
    Private Sub GenerarLoteDiferencias()
        Try
            txtDiferenciasCodigoLote.Text = codigoLote.GenerarCodigoDiferencias(dtpFecha.Value, Convert.ToInt32(cboDiferenciaProducto.SelectedValue), TipoLoteID, dtb)

        Catch ex As Exception
            txtDiferenciasCodigoLote.Text = ""
        Finally
            If txtDiferenciasCodigoLote.Text = "" Then
                'Me.butActualizar.Enabled = False
            Else
                Me.butActualizar.Enabled = True
            End If
        End Try

    End Sub

    Sub GenerarCodigoLoteCompra()
        Try
            'Dim dia, mes As String
            'If dtpFecha.Value.Day < 10 Then
            '    dia = "0" & dtpFecha.Value.Day
            'Else
            '    dia = dtpFecha.Value.Day
            'End If
            'If dtpFecha.Value.Month < 10 Then
            '    mes = "0" & dtpFecha.Value.Month
            'Else
            '    mes = dtpFecha.Value.Month
            'End If

            'Dim abrProducto As String = ctlTipPro.DevolverAbreviatura(cboCompraProducto.SelectedValue)
            'Dim abrlote As String = ctlTipLot.DevolverPorDescripcion(DescripcionTipoLoteRecepcion).Abreviatura

            'If abrProducto = "" Or abrlote = "" Then
            '    txtCompraLote.Text = ""
            '    'Me.butActualizar.Enabled = False
            'Else
            '    txtCompraLote.Text = dtpFecha.Value.Year & mes & dia & abrProducto & abrlote & "1"
            '    Me.butActualizar.Enabled = True
            'End If

            txtCompraLote.Text = codigoLote.GenerarCodigoLoteCompra(dtpFecha.Value, Convert.ToInt32(cboCompraProducto.SelectedValue), DESCRIPCION_TIPO_LOTE_RECEPCION, dtb)
            Me.butActualizar.Enabled = True
        Catch ex As Exception
            txtCompraLote.Text = ""
        Finally
            If txtCompraLote.Text = "" Then
                butActualizar.Enabled = False
            Else
                butActualizar.Enabled = True
            End If
        End Try
    End Sub

    Sub generarCodigoLotesalida()
        Try
            'Dim dia, mes As String
            'If dtpFecha.Value.Day < 10 Then
            '    dia = "0" & dtpFecha.Value.Day
            'Else
            '    dia = dtpFecha.Value.Day
            'End If
            'If dtpFecha.Value.Month < 10 Then
            '    mes = "0" & dtpFecha.Value.Month
            'Else
            '    mes = dtpFecha.Value.Month
            'End If

            'Dim abrProducto As String = ctlTipPro.DevolverAbreviatura(cboSalidaProducto.SelectedValue, BD.t)
            'Dim abrLote As String = ctlTipLot.Select_Record(TipoLoteID).Abreviatura

            'If abrProducto = "" Or abrLote = "" Then
            '    txtSalidaCodigoLote.Text = ""
            'Else
            '    txtSalidaCodigoLote.Text = dtpFecha.Value.Year & mes & dia & _
            '        abrProducto & abrLote & "1"
            'End If
            txtSalidaCodigoLote.Text = codigoLote.GenerarCodigoLoteSalida(dtpFecha.Value, Convert.ToInt32(cboSalidaProducto.SelectedValue), TipoLoteID, dtb)
        Catch ex As Exception
            txtSalidaCodigoLote.Text = ""
        Finally
            If txtSalidaCodigoLote.Text = "" Then
                'Me.butActualizar.Enabled = False
            Else
                Me.butActualizar.Enabled = True
            End If
        End Try
    End Sub

    Sub generarLoteProcesoCompra()
        Try
            'Dim tipoLot As Integer = cboTipoLoteCompra.SelectedValue

            'TipoLoteCompraID = tipoLot
            'TipoLoteID = tipoLot
            'TipoMovimientoCompra = "T"
            'TipodProductoParaLote = "I"

            'Dim dia, mes As String
            'If dtpFecha.Value.Day < 10 Then
            '    dia = "0" & dtpFecha.Value.Day
            'Else
            '    dia = dtpFecha.Value.Day
            'End If
            'If dtpFecha.Value.Month < 10 Then
            '    mes = "0" & dtpFecha.Value.Month
            'Else
            '    mes = dtpFecha.Value.Month
            'End If
            'txtFinalLoteFinal.Text = dtpFecha.Value.Year & mes & dia & ctlTipPro.DevolverAbreviatura(cboFinalTipoProductoFinal.SelectedValue) & ctlTipLot.Select_Record(TipoLoteCompraID).Abreviatura & "1"

            txtFinalLoteFinal.Text = codigoLote.GenerarCodigoLoteProcesoCompra(dtpFecha.Value, Convert.ToInt32(cboFinalTipoProductoFinal.SelectedValue), TipoLoteCompraID, dtb)
        Catch ex As Exception
            txtFinalLoteFinal.Text = ""
        Finally
            If txtFinalLoteFinal.Text = "" Then
                butActualizar.Enabled = False
            Else
                butActualizar.Enabled = True
            End If
        End Try
    End Sub

    Sub GenerarCodigoLote()
        Try
            'Dim dia, mes As String
            'If dtpFecha.Value.Day < 10 Then
            '    dia = "0" & dtpFecha.Value.Day
            'Else
            '    dia = dtpFecha.Value.Day
            'End If
            'If dtpFecha.Value.Month < 10 Then
            '    mes = "0" & dtpFecha.Value.Month
            'Else
            '    mes = dtpFecha.Value.Month
            'End If

            'Dim abrProducto As String = ctlTipPro.DevolverAbreviatura(cboFinalTipoProductoFinal.SelectedValue)
            'Dim abrLote As String = ctlTipLot.Select_Record(TipoLoteID).Abreviatura

            'If abrProducto = "" Or abrLote = "" Then
            '    txtFinalLoteFinal.Text = ""
            '    'Me.butActualizar.Enabled = False
            'Else
            '    txtFinalLoteFinal.Text = dtpFecha.Value.Year & mes & dia & abrProducto & abrLote & "1"
            '    Me.butActualizar.Enabled = True
            'End If
            Dim codigo As String = codigoLote.GenerarCodigoLote(dtpFecha.Value, Convert.ToInt32(cboFinalTipoProductoFinal.SelectedValue), TipoLoteID, dtb)
            txtFinalLoteFinal.Text = codigo
            Me.butActualizar.Enabled = True
        Catch ex As Exception
            txtFinalLoteFinal.Text = ""
            'Me.butActualizar.Enabled = False
        Finally
            If txtFinalLoteFinal.Text = "" Then
                'Me.butActualizar.Enabled = False
            Else
                Me.butActualizar.Enabled = True
            End If
        End Try
    End Sub
#End Region

    Private Function response() As DialogResult
        Throw New NotImplementedException
    End Function

End Class