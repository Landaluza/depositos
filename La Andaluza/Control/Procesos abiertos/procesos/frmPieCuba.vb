﻿Public Class frmPieCuba
    Inherits frmProceso

    Private EnginePieCuba As EnginePieCuba

    Public Sub New(ByVal id As Integer)

        InitializeComponent()

        Me.pbIconoOperacion.Image = My.Resources.desecho
        EnginePieCuba = New EnginePieCuba(id, Me)

    End Sub
End Class