﻿Public Class EngineTrasiegos
    Inherits ProcesosEngine

    Private spTrasiegos As SpTrasiegos

    Public Sub New(ByVal id As Integer)
        MyBase.New(id)
        spTrasiegos = New SpTrasiegos
    End Sub

    Public Sub SetValues(ByRef cboDepositoOrigen As ComboBox, ByRef cboDepositoDestino As ComboBox, ByRef txtCantidad As TextBox, ByRef cboProducto As ComboBox, ByRef cboLote As ComboBox)
        cboProducto.mam_DataSource(spTrasiegos.devolver_productos(), False, )
        cboLote.mam_DataSource(spTrasiegos.devolver_tipos_de_lotes(), False, )
        cboDepositoDestino.mam_DataSource(spTrasiegos.devolver_depositos(), False, )
        cboDepositoOrigen.mam_DataSource(spTrasiegos.devolver_depositos_ocupados(), False, )

        Dim dt As DataTable = MyBase.seleccionar()
        If Not dt Is Nothing Then
            cboDepositoOrigen.SelectedValue = dt.Rows(0).Item(6)
            cboDepositoDestino.SelectedValue = dt.Rows(0).Item(5)
            txtCantidad.Text = dt.Rows(0).Item(3).ToString
            cboProducto.SelectedValue = dt.Rows(0).Item(9)
            cboLote.SelectedValue = dt.Rows(0).Item(10)
        End If
    End Sub

    Public Sub actualizar(ByRef cboDepositoOrigen As ComboBox, ByRef cboDepositoDestino As ComboBox, ByRef txtCantidad As TextBox, ByRef cboProducto As ComboBox, ByRef cboLote As ComboBox)
        Dim origen As Integer
        Dim destino As Integer
        Dim producto As Integer
        Dim lote As Integer
        Dim cantidad As Double

        If cboDepositoOrigen.SelectedValue Is Nothing Then
            origen = 0
        Else
            Try
                origen = CType(cboDepositoOrigen.SelectedValue, Integer)
            Catch ex As Exception
                origen = 0
            End Try
        End If

        If cboDepositoDestino.SelectedValue Is Nothing Then
            destino = 0
        Else
            Try
                destino = CType(cboDepositoDestino.SelectedValue, Integer)
            Catch ex As Exception
                destino = 0
            End Try
        End If


        If cboProducto.SelectedValue Is Nothing Then
            producto = 0
        Else
            Try
                producto = CType(cboProducto.SelectedValue, Integer)
            Catch ex As Exception
                producto = 0
            End Try
        End If

        If cboLote.SelectedValue Is Nothing Then
            lote = 0
        Else
            Try
                lote = CType(cboLote.SelectedValue, Integer)
            Catch ex As Exception
                lote = 0
            End Try
        End If

        If txtCantidad.Text = "" Or Not IsNumeric(txtCantidad.Text) Then
            cantidad = 0
        Else
            Try
                cantidad = CType(txtCantidad.Text, Double)
            Catch ex As Exception
                cantidad = 0
            End Try
        End If


        spTrasiegos.actualizar(origen, destino, cantidad, producto, lote, id)
    End Sub
End Class
