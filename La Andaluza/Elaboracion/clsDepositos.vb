Public Class clsDepositos

#Region "Atributos"
    Private DepositoID As Integer
    Private Codigo As String
    Private FechaCreacion As Date
    Private Capacidad As Integer
    Private DoctoUbicacionFisica As String
    Private TonelID As String
    Private TransicubaID As String
    Private BotaID As String
    Private BotaPiernaID As String
    Private MaterialConstruccionID As String
    Private Listado As Boolean    
#End Region

#Region "Propiedades"
    Public Property _DepositoID() As Integer
        Get
            Return DepositoID
        End Get

        Set(ByVal value As Integer)
            DepositoID = value
        End Set
    End Property

    Public Property _Codigo() As String
        Get
            Return Codigo
        End Get

        Set(ByVal value As String)
            Codigo = value
        End Set
    End Property

    Public Property _FechaCreacion() As DateTime
        Get
            Return FechaCreacion
        End Get

        Set(ByVal value As DateTime)
            FechaCreacion = value
        End Set
    End Property

    Public Property _Capacidad() As Double
        Get
            Return Convert.ToDouble(Capacidad)
        End Get

        Set(ByVal value As Double)
            Capacidad = Convert.ToInt32(value)
        End Set
    End Property

    Public Property _DoctoUbicacionFisica() As String
        Get
            Return DoctoUbicacionFisica
        End Get

        Set(ByVal value As String)
            DoctoUbicacionFisica = value
        End Set
    End Property

    Public Property _TonelID() As Integer
        Get
            If TonelID = "null" Then
                Return 0
            Else
                Return Convert.ToInt32(TonelID)
            End If
        End Get

        Set(ByVal value As Integer)
            If value = 0 Then
                TonelID = "null"
            Else
                TonelID = value.ToString
            End If
        End Set
    End Property

    Public Property _TransicubaID() As Integer
        Get
            If TransicubaID = "null" Then
                Return 0
            Else
                Return Convert.ToInt32(TransicubaID)
            End If
        End Get

        Set(ByVal value As Integer)
            If value = 0 Then
                TransicubaID = "null"
            Else
                TransicubaID = value.ToString
            End If
        End Set
    End Property

    Public Property _BotaID() As Integer
        Get
            If BotaID = "null" Then
                Return 0
            Else
                Return Convert.ToInt32(BotaID)
            End If
        End Get

        Set(ByVal value As Integer)
            If value = 0 Then
                BotaID = "null"
            Else
                BotaID = value.ToString
            End If
        End Set
    End Property


    Public Property _BotaPiernaID() As Integer
        Get
            If BotaPiernaID = "null" Then
                Return 0
            Else
                Return Convert.ToInt32(BotaPiernaID)
            End If
        End Get

        Set(ByVal value As Integer)
            If value = 0 Then
                BotaPiernaID = "null"
            Else
                BotaPiernaID = value.ToString
            End If
        End Set
    End Property

    Public Property _MaterialConstruccionID() As Integer
        Get
            If MaterialConstruccionID = "null" Then
                Return 0
            Else
                Return Convert.ToInt32(MaterialConstruccionID)
            End If
        End Get

        Set(ByVal value As Integer)
            If value = 0 Then
                MaterialConstruccionID = "null"
            Else
                MaterialConstruccionID = value.ToString
            End If
        End Set
    End Property

    Public Property _Listado() As Boolean
        Get
            Return Listado
        End Get

        Set(ByVal value As Boolean)
            Listado = value
        End Set
    End Property
#End Region

#Region "Metodos"
    Public Function devolverDepositosFinales(ByRef dtb As DataBase) As DataTable
        Return dtb.Consultar("devolverDepositosFinales", True)
    End Function

    Public Function devolverDepositosPartidas(ByRef dtb As DataBase) As DataTable
        Return dtb.Consultar("devolverDepositosPartidas", True)
    End Function

    Public Sub Cargar(ByRef dtb As DataBase)
        Try
            Dim tabla As New DataTable
            tabla = dtb.Consultar("select Depositos.FechaCreacion, Depositos.Capacidad,Depositos.DoctoUbicacionFisica,TonelID,TransicubaID, BotaID, BotaPiernaID from Depositos where DepositoID=" & DepositoID, False)

            If Convert.IsDBNull(tabla.Rows(0).Item(0)) Then
                FechaCreacion = DateTime.Now.Date
            Else
                FechaCreacion = CDate(tabla.Rows(0).Item(0))
            End If

            Capacidad = Convert.ToInt32(tabla.Rows(0).Item(1))
            If Convert.IsDBNull(tabla.Rows(0).Item(2)) Then
                DoctoUbicacionFisica = ""
            Else
                DoctoUbicacionFisica = tabla.Rows(0).Item(2).ToString
            End If
            If Convert.IsDBNull(tabla.Rows(0).Item(3)) Then
                _TonelID = 0
            Else
                TonelID = tabla.Rows(0).Item(3).ToString
            End If
            If Convert.IsDBNull(tabla.Rows(0).Item(4)) Then
                _TransicubaID = 0
            Else
                TransicubaID = tabla.Rows(0).Item(4).ToString
            End If
            If Convert.IsDBNull(tabla.Rows(0).Item(5)) Then
                _BotaID = 0
            Else
                BotaID = tabla.Rows(0).Item(5).ToString
            End If
            If Convert.IsDBNull(tabla.Rows(0).Item(6)) Then
                _BotaPiernaID = 0
            Else
                BotaPiernaID = tabla.Rows(0).Item(6).ToString
            End If
        Catch ex As Exception
            Capacidad = 0
            DoctoUbicacionFisica = ""
            _TonelID = 0
            _TransicubaID = 0
            _BotaID = 0
            _BotaPiernaID = 0
        End Try
    End Sub

   

   
    Public Function devolverTransicubasActivas(ByRef dtb As DataBase) As DataTable
        Return dtb.Consultar("select Depositos.TransicubaID,Depositos.Codigo from " & _
                              "Depositos INNER JOIN Transicubas ON Depositos.TransicubaID = Transicubas.TransicubaID where " & _
                              "(Transicubas.Estado = 'True')  and Depositos.DepositoID not in (SELECT DISTINCT Depositos.DepositoID FROM Depositos INNER JOIN Transicubas ON Depositos.TransicubaID = Transicubas.TransicubaID INNER JOIN Lotes ON Depositos.DepositoID = Lotes.DepositoID WHERE (Transicubas.Estado = 'True')) order by Depositos.Codigo", False)
    End Function

   

   
#End Region
End Class
