Namespace Movimientos
    Namespace Tipos
        Public Class frmEnt
            Inherits DetailedSimpleForm
            Implements Savable
            Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements Savable.afterSave
            Private m_DBO_TiposMovimientos As Tipos

            Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As Db = Nothing, Optional ByRef v_dbo As Tipos = Nothing)
                MyBase.New(modoDeApertura, v_sp, CType(v_dbo, DataBussines))
                InitializeComponent()
                If v_sp Is Nothing Then
                    sp = CType(New Db, Connection.StoredProcedure)
                Else
                    sp = v_sp
                End If
                m_DBO_TiposMovimientos = If(v_dbo Is Nothing, New Tipos, v_dbo)
                dbo = m_DBO_TiposMovimientos
            End Sub

            Public Sub New()
                MyBase.New(gridsimpleform.ACCION_INSERTAR, CType(New Db, Connection.StoredProcedure), CType(New Tipos, DataBussines))
                InitializeComponent()
            End Sub

            Private Sub frmEntTiposMovimientos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
                If (Me.ModoDeApertura = VISION) Then
                End If
                If Config.UserType <> 4 And Config.UserType <> 9 Then
                End If

            End Sub

            Overrides Sub SetValores() Implements Savable.setValores
                If (Me.ModoDeApertura = INSERCION) Then
                    Me.m_DBO_TiposMovimientos = New Tipos
                Else
                    Me.m_DBO_TiposMovimientos = CType(dbo, Tipos)
                End If

                txtAbreviatura.Text = m_DBO_TiposMovimientos.Abreviatura
                txtDescripcion.Text = m_DBO_TiposMovimientos.Descripcion
                txtObservaciones.Text = m_DBO_TiposMovimientos.Observaciones
            End Sub

            Protected Overrides Function GetValores() As Boolean Implements Savable.getValores
                Dim errores As String = String.Empty


                If txtAbreviatura.Text = "" Then
                    If errores = "" Then txtAbreviatura.Focus()
                    errores = errores & "El campo Abreviatura no puede estar vacío." & Environment.NewLine()
                Else
                    m_DBO_TiposMovimientos.Abreviatura = System.Convert.ToChar(txtAbreviatura.Text)
                End If


                If txtDescripcion.Text = "" Then
                    If errores = "" Then txtDescripcion.Focus()
                    errores = errores & "El campo Descripcion no puede estar vacío." & Environment.NewLine()
                Else
                    m_DBO_TiposMovimientos.Descripcion = txtDescripcion.Text
                End If



                m_DBO_TiposMovimientos.Observaciones = txtObservaciones.Text


                If (errores = String.Empty) Then
                    dbo = CType(m_DBO_TiposMovimientos, DataBussines)
                    Return True
                Else
                    MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return False
                End If
            End Function

            Public Overrides Sub Guardar(ByRef dtb As Connection.DataBase) Implements Savable.Guardar
                MyBase.Guardar(dtb)
            End Sub

            Private Sub frmEntTiposMovimientos_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
                Pantalla.centerIn(CType(Me.tlpMiddle, Control), Me)
            End Sub
        End Class
    End Namespace
End Namespace