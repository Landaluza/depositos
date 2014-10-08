Public Class Guifiltrado
    Private filtrado As filtrados.filtrado
    Public Event CantidadIncorrecta(lote As Integer, e As EventArgs)
    Public Event ProductoIncorrecto(lote As Integer, e As EventArgs)

    Public Sub New(ByVal filtrado As filtrados.filtrado)
        InitializeComponent()
        Me.filtrado = filtrado
        Dim pop As New DgvFilterPopup.DgvFilterManager(Me.dgvDestino)
        Dim filter As New DecimalWatcher(Me.txtCantidad, 0)

        Me.chbMuestra.Checked = filtrado.loteFinal.muestra
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
            Me.cboProducto.mam_DataSource(value, False, False)
        End Set
    End Property

    Public WriteOnly Property FiltroDatasource As DataTable
        Set(value As DataTable)
            Me.cboFiltro.mam_DataSource(value, False, False)
        End Set
    End Property


    Public ReadOnly Property valores As filtrados.filtrado
        Get


            filtrado.lotePartida.producto = Convert.ToInt32(dgvOrigen.CurrentRow.Cells("TipoProductoID").Value)
            filtrado.lotePartida.tipo = Convert.ToInt32(dgvOrigen.CurrentRow.Cells("TipoLoteID").Value)
            filtrado.lotePartida.codigo_lote = Convert.ToString(dgvOrigen.CurrentRow.Cells("CodigoLote").Value)
            filtrado.lotePartida.id = Convert.ToInt32(dgvOrigen.CurrentRow.Cells("LoteID").Value)
            filtrado.filtro = Convert.ToInt32(cboFiltro.SelectedValue)

            filtrado.lotePartida.deposito = Convert.ToInt32(dgvOrigen.CurrentRow.Cells("depositoID").Value)
            filtrado.loteFinal.deposito = Convert.ToInt32(dgvDestino.CurrentRow.Cells("depositoID").Value)

            If Convert.IsDBNull(dgvDestino.CurrentRow.Cells("CodigoLote").Value) Then
                filtrado.loteFinal.codigo_lote = ""
                filtrado.loteFinal.id = 0
                filtrado.loteFinal.producto = Convert.ToInt32(cboProducto.SelectedValue)
                filtrado.sumarAdestino = True
            Else
                If Not chbLoteNuevo.Checked Then
                    filtrado.loteFinal.codigo_lote = ""
                    filtrado.loteFinal.producto = Convert.ToInt32(cboProducto.SelectedValue)
                    filtrado.loteFinal.id = Convert.ToInt32(dgvDestino.CurrentRow.Cells("LoteID").Value) 'lo guardamos para la trabilidad
                Else
                    filtrado.loteFinal.codigo_lote = Convert.ToString(dgvDestino.CurrentRow.Cells("CodigoLote").Value)
                    filtrado.loteFinal.id = Convert.ToInt32(dgvDestino.CurrentRow.Cells("LoteID").Value)
                    filtrado.loteFinal.producto = Convert.ToInt32(dgvDestino.CurrentRow.Cells("TipoProductoID").Value)
                End If

                filtrado.sumarAdestino = chbSuma.Checked
            End If

            filtrado.cantidad = Convert.ToDouble(txtCantidad.Text)
            filtrado.fecha = dtpFecha.Value.Date

            Return filtrado
        End Get
    End Property

    Private Sub actualiza_descripcion(sender As Object, e As EventArgs)
        If dgvDestino.CurrentRow Is Nothing Then
            Return
        End If

        'Me.lDescripcionDestino.Text = "Se añadirá " & txtCantidad.Text & " litros de " & cboProducto.Text & _
        '    " al deposito " & dgvDestino.CurrentRow.Cells("Codigo").Value.ToString & ". El producto se recepciono de " & cboFiltro.Text & "." & Environment.NewLine & Environment.NewLine

        If Convert.IsDBNull(dgvDestino.CurrentRow.Cells("CodigoLote").Value) Then
            Me.lDescripcionDestino.Text &= "El deposito se encuentra vacio."
            Me.btnCantidadDestinoIncorrecta.Visible = False
            Me.btnProductoDestinoIncorrecto.Visible = False
            Me.chbLoteNuevo.Enabled = False                        
        Else
            Me.lDescripcionDestino.Text &= "El deposito contiene el lote " & dgvDestino.CurrentRow.Cells("CodigoLote").Value.ToString
            Me.btnCantidadDestinoIncorrecta.Visible = True
            Me.btnProductoDestinoIncorrecto.Visible = True
            Me.chbLoteNuevo.Enabled = True
            If chbLoteNuevo.Checked Then
                Me.cboProducto.Enabled = True
            End If
        End If
    End Sub

    Private Sub GuiMovimientoCompra_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        AddHandler dgvDestino.SelectionChanged, AddressOf actualiza_descripcion
        AddHandler cboFiltro.SelectedValueChanged, AddressOf actualiza_descripcion
        'AddHandler cboTipoLote.SelectedValueChanged, AddressOf actualiza_descripcion
        AddHandler cboProducto.SelectedValueChanged, AddressOf actualiza_descripcion
        AddHandler txtCantidad.TextChanged, AddressOf actualiza_descripcion
        AddHandler chbLoteNuevo.CheckedChanged, AddressOf actualiza_descripcion
    End Sub


    Private Sub btnProductoDestinoIncorrecto_Click(sender As Object, e As EventArgs) Handles btnProductoDestinoIncorrecto.Click
        RaiseEvent ProductoIncorrecto(Convert.ToInt32(dgvDestino.CurrentRow.Cells("loteid").Value), Nothing)
    End Sub

    Private Sub btncantidadDestinoIncorrecta_Click(sender As Object, e As EventArgs) Handles btnCantidadDestinoIncorrecta.Click
        RaiseEvent CantidadIncorrecta(Convert.ToInt32(dgvDestino.CurrentRow.Cells("loteid").Value), Nothing)
    End Sub

    Private Sub btnTodo_Click(sender As Object, e As EventArgs) Handles btnTodo.Click
        txtCantidad.Text = Convert.ToString(dgvOrigen.CurrentRow.Cells("CantidadRestante").Value)
    End Sub
End Class