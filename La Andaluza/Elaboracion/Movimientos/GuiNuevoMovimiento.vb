Public Class GuiNuevoMovimiento
    Private contador As contadorMovimientos
    Private fil As New File
    Public Sub New()

        InitializeComponent()
        Dim rand As New Random

        Try
            Dim obj As Object = fil.loadObject(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\mov.obj")
            If Not obj Is Nothing Then
                contador = CType(obj, contadorMovimientos)
            Else
                contador = New contadorMovimientos
            End If
        Catch ex As Exception
            contador = New contadorMovimientos
        End Try

        Dim indices As Integer() = contador.order()

        Me.SuspendLayout()
        For i As Integer = 0 To 4

            For Each Control As Control In Me.FlowLayoutPanel1.Controls
                Randomize(Now.Millisecond + Now.Second)
                Control.BackColor = Color.FromArgb(rand.Next(20, 160), rand.Next(20, 160), rand.Next(20, 160))

                If Control.Tag.ToString = indices(i).ToString Then
                    Control.MinimumSize = New Size(306, 150)
                    Me.FlowLayoutPanel1.Controls.SetChildIndex(Control, i)
                    Me.FlowLayoutPanel1.FlowDirection = FlowDirection.TopDown
                Else
                    Control.Width = 150
                End If
            Next
        Next
        Me.ResumeLayout()
    End Sub

    Private Sub btnTrasiego_Click(sender As Object, e As EventArgs) Handles btnTrasiego.Click
        Dim trasiego As New MovimientoTrasiego
        GUImain.añadirPestañaCentrada(trasiego.Form)
    End Sub

    Private Sub btnNiveles_Click(sender As Object, e As EventArgs) Handles btnNiveles.Click
        Dim frm As New guiNiveles
        GUImain.añadirPestañaCentrada(CType(frm, Form))
    End Sub

    Private Sub btnCompra_Click(sender As Object, e As EventArgs) Handles btnCompra.Click
        Dim trasiego As New MovimientoEntrada
        GUImain.añadirPestañaCentrada(trasiego.Form)
    End Sub

    Private Sub btnVenta_Click(sender As Object, e As EventArgs) Handles btnVenta.Click
        Dim trasiego As New MovimientoVenta
        GUImain.añadirPestañaCentrada(trasiego.Form)
    End Sub

    Private Sub btnEnvasar_Click(sender As Object, e As EventArgs) Handles btnEnvasar.Click
        Dim trasiego As New MovimientoEnvasar
        GUImain.añadirPestañaCentrada(trasiego.Form)
    End Sub

    Private Sub btnFiltrado_Click(sender As Object, e As EventArgs) Handles btnFiltrado.Click
        Dim trasiego As New MovimientoFiltrado
        GUImain.añadirPestañaCentrada(trasiego.Form)
    End Sub

    Private Sub btnAjustesComerciales_Click(sender As Object, e As EventArgs) Handles btnAjustesComerciales.Click
        Dim trasiego As New MovimientoAjusteComercial
        GUImain.añadirPestañaCentrada(trasiego.Form)
    End Sub

    Private Sub btnAjustesAgua_Click(sender As Object, e As EventArgs) Handles btnAjustesAgua.Click
        Dim trasiego As New MovimientoAjusteAgua
        GUImain.añadirPestañaCentrada(trasiego.Form)
    End Sub

    Private Sub btnClarificacion_Click(sender As Object, e As EventArgs) Handles btnClarificacion.Click
        Dim trasiego As New MovimientoClarificacion
        GUImain.añadirPestañaCentrada(trasiego.Form)
    End Sub

    Private Sub btnCoccionControlada_Click(sender As Object, e As EventArgs) Handles btnCoccionControlada.Click
        Dim trasiego As New MovimientoCoccionControlada
        GUImain.añadirPestañaCentrada(trasiego.Form)
    End Sub

    Private Sub btnDesecho_Click(sender As Object, e As EventArgs) Handles btnDesecho.Click
        Dim trasiego As New MovimientoDEsecho
        GUImain.añadirPestañaCentrada(trasiego.Form)
    End Sub

    Private Sub btnDesemboteNC_Click(sender As Object, e As EventArgs) Handles btnDesemboteNC.Click
        Dim trasiego As New MovimientoDesemboteNC
        GUImain.añadirPestañaCentrada(trasiego.Form)
    End Sub

    Private Sub btnDiferencia_Click(sender As Object, e As EventArgs) Handles btnDiferencia.Click
        Dim trasiego As New MovimientoTrasiego
        GUImain.añadirPestañaCentrada(trasiego.Form)
    End Sub

    Private Sub btnFermentados_Click(sender As Object, e As EventArgs) Handles btnFermentados.Click
        Dim trasiego As New MovimientoFermentacion
        GUImain.añadirPestañaCentrada(trasiego.Form)
    End Sub


    Private Sub btnLavado_Click(sender As Object, e As EventArgs) Handles btnLavado.Click
        Dim trasiego As New MovimientoLavado
        GUImain.añadirPestañaCentrada(trasiego.Form)
    End Sub

    Private Sub btnMigracion_Click(sender As Object, e As EventArgs) Handles btnMigracion.Click
        Dim trasiego As New MovimientoMaceracion
        GUImain.añadirPestañaCentrada(trasiego.Form)
    End Sub

    Private Sub btnPieCuba_Click(sender As Object, e As EventArgs) Handles btnPieCuba.Click
        Dim trasiego As New MovimientoPieCuba
        GUImain.añadirPestañaCentrada(trasiego.Form)
    End Sub

    Private Sub btnDEsembote_Click(sender As Object, e As EventArgs) Handles btnDEsembote.Click
        Dim trasiego As New MovimientoDesembote
        GUImain.añadirPestañaCentrada(trasiego.Form)
    End Sub

    Private Sub estadisticas(sender As Object, e As EventArgs) Handles btnDEsembote.Click, btnPieCuba.Click, btnMigracion.Click, btnLavado.Click, btnFermentados.Click, btnDiferencia.Click, btnDesemboteNC.Click, btnDesecho.Click, _
        btnCoccionControlada.Click, btnClarificacion.Click, btnAjustesAgua.Click, btnAjustesComerciales.Click, btnFiltrado.Click, btnEnvasar.Click, btnVenta.Click, btnCompra.Click, btnNiveles.Click, _
        btnTrasiego.Click

        Dim index As Integer = Convert.ToInt32(CType(sender, Button).Tag)
        contador.incrementar(index - 1)

        Try
            fil.saveObject(CType(contador, Object), My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\mov.obj")
        Catch ex As Exception
        End Try
        
    End Sub
End Class