Namespace Movimientos
    Namespace Procesos
        Public Class frmProcesos
            Inherits gridsimpleform
            Implements Queriable

            Private dboProcesos As DBO_Procesos

            Public Sub New(Optional ByVal MaestroID As Integer = 0)
                MyBase.New(New spProcesos(), MaestroID.ToString)
                InitializeComponent()
                dboProcesos = New DBO_Procesos
                MyBase.newRegForm = CType(New frmEntProcesos(gridsimpleform.ACCION_INSERTAR, CType(sp, spProcesos)), DetailedSimpleForm)
            End Sub

            Private Sub Insert_Before() Handles MyBase.BeforeInsert
                newRegForm.SetDataBussinesObject(CType(Me.dboProcesos, DataBussines))
            End Sub

            Private Sub modify_Before() Handles MyBase.BeforeModify
                dboProcesos = CType(sp, spProcesos).Select_Record(CType(dgvGeneral.CurrentRow.Cells("Id").Value, Integer))
                If Not dboProcesos Is Nothing Then
                    newRegForm.SetDataBussinesObject(CType(Me.dboProcesos, DataBussines))
                Else
                    MyBase.EventHandeld = True
                    MessageBox.Show("No se pudo recuperar los datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End Sub

            Protected Overrides Sub BindDataSource() Implements Queriable.dataGridViewFill
                'dim dt as datatable = DataTableFill(Me.spProcesos.DataGridViewStoredProcedure)

                If Not dataSource Is Nothing Then
                    GeneralBindingSource.DataSource = dataSource
                    With dgvGeneral
                        .DataSource = GeneralBindingSource
                        .Columns("Id").Visible = False
                        .FormatoColumna("Descripcion", TiposColumna.Izquierda, True)
                        .FormatoColumna("TipoProductoParaLote", TiposColumna.Izquierda, True)
                        .FormatoColumna("TipoLote", TiposColumna.Izquierda, True)
                        .FormatoColumna("TipoMovimiento", TiposColumna.Izquierda, True)
                    End With
                End If

            End Sub

        End Class
    End Namespace
End Namespace