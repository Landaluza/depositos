Public Class frmEntFiltros
   Inherits DetailedSimpleForm
   implements Savable
   Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements Savable.afterSave
   Private m_DBO_Filtros As DBO_Filtros

   Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spFiltros = Nothing, Optional ByRef v_dbo As DBO_Filtros = Nothing)
       MyBase.new(modoDeApertura, v_sp, ctype(v_dbo,databussines))
       InitializeComponent()
       If v_sp Is Nothing then
            sp = CType(New spFiltros, Connection.StoredProcedure)
       else
       sp = v_sp
       End if
       m_DBO_Filtros = If(v_dbo Is Nothing, New DBO_Filtros, v_dbo)
       dbo = m_DBO_Filtros
   End Sub

   Public Sub New()
        MyBase.New(gridsimpleform.ACCION_INSERTAR, CType(New spFiltros, Connection.StoredProcedure), CType(New DBO_Filtros, DataBussines))
       InitializeComponent()
   End Sub

   Private Sub frmEntFiltros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       If (me.mododeapertura = VISION) Then
       End If
       If Config.userType <> 4 and Config.userType <> 9 Then
       End If

   End Sub

   Overrides Sub SetValores() implements Savable.setValores
       If (Me.modoDeApertura = INSERCION) Then
       Me.m_DBO_Filtros = new dbo_Filtros
       Else
       Me.m_DBO_Filtros = ctype(dbo, DBO_Filtros)
       End If

           txtDescripcion.Text = m_DBO_Filtros.Descripcion
   End Sub

   Protected Overrides Function GetValores() as boolean implements savable.getValores
        Dim errores as String = string.empty


       If txtDescripcion.Text= "" then
           If errores = "" Then txtDescripcion.Focus()
           errores = errores & "El campo Descripcion no puede estar vacío." & Environment.NewLine()
       Else
       m_DBO_Filtros.Descripcion = txtDescripcion.Text
       End If



       If (errores = String.empty) then
         Dbo = ctype(m_DBO_Filtros, databussines)
         return true
       Else
         MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores,"Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         return false
        End IF
   End Function

    Public Overrides Sub Guardar(ByRef dtb As Connection.DataBase) Implements Savable.Guardar
        MyBase.Guardar(dtb)
    End Sub
End Class
