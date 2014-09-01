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

    Private Sub actualiza_descripcion(sender As Object, e As EventArgs)
        If dgvDestino.CurrentRow Is Nothing Then
            Return
        End If

        Me.lDescripcionDestino.Text = "Se añadirá " & txtCantidad.Text & " litros de " & cboProductoEntrada.Text & _
            " al deposito " & dgvDestino.CurrentRow.Cells("Codigo").Value.ToString & ". El producto se recepciono de " & cboProveedor.Text & "." & Environment.NewLine
    End Sub

    Private Sub GuiMovimientoCompra_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        AddHandler dgvDestino.SelectionChanged, AddressOf actualiza_descripcion
        AddHandler cboProductoEntrada.SelectedValueChanged, AddressOf actualiza_descripcion
        AddHandler cboProveedor.SelectedValueChanged, AddressOf actualiza_descripcion
        AddHandler cboTipoLote.SelectedValueChanged, AddressOf actualiza_descripcion
        AddHandler cboTipoProducto.SelectedValueChanged, AddressOf actualiza_descripcion
        AddHandler txtCantidad.TextChanged, AddressOf actualiza_descripcion
    End Sub
End Class