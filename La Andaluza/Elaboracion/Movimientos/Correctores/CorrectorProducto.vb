Public Class CorrectorProducto
    Private gui As GuiCorrectorProducto
    Private bdCorrector As BdCorrector
    Private productos As DataTable

    Protected hiloDatos As System.Threading.Thread
    Protected iniciohiloDatos As System.Threading.ThreadStart
    Protected invocador As MethodInvoker

    Public Sub New(ByVal loteID As Integer)

        bdCorrector = New BdCorrector
        gui = New GuiCorrectorProducto

        iniciohiloDatos = New System.Threading.ThreadStart(AddressOf cargardatos)
        invocador = New MethodInvoker(AddressOf mostrarDatos)
        hiloDatos = New System.Threading.Thread(iniciohiloDatos)
        hiloDatos.IsBackground = True
        hiloDatos.Name = "consultadatosproductos"
        hiloDatos.Start()

        If gui.ShowDialog = DialogResult.OK Then
            Try
                If Not guardarProducto(loteID, gui.Producto) Then
                    MessageBox.Show("No se pudo guardar  el nuevo producto", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("No se pudo guardar el nuevo producto. Detalles: " & ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub cargardatos()
        productos = bdCorrector.listar_productos()

        gui.BeginInvoke(invocador)
    End Sub

    Private Sub mostrarDatos()
        gui.TipoProductoDatasource = productos
    End Sub

    Public Function guardarProducto(ByVal loteid As Integer, ByVal producto As Integer) As Boolean
        bdCorrector.EmpezarTransaccion()

        Try

            If Not bdCorrector.guardarProducto(loteid, producto) Then
                Throw New Exception("Error al guardar el producto")
            End If

            Dim lote As DataTable = bdCorrector.seleccionar_lote(loteid)
            Dim abreviatura As String = Convert.ToString(bdCorrector.seleccionar_detalles_producto(producto).Rows(0).Item(2))
            Dim codigoSinLetra As String = Convert.ToString(lote.Rows(0).Item(1))
            codigoSinLetra = codigoSinLetra.Substring(0, 8) & abreviatura & codigoSinLetra.Substring(10, 3)

            Dim codigoNuevo As String = bdCorrector.calcular_codigo_lote(codigoSinLetra)

            If Not bdCorrector.guardarCodigo(loteid, codigoNuevo) Then
                Throw New Exception("Error guardando el codigo del lote")
            End If

            bdCorrector.TerminarTransaccion()
            Return True
        Catch ex As Exception
            bdCorrector.CancelarTransaccion()
            Throw ex
        End Try
    End Function
End Class
