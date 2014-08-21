Public Class MovimientoTrasiego
    Private gui As GuiMovimientoTrasiego
    Private bdTrasiego As bdTrasiego
    Private listadoDepositos As DataTable

    Public ReadOnly Property Form As Form
        Get
            Return CType(gui, Form)
        End Get
    End Property

    Public Sub New()
        gui = New GuiMovimientoTrasiego
        bdTrasiego = New bdTrasiego


        cargardatos()
        AddHandler gui.dgvorigen.SelectionChanged, AddressOf cargardatosSecundarios
    End Sub

    Public Sub cargardatos()
        listadoDepositos = bdTrasiego.listar_depositos()

        gui.OrigenDataSource = listadoDepositos
    End Sub

    Public Sub cargarDatosSecundarios()
        listadoDepositos = bdTrasiego.listar_depositos_excepto(Convert.ToInt32(gui.dgvorigen.CurrentRow.Cells(0).Value))
        gui.DestinoDataSource = listadoDepositos
    End Sub

End Class
