Public Class MovimientoDeposito
    Inherits DataBase

    Public loteDestino As Integer 'lote que recibe el movimiento
    Public lotePartida As Integer 'lote del que surge el movimiento
    Public trazabilidad As Boolean 'si el movimiento posee trazabilidad
    Public MovimientoID As Integer 'id del movimiento a eliminar
    Public revertirDepositos As Boolean
    Public depositoOcupado As Boolean 'deposito previo del lote final ocupado
    Public movimientoReflexivo As Boolean 'movimiento sobre si mismo
    Public movimientoReflexivoEntreDepositos As Boolean ' movimientos sobre si mismo a diferente deposito
    Public destinoEliminable As Boolean 'si el lote final se puede eliminar por no ser el de partida y no contener trazabilidad
    Public eliminarDestino As Boolean


    Private dtb As DataBase

    Public Sub New()
        MyBase.New(Config.Server)
    End Sub

    Public Function devolverDepositos() As DataTable
        Return Consultar("SELECT Depositos.DepositoID, Depositos.Codigo FROM  Depositos WHERE (Depositos.BotaID IS NULL) ", False)
    End Function

    Public Function tieneTrazabilidad(ByVal movimientoid As Integer) As Boolean
        Dim dt As DataTable = Consultar("select count(*) from compuestoPor where movimientoid = " & movimientoid, False)

        If dt Is Nothing Then Return False

        If Convert.ToInt32(dt.Rows(0).Item(0)) > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function tieneTrazabilidadLote(ByVal loteID As Integer, ByVal movimientoid As Integer) As Boolean
        Dim dt As DataTable = Consultar("select count(*) from compuestoPor where (loteFinal = " & loteID & " and movimientoid<>" & movimientoid & ") or (lotePArtida=" & loteID & ")", False)

        If dt Is Nothing Then Return False

        If Convert.ToInt32(dt.Rows(0).Item(0)) > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function estaOcupado(ByVal depositoID As Integer) As Boolean
        Dim dt As DataTable = Consultar("select count(*) from lotes where depositoid = " & depositoID, False)


        If Convert.ToInt32(dt.Rows(0).Item(0)) > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function esReflexivo(ByVal movimientoid As Integer) As Boolean
        Dim dt As DataTable = Consultar("select count(*) from compuestopor where lotefinal = lotePartida and movimientoid= " & movimientoid, False)


        If Convert.ToInt32(dt.Rows(0).Item(0)) > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function recuperarLoteMovimiento(ByVal movimientoId As Integer) As Integer
        Dim dt As DataTable = Consultar("select loteid from movimientos where movimientoid = " & movimientoId, False)

        If dt Is Nothing Then Return 0

        Return Convert.ToInt32(dt.Rows(0).Item(0))
    End Function

    Public Function recuperarLoteTrazabilidad(ByVal movimientoId As Integer) As Integer
        Dim dt As DataTable = Consultar("select loteFinal from compuestopor where movimientoid = " & movimientoId, False)

        If dt Is Nothing Then Return 0

        Return Convert.ToInt32(dt.Rows(0).Item(0))
    End Function

    Public Function recuperarLotePartidaTrazabilidad(ByVal movimientoId As Integer) As Integer
        Dim dt As DataTable = Consultar("select lotePartida from compuestopor where movimientoid = " & movimientoId, False)

        If dt Is Nothing Then Return 0

        Return Convert.ToInt32(dt.Rows(0).Item(0))
    End Function

    Public Function recuperarCodigoLoteMovimiento(ByVal movimientoId As Integer) As String
        Dim dt As DataTable = Consultar("select codigolote from movimientos, lotes where lotes.loteid = movimientos.loteid and movimientoid = " & movimientoId, False)

        If dt Is Nothing Then Return "-"

        Return Convert.ToString(dt.Rows(0).Item(0))
    End Function

    Public Function recuperarCodigoLoteTrazabilidad(ByVal movimientoId As Integer) As String
        Dim dt As DataTable = Consultar("select codigolote from compuestopor, lotes where lotefinal = loteid and movimientoid = " & movimientoId, False)

        If dt Is Nothing Then Return "-"

        Return Convert.ToString(dt.Rows(0).Item(0))
    End Function

    Public Function recuperarCodigoLotePartidaTrazabilidad(ByVal movimientoId As Integer) As String
        Dim dt As DataTable = Consultar("select codigolote from compuestopor, lotes where lotepartida = loteid and movimientoid = " & movimientoId, False)

        If dt Is Nothing Then Return "-"

        Return Convert.ToString(dt.Rows(0).Item(0))
    End Function
    Public Function actualizarValoresLote(ByVal loteid As Integer, ByVal movimientoid As Integer) As Boolean
        If Not ConsultaAlteraciones("update lotes set cantidadrestante = cantidadrestante+(select cantidad from movimientos where movimientoid = " & movimientoid & ") where loteid=" & loteid) Then
            Return False
        End If

        If Not ConsultaAlteraciones("update lotes set depositoid = depositoprevioid where loteid=" & loteid) Then
            Return False
        End If

        If Not ConsultaAlteraciones("update lotes set depositoprevioid = null where loteid=" & loteid) Then
            Return False
        End If

        Return True
    End Function

    Public Function actualizarDepositoLote(ByVal loteid As Integer) As Boolean
        If Not ConsultaAlteraciones("update lotes set depositoid = depositoprevioid where loteid=" & loteid) Then
            Return False
        End If

        Return True
    End Function
    Public Function actualizarCantidadLote(ByVal loteid As Integer, ByVal movimientoid As Integer) As Boolean
        If Not ConsultaAlteraciones("update lotes set cantidadrestante = cantidadrestante+(select cantidad from movimientos where movimientoid = " & movimientoid & ") where loteid=" & loteid) Then
            Return False
        End If

        Return True
    End Function

    Public Function actualizarDepositoPrevioLote(ByVal loteid As Integer) As Boolean
        If Not ConsultaAlteraciones("update lotes set depositoprevioid =null where loteid=" & loteid) Then
            Return False
        End If

        Return True
    End Function
    Public Function borrarMovimiento(ByVal movimientoid As Integer) As Boolean
        If Not ConsultaAlteraciones("delete from movimientos where movimientoid=" & movimientoid) Then
            Return False
        End If

        Return True
    End Function

    Public Function borrarLote(ByVal loteID As Integer) As Boolean
        '        select * from AnaliticasExternas where analiticaid in (select analiticaid from analiticas where loteid = )
        'select * from AnaliticasValores where analiticaid in (select analiticaid from analiticas where loteid = )
        'select * from Analiticas where loteId = 

        If Not ConsultaAlteraciones("delete from AnaliticasExternas where analiticaid in (select analiticaid from analiticas where loteid = " & loteID & ")") Then
            Return False
        End If

        If Not ConsultaAlteraciones("delete select * from AnaliticasValores where analiticaid in (select analiticaid from analiticas where loteid = " & loteID & " )") Then
            Return False
        End If

        If Not ConsultaAlteraciones("delete from Analiticas where loteId = " & loteID) Then
            Return False
        End If


        If Not ConsultaAlteraciones("delete from lotes where loteID=" & loteID) Then
            Return False
        End If

        Return True
    End Function

    Public Function borrarTrazabilidad(ByVal loteDestino As Integer, ByVal movimientoid As Integer) As Boolean
        If Not ConsultaAlteraciones("delete from compuestopor where movimientoid=" & movimientoid & " and lotefinal=" & loteDestino) Then
            Return False
        End If

        Return True
    End Function

    Public Function seleccionarDepositoActual(ByVal loteid As Integer) As Integer
        Dim dt As DataTable = Consultar("select isnull(depositoid,0) from lotes where loteid = " & loteid.ToString, False)

        If dt Is Nothing Then Return 0

        Return Convert.ToInt32(dt.Rows(0).Item(0))
    End Function

    Public Function seleccionarDepositoPrevio(ByVal loteid As Integer) As Integer
        Dim dt As DataTable = Consultar("select isnull(depositoPrevioid,0) from lotes where loteid = " & loteid.ToString, False)

        If dt Is Nothing Then Return 0

        Return Convert.ToInt32(dt.Rows(0).Item(0))
    End Function
End Class
