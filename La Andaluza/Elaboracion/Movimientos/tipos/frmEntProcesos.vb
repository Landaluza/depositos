Public Class frmEntProcesos
    Inherits DetailedSimpleForm
    Implements Savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements Savable.afterSave
    Private m_DBO_Procesos As DBO_Procesos

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spProcesos = Nothing, Optional ByRef v_dbo As DBO_Procesos = Nothing)
        MyBase.new(modoDeApertura, v_sp, CType(v_dbo, databussines))
        InitializeComponent()
        If v_sp Is Nothing Then
            sp = CType(New spProcesos, StoredProcedure)
        Else
            sp = v_sp
        End If
        m_DBO_Procesos = If(v_dbo Is Nothing, New DBO_Procesos, v_dbo)
        dbo = m_DBO_Procesos
    End Sub

    Public Sub New()
        MyBase.new(GridSimpleForm.ACCION_INSERTAR, CType(New spProcesos, storedprocedure), CType(New DBO_Procesos, databussines))
        InitializeComponent()
    End Sub

    Private Sub frmEntProcesos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s0 As New spTiposLotes
        s0.cargar_TiposLotes(Me.cboTipoLote)
        Dim s1 As New spTiposMovimientos
        s1.cargar_TiposMovimientos(Me.cboTipoMovimiento)
        If (Me.mododeapertura = VISION) Then
            Me.cboTipoLote.enabled = False
            Me.lblTipoLoteID.enabled = False

            Me.cboTipoMovimiento.enabled = False
            Me.lblTipoMovimientoID.enabled = False

        End If
        If Config.userType <> 4 And Config.userType <> 9 Then
            butAddTipoMovimientoID.enabled = False
            butVerTipoMovimientoID.enabled = False
        End If

    End Sub

    Overrides Sub SetValores() Implements Savable.setValores
        If (Me.modoDeApertura = INSERCION) Then
            Me.m_DBO_Procesos = New dbo_Procesos
        Else
            Me.m_DBO_Procesos = CType(dbo, DBO_Procesos)
        End If

        txtDescripcion.Text = m_DBO_Procesos.Descripcion
        txtTipoProductoParaLote.Text = m_DBO_Procesos.TipoProductoParaLote
        cboTipoLote.SelectedValue = m_DBO_Procesos.TipoLoteID
        chbConMuestra.Checked = m_DBO_Procesos.ConMuestra
        cboTipoMovimiento.SelectedValue = m_DBO_Procesos.TipoMovimientoID
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements Savable.getValores
        Dim errores As String = String.empty


        If txtDescripcion.Text = "" Then
            If errores = "" Then txtDescripcion.Focus()
            errores = errores & "El campo Descripcion no puede estar vacío." & Environment.NewLine()
        Else
            m_DBO_Procesos.Descripcion = txtDescripcion.Text
        End If

        If cboTipoLote.SelectedValue Is Nothing Then
            If errores = "" Then cboTipoLote.Focus()
            errores = errores & "Debe seleccionar el tipo de lote." & Environment.NewLine()
        Else
            m_DBO_Procesos.TipoLoteID = Convert.ToInt32(cboTipoLote.SelectedValue)
        End If

        If cboTipoMovimiento.SelectedValue Is Nothing Then
            If errores = "" Then cboTipoMovimiento.Focus()
            errores = errores & "Debe seleccionar el tipo de movimiento." & Environment.NewLine()
        Else
            m_DBO_Procesos.TipoMovimientoID = Convert.ToInt32(cboTipoMovimiento.SelectedValue)
        End If

        If txtTipoProductoParaLote.Text = "" Then
            If errores = "" Then txtTipoProductoParaLote.Focus()
            errores = errores & "El campo TipoProductoParaLote no puede estar vacío." & Environment.NewLine()
        Else
            m_DBO_Procesos.TipoProductoParaLote = txtTipoProductoParaLote.Text
        End If



        m_DBO_Procesos.ConMuestra = chbConMuestra.Checked

        If (errores = String.empty) Then
            Dbo = CType(m_DBO_Procesos, databussines)
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(ByRef dtb As DataBase) Implements Savable.Guardar
        MyBase.Guardar(dtb)
    End Sub

    Private Sub butVerTipoMovimientoID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerTipoMovimientoID.Click
        Dim frmEnt As New frmTiposMovimientos()
        GUImain.añadirPestaña(CType(frmEnt, Form))
    End Sub

    Private Sub butAddTipoMovimientoID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddTipoMovimientoID.Click
        Dim DBO_TiposMovimientos As New DBO_TiposMovimientos
        Dim frmEnt As New frmEntTiposMovimientos(GridSimpleForm.ACCION_INSERTAR, New spTiposMovimientos, DBO_TiposMovimientos)
        frmEnt.ShowDialog()
        Dim s As New spTiposMovimientos
        s.cargar_TiposMovimientos(Me.cboTipoMovimiento)
    End Sub

    Private Sub frmEntProcesos_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        Pantalla.centerIn(CType(Me.tlpMiddle, Control), Me)
    End Sub
End Class
