﻿Namespace Procesos
    Public Class EngineEnvasado
        Inherits ProcesosEngine
        Implements ProcesoMovimiento

        Private spEnvasado As SpEnvasado
        Private gui As frmEnvasado
        Public Sub New(ByVal id As Integer, ByRef frm As frmEnvasado)
            MyBase.New(id)
            spEnvasado = New SpEnvasado
            gui = frm

            CargarDatos()
            AddHandler gui.cboDeposito.SelectedValueChanged, AddressOf Autoguardado
            AddHandler gui.txtCantidad.TextChanged, AddressOf Autoguardado
            AddHandler gui.btnExportar.Click, AddressOf Exportar
            AddHandler gui.btnBorrar.Click, AddressOf borrar
        End Sub

        Private Sub CargarDatos() Implements ProcesoMovimiento.CargarDatos
            gui.cboDeposito.mam_DataSource(spEnvasado.devolver_depositos(), False, False)

            Dim dt As DataTable = MyBase.seleccionar()
            If Not dt Is Nothing Then
                gui.cboDeposito.SelectedValue = dt.Rows(0).Item(6)
                gui.txtCantidad.Text = dt.Rows(0).Item(3).ToString
            End If
        End Sub
        Private Sub Autoguardado(sender As Object, e As EventArgs) Implements ProcesoMovimiento.Autoguardado
            Dim destino As Integer
            Dim cantidad As Double

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
                    destino = Convert.ToInt32(gui.cboDeposito.SelectedValue)
                Catch ex As Exception
                    destino = 0
                End Try
            End If

            spEnvasado.actualizar(destino, cantidad, id)
        End Sub

        Private Sub Exportar(sender As Object, e As EventArgs) Implements ProcesoMovimiento.Exportar
            gui.frmEspera = New frmEspera("Cargando datos")
            gui.frmEspera.Show()


            gui.frmMovimientos = New frmEntMovimientosCopy
            AddHandler gui.frmMovimientos.Saved, AddressOf borrar
            gui.frmMovimientos.Show()
            gui.frmMovimientos.CargarDatos(0, 0, New Date, 0, "", EngineProcesosAbiertos.ENVASADO.ToString, "", "", "", New Connection.DataBase(Config.Server))
            gui.frmMovimientos.cboProceso.SelectedValue = EngineProcesosAbiertos.ENVASADO
            If Not gui.cboDeposito.SelectedValue Is Nothing Then gui.frmMovimientos.cboPartidaDepositoID.SelectedValue = gui.cboDeposito.SelectedValue
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