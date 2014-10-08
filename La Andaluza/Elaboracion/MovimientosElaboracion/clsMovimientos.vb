Public Class clsMovimientos

    Private MovimientoID As Integer
    Private Fecha As DateTime
    Private Observaciones As String
    Private Cantidad As Double
    Private ProcesoID As String
    Private EntraDepositoID As String
    Private SaleDepositoID As String
    Private LoteID As String
    Private FiltroID As String
    Private suma As Boolean
    Private NuevoLote As Boolean

    Public Property _MovimientoID() As Integer
        Get
            Return MovimientoID
        End Get

        Set(ByVal value As Integer)
            MovimientoID = value
        End Set
    End Property

    Public Property _Fecha() As DateTime
        Get
            Return Fecha
        End Get

        Set(ByVal value As DateTime)
            Fecha = value
        End Set
    End Property

    Public Property _Observaciones() As String
        Get
            Return Observaciones
        End Get

        Set(ByVal value As String)
            Observaciones = value
        End Set
    End Property

    Public Property _ProcesoID() As Integer
        Get
            If ProcesoID = "" Then Return 0
            Return Convert.ToInt32(ProcesoID)
        End Get

        Set(ByVal value As Integer)
            ProcesoID = value.ToString
        End Set
    End Property

    Public Property _Cantidad() As Double
        Get
            Return Cantidad
        End Get

        Set(ByVal value As Double)
            Cantidad = value
        End Set
    End Property
    Public Property _EntraDepositoID() As Integer
        Get
            If EntraDepositoID = "null" Then
                Return 0
            Else
                If EntraDepositoID = "" Then Return 0
                Return Convert.ToInt32(EntraDepositoID)
            End If
        End Get

        Set(ByVal value As Integer)
            If value = 0 Then
                EntraDepositoID = "null"
            Else
                EntraDepositoID = value.ToString
            End If
        End Set
    End Property

    Public Property _SaleDepositoID() As Integer
        Get
            If SaleDepositoID = "null" Then
                Return 0
            Else
                If SaleDepositoID = "" Then Return 0
                Return Convert.ToInt32(SaleDepositoID)
            End If
        End Get

        Set(ByVal value As Integer)
            If value = 0 Then
                SaleDepositoID = "null"
            Else
                SaleDepositoID = value.ToString
            End If
        End Set
    End Property

    Public Property _LoteID() As Integer
        Get
            If LoteID = "null" Then
                Return 0
            Else
                If LoteID = "" Then Return 0
                Return Convert.ToInt32(LoteID)
            End If
        End Get

        Set(ByVal value As Integer)
            If value = 0 Then
                LoteID = "null"
            Else
                LoteID = value.ToString
            End If
        End Set
    End Property
    Public Property _FiltroID() As Integer
        Get
            If FiltroID = "null" Then
                Return 0
            Else
                Return Convert.ToInt32(FiltroID)
            End If
        End Get

        Set(ByVal value As Integer)
            If value = 0 Then
                FiltroID = "null"
            Else
                FiltroID = value.ToString
            End If
        End Set
    End Property

    Public Property _suma() As Boolean
        Get
            Return suma
        End Get

        Set(ByVal value As Boolean)
            suma = value
        End Set
    End Property

    Public Property _NuevoLote() As Boolean
        Get
            Return NuevoLote
        End Get

        Set(ByVal value As Boolean)
            NuevoLote = value
        End Set
    End Property


    Public Function devolverListadoMovimientosPorTipos(ByVal hasta As Date, ByRef dtb As Connection.DataBase) As DataTable
        Dim strSELECT As String

        strSELECT = "select DISTINCT Movimientos.MovimientoId," & _
                    "Lotes.Referencia," & _
                    "Movimientos.Fecha," & _
                    "Movimientos.Cantidad," & _
                    "TiposProductos.Descripcion AS TiposProductos," & _
                    "dbo.DevolerValorParametroDeLote(Lotes.LoteID, 'Acidez') AS Acidez," & _
                    "dbo.DevolerValorParametroDeLote(Lotes.LoteID, 'Alcohol') AS Alcohol " & _
                    " from Procesos RIGHT OUTER JOIN Movimientos INNER JOIN TiposProductos INNER JOIN  Lotes " & _
                  "ON TiposProductos.TipoProductoID = Lotes.TipoProductoID INNER JOIN CompuestoPor " & _
                  "ON Lotes.LoteID = CompuestoPor.LoteFinal " & _
                  "ON Movimientos.MovimientoID = CompuestoPor.MovimientoID " & _
                  "ON Procesos.ProcesoID = Movimientos.ProcesoID " & _
                  "where (Movimientos.Fecha >= '" & Calendar.ArmarFecha(Fecha) & "' " & _
                   "AND Movimientos.Fecha <= '" & Calendar.ArmarFecha(hasta) & "') " & _
                   "AND Procesos.procesoID = " & Convert.ToString(ProcesoID) & _
                   " ORDER BY Movimientos.Fecha, TiposProductos"

        Return dtb.Consultar(strSELECT, False)
    End Function

    Public Function Devolver(ByRef dtb As Connection.DataBase) As DataTable
        Dim strSELECT As String

        strSELECT = "select Movimientos.MovimientoID, " & _
                    "Movimientos.Fecha, " & _
                    "Movimientos.Observaciones, " & _
                    "Movimientos.Cantidad, " & _
                    "Procesos.Descripcion AS Procesos, " & _
                    "CASE WHEN DepositosEntrada.Codigo is NULL THEN " & _
                    "(SELECT top 1 Lot1.CodigoLote FROM CompuestoPor as Com1 INNER JOIN Lotes as Lot1" & _
                    "ON Com1.LoteFinal = Lot1.LoteID" & _
                    "WHERE(Com1.MovimientoID = Movimientos.MovimientoID))" & _
                    "ELSE  Cast(DepositosEntrada.Codigo as varchar(15))" & _
                    "END  AS DepositosEntrada, " & _
                    "CASE WHEN DepositosSalida.Codigo is NULL THEN" & _
                    "(dbo.DevolverMovimientoDepositoSalida(Movimientos.MovimientoID))" & _
                    "ELSE  Cast(DepositosSalida.Codigo as varchar(15))" & _
                    "END  AS DepositosSalida, " & _
                    "Lotes.Descripcion AS Lotes," & _
                    "Filtros.Descripcion("")" & _
                    " from Movimientos LEFT OUTER JOIN Procesos " & _
                  "ON Movimientos.ProcesoID = Procesos.ProcesoID " & _
                  "LEFT OUTER JOIN Depositos AS DepositosEntrada " & _
                  "ON Movimientos.EntraDepositoID = DepositosEntrada.DepositoID " & _
                  "LEFT OUTER JOIN Depositos AS DepositosSalida " & _
                  "ON Movimientos.SaleDepositoID = DepositosSalida.DepositoID " & _
                  "LEFT OUTER JOIN Lotes " & _
                  "ON Movimientos.LoteID = Lotes.LoteID " & _
                  "LEFT OUTER JOIN Filtros " & _
                  "ON Movimientos.FiltroID = Filtros.FiltroID " & _
                "where Movimientos.MovimientoID, Movimientos.Fecha, Movimientos.Observaciones, Movimientos.Cantidad, Procesos.Descripcion AS Procesos, CASE WHEN DepositosEntrada.Codigo is NULL THEN (SELECT top 1 Lot1.CodigoLote FROM CompuestoPor as Com1 INNER JOIN Lotes as Lot1 ON Com1.LoteFinal = Lot1.LoteID WHERE(Com1.MovimientoID = Movimientos.MovimientoID)) ELSE  Cast(DepositosEntrada.Codigo as varchar(15)) END  AS DepositosEntrada, CASE WHEN DepositosSalida.Codigo is NULL THEN (dbo.DevolverMovimientoDepositoSalida(Movimientos.MovimientoID)) ELSE  Cast(DepositosSalida.Codigo as varchar(15)) END  AS DepositosSalida, Lotes.Descripcion AS Lotes, Filtros.Descripcion" & _
                " Movimientos LEFT OUTER JOIN Procesos ON Movimientos.ProcesoID = Procesos.ProcesoID LEFT OUTER JOIN Depositos AS DepositosEntrada ON Movimientos.EntraDepositoID = DepositosEntrada.DepositoID LEFT OUTER JOIN Depositos AS DepositosSalida ON Movimientos.SaleDepositoID = DepositosSalida.DepositoID LEFT OUTER JOIN Lotes ON Movimientos.LoteID = Lotes.LoteID LEFT OUTER JOIN Filtros ON Movimientos.FiltroID = Filtros.FiltroID"

        Return dtb.Consultar(strSELECT, False)
    End Function

    Public Sub Cargar(ByRef dtb As Connection.DataBase)
        Dim tabla As New DataTable
        tabla = dtb.Consultar("select NuevoLote,Suma from Movimientos where MovimientoID=" & Convert.ToString(MovimientoID))
        Try
            NuevoLote = Convert.ToBoolean(tabla.Rows(0).Item(0))
            suma = Convert.ToBoolean(tabla.Rows(0).Item(1))
        Catch ex As Exception
            NuevoLote = False
            suma = False
        End Try
    End Sub

    'Public Function Modificar(ByRef dtb as Connection.DataBase ) As Boolean
    '    Return dtb.ConsultaAlteraciones("update Movimientos set " & _
    '                             "Fecha='" & Calendar.ArmarFecha(Fecha) & "'," & _
    '                             "Observaciones='" & Observaciones & "'," & _
    '                             "Cantidad=" & Convert.ToString(Cantidad).Replace(",", ".") & "," & _
    '                             "ProcesoID=" & Convert.ToString(ProcesoID) & "," & _
    '                             "EntraDepositoID=" & Convert.ToString(EntraDepositoID) & "," & _
    '                             "SaleDepositoID=" & Convert.ToString(SaleDepositoID) & "," & _
    '                             "FiltroID=" & Convert.ToString(FiltroID) & "," & _
    '                             "NuevoLote='" & Convert.ToString(NuevoLote) & "'," & _
    '                             "Suma='" & Convert.ToString(suma) & "'," & _
    '                             "LoteID=" & Convert.ToString(LoteID) & _
    '                             " where MovimientoID=" & Convert.ToString(MovimientoID))

    'End Function

    Public Function Insertar(ByRef dtb As Connection.DataBase) As Boolean
        Dim ret As Boolean
        ret = dtb.ConsultaAlteraciones("insert into  Movimientos (fecha,observaciones, cantidad,procesoid,entradepositoid, saledepositoid, loteid, filtroid, suma, nuevolote, fechamodificacion, usuariomodificacion ) values(" & _
                            "'" & Calendar.ArmarFecha(Fecha) & "'," & _
                            "'" & Observaciones & "'," & _
                            "" & Convert.ToString(Cantidad).Replace(",", ".") & "," & _
                            "" & Convert.ToString(ProcesoID) & "," & _
                            "" & Convert.ToString(EntraDepositoID) & "," & _
                            "" & Convert.ToString(SaleDepositoID) & "," & _
                            "" & LoteID & "," & _
                            "" & FiltroID & ",'" & _
                            "" & Convert.ToString(suma) & "'," & _
                            "'" & Convert.ToString(NuevoLote) & "', CURRENT_TIMESTAMP, " & Config.User & ")")

        Try
            If ret Then
                MovimientoID = Convert.ToInt32(dtb.Consultar("select max(MovimientoID) from Movimientos", False).Rows(0).Item(0))
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function Eliminar(ByRef dtb As Connection.DataBase) As Boolean
        Return dtb.ConsultaAlteraciones("delete from Movimientos where MovimientoID = " & Convert.ToString(MovimientoID))
    End Function

End Class
