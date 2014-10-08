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


    Private Sub btnNiveles_Click(sender As Object, e As EventArgs) Handles btnNiveles.Click
        'Dim frm As New guiNiveles
        'GUImain.añadirPestañaCentrada(CType(frm, Form))
    End Sub

    Private Sub estadisticas(sender As Object, e As EventArgs) Handles btnDEsembote.Click, btnPieCuba.Click, btnMigracion.Click, btnLavado.Click, btnFermentados.Click, btnDiferencia.Click, btnDesemboteNC.Click, btnDesecho.Click, _
        btnCoccionControlada.Click, btnClarificacion.Click, btnAjustesAgua.Click, btnAjustesComerciales.Click, btnFiltrado.Click, btnEnvasar.Click, btnVenta.Click, btnCompra.Click, btnNiveles.Click, _
        btnTrasiego.Click, btnTerminado.Click, btnClarificacion.Click

        Dim index As Integer = Convert.ToInt32(CType(sender, Button).Tag)
        contador.incrementar(index - 1)

        Try
            fil.saveObject(CType(contador, Object), My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\mov.obj")
        Catch ex As Exception
        End Try

    End Sub

    Private Sub btnTerminado_Click(sender As Object, e As EventArgs) Handles btnDEsembote.Click, btnPieCuba.Click, btnMigracion.Click, btnLavado.Click, btnFermentados.Click, btnDiferencia.Click, btnDesemboteNC.Click, btnDesecho.Click, _
        btnCoccionControlada.Click, btnClarificacion.Click, btnAjustesAgua.Click, btnAjustesComerciales.Click, btnFiltrado.Click, btnEnvasar.Click, btnVenta.Click, btnCompra.Click, btnNiveles.Click, _
        btnTrasiego.Click, btnTerminado.Click, btnClarificacion.Click

        Dim trasiego As New Movimientos.Movimiento(Convert.ToInt32(CType(sender, Button).Tag))
        GUImain.añadirPestañaCentrada(trasiego.Form)
    End Sub

    
End Class