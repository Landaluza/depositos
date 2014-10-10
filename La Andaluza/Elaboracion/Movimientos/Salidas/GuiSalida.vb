Namespace Movimientos
    Public Class GuiSalida
        Private salida As Movimientos.Salida
        Public Event CantidadIncorrecta(lote As Integer, e As EventArgs)
        Public Event ProductoIncorrecto(lote As Integer, e As EventArgs)

        Public Sub New(ByVal salida As Movimientos.Salida)
            InitializeComponent()
            Me.salida = salida
            Dim pop As New DgvFilterPopup.DgvFilterManager(Me.dgvOrigen)
            Dim filter As New DecimalWatcher(Me.txtCantidad, 0)
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


        Public WriteOnly Property RecipientesDatasource As DataTable
            Set(value As DataTable)
                Me.cboRecipiente.mam_DataSource(value, False, False)
            End Set
        End Property

        Public ReadOnly Property valores As Movimientos.Salida
            Get


                salida.lotePartida.producto = Convert.ToInt32(dgvOrigen.CurrentRow.Cells("TipoProductoID").Value)
                salida.loteFinal.producto = Convert.ToInt32(dgvOrigen.CurrentRow.Cells("TipoProductoID").Value)
                salida.lotePartida.deposito = Convert.ToInt32(dgvOrigen.CurrentRow.Cells("depositoID").Value)
                salida.lotePartida.codigo_lote = Convert.ToString(dgvOrigen.CurrentRow.Cells("CodigoLote").Value)
                salida.lotePartida.tipo = Convert.ToInt32(dgvOrigen.CurrentRow.Cells("TipoLoteID").Value)
                salida.recipiente = Convert.ToInt32(cboRecipiente.SelectedValue)

                salida.sumarAdestino = chbSuma.Checked

                salida.cantidad = Convert.ToDouble(txtCantidad.Text)
                salida.fecha = dtpFecha.Value.Date

                Return salida
            End Get
        End Property

        Private Sub actualiza_descripcion(sender As Object, e As EventArgs)
            If dgvOrigen.CurrentRow Is Nothing Then
                Return
            End If

            Me.lDescripcionDestino.Text = "Se añadirá " & txtCantidad.Text & " litros de " & cboRecipiente.Text & _
                " al deposito " & dgvOrigen.CurrentRow.Cells("Codigo").Value.ToString & "."

            If Convert.IsDBNull(dgvOrigen.CurrentRow.Cells("CodigoLote").Value) Then
                Me.lDEscripcionDestino.Text &= "El deposito se encuentra vacio."
                Me.btncantidadOrigenIncorrecta.Visible = False
                Me.btnProductoOrigenncorrecto.Visible = False
            Else
                Me.lDEscripcionDestino.Text &= "El deposito contiene el lote " & dgvOrigen.CurrentRow.Cells("CodigoLote").Value.ToString
                Me.btncantidadOrigenIncorrecta.Visible = True
                Me.btnProductoOrigenncorrecto.Visible = True
            End If
        End Sub

        Private Sub GuiMovimientoCompra_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
            AddHandler dgvOrigen.SelectionChanged, AddressOf actualiza_descripcion
            AddHandler txtCantidad.TextChanged, AddressOf actualiza_descripcion
        End Sub


        Private Sub btnProductoDestinoIncorrecto_Click(sender As Object, e As EventArgs) Handles btnProductoOrigenncorrecto.Click
            RaiseEvent ProductoIncorrecto(Convert.ToInt32(dgvOrigen.CurrentRow.Cells("loteid").Value), Nothing)
        End Sub

        Private Sub btncantidadDestinoIncorrecta_Click(sender As Object, e As EventArgs) Handles btncantidadOrigenIncorrecta.Click
            RaiseEvent CantidadIncorrecta(Convert.ToInt32(dgvOrigen.CurrentRow.Cells("loteid").Value), Nothing)
        End Sub

        Private Sub btnProductoOrigenIncorrecto_Click(sender As Object, e As EventArgs) Handles btncantidadOrigenIncorrecta.Click
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