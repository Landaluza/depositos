﻿



Public Class Web


    Public Sub New()

    End Sub

    Public Sub send_GET(ByVal msg As String, ByVal regId As String)
        'Dim request As WebRequest = WebRequest.Create("http://192.168.10.106/gcm/send_message.php") '" & regid & "&message=" & message)
        'request.Method = "GET"

        'Dim byteArray As Byte() = Encoding.UTF8.GetBytes(msg)
        'Dim byteArray2 As Byte() = Encoding.UTF8.GetBytes(regId)
        'request.ContentType = "application/x-www-form-urlencoded"
        'request.ContentLength = byteArray.Length + byteArray2.Length

        'Dim dataStream As Stream = request.GetRequestStream()
        'dataStream.Write(byteArray, 0, byteArray.Length)
        'dataStream.Write(byteArray2, 0, byteArray.Length)
        'dataStream.Close()
        'messageBox.show("Done")
        Dim webClient As New System.Net.WebClient
        Dim result As String = webClient.DownloadString("http://192.168.10.106/gcm/send_message.php?regId=" & regId & "&message=" & msg)
        'messageBox.show(result)
    End Sub

    Public Function recuperar_id_tablet(ByVal usuarioid As Integer, ByRef dtb As Connection.DataBase) As String
        dtb.PrepararConsulta("select gcm_regid from gcm_Users where id_usuario= @id")
        dtb.AñadirParametroConsulta("@id", usuarioid)
        Return dtb.Consultar().Rows(0).Item(0).ToString
    End Function
End Class
