Public Class EngineFermentacion
    Inherits ProcesosEngine
    Implements ProcesoMovimiento

    Private SpFermentacion As SpFermentacion
    Private gui As frmFermentacion
    Public Sub New(ByVal id As Integer, ByRef frm As frmFermentacion)
        MyBase.New(id)
        SpFermentacion = New SpFermentacion
        gui = frm

        CargarDatos()
        AddHandler gui.cboDepositoPartida.SelectedValueChanged, AddressOf Autoguardado
        AddHandler gui.cboDepositoDestino.SelectedValueChanged, AddressOf Autoguardado
        AddHandler gui.txtCantidad.TextChanged, AddressOf Autoguardado
        AddHandler gui.btnExportar.Click, AddressOf Exportar
        AddHandler gui.btnBorrar.Click, AddressOf borrar
    End Sub

    Private Sub CargarDatos() Implements ProcesoMovimiento.CargarDatos
        gui.cboDepositoDestino.mam_DataSource(SpFermentacion.devolver_depositos(), False, False)
        gui.cboDepositoPartida.mam_DataSource(SpFermentacion.devolver_depositos(), False, False)

        Dim dt As DataTable = MyBase.seleccionar()
        If Not dt Is Nothing Then
            gui.cboDepositoPartida.SelectedValue = dt.Rows(0).Item(5)
            gui.cboDepositoDestino.SelectedValue = dt.Rows(0).Item(6)
            gui.txtCantidad.Text = dt.Rows(0).Item(3).ToString
        End If
    End Sub
    Private Sub Autoguardado(sender As Object, e As EventArgs) Implements ProcesoMovimiento.Autoguardado
        Dim destino As Integer
        Dim origen As Integer
        Dim cantidad As Double

        If gui.cboDepositoPartida.SelectedValue Is Nothing Then
            origen = 0
        Else
            Try
                origen = CType(gui.cboDepositoPartida.SelectedValue, Integer)
            Catch ex As Exception
                origen = 0
            End Try
        End If

        If gui.cboDepositoDestino.SelectedValue Is Nothing Then
            destino = 0
        Else
            Try
                destino = CType(gui.cboDepositoDestino.SelectedValue, Integer)
            Catch ex As Exception
                destino = 0
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


        SpFermentacion.actualizar(origen, destino, cantidad, id)
    End Sub

    Private Sub Exportar(sender As Object, e As EventArgs) Implements ProcesoMovimiento.Exportar
        gui.frmEspera = New frmEspera("Cargando datos")
        gui.frmEspera.Show()


        gui.frmMovimientos = New frmEntMovimientosCopy
        AddHandler gui.frmMovimientos.Saved, AddressOf borrar
        gui.frmMovimientos.Show()
        gui.frmMovimientos.CargarDatos(0, 0, New Date, 0, "", EngineProcesosAbiertos.FERMENTACION.ToString, gui.cboDepositoDestino.SelectedValue.ToString, "", "", New DataBase(Config.Server))
        gui.frmMovimientos.cboProceso.SelectedValue = EngineProcesosAbiertos.FERMENTACION
        If Not gui.cboDepositoPartida.SelectedValue Is Nothing Then gui.frmMovimientos.cboPartidaDepositoID.SelectedValue = gui.cboDepositoPartida.SelectedValue
        If Not gui.cboDepositoDestino.SelectedValue Is Nothing Then gui.frmMovimientos.cboFinalDepositoID.SelectedValue = gui.cboDepositoDestino.SelectedValue
        gui.frmMovimientos.txtCantidad.Text = gui.txtCantidad.Text


        gui.frmEspera.Close()
    End Sub

    Private Sub borrar(sender As Object, e As EventArgs)
        If borrar_proceso_abierto() Then
            gui.Close()
        End If
    End Sub
End Class
