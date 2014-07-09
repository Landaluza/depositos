Public Class spProveedores

    Sub cargar_Proveedores(ByRef comboBox As ComboBox)
        comboBox.mam_DataSource("ProveedoresCbo", False)
    End Sub

    Sub cargar_Proveedores_Por_Tipo_Material(ByRef cbo As ComboBox, ByVal TipoMaterialId As Integer)
        cbo.mam_DataSource("ProveedoresCboByTipoMaterial " & TipoMaterialId, False)
    End Sub

    Public Sub cargar_Proveedores_Por_Tipo(ByRef cbo As ComboBox, ByVal tipo As Integer)
        cbo.mam_DataSource("Proveedores1CboPorTipo " & tipo, False)
    End Sub

    Public Sub cargar_Proveedores_Analiticas(ByRef cbo As ComboBox)
        Me.cargar_Proveedores_Por_Tipo(cbo, 6)
    End Sub

    Public Sub cargar_Proveedores_Enologicos(ByRef cbo As ComboBox)
        Me.cargar_Proveedores_Por_Tipo(cbo, 5)
    End Sub

    Public Sub cargar_Proveedores_Compras(ByRef cbo As ComboBox)
        Me.cargar_Proveedores_Por_Tipo(cbo, 3)
    End Sub
End Class
