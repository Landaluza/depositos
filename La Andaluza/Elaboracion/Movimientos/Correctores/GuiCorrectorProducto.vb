Public Class GuiCorrectorProducto

    Public WriteOnly Property TipoProductoDataSource As DataTable
        Set(value As DataTable)
            Me.cboProducto.mam_DataSource(value, False, False)
        End Set
    End Property
    Public ReadOnly Property Producto As Integer
        Get

            Return Convert.ToInt32(Me.cboProducto.SelectedValue)
        End Get
    End Property

    Public Sub New()
        InitializeComponent()

     
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If Me.cboProducto.SelectedValue Is Nothing Then Return

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Hide()        
    End Sub
End Class