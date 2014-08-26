Public Class Watcher
    Protected control As Control
    Protected filtro As String
    Protected tooltip As ToolTip
    Protected backcolor As Color

    Public Sub New(ByRef control As Control)
        Me.tooltip = New ToolTip
        Me.control = control
        Me.backcolor = control.BackColor

        tooltip.IsBalloon = True
        tooltip.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class
