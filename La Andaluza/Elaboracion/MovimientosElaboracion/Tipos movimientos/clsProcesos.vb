Public Class clsProcesos

#Region "Atributos"
    Private ProcesoID As Integer
    Private Descripcion As String
    Private TipoProductoParaLote As String
    Private TipoMovimiento As String
    Private TipoLoteID As String
    Private ConMuestra As Boolean
#End Region

    Public Property _ProcesoID() As Integer
        Get
            Return ProcesoID
        End Get

        Set(ByVal value As Integer)
            ProcesoID = value
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

    Public Property _TipoProductoParaLote() As String
        Get
            Return TipoProductoParaLote
        End Get

        Set(ByVal value As String)
            TipoProductoParaLote = value
        End Set
    End Property

    Public Property _TipoMovimiento() As String
        Get
            Return TipoMovimiento
        End Get

        Set(ByVal value As String)
            TipoMovimiento = value
        End Set
    End Property

    Public Property _ConMuestra() As Boolean
        Get
            Return ConMuestra
        End Get

        Set(ByVal value As Boolean)
            ConMuestra = value
        End Set
    End Property

    Public Property _TipoLoteID() As Integer
        Get
            If TipoLoteID = "null" Then
                Return 0
            Else
                Return Convert.ToInt32(TipoLoteID)
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


    Public Sub devolverTipoMovimientoPorDescripcion(ByRef dtb As DataBase)
        Try
            TipoMovimiento = dtb.Consultar("select tiposmovimiento.descripcion as TipoMovimiento from Procesos, tiposmovimientos where tipomovimientoid = id and procesos.Descripcion ='" & Descripcion & "'", False).Rows(0).Item(0).ToString
        Catch ex As Exception
            TipoMovimiento = ""
        End Try

    End Sub


    Public Sub Cargar(ByRef dtb As DataBase)
        Dim tabla As DataTable = dtb.Consultar("select Procesos.Descripcion,Procesos.TipoProductoParaLote,Tiposmovimiento.descripcion as TipoMovimiento,TiposLotes.tipoLoteID As TiposLotes, Procesos.ConMuestra " & _
                                               " from Procesos inner join tiposmovimientos on tipomovimientoid = id LEFT JOIN TiposLotes On Procesos.TipoLoteID = TiposLotes.TipoLoteID " & _
                                               "where Procesos.ProcesoId = " & Convert.ToString(ProcesoID), False)

        Try
            Descripcion = tabla.Rows(0).Item(0).ToString
            TipoProductoParaLote = tabla.Rows(0).Item(1).ToString
            TipoMovimiento = tabla.Rows(0).Item(2).ToString

           
            If IsDBNull(tabla.Rows(0).Item(3)) Then
                TipoLoteID = "0"
            Else
                TipoLoteID = tabla.Rows(0).Item(3).ToString
            End If
            If IsDBNull(tabla.Rows(0).Item(4)) Then
                ConMuestra = False
            Else
                ConMuestra = Convert.ToBoolean(tabla.Rows(0).Item(4))
            End If

        Catch ex As Exception
            Descripcion = ""
            TipoProductoParaLote = ""
            TipoMovimiento = ""
            TipoLoteID = "0"
            ConMuestra = False
        End Try
    End Sub

    Public Function devolverProcesosPorDescripcion(ByRef dtb As DataBase) As DataTable
        Return dtb.Consultar("select ProcesoID,Descripcion from Procesos where ProcesoID>0 and procesoid<>16 ORDER BY Descripcion", False)
    End Function

End Class
