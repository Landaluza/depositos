Public Class GuiDiferencia
    Private diferencia As Diferencias.Diferencia
    Public Event CantidadIncorrecta(lote As Integer, e As EventArgs)
    Public Event ProductoIncorrecto(lote As Integer, e As EventArgs)

    Public Sub New(ByVal diferencia As Diferencias.Diferencia)
        InitializeComponent()
        Me.diferencia = diferencia
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
                Me.dgvDestino.Columns("LoteID").Visible = False
            End If
        End Set
    End Property


    Public ReadOnly Property valores As Diferencias.Diferencia
        Get
            diferencia.lotePartida.deposito = Convert.ToInt32(dgvDestino.CurrentRow.Cells("depositoID").Value)
            diferencia.lotePartida.id = Convert.ToInt32(dgvDestino.CurrentRow.Cells("LoteID").Value)
            diferencia.lotePartida.codigo_lote = Convert.ToString(dgvDestino.CurrentRow.Cells("CodigoLote").Value)
            diferencia.lotePartida.producto = Convert.ToInt32(dgvDestino.CurrentRow.Cells("TipoProductoID").Value)
            diferencia.loteFinal.producto = Convert.ToInt32(dgvDestino.CurrentRow.Cells("TipoProductoID").Value)

            diferencia.cantidad = Convert.ToDouble(txtCantidad.Text)
            diferencia.fecha = dtpFecha.Value.Date

            Return diferencia
        End Get
    End Property

    Private Sub actualiza_descripcion(sender As Object, e As EventArgs)
        If dgvDestino.CurrentRow Is Nothing Then
            Return
        End If

        'Me.lDescripcionDestino.Text = "Se añadirá " & txtCantidad.Text & " litros de " & cboProductoEntrada.Text & _
        '    " al deposito " & dgvDestino.CurrentRow.Cells("Codigo").Value.ToString & ". El producto se recepciono de " & cboProveedor.Text & "." & Environment.NewLine & Environment.NewLine

        If Convert.IsDBNull(dgvDestino.CurrentRow.Cells("CodigoLote").Value) Then
            Me.lDescripcionDestino.Text &= "El deposito se encuentra vacio."
            Me.btncantidadDestinoIncorrecta.Visible = False
            Me.btnProductoDestinoIncorrecto.Visible = False
        Else
            Me.lDescripcionDestino.Text &= "El deposito contiene el lote " & dgvDestino.CurrentRow.Cells("CodigoLote").Value.ToString
            Me.btncantidadDestinoIncorrecta.Visible = True
            Me.btnProductoDestinoIncorrecto.Visible = True
        End If
    End Sub

    Private Sub GuiMovimientoCompra_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        AddHandler dgvDestino.SelectionChanged, AddressOf actualiza_descripcion
        AddHandler txtCantidad.TextChanged, AddressOf actualiza_descripcion
    End Sub


    Private Sub btnProductoDestinoIncorrecto_Click(sender As Object, e As EventArgs) Handles btnProductoDestinoIncorrecto.Click
        RaiseEvent ProductoIncorrecto(Convert.ToInt32(dgvDestino.CurrentRow.Cells("loteid").Value), Nothing)
    End Sub

    Private Sub btncantidadDestinoIncorrecta_Click(sender As Object, e As EventArgs) Handles btncantidadDestinoIncorrecta.Click
        RaiseEvent CantidadIncorrecta(Convert.ToInt32(dgvDestino.CurrentRow.Cells("loteid").Value), Nothing)
    End Sub
End Class