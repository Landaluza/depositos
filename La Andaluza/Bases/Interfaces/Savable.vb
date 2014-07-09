Public Interface Savable
    Event afterSave(sender As Object, args As EventArgs) '
    Sub setValores()
    Function getValores() As Boolean
    Sub Guardar(ByRef dtb As DataBase)
End Interface
