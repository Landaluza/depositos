Namespace Procesos
    Public Class EngineGraneles
        Inherits ProcesosEngine
        Implements ProcesoMovimiento

        Private spGraneles As spGraneles
        Private gui As frmGraneles
        Public Sub New(ByVal id As Integer, ByRef frm As frmGraneles)
            MyBase.New(id)
            spGraneles = New spGraneles
            gui = frm

            CargarDatos()
            AddHandler gui.cboRecipiente.SelectedValueChanged, AddressOf Autoguardado
            AddHandler gui.cboDepositoPArtida.SelectedValueChanged, AddressOf Autoguardado
            AddHandler gui.txtCantidad.TextChanged, AddressOf Autoguardado
            AddHandler gui.btnExportar.Click, AddressOf Exportar
            AddHandler gui.btnBorrar.Click, AddressOf borrar
        End Sub

        Private Sub CargarDatos() Implements ProcesoMovimiento.CargarDatos
            gui.cboRecipiente.mam_DataSource(spGraneles.devolver_recipientes(), False, False)
            gui.cboDepositoPArtida.mam_DataSource(spGraneles.devolver_depositos(), False, False)

            Dim dt As DataTable = MyBase.seleccionar()
            If Not dt Is Nothing Then
                gui.cboDepositoPArtida.SelectedValue = dt.Rows(0).Item(6)
                gui.cboRecipiente.SelectedValue = dt.Rows(0).Item(13)
                gui.txtCantidad.Text = dt.Rows(0).Item(3).ToString
            End If
        End Sub
        Private Sub Autoguardado(sender As Object, e As EventArgs) Implements ProcesoMovimiento.Autoguardado
            Dim recipiente As Integer
            Dim origen As Integer
            Dim cantidad As Double

            If gui.cboRecipiente.SelectedValue Is Nothing Then
                recipiente = 0
            Else
                Try
                    recipiente = CType(gui.cboRecipiente.SelectedValue, Integer)
                Catch ex As Exception
                    recipiente = 0
                End Try
            End If

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


            spGraneles.actualizar(recipiente, origen, cantidad, id)
        End Sub

        Private Sub Exportar(sender As Object, e As EventArgs) Implements ProcesoMovimiento.Exportar
            gui.frmEspera = New frmEspera("Cargando datos")
            gui.frmEspera.Show()


            gui.frmMovimientos = New frmEntMovimientosCopy
            AddHandler gui.frmMovimientos.Saved, AddressOf borrar
            gui.frmMovimientos.Show()
            gui.frmMovimientos.CargarDatos(0, 0, New Date, 0, "", EngineProcesosAbiertos.GRANEL.ToString, gui.cboRecipiente.SelectedValue.ToString, "", "", New Connection.DataBase(Config.Server))
            gui.frmMovimientos.cboProceso.SelectedValue = EngineProcesosAbiertos.GRANEL
            If Not gui.cboDepositoPArtida.SelectedValue Is Nothing Then gui.frmMovimientos.cboPartidaDepositoID.SelectedValue = gui.cboDepositoPArtida.SelectedValue
            If Not gui.cboRecipiente.SelectedValue Is Nothing Then gui.frmMovimientos.cboSalidaRecipiente.SelectedValue = gui.cboRecipiente.SelectedValue
            gui.frmMovimientos.txtCantidad.Text = gui.txtCantidad.Text

            If Not gui.cboRecipiente.SelectedValue Is Nothing Then gui.frmMovimientos.cboFinalDepositoID.SelectedValue = gui.cboRecipiente.SelectedValue
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