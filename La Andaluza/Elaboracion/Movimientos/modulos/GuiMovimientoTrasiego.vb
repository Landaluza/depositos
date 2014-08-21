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

    Private Sub dgvorigen_SelectionChanged(sender As Object, e As EventArgs) Handles dgvorigen.SelectionChanged
        lDescripcionOrigen.Text = "Se ha elegido el deposito " & dgvorigen.CurrentRow.Cells("Codigo").Value.ToString & ". Que contiene " & dgvorigen.CurrentRow.Cells("CantidadRestante").Value.ToString & " litros de " & dgvorigen.CurrentRow.Cells("producto").Value.ToString
    End Sub

    Private Sub dgvDestino_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDestino.SelectionChanged
        lDescripcionDestino.Text = "Se ha elegido el deposito " & dgvDestino.CurrentRow.Cells("Codigo").Value.ToString & ". Que contiene " & dgvDestino.CurrentRow.Cells("CantidadRestante").Value.ToString & " litros de " & dgvDestino.CurrentRow.Cells("producto").Value.ToString
    End Sub
End Class