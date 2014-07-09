Public Class frmFiltros
   Inherits GridSimpleForm
   Implements Queriable

   private dboFiltros As DBO_Filtros
       
   Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spFiltros(), MaestroID.ToString)
       InitializeComponent()
       dboFiltros = new DBO_Filtros
       MyBase.newRegForm = ctype(New frmEntFiltros(GridSimpleForm.ACCION_INSERTAR, ctype(sp, spFiltros)), DetailedSimpleForm)
   End Sub

   Private Sub Insert_Before() Handles MyBase.BeforeInsert
       newRegForm.SetDataBussinesObject(ctype(Me.dboFiltros, databussines))
   End Sub

   Private Sub modify_Before() Handles MyBase.BeforeModify
        dboFiltros = CType(sp, spFiltros).Select_Record(CType(dgvGeneral.CurrentRow.Cells("Id").Value, Integer), dtb)
       If Not dboFiltros Is Nothing Then
           newRegForm.SetDataBussinesObject(ctype(Me.dboFiltros,databussines))
       Else
           MyBase.EventHandeld = True
           Messagebox.show("No se pudo recuperar los datos",  "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
       End If
   End Sub

   Protected Overrides Sub BindDataSource() implements Queriable.dataGridViewFill
       'dim dt as datatable = DataTableFill(Me.spFiltros.DataGridViewStoredProcedure)

       If not datasource Is Nothing Then
       GeneralBindingSource.DataSource = datasource
               With dgvGeneral
                   .DataSource = GeneralBindingSource
               .Columns("Id").Visible = False
                   .FormatoColumna("Descripcion", TiposColumna.Izquierda, true)
               End With
       End If

   End Sub

End Class
