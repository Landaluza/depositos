Public Class clsLotes

#Region "Atributos"
    Private LoteID As Integer
    Private Referencia As Integer
    Private Descripcion As String
    Private Fecha As Date
    Private CantidadRestante As Double
    Private Observacion As String

    Private Botellas As String
    Private CantidadID As String
    Private MedidaID As String

    Private LoteProveedor As String

    Private EspecificacionID As String
    Private TipoLoteID As String
    Private TipoLote As String

    Private TipoProductoID As String

    Private CorredorID As String
    Private ProveedorID As String
    Private LoteConjuntoCompraID As String

    Private CodigoLote As String
    Private DepositoID As String
    Private RecipienteSalidaID As String

#End Region

    Public Property _LoteID() As Integer
        Get
            Return LoteID
        End Get

        Set(ByVal value As Integer)
            LoteID = value
        End Set
    End Property

    Public Property _Referencia() As Integer
        Get
            Return Referencia
        End Get

        Set(ByVal value As Integer)
            Referencia = value
        End Set
    End Property

    Public Property _CodigoLote() As String
        Get
            Return CodigoLote
        End Get

        Set(ByVal value As String)
            CodigoLote = value
        End Set
    End Property

    Public Property _Descripcion() As String
        Get
            Return Descripcion
        End Get

        Set(ByVal value As String)
            Descripcion = value
        End Set
    End Property

    Public Property _Fecha() As Date
        Get
            Return Fecha
        End Get

        Set(ByVal value As Date)
            Fecha = value
        End Set
    End Property

    Public Property _CantidadRestante() As Double
        Get
            Return CantidadRestante
        End Get

        Set(ByVal value As Double)
            CantidadRestante = value
        End Set
    End Property


    Public Property _LoteProveedor() As String
        Get
            Return LoteProveedor
        End Get

        Set(ByVal value As String)
            LoteProveedor = value
        End Set
    End Property


    Public Property _TipoLoteID() As Integer
        Get
            If TipoLoteID = "null" Then
                Return 0
            Else
                Return If(TipoLoteID <> String.Empty, Convert.ToInt32(TipoLoteID), 0)
            End If
        End Get

        Set(ByVal value As Integer)
            If value = 0 Then
                TipoLoteID = "null"
            Else
                TipoLoteID = value.ToString
            End If
        End Set
    End Property

    Public Property _RecipienteSalidaID() As Integer
        Get
            If RecipienteSalidaID = "null" Then
                Return 0
            Else
                Return If(RecipienteSalidaID <> String.Empty, Convert.ToInt32(RecipienteSalidaID), 0)
            End If
        End Get

        Set(ByVal value As Integer)
            If value = 0 Then
                RecipienteSalidaID = "null"
            Else
                RecipienteSalidaID = Convert.ToString(value)
            End If
        End Set
    End Property

    Public Property _TipoProductoID() As Integer
        Get
            If TipoProductoID = "null" Then
                Return 0
            Else
                Return If(TipoProductoID <> String.Empty, Convert.ToInt32(TipoProductoID), 0)
            End If
        End Get

        Set(ByVal value As Integer)
            If value = 0 Then
                TipoProductoID = "null"
            Else
                TipoProductoID = Convert.ToString(value)
            End If
        End Set
    End Property

    Public Property _CorredorID() As Integer
        Get
            If CorredorID = "null" Then
                Return 0
            Else
                Return If(CorredorID <> String.Empty, Convert.ToInt32(CorredorID), 0)
            End If
        End Get

        Set(ByVal value As Integer)
            If value = 0 Then
                CorredorID = "null"
            Else
                CorredorID = Convert.ToString(value)
            End If
        End Set
    End Property

    Public Property _EspecificacionID() As Integer
        Get
            If EspecificacionID = "null" Then
                Return 0
            Else
                Return If(EspecificacionID <> String.Empty, Convert.ToInt32(EspecificacionID), 0)
            End If
        End Get

        Set(ByVal value As Integer)
            If value = 0 Then
                EspecificacionID = "null"
            Else
                EspecificacionID = Convert.ToString(value)
            End If
        End Set
    End Property

    Public Property _Observacion() As String
        Get
            Return Observacion
        End Get

        Set(ByVal value As String)
            Observacion = value
        End Set
    End Property

    Public Property _Botellas() As String
        Get
            If Botellas = "null" Then
                Return "0"
            Else
                Return Botellas
            End If
        End Get

        Set(ByVal value As String)
            If value = "" Then
                Botellas = "null"
            Else
                If Convert.ToInt32(value) = 0 Then
                    Botellas = "null"
                Else
                    Botellas = value
                End If
            End If
        End Set
    End Property

    Public Property _CantidadID() As String
        Get
            If CantidadID = "null" Then
                Return "0"
            Else
                Return CantidadID
            End If
        End Get

        Set(ByVal value As String)
            If value = "" Then
                CantidadID = "null"
            Else
                If Convert.ToInt32(value) = 0 Then
                    CantidadID = "null"
                Else
                    CantidadID = value
                End If

            End If
        End Set
    End Property

    Public Property _MedidaID() As String
        Get
            If MedidaID = "null" Then
                Return "0"
            Else

                Return MedidaID
            End If
        End Get

        Set(ByVal value As String)
            If value = "" Then
                MedidaID = "null"
            Else
                If Convert.ToInt32(value) = 0 Then
                    CantidadID = "null"
                Else
                    MedidaID = value

                End If
            End If
        End Set
    End Property

    Public Property _ProveedorID() As Integer
        Get
            If ProveedorID = "null" Then
                Return 0
            Else
                Return If(ProveedorID <> String.Empty, Convert.ToInt32(ProveedorID), 0)
            End If
        End Get

        Set(ByVal value As Integer)
            If value = 0 Then
                ProveedorID = "null"
            Else
                ProveedorID = Convert.ToString(value)
            End If
        End Set
    End Property

    Public Property _LoteConjuntoCompraID() As Integer
        Get
            If LoteConjuntoCompraID = "null" Then
                Return 0
            Else
                Return If(LoteConjuntoCompraID <> String.Empty, Convert.ToInt32(LoteConjuntoCompraID), 0)
            End If
        End Get

        Set(ByVal value As Integer)
            If value = 0 Then
                LoteConjuntoCompraID = "null"
            Else
                LoteConjuntoCompraID = Convert.ToString(value)
            End If
        End Set
    End Property



    Public Property _DepositoID() As Integer
        Get
            If DepositoID = "null" Then
                Return 0
            Else
                Return If(DepositoID <> String.Empty, Convert.ToInt32(DepositoID), 0)
            End If
        End Get

        Set(ByVal value As Integer)
            If value = 0 Then
                DepositoID = "null"
            Else
                DepositoID = Convert.ToString(value)
            End If
        End Set
    End Property


    Public Sub New()
        _Descripcion = ""
        _Referencia = 0
        _Fecha = Today
        _CantidadRestante = 0
        _Observacion = ""
        _Botellas = "0"
        _CantidadID = "0"
        _MedidaID = "0"
        _LoteProveedor = ""
        _EspecificacionID = 0
        _TipoLoteID = 0
        _TipoProductoID = 0
        _CorredorID = 0
        _ProveedorID = 0
        _LoteConjuntoCompraID = 0
        _CodigoLote = ""
        _DepositoID = 0
        _RecipienteSalidaID = 0
    End Sub


    Public Sub cargarParaMovimientoPorDeposito(ByRef dtb As DataBase)
        Dim tabla As DataTable = dtb.Consultar("select LoteID, Descripcion, CantidadRestante, TipoProductoId, CodigoLote, observacion " & _
                                   "from Lotes where " & _
                                   "Lotes.DepositoID =" & Convert.ToString(DepositoID), False)

        Try
            LoteID = Convert.ToInt32(tabla.Rows(0).Item("LoteID"))
            If IsDBNull(tabla.Rows(0).Item(1)) Then
                Descripcion = ""
            Else
                Descripcion = CStr(tabla.Rows(0).Item(1))
            End If
            If IsDBNull(tabla.Rows(0).Item(2)) Then
                CantidadRestante = 0
            Else
                CantidadRestante = Convert.ToDouble(tabla.Rows(0).Item(2))
            End If

            If IsDBNull(tabla.Rows(0).Item(3)) Then
                TipoProductoID = "NULL"
            Else
                TipoProductoID = CStr(tabla.Rows(0).Item(3))
            End If
            CodigoLote = CStr(tabla.Rows(0).Item(4))
            If IsDBNull(tabla.Rows(0).Item(5)) Then
                Observacion = ""
            Else
                Observacion = CStr(tabla.Rows(0).Item(5))
            End If

        Catch ex As Exception
            LoteID = 0
            Descripcion = ""
            CantidadRestante = 0
            _TipoProductoID = 0
            CodigoLote = ""
            Observacion = ""
        End Try

    End Sub


    Public Sub devolverReferencia(ByRef dtb As DataBase)
        Try
            Referencia = Convert.ToInt32(dtb.Consultar("select max(referencia) from Lotes", False).Rows(0).Item(0))
            Referencia = Referencia + 1
        Catch ex As Exception
            Referencia = 1
        End Try
    End Sub

    Public Function guardarLoteCompra(ByRef dtb As DataBase) As Boolean

        If Not dtb.ConsultaAlteraciones("insert into Lotes(Referencia,Fecha,CantidadRestante,TipoLoteID,TipoProductoID,ProveedorID,CodigoLote,descripcion,observacion,FechaModificacion,UsuarioModificacion) values(" & _
                                        Referencia & ",'" & Calendar.ArmarFecha(Fecha) & "'," & _
                            "'" & Convert.ToString(CantidadRestante) & "'," & _
                            "" & Convert.ToString(TipoLoteID) & "," & _
                            "" & Convert.ToString(TipoProductoID) & "," & _
                            Convert.ToString(ProveedorID) & "," & _
                            "'" & CodigoLote & "','" & Descripcion & "','" & Observacion & "', CURRENT_TIMESTAMP, " & Config.User & ")") Then

            Return False
        End If
        Try
            LoteID = Convert.ToInt32(dtb.Consultar("select max(LoteID) from Lotes", False).Rows(0).Item(0))
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


    Public Function Eliminar(ByRef dtb As DataBase) As Boolean
        Return dtb.ConsultaAlteraciones("delete from Lotes where LoteID = " & LoteID)
  
    End Function

    Public Function devolverLotesEnologicosParaMovimientoPorProceso(ByVal Proceso As Integer, ByRef dtb As DataBase) As DataTable
        Return dtb.Consultar("select Lotes.LoteID, Lotes.CodigoLote from " & _
                              " Lotes LEFT OUTER JOIN TiposProductos ON Lotes.TipoProductoID = TiposProductos.TipoProductoID inner join usosProductos on TiposProductos.TipoProductoID = usosproductos.TipoProductoID " & _
                              " where usosProductos.ProcesoID = " & Proceso & " and CantidadRestante > 0", False)
    End Function

    Public Sub validarLoteDiferencia(ByRef dtb As DataBase)
        Try
            Dim tabla As DataTable = dtb.Consultar("select Lotes.LoteID, cantidadRestante, descripcion from Lotes where codigoLote = '" & CodigoLote & "'", False)
            LoteID = Convert.ToInt32(tabla.Rows(0).Item(0))
            CantidadRestante = Convert.ToDouble(tabla.Rows(0).Item(1))
            Descripcion = CStr(tabla.Rows(0).Item(2))
        Catch ex As Exception
            LoteID = 0
            CantidadRestante = 0
            Descripcion = ""
        End Try
    End Sub

    Public Sub DevolverEnologicosParaMovimientosPorLoteID(ByRef dtb As DataBase)
        Dim tabla As DataTable = dtb.Consultar("select Lotes.LoteID, Lotes.CantidadRestante,TipoProductoID, Lotes.CodigoLote from Lotes where LoteID =" & Convert.ToString(LoteID), False)
        Try
            LoteID = Convert.ToInt32(tabla.Rows(0).Item(0))
            CantidadRestante = Convert.ToDouble(tabla.Rows(0).Item(1))
            TipoProductoID = CStr(tabla.Rows(0).Item(2))
            CodigoLote = CStr(tabla.Rows(0).Item(0))
        Catch ex As Exception
            LoteID = 0
            CantidadRestante = 0
            TipoProductoID = "0"
            CodigoLote = ""
        End Try
    End Sub


    Public Function DevolverLotesTrazabilidad(ByVal Lote As Integer, ByRef dtb As DataBase) As DataTable
        Return dtb.Consultar("select Lotes.CodigoLote AS ComponeA, Lotes_Partida.LoteID, Lotes_Partida.CodigoLote, Movimientos.Fecha, Procesos.Descripcion AS Proceso, CompuestoPor.Cantidad, Proveedores.Nombre " & _
                              "from Lotes INNER JOIN CompuestoPor ON Lotes.LoteID = CompuestoPor.LoteFinal LEFT JOIN Movimientos ON CompuestoPor.MovimientoID = Movimientos.MovimientoID LEFT JOIN Lotes AS Lotes_Partida ON CompuestoPor.LotePartida = Lotes_Partida.LoteID LEFT JOIN Procesos ON Movimientos.ProcesoID = Procesos.ProcesoID LEFT JOIN Proveedores ON Lotes_Partida.ProveedorID = Proveedores.ProveedorID" & _
                              " where Lotes.LoteID =" & Lote, False)
    End Function

End Class
