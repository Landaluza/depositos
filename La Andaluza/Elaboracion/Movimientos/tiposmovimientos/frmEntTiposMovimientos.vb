Public Class frmEntTiposMovimientos
   Inherits BasesParaCompatibilidad.DetailedSimpleForm
   Implements BasesParaCompatibilidad.Savable
   Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave
   Private m_DBO_TiposMovimientos As DBO_TiposMovimientos

   Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spTiposMovimientos = Nothing, Optional ByRef v_dbo As DBO_TiposMovimientos = Nothing)
       MyBase.new(modoDeApertura, v_sp, ctype(v_dbo, BasesParaCompatibilidad.databussines))
       InitializeComponent()
       If v_sp Is Nothing then
       sp = ctype( New spTiposMovimientos,BasesParaCompatibilidad.StoredProcedure)
       else
       sp = v_sp
       End if
       m_DBO_TiposMovimientos = If(v_dbo Is Nothing, New DBO_TiposMovimientos, v_dbo)
       dbo = m_DBO_TiposMovimientos
   End Sub

   Public Sub New()
       MyBase.new(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, ctype(new spTiposMovimientos,BasesParaCompatibilidad.storedprocedure), ctype(new DBO_TiposMovimientos, BasesParaCompatibilidad.databussines))
       InitializeComponent()
   End Sub

   Private Sub frmEntTiposMovimientos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       If (me.mododeapertura = VISION) Then
       End If
       If Config.userType <> 4 and Config.userType <> 9 Then
       End If

   End Sub

   Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores
       If (Me.modoDeApertura = INSERCION) Then
       Me.m_DBO_TiposMovimientos = new dbo_TiposMovimientos
       Else
       Me.m_DBO_TiposMovimientos = ctype(dbo, DBO_TiposMovimientos)
       End If

           txtAbreviatura.Text = m_DBO_TiposMovimientos.Abreviatura
           txtDescripcion.Text = m_DBO_TiposMovimientos.Descripcion
           txtObservaciones.Text = m_DBO_TiposMovimientos.Observaciones
   End Sub

   Protected Overrides Function GetValores() as boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores as String = string.empty


       If txtAbreviatura.Text= "" then
           If errores = "" Then txtAbreviatura.Focus()
           errores = errores & "El campo Abreviatura no puede estar vacío." & Environment.NewLine()
       Else
       m_DBO_TiposMovimientos.Abreviatura = System.Convert.ToString(txtAbreviatura.Text)
       End If


       If txtDescripcion.Text= "" then
           If errores = "" Then txtDescripcion.Focus()
           errores = errores & "El campo Descripcion no puede estar vacío." & Environment.NewLine()
       Else
       m_DBO_TiposMovimientos.Descripcion = txtDescripcion.Text
       End If



       m_DBO_TiposMovimientos.Observaciones = txtObservaciones.Text


       If (errores = String.empty) then
         Dbo = ctype(m_DBO_TiposMovimientos, BasesParaCompatibilidad.databussines)
         return true
       Else
         MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores,"Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         return false
        End IF
   End Function

   Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = nothing) Implements BasesParaCompatibilidad.Savable.Guardar
       MyBase.Guardar(trans)
   End Sub

   Private Sub frmEntTiposMovimientos_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
       BasesParaCompatibilidad.DetailedSimpleForm.centerIn(ctype(Me.tlpMiddle, Control), Me)
   End Sub
End Class
