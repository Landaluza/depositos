Public Class clsCompuestoPor

#Region "Atributos"
    Private LoteFinal As Integer
    Private LotePartida As Integer
    Private MovimientoID As String
    Private Cantidad As Double
#End Region

    Public Property _LoteFinal() As Integer
        Get
            Return LoteFinal
        End Get

        Set(ByVal value As Integer)
            LoteFinal = value
        End Set
    End Property

    Public Property _LotePartida() As Integer
        Get
            Return LotePartida
        End Get

        Set(ByVal value As Integer)
            LotePartida = value
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

    Public Property _MovimientoID() As Integer
        Get
            If MovimientoID = "null" Then
                Return 0
            Else
                Return Convert.ToInt32(MovimientoID)
            End If
        End Get

        Set(ByVal value As Integer)
            If value = 0 Then
                MovimientoID = "null"
            Else
                MovimientoID = value.ToString
            End If
        End Set
    End Property


    Public Function DevolverPorMovimiento(ByRef dtb As Connection.DataBase) As DataTable
        Return dtb.Consultar("select LoteFinal,LotePartida,Cantidad from CompuestoPor where MovimientoID=" & Convert.ToString(MovimientoID), False)
    End Function


    Public Function Insertar(ByRef dtb As Connection.DataBase) As Boolean
        Try
            If Not dtb.ConsultaAlteraciones("insert into CompuestoPor(lotefinal, lotepartida, movimientoid, cantidad) values(" & Convert.ToString(LoteFinal) & "," & _
                                    "" & Convert.ToString(LotePartida) & "," & _
                                    "" & Convert.ToString(MovimientoID) & "," & _
                                    "'" & Convert.ToString(Cantidad).Replace(",", ".") & "')") Then
                Return False
            End If

            LoteFinal = Convert.ToInt32(dtb.Consultar("select max(LoteFinal) from CompuestoPor", False).Rows(0).Item(0))
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function RevertirMovimiento(ByRef dtb As Connection.DataBase) As Boolean
        Dim dt As DataTable
        Try
            dt = dtb.Consultar("RevertirMovimiento " & Convert.ToString(LotePartida) & "," & "'" & Convert.ToString(Cantidad).Replace(",", ".") & "'")
            If dt Is Nothing Then Return False
            If dt.Rows.Count = 0 Then Return False
            If dt.Rows(0).Item(0) Is Convert.DBNull Then Return False

            If Convert.ToBoolean(dt.Rows(0).Item(0)) <> True Then Return False

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function Eliminar(ByRef dtb As Connection.DataBase) As Boolean
        Return dtb.ConsultaAlteraciones("delete from CompuestoPor where LoteFinal = " & Convert.ToString(LoteFinal) & " and LotePartida =" & Convert.ToString(LotePartida))
    End Function

End Class
