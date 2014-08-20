<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntMovimientosCopy
    Inherits La_Andaluza_MovimientosDepositos.FrmAHeredarEntOld

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim FechaLabel As System.Windows.Forms.Label
        Dim CantidadLabel As System.Windows.Forms.Label
        Dim ObservacionesLabel As System.Windows.Forms.Label
        Dim ProcesoIDLabel As System.Windows.Forms.Label
        Dim EntraDepositoIDLabel As System.Windows.Forms.Label
        Dim SaleDepositoIDLabel As System.Windows.Forms.Label
        Dim LoteIDLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim Label14 As System.Windows.Forms.Label
        Dim Label15 As System.Windows.Forms.Label
        Dim Label16 As System.Windows.Forms.Label
        Dim Label17 As System.Windows.Forms.Label
        Dim Label19 As System.Windows.Forms.Label
        Dim Label21 As System.Windows.Forms.Label
        Dim Label18 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label22 As System.Windows.Forms.Label
        Dim Label23 As System.Windows.Forms.Label
        Dim Label24 As System.Windows.Forms.Label
        Dim Label25 As System.Windows.Forms.Label
        Dim Label26 As System.Windows.Forms.Label
        Dim Label27 As System.Windows.Forms.Label
        Dim Label28 As System.Windows.Forms.Label
        Dim Label30 As System.Windows.Forms.Label
        Dim Label31 As System.Windows.Forms.Label
        Dim Label32 As System.Windows.Forms.Label
        Dim Label29 As System.Windows.Forms.Label
        Dim Label33 As System.Windows.Forms.Label
        Dim Label34 As System.Windows.Forms.Label
        Dim Label35 As System.Windows.Forms.Label
        Dim Label36 As System.Windows.Forms.Label
        Dim Label37 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntMovimientosCopy))
        Me.DtsMovimientos = New La_Andaluza_MovimientosDepositos.dtsMovimientos()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtCantidad = New La_Andaluza_MovimientosDepositos.CuadroTextoNumerosNegativos(Me.components)
        Me.txtObservaciones = New La_Andaluza_MovimientosDepositos.CuadroDeTexto()
        Me.gbPartida = New System.Windows.Forms.GroupBox()
        Me.cbFiltros = New System.Windows.Forms.ComboBox()
        Me.cboPartidaTipoProducto = New System.Windows.Forms.ComboBox()
        Me.cboPartidaDepositoID = New System.Windows.Forms.ComboBox()
        Me.chbFiltroDeshechos = New System.Windows.Forms.CheckBox()
        Me.txtPartidaObservacion = New System.Windows.Forms.TextBox()
        Me.lblFiltros = New System.Windows.Forms.Label()
        Me.cbMedidaPartida = New La_Andaluza_MovimientosDepositos.CuadroDeTexto()
        Me.txtPartidaDescripcion = New La_Andaluza_MovimientosDepositos.CuadroDeTexto()
        Me.txtPartidaCantidadActual = New La_Andaluza_MovimientosDepositos.CuadroDeTexto()
        Me.txtPartidaLoteActual = New La_Andaluza_MovimientosDepositos.CuadroDeTexto()
        Me.gbLotes = New System.Windows.Forms.GroupBox()
        Me.cboAjusteLotes = New System.Windows.Forms.ComboBox()
        Me.cboAdicionProducto = New System.Windows.Forms.ComboBox()
        Me.cbMedidaLote = New System.Windows.Forms.ComboBox()
        Me.txtAjusteCantidadActual = New La_Andaluza_MovimientosDepositos.CuadroDeTexto()
        Me.chbSumaEnologico = New System.Windows.Forms.CheckBox()
        Me.gbCompra = New System.Windows.Forms.GroupBox()
        Me.cbMedidacompra = New System.Windows.Forms.ComboBox()
        Me.cboCompraProveedor = New System.Windows.Forms.ComboBox()
        Me.cboCompraProducto = New System.Windows.Forms.ComboBox()
        Me.txtCompraObservacion = New System.Windows.Forms.TextBox()
        Me.txtCompraDescripcion = New System.Windows.Forms.TextBox()
        Me.txtCompraLote = New La_Andaluza_MovimientosDepositos.CuadroDeTexto()
        Me.txtCompraCantidad = New La_Andaluza_MovimientosDepositos.CuadroDeTexto()
        Me.chbNuevoLote = New System.Windows.Forms.CheckBox()
        Me.gbFinal = New System.Windows.Forms.GroupBox()
        Me.cboFinalDepositoID = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboTipoLoteCompra = New System.Windows.Forms.ComboBox()
        Me.cboFinalTipoProductoFinal = New System.Windows.Forms.ComboBox()
        Me.txtFinalObservacionFinal = New System.Windows.Forms.TextBox()
        Me.txtFinalCantidadFinal = New La_Andaluza_MovimientosDepositos.CuadroDeTexto()
        Me.lblProcesoCompra = New System.Windows.Forms.Label()
        Me.txtFinalLoteFinal = New La_Andaluza_MovimientosDepositos.CuadroDeTexto()
        Me.txtFinalDescripcionFinal = New La_Andaluza_MovimientosDepositos.CuadroDeTexto()
        Me.chbConMuestra = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboFinalTipoProductoActual = New System.Windows.Forms.ComboBox()
        Me.txtFinalObservacionActual = New System.Windows.Forms.TextBox()
        Me.txtFinalDescripcionActual = New La_Andaluza_MovimientosDepositos.CuadroDeTexto()
        Me.txtFinalLoteActual = New La_Andaluza_MovimientosDepositos.CuadroDeTexto()
        Me.txtFinalCantidadActual = New La_Andaluza_MovimientosDepositos.CuadroDeTexto()
        Me.gbSalidas = New System.Windows.Forms.GroupBox()
        Me.cboSalidaTransicubas = New System.Windows.Forms.ComboBox()
        Me.cboSalidaRecipiente = New System.Windows.Forms.ComboBox()
        Me.cboSalidaProducto = New System.Windows.Forms.ComboBox()
        Me.lblTransicubas = New System.Windows.Forms.Label()
        Me.lblSalidasRecipientes = New System.Windows.Forms.Label()
        Me.lblSalidaCantidadReal = New System.Windows.Forms.Label()
        Me.txtSalidaCantidadReal = New La_Andaluza_MovimientosDepositos.CuadroDeTexto()
        Me.txtSalidaObservacion = New System.Windows.Forms.TextBox()
        Me.chbSalidaMuestra = New System.Windows.Forms.CheckBox()
        Me.txtSalidaCantidad = New La_Andaluza_MovimientosDepositos.CuadroDeTexto()
        Me.txtSalidaCodigoLote = New La_Andaluza_MovimientosDepositos.CuadroDeTexto()
        Me.txtSalidaDescripcion = New La_Andaluza_MovimientosDepositos.CuadroDeTexto()
        Me.gbDiferencias = New System.Windows.Forms.GroupBox()
        Me.cboDiferenciasTipoLote = New System.Windows.Forms.ComboBox()
        Me.cboDiferenciaProducto = New System.Windows.Forms.ComboBox()
        Me.txtdiferenciaObservaciones = New System.Windows.Forms.TextBox()
        Me.txtDiferenciasDescripcionFinal = New La_Andaluza_MovimientosDepositos.CuadroDeTexto()
        Me.txtDiferenciasDescripcion = New La_Andaluza_MovimientosDepositos.CuadroDeTexto()
        Me.txtDiferenciasCantidadFinal = New La_Andaluza_MovimientosDepositos.CuadroDeTexto()
        Me.txtDiferenciasCantidad = New La_Andaluza_MovimientosDepositos.CuadroDeTexto()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtDiferenciasCodigoLote = New La_Andaluza_MovimientosDepositos.CuadroDeTexto()
        Me.butActualizar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cboProceso = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        FechaLabel = New System.Windows.Forms.Label()
        CantidadLabel = New System.Windows.Forms.Label()
        ObservacionesLabel = New System.Windows.Forms.Label()
        ProcesoIDLabel = New System.Windows.Forms.Label()
        EntraDepositoIDLabel = New System.Windows.Forms.Label()
        SaleDepositoIDLabel = New System.Windows.Forms.Label()
        LoteIDLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        Label14 = New System.Windows.Forms.Label()
        Label15 = New System.Windows.Forms.Label()
        Label16 = New System.Windows.Forms.Label()
        Label17 = New System.Windows.Forms.Label()
        Label19 = New System.Windows.Forms.Label()
        Label21 = New System.Windows.Forms.Label()
        Label18 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Label22 = New System.Windows.Forms.Label()
        Label23 = New System.Windows.Forms.Label()
        Label24 = New System.Windows.Forms.Label()
        Label25 = New System.Windows.Forms.Label()
        Label26 = New System.Windows.Forms.Label()
        Label27 = New System.Windows.Forms.Label()
        Label28 = New System.Windows.Forms.Label()
        Label30 = New System.Windows.Forms.Label()
        Label31 = New System.Windows.Forms.Label()
        Label32 = New System.Windows.Forms.Label()
        Label29 = New System.Windows.Forms.Label()
        Label33 = New System.Windows.Forms.Label()
        Label34 = New System.Windows.Forms.Label()
        Label35 = New System.Windows.Forms.Label()
        Label36 = New System.Windows.Forms.Label()
        Label37 = New System.Windows.Forms.Label()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtsMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbPartida.SuspendLayout()
        Me.gbLotes.SuspendLayout()
        Me.gbCompra.SuspendLayout()
        Me.gbFinal.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbSalidas.SuspendLayout()
        Me.gbDiferencias.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GeneralBindingSource
        '
        Me.GeneralBindingSource.DataMember = "Movimientos"
        Me.GeneralBindingSource.DataSource = Me.DtsMovimientos
        '
        'txtTodoCorrecto
        '
        Me.txtTodoCorrecto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTodoCorrecto.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTodoCorrecto.Size = New System.Drawing.Size(10, 13)
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(4, 15)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(40, 13)
        FechaLabel.TabIndex = 0
        FechaLabel.Text = "Fecha:"
        '
        'CantidadLabel
        '
        CantidadLabel.AutoSize = True
        CantidadLabel.Location = New System.Drawing.Point(212, 11)
        CantidadLabel.Name = "CantidadLabel"
        CantidadLabel.Size = New System.Drawing.Size(108, 13)
        CantidadLabel.TabIndex = 11
        CantidadLabel.Text = "Cantidad a Transferir:"
        '
        'ObservacionesLabel
        '
        ObservacionesLabel.AutoSize = True
        ObservacionesLabel.Location = New System.Drawing.Point(62, 33)
        ObservacionesLabel.Name = "ObservacionesLabel"
        ObservacionesLabel.Size = New System.Drawing.Size(81, 13)
        ObservacionesLabel.TabIndex = 14
        ObservacionesLabel.Text = "Observaciones:"
        '
        'ProcesoIDLabel
        '
        ProcesoIDLabel.AutoSize = True
        ProcesoIDLabel.Location = New System.Drawing.Point(166, 15)
        ProcesoIDLabel.Name = "ProcesoIDLabel"
        ProcesoIDLabel.Size = New System.Drawing.Size(49, 13)
        ProcesoIDLabel.TabIndex = 2
        ProcesoIDLabel.Text = "Proceso:"
        '
        'EntraDepositoIDLabel
        '
        EntraDepositoIDLabel.AutoSize = True
        EntraDepositoIDLabel.Location = New System.Drawing.Point(26, 35)
        EntraDepositoIDLabel.Name = "EntraDepositoIDLabel"
        EntraDepositoIDLabel.Size = New System.Drawing.Size(49, 13)
        EntraDepositoIDLabel.TabIndex = 0
        EntraDepositoIDLabel.Text = "Deposito"
        '
        'SaleDepositoIDLabel
        '
        SaleDepositoIDLabel.AutoSize = True
        SaleDepositoIDLabel.Location = New System.Drawing.Point(4, 29)
        SaleDepositoIDLabel.Name = "SaleDepositoIDLabel"
        SaleDepositoIDLabel.Size = New System.Drawing.Size(88, 13)
        SaleDepositoIDLabel.TabIndex = 0
        SaleDepositoIDLabel.Text = "Deposito Partida:"
        '
        'LoteIDLabel
        '
        LoteIDLabel.AutoSize = True
        LoteIDLabel.Location = New System.Drawing.Point(19, 27)
        LoteIDLabel.Name = "LoteIDLabel"
        LoteIDLabel.Size = New System.Drawing.Size(31, 13)
        LoteIDLabel.TabIndex = 0
        LoteIDLabel.Text = "Lote:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(4, 58)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(64, 13)
        Label1.TabIndex = 2
        Label1.Text = "Lote Actual:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(4, 89)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(92, 13)
        Label2.TabIndex = 4
        Label2.Text = "Tipo de Producto:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(4, 243)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(85, 13)
        Label3.TabIndex = 10
        Label3.Text = "Cantidad Actual:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(4, 117)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(66, 13)
        Label4.TabIndex = 6
        Label4.Text = "Descripcion:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(7, 138)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(66, 13)
        Label5.TabIndex = 8
        Label5.Text = "Descripcion:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(6, 89)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(52, 13)
        Label6.TabIndex = 4
        Label6.Text = "Cantidad "
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(7, 16)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(73, 13)
        Label7.TabIndex = 0
        Label7.Text = "Tipo producto"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label8.Location = New System.Drawing.Point(4, 52)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(50, 20)
        Label8.TabIndex = 2
        Label8.Text = "Lote "
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(7, 112)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(52, 13)
        Label9.TabIndex = 6
        Label9.Text = "Cantidad "
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label10.Location = New System.Drawing.Point(5, 79)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(50, 20)
        Label10.TabIndex = 4
        Label10.Text = "Lote "
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.Location = New System.Drawing.Point(5, 24)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(73, 13)
        Label13.TabIndex = 0
        Label13.Text = "Tipo producto"
        '
        'Label14
        '
        Label14.AutoSize = True
        Label14.Location = New System.Drawing.Point(10, 14)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(92, 13)
        Label14.TabIndex = 0
        Label14.Text = "Tipo de Producto:"
        '
        'Label15
        '
        Label15.AutoSize = True
        Label15.Location = New System.Drawing.Point(10, 42)
        Label15.Name = "Label15"
        Label15.Size = New System.Drawing.Size(59, 13)
        Label15.TabIndex = 2
        Label15.Text = "Proveedor:"
        '
        'Label16
        '
        Label16.AutoSize = True
        Label16.Location = New System.Drawing.Point(10, 102)
        Label16.Name = "Label16"
        Label16.Size = New System.Drawing.Size(91, 13)
        Label16.TabIndex = 6
        Label16.Text = "Cantidad entrada:"
        '
        'Label17
        '
        Label17.AutoSize = True
        Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label17.Location = New System.Drawing.Point(9, 72)
        Label17.Name = "Label17"
        Label17.Size = New System.Drawing.Size(50, 20)
        Label17.TabIndex = 4
        Label17.Text = "Lote:"
        '
        'Label19
        '
        Label19.AutoSize = True
        Label19.Location = New System.Drawing.Point(20, 90)
        Label19.Name = "Label19"
        Label19.Size = New System.Drawing.Size(85, 13)
        Label19.TabIndex = 4
        Label19.Text = "Cantidad Actual:"
        '
        'Label21
        '
        Label21.AutoSize = True
        Label21.Location = New System.Drawing.Point(19, 58)
        Label21.Name = "Label21"
        Label21.Size = New System.Drawing.Size(89, 13)
        Label21.TabIndex = 2
        Label21.Text = "Tipo de Producto"
        '
        'Label18
        '
        Label18.AutoSize = True
        Label18.Location = New System.Drawing.Point(58, 11)
        Label18.Name = "Label18"
        Label18.Size = New System.Drawing.Size(116, 13)
        Label18.TabIndex = 9
        Label18.Text = "Suma a Cantidad Final:"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Location = New System.Drawing.Point(6, 118)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(66, 13)
        Label11.TabIndex = 6
        Label11.Text = "Descripcion:"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Location = New System.Drawing.Point(10, 20)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(73, 13)
        Label12.TabIndex = 0
        Label12.Text = "Tipo producto"
        '
        'Label22
        '
        Label22.AutoSize = True
        Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label22.Location = New System.Drawing.Point(9, 79)
        Label22.Name = "Label22"
        Label22.Size = New System.Drawing.Size(50, 20)
        Label22.TabIndex = 4
        Label22.Text = "Lote "
        '
        'Label23
        '
        Label23.AutoSize = True
        Label23.Location = New System.Drawing.Point(7, 114)
        Label23.Name = "Label23"
        Label23.Size = New System.Drawing.Size(82, 13)
        Label23.TabIndex = 6
        Label23.Text = "Cantidad Actual"
        '
        'Label24
        '
        Label24.AutoSize = True
        Label24.Location = New System.Drawing.Point(7, 180)
        Label24.Name = "Label24"
        Label24.Size = New System.Drawing.Size(74, 13)
        Label24.TabIndex = 10
        Label24.Text = "Cantidad Final"
        '
        'Label25
        '
        Label25.AutoSize = True
        Label25.Location = New System.Drawing.Point(10, 132)
        Label25.Name = "Label25"
        Label25.Size = New System.Drawing.Size(66, 13)
        Label25.TabIndex = 9
        Label25.Text = "Descripcion:"
        '
        'Label26
        '
        Label26.AutoSize = True
        Label26.Location = New System.Drawing.Point(7, 141)
        Label26.Name = "Label26"
        Label26.Size = New System.Drawing.Size(66, 13)
        Label26.TabIndex = 8
        Label26.Text = "Descripcion:"
        '
        'Label27
        '
        Label27.AutoSize = True
        Label27.Location = New System.Drawing.Point(7, 210)
        Label27.Name = "Label27"
        Label27.Size = New System.Drawing.Size(91, 13)
        Label27.TabIndex = 12
        Label27.Text = "Descripcion Final:"
        '
        'Label28
        '
        Label28.AutoSize = True
        Label28.Location = New System.Drawing.Point(10, 36)
        Label28.Name = "Label28"
        Label28.Size = New System.Drawing.Size(73, 13)
        Label28.TabIndex = 0
        Label28.Text = "Tipo producto"
        '
        'Label30
        '
        Label30.AutoSize = True
        Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label30.Location = New System.Drawing.Point(9, 68)
        Label30.Name = "Label30"
        Label30.Size = New System.Drawing.Size(50, 20)
        Label30.TabIndex = 2
        Label30.Text = "Lote "
        '
        'Label31
        '
        Label31.AutoSize = True
        Label31.Location = New System.Drawing.Point(10, 104)
        Label31.Name = "Label31"
        Label31.Size = New System.Drawing.Size(52, 13)
        Label31.TabIndex = 4
        Label31.Text = "Cantidad "
        '
        'Label32
        '
        Label32.AutoSize = True
        Label32.Location = New System.Drawing.Point(10, 128)
        Label32.Name = "Label32"
        Label32.Size = New System.Drawing.Size(66, 13)
        Label32.TabIndex = 6
        Label32.Text = "Descripcion:"
        '
        'Label29
        '
        Label29.AutoSize = True
        Label29.Location = New System.Drawing.Point(10, 188)
        Label29.Name = "Label29"
        Label29.Size = New System.Drawing.Size(81, 13)
        Label29.TabIndex = 11
        Label29.Text = "Observaciones:"
        '
        'Label33
        '
        Label33.AutoSize = True
        Label33.Location = New System.Drawing.Point(9, 201)
        Label33.Name = "Label33"
        Label33.Size = New System.Drawing.Size(81, 13)
        Label33.TabIndex = 8
        Label33.Text = "Observaciones:"
        '
        'Label34
        '
        Label34.AutoSize = True
        Label34.Location = New System.Drawing.Point(7, 244)
        Label34.Name = "Label34"
        Label34.Size = New System.Drawing.Size(81, 13)
        Label34.TabIndex = 14
        Label34.Text = "Observaciones:"
        '
        'Label35
        '
        Label35.AutoSize = True
        Label35.Location = New System.Drawing.Point(5, 177)
        Label35.Name = "Label35"
        Label35.Size = New System.Drawing.Size(81, 13)
        Label35.TabIndex = 8
        Label35.Text = "Observaciones:"
        '
        'Label36
        '
        Label36.AutoSize = True
        Label36.Location = New System.Drawing.Point(7, 198)
        Label36.Name = "Label36"
        Label36.Size = New System.Drawing.Size(81, 13)
        Label36.TabIndex = 10
        Label36.Text = "Observaciones:"
        '
        'Label37
        '
        Label37.AutoSize = True
        Label37.Location = New System.Drawing.Point(4, 183)
        Label37.Name = "Label37"
        Label37.Size = New System.Drawing.Size(81, 13)
        Label37.TabIndex = 8
        Label37.Text = "Observaciones:"
        '
        'DtsMovimientos
        '
        Me.DtsMovimientos.DataSetName = "dtsMovimientos"
        Me.DtsMovimientos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtpFecha
        '
        Me.dtpFecha.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.GeneralBindingSource, "Fecha", True))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(48, 13)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(93, 20)
        Me.dtpFecha.TabIndex = 1
        '
        'txtCantidad
        '
        Me.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCantidad.EsUnicoCampo = ""
        Me.txtCantidad.EsUnicoCampoID = ""
        Me.txtCantidad.EsUnicoID = 0
        Me.txtCantidad.EsUnicoTabla = ""
        Me.txtCantidad.Location = New System.Drawing.Point(335, 7)
        Me.txtCantidad.Minimo = 0
        Me.txtCantidad.Modificado = False
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Numerico_EsNumerico = True
        Me.txtCantidad.Numerico_NumeroDecimales = 3
        Me.txtCantidad.Numerico_SeparadorMiles = True
        Me.txtCantidad.Obligatorio = True
        Me.txtCantidad.ParametroID = 0
        Me.txtCantidad.Size = New System.Drawing.Size(102, 20)
        Me.txtCantidad.TabIndex = 12
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCantidad.ValorMaximo = 0.0R
        Me.txtCantidad.ValorMinimo = 0.0R
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservaciones.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "Observaciones", True))
        Me.txtObservaciones.EsUnicoCampo = ""
        Me.txtObservaciones.EsUnicoCampoID = ""
        Me.txtObservaciones.EsUnicoID = 0
        Me.txtObservaciones.EsUnicoTabla = ""
        Me.txtObservaciones.Location = New System.Drawing.Point(148, 31)
        Me.txtObservaciones.MaxLength = 50
        Me.txtObservaciones.Minimo = 0
        Me.txtObservaciones.Modificado = False
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Numerico_EsNumerico = False
        Me.txtObservaciones.Numerico_NumeroDecimales = 0
        Me.txtObservaciones.Numerico_SeparadorMiles = False
        Me.txtObservaciones.Obligatorio = False
        Me.txtObservaciones.ParametroID = 0
        Me.txtObservaciones.Size = New System.Drawing.Size(337, 32)
        Me.txtObservaciones.TabIndex = 15
        Me.txtObservaciones.ValorMaximo = 0.0R
        Me.txtObservaciones.ValorMinimo = 0.0R
        '
        'gbPartida
        '
        Me.gbPartida.Controls.Add(Me.cbFiltros)
        Me.gbPartida.Controls.Add(Me.cboPartidaTipoProducto)
        Me.gbPartida.Controls.Add(Me.cboPartidaDepositoID)
        Me.gbPartida.Controls.Add(Me.chbFiltroDeshechos)
        Me.gbPartida.Controls.Add(Label37)
        Me.gbPartida.Controls.Add(Me.txtPartidaObservacion)
        Me.gbPartida.Controls.Add(Me.lblFiltros)
        Me.gbPartida.Controls.Add(Me.cbMedidaPartida)
        Me.gbPartida.Controls.Add(Me.txtPartidaDescripcion)
        Me.gbPartida.Controls.Add(Label4)
        Me.gbPartida.Controls.Add(Me.txtPartidaCantidadActual)
        Me.gbPartida.Controls.Add(Label3)
        Me.gbPartida.Controls.Add(Label2)
        Me.gbPartida.Controls.Add(Me.txtPartidaLoteActual)
        Me.gbPartida.Controls.Add(Label1)
        Me.gbPartida.Controls.Add(SaleDepositoIDLabel)
        Me.gbPartida.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbPartida.Location = New System.Drawing.Point(0, 0)
        Me.gbPartida.Name = "gbPartida"
        Me.gbPartida.Size = New System.Drawing.Size(350, 341)
        Me.gbPartida.TabIndex = 2
        Me.gbPartida.TabStop = False
        Me.gbPartida.Text = "Deposito Partida"
        '
        'cbFiltros
        '
        Me.cbFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbFiltros.FormattingEnabled = True
        Me.cbFiltros.Location = New System.Drawing.Point(106, 271)
        Me.cbFiltros.Margin = New System.Windows.Forms.Padding(2)
        Me.cbFiltros.Name = "cbFiltros"
        Me.cbFiltros.Size = New System.Drawing.Size(218, 21)
        Me.cbFiltros.TabIndex = 14
        '
        'cboPartidaTipoProducto
        '
        Me.cboPartidaTipoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboPartidaTipoProducto.Enabled = False
        Me.cboPartidaTipoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboPartidaTipoProducto.FormattingEnabled = True
        Me.cboPartidaTipoProducto.Location = New System.Drawing.Point(108, 86)
        Me.cboPartidaTipoProducto.Margin = New System.Windows.Forms.Padding(2)
        Me.cboPartidaTipoProducto.Name = "cboPartidaTipoProducto"
        Me.cboPartidaTipoProducto.Size = New System.Drawing.Size(216, 24)
        Me.cboPartidaTipoProducto.TabIndex = 5
        '
        'cboPartidaDepositoID
        '
        Me.cboPartidaDepositoID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboPartidaDepositoID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboPartidaDepositoID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboPartidaDepositoID.FormattingEnabled = True
        Me.cboPartidaDepositoID.Location = New System.Drawing.Point(107, 27)
        Me.cboPartidaDepositoID.Margin = New System.Windows.Forms.Padding(2)
        Me.cboPartidaDepositoID.Name = "cboPartidaDepositoID"
        Me.cboPartidaDepositoID.Size = New System.Drawing.Size(216, 21)
        Me.cboPartidaDepositoID.TabIndex = 1
        '
        'chbFiltroDeshechos
        '
        Me.chbFiltroDeshechos.AutoSize = True
        Me.chbFiltroDeshechos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbFiltroDeshechos.Location = New System.Drawing.Point(105, 314)
        Me.chbFiltroDeshechos.Name = "chbFiltroDeshechos"
        Me.chbFiltroDeshechos.Size = New System.Drawing.Size(110, 17)
        Me.chbFiltroDeshechos.TabIndex = 15
        Me.chbFiltroDeshechos.Text = "a Lote Deshechos"
        Me.chbFiltroDeshechos.UseVisualStyleBackColor = True
        Me.chbFiltroDeshechos.Visible = False
        '
        'txtPartidaObservacion
        '
        Me.txtPartidaObservacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPartidaObservacion.Location = New System.Drawing.Point(106, 180)
        Me.txtPartidaObservacion.MaxLength = 100
        Me.txtPartidaObservacion.Multiline = True
        Me.txtPartidaObservacion.Name = "txtPartidaObservacion"
        Me.txtPartidaObservacion.ReadOnly = True
        Me.txtPartidaObservacion.Size = New System.Drawing.Size(218, 52)
        Me.txtPartidaObservacion.TabIndex = 9
        '
        'lblFiltros
        '
        Me.lblFiltros.AutoSize = True
        Me.lblFiltros.Location = New System.Drawing.Point(4, 274)
        Me.lblFiltros.Name = "lblFiltros"
        Me.lblFiltros.Size = New System.Drawing.Size(37, 13)
        Me.lblFiltros.TabIndex = 13
        Me.lblFiltros.Text = "Filtros:"
        '
        'cbMedidaPartida
        '
        Me.cbMedidaPartida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cbMedidaPartida.Enabled = False
        Me.cbMedidaPartida.EsUnicoCampo = ""
        Me.cbMedidaPartida.EsUnicoCampoID = ""
        Me.cbMedidaPartida.EsUnicoID = 0
        Me.cbMedidaPartida.EsUnicoTabla = ""
        Me.cbMedidaPartida.Location = New System.Drawing.Point(186, 240)
        Me.cbMedidaPartida.Minimo = 0
        Me.cbMedidaPartida.Modificado = False
        Me.cbMedidaPartida.Name = "cbMedidaPartida"
        Me.cbMedidaPartida.Numerico_EsNumerico = False
        Me.cbMedidaPartida.Numerico_NumeroDecimales = 0
        Me.cbMedidaPartida.Numerico_SeparadorMiles = True
        Me.cbMedidaPartida.Obligatorio = False
        Me.cbMedidaPartida.ParametroID = 0
        Me.cbMedidaPartida.ReadOnly = True
        Me.cbMedidaPartida.Size = New System.Drawing.Size(138, 20)
        Me.cbMedidaPartida.TabIndex = 12
        Me.cbMedidaPartida.ValorMaximo = 0.0R
        Me.cbMedidaPartida.ValorMinimo = 0.0R
        '
        'txtPartidaDescripcion
        '
        Me.txtPartidaDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPartidaDescripcion.Enabled = False
        Me.txtPartidaDescripcion.EsUnicoCampo = ""
        Me.txtPartidaDescripcion.EsUnicoCampoID = ""
        Me.txtPartidaDescripcion.EsUnicoID = 0
        Me.txtPartidaDescripcion.EsUnicoTabla = ""
        Me.txtPartidaDescripcion.Location = New System.Drawing.Point(107, 115)
        Me.txtPartidaDescripcion.Minimo = 0
        Me.txtPartidaDescripcion.Modificado = False
        Me.txtPartidaDescripcion.Multiline = True
        Me.txtPartidaDescripcion.Name = "txtPartidaDescripcion"
        Me.txtPartidaDescripcion.Numerico_EsNumerico = False
        Me.txtPartidaDescripcion.Numerico_NumeroDecimales = 0
        Me.txtPartidaDescripcion.Numerico_SeparadorMiles = True
        Me.txtPartidaDescripcion.Obligatorio = False
        Me.txtPartidaDescripcion.ParametroID = 0
        Me.txtPartidaDescripcion.ReadOnly = True
        Me.txtPartidaDescripcion.Size = New System.Drawing.Size(218, 53)
        Me.txtPartidaDescripcion.TabIndex = 7
        Me.txtPartidaDescripcion.ValorMaximo = 0.0R
        Me.txtPartidaDescripcion.ValorMinimo = 0.0R
        '
        'txtPartidaCantidadActual
        '
        Me.txtPartidaCantidadActual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPartidaCantidadActual.Enabled = False
        Me.txtPartidaCantidadActual.EsUnicoCampo = ""
        Me.txtPartidaCantidadActual.EsUnicoCampoID = ""
        Me.txtPartidaCantidadActual.EsUnicoID = 0
        Me.txtPartidaCantidadActual.EsUnicoTabla = ""
        Me.txtPartidaCantidadActual.Location = New System.Drawing.Point(108, 240)
        Me.txtPartidaCantidadActual.Minimo = 0
        Me.txtPartidaCantidadActual.Modificado = False
        Me.txtPartidaCantidadActual.Name = "txtPartidaCantidadActual"
        Me.txtPartidaCantidadActual.Numerico_EsNumerico = True
        Me.txtPartidaCantidadActual.Numerico_NumeroDecimales = 0
        Me.txtPartidaCantidadActual.Numerico_SeparadorMiles = True
        Me.txtPartidaCantidadActual.Obligatorio = False
        Me.txtPartidaCantidadActual.ParametroID = 0
        Me.txtPartidaCantidadActual.ReadOnly = True
        Me.txtPartidaCantidadActual.Size = New System.Drawing.Size(72, 20)
        Me.txtPartidaCantidadActual.TabIndex = 11
        Me.txtPartidaCantidadActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPartidaCantidadActual.ValorMaximo = 0.0R
        Me.txtPartidaCantidadActual.ValorMinimo = 0.0R
        '
        'txtPartidaLoteActual
        '
        Me.txtPartidaLoteActual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPartidaLoteActual.Enabled = False
        Me.txtPartidaLoteActual.EsUnicoCampo = ""
        Me.txtPartidaLoteActual.EsUnicoCampoID = ""
        Me.txtPartidaLoteActual.EsUnicoID = 0
        Me.txtPartidaLoteActual.EsUnicoTabla = ""
        Me.txtPartidaLoteActual.Location = New System.Drawing.Point(106, 56)
        Me.txtPartidaLoteActual.Minimo = 0
        Me.txtPartidaLoteActual.Modificado = False
        Me.txtPartidaLoteActual.Name = "txtPartidaLoteActual"
        Me.txtPartidaLoteActual.Numerico_EsNumerico = False
        Me.txtPartidaLoteActual.Numerico_NumeroDecimales = 0
        Me.txtPartidaLoteActual.Numerico_SeparadorMiles = True
        Me.txtPartidaLoteActual.Obligatorio = False
        Me.txtPartidaLoteActual.ParametroID = 0
        Me.txtPartidaLoteActual.ReadOnly = True
        Me.txtPartidaLoteActual.Size = New System.Drawing.Size(218, 20)
        Me.txtPartidaLoteActual.TabIndex = 3
        Me.txtPartidaLoteActual.ValorMaximo = 0.0R
        Me.txtPartidaLoteActual.ValorMinimo = 0.0R
        '
        'gbLotes
        '
        Me.gbLotes.Controls.Add(Me.cboAjusteLotes)
        Me.gbLotes.Controls.Add(Me.cboAdicionProducto)
        Me.gbLotes.Controls.Add(Me.cbMedidaLote)
        Me.gbLotes.Controls.Add(Label21)
        Me.gbLotes.Controls.Add(Me.txtAjusteCantidadActual)
        Me.gbLotes.Controls.Add(Label19)
        Me.gbLotes.Controls.Add(LoteIDLabel)
        Me.gbLotes.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbLotes.Location = New System.Drawing.Point(0, 341)
        Me.gbLotes.Name = "gbLotes"
        Me.gbLotes.Size = New System.Drawing.Size(350, 117)
        Me.gbLotes.TabIndex = 5
        Me.gbLotes.TabStop = False
        Me.gbLotes.Text = "Lotes"
        '
        'cboAjusteLotes
        '
        Me.cboAjusteLotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboAjusteLotes.FormattingEnabled = True
        Me.cboAjusteLotes.Location = New System.Drawing.Point(118, 19)
        Me.cboAjusteLotes.Margin = New System.Windows.Forms.Padding(2)
        Me.cboAjusteLotes.Name = "cboAjusteLotes"
        Me.cboAjusteLotes.Size = New System.Drawing.Size(217, 21)
        Me.cboAjusteLotes.TabIndex = 1
        '
        'cboAdicionProducto
        '
        Me.cboAdicionProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboAdicionProducto.Enabled = False
        Me.cboAdicionProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboAdicionProducto.FormattingEnabled = True
        Me.cboAdicionProducto.Location = New System.Drawing.Point(118, 52)
        Me.cboAdicionProducto.Margin = New System.Windows.Forms.Padding(2)
        Me.cboAdicionProducto.Name = "cboAdicionProducto"
        Me.cboAdicionProducto.Size = New System.Drawing.Size(217, 24)
        Me.cboAdicionProducto.TabIndex = 3
        '
        'cbMedidaLote
        '
        Me.cbMedidaLote.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbMedidaLote.Enabled = False
        Me.cbMedidaLote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbMedidaLote.FormattingEnabled = True
        Me.cbMedidaLote.Location = New System.Drawing.Point(202, 86)
        Me.cbMedidaLote.Margin = New System.Windows.Forms.Padding(2)
        Me.cbMedidaLote.Name = "cbMedidaLote"
        Me.cbMedidaLote.Size = New System.Drawing.Size(133, 24)
        Me.cbMedidaLote.TabIndex = 6
        '
        'txtAjusteCantidadActual
        '
        Me.txtAjusteCantidadActual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAjusteCantidadActual.Enabled = False
        Me.txtAjusteCantidadActual.EsUnicoCampo = ""
        Me.txtAjusteCantidadActual.EsUnicoCampoID = ""
        Me.txtAjusteCantidadActual.EsUnicoID = 0
        Me.txtAjusteCantidadActual.EsUnicoTabla = ""
        Me.txtAjusteCantidadActual.Location = New System.Drawing.Point(116, 86)
        Me.txtAjusteCantidadActual.Minimo = 0
        Me.txtAjusteCantidadActual.Modificado = False
        Me.txtAjusteCantidadActual.Name = "txtAjusteCantidadActual"
        Me.txtAjusteCantidadActual.Numerico_EsNumerico = True
        Me.txtAjusteCantidadActual.Numerico_NumeroDecimales = 0
        Me.txtAjusteCantidadActual.Numerico_SeparadorMiles = True
        Me.txtAjusteCantidadActual.Obligatorio = False
        Me.txtAjusteCantidadActual.ParametroID = 0
        Me.txtAjusteCantidadActual.ReadOnly = True
        Me.txtAjusteCantidadActual.Size = New System.Drawing.Size(72, 20)
        Me.txtAjusteCantidadActual.TabIndex = 5
        Me.txtAjusteCantidadActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtAjusteCantidadActual.ValorMaximo = 0.0R
        Me.txtAjusteCantidadActual.ValorMinimo = 0.0R
        '
        'chbSumaEnologico
        '
        Me.chbSumaEnologico.AutoSize = True
        Me.chbSumaEnologico.Checked = True
        Me.chbSumaEnologico.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbSumaEnologico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbSumaEnologico.Location = New System.Drawing.Point(182, 11)
        Me.chbSumaEnologico.Name = "chbSumaEnologico"
        Me.chbSumaEnologico.Size = New System.Drawing.Size(12, 11)
        Me.chbSumaEnologico.TabIndex = 10
        Me.chbSumaEnologico.UseVisualStyleBackColor = True
        '
        'gbCompra
        '
        Me.gbCompra.Controls.Add(Me.cbMedidacompra)
        Me.gbCompra.Controls.Add(Me.cboCompraProveedor)
        Me.gbCompra.Controls.Add(Me.cboCompraProducto)
        Me.gbCompra.Controls.Add(Label29)
        Me.gbCompra.Controls.Add(Me.txtCompraObservacion)
        Me.gbCompra.Controls.Add(Label25)
        Me.gbCompra.Controls.Add(Me.txtCompraDescripcion)
        Me.gbCompra.Controls.Add(Me.txtCompraLote)
        Me.gbCompra.Controls.Add(Label17)
        Me.gbCompra.Controls.Add(Me.txtCompraCantidad)
        Me.gbCompra.Controls.Add(Label16)
        Me.gbCompra.Controls.Add(Label15)
        Me.gbCompra.Controls.Add(Label14)
        Me.gbCompra.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbCompra.Location = New System.Drawing.Point(0, 458)
        Me.gbCompra.Name = "gbCompra"
        Me.gbCompra.Size = New System.Drawing.Size(350, 245)
        Me.gbCompra.TabIndex = 6
        Me.gbCompra.TabStop = False
        Me.gbCompra.Text = "Compras"
        '
        'cbMedidacompra
        '
        Me.cbMedidacompra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbMedidacompra.Enabled = False
        Me.cbMedidacompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbMedidacompra.FormattingEnabled = True
        Me.cbMedidacompra.Location = New System.Drawing.Point(239, 102)
        Me.cbMedidacompra.Margin = New System.Windows.Forms.Padding(2)
        Me.cbMedidacompra.Name = "cbMedidacompra"
        Me.cbMedidacompra.Size = New System.Drawing.Size(98, 24)
        Me.cbMedidacompra.TabIndex = 8
        '
        'cboCompraProveedor
        '
        Me.cboCompraProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboCompraProveedor.FormattingEnabled = True
        Me.cboCompraProveedor.Location = New System.Drawing.Point(115, 40)
        Me.cboCompraProveedor.Margin = New System.Windows.Forms.Padding(2)
        Me.cboCompraProveedor.Name = "cboCompraProveedor"
        Me.cboCompraProveedor.Size = New System.Drawing.Size(222, 21)
        Me.cboCompraProveedor.TabIndex = 3
        '
        'cboCompraProducto
        '
        Me.cboCompraProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboCompraProducto.FormattingEnabled = True
        Me.cboCompraProducto.Location = New System.Drawing.Point(115, 11)
        Me.cboCompraProducto.Margin = New System.Windows.Forms.Padding(2)
        Me.cboCompraProducto.Name = "cboCompraProducto"
        Me.cboCompraProducto.Size = New System.Drawing.Size(222, 21)
        Me.cboCompraProducto.TabIndex = 1
        '
        'txtCompraObservacion
        '
        Me.txtCompraObservacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCompraObservacion.Location = New System.Drawing.Point(115, 186)
        Me.txtCompraObservacion.MaxLength = 100
        Me.txtCompraObservacion.Multiline = True
        Me.txtCompraObservacion.Name = "txtCompraObservacion"
        Me.txtCompraObservacion.Size = New System.Drawing.Size(222, 52)
        Me.txtCompraObservacion.TabIndex = 12
        '
        'txtCompraDescripcion
        '
        Me.txtCompraDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCompraDescripcion.Location = New System.Drawing.Point(115, 132)
        Me.txtCompraDescripcion.MaxLength = 100
        Me.txtCompraDescripcion.Multiline = True
        Me.txtCompraDescripcion.Name = "txtCompraDescripcion"
        Me.txtCompraDescripcion.Size = New System.Drawing.Size(222, 48)
        Me.txtCompraDescripcion.TabIndex = 10
        '
        'txtCompraLote
        '
        Me.txtCompraLote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCompraLote.Enabled = False
        Me.txtCompraLote.EsUnicoCampo = "CodigoLote"
        Me.txtCompraLote.EsUnicoCampoID = "LoteID"
        Me.txtCompraLote.EsUnicoID = 0
        Me.txtCompraLote.EsUnicoTabla = "Lotes"
        Me.txtCompraLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompraLote.Location = New System.Drawing.Point(115, 70)
        Me.txtCompraLote.Minimo = 0
        Me.txtCompraLote.Modificado = False
        Me.txtCompraLote.Name = "txtCompraLote"
        Me.txtCompraLote.Numerico_EsNumerico = False
        Me.txtCompraLote.Numerico_NumeroDecimales = 0
        Me.txtCompraLote.Numerico_SeparadorMiles = True
        Me.txtCompraLote.Obligatorio = False
        Me.txtCompraLote.ParametroID = 0
        Me.txtCompraLote.ReadOnly = True
        Me.txtCompraLote.Size = New System.Drawing.Size(222, 26)
        Me.txtCompraLote.TabIndex = 5
        Me.txtCompraLote.ValorMaximo = 0.0R
        Me.txtCompraLote.ValorMinimo = 0.0R
        '
        'txtCompraCantidad
        '
        Me.txtCompraCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCompraCantidad.EsUnicoCampo = ""
        Me.txtCompraCantidad.EsUnicoCampoID = ""
        Me.txtCompraCantidad.EsUnicoID = 0
        Me.txtCompraCantidad.EsUnicoTabla = ""
        Me.txtCompraCantidad.Location = New System.Drawing.Point(115, 102)
        Me.txtCompraCantidad.Minimo = 0
        Me.txtCompraCantidad.Modificado = False
        Me.txtCompraCantidad.Name = "txtCompraCantidad"
        Me.txtCompraCantidad.Numerico_EsNumerico = True
        Me.txtCompraCantidad.Numerico_NumeroDecimales = 0
        Me.txtCompraCantidad.Numerico_SeparadorMiles = True
        Me.txtCompraCantidad.Obligatorio = False
        Me.txtCompraCantidad.ParametroID = 0
        Me.txtCompraCantidad.Size = New System.Drawing.Size(72, 20)
        Me.txtCompraCantidad.TabIndex = 7
        Me.txtCompraCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCompraCantidad.ValorMaximo = 0.0R
        Me.txtCompraCantidad.ValorMinimo = 0.0R
        '
        'chbNuevoLote
        '
        Me.chbNuevoLote.AutoSize = True
        Me.chbNuevoLote.Checked = True
        Me.chbNuevoLote.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbNuevoLote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbNuevoLote.Location = New System.Drawing.Point(203, 20)
        Me.chbNuevoLote.Name = "chbNuevoLote"
        Me.chbNuevoLote.Size = New System.Drawing.Size(120, 17)
        Me.chbNuevoLote.TabIndex = 2
        Me.chbNuevoLote.Text = "Generar Nuevo Lote"
        Me.chbNuevoLote.UseVisualStyleBackColor = True
        '
        'gbFinal
        '
        Me.gbFinal.Controls.Add(Me.cboFinalDepositoID)
        Me.gbFinal.Controls.Add(Me.GroupBox2)
        Me.gbFinal.Controls.Add(Me.chbConMuestra)
        Me.gbFinal.Controls.Add(Me.chbNuevoLote)
        Me.gbFinal.Controls.Add(Me.GroupBox1)
        Me.gbFinal.Controls.Add(EntraDepositoIDLabel)
        Me.gbFinal.Dock = System.Windows.Forms.DockStyle.Left
        Me.gbFinal.Location = New System.Drawing.Point(350, 72)
        Me.gbFinal.Name = "gbFinal"
        Me.gbFinal.Size = New System.Drawing.Size(350, 684)
        Me.gbFinal.TabIndex = 4
        Me.gbFinal.TabStop = False
        Me.gbFinal.Text = "Deposito Final"
        '
        'cboFinalDepositoID
        '
        Me.cboFinalDepositoID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboFinalDepositoID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboFinalDepositoID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboFinalDepositoID.FormattingEnabled = True
        Me.cboFinalDepositoID.Location = New System.Drawing.Point(80, 33)
        Me.cboFinalDepositoID.Margin = New System.Windows.Forms.Padding(2)
        Me.cboFinalDepositoID.Name = "cboFinalDepositoID"
        Me.cboFinalDepositoID.Size = New System.Drawing.Size(110, 21)
        Me.cboFinalDepositoID.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboTipoLoteCompra)
        Me.GroupBox2.Controls.Add(Me.cboFinalTipoProductoFinal)
        Me.GroupBox2.Controls.Add(Label36)
        Me.GroupBox2.Controls.Add(Me.txtFinalObservacionFinal)
        Me.GroupBox2.Controls.Add(Label7)
        Me.GroupBox2.Controls.Add(Me.txtFinalCantidadFinal)
        Me.GroupBox2.Controls.Add(Me.lblProcesoCompra)
        Me.GroupBox2.Controls.Add(Label10)
        Me.GroupBox2.Controls.Add(Label9)
        Me.GroupBox2.Controls.Add(Me.txtFinalLoteFinal)
        Me.GroupBox2.Controls.Add(Me.txtFinalDescripcionFinal)
        Me.GroupBox2.Controls.Add(Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(20, 322)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(306, 251)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Despues"
        '
        'cboTipoLoteCompra
        '
        Me.cboTipoLoteCompra.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboTipoLoteCompra.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTipoLoteCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboTipoLoteCompra.FormattingEnabled = True
        Me.cboTipoLoteCompra.Location = New System.Drawing.Point(96, 45)
        Me.cboTipoLoteCompra.Margin = New System.Windows.Forms.Padding(2)
        Me.cboTipoLoteCompra.Name = "cboTipoLoteCompra"
        Me.cboTipoLoteCompra.Size = New System.Drawing.Size(194, 21)
        Me.cboTipoLoteCompra.TabIndex = 3
        Me.cboTipoLoteCompra.Visible = False
        '
        'cboFinalTipoProductoFinal
        '
        Me.cboFinalTipoProductoFinal.Enabled = False
        Me.cboFinalTipoProductoFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboFinalTipoProductoFinal.FormattingEnabled = True
        Me.cboFinalTipoProductoFinal.Location = New System.Drawing.Point(96, 14)
        Me.cboFinalTipoProductoFinal.Margin = New System.Windows.Forms.Padding(2)
        Me.cboFinalTipoProductoFinal.Name = "cboFinalTipoProductoFinal"
        Me.cboFinalTipoProductoFinal.Size = New System.Drawing.Size(194, 21)
        Me.cboFinalTipoProductoFinal.TabIndex = 1
        '
        'txtFinalObservacionFinal
        '
        Me.txtFinalObservacionFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFinalObservacionFinal.Location = New System.Drawing.Point(97, 195)
        Me.txtFinalObservacionFinal.MaxLength = 100
        Me.txtFinalObservacionFinal.Multiline = True
        Me.txtFinalObservacionFinal.Name = "txtFinalObservacionFinal"
        Me.txtFinalObservacionFinal.Size = New System.Drawing.Size(193, 52)
        Me.txtFinalObservacionFinal.TabIndex = 11
        '
        'txtFinalCantidadFinal
        '
        Me.txtFinalCantidadFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFinalCantidadFinal.Enabled = False
        Me.txtFinalCantidadFinal.EsUnicoCampo = ""
        Me.txtFinalCantidadFinal.EsUnicoCampoID = ""
        Me.txtFinalCantidadFinal.EsUnicoID = 0
        Me.txtFinalCantidadFinal.EsUnicoTabla = ""
        Me.txtFinalCantidadFinal.Location = New System.Drawing.Point(96, 110)
        Me.txtFinalCantidadFinal.Minimo = 0
        Me.txtFinalCantidadFinal.Modificado = False
        Me.txtFinalCantidadFinal.Name = "txtFinalCantidadFinal"
        Me.txtFinalCantidadFinal.Numerico_EsNumerico = True
        Me.txtFinalCantidadFinal.Numerico_NumeroDecimales = 0
        Me.txtFinalCantidadFinal.Numerico_SeparadorMiles = True
        Me.txtFinalCantidadFinal.Obligatorio = False
        Me.txtFinalCantidadFinal.ParametroID = 0
        Me.txtFinalCantidadFinal.ReadOnly = True
        Me.txtFinalCantidadFinal.Size = New System.Drawing.Size(73, 20)
        Me.txtFinalCantidadFinal.TabIndex = 7
        Me.txtFinalCantidadFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtFinalCantidadFinal.ValorMaximo = 0.0R
        Me.txtFinalCantidadFinal.ValorMinimo = 0.0R
        '
        'lblProcesoCompra
        '
        Me.lblProcesoCompra.AutoSize = True
        Me.lblProcesoCompra.Location = New System.Drawing.Point(7, 47)
        Me.lblProcesoCompra.Name = "lblProcesoCompra"
        Me.lblProcesoCompra.Size = New System.Drawing.Size(55, 13)
        Me.lblProcesoCompra.TabIndex = 2
        Me.lblProcesoCompra.Text = "Tipo Lote:"
        '
        'txtFinalLoteFinal
        '
        Me.txtFinalLoteFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFinalLoteFinal.Enabled = False
        Me.txtFinalLoteFinal.EsUnicoCampo = "CodigoLote"
        Me.txtFinalLoteFinal.EsUnicoCampoID = "LoteID"
        Me.txtFinalLoteFinal.EsUnicoID = 0
        Me.txtFinalLoteFinal.EsUnicoTabla = "Lotes"
        Me.txtFinalLoteFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFinalLoteFinal.Location = New System.Drawing.Point(95, 76)
        Me.txtFinalLoteFinal.Minimo = 0
        Me.txtFinalLoteFinal.Modificado = False
        Me.txtFinalLoteFinal.Name = "txtFinalLoteFinal"
        Me.txtFinalLoteFinal.Numerico_EsNumerico = False
        Me.txtFinalLoteFinal.Numerico_NumeroDecimales = 0
        Me.txtFinalLoteFinal.Numerico_SeparadorMiles = True
        Me.txtFinalLoteFinal.Obligatorio = False
        Me.txtFinalLoteFinal.ParametroID = 0
        Me.txtFinalLoteFinal.ReadOnly = True
        Me.txtFinalLoteFinal.Size = New System.Drawing.Size(195, 26)
        Me.txtFinalLoteFinal.TabIndex = 5
        Me.txtFinalLoteFinal.ValorMaximo = 0.0R
        Me.txtFinalLoteFinal.ValorMinimo = 0.0R
        '
        'txtFinalDescripcionFinal
        '
        Me.txtFinalDescripcionFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFinalDescripcionFinal.EsUnicoCampo = ""
        Me.txtFinalDescripcionFinal.EsUnicoCampoID = ""
        Me.txtFinalDescripcionFinal.EsUnicoID = 0
        Me.txtFinalDescripcionFinal.EsUnicoTabla = ""
        Me.txtFinalDescripcionFinal.Location = New System.Drawing.Point(96, 136)
        Me.txtFinalDescripcionFinal.MaxLength = 100
        Me.txtFinalDescripcionFinal.Minimo = 0
        Me.txtFinalDescripcionFinal.Modificado = False
        Me.txtFinalDescripcionFinal.Multiline = True
        Me.txtFinalDescripcionFinal.Name = "txtFinalDescripcionFinal"
        Me.txtFinalDescripcionFinal.Numerico_EsNumerico = False
        Me.txtFinalDescripcionFinal.Numerico_NumeroDecimales = 0
        Me.txtFinalDescripcionFinal.Numerico_SeparadorMiles = True
        Me.txtFinalDescripcionFinal.Obligatorio = False
        Me.txtFinalDescripcionFinal.ParametroID = 0
        Me.txtFinalDescripcionFinal.Size = New System.Drawing.Size(195, 53)
        Me.txtFinalDescripcionFinal.TabIndex = 9
        Me.txtFinalDescripcionFinal.ValorMaximo = 0.0R
        Me.txtFinalDescripcionFinal.ValorMinimo = 0.0R
        '
        'chbConMuestra
        '
        Me.chbConMuestra.AutoSize = True
        Me.chbConMuestra.Checked = True
        Me.chbConMuestra.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbConMuestra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbConMuestra.Location = New System.Drawing.Point(204, 44)
        Me.chbConMuestra.Name = "chbConMuestra"
        Me.chbConMuestra.Size = New System.Drawing.Size(142, 17)
        Me.chbConMuestra.TabIndex = 3
        Me.chbConMuestra.Text = "Nuevo Lote Con Muestra"
        Me.chbConMuestra.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboFinalTipoProductoActual)
        Me.GroupBox1.Controls.Add(Label35)
        Me.GroupBox1.Controls.Add(Me.txtFinalObservacionActual)
        Me.GroupBox1.Controls.Add(Me.txtFinalDescripcionActual)
        Me.GroupBox1.Controls.Add(Label11)
        Me.GroupBox1.Controls.Add(Me.txtFinalLoteActual)
        Me.GroupBox1.Controls.Add(Label6)
        Me.GroupBox1.Controls.Add(Label8)
        Me.GroupBox1.Controls.Add(Label13)
        Me.GroupBox1.Controls.Add(Me.txtFinalCantidadActual)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(305, 236)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Antes"
        '
        'cboFinalTipoProductoActual
        '
        Me.cboFinalTipoProductoActual.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboFinalTipoProductoActual.Enabled = False
        Me.cboFinalTipoProductoActual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboFinalTipoProductoActual.FormattingEnabled = True
        Me.cboFinalTipoProductoActual.Location = New System.Drawing.Point(96, 21)
        Me.cboFinalTipoProductoActual.Margin = New System.Windows.Forms.Padding(2)
        Me.cboFinalTipoProductoActual.Name = "cboFinalTipoProductoActual"
        Me.cboFinalTipoProductoActual.Size = New System.Drawing.Size(194, 24)
        Me.cboFinalTipoProductoActual.TabIndex = 1
        '
        'txtFinalObservacionActual
        '
        Me.txtFinalObservacionActual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFinalObservacionActual.Location = New System.Drawing.Point(94, 174)
        Me.txtFinalObservacionActual.MaxLength = 100
        Me.txtFinalObservacionActual.Multiline = True
        Me.txtFinalObservacionActual.Name = "txtFinalObservacionActual"
        Me.txtFinalObservacionActual.ReadOnly = True
        Me.txtFinalObservacionActual.Size = New System.Drawing.Size(198, 52)
        Me.txtFinalObservacionActual.TabIndex = 9
        '
        'txtFinalDescripcionActual
        '
        Me.txtFinalDescripcionActual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFinalDescripcionActual.Enabled = False
        Me.txtFinalDescripcionActual.EsUnicoCampo = ""
        Me.txtFinalDescripcionActual.EsUnicoCampoID = ""
        Me.txtFinalDescripcionActual.EsUnicoID = 0
        Me.txtFinalDescripcionActual.EsUnicoTabla = ""
        Me.txtFinalDescripcionActual.Location = New System.Drawing.Point(96, 115)
        Me.txtFinalDescripcionActual.Minimo = 0
        Me.txtFinalDescripcionActual.Modificado = False
        Me.txtFinalDescripcionActual.Multiline = True
        Me.txtFinalDescripcionActual.Name = "txtFinalDescripcionActual"
        Me.txtFinalDescripcionActual.Numerico_EsNumerico = False
        Me.txtFinalDescripcionActual.Numerico_NumeroDecimales = 0
        Me.txtFinalDescripcionActual.Numerico_SeparadorMiles = True
        Me.txtFinalDescripcionActual.Obligatorio = False
        Me.txtFinalDescripcionActual.ParametroID = 0
        Me.txtFinalDescripcionActual.ReadOnly = True
        Me.txtFinalDescripcionActual.Size = New System.Drawing.Size(195, 52)
        Me.txtFinalDescripcionActual.TabIndex = 7
        Me.txtFinalDescripcionActual.ValorMaximo = 0.0R
        Me.txtFinalDescripcionActual.ValorMinimo = 0.0R
        '
        'txtFinalLoteActual
        '
        Me.txtFinalLoteActual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFinalLoteActual.Enabled = False
        Me.txtFinalLoteActual.EsUnicoCampo = ""
        Me.txtFinalLoteActual.EsUnicoCampoID = ""
        Me.txtFinalLoteActual.EsUnicoID = 0
        Me.txtFinalLoteActual.EsUnicoTabla = ""
        Me.txtFinalLoteActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFinalLoteActual.Location = New System.Drawing.Point(96, 50)
        Me.txtFinalLoteActual.Minimo = 0
        Me.txtFinalLoteActual.Modificado = False
        Me.txtFinalLoteActual.Name = "txtFinalLoteActual"
        Me.txtFinalLoteActual.Numerico_EsNumerico = False
        Me.txtFinalLoteActual.Numerico_NumeroDecimales = 0
        Me.txtFinalLoteActual.Numerico_SeparadorMiles = True
        Me.txtFinalLoteActual.Obligatorio = False
        Me.txtFinalLoteActual.ParametroID = 0
        Me.txtFinalLoteActual.ReadOnly = True
        Me.txtFinalLoteActual.Size = New System.Drawing.Size(195, 26)
        Me.txtFinalLoteActual.TabIndex = 3
        Me.txtFinalLoteActual.ValorMaximo = 0.0R
        Me.txtFinalLoteActual.ValorMinimo = 0.0R
        '
        'txtFinalCantidadActual
        '
        Me.txtFinalCantidadActual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFinalCantidadActual.Enabled = False
        Me.txtFinalCantidadActual.EsUnicoCampo = ""
        Me.txtFinalCantidadActual.EsUnicoCampoID = ""
        Me.txtFinalCantidadActual.EsUnicoID = 0
        Me.txtFinalCantidadActual.EsUnicoTabla = ""
        Me.txtFinalCantidadActual.Location = New System.Drawing.Point(97, 86)
        Me.txtFinalCantidadActual.Minimo = 0
        Me.txtFinalCantidadActual.Modificado = False
        Me.txtFinalCantidadActual.Name = "txtFinalCantidadActual"
        Me.txtFinalCantidadActual.Numerico_EsNumerico = True
        Me.txtFinalCantidadActual.Numerico_NumeroDecimales = 0
        Me.txtFinalCantidadActual.Numerico_SeparadorMiles = True
        Me.txtFinalCantidadActual.Obligatorio = False
        Me.txtFinalCantidadActual.ParametroID = 0
        Me.txtFinalCantidadActual.ReadOnly = True
        Me.txtFinalCantidadActual.Size = New System.Drawing.Size(72, 20)
        Me.txtFinalCantidadActual.TabIndex = 5
        Me.txtFinalCantidadActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtFinalCantidadActual.ValorMaximo = 0.0R
        Me.txtFinalCantidadActual.ValorMinimo = 0.0R
        '
        'gbSalidas
        '
        Me.gbSalidas.Controls.Add(Me.cboSalidaTransicubas)
        Me.gbSalidas.Controls.Add(Me.cboSalidaRecipiente)
        Me.gbSalidas.Controls.Add(Me.cboSalidaProducto)
        Me.gbSalidas.Controls.Add(Me.lblTransicubas)
        Me.gbSalidas.Controls.Add(Me.lblSalidasRecipientes)
        Me.gbSalidas.Controls.Add(Me.lblSalidaCantidadReal)
        Me.gbSalidas.Controls.Add(Me.txtSalidaCantidadReal)
        Me.gbSalidas.Controls.Add(Label33)
        Me.gbSalidas.Controls.Add(Me.txtSalidaObservacion)
        Me.gbSalidas.Controls.Add(Me.chbSalidaMuestra)
        Me.gbSalidas.Controls.Add(Me.txtSalidaCantidad)
        Me.gbSalidas.Controls.Add(Label30)
        Me.gbSalidas.Controls.Add(Label31)
        Me.gbSalidas.Controls.Add(Me.txtSalidaCodigoLote)
        Me.gbSalidas.Controls.Add(Me.txtSalidaDescripcion)
        Me.gbSalidas.Controls.Add(Label32)
        Me.gbSalidas.Controls.Add(Label28)
        Me.gbSalidas.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbSalidas.Location = New System.Drawing.Point(0, 0)
        Me.gbSalidas.Name = "gbSalidas"
        Me.gbSalidas.Size = New System.Drawing.Size(341, 386)
        Me.gbSalidas.TabIndex = 7
        Me.gbSalidas.TabStop = False
        Me.gbSalidas.Text = "Salidas"
        '
        'cboSalidaTransicubas
        '
        Me.cboSalidaTransicubas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboSalidaTransicubas.FormattingEnabled = True
        Me.cboSalidaTransicubas.Location = New System.Drawing.Point(97, 322)
        Me.cboSalidaTransicubas.Margin = New System.Windows.Forms.Padding(2)
        Me.cboSalidaTransicubas.Name = "cboSalidaTransicubas"
        Me.cboSalidaTransicubas.Size = New System.Drawing.Size(216, 21)
        Me.cboSalidaTransicubas.TabIndex = 14
        Me.cboSalidaTransicubas.Visible = False
        '
        'cboSalidaRecipiente
        '
        Me.cboSalidaRecipiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboSalidaRecipiente.FormattingEnabled = True
        Me.cboSalidaRecipiente.Location = New System.Drawing.Point(97, 290)
        Me.cboSalidaRecipiente.Margin = New System.Windows.Forms.Padding(2)
        Me.cboSalidaRecipiente.Name = "cboSalidaRecipiente"
        Me.cboSalidaRecipiente.Size = New System.Drawing.Size(216, 21)
        Me.cboSalidaRecipiente.TabIndex = 12
        '
        'cboSalidaProducto
        '
        Me.cboSalidaProducto.Enabled = False
        Me.cboSalidaProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboSalidaProducto.FormattingEnabled = True
        Me.cboSalidaProducto.Location = New System.Drawing.Point(96, 33)
        Me.cboSalidaProducto.Margin = New System.Windows.Forms.Padding(2)
        Me.cboSalidaProducto.Name = "cboSalidaProducto"
        Me.cboSalidaProducto.Size = New System.Drawing.Size(217, 21)
        Me.cboSalidaProducto.TabIndex = 1
        '
        'lblTransicubas
        '
        Me.lblTransicubas.AutoSize = True
        Me.lblTransicubas.Location = New System.Drawing.Point(10, 324)
        Me.lblTransicubas.Name = "lblTransicubas"
        Me.lblTransicubas.Size = New System.Drawing.Size(68, 13)
        Me.lblTransicubas.TabIndex = 13
        Me.lblTransicubas.Text = "Transicubas:"
        Me.lblTransicubas.Visible = False
        '
        'lblSalidasRecipientes
        '
        Me.lblSalidasRecipientes.AutoSize = True
        Me.lblSalidasRecipientes.Location = New System.Drawing.Point(10, 296)
        Me.lblSalidasRecipientes.Name = "lblSalidasRecipientes"
        Me.lblSalidasRecipientes.Size = New System.Drawing.Size(66, 13)
        Me.lblSalidasRecipientes.TabIndex = 11
        Me.lblSalidasRecipientes.Text = "Recipientes:"
        '
        'lblSalidaCantidadReal
        '
        Me.lblSalidaCantidadReal.AutoSize = True
        Me.lblSalidaCantidadReal.Location = New System.Drawing.Point(10, 365)
        Me.lblSalidaCantidadReal.Name = "lblSalidaCantidadReal"
        Me.lblSalidaCantidadReal.Size = New System.Drawing.Size(77, 13)
        Me.lblSalidaCantidadReal.TabIndex = 15
        Me.lblSalidaCantidadReal.Text = "Cantidad Real:"
        '
        'txtSalidaCantidadReal
        '
        Me.txtSalidaCantidadReal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSalidaCantidadReal.EsUnicoCampo = ""
        Me.txtSalidaCantidadReal.EsUnicoCampoID = ""
        Me.txtSalidaCantidadReal.EsUnicoID = 0
        Me.txtSalidaCantidadReal.EsUnicoTabla = ""
        Me.txtSalidaCantidadReal.Location = New System.Drawing.Point(97, 362)
        Me.txtSalidaCantidadReal.Minimo = 0
        Me.txtSalidaCantidadReal.Modificado = False
        Me.txtSalidaCantidadReal.Name = "txtSalidaCantidadReal"
        Me.txtSalidaCantidadReal.Numerico_EsNumerico = True
        Me.txtSalidaCantidadReal.Numerico_NumeroDecimales = 0
        Me.txtSalidaCantidadReal.Numerico_SeparadorMiles = False
        Me.txtSalidaCantidadReal.Obligatorio = False
        Me.txtSalidaCantidadReal.ParametroID = 0
        Me.txtSalidaCantidadReal.Size = New System.Drawing.Size(86, 20)
        Me.txtSalidaCantidadReal.TabIndex = 16
        Me.txtSalidaCantidadReal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSalidaCantidadReal.ValorMaximo = 0.0R
        Me.txtSalidaCantidadReal.ValorMinimo = 0.0R
        '
        'txtSalidaObservacion
        '
        Me.txtSalidaObservacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSalidaObservacion.Location = New System.Drawing.Point(96, 198)
        Me.txtSalidaObservacion.MaxLength = 100
        Me.txtSalidaObservacion.Multiline = True
        Me.txtSalidaObservacion.Name = "txtSalidaObservacion"
        Me.txtSalidaObservacion.Size = New System.Drawing.Size(217, 52)
        Me.txtSalidaObservacion.TabIndex = 9
        '
        'chbSalidaMuestra
        '
        Me.chbSalidaMuestra.AutoSize = True
        Me.chbSalidaMuestra.Checked = True
        Me.chbSalidaMuestra.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbSalidaMuestra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbSalidaMuestra.Location = New System.Drawing.Point(97, 265)
        Me.chbSalidaMuestra.Name = "chbSalidaMuestra"
        Me.chbSalidaMuestra.Size = New System.Drawing.Size(83, 17)
        Me.chbSalidaMuestra.TabIndex = 10
        Me.chbSalidaMuestra.Text = "Con Muestra"
        Me.chbSalidaMuestra.UseVisualStyleBackColor = True
        '
        'txtSalidaCantidad
        '
        Me.txtSalidaCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSalidaCantidad.Enabled = False
        Me.txtSalidaCantidad.EsUnicoCampo = ""
        Me.txtSalidaCantidad.EsUnicoCampoID = ""
        Me.txtSalidaCantidad.EsUnicoID = 0
        Me.txtSalidaCantidad.EsUnicoTabla = ""
        Me.txtSalidaCantidad.Location = New System.Drawing.Point(96, 100)
        Me.txtSalidaCantidad.Minimo = 0
        Me.txtSalidaCantidad.Modificado = False
        Me.txtSalidaCantidad.Name = "txtSalidaCantidad"
        Me.txtSalidaCantidad.Numerico_EsNumerico = True
        Me.txtSalidaCantidad.Numerico_NumeroDecimales = 0
        Me.txtSalidaCantidad.Numerico_SeparadorMiles = True
        Me.txtSalidaCantidad.Obligatorio = False
        Me.txtSalidaCantidad.ParametroID = 0
        Me.txtSalidaCantidad.ReadOnly = True
        Me.txtSalidaCantidad.Size = New System.Drawing.Size(73, 20)
        Me.txtSalidaCantidad.TabIndex = 5
        Me.txtSalidaCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSalidaCantidad.ValorMaximo = 0.0R
        Me.txtSalidaCantidad.ValorMinimo = 0.0R
        '
        'txtSalidaCodigoLote
        '
        Me.txtSalidaCodigoLote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSalidaCodigoLote.Enabled = False
        Me.txtSalidaCodigoLote.EsUnicoCampo = "CodigoLote"
        Me.txtSalidaCodigoLote.EsUnicoCampoID = "LoteID"
        Me.txtSalidaCodigoLote.EsUnicoID = 0
        Me.txtSalidaCodigoLote.EsUnicoTabla = "Lotes"
        Me.txtSalidaCodigoLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalidaCodigoLote.Location = New System.Drawing.Point(95, 66)
        Me.txtSalidaCodigoLote.Minimo = 0
        Me.txtSalidaCodigoLote.Modificado = False
        Me.txtSalidaCodigoLote.Name = "txtSalidaCodigoLote"
        Me.txtSalidaCodigoLote.Numerico_EsNumerico = False
        Me.txtSalidaCodigoLote.Numerico_NumeroDecimales = 0
        Me.txtSalidaCodigoLote.Numerico_SeparadorMiles = True
        Me.txtSalidaCodigoLote.Obligatorio = False
        Me.txtSalidaCodigoLote.ParametroID = 0
        Me.txtSalidaCodigoLote.ReadOnly = True
        Me.txtSalidaCodigoLote.Size = New System.Drawing.Size(218, 26)
        Me.txtSalidaCodigoLote.TabIndex = 3
        Me.txtSalidaCodigoLote.ValorMaximo = 0.0R
        Me.txtSalidaCodigoLote.ValorMinimo = 0.0R
        '
        'txtSalidaDescripcion
        '
        Me.txtSalidaDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSalidaDescripcion.EsUnicoCampo = ""
        Me.txtSalidaDescripcion.EsUnicoCampoID = ""
        Me.txtSalidaDescripcion.EsUnicoID = 0
        Me.txtSalidaDescripcion.EsUnicoTabla = ""
        Me.txtSalidaDescripcion.Location = New System.Drawing.Point(96, 126)
        Me.txtSalidaDescripcion.MaxLength = 100
        Me.txtSalidaDescripcion.Minimo = 0
        Me.txtSalidaDescripcion.Modificado = False
        Me.txtSalidaDescripcion.Multiline = True
        Me.txtSalidaDescripcion.Name = "txtSalidaDescripcion"
        Me.txtSalidaDescripcion.Numerico_EsNumerico = False
        Me.txtSalidaDescripcion.Numerico_NumeroDecimales = 0
        Me.txtSalidaDescripcion.Numerico_SeparadorMiles = True
        Me.txtSalidaDescripcion.Obligatorio = False
        Me.txtSalidaDescripcion.ParametroID = 0
        Me.txtSalidaDescripcion.Size = New System.Drawing.Size(218, 60)
        Me.txtSalidaDescripcion.TabIndex = 7
        Me.txtSalidaDescripcion.ValorMaximo = 0.0R
        Me.txtSalidaDescripcion.ValorMinimo = 0.0R
        '
        'gbDiferencias
        '
        Me.gbDiferencias.Controls.Add(Me.cboDiferenciasTipoLote)
        Me.gbDiferencias.Controls.Add(Me.cboDiferenciaProducto)
        Me.gbDiferencias.Controls.Add(Label34)
        Me.gbDiferencias.Controls.Add(Me.txtdiferenciaObservaciones)
        Me.gbDiferencias.Controls.Add(Me.txtDiferenciasDescripcionFinal)
        Me.gbDiferencias.Controls.Add(Label27)
        Me.gbDiferencias.Controls.Add(Me.txtDiferenciasDescripcion)
        Me.gbDiferencias.Controls.Add(Label26)
        Me.gbDiferencias.Controls.Add(Me.txtDiferenciasCantidadFinal)
        Me.gbDiferencias.Controls.Add(Label24)
        Me.gbDiferencias.Controls.Add(Label12)
        Me.gbDiferencias.Controls.Add(Me.txtDiferenciasCantidad)
        Me.gbDiferencias.Controls.Add(Me.Label20)
        Me.gbDiferencias.Controls.Add(Label22)
        Me.gbDiferencias.Controls.Add(Label23)
        Me.gbDiferencias.Controls.Add(Me.txtDiferenciasCodigoLote)
        Me.gbDiferencias.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbDiferencias.Location = New System.Drawing.Point(0, 386)
        Me.gbDiferencias.Name = "gbDiferencias"
        Me.gbDiferencias.Size = New System.Drawing.Size(341, 305)
        Me.gbDiferencias.TabIndex = 8
        Me.gbDiferencias.TabStop = False
        Me.gbDiferencias.Text = "Diferencias"
        Me.gbDiferencias.Visible = False
        '
        'cboDiferenciasTipoLote
        '
        Me.cboDiferenciasTipoLote.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboDiferenciasTipoLote.Enabled = False
        Me.cboDiferenciasTipoLote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboDiferenciasTipoLote.FormattingEnabled = True
        Me.cboDiferenciasTipoLote.Location = New System.Drawing.Point(105, 44)
        Me.cboDiferenciasTipoLote.Margin = New System.Windows.Forms.Padding(2)
        Me.cboDiferenciasTipoLote.Name = "cboDiferenciasTipoLote"
        Me.cboDiferenciasTipoLote.Size = New System.Drawing.Size(199, 24)
        Me.cboDiferenciasTipoLote.TabIndex = 3
        '
        'cboDiferenciaProducto
        '
        Me.cboDiferenciaProducto.Enabled = False
        Me.cboDiferenciaProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboDiferenciaProducto.FormattingEnabled = True
        Me.cboDiferenciaProducto.Location = New System.Drawing.Point(105, 16)
        Me.cboDiferenciaProducto.Margin = New System.Windows.Forms.Padding(2)
        Me.cboDiferenciaProducto.Name = "cboDiferenciaProducto"
        Me.cboDiferenciaProducto.Size = New System.Drawing.Size(199, 21)
        Me.cboDiferenciaProducto.TabIndex = 1
        '
        'txtdiferenciaObservaciones
        '
        Me.txtdiferenciaObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdiferenciaObservaciones.Location = New System.Drawing.Point(105, 241)
        Me.txtdiferenciaObservaciones.MaxLength = 100
        Me.txtdiferenciaObservaciones.Multiline = True
        Me.txtdiferenciaObservaciones.Name = "txtdiferenciaObservaciones"
        Me.txtdiferenciaObservaciones.Size = New System.Drawing.Size(199, 52)
        Me.txtdiferenciaObservaciones.TabIndex = 15
        '
        'txtDiferenciasDescripcionFinal
        '
        Me.txtDiferenciasDescripcionFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDiferenciasDescripcionFinal.EsUnicoCampo = ""
        Me.txtDiferenciasDescripcionFinal.EsUnicoCampoID = ""
        Me.txtDiferenciasDescripcionFinal.EsUnicoID = 0
        Me.txtDiferenciasDescripcionFinal.EsUnicoTabla = ""
        Me.txtDiferenciasDescripcionFinal.Location = New System.Drawing.Point(105, 206)
        Me.txtDiferenciasDescripcionFinal.MaxLength = 100
        Me.txtDiferenciasDescripcionFinal.Minimo = 0
        Me.txtDiferenciasDescripcionFinal.Modificado = False
        Me.txtDiferenciasDescripcionFinal.Name = "txtDiferenciasDescripcionFinal"
        Me.txtDiferenciasDescripcionFinal.Numerico_EsNumerico = False
        Me.txtDiferenciasDescripcionFinal.Numerico_NumeroDecimales = 0
        Me.txtDiferenciasDescripcionFinal.Numerico_SeparadorMiles = True
        Me.txtDiferenciasDescripcionFinal.Obligatorio = False
        Me.txtDiferenciasDescripcionFinal.ParametroID = 0
        Me.txtDiferenciasDescripcionFinal.Size = New System.Drawing.Size(199, 20)
        Me.txtDiferenciasDescripcionFinal.TabIndex = 13
        Me.txtDiferenciasDescripcionFinal.ValorMaximo = 0.0R
        Me.txtDiferenciasDescripcionFinal.ValorMinimo = 0.0R
        '
        'txtDiferenciasDescripcion
        '
        Me.txtDiferenciasDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDiferenciasDescripcion.Enabled = False
        Me.txtDiferenciasDescripcion.EsUnicoCampo = ""
        Me.txtDiferenciasDescripcion.EsUnicoCampoID = ""
        Me.txtDiferenciasDescripcion.EsUnicoID = 0
        Me.txtDiferenciasDescripcion.EsUnicoTabla = ""
        Me.txtDiferenciasDescripcion.Location = New System.Drawing.Point(105, 140)
        Me.txtDiferenciasDescripcion.Minimo = 0
        Me.txtDiferenciasDescripcion.Modificado = False
        Me.txtDiferenciasDescripcion.Name = "txtDiferenciasDescripcion"
        Me.txtDiferenciasDescripcion.Numerico_EsNumerico = False
        Me.txtDiferenciasDescripcion.Numerico_NumeroDecimales = 0
        Me.txtDiferenciasDescripcion.Numerico_SeparadorMiles = True
        Me.txtDiferenciasDescripcion.Obligatorio = False
        Me.txtDiferenciasDescripcion.ParametroID = 0
        Me.txtDiferenciasDescripcion.ReadOnly = True
        Me.txtDiferenciasDescripcion.Size = New System.Drawing.Size(199, 20)
        Me.txtDiferenciasDescripcion.TabIndex = 9
        Me.txtDiferenciasDescripcion.ValorMaximo = 0.0R
        Me.txtDiferenciasDescripcion.ValorMinimo = 0.0R
        '
        'txtDiferenciasCantidadFinal
        '
        Me.txtDiferenciasCantidadFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDiferenciasCantidadFinal.Enabled = False
        Me.txtDiferenciasCantidadFinal.EsUnicoCampo = ""
        Me.txtDiferenciasCantidadFinal.EsUnicoCampoID = ""
        Me.txtDiferenciasCantidadFinal.EsUnicoID = 0
        Me.txtDiferenciasCantidadFinal.EsUnicoTabla = ""
        Me.txtDiferenciasCantidadFinal.Location = New System.Drawing.Point(105, 173)
        Me.txtDiferenciasCantidadFinal.Minimo = 0
        Me.txtDiferenciasCantidadFinal.Modificado = False
        Me.txtDiferenciasCantidadFinal.Name = "txtDiferenciasCantidadFinal"
        Me.txtDiferenciasCantidadFinal.Numerico_EsNumerico = True
        Me.txtDiferenciasCantidadFinal.Numerico_NumeroDecimales = 0
        Me.txtDiferenciasCantidadFinal.Numerico_SeparadorMiles = True
        Me.txtDiferenciasCantidadFinal.Obligatorio = False
        Me.txtDiferenciasCantidadFinal.ParametroID = 0
        Me.txtDiferenciasCantidadFinal.ReadOnly = True
        Me.txtDiferenciasCantidadFinal.Size = New System.Drawing.Size(77, 20)
        Me.txtDiferenciasCantidadFinal.TabIndex = 11
        Me.txtDiferenciasCantidadFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtDiferenciasCantidadFinal.ValorMaximo = 0.0R
        Me.txtDiferenciasCantidadFinal.ValorMinimo = 0.0R
        '
        'txtDiferenciasCantidad
        '
        Me.txtDiferenciasCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDiferenciasCantidad.Enabled = False
        Me.txtDiferenciasCantidad.EsUnicoCampo = ""
        Me.txtDiferenciasCantidad.EsUnicoCampoID = ""
        Me.txtDiferenciasCantidad.EsUnicoID = 0
        Me.txtDiferenciasCantidad.EsUnicoTabla = ""
        Me.txtDiferenciasCantidad.Location = New System.Drawing.Point(105, 110)
        Me.txtDiferenciasCantidad.Minimo = 0
        Me.txtDiferenciasCantidad.Modificado = False
        Me.txtDiferenciasCantidad.Name = "txtDiferenciasCantidad"
        Me.txtDiferenciasCantidad.Numerico_EsNumerico = True
        Me.txtDiferenciasCantidad.Numerico_NumeroDecimales = 0
        Me.txtDiferenciasCantidad.Numerico_SeparadorMiles = True
        Me.txtDiferenciasCantidad.Obligatorio = False
        Me.txtDiferenciasCantidad.ParametroID = 0
        Me.txtDiferenciasCantidad.ReadOnly = True
        Me.txtDiferenciasCantidad.Size = New System.Drawing.Size(72, 20)
        Me.txtDiferenciasCantidad.TabIndex = 7
        Me.txtDiferenciasCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtDiferenciasCantidad.ValorMaximo = 0.0R
        Me.txtDiferenciasCantidad.ValorMinimo = 0.0R
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(9, 49)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(55, 13)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "Tipo Lote:"
        '
        'txtDiferenciasCodigoLote
        '
        Me.txtDiferenciasCodigoLote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDiferenciasCodigoLote.Enabled = False
        Me.txtDiferenciasCodigoLote.EsUnicoCampo = "CodigoLote"
        Me.txtDiferenciasCodigoLote.EsUnicoCampoID = "LoteID"
        Me.txtDiferenciasCodigoLote.EsUnicoID = 0
        Me.txtDiferenciasCodigoLote.EsUnicoTabla = "Lotes"
        Me.txtDiferenciasCodigoLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiferenciasCodigoLote.Location = New System.Drawing.Point(105, 76)
        Me.txtDiferenciasCodigoLote.Minimo = 0
        Me.txtDiferenciasCodigoLote.Modificado = False
        Me.txtDiferenciasCodigoLote.Name = "txtDiferenciasCodigoLote"
        Me.txtDiferenciasCodigoLote.Numerico_EsNumerico = False
        Me.txtDiferenciasCodigoLote.Numerico_NumeroDecimales = 0
        Me.txtDiferenciasCodigoLote.Numerico_SeparadorMiles = True
        Me.txtDiferenciasCodigoLote.Obligatorio = False
        Me.txtDiferenciasCodigoLote.ParametroID = 0
        Me.txtDiferenciasCodigoLote.ReadOnly = True
        Me.txtDiferenciasCodigoLote.Size = New System.Drawing.Size(199, 26)
        Me.txtDiferenciasCodigoLote.TabIndex = 5
        Me.txtDiferenciasCodigoLote.ValorMaximo = 0.0R
        Me.txtDiferenciasCodigoLote.ValorMinimo = 0.0R
        '
        'butActualizar
        '
        Me.butActualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butActualizar.FlatAppearance.BorderSize = 0
        Me.butActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butActualizar.Image = Global.La_Andaluza_MovimientosDepositos.My.Resources.Resources.checkbox_2
        Me.butActualizar.Location = New System.Drawing.Point(525, 11)
        Me.butActualizar.Name = "butActualizar"
        Me.butActualizar.Size = New System.Drawing.Size(114, 49)
        Me.butActualizar.TabIndex = 16
        Me.butActualizar.Text = "Realizar Movimiento"
        Me.butActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.butActualizar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.Button1.Location = New System.Drawing.Point(443, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(42, 20)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Todo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cboProceso
        '
        Me.cboProceso.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboProceso.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboProceso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboProceso.FormattingEnabled = True
        Me.cboProceso.Location = New System.Drawing.Point(219, 10)
        Me.cboProceso.Margin = New System.Windows.Forms.Padding(2)
        Me.cboProceso.Name = "cboProceso"
        Me.cboProceso.Size = New System.Drawing.Size(288, 21)
        Me.cboProceso.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.gbCompra)
        Me.Panel1.Controls.Add(Me.gbLotes)
        Me.Panel1.Controls.Add(Me.gbPartida)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 72)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(350, 684)
        Me.Panel1.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cboProceso)
        Me.Panel2.Controls.Add(ProcesoIDLabel)
        Me.Panel2.Controls.Add(Me.dtpFecha)
        Me.Panel2.Controls.Add(FechaLabel)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 25)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(700, 47)
        Me.Panel2.TabIndex = 16
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Label18)
        Me.Panel3.Controls.Add(Me.txtObservaciones)
        Me.Panel3.Controls.Add(Me.txtCantidad)
        Me.Panel3.Controls.Add(ObservacionesLabel)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(CantidadLabel)
        Me.Panel3.Controls.Add(Me.chbSumaEnologico)
        Me.Panel3.Controls.Add(Me.butActualizar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 756)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(700, 63)
        Me.Panel3.TabIndex = 1000000001
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.gbDiferencias)
        Me.Panel4.Controls.Add(Me.gbSalidas)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(700, 72)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(341, 684)
        Me.Panel4.TabIndex = 1000000002
        '
        'frmEntMovimientosCopy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(700, 819)
        Me.ControlBox = True
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.gbFinal)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = True
        Me.Name = "frmEntMovimientosCopy"
        Me.Controls.SetChildIndex(Me.Panel3, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.txtTodoCorrecto, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.gbFinal, 0)
        Me.Controls.SetChildIndex(Me.Panel4, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtsMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPartida.ResumeLayout(False)
        Me.gbPartida.PerformLayout()
        Me.gbLotes.ResumeLayout(False)
        Me.gbLotes.PerformLayout()
        Me.gbCompra.ResumeLayout(False)
        Me.gbCompra.PerformLayout()
        Me.gbFinal.ResumeLayout(False)
        Me.gbFinal.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbSalidas.ResumeLayout(False)
        Me.gbSalidas.PerformLayout()
        Me.gbDiferencias.ResumeLayout(False)
        Me.gbDiferencias.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents DtsMovimientos As La_Andaluza_MovimientosDepositos.dtsMovimientos
    Private WithEvents gbDiferencias As System.Windows.Forms.GroupBox
    Private WithEvents cboPartidaTipoProducto As System.Windows.Forms.ComboBox
    Private WithEvents cbMedidacompra As System.Windows.Forms.ComboBox
    Private WithEvents cboFinalTipoProductoActual As System.Windows.Forms.ComboBox
    Private WithEvents cboSalidaTransicubas As System.Windows.Forms.ComboBox
    Private WithEvents cboSalidaProducto As System.Windows.Forms.ComboBox
    Private WithEvents cboDiferenciasTipoLote As System.Windows.Forms.ComboBox
    Private WithEvents cboDiferenciaProducto As System.Windows.Forms.ComboBox
    Private WithEvents cboAdicionProducto As System.Windows.Forms.ComboBox
    Private WithEvents cbMedidaLote As System.Windows.Forms.ComboBox
    Private WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Private WithEvents txtObservaciones As CuadroDeTexto
    Private WithEvents gbPartida As System.Windows.Forms.GroupBox
    Private WithEvents gbFinal As System.Windows.Forms.GroupBox
    Private WithEvents gbLotes As System.Windows.Forms.GroupBox
    Private WithEvents butActualizar As System.Windows.Forms.Button
    Private WithEvents txtPartidaLoteActual As CuadroDeTexto
    Private WithEvents txtPartidaCantidadActual As CuadroDeTexto
    Private WithEvents txtPartidaDescripcion As CuadroDeTexto
    Private WithEvents txtFinalLoteFinal As CuadroDeTexto
    Private WithEvents txtFinalCantidadFinal As CuadroDeTexto
    Private WithEvents txtFinalDescripcionFinal As CuadroDeTexto
    Private WithEvents txtFinalCantidadActual As CuadroDeTexto
    Private WithEvents txtFinalLoteActual As CuadroDeTexto
    Private WithEvents gbCompra As System.Windows.Forms.GroupBox
    Private WithEvents txtCompraLote As CuadroDeTexto
    Private WithEvents lblProcesoCompra As System.Windows.Forms.Label
    Private WithEvents txtAjusteCantidadActual As CuadroDeTexto
    Private WithEvents chbNuevoLote As System.Windows.Forms.CheckBox
    Private WithEvents cbMedidaPartida As CuadroDeTexto
    Private WithEvents chbSumaEnologico As System.Windows.Forms.CheckBox
    Private WithEvents lblFiltros As System.Windows.Forms.Label
    Private WithEvents Button1 As System.Windows.Forms.Button
    Private WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents txtFinalDescripcionActual As CuadroDeTexto
    Private WithEvents txtDiferenciasCantidad As CuadroDeTexto
    Private WithEvents Label20 As System.Windows.Forms.Label
    Private WithEvents txtDiferenciasCodigoLote As CuadroDeTexto
    Private WithEvents txtDiferenciasCantidadFinal As CuadroDeTexto
    Private WithEvents txtCompraDescripcion As System.Windows.Forms.TextBox
    Private WithEvents txtDiferenciasDescripcionFinal As CuadroDeTexto
    Private WithEvents txtDiferenciasDescripcion As CuadroDeTexto
    Private WithEvents chbConMuestra As System.Windows.Forms.CheckBox
    Private WithEvents gbSalidas As System.Windows.Forms.GroupBox
    Private WithEvents chbSalidaMuestra As System.Windows.Forms.CheckBox
    Private WithEvents txtSalidaCantidad As CuadroDeTexto
    Private WithEvents txtSalidaCodigoLote As CuadroDeTexto
    Private WithEvents txtSalidaDescripcion As CuadroDeTexto
    Private WithEvents txtCompraObservacion As System.Windows.Forms.TextBox
    Private WithEvents txtdiferenciaObservaciones As System.Windows.Forms.TextBox
    Private WithEvents txtSalidaObservacion As System.Windows.Forms.TextBox
    Private WithEvents txtFinalObservacionActual As System.Windows.Forms.TextBox
    Private WithEvents txtFinalObservacionFinal As System.Windows.Forms.TextBox
    Private WithEvents txtPartidaObservacion As System.Windows.Forms.TextBox
    Private WithEvents txtSalidaCantidadReal As CuadroDeTexto
    Private WithEvents lblSalidaCantidadReal As System.Windows.Forms.Label
    Private WithEvents chbFiltroDeshechos As System.Windows.Forms.CheckBox
    Private WithEvents lblSalidasRecipientes As System.Windows.Forms.Label
    Private WithEvents lblTransicubas As System.Windows.Forms.Label
    Private WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents Panel2 As System.Windows.Forms.Panel
    Private WithEvents Panel3 As System.Windows.Forms.Panel
    Private WithEvents Panel4 As System.Windows.Forms.Panel
    Public WithEvents cboProceso As System.Windows.Forms.ComboBox
    Public WithEvents cboPartidaDepositoID As System.Windows.Forms.ComboBox
    Public WithEvents cboFinalDepositoID As System.Windows.Forms.ComboBox
    Public WithEvents cboTipoLoteCompra As System.Windows.Forms.ComboBox
    Public WithEvents cboFinalTipoProductoFinal As System.Windows.Forms.ComboBox
    Public WithEvents txtCantidad As La_Andaluza_MovimientosDepositos.CuadroTextoNumerosNegativos
    Public WithEvents cboCompraProveedor As System.Windows.Forms.ComboBox
    Public WithEvents cboCompraProducto As System.Windows.Forms.ComboBox
    Public WithEvents txtCompraCantidad As La_Andaluza_MovimientosDepositos.CuadroDeTexto
    Public WithEvents cboSalidaRecipiente As System.Windows.Forms.ComboBox
    Public WithEvents cbFiltros As System.Windows.Forms.ComboBox
    Public WithEvents cboAjusteLotes As System.Windows.Forms.ComboBox

End Class
