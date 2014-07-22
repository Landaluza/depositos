Public Class EngineCoccion
    Inherits ProcesosEngine
    Implements ProcesoMovimiento

    Private spCoccion As SpCoccion
    Private gui As frmCoccion
    Public Sub New(ByVal id As Integer, ByRef frm As frmCoccion)
        MyBase.New(id)
        spCoccion = New SpCoccion
        gui = frm

        CargarDatos()
        AddHandler gui.cboDeposito.SelectedValueChanged, AddressOf Autoguardado
        AddHandler gui.cboLote.SelectedValueChanged, AddressOf Autoguardado
        AddHandler gui.cboProducto.SelectedValueChanged, AddressOf Autoguardado
        AddHandler gui.txtCantidad.TextChanged, AddressOf Autoguardado
        AddHandler gui.btnExportar.Click, AddressOf Exportar
        AddHandler gui.btnBorrar.Click, AddressOf borrar
    End Sub

    Private Sub CargarDatos() Implements ProcesoMovimiento.CargarDatos
        gui.cboProducto.mam_DataSource(spCoccion.devolver_productos(), False, False)
        gui.cboLote.mam_DataSource(spCoccion.devolver_tipos_de_lotes(), False, False)
        gui.cboDeposito.mam_DataSource(spCoccion.devolver_depositos(), False, False)

        Dim dt As DataTable = MyBase.seleccionar()
        If Not dt Is Nothing Then
            gui.cboDeposito.SelectedValue = dt.Rows(0).Item(6)
            gui.txtCantidad.Text = dt.Rows(0).Item(3).ToString
            gui.cboProducto.SelectedValue = dt.Rows(0).Item(9)
            gui.cboLote.SelectedValue = dt.Rows(0).Item(7)
        End If
    End Sub
    Private Sub Autoguardado(sender As Object, e As EventArgs) Implements ProcesoMovimiento.Autoguardado
        Dim destino As Integer
        Dim producto As Integer
        Dim lote As Integer
        Dim cantidad As Double

        If gui.cboProducto.SelectedValue Is Nothing Then
            producto = 0
        Else
            Try
                producto = CType(gui.cboProducto.SelectedValue, Integer)
            Catch ex As Exception
                producto = 0
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


        spCoccion.actualizar(destino, cantidad, producto, lote, id)
    End Sub

    Private Sub Exportar(sender As Object, e As EventArgs) Implements ProcesoMovimiento.Exportar
        gui.frmEspera = New frmEspera("Cargando datos")
        gui.frmEspera.Show()


        gui.frmMovimientos = New frmEntMovimientosCopy
        AddHandler gui.frmMovimientos.Saved, AddressOf borrar
        gui.frmMovimientos.Show()
        gui.frmMovimientos.CargarDatos(0, 0, New Date, 0, "", EngineProcesosAbiertos.COCCION_CONTROLADA.ToString, "", "", "", New DataBase(Config.Server))
        gui.frmMovimientos.cboProceso.SelectedValue = EngineProcesosAbiertos.COCCION_CONTROLADA
        gui.frmMovimientos.cboAjusteLotes.SelectedValue = gui.cboLote.SelectedValue
        gui.frmMovimientos.cboFinalDepositoID.SelectedValue = gui.cboDeposito.SelectedValue
        gui.frmMovimientos.cboFinalTipoProductoFinal.SelectedValue = gui.cboProducto.SelectedValue
        gui.frmMovimientos.txtCantidad.Text = gui.txtCantidad.Text


        gui.frmEspera.Close()
    End Sub

    Private Sub borrar(sender As Object, e As EventArgs)
        If borrar_proceso_abierto() Then
            gui.Close()
        End If
    End Sub
End Class
