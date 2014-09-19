Public Class frmEntProcesos
   Inherits BasesParaCompatibilidad.DetailedSimpleForm
   Implements BasesParaCompatibilidad.Savable
   Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave
   Private m_DBO_Procesos As DBO_Procesos

   Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spProcesos = Nothing, Optional ByRef v_dbo As DBO_Procesos = Nothing)
       MyBase.new(modoDeApertura, v_sp, ctype(v_dbo, BasesParaCompatibilidad.databussines))
       InitializeComponent()
       If v_sp Is Nothing then
       sp = ctype( New spProcesos,BasesParaCompatibilidad.StoredProcedure)
       else
       sp = v_sp
       End if
       m_DBO_Procesos = If(v_dbo Is Nothing, New DBO_Procesos, v_dbo)
       dbo = m_DBO_Procesos
   End Sub

   Public Sub New()
       MyBase.new(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, ctype(new spProcesos,BasesParaCompatibilidad.storedprocedure), ctype(new DBO_Procesos, BasesParaCompatibilidad.databussines))
       InitializeComponent()
   End Sub

   Private Sub frmEntProcesos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       dim s0 as new spTiposLotes
       s0.cargar_TiposLotes(Me.cboTipoLote)
       dim s1 as new spTiposMovimientos
       s1.cargar_TiposMovimientos(Me.cboTipoMovimiento)
       If (me.mododeapertura = VISION) Then
           Me.cboTipoLote.enabled = False
           Me.lblTipoLoteID.enabled = False
           
           Me.cboTipoMovimiento.enabled = False
           Me.lblTipoMovimientoID.enabled = False
           
       End If
       If Config.userType <> 4 and Config.userType <> 9 Then
   butAddTipoLoteID.enabled = false
   butVerTipoLoteID.enabled = false
   butAddTipoMovimientoID.enabled = false
   butVerTipoMovimientoID.enabled = false
       End If

   End Sub

   Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores
       If (Me.modoDeApertura = INSERCION) Then
       Me.m_DBO_Procesos = new dbo_Procesos
       Else
       Me.m_DBO_Procesos = ctype(dbo, DBO_Procesos)
       End If

           txtDescripcion.Text = m_DBO_Procesos.Descripcion
           txtTipoProductoParaLote.Text = m_DBO_Procesos.TipoProductoParaLote
           cboTipoLote.SelectedValue = m_DBO_Procesos.TipoLoteID
           chbConMuestra.Checked = m_DBO_Procesos.ConMuestra
           cboTipoMovimiento.SelectedValue = m_DBO_Procesos.TipoMovimientoID
   End Sub

   Protected Overrides Function GetValores() as boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores as String = string.empty


       If txtDescripcion.Text= "" then
           If errores = "" Then txtDescripcion.Focus()
           errores = errores & "El campo Descripcion no puede estar vacío." & Environment.NewLine()
       Else
       m_DBO_Procesos.Descripcion = txtDescripcion.Text
       End If



       If txtTipoProductoParaLote.Text= "" then
           If errores = "" Then txtTipoProductoParaLote.Focus()
           errores = errores & "El campo TipoProductoParaLote no puede estar vacío." & Environment.NewLine()
       Else
       m_DBO_Procesos.TipoProductoParaLote = txtTipoProductoParaLote.Text
       End If



       m_DBO_Procesos.ConMuestra = chbConMuestra.Checked

       If (errores = String.empty) then
         Dbo = ctype(m_DBO_Procesos, BasesParaCompatibilidad.databussines)
         return true
       Else
         MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores,"Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         return false
        End IF
   End Function

   Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = nothing) Implements BasesParaCompatibilidad.Savable.Guardar
       MyBase.Guardar(trans)
   End Sub

   Private Sub butVerTipoLoteID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerTipoLoteID.Click
       Dim frmEnt As New frmTiposLotes()
       guiMain.añadirPestaña(frmEnt)
   End Sub

   Private Sub butAddTipoLoteID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddTipoLoteID.Click
       Dim DBO_TiposLotes As New DBO_TiposLotes
       Dim frmEnt As New frmEntTiposLotes(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, new spTiposLotes,DBO_TiposLotes)
       frmEnt.ShowDialog()
       dim s as new spTiposLotes
       s.cargar_TiposLotes(Me.cboTipoLote)
   End Sub

   Private Sub butVerTipoMovimientoID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerTipoMovimientoID.Click
       Dim frmEnt As New frmTiposMovimientos()
       guiMain.añadirPestaña(frmEnt)
   End Sub

   Private Sub butAddTipoMovimientoID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddTipoMovimientoID.Click
       Dim DBO_TiposMovimientos As New DBO_TiposMovimientos
       Dim frmEnt As New frmEntTiposMovimientos(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, new spTiposMovimientos,DBO_TiposMovimientos)
       frmEnt.ShowDialog()
       dim s as new spTiposMovimientos
       s.cargar_TiposMovimientos(Me.cboTipoMovimiento)
   End Sub

   Private Sub frmEntProcesos_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
       BasesParaCompatibilidad.DetailedSimpleForm.centerIn(ctype(Me.tlpMiddle, Control), Me)
   End Sub
End Class
