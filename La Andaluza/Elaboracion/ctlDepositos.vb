Public Class ctlDepositos

    Private clsDep As clsDepositos
    Private clsTra As clsTransicubas

    Public Sub New()
        clsDep = New clsDepositos
        clsTra = New clsTransicubas

    End Sub

    Public Sub SetDepositoID(ByVal ID As Integer)
        clsDep._DepositoID = ID
    End Sub

    Public Function devolverDepositosFinales(ByRef dtb As DataBase) As DataTable
        Return clsDep.devolverDepositosFinales(dtb)
    End Function

    Public Function devolverDepositosPartidas(ByRef dtb As DataBase) As DataTable
        Return clsDep.devolverDepositosPartidas(dtb)
    End Function

    Public Sub CargarDepositos(ByRef dtb As DataBase)
        clsDep.Cargar(dtb)
    End Sub

    Public Function devolverCapacidadDeposito() As Integer
        Return Convert.ToInt32(clsDep._Capacidad)
    End Function


    '-------------------------------- TRANSICUBAS ---------------------------------------------


    Public Sub SetTransicubaID(ByVal ID As Integer)
        clsTra._TransicubaID = ID
    End Sub

    Public Function devolverTransicubasActivas(ByRef dtb As DataBase) As DataTable
        Return clsDep.devolverTransicubasActivas(dtb)
    End Function

    Public Function darDeBajaTransicuba(ByRef dtb As DataBase) As Boolean
        Return clsTra.darDeBajaTransicuba(dtb)
    End Function

End Class
