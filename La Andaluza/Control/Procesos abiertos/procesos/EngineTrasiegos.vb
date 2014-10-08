Namespace Procesos
    Public Class EngineTrasiegos
        Inherits ProcesosEngine
        Implements ProcesoMovimiento

        Private spTrasiegos As SpTrasiegos
        Private gui As frmTrasiego
        Public Sub New(ByVal id As Integer, ByRef frm As frmTrasiego)
            MyBase.New(id)
            spTrasiegos = New SpTrasiegos
            gui = frm

            CargarDatos()
            AddHandler gui.cboDepositoDestino.SelectedValueChanged, AddressOf Autoguardado
            AddHandler gui.cboDepositoOrigen.SelectedValueChanged, AddressOf Autoguardado
            AddHandler gui.cboLote.SelectedValueChanged, AddressOf Autoguardado
            AddHandler gui.cboProducto.SelectedValueChanged, AddressOf Autoguardado
            AddHandler gui.txtCantidad.TextChanged, AddressOf Autoguardado
            AddHandler gui.btnExportar.Click, AddressOf Exportar
            AddHandler gui.btnBorrar.Click, AddressOf borrar
        End Sub

        Private Sub CargarDatos() Implements ProcesoMovimiento.CargarDatos
            gui.cboProducto.mam_DataSource(spTrasiegos.devolver_productos(), False, False)
            gui.cboLote.mam_DataSource(spTrasiegos.devolver_tipos_de_lotes(), False, False)
            gui.cboDepositoDestino.mam_DataSource(spTrasiegos.devolver_depositos(), False, False)
            gui.cboDepositoOrigen.mam_DataSource(spTrasiegos.devolver_depositos_ocupados(), False, False)

            Dim dt As DataTable = MyBase.seleccionar()
            If Not dt Is Nothing Then
                gui.cboDepositoOrigen.SelectedValue = dt.Rows(0).Item(6)
                gui.cboDepositoDestino.SelectedValue = dt.Rows(0).Item(5)
                gui.txtCantidad.Text = dt.Rows(0).Item(3).ToString
                gui.cboProducto.SelectedValue = dt.Rows(0).Item(9)
                gui.cboLote.SelectedValue = dt.Rows(0).Item(10)
            End If
        End Sub
        Private Sub Autoguardado(sender As Object, e As EventArgs) Implements ProcesoMovimiento.Autoguardado
            Dim origen As Integer
            Dim destino As Integer
            Dim producto As Integer
            Dim lote As Integer
            Dim cantidad As Double

            If gui.cboDepositoOrigen.SelectedValue Is Nothing Then
                origen = 0
            Else
                Try
                    origen = CType(gui.cboDepositoOrigen.SelectedValue, Integer)
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


            spTrasiegos.actualizar(origen, destino, cantidad, producto, lote, id)
        End Sub

        Private Sub Exportar(sender As Object, e As EventArgs) Implements ProcesoMovimiento.Exportar
            gui.frmEspera = New frmEspera("Cargando datos")
            gui.frmEspera.Show()


            gui.frmMovimientos = New frmEntMovimientosCopy
            AddHandler gui.frmMovimientos.Saved, AddressOf borrar
            gui.frmMovimientos.Show()
            gui.frmMovimientos.CargarDatos(0, 0, New Date, 0, "", EngineProcesosAbiertos.TRASIEGO.ToString, gui.cboDepositoDestino.SelectedValue.ToString, gui.cboDepositoOrigen.SelectedValue.ToString, "", New DataBase(Config.Server))
            gui.frmMovimientos.cboProceso.SelectedValue = EngineProcesosAbiertos.TRASIEGO
            If Not gui.cboDepositoOrigen.SelectedValue Is Nothing Then gui.frmMovimientos.cboPartidaDepositoID.SelectedValue = gui.cboDepositoOrigen.SelectedValue
            If Not gui.cboDepositoDestino.SelectedValue Is Nothing Then gui.frmMovimientos.cboFinalDepositoID.SelectedValue = gui.cboDepositoDestino.SelectedValue
            If Not gui.cboProducto.SelectedValue Is Nothing Then gui.frmMovimientos.cboFinalTipoProductoFinal.SelectedValue = gui.cboProducto.SelectedValue
            If Not gui.cboLote.SelectedValue Is Nothing Then gui.frmMovimientos.cboTipoLoteCompra.SelectedValue = gui.cboLote.SelectedValue
            gui.frmMovimientos.txtCantidad.Text = gui.txtCantidad.Text


            gui.frmEspera.Close()
        End Sub

        Private Sub borrar(sender As Object, e As EventArgs)
            If borrar_proceso_abierto() Then
                gui.Close()
            End If
        End Sub



    End Class
End Namespace