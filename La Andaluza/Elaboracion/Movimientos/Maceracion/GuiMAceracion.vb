Public Class GuiMAceracion
    Private maceracion As Maceraciones.Maceracion
    Public Event CantidadIncorrecta(lote As Integer, e As EventArgs)
    Public Event ProductoIncorrecto(lote As Integer, e As EventArgs)

    Public Sub New(ByVal maceracion As Maceraciones.Maceracion)
        InitializeComponent()
        Me.maceracion = maceracion
        Dim pop As New DgvFilterPopup.DgvFilterManager(Me.dgvDestino)
        Dim filter As New DecimalWatcher(Me.txtCantidad, 0)

        Me.chbMuestra.Checked = maceracion.loteFinal.muestra
    End Sub

    Public WriteOnly Property DestinoDatasource As DataTable
        Set(value As DataTable)
            Me.dgvDestino.DataSource = value
            If Not value Is Nothing Then
                Me.dgvDestino.Columns("depositoID").Visible = False
            End If
        End Set
    End Property

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


    Public WriteOnly Property TipoProductoEntradaDatasource As DataTable
        Set(value As DataTable)
            Me.cboTipoProducto.mam_DataSource(value, False, False)
        End Set
    End Property

    Public WriteOnly Property TipoLoteDatasource As DataTable
        Set(value As DataTable)
            Me.cboTipoLote.mam_DataSource(value, False, False)
        End Set
    End Property


    Public ReadOnly Property valores As Maceraciones.Maceracion
        Get


            maceracion.lotePartida.producto = Convert.ToInt32(dgvOrigen.CurrentRow.Cells("TipoProductoID").Value)


            maceracion.lotePartida.deposito = Convert.ToInt32(dgvOrigen.CurrentRow.Cells("depositoID").Value)
            maceracion.lotePartida.deposito = Convert.ToInt32(dgvDestino.CurrentRow.Cells("depositoID").Value)

            If Convert.IsDBNull(dgvDestino.CurrentRow.Cells("CodigoLote").Value) Then
                maceracion.loteFinal.producto = Convert.ToInt32(cboTipoProducto.SelectedValue)
                'If cboTipoLote.Visible Then maceracion.loteFinal.tipo = Convert.ToInt32(cboTipoLote.SelectedValue)
                maceracion.sumarAdestino = True
            Else
                If Not chbLoteNuevo.Checked Then
                    maceracion.loteFinal.producto = Convert.ToInt32(cboTipoProducto.SelectedValue)
                    'If cboTipoLote.Visible Then maceracion.loteFinal.tipo = Convert.ToInt32(cboTipoLote.SelectedValue)
                    maceracion.loteFinal.id = Convert.ToInt32(dgvDestino.CurrentRow.Cells("LoteID").Value) 'lo guardamos para la trabilidad
                Else
                    maceracion.loteFinal.codigo_lote = Convert.ToString(dgvDestino.CurrentRow.Cells("CodigoLote").Value)
                    maceracion.loteFinal.id = Convert.ToInt32(dgvDestino.CurrentRow.Cells("LoteID").Value)
                    maceracion.loteFinal.producto = Convert.ToInt32(dgvDestino.CurrentRow.Cells("TipoProductoID").Value)
                    'If cboTipoLote.Visible Then maceracion.loteFinal.tipo = Convert.ToInt32(dgvDestino.CurrentRow.Cells("TipoLoteID").Value)
                End If

                maceracion.sumarAdestino = chbSuma.Checked
            End If

            maceracion.cantidad = Convert.ToDouble(txtCantidad.Text)
            maceracion.fecha = dtpFecha.Value.Date

            Return maceracion
        End Get
    End Property

    Private Sub actualiza_descripcion(sender As Object, e As EventArgs)
        If dgvDestino.CurrentRow Is Nothing Then
            Return
        End If

        'Me.lDescripcionDestino.Text = "Se añadirá " & txtCantidad.Text & " litros de " & cboProducto.Text & _
        '    " al deposito " & dgvDestino.CurrentRow.Cells("Codigo").Value.ToString & ". El producto se recepciono de " & cboFiltro.Text & "." & Environment.NewLine & Environment.NewLine

        'If Convert.IsDBNull(dgvDestino.CurrentRow.Cells("CodigoLote").Value) Then
        '    Me.lDescripcionDestino.Text &= "El deposito se encuentra vacio."
        '    Me.btncantidadDestinoIncorrecta.Visible = False
        '    Me.btnProductoDestinoIncorrecto.Visible = False
        '    Me.chbLoteNuevo.Enabled = False
        '    'Me.cboTipoProducto.Enabled = False
        '    Me.cboProducto.Text = ""
        'Else
        '    Me.lDescripcionDestino.Text &= "El deposito contiene el lote " & dgvDestino.CurrentRow.Cells("CodigoLote").Value.ToString
        '    Me.btncantidadDestinoIncorrecta.Visible = True
        '    Me.btnProductoDestinoIncorrecto.Visible = True
        '    Me.chbLoteNuevo.Enabled = True
        '    If chbLoteNuevo.Checked Then
        '        Me.cboProducto.Enabled = True
        '    End If
        'End If
    End Sub

    Private Sub GuiMovimientoCompra_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        AddHandler dgvDestino.SelectionChanged, AddressOf actualiza_descripcion
        AddHandler cboTipoLote.SelectedValueChanged, AddressOf actualiza_descripcion
        AddHandler txtCantidad.TextChanged, AddressOf actualiza_descripcion
        AddHandler chbLoteNuevo.CheckedChanged, AddressOf actualiza_descripcion
    End Sub


    Private Sub btnProductoDestinoIncorrecto_Click(sender As Object, e As EventArgs) Handles btnProductoDestinoIncorrecto.Click
        RaiseEvent ProductoIncorrecto(Convert.ToInt32(dgvDestino.CurrentRow.Cells("loteid").Value), Nothing)
    End Sub

    Private Sub btncantidadDestinoIncorrecta_Click(sender As Object, e As EventArgs) Handles btncantidadDestinoIncorrecta.Click
        RaiseEvent CantidadIncorrecta(Convert.ToInt32(dgvDestino.CurrentRow.Cells("loteid").Value), Nothing)
    End Sub
End Class