
Public Class DetailedSimpleForm

   
    Private m_modoDeApertura As Integer
    Public Const INSERCION As Byte = 1
    Public Const MODIFICACION As Byte = 2
    Public Const CERRADO As Byte = 3
    Public Const VISION As Byte = 99
    Protected sp As StoredProcedure
    Protected dbo As DataBussines
    Protected Event beforeShown()
    Protected Event afterShown()
    Public Shadows Event afterSave()
    Private dtb As DataBase
    Protected evitarCerrarSinGuardar As Boolean

    Public WriteOnly Property Evitar_cerrado_sin_guardar As Boolean
        Set(ByVal value As Boolean)
            Me.evitarCerrarSinGuardar = value
        End Set
    End Property

    Public Sub New()
        InitializeComponent()
        Me.ModoDeApertura = INSERCION
        Me.dbo = New DataBussines
        dtb = New DataBase(Config.Server)
        evitarCerrarSinGuardar = False
    End Sub

    Public Sub New(ByVal modo_de_apertura As String)
        InitializeComponent()

        Select Case modo_de_apertura
            Case gridsimpleform.ACCION_INSERTAR
                Me.ModoDeApertura = INSERCION
            Case gridsimpleform.ACCION_MODIFICAR
                Me.ModoDeApertura = MODIFICACION
            Case gridsimpleform.ACCION_VER
                Me.ModoDeApertura = VISION
        End Select

        dtb = New DataBase(Config.Server)
        evitarCerrarSinGuardar = False
    End Sub

    Public Sub New(ByVal modo_de_apertura As String, ByVal sp As StoredProcedure, Optional ByRef dbo As DataBussines = Nothing)
        InitializeComponent()

        Select Case modo_de_apertura
            Case gridsimpleform.ACCION_INSERTAR
                Me.ModoDeApertura = INSERCION
            Case gridsimpleform.ACCION_MODIFICAR
                Me.ModoDeApertura = MODIFICACION
            Case gridsimpleform.ACCION_VER
                Me.ModoDeApertura = VISION
        End Select

        dtb = New DataBase(Config.Server)
        Me.dbo = dbo
        Me.sp = sp

        evitarCerrarSinGuardar = False
    End Sub

    Public Sub New(ByVal sp As StoredProcedure, ByRef dbo As DataBussines)
        Me.sp = sp
        Me.dbo = dbo
        InitializeComponent()

        evitarCerrarSinGuardar = False
    End Sub

    Public Property ModoDeApertura As Integer
        Get
            Return m_modoDeApertura
        End Get
        Set(ByVal value As Integer)
            m_modoDeApertura = value
        End Set
    End Property

    Public WriteOnly Property ModoDeAperturaCadena As String
        Set(ByVal value As String)
            Select Case value
                Case GridSimpleForm.ACCION_INSERTAR
                    Me.ModoDeApertura = INSERCION
                Case GridSimpleForm.ACCION_MODIFICAR
                    Me.ModoDeApertura = MODIFICACION
                Case GridSimpleForm.ACCION_VER
                    Me.ModoDeApertura = VISION
            End Select
        End Set
    End Property

    Public Property StoredProcedure As StoredProcedure
        Get
            Return Me.sp
        End Get
        Set(ByVal value As StoredProcedure)
            sp = value
        End Set
    End Property

    Public Sub SetStoredProcedure(ByRef value As StoredProcedure)
        sp = value
    End Sub

    Public ReadOnly Property DataBussinesObject As DataBussines
        Get
            Return dbo
        End Get
    End Property

    Public Sub SetDataBussinesObject(ByRef value As DataBussines)
        dbo = value
    End Sub

    Private Sub butSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butSalir.Click
        Salir()
    End Sub

    Private Sub butImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butImprimir.Click
        Imprimir()
    End Sub

    Private Sub butExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butExcel.Click
        ExportToExcel()
    End Sub

    Protected Overridable Function getValores() As Boolean
        Return False
    End Function

    Public Overridable Sub Guardar(ByRef dtb As DataBase)
        If Not Me.sp Is Nothing Then
            If Me.getValores Then
                Try
                    If sp.Grabar(dbo, dtb) Then
                        evitarCerrarSinGuardar = False
                        RaiseEvent afterSave()

                        Me.Close()
                    Else
                        MessageBox.Show("No se pudo guardar el registro. Asegurese de tener conexion a la red.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MessageBox.Show("No se pudo guardar el registro. Detalles:" & Environment.NewLine & Environment.NewLine, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Else
            If Me.ModoDeApertura = INSERCION Then
                Me.Text = Me.Text.Replace("Insertar", "Modificar")
                Me.ModoDeApertura = MODIFICACION
            End If
        End If
    End Sub

    Overridable Sub Salir()      
            Me.Close()
    End Sub

    Overridable Sub Imprimir()
    End Sub

    Overridable Sub ExportToExcel()
    End Sub

    Overridable Sub Ver()
    End Sub

    Overridable Sub setValores(ByVal m_ArticuloID As Integer, ByVal m_SelectRecord As Boolean)
    End Sub

    Overridable Sub setValores()
    End Sub

    Private Sub butVer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVer.Click
        Ver()
    End Sub

    Private Sub FrmAHeredarEnt_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Me.gestionarEventosDeTeclado(e)
    End Sub

    Public Sub gestionarEventosDeTeclado(ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = 27 And Me.butSalir.Visible And Me.butSalir.Enabled Then
            Salir()
        ElseIf e.KeyCode = 116 And Me.butGuardar.Visible And Me.butGuardar.Enabled Then
            Me.Guardar(dtb)
        ElseIf e.KeyCode = 117 And Me.butImprimir.Visible And Me.butImprimir.Enabled Then
            Me.Imprimir()
        ElseIf e.KeyCode = 118 And Me.butVer.Visible And Me.butVer.Enabled Then
            Me.Ver()
        ElseIf e.KeyCode = 119 And Me.butExcel.Visible And Me.butExcel.Enabled Then
            Me.ExportToExcel()
        End If
    End Sub

    Private Sub FrmAHeredarEnt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Not Me.ModoDeApertura = Nothing Then
            Me.Text = Me.Text.Replace(GridSimpleForm.ACCION_INSERTAR & " ", "")
            Me.Text = Me.Text.Replace(GridSimpleForm.ACCION_MODIFICAR & " ", "")
            Me.Text = Me.Text.Replace(GridSimpleForm.ACCION_VER & " ", "")

            Select Case Me.ModoDeApertura
                Case INSERCION
                    Me.Text = GridSimpleForm.ACCION_INSERTAR & " " & Me.Text
                    Me.Icon = My.Resources.window_new
                Case MODIFICACION
                    Me.Text = GridSimpleForm.ACCION_MODIFICAR & " " & Me.Text
                    Me.Icon = My.Resources.window_new_3
                Case VISION
                    Me.Text = GridSimpleForm.ACCION_VER & " " & Me.Text
                    butGuardar.Visible = False
                    Me.Icon = My.Resources.window_duplicate1
                Case Else
                    Me.Icon = My.Resources.LogoBandejaLa21
            End Select
        End If

    End Sub

    Private Sub FrmAHeredarEnt_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        RaiseEvent beforeShown()
        setValores()
        Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Me.Cursor = Cursors.Default
        RaiseEvent afterShown()
    End Sub

   
    Private Sub DetailedSimpleForm_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If evitarCerrarSinGuardar Then
            e.Cancel = True
        End If
    End Sub

    Protected Sub saved()
        RaiseEvent afterSave()
    End Sub

    Private Sub butGuardar_Click(sender As System.Object, e As System.EventArgs) Handles butGuardar.Click
        Guardar(dtb)
    End Sub
End Class