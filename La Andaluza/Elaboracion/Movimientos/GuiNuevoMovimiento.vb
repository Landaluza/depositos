Public Class GuiNuevoMovimiento

    Private Sub btnTrasiego_Click(sender As Object, e As EventArgs) Handles btnTrasiego.Click
        Dim trasiego As New MovimientoTrasiego
        GUImain.añadirPestaña(trasiego.Form)
    End Sub

    Private Sub btnNiveles_Click(sender As Object, e As EventArgs) Handles btnNiveles.Click
        Dim frm As New guiNiveles
        GUImain.añadirPestaña(CType(frm, Form))
    End Sub

    Private Sub btnCompra_Click(sender As Object, e As EventArgs) Handles btnCompra.Click
        Dim trasiego As New MovimientoCompra
        GUImain.añadirPestaña(trasiego.Form)
    End Sub

    Private Sub btnVenta_Click(sender As Object, e As EventArgs) Handles btnVenta.Click
        Dim trasiego As New MovimientoVenta
        GUImain.añadirPestaña(trasiego.Form)
    End Sub

    Private Sub btnEnvasar_Click(sender As Object, e As EventArgs) Handles btnEnvasar.Click
        Dim trasiego As New MovimientoEnvasar
        GUImain.añadirPestaña(trasiego.Form)
    End Sub

    Private Sub btnFiltrado_Click(sender As Object, e As EventArgs) Handles btnFiltrado.Click
        Dim trasiego As New MovimientoFiltrado
        GUImain.añadirPestaña(trasiego.Form)
    End Sub

    Private Sub btnAjustesComerciales_Click(sender As Object, e As EventArgs) Handles btnAjustesComerciales.Click
        Dim trasiego As New MovimientoAjusteComercial
        GUImain.añadirPestaña(trasiego.Form)
    End Sub

    Private Sub btnAjustesAgua_Click(sender As Object, e As EventArgs) Handles btnAjustesAgua.Click
        Dim trasiego As New MovimientoAjusteAgua
        GUImain.añadirPestaña(trasiego.Form)
    End Sub

    Private Sub btnClarificacion_Click(sender As Object, e As EventArgs) Handles btnClarificacion.Click
        Dim trasiego As New MovimientoClarificacion
        GUImain.añadirPestaña(trasiego.Form)
    End Sub

    Private Sub btnCoccionControlada_Click(sender As Object, e As EventArgs) Handles btnCoccionControlada.Click
        Dim trasiego As New MovimientoCoccionControlada
        GUImain.añadirPestaña(trasiego.Form)
    End Sub

    Private Sub btnDesecho_Click(sender As Object, e As EventArgs) Handles btnDesecho.Click
        Dim trasiego As New MovimientoDEsecho
        GUImain.añadirPestaña(trasiego.Form)
    End Sub

    Private Sub btnDesemboteNC_Click(sender As Object, e As EventArgs) Handles btnDesemboteNC.Click
        Dim trasiego As New MovimientoDesemboteNC
        GUImain.añadirPestaña(trasiego.Form)
    End Sub

    Private Sub btnDiferencia_Click(sender As Object, e As EventArgs) Handles btnDiferencia.Click
        Dim trasiego As New MovimientoTrasiego
        GUImain.añadirPestaña(trasiego.Form)
    End Sub

    Private Sub btnFermentados_Click(sender As Object, e As EventArgs) Handles btnFermentados.Click
        Dim trasiego As New MovimientoFermentacion
        GUImain.añadirPestaña(trasiego.Form)
    End Sub


    Private Sub btnLavado_Click(sender As Object, e As EventArgs) Handles btnLavado.Click
        Dim trasiego As New MovimientoLavado
        GUImain.añadirPestaña(trasiego.Form)
    End Sub

    Private Sub btnMigracion_Click(sender As Object, e As EventArgs) Handles btnMigracion.Click
        Dim trasiego As New MovimientoMaceracion
        GUImain.añadirPestaña(trasiego.Form)
    End Sub

    Private Sub btnPieCuba_Click(sender As Object, e As EventArgs) Handles btnPieCuba.Click
        Dim trasiego As New MovimientoPieCuba
        GUImain.añadirPestaña(trasiego.Form)
    End Sub
End Class