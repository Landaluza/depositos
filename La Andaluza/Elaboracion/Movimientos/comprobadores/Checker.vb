Public MustInherit Class Checker
    Protected message As String

    MustOverride Function check(DateValue As Object, type As Integer) As Boolean

End Class
