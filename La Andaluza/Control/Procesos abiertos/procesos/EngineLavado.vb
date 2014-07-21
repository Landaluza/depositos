Public Class EngineLavado
    Inherits ProcesosEngine
    Implements ProcesoMovimiento

    Private spLavado As SpLavado
    Private gui As frmLavado
    Public Sub New(ByVal id As Integer, ByRef frm As frmLavado)
        MyBase.New(id)
        spLavado = New SpLavado
        gui = frm

        CargarDatos()
        AddHandler gui.cboDepositoPArtida.SelectedValueChanged, AddressOf Autoguardado
        AddHandler gui.txtCantidad.TextChanged, AddressOf Autoguardado
        AddHandler gui.btnExportar.Click, AddressOf Exportar
        AddHandler gui.btnBorrar.Click, AddressOf borrar
    End Sub

    Private Sub CargarDatos() Implements ProcesoMovimiento.CargarDatos
        gui.cboDepositoPArtida.mam_DataSource(spLavado.devolver_depositos(), False, )

        Dim dt As DataTable = MyBase.seleccionar()
        If Not dt Is Nothing Then
            gui.cboDepositoPArtida.SelectedValue = dt.Rows(0).Item(6)
            gui.txtCantidad.Text = dt.Rows(0).Item(3).ToString
        End If
    End Sub
    Private Sub Autoguardado(sender As Object, e As EventArgs) Implements ProcesoMovimiento.Autoguardado
        Dim origen As Integer
        Dim cantidad As Double

        If gui.cboDepositoPArtida.SelectedValue Is Nothing Then
            origen = 0
        Else
            Try
                origen = CType(gui.cboDepositoPArtida.SelectedValue, Integer)
            Catch ex As Exception
                origen = 0
            End Try
        End If

        If gui.txtCantidad.Text = "" Or Not IsNumeric(gui.txtCantidad.Text) Then
            cantidad = 0
        Else
            Try
                cantidad = CType(gui.txtCantidad.Text.Replace(".", ","), Double)
            Catch ex As Exception
                cantidad = 0
            End Try
        End If


        spLavado.actualizar(origen, cantidad, id)
    End Sub

    Private Sub Exportar(sender As Object, e As EventArgs) Implements ProcesoMovimiento.Exportar
        gui.frmEspera = New frmEspera("Cargando datos")
        gui.frmEspera.Show()


        gui.frmMovimientos = New frmEntMovimientosCopy
        AddHandler gui.frmMovimientos.Saved, AddressOf borrar
        gui.frmMovimientos.Show()
        gui.frmMovimientos.CargarDatos(0, 0, New Date, 0, "", EngineProcesosAbiertos.LAVADO_DEPOSITO.ToString, "", "", "", New DataBase(Config.Server))
        gui.frmMovimientos.cboProceso.SelectedValue = EngineProcesosAbiertos.LAVADO_DEPOSITO
        gui.frmMovimientos.cboPartidaDepositoID.SelectedValue = gui.cboDepositoPArtida.SelectedValue

        gui.frmMovimientos.txtCantidad.Text = gui.txtCantidad.Text


        gui.frmEspera.Close()
    End Sub

    Private Sub borrar(sender As Object, e As EventArgs)
        If borrar_proceso_abierto() Then
            gui.Close()
        End If
    End Sub



End Class
