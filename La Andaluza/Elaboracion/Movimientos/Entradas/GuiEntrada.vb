Public Class GuiEntrada
    Dim entrada As Entradas.Entrada
    Public Sub New(ByVal tipoEntrada As Integer, ByVal entrada As Entradas.Entrada)
        InitializeComponent()
        Me.entrada = entrada
        Dim pop As New DgvFilterPopup.DgvFilterManager(Me.dgvDestino)
        Dim filter As New DecimalWatcher(Me.txtCantidad, 0)

        Me.chbMuestra.Checked = entrada.loteFinal.muestra

        If tipoEntrada = Entradas.Entrada.COMPRA Then
            cboProveedor.Visible = True
            lProveedor.Visible = True
            cboTipoLote.Visible = True
            lTlote.Visible = True
            cboTipoLote.SelectedValue = entrada.loteFinal.tipo
        Else
            cboProveedor.Visible = False
            lProveedor.Visible = False
            cboTipoLote.Visible = False
            lTlote.Visible = False
        End If
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
                Me.dgvDestino.Columns("LoteID").Visible = False
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

    Public ReadOnly Property valores As Entradas.Entrada
        Get


            entrada.lotePartida.producto = Convert.ToInt32(cboTipoProducto.SelectedValue)
            If cboProveedor.Visible Then entrada.proveedorCompra = Convert.ToInt32(cboProveedor.SelectedValue)

            entrada.loteFinal.deposito = Convert.ToInt32(dgvDestino.CurrentRow.Cells("depositoID").Value)

            If Convert.IsDBNull(dgvDestino.CurrentRow.Cells("CodigoLote").Value) Then
                entrada.loteFinal.producto = Convert.ToInt32(cboTipoProducto.SelectedValue)
                If cboTipoLote.Visible Then entrada.loteFinal.tipo = Convert.ToInt32(cboTipoLote.SelectedValue)
                entrada.sumarAdestino = True
            Else
                If Not chbLoteNuevo.Checked Then
                    entrada.loteFinal.producto = Convert.ToInt32(cboTipoProducto.SelectedValue)
                    If cboTipoLote.Visible Then entrada.loteFinal.tipo = Convert.ToInt32(cboTipoLote.SelectedValue)
                    entrada.loteFinal.id = Convert.ToInt32(dgvDestino.CurrentRow.Cells("LoteID").Value) 'lo guardamos para la trabilidad
                Else
                    entrada.loteFinal.codigo_lote = Convert.ToString(dgvDestino.CurrentRow.Cells("CodigoLote").Value)
                    entrada.loteFinal.id = Convert.ToInt32(dgvDestino.CurrentRow.Cells("LoteID").Value)
                    entrada.loteFinal.producto = Convert.ToInt32(dgvDestino.CurrentRow.Cells("TipoProductoID").Value)
                    If cboTipoLote.Visible Then entrada.loteFinal.tipo = Convert.ToInt32(dgvDestino.CurrentRow.Cells("TipoLoteID").Value)
                End If

                entrada.sumarAdestino = chbSuma.Checked
            End If

            entrada.cantidad = Convert.ToDouble(txtCantidad.Text)
            entrada.fecha = dtpFecha.Value.Date

            Return entrada
        End Get
    End Property

    Private Sub actualiza_descripcion(sender As Object, e As EventArgs)
        If dgvDestino.CurrentRow Is Nothing Then
            Return
        End If

        Me.lDescripcionDestino.Text = "Se añadirá " & txtCantidad.Text & " litros de " & cboProductoEntrada.Text & _
            " al deposito " & dgvDestino.CurrentRow.Cells("Codigo").Value.ToString & ". El producto se recepciono de " & cboProveedor.Text & "." & Environment.NewLine & Environment.NewLine

        If Convert.IsDBNull(dgvDestino.CurrentRow.Cells("CodigoLote").Value) Then
            Me.lDescripcionDestino.Text &= "El deposito se encuentra vacio."
            Me.btncantidadDestinoIncorrecta.Visible = False
            Me.btnProductoDestinoIncorrecto.Visible = False
            Me.chbLoteNuevo.Enabled = False
            Me.cboTipoProducto.Enabled = False
            Me.cboTipoProducto.Text = ""
        Else
            Me.lDescripcionDestino.Text &= "El deposito contiene el lote " & dgvDestino.CurrentRow.Cells("CodigoLote").Value.ToString
            Me.btncantidadDestinoIncorrecta.Visible = True
            Me.btnProductoDestinoIncorrecto.Visible = True
            Me.chbLoteNuevo.Enabled = True
            If chbLoteNuevo.Checked Then
                Me.cboTipoProducto.Enabled = True
            End If
        End If
    End Sub

    Private Sub GuiMovimientoCompra_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        AddHandler dgvDestino.SelectionChanged, AddressOf actualiza_descripcion
        AddHandler cboProductoEntrada.SelectedValueChanged, AddressOf actualiza_descripcion
        AddHandler cboProveedor.SelectedValueChanged, AddressOf actualiza_descripcion
        AddHandler cboTipoLote.SelectedValueChanged, AddressOf actualiza_descripcion
        AddHandler cboTipoProducto.SelectedValueChanged, AddressOf actualiza_descripcion
        AddHandler txtCantidad.TextChanged, AddressOf actualiza_descripcion
        AddHandler chbLoteNuevo.CheckedChanged, AddressOf actualiza_descripcion
    End Sub

End Class