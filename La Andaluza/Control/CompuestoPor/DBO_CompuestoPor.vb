Public Class DBO_CompuestoPor


   Private m_LoteFinal As Int32
   Private m_LotePartida As Int32
   Private m_MovimientoID As Int32
    Private m_Cantidad As String
   Private m_FechaModificacion As date
   Private m_UsuarioModificacion As Int32


   Public Sub New()

   End Sub


   Public Property LoteFinal() As Int32
       Get
           Return m_LoteFinal
       End Get
       Set(ByVal value As Int32)
           m_LoteFinal = value
       End Set
   End Property

   Public Property LotePartida() As Int32
       Get
           Return m_LotePartida
       End Get
       Set(ByVal value As Int32)
           m_LotePartida = value
       End Set
   End Property

   Public Property MovimientoID() As Int32
       Get
           Return m_MovimientoID
       End Get
       Set(ByVal value As Int32)
           m_MovimientoID = value
       End Set
   End Property

    Public Property Cantidad() As String
        Get
            Return m_Cantidad
        End Get
        Set(ByVal value As String)
            m_Cantidad = value
        End Set
    End Property

   Public Property FechaModificacion() As Date
       Get
           Return m_FechaModificacion
       End Get
        Set(ByVal value As Date)
            m_FechaModificacion = value
        End Set
   End Property

   Public Property UsuarioModificacion() As Int32
       Get
           Return m_UsuarioModificacion
       End Get
       Set(ByVal value As Int32)
           m_UsuarioModificacion = value
       End Set
   End Property


End Class
