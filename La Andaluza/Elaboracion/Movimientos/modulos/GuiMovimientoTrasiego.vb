Public Class GuiMovimientoTrasiego


    Public WriteOnly Property OrigenDataSource As DataTable
        Set(value As DataTable)
            Me.dgvorigen.DataSource = value
            Me.dgvorigen.Columns("TipoProductoID").Visible = False
            Me.dgvorigen.Columns("TipoLoteID").Visible = False
            Me.dgvorigen.Columns("depositoID").Visible = False
            Me.dgvorigen.Columns("Capacidad").Visible = False
            Me.dgvorigen.Columns("Listado").Visible = False
        End Set
          

    End Property


    Public WriteOnly Property DestinoDataSource As DataTable
        Set(value As DataTable)
            Me.dgvDestino.DataSource = value
            Me.dgvDestino.Columns("TipoProductoID").Visible = False
            Me.dgvDestino.Columns("TipoLoteID").Visible = False
            Me.dgvDestino.Columns("depositoID").Visible = False
            Me.dgvDestino.Columns("Capacidad").Visible = False
            Me.dgvDestino.Columns("Listado").Visible = False
        End Set


    End Property
End Class