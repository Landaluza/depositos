Public Class EngineTrasiegos

    Private spTrasiegos As SpTrasiegos

    Public Sub New()
        spTrasiegos = New SpTrasiegos
    End Sub

    Public Sub SetValues(ByRef cboDepositoOrigen As ComboBox, ByRef cboDepositoDestino As ComboBox, ByRef txtCantidad As TextBox, ByRef cboProducto As ComboBox, ByRef cboLote As ComboBox)
        cboProducto.mam_DataSource(spTrasiegos.devolver_productos(), False, )
        cboLote.mam_DataSource(spTrasiegos.devolver_tipos_de_lotes(), False, )
        cboDepositoDestino.mam_DataSource(spTrasiegos.devolver_depositos(), False, )
        cboDepositoOrigen.mam_DataSource(spTrasiegos.devolver_depositos_ocupados(), False, )
    End Sub
End Class
