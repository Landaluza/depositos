Public Class EnginePieCuba
    Inherits ProcesosEngine
    Implements ProcesoMovimiento

    Private SpPieCuba As SpPieCuba
    Private gui As frmPieCuba
    Public Sub New(ByVal id As Integer, ByRef frm As frmPieCuba)
        MyBase.New(id)
        SpPieCuba = New SpPieCuba
        gui = frm

        CargarDatos()
        AddHandler gui.cboDeposito.SelectedValueChanged, AddressOf Autoguardado
        AddHandler gui.cboLote.SelectedValueChanged, AddressOf Autoguardado
        AddHandler gui.cbotlote.SelectedValueChanged, AddressOf Autoguardado
        AddHandler gui.txtCantidad.TextChanged, AddressOf Autoguardado
        AddHandler gui.btnExportar.Click, AddressOf Exportar
        AddHandler gui.btnBorrar.Click, AddressOf borrar
    End Sub

    Private Sub CargarDatos() Implements ProcesoMovimiento.CargarDatos
        gui.cbotlote.mam_DataSource(SpPieCuba.devolver_tipos_lotes(), False, False)
        gui.cboLote.mam_DataSource(SpPieCuba.devolver_lotes(), False, False)
        gui.cboDeposito.mam_DataSource(SpPieCuba.devolver_depositos(), False, False)

        Dim dt As DataTable = MyBase.seleccionar()
        If Not dt Is Nothing Then
            gui.cboDeposito.SelectedValue = dt.Rows(0).Item(6)
            gui.txtCantidad.Text = dt.Rows(0).Item(3).ToString
            gui.cbotlote.SelectedValue = dt.Rows(0).Item(10)
            gui.cboLote.SelectedValue = dt.Rows(0).Item(7)
        End If
    End Sub
    Private Sub Autoguardado(sender As Object, e As EventArgs) Implements ProcesoMovimiento.Autoguardado
        Dim destino As Integer
        Dim tlote As Integer
        Dim lote As Integer
        Dim cantidad As Double

        If gui.cbotlote.SelectedValue Is Nothing Then
            tlote = 0
        Else
            Try
                tlote = CType(gui.cbotlote.SelectedValue, Integer)
            Catch ex As Exception
                tlote = 0
            End Try
        End If

        If gui.cboLote.SelectedValue Is Nothing Then
            lote = 0
        Else
            Try
                lote = CType(gui.cboLote.SelectedValue, Integer)
            Catch ex As Exception
                lote = 0
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


        If gui.cboDeposito.SelectedValue Is Nothing Then
            destino = 0
        Else
            Try
                destino = CType(gui.cboDeposito.SelectedValue, Integer)
            Catch ex As Exception
                destino = 0
            End Try
        End If

        SpPieCuba.actualizar(destino, cantidad, tlote, lote, id)
    End Sub

    Private Sub Exportar(sender As Object, e As EventArgs) Implements ProcesoMovimiento.Exportar
        gui.frmEspera = New frmEspera("Cargando datos")
        gui.frmEspera.Show()


        gui.frmMovimientos = New frmEntMovimientosCopy
        AddHandler gui.frmMovimientos.Saved, AddressOf borrar
        gui.frmMovimientos.Show()
        gui.frmMovimientos.CargarDatos(0, 0, New Date, 0, "", EngineProcesosAbiertos.PIE_DE_CUBA.ToString, "", "", "", New DataBase(Config.Server))
        gui.frmMovimientos.cboProceso.SelectedValue = EngineProcesosAbiertos.PIE_DE_CUBA
        If Not gui.cboLote.SelectedValue Is Nothing Then gui.frmMovimientos.cboAjusteLotes.SelectedValue = gui.cboLote.SelectedValue
        If Not gui.cboDeposito.SelectedValue Is Nothing Then gui.frmMovimientos.cboFinalDepositoID.SelectedValue = gui.cboDeposito.SelectedValue
        If Not gui.cbotlote.SelectedValue Is Nothing Then gui.frmMovimientos.cboTipoLoteCompra.SelectedValue = gui.cbotlote.SelectedValue
        gui.frmMovimientos.txtCantidad.Text = gui.txtCantidad.Text


        gui.frmEspera.Close()
    End Sub

    Private Sub borrar(sender As Object, e As EventArgs)
        If borrar_proceso_abierto() Then
            gui.Close()
        End If
    End Sub
End Class
