Public Class GuiMovimientoCompra

    Public Sub New()
        InitializeComponent()
        Dim pop As New DgvFilterPopup.DgvFilterManager(Me.dgvDestino)

        Dim filter As New DecimalWatcher(Me.txtCantidad, 0)

    End Sub

    Public WriteOnly Property DestinoDatasource As DataTable
        Set(value As DataTable)
            Me.dgvDestino.DataSource = value
            If Not value Is Nothing Then
                Me.dgvDestino.Columns("TipoProductoID").Visible = False
                Me.dgvDestino.Columns("TipoLoteID").Visible = False
                Me.dgvDestino.Columns("depositoID").Visible = False
                Me.dgvDestino.Columns("Capacidad").Visible = False
                Me.dgvDestino.Columns("Listado").Visible = False
            End If
        End Set
    End Property

    Public WriteOnly Property TipoLoteDatasource As DataTable
        Set(value As DataTable)
            Me.cboTipoLote.mam_DataSource(value, False, False)
        End Set
    End Property

    Public WriteOnly Property TipoProductoEntradaDatasource As DataTable
        Set(value As DataTable)
            Me.cboProductoEntrada.mam_DataSource(value, False, False)
        End Set
    End Property

    Public WriteOnly Property ProveedorEntradaDatasource As DataTable
        Set(value As DataTable)
            Me.cboProveedor.mam_DataSource(value, False, False)
        End Set
    End Property

    Public WriteOnly Property TipoProductoDatasource As DataTable
        Set(value As DataTable)
            Me.cboTipoProducto.mam_DataSource(value, False, False)
        End Set
    End Property

    Public ReadOnly Property valores As Compra
        Get
            Return Nothing
        End Get
    End Property
End Class