Public Class ctlLotes
    Private clsLot As clsLotes
    Private clsAnaVal As clsAnaliticasValores
    Private clsAna As clsAnaliticas

    Public ReadOnly Property LoteId As Integer
        Get
            Return clsLot._LoteID
        End Get
    End Property

    Public ReadOnly Property Controlador_Lote As clsLotes
        Get
            Return Me.clsLot
        End Get
    End Property
    Public Sub New()
        clsLot = New clsLotes
        clsAnaVal = New clsAnaliticasValores
        clsAna = New clsAnaliticas
    End Sub
    Public Function devolverLotesEnologicosParaMovimientoPorProceso(ByVal Proceso As Integer, ByRef dtb As Connection.DataBase) As DataTable
        Return clsLot.devolverLotesEnologicosParaMovimientoPorProceso(Proceso, dtb)
    End Function

    Public Sub devolverLotesEnologicosParaMovimientosPorLoteID(ByVal LoteID As Integer, ByRef CantidadRestante As String, ByRef TipoProductoID As Integer, ByRef CodigoLote As String, ByRef dtb As Connection.DataBase)
        clsLot._LoteID = LoteID
        clsLot.DevolverEnologicosParaMovimientosPorLoteID(dtb)
        CantidadRestante = clsLot._CantidadRestante.ToString
        TipoProductoID = clsLot._TipoProductoID
        CodigoLote = clsLot._CodigoLote
    End Sub

    Function validarLoteDiferencia(ByVal codigo As String, ByRef cantidad As Double, ByRef descr As String, ByRef dtb As Connection.DataBase) As Integer
        clsLot._CodigoLote = codigo
        clsLot.validarLoteDiferencia(dtb)
        cantidad = clsLot._CantidadRestante
        descr = clsLot._Descripcion
        Return clsLot._LoteID
    End Function

    '---------------------------------------------------MOVIMIENTOS----------------------------------------------------------
    Public Function guardarLoteDesdeMovimiento(ByVal LotePartidaID As Integer, _
                                               ByVal LoteFinalID As Integer, _
                                               ByVal codigoLote As String, _
                                               ByVal cantidadRestantePartida As Double, _
                                               ByVal fechaFinal As Date, _
                                               ByVal cantidadActualFinal As Double, _
                                               ByVal DepositoID As Integer, _
                                               ByVal TipoProductoID As Integer, _
                                               ByVal TipoLoteID As Integer, _
                                               ByVal TercerLote As Boolean, _
                                               ByVal descripcion As String, _
                                               ByVal observacion As String, _
                                               ByVal conMuestra As Boolean, _
                                               ByVal RecipienteSalida As Integer, _
                                               ByVal TransicubaID As Integer, ByRef dtb As Connection.DataBase) _
                                               As Integer

        Dim RecipienteSalidaId As String
        If RecipienteSalida = 0 Then
            RecipienteSalidaId = "null"
        Else
            RecipienteSalidaId = Convert.ToString(RecipienteSalida)
        End If

        Dim lote As Integer = verificar_lote(codigoLote, dtb)


        If codigoLote.Contains("Dif") And lote <> 0 Then
            If Convert.ToInt32(dtb.Consultar("guardarLoteDesdeMovimiento " & _
                                    Convert.ToString(LotePartidaID) & "," & _
                                    Convert.ToString(LoteFinalID) & ",'" & _
                                    codigoLote & "'," & _
                                    Convert.ToString(cantidadRestantePartida).Replace(",", ".") & ",'" & _
                                    Calendar.ArmarFecha(fechaFinal) & "'," & _
                                    Convert.ToString(cantidadActualFinal).Replace(",", ".") & "," & _
                                    DepositoID.ToString & "," & _
                                    Convert.ToString(TipoProductoID) & "," & _
                                    Convert.ToString(TipoLoteID) & ",'" & _
                                    False & "','" & _
                                    conMuestra & "'," & _
                                    Config.User & ",'" & _
                                    descripcion & "','" & _
                                    observacion & "'," & _
                                    RecipienteSalidaId).Rows(0).Item(0)) <> 1 Then

                Return 0
            End If

        Else
            If Convert.ToInt32(dtb.Consultar("guardarLoteDesdeMovimiento " & _
                                    Convert.ToString(LotePartidaID) & "," & _
                                    Convert.ToString(LoteFinalID) & ",'" & _
                                    codigoLote & "'," & _
                                    Convert.ToString(cantidadRestantePartida).Replace(",", ".") & ",'" & _
                                    Calendar.ArmarFecha(fechaFinal) & "'," & _
                                    Convert.ToString(cantidadActualFinal).Replace(",", ".") & "," & _
                                    DepositoID.ToString & "," & _
                                    Convert.ToString(TipoProductoID) & "," & _
                                    Convert.ToString(TipoLoteID) & ",'" & _
                                    TercerLote & "','" & _
                                    conMuestra & "'," & _
                                    Config.User & ",'" & _
                                    descripcion & "','" & _
                                    observacion & "'," & _
                                    RecipienteSalidaId).Rows(0).Item(0)) <> 1 Then

                Return 0
            End If
        End If

        'tipoproducto 0



        If TransicubaID <> 0 Then
            Dim ctldep As New ctlDepositos
            ctldep.SetTransicubaID(TransicubaID)
            If Not ctldep.darDeBajaTransicuba(dtb) Then
                Return 0
            End If
        End If

        If TercerLote Then
            If lote <> 0 Then
                Return lote
            Else
                Return Convert.ToInt32(dtb.Consultar("select max(LoteID) from Lotes", False).Rows(0).Item(0))
            End If
        Else
            Return LoteFinalID
        End If
    End Function

    Public Function verificar_lote(ByVal codigoLote As String, ByRef dtb As Connection.DataBase) As Integer
        Dim consulta As String = "select loteid from lotes where codigolote = '" & codigoLote & "'"

        Dim dt As DataTable = dtb.Consultar(consulta, False)
        If dt Is Convert.DBNull Then Return 0
        If dt.Rows.Count = 0 Then Return 0
        If dt.Rows(0) Is Convert.DBNull Then Return 0

        If dt.Rows(0).Item(0) Is Convert.DBNull Then Return 0
        Return Convert.ToInt32(dt.Rows(0).Item(0))
    End Function

    Public Sub CargarParaMovimiento(ByVal DepositoID As Integer, ByRef LoteId As Integer, ByRef LoteActual As String, ByRef TipoProductoID As Integer, ByRef Descripcion As String, ByRef obser As String, ByRef CantidadActual As String, ByRef dtb As Connection.DataBase)
        clsLot._DepositoID = DepositoID
        clsLot.cargarParaMovimientoPorDeposito(dtb)
        LoteId = clsLot._LoteID
        LoteActual = clsLot._CodigoLote
        TipoProductoID = clsLot._TipoProductoID
        Descripcion = clsLot._Descripcion
        CantidadActual = clsLot._CantidadRestante.ToString
        obser = clsLot._Observacion
    End Sub

    Public Function devolverReferencia(ByRef dtb As Connection.DataBase) As Integer
        clsLot.devolverReferencia(dtb)
        Return clsLot._Referencia
    End Function

    Public Function GuardarLoteCompra(ByVal TipoProducto As Integer, ByVal tipoLote As Integer, ByVal proveedor As Integer, ByVal Cantidad As Double, ByVal Fecha As Date, ByVal CodigoLote As String, ByVal descrip As String, ByVal obs As String, ByRef dtb As Connection.DataBase) As Boolean
        devolverReferencia(dtb)
        clsLot._TipoProductoID = TipoProducto
        clsLot._TipoLoteID = tipoLote
        clsLot._ProveedorID = proveedor
        clsLot._CantidadRestante = Cantidad
        clsLot._CodigoLote = CodigoLote
        clsLot._Fecha = Fecha
        clsLot._Descripcion = descrip
        clsLot._Observacion = obs
        Return clsLot.guardarLoteCompra(dtb)
    End Function

    '-----------------------------------------------------LOTES-----------------------------------------------------------------
    Public Sub mostrarTrazabilidadLote(ByRef dts As dtsLotesTrazabilidad.LotesTrazabilidadDataTable, ByVal Lote As Integer, ByRef dtb As Connection.DataBase)
        Dim tabla As New DataTable
        tabla = clsLot.DevolverLotesTrazabilidad(Lote, dtb)
        Dim i As Integer
        Dim reg As dtsLotesTrazabilidad.LotesTrazabilidadRow
        While i < tabla.Rows.Count
            reg = dts.NewLotesTrazabilidadRow
            reg.ComponeA = tabla.Rows(i).Item(0).ToString
            reg.LoteId = Convert.ToInt32(tabla.Rows(i).Item(1))
            reg.CodigoLote = tabla.Rows(i).Item(2).ToString
            reg.Fecha = CDate(tabla.Rows(i).Item(3))
            reg.Fecha = reg.Fecha.Date
            reg.Proceso = tabla.Rows(i).Item(4).ToString
            reg.Cantidad = tabla.Rows(i).Item(5).ToString
            If IsDBNull(tabla.Rows(i).Item(6)) Then
                reg.Proveedor = ""
            Else
                reg.Proveedor = tabla.Rows(i).Item(6).ToString
            End If

            dts.AddLotesTrazabilidadRow(reg)
            mostrarTrazabilidadLote(dts, reg.LoteId, dtb)
            reg = Nothing
            i = i + 1
        End While
    End Sub


    Public Function EliminarLote(ByVal ID As Integer, ByRef dtb As Connection.DataBase) As Boolean
        clsAna._LoteID = ID

        Dim tabla As DataTable = clsAna.DevolverPorMuestra(dtb)
        Dim i As Integer
        While i < tabla.Rows.Count
            'eliminar analitica Valores
            If Not EliminarValoresPorAnalitica(dtb, Convert.ToInt32(tabla.Rows(i).Item(0))) Then Return False

            'eliminar analitica Requerimientos
            If Not EliminarRequerimientoPorAnalitica(dtb, Convert.ToInt32(tabla.Rows(i).Item(0))) Then Return False

            'eliminar analitica Muestra Observacion
            If Not EliminarObservacionesPorAnalitica(dtb, Convert.ToInt32(tabla.Rows(i).Item(0))) Then Return False

            'eliminar analitica externa
            If Not EliminarExternasPorAnalitica(dtb, Convert.ToInt32(tabla.Rows(i).Item(0))) Then Return False

            'eliminar analitica
            clsAna._AnaliticaID = Convert.ToInt32(tabla.Rows(i).Item(0))
            If Not clsAna.Eliminar(dtb) Then Return False
            i = i + 1

        End While

        'eliminar muestra
        clsLot._LoteID = ID
        If Not clsLot.Eliminar(dtb) Then Return False

        Return True
    End Function

    Public Function EliminarRequerimientoPorAnalitica(ByRef dtb As Connection.DataBase, ByVal analiticaid As Integer) As Boolean
        Return dtb.ConsultaAlteraciones("delete from AnaliticasRequerimientos where AnaliticaID = " & Convert.ToString(AnaliticaID))
    End Function
    Public Function EliminarObservacionesPorAnalitica(ByRef dtb As Connection.DataBase, ByVal AnaliticaID As Integer) As Boolean
        Return dtb.ConsultaAlteraciones("delete from MuestrasObservaciones where AnaliticaID = " & Convert.ToString(AnaliticaID))
    End Function

    Public Function EliminarExternasPorAnalitica(ByRef dtb As Connection.DataBase, ByVal AnaliticaID As Integer) As Boolean
        Return dtb.ConsultaAlteraciones("delete from AnaliticasExternas where AnaliticaID = " & Convert.ToString(AnaliticaID))
    End Function

    Public Function EliminarValoresPorAnalitica(ByRef dtb As Connection.DataBase, ByVal analiticaId As Integer) As Boolean
        Return dtb.ConsultaAlteraciones("delete from AnaliticasValores where AnaliticaID = " & Convert.ToString(AnaliticaID))
    End Function
End Class
