Namespace Movimientos
    Namespace Tipos

        Public Class frm
            Inherits gridsimpleform
            Implements Queriable

            Private dboTiposMovimientos As Tipos

            Public Sub New(Optional ByVal MaestroID As Integer = 0)
                MyBase.New(New Db(), MaestroID.ToString)
                InitializeComponent()
                dboTiposMovimientos = New Tipos
                MyBase.newRegForm = CType(New frmEnt(gridsimpleform.ACCION_INSERTAR, CType(sp, Db)), DetailedSimpleForm)
            End Sub

            Private Sub Insert_Before() Handles MyBase.BeforeInsert
                newRegForm.SetDataBussinesObject(CType(Me.dboTiposMovimientos, DataBussines))
            End Sub

            Private Sub modify_Before() Handles MyBase.BeforeModify
                dboTiposMovimientos = CType(sp, Db).Select_Record(CType(dgvGeneral.CurrentRow.Cells("Id").Value, Integer))
                If Not dboTiposMovimientos Is Nothing Then
                    newRegForm.SetDataBussinesObject(CType(Me.dboTiposMovimientos, DataBussines))
                Else
                    MyBase.EventHandeld = True
                    MessageBox.Show("No se pudo recuperar los datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End Sub

            Protected Overrides Sub BindDataSource() Implements Queriable.dataGridViewFill
                'dim dt as datatable = DataTableFill(Me.spTiposMovimientos.DataGridViewStoredProcedure)

                If Not dataSource Is Nothing Then
                    GeneralBindingSource.DataSource = dataSource
                    With dgvGeneral
                        .DataSource = GeneralBindingSource
                        .Columns("Id").Visible = False
                        .FormatoColumna("Descripcion", TiposColumna.Izquierda, True)
                        .FormatoColumna("Observaciones", TiposColumna.Izquierda, True)
                    End With
                End If

            End Sub

        End Class
    End Namespace
End Namespace