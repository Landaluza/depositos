Public Class frmResumenEliminarElaboracion
    Private loteID As Integer
    Private m_retorno As Boolean

    Public ReadOnly Property retorno As Boolean
        Get
            Return Me.m_retorno
        End Get
    End Property

    Public Sub New(ByVal lote As Integer)

        InitializeComponent()

        Me.loteID = lote
        mostrarOperaciones()
    End Sub

    Private Sub mostrarOperaciones()

    End Sub
End Class