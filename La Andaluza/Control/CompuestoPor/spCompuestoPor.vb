

Class spCompuestoPor
    inherits sp
    Public DataGridViewStoredProcedureForFilteredSelect2 As String = "CompuestoPorDgvByLoteFinal"
    Public DataGridViewStoredProcedureForFilteredSelect3 As String = "CompuestoPorDgvByLotePartida"
    Public Sub New()
        MyBase.new("[dbo].[CompuestoPorSelect]", "[dbo].[CompuestoPorInsert]", "[dbo].[CompuestoPorUpdate]", _
                   "[dbo].[CompuestoPorDelete]", "CompuestoPorSelectDgv", "CompuestoPorSelectDgvByLotePartida")
    End Sub

    Public Function Select_Record(ByVal LoteFinal As Int32, ByVal LotePartida As Int32, ByVal MovimientoID As Int32, ByRef dtb As Connection.DataBase) As DBO_CompuestoPor
        dtb.Conectar()
        Dim DBO_CompuestoPor As New DBO_CompuestoPor
        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.Comando("[dbo].[CompuestoPorSelect]")
        If Not dtb.Transaccion Is Nothing Then selectCommand.Transaction = dtb.Transaccion
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@LoteFinal", LoteFinal)
        selectCommand.Parameters.AddWithValue("@LotePartida", LotePartida)
        selectCommand.Parameters.AddWithValue("@MovimientoID", MovimientoID)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then

                DBO_CompuestoPor.LoteFinal = If(reader("LoteFinal") Is Convert.DBNull, 0, Convert.ToInt32(reader("LoteFinal")))
                DBO_CompuestoPor.LotePartida = If(reader("LotePartida") Is Convert.DBNull, 0, Convert.ToInt32(reader("LotePartida")))
                DBO_CompuestoPor.MovimientoID = If(reader("MovimientoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("MovimientoID")))
                DBO_CompuestoPor.Cantidad = If(reader("Cantidad") Is Convert.DBNull, "0", reader("Cantidad").ToString)
                DBO_CompuestoPor.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_CompuestoPor.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))

            Else
                DBO_CompuestoPor = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException

        Finally
            dtb.Desconectar()
        End Try
        Return DBO_CompuestoPor
    End Function

    Public Function CompuestoPorInsert(ByVal dbo_CompuestoPor As DBO_CompuestoPor, ByRef dtb As Connection.DataBase) As Boolean
        dtb.Conectar()
        Dim insertCommand As System.Data.SqlClient.SqlCommand = dtb.Comando("[dbo].[CompuestoPorInsert]")
        insertCommand.CommandType = CommandType.StoredProcedure
        If Not dtb.Transaccion Is Nothing Then insertCommand.Transaction = dtb.Transaccion

        insertCommand.Parameters.AddWithValue("@LoteFinal", dbo_CompuestoPor.LoteFinal)
        insertCommand.Parameters.AddWithValue("@LotePartida", dbo_CompuestoPor.LotePartida)
        insertCommand.Parameters.AddWithValue("@MovimientoID", dbo_CompuestoPor.MovimientoID)
        insertCommand.Parameters.AddWithValue("@Cantidad", dbo_CompuestoPor.Cantidad)
        insertCommand.Parameters.AddWithValue("@FechaModificacion", System.DateTime.Now)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", Config.User)

        insertCommand.Parameters.Add("@ReturnValue", System.Data.SqlDbType.Int)
        insertCommand.Parameters("@ReturnValue").Direction = ParameterDirection.Output
        Try
            insertCommand.ExecuteNonQuery()
            Return True
        Catch ex As System.Data.SqlClient.SqlException
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function CompuestoPorUpdate(ByVal newDBO_CompuestoPor As DBO_CompuestoPor, ByRef dtb As Connection.DataBase) As Boolean
        dtb.Conectar()
        Dim updateCommand As System.Data.SqlClient.SqlCommand = dtb.Comando("[dbo].[CompuestoPorUpdate]")
        If Not dtb.Transaccion Is Nothing Then updateCommand.Transaction = dtb.Transaccion
        updateCommand.CommandType = CommandType.StoredProcedure
        '<Tag=[Three][Start]> -- please do not remove this line
        updateCommand.Parameters.AddWithValue("@NewCantidad", newDBO_CompuestoPor.Cantidad)
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_CompuestoPor.FechaModificacion)
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_CompuestoPor.UsuarioModificacion)
        updateCommand.Parameters.AddWithValue("@OldLoteFinal", newDBO_CompuestoPor.LoteFinal)
        updateCommand.Parameters.AddWithValue("@OldLotePartida", newDBO_CompuestoPor.LotePartida)
        updateCommand.Parameters.AddWithValue("@OldMovimientoID", newDBO_CompuestoPor.MovimientoID)
        '<Tag=[Three][End]> -- please do not remove this line
        updateCommand.Parameters.Add("@ReturnValue", System.Data.SqlDbType.Int)
        updateCommand.Parameters("@ReturnValue").Direction = ParameterDirection.Output
        Try
            updateCommand.ExecuteNonQuery()
            Return True
        Catch ex As System.Data.SqlClient.SqlException
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function CompuestoPorDelete(ByVal LoteFinal As Int32, ByVal LotePartida As Int32, ByVal MovimientoID As Int32, ByRef dtb As Connection.DataBase) As Boolean
        dtb.Conectar()
        Dim deleteCommand As System.Data.SqlClient.SqlCommand = dtb.Comando("[dbo].[CompuestoPorDelete]")
        deleteCommand.CommandType = CommandType.StoredProcedure
        If Not dtb.Transaccion Is Nothing Then deleteCommand.Transaction = dtb.Transaccion
        '<Tag=[Four][Start]> -- please do not remove this line
        deleteCommand.Parameters.AddWithValue("@OldLoteFinal", LoteFinal)
        deleteCommand.Parameters.AddWithValue("@OldLotePartida", LotePartida)
        deleteCommand.Parameters.AddWithValue("@OldMovimientoID", MovimientoID)
        '<Tag=[Four][End]> -- please do not remove this line
        deleteCommand.Parameters.Add("@ReturnValue", System.Data.SqlDbType.Int)
        deleteCommand.Parameters("@ReturnValue").Direction = ParameterDirection.Output
        Try
            deleteCommand.ExecuteNonQuery()
            Return True
        Catch ex As System.Data.SqlClient.SqlException
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function GrabarCompuestoPor(ByVal dbo_CompuestoPor As DBO_CompuestoPor, ByRef dtb As Connection.DataBase) As Boolean
        dbo_CompuestoPor.FechaModificacion = System.DateTime.Now.Date
        dbo_CompuestoPor.UsuarioModificacion = Config.User
        If dbo_CompuestoPor.LoteFinal = 0 Then
            Return CompuestoPorInsert(dbo_CompuestoPor, dtb)
        Else
            Return CompuestoPorUpdate(dbo_CompuestoPor, dtb)
        End If
    End Function

End Class
