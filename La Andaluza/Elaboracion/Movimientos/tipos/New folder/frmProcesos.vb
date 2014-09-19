Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmProcesos
   Inherits BasesParaCompatibilidad.gridsimpleform
   Implements BasesParaCompatibilidad.Queriable

   private dboProcesos As DBO_Procesos
       
   Public Sub New(Optional ByVal MaestroID As Integer = 0)
       MyBase.new(new spProcesos(),MaestroID.ToString)
       InitializeComponent()
       dboProcesos = new DBO_Procesos
       MyBase.newRegForm = ctype(New frmEntProcesos(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, ctype(sp, spProcesos)), BasesParaCompatibilidad.DetailedSimpleForm)
   End Sub

   Private Sub Insert_Before() Handles MyBase.BeforeInsert
       newRegForm.SetDataBussinesObject(ctype(Me.dboProcesos, BasesParaCompatibilidad.databussines))
   End Sub

   Private Sub modify_Before() Handles MyBase.BeforeModify
       dboProcesos =ctype(sp, spProcesos).Select_Record(ctype(dgvGeneral.CurrentRow.Cells("Id").Value, integer))
       If Not dboProcesos Is Nothing Then
           newRegForm.SetDataBussinesObject(ctype(Me.dboProcesos,BasesParaCompatibilidad.databussines))
       Else
           MyBase.EventHandeld = True
           Messagebox.show("No se pudo recuperar los datos",  "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
       End If
   End Sub

   Protected Overrides Sub BindDataSource() Implements BasesParaCompatibilidad.Queriable.dataGridViewFill
       'dim dt as datatable = DataTableFill(Me.spProcesos.DataGridViewStoredProcedure)

       If not datasource Is Nothing Then
       GeneralBindingSource.DataSource = datasource
               With dgvGeneral
                   .DataSource = GeneralBindingSource
               .Columns("Id").Visible = False
                   .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, true)
                   .FormatoColumna("TipoProductoParaLote", BasesParaCompatibilidad.TiposColumna.Izquierda, true)
               .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, true)
               .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, true)
               End With
       End If

   End Sub

End Class
