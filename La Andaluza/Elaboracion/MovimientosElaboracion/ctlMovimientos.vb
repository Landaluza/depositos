Public Class ctlMovimientos
    Private clsMov As clsMovimientos

    Public ReadOnly Property Movimientoid As Integer
        Get
            Return Me.clsMov._MovimientoID
        End Get
    End Property
    Public Sub New()
        clsMov = New clsMovimientos
    End Sub

    Public Function GetMovimientoID() As Integer
        Return clsMov._MovimientoID
    End Function

    Public Sub SetMovimientoID(ByVal ID As Integer)
        clsMov._MovimientoID = ID
    End Sub

    Public Function devolverListadoMovimientosPorTipos(ByVal ProcesoID As Integer, ByVal Desde As Date, ByVal Hasta As Date, ByRef dtb As DataBase) As DataTable
        clsMov._ProcesoID = ProcesoID
        clsMov._Fecha = Desde
        Return clsMov.devolverListadoMovimientosPorTipos(Hasta, dtb)
    End Function

    Public Sub mostrarTodosMovimientos(ByRef dts As dtsMovimientos.MovimientosDataTable, ByRef dtb As DataBase)
        Dim tabla As DataTable
        tabla = clsMov.Devolver(dtb)

        If Not tabla Is Nothing Then
            Dim i As Integer
            dts.Clear()
            Dim reg As dtsMovimientos.MovimientosRow
            While i < tabla.Rows.Count
                reg = dts.NewMovimientosRow
                reg.MovimientoID = Convert.ToInt32(tabla.Rows(i).Item(0))
                If Not IsDBNull(tabla.Rows(i).Item(1)) Then reg.Fecha = CDate(tabla.Rows(i).Item(1))

                If Not IsDBNull(tabla.Rows(i).Item(2)) Then reg.Observaciones = tabla.Rows(i).Item(2).ToString
                If Not IsDBNull(tabla.Rows(i).Item(3)) Then reg.Cantidad = Convert.ToSingle(tabla.Rows(i).Item(3))
                If Not IsDBNull(tabla.Rows(i).Item(4)) Then reg.ProcesoID = tabla.Rows(i).Item(4).ToString

                If IsDBNull(tabla.Rows(i).Item(5)) Then
                    reg.EntraDepositoID = "0"
                Else
                    reg.EntraDepositoID = tabla.Rows(i).Item(5).ToString
                End If
                If IsDBNull(tabla.Rows(i).Item(6)) Then
                    reg.SaleDepositoID = "0"
                Else
                    reg.SaleDepositoID = tabla.Rows(i).Item(6).ToString
                End If
                If IsDBNull(tabla.Rows(i).Item(7)) Then
                    reg.LoteID = ""
                Else
                    reg.LoteID = tabla.Rows(i).Item(7).ToString
                End If
                If IsDBNull(tabla.Rows(i).Item(8)) Then
                    reg.FiltroID = ""
                Else
                    reg.FiltroID = tabla.Rows(i).Item(8).ToString
                End If
                dts.AddMovimientosRow(reg)
                reg = Nothing
                i = i + 1
            End While
        End If
    End Sub

    Public Function GuardarMovimiento(ByVal Fecha As DateTime, _
                                 ByVal Observaciones As String, _
                                 ByVal Cantidad As Double, _
                                 ByVal ProcesoID As Integer, _
                                 ByVal EntraDepositoID As Integer, _
                                 ByVal SaleDepositoID As Integer, _
                                 ByVal LoteID As Integer, _
                                 ByVal FiltroID As Integer, _
                                 ByVal Suma As Boolean, _
                                 ByVal NuevoLote As Boolean, ByRef dtb As DataBase) As Boolean

        clsMov._Fecha = Fecha
        clsMov._Observaciones = Observaciones
        clsMov._Cantidad = Cantidad
        clsMov._ProcesoID = ProcesoID
        clsMov._EntraDepositoID = EntraDepositoID
        clsMov._SaleDepositoID = SaleDepositoID
        clsMov._LoteID = LoteID
        clsMov._FiltroID = FiltroID
        clsMov._suma = Suma
        clsMov._NuevoLote = NuevoLote

        If clsMov._MovimientoID = 0 Then
            Return clsMov.Insertar(dtb)
        Else
            Return False
        End If
    End Function

    Public Function EliminarMovimiento(Optional ByRef transactdtb As DataBase = Nothing) As Boolean
        Dim dtb As DataBase

        If transactdtb Is Nothing Then
            dtb = New DataBase(Config.Server)
        Else
            dtb = transactdtb
        End If

        clsMov.Cargar(dtb)
        Dim ctlCom As New ctlCompuestoPor
        Dim ctlLot As New ctlLotes
        Dim tabla As New DataTable
        Dim i As Integer = 0
        Dim retorno As Boolean

        retorno = True
        If transactdtb Is Nothing Then dtb.EmpezarTransaccion()

        Try

            tabla = ctlCom.DevolverCompuestosPorMovimiento(clsMov._MovimientoID, dtb)
            If clsMov._NuevoLote Then
                While i < tabla.Rows.Count()
                    ctlCom.SetLoteFinal(Convert.ToInt32(tabla.Rows(i).Item(0)))
                    ctlCom.SetLotePartida(Convert.ToInt32(tabla.Rows(i).Item(1)))
                    ctlCom.SetCantidad(Convert.ToDouble(tabla.Rows(i).Item(2)))
                    If Not ctlCom.RevertirMovimiento(dtb) Then retorno = False
                    If Not ctlCom.EliminarCompuestoPor(dtb) Then retorno = False
                    i = i + 1
                End While
                If Not ctlLot.EliminarLote(ctlCom.GetLoteFinal, dtb) Then retorno = False
            Else
                While i < tabla.Rows.Count()
                    ctlCom.SetLoteFinal(Convert.ToInt32(tabla.Rows(i).Item(0)))
                    ctlCom.SetLotePartida(Convert.ToInt32(tabla.Rows(i).Item(1)))
                    ctlCom.SetCantidad(Convert.ToDouble(tabla.Rows(i).Item(2)))
                    If Not ctlCom.RevertirMovimiento(dtb) Then retorno = False
                    If Not ctlCom.EliminarCompuestoPor(dtb) Then retorno = False
                    i = i + 1
                End While
                If clsMov._suma Then
                    ctlCom.SetLotePartida(ctlCom.GetLoteFinal)
                    ctlCom.SetCantidad(ctlCom.GetCantidad * (-1))
                    If Not ctlCom.RevertirMovimiento(dtb) Then retorno = False
                End If
            End If

            If Not clsMov.Eliminar(dtb) Then retorno = False

            If transactdtb Is Nothing Then
                If retorno Then
                    dtb.TerminarTransaccion()
                Else
                    dtb.CancelarTransaccion()
                End If
            End If

            Return retorno
        Catch ex As Exception
            If transactdtb Is Nothing Then dtb.CancelarTransaccion()
            Return False
        End Try
    End Function
End Class
