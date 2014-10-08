Namespace Procesos
    Public Class EngineDesemboteNC
        Inherits ProcesosEngine
        Implements ProcesoMovimiento

        Private spDesemboteNC As SpDesemboteNC
        Private gui As frmDesemboteNC
        Public Sub New(ByVal id As Integer, ByRef frm As frmDesemboteNC)
            MyBase.New(id)
            spDesemboteNC = New SpDesemboteNC
            gui = frm

            CargarDatos()
            AddHandler gui.cboDepositoDestino.SelectedValueChanged, AddressOf Autoguardado
            AddHandler gui.cboProductoEntrada.SelectedValueChanged, AddressOf Autoguardado
            AddHandler gui.cboProductoFin.SelectedValueChanged, AddressOf Autoguardado
            AddHandler gui.cboProveedor.SelectedValueChanged, AddressOf Autoguardado
            AddHandler gui.txtCantidad.TextChanged, AddressOf Autoguardado
            AddHandler gui.btnExportar.Click, AddressOf Exportar
            AddHandler gui.btnBorrar.Click, AddressOf borrar
        End Sub

        Private Sub CargarDatos() Implements ProcesoMovimiento.CargarDatos
            gui.cboProductoEntrada.mam_DataSource(spDesemboteNC.devolver_productos(), False, False)
            gui.cboProductoFin.mam_DataSource(spDesemboteNC.devolver_productos_no_enologicos(), False, False)
            gui.cboDepositoDestino.mam_DataSource(spDesemboteNC.devolver_depositos(), False, False)
            gui.cboProveedor.mam_DataSource(spDesemboteNC.devolver_proveedores(), False, False)

            Dim dt As DataTable = MyBase.seleccionar()
            If Not dt Is Nothing Then
                gui.cboDepositoDestino.SelectedValue = dt.Rows(0).Item(5)
                gui.txtCantidad.Text = dt.Rows(0).Item(3).ToString
                gui.cboProductoEntrada.SelectedValue = dt.Rows(0).Item(9)
                gui.cboProductoFin.SelectedValue = dt.Rows(0).Item(12)
                gui.cboProveedor.SelectedValue = dt.Rows(0).Item(11)
            End If
        End Sub
        Private Sub Autoguardado(sender As Object, e As EventArgs) Implements ProcesoMovimiento.Autoguardado
            Dim destino As Integer
            Dim producto As Integer
            Dim productofin As Integer
            Dim proveedor As Integer
            Dim cantidad As Double


            If gui.cboDepositoDestino.SelectedValue Is Nothing Then
                destino = 0
            Else
                Try
                    destino = CType(gui.cboDepositoDestino.SelectedValue, Integer)
                Catch ex As Exception
                    destino = 0
                End Try
            End If

            If gui.cboProveedor.SelectedValue Is Nothing Then
                proveedor = 0
            Else
                Try
                    proveedor = CType(gui.cboProveedor.SelectedValue, Integer)
                Catch ex As Exception
                    proveedor = 0
                End Try
            End If


            If gui.cboProductoEntrada.SelectedValue Is Nothing Then
                producto = 0
            Else
                Try
                    producto = CType(gui.cboProductoEntrada.SelectedValue, Integer)
                Catch ex As Exception
                    producto = 0
                End Try
            End If

            If gui.cboProductoFin.SelectedValue Is Nothing Then
                productofin = 0
            Else
                Try
                    productofin = CType(gui.cboProductoFin.SelectedValue, Integer)
                Catch ex As Exception
                    productofin = 0
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


            spDesemboteNC.actualizar(proveedor, destino, cantidad, producto, productofin, id)
        End Sub

        Private Sub Exportar(sender As Object, e As EventArgs) Implements ProcesoMovimiento.Exportar
            gui.frmEspera = New frmEspera("Cargando datos")
            gui.frmEspera.Show()


            gui.frmMovimientos = New frmEntMovimientosCopy
            AddHandler gui.frmMovimientos.Saved, AddressOf borrar
            gui.frmMovimientos.Show()
            gui.frmMovimientos.CargarDatos(0, 0, New Date, 0, "", EngineProcesosAbiertos.DESEMBOTES.ToString, gui.cboDepositoDestino.SelectedValue.ToString, "", "", New Connection.DataBase(Config.Server))
            gui.frmMovimientos.cboProceso.SelectedValue = EngineProcesosAbiertos.DESEMBOTES
            If Not gui.cboProductoEntrada.SelectedValue Is Nothing Then gui.frmMovimientos.cboCompraProducto.SelectedValue = gui.cboProductoEntrada.SelectedValue
            If Not gui.cboProveedor.SelectedValue Is Nothing Then gui.frmMovimientos.cboCompraProveedor.SelectedValue = gui.cboProveedor.SelectedValue
            gui.frmMovimientos.txtCompraCantidad.Text = gui.txtCantidad.Text

            If Not gui.cboDepositoDestino.SelectedValue Is Nothing Then gui.frmMovimientos.cboFinalDepositoID.SelectedValue = gui.cboDepositoDestino.SelectedValue
            If Not gui.cboProductoFin.SelectedValue Is Nothing Then gui.frmMovimientos.cboFinalTipoProductoFinal.SelectedValue = gui.cboProductoFin.SelectedValue
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