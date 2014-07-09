Public Class spRecipientesSalidas

    Public Sub cargar_RecipientesSalidas(ByRef cbo As ComboBox)
        cbo.mam_DataSource("RecipiesntesSalidasCbo", False)
    End Sub
End Class
