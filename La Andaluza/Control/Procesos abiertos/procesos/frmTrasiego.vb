Public Class frmTrasiego
    Inherits frmProceso

    Private trasiegosEng As EngineTrasiegos

    Public Sub New(ByVal id As Integer)

        InitializeComponent()

        Me.pbIconoOperacion.Image = My.Resources.trasiego
        trasiegosEng = New EngineTrasiegos(id, Me)

    End Sub

    

    


   


End Class