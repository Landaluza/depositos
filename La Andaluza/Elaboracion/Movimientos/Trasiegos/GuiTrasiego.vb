Namespace Movimientos

Public Class GuiTrasiego
        Private trasiego As Movimientos.Trasiego
    Public Event CantidadIncorrecta(lote As Integer, e As EventArgs)
    Public Event ProductoIncorrecto(lote As Integer, e As EventArgs)

        Public Sub New(ByVal trasiego As Movimientos.Trasiego)
            InitializeComponent()
            Me.trasiego = trasiego
            Dim pop As New DgvFilterPopup.DgvFilterManager(Me.dgvDestino)
            Dim filter As New DecimalWatcher(Me.txtCantidad, 0)

            If Me.trasiego.loteFinal.tipo <> 0 Then
                Me.cboTiplote.Visible = False
                Me.lTipoLote.Visible = False
            End If
        End Sub

    Public WriteOnly Property OrigenDatasource As DataTable
        Set(value As DataTable)
            Me.dgvOrigen.DataSource = value
            If Not value Is Nothing Then
                Me.dgvOrigen.Columns("TipoProductoID").Visible = False
                Me.dgvOrigen.Columns("TipoLoteID").Visible = False
                Me.dgvOrigen.Columns("depositoID").Visible = False
                Me.dgvOrigen.Columns("Capacidad").Visible = False
                Me.dgvOrigen.Columns("Listado").Visible = False
                Me.dgvOrigen.Columns("LoteID").Visible = False
            End If
        End Set
    End Property
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
            Me.cboTiplote.mam_DataSource(value, False, False)
        End Set
    End Property

    Public WriteOnly Property TipoProductoDatasource As DataTable
        Set(value As DataTable)
            Me.cboTipoProducto.mam_DataSource(value, False, False)
        End Set
    End Property

        Public ReadOnly Property valores As Movimientos.Trasiego
            Get


                trasiego.lotePartida.producto = Convert.ToInt32(dgvOrigen.CurrentRow.Cells("TipoProductoID").Value)
                trasiego.lotePartida.deposito = Convert.ToInt32(dgvOrigen.CurrentRow.Cells("depositoID").Value)
                trasiego.lotePartida.codigo_lote = Convert.ToString(dgvOrigen.CurrentRow.Cells("CodigoLote").Value)
                trasiego.lotePartida.id = Convert.ToInt32(dgvOrigen.CurrentRow.Cells("LoteID").Value)
                trasiego.lotePartida.tipo = Convert.ToInt32(dgvOrigen.CurrentRow.Cells("TipoLoteID").Value)

                trasiego.loteFinal.deposito = Convert.ToInt32(dgvDestino.CurrentRow.Cells("depositoID").Value)

                If Convert.IsDBNull(dgvDestino.CurrentRow.Cells("CodigoLote").Value) Then
                    trasiego.loteFinal.producto = Convert.ToInt32(cboTipoProducto.SelectedValue)
                    trasiego.sumarAdestino = True
                    If cboTiplote.Visible Then trasiego.loteFinal.tipo = Convert.ToInt32(cboTiplote.SelectedValue)
                Else
                    trasiego.loteFinal.id = Convert.ToInt32(dgvDestino.CurrentRow.Cells("LoteID").Value) 'lo guardamos para la trabilidad

                    If Not chbLoteNuevo.Checked Then
                        trasiego.loteFinal.producto = Convert.ToInt32(cboTipoProducto.SelectedValue)
                        If cboTiplote.Visible Then trasiego.loteFinal.tipo = Convert.ToInt32(cboTiplote.SelectedValue)
                    Else
                        trasiego.loteFinal.codigo_lote = Convert.ToString(dgvDestino.CurrentRow.Cells("CodigoLote").Value)
                        trasiego.loteFinal.producto = Convert.ToInt32(dgvDestino.CurrentRow.Cells("TipoProductoID").Value)
                        If cboTiplote.Visible Then trasiego.loteFinal.tipo = Convert.ToInt32(dgvDestino.CurrentRow.Cells("TipoLoteID").Value)

                    End If

                    trasiego.sumarAdestino = chbSuma.Checked
                End If



                trasiego.cantidad = Convert.ToDouble(txtCantidad.Text)
                trasiego.fecha = dtpFecha.Value.Date
                trasiego.muestra = Me.chbMuetra.Checked

                Return trasiego
            End Get
        End Property

    Private Sub actualiza_descripcion(sender As Object, e As EventArgs)
        If dgvDestino.CurrentRow Is Nothing Then
            Return
        End If


        If Convert.IsDBNull(dgvDestino.CurrentRow.Cells("CodigoLote").Value) Then
            Me.btncantidadDestinoIncorrecta.Visible = False
            Me.btnProductoDestinaIncorrecto.Visible = False
            Me.chbLoteNuevo.Enabled = False
            Me.cboTipoProducto.Enabled = False
            Me.cboTipoProducto.Text = ""
        Else
            Me.btncantidadDestinoIncorrecta.Visible = True
            Me.btnProductoDestinaIncorrecto.Visible = True
            Me.chbLoteNuevo.Enabled = True
            If chbLoteNuevo.Checked Then
                Me.cboTipoProducto.Enabled = True
            End If
        End If
    End Sub

    Private Sub GuiMovimientoCompra_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        AddHandler dgvDestino.SelectionChanged, AddressOf actualiza_descripcion
        AddHandler cboTiplote.SelectedValueChanged, AddressOf actualiza_descripcion
        AddHandler cboTipoProducto.SelectedValueChanged, AddressOf actualiza_descripcion
        AddHandler txtCantidad.TextChanged, AddressOf actualiza_descripcion
        AddHandler chbLoteNuevo.CheckedChanged, AddressOf actualiza_descripcion
    End Sub


    Private Sub btnProductoDestinoIncorrecto_Click(sender As Object, e As EventArgs) Handles btnProductoDestinaIncorrecto.Click
        RaiseEvent ProductoIncorrecto(Convert.ToInt32(dgvDestino.CurrentRow.Cells("loteid").Value), Nothing)
    End Sub

    Private Sub btncantidadDestinoIncorrecta_Click(sender As Object, e As EventArgs) Handles btncantidadDestinoIncorrecta.Click
        RaiseEvent CantidadIncorrecta(Convert.ToInt32(dgvDestino.CurrentRow.Cells("loteid").Value), Nothing)
    End Sub

    Private Sub btnProductoOrigenIncorrecto_Click(sender As Object, e As EventArgs) Handles btnProductoOrigenIncorrecto.Click
        RaiseEvent ProductoIncorrecto(Convert.ToInt32(dgvOrigen.CurrentRow.Cells("loteid").Value), Nothing)
    End Sub

    Private Sub btncantidadOrigenIncorrecta_Click(sender As Object, e As EventArgs) Handles btncantidadOrigenIncorrecta.Click
        RaiseEvent CantidadIncorrecta(Convert.ToInt32(dgvOrigen.CurrentRow.Cells("loteid").Value), Nothing)
    End Sub

    Private Sub btnTodo_Click(sender As Object, e As EventArgs) Handles btnTodo.Click
        txtCantidad.Text = Convert.ToString(dgvOrigen.CurrentRow.Cells("CantidadRestante").Value)
    End Sub
    End Class
End Namespace
