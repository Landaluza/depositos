Public Class GuiMovimientoTrasiego
    Public Sub New()
        InitializeComponent()
        Dim pop As New DgvFilterPopup.DgvFilterManager(Me.dgvorigen)
        Dim pop2 As New DgvFilterPopup.DgvFilterManager(Me.dgvDestino)

    End Sub

    Public WriteOnly Property OrigenDataSource As DataTable
        Set(value As DataTable)
            Me.dgvorigen.DataSource = value
            If Not value Is Nothing Then
                Me.dgvorigen.Columns("TipoProductoID").Visible = False
                Me.dgvorigen.Columns("TipoLoteID").Visible = False
                Me.dgvorigen.Columns("depositoID").Visible = False
                Me.dgvorigen.Columns("Capacidad").Visible = False
                Me.dgvorigen.Columns("Listado").Visible = False
            End If
        End Set
    End Property


    Public WriteOnly Property DestinoDataSource As DataTable
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

    Public WriteOnly Property TipoProductoDatasource As DataTable
        Set(value As DataTable)
            cboTipoProducto.mam_DataSource(value, False, False)
        End Set
    End Property

    Public WriteOnly Property TipoLoteDatasource As DataTable
        Set(value As DataTable)
            cboTipoLote.mam_DataSource(value, False, False)
        End Set
    End Property

    Private Sub dgvorigen_SelectionChanged(sender As Object, e As EventArgs) Handles dgvorigen.SelectionChanged
        lDescripcionOrigen.Text = "Se ha elegido el deposito " & dgvorigen.CurrentRow.Cells("Codigo").Value.ToString & ". Que contiene " & dgvorigen.CurrentRow.Cells("CantidadRestante").Value.ToString & " litros de " & dgvorigen.CurrentRow.Cells("producto").Value.ToString
    End Sub

    Private Sub dgvDestino_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDestino.SelectionChanged
        lDescripcionDestino.Text = "Se ha elegido el deposito " & dgvDestino.CurrentRow.Cells("Codigo").Value.ToString & ". Que contiene " & dgvDestino.CurrentRow.Cells("CantidadRestante").Value.ToString & " litros de " & dgvDestino.CurrentRow.Cells("producto").Value.ToString
    End Sub


    Private Sub rbLoteDEstino_CheckedChanged(sender As Object, e As EventArgs) Handles rbLoteDEstino.CheckedChanged, rbNuevoLote.CheckedChanged
        panNuevoLote.Visible = rbNuevoLote.Checked
        chbSuma.Visible = rbLoteDEstino.Checked
    End Sub
End Class