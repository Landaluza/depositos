Imports C1.C1Preview


Public Class ListMovPorTipos
    Private ctlPro As New ctlProcesos
    Private OldLib As New OldLib
    Private ctlMov As ctlMovimientos
    Private Tab As DataTable
    Private doc As C1PrintDocument
    Private title As RenderParagraph
    Private pl As PageLayout
    Private rt As RenderTable
    Private Fila As Integer
    Private frmEspera As frmEspera
    Private valor As Object
    Private dtb As DataBase

    Public Sub New()

        InitializeComponent()

        dtb = New DataBase(Config.Server)
        ctlPro = New ctlProcesos
        OldLib = New OldLib
        ctlMov = New ctlMovimientos        
        title = New RenderParagraph
        pl = New PageLayout
        rt = New RenderTable

        dtpDesde.activarFoco()
        dtpHasta.activarFoco()

        Dim s As New spProcesos
        s.cargar_Procesos(Me.cboProcesos)
        ' OldLib.RellenarComboBox(Me.cboProcesos, ctlPro.devolverProcesos, False)
        'cboProcesos.MaxDropDownItems = cboProcesos.Items.Count
    End Sub


    Private Sub rdbGrados_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbGrados.GotFocus
        Me.chbAlcohol.Visible = True
    End Sub

    Private Sub rdbLitros_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbLitros.GotFocus
        Me.chbAlcohol.Checked = False
        Me.chbAlcohol.Visible = False
    End Sub

    Private Sub btnVer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVer.Click
        frmEspera = New frmEspera("Generando informe, espere unso segundos")
        frmEspera.Show()
        Try


            doc = New C1PrintDocument
            doc.DefaultUnit = C1.C1Preview.UnitTypeEnum.Mm
            Tab = ctlMov.devolverListadoMovimientosPorTipos(Convert.ToInt32(cboProcesos.SelectedValue), dtpDesde.Value.Date, dtpHasta.Value.Date, dtb)
            Me.DataGridView1.DataSource = Tab

            Me.C1PrintPreviewControl1.Visible = True

            With pl
                .PageSettings = New C1PageSettings()
                .PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
                .PageSettings.LeftMargin = 10
                .PageSettings.RightMargin = 10
                .PageSettings.Landscape = True
            End With
            doc.PageLayouts.Default = pl

            'doc.PageLayouts.EvenPages = pl
            'doc.PageLayouts.OddPages = pl

            ' Titulo
            title.Content.AddText("Movimientos de " & Convert.ToString(Me.cboProcesos.SelectedText))
            title.Content.AddText(" desde el " & Me.dtpDesde.Value.Date & " hasta el " & Me.dtpHasta.Value.Date)
            'title.Content.AddText("PageLayouts", Color.Blue)
            title.Style.Font = New Font("Tahoma", 18, FontStyle.Bold)
            title.Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Center
            title.Style.Borders.Bottom = New LineDef("1mm", Color.Black)
            doc.Body.Children.Add(title)


            rt.Style.GridLines.All = LineDef.Default
            rt.CellStyle.Padding.Right = "1mm"
            rt.CellStyle.Padding.Left = "1mm"

            Dim AnchoCol As Integer = 12
            rt.Cols(0).Width = 16
            rt.Cols(1).Width = AnchoCol
            rt.Cols(2).Width = AnchoCol
            rt.Cols(3).Width = AnchoCol
            rt.Cols(4).Width = AnchoCol
            rt.Cols(5).Width = AnchoCol
            rt.Cols(6).Width = AnchoCol
            rt.Cols(7).Width = AnchoCol
            rt.Cols(8).Width = AnchoCol
            rt.Cols(9).Width = AnchoCol
            rt.Cols(10).Width = AnchoCol
            rt.Cols(11).Width = AnchoCol

            valor = Nothing
            Fila = 0


            valor = rt.Rows.Item(Fila)
            rt.Cells(Fila, 0).Text = "Fecha"
            rt.Cells(Fila, 1).Text = "Blanco"
            rt.Cells(Fila, 2).Text = "Ajo"
            rt.Cells(Fila, 3).Text = "Estragon"
            rt.Cells(Fila, 4).Text = "Jerez"
            rt.Cells(Fila, 5).Text = "Reserva"
            rt.Cells(Fila, 6).Text = "Sidra"
            rt.Cells(Fila, 7).Text = "Crianza"
            rt.Cells(Fila, 8).Text = "Balsamico"
            rt.Cells(Fila, 9).Text = "Balsamico LA"
            rt.Cells(Fila, 10).Text = "Jerez Eco"
            rt.Cells(Fila, 11).Text = "Mosto conc."

            rt.Rows(Fila).Style.Font = New Font("Arial", 6, FontStyle.Bold)
            rt.Rows(Fila).Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Center
            rt.Rows(Fila).Style.BackColor = Color.LightGray
            Fila += 1


            Dim i As Integer = 0
            Dim TotalBlanco As Double = 0
            Dim TotalAjo As Double = 0
            Dim Estragon As Double = 0
            Dim Jerez As Double = 0
            Dim Reserva As Double = 0
            Dim Sidra As Double = 0
            Dim Crianza As Double = 0
            Dim Balsamico As Double = 0
            Dim BalsamicoLA As Double = 0
            Dim acidez, alcohol As Double

            Dim Columna As Integer
            If Tab.Rows.Count > 0 Then
                While i < Tab.Rows.Count
                    'Recorro toda la tabla, si la fecha no existe añado un Row, si existe la fecha coloco la cantidad en su columna correspondiente
                    'si existe la fecha y el tipo de vinagre añado un Row. Por ejemplo si en un mismo dia hay una salida para envasado de Jerez 
                    'y tambien para granell tendremos dos Rows con la misma fecha.

                    'Si rdbLitros esta seleccionado los datos se muestras en litros.
                    'Si rdbGrados esta seleccionado los datos se muestran en grados = (cantidad x acidez), si ademas chkAlcohol esta
                    'seleccionado los grados seran grados = ( cantidad x (acidez + alcohol))

                    valor = rt.Rows.Item(Fila)

                    Select Case Tab.Rows(i).Item("TiposProductos").ToString
                        Case Is = "Vinagre vino blanco"
                            Columna = 1
                            TotalBlanco += If(Tab.Rows(i).Item("Cantidad") Is Nothing, 0, CType(Tab.Rows(i).Item("Cantidad"), Double))
                        Case Is = "Vinagre al ajo"
                            Columna = 2
                            TotalAjo += If(Tab.Rows(i).Item("Cantidad") Is Nothing, 0, CType(Tab.Rows(i).Item("Cantidad"), Double))
                        Case Is = "Vinagre al estragon"
                            Columna = 3
                            Estragon += If(Tab.Rows(i).Item("Cantidad") Is Nothing, 0, CType(Tab.Rows(i).Item("Cantidad"), Double))
                        Case Is = "Vinagre Jerez (6 meses)"
                            Columna = 4
                            Jerez += If(Tab.Rows(i).Item("Cantidad") Is Nothing, 0, CType(Tab.Rows(i).Item("Cantidad"), Double))
                        Case Is = "Vinagre Jerez Reserva"
                            Columna = 5
                            Reserva += If(Tab.Rows(i).Item("Cantidad") Is Nothing, 0, CType(Tab.Rows(i).Item("Cantidad"), Double))
                        Case Is = "Vinagre de sidra"
                            Columna = 6
                            Sidra += If(Tab.Rows(i).Item("Cantidad") Is Nothing, 0, CType(Tab.Rows(i).Item("Cantidad"), Double))
                        Case Is = "Vinagre de crianza"
                            Columna = 7
                            Crianza += If(Tab.Rows(i).Item("Cantidad") Is Nothing, 0, CType(Tab.Rows(i).Item("Cantidad"), Double))
                        Case Is = "Vinagre Balsamico de Módena"
                            Columna = 8
                            Balsamico += If(Tab.Rows(i).Item("Cantidad") Is Nothing, 0, CType(Tab.Rows(i).Item("Cantidad"), Double))
                        Case Is = "Vinagre Balsámico"
                            Columna = 9
                            BalsamicoLA += If(Tab.Rows(i).Item("Cantidad") Is Nothing, 0, CType(Tab.Rows(i).Item("Cantidad"), Double))
                    End Select
                    '  messagebox.show(rt.Cells(Fila - 1, 0).Text & "," & Tab.Rows(i).Item("Fecha").ToString.Substring(0, 10))
                    If rt.Cells(Fila - 1, 0).Text = Tab.Rows(i).Item("Fecha").ToString.Substring(0, 10) Then
                        Fila = Fila - 1

                        If rt.Cells(Fila, Columna).Text.ToString.Length = 0 Then
                            rt.Cells(Fila, Columna).Text = "0"
                        End If

                        If rdbLitros.Checked Then
                            rt.Cells(Fila, Columna).Text = Format(Convert.ToDouble(rt.Cells(Fila, Columna).Text) + Convert.ToDouble(Tab.Rows(i).Item("Cantidad")), "0,00")
                        Else
                            If IsDBNull(Tab.Rows(i).Item("Acidez")) Then
                                MessageBox.Show("Hay un lote sin acidez", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                'Return
                                acidez = 1
                            Else
                                acidez = Convert.ToDouble(Tab.Rows(i).Item("Acidez"))
                            End If

                            If chbAlcohol.Checked Then

                                If IsDBNull(Tab.Rows(i).Item("Alcohol")) Then
                                    MessageBox.Show("Hay un lote sin Alcohol", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                    ' Return
                                    alcohol = 1
                                Else
                                    alcohol = Convert.ToDouble(Tab.Rows(i).Item("Alcohol"))
                                End If

                                rt.Cells(Fila, Columna).Text = Format(Convert.ToDouble(rt.Cells(Fila, Columna).Text) + Convert.ToDouble(If(Tab.Rows(i).Item("Cantidad") Is Nothing, 0, Convert.ToDouble(Tab.Rows(i).Item("Cantidad"))) * (acidez + alcohol)), "0,00")
                            Else
                                rt.Cells(Fila, Columna).Text = Format(Convert.ToDouble(rt.Cells(Fila, Columna).Text) + Convert.ToDouble(If(Tab.Rows(i).Item("Cantidad") Is Nothing, 0, Convert.ToDouble(Tab.Rows(i).Item("Cantidad"))) * acidez), "0,00")
                            End If

                        End If
                        i += 1
                        Fila += 1
                    Else
                        rt.Cells(Fila, 0).Text = Tab.Rows(i).Item("Fecha").ToString
                        If rdbLitros.Checked Then
                            rt.Cells(Fila, Columna).Text = Format(Tab.Rows(i).Item("Cantidad"), "0,00")
                        Else

                            If IsDBNull(Tab.Rows(i).Item("Acidez")) Then
                                MessageBox.Show("Hay un lote sin acidez", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                'Return
                                acidez = 1
                            Else
                                acidez = Convert.ToDouble(Tab.Rows(i).Item("Acidez"))
                            End If

                            If chbAlcohol.Checked Then

                                If IsDBNull(Tab.Rows(i).Item("Alcohol")) Then
                                    MessageBox.Show("Hay un lote sin Alcohol", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                    ' Return
                                    alcohol = 1
                                Else
                                    alcohol = Convert.ToDouble(Tab.Rows(i).Item("Alcohol"))
                                End If

                                rt.Cells(Fila, Columna).Text = Format(If(Tab.Rows(i).Item("Cantidad") Is Nothing, 0, Convert.ToDouble(Tab.Rows(i).Item("Cantidad"))) * (acidez + alcohol), "0,00")
                            Else
                                rt.Cells(Fila, Columna).Text = Format(If(Tab.Rows(i).Item("Cantidad") Is Nothing, 0, Convert.ToDouble(Tab.Rows(i).Item("Cantidad"))) * acidez, "0,00")
                            End If

                        End If
                        rt.Rows(Fila).Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Right
                        rt.Rows(Fila).Style.Font = New Font("Arial", 6, FontStyle.Regular)
                        Fila += 1
                        i += 1
                    End If
                End While

                'Totales
                valor = rt.Rows.Item(Fila)
                rt.Cells(Fila, 1).Text = Format(TotalBlanco, "#,##")
                rt.Cells(Fila, 2).Text = Format(TotalAjo, "#,##")
                rt.Cells(Fila, 3).Text = Format(Estragon, "#,##")
                rt.Cells(Fila, 4).Text = Format(Jerez, "#,##")
                rt.Cells(Fila, 5).Text = Format(Reserva, "#,##")
                rt.Cells(Fila, 6).Text = Format(Sidra, "#,##")
                rt.Cells(Fila, 7).Text = Format(Crianza, "#,##")
                rt.Cells(Fila, 8).Text = Format(Balsamico, "#,##")
                rt.Cells(Fila, 9).Text = Format(BalsamicoLA, "#,##")


                rt.Rows(Fila).Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Right
                rt.Rows(Fila).Style.Font = New Font("Arial", 8, FontStyle.Bold)
                rt.Rows(Fila).Style.BackColor = Color.LightGray

                doc.Body.Children.Add(New RenderEmpty("2mm"))
                doc.Body.Children.Add(rt)
            End If

            C1PrintPreviewControl1.Document = doc

        Catch ex As Exception
            MessageBox.Show("Error mostrando el informe. Detalles:" & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            frmEspera.Close()
        End Try
    End Sub



End Class

