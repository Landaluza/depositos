Public Class DBO_Procesos
Inherits DataBussines

   Private m_Id As DataBussinesParameter
   Private m_Descripcion As DataBussinesParameter
   Private m_TipoProductoParaLote As DataBussinesParameter
   Private m_TipoMovimiento As DataBussinesParameter
   Private m_TipoLoteID As DataBussinesParameter
   Private m_ConMuestra As DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New DataBussinesParameter("@ProcesoID","ProcesoID")
       m_Descripcion= New DataBussinesParameter("@Descripcion","Descripcion")
       m_TipoProductoParaLote= New DataBussinesParameter("@TipoProductoParaLote","TipoProductoParaLote")
       m_TipoMovimiento= New DataBussinesParameter("@TipoMovimiento","TipoMovimiento")
       m_TipoLoteID= New DataBussinesParameter("@TipoLoteID","TipoLoteID")
       m_ConMuestra= New DataBussinesParameter("@ConMuestra","ConMuestra")
       MyBase.primaryKey = m_Id
       añadirParametros()
   End Sub

   Public Property ID() As Int32
       Get
           if m_id.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_id.value,int32)
       End Get
       Set(ByVal value As Int32)
           Me.primaryKey.value = value
           m_id.value = value
       End Set
   End Property

   Public Property Descripcion() As String
       Get
           if m_Descripcion.value is convert.dbnull then
             Return string.empty
           End if
           Return ctype(m_Descripcion.value,string)
       End Get
       Set(ByVal value As String)
           m_Descripcion.value = value
       End Set
   End Property

   Public Property TipoProductoParaLote() As String
       Get
           if m_TipoProductoParaLote.value is convert.dbnull then
             Return string.empty
           End if
           Return ctype(m_TipoProductoParaLote.value,string)
       End Get
       Set(ByVal value As String)
           m_TipoProductoParaLote.value = value
       End Set
   End Property

   Public Property TipoMovimiento() As String
       Get
           if m_TipoMovimiento.value is convert.dbnull then
             Return string.empty
           End if
           Return ctype(m_TipoMovimiento.value,string)
       End Get
       Set(ByVal value As String)
           m_TipoMovimiento.value = value
       End Set
   End Property

   Public Property TipoLoteID() As Int32
       Get
           if m_TipoLoteID.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_TipoLoteID.value,int32)
       End Get
       Set(ByVal value As Int32)
           m_TipoLoteID.value = value
       End Set
   End Property

   Public Property ConMuestra() As Boolean
       Get
           if m_ConMuestra.value is convert.dbnull then
             Return false
           End if
           Return ctype(m_ConMuestra.value,boolean)
       End Get
       Set(ByVal value As Boolean)
           m_ConMuestra.value = value
       End Set
   End Property

   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_Descripcion, m_Descripcion.sqlName)
       MyBase.atributos.Add(m_TipoProductoParaLote, m_TipoProductoParaLote.sqlName)
       MyBase.atributos.Add(m_TipoMovimiento, m_TipoMovimiento.sqlName)
       MyBase.atributos.Add(m_TipoLoteID, m_TipoLoteID.sqlName)
       MyBase.atributos.Add(m_ConMuestra, m_ConMuestra.sqlName)
   End Sub
End Class
