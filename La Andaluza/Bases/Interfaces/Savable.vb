Public Interface Savable
    Event afterSave(sender As Object, args As EventArgs) '
    Sub setValores()
    Function getValores() As Boolean
    Sub Guardar(ByRef dtb As Connection.DataBase)
End Interface
