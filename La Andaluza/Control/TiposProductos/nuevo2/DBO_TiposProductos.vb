Public Class DBO_TiposProductos
Inherits DataBussines

   Private m_Id As DataBussinesParameter
   Private m_Descripcion As DataBussinesParameter
   Private m_Abreviatura As DataBussinesParameter
   Private m_Enologico As DataBussinesParameter
   Private m_MedidaID As DataBussinesParameter
   Private m_id_palet_no_conforme As DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New DataBussinesParameter("@TipoProductoID","TipoProductoID")
       m_Descripcion= New DataBussinesParameter("@Descripcion","Descripcion")
       m_Abreviatura= New DataBussinesParameter("@Abreviatura","Abreviatura")
       m_Enologico= New DataBussinesParameter("@Enologico","Enologico")
       m_MedidaID= New DataBussinesParameter("@MedidaID","MedidaID")
       m_id_palet_no_conforme= New DataBussinesParameter("@id_palet_no_conforme","id_palet_no_conforme")
       MyBase.primaryKey = m_Id
       añadirParametros()
   End Sub


   Public Property ID() As Int32
       Get
            Return If(IsDBNull(m_Id.value), Nothing, Convert.ToInt32(m_Id.value))
       End Get
       Set(ByVal value As Int32)
           Me.primaryKey.value = value
           m_id.value = value
       End Set
   End Property

   Public Property Descripcion() As String
       Get
            Return If(IsDBNull(m_Descripcion.value), String.Empty, m_Descripcion.value.ToString)
       End Get
       Set(ByVal value As String)
           m_Descripcion.value = value
       End Set
   End Property

   Public Property Abreviatura() As String
       Get
            Return If(IsDBNull(m_Abreviatura.value), String.Empty, m_Abreviatura.value.ToString)
       End Get
       Set(ByVal value As String)
           m_Abreviatura.value = value
       End Set
   End Property

   Public Property Enologico() As Boolean
       Get
            Return If(IsDBNull(m_Enologico.value), False, Convert.ToBoolean(m_Enologico.value))
       End Get
       Set(ByVal value As Boolean)
           m_Enologico.value = value
       End Set
   End Property

   Public Property MedidaID() As Int32
       Get
            Return If(IsDBNull(m_MedidaID.value), Nothing, Convert.ToInt32(m_MedidaID.value))
       End Get
       Set(ByVal value As Int32)
           m_MedidaID.value = value
       End Set
   End Property

   Public Property id_palet_no_conforme() As Int32
       Get
            Return If(IsDBNull(m_id_palet_no_conforme.value), Nothing, Convert.ToInt32(m_id_palet_no_conforme.value))
       End Get
       Set(ByVal value As Int32)
           m_id_palet_no_conforme.value = value
       End Set
   End Property



   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_Descripcion, m_Descripcion.sqlName)
       MyBase.atributos.Add(m_Abreviatura, m_Abreviatura.sqlName)
       MyBase.atributos.Add(m_Enologico, m_Enologico.sqlName)
       MyBase.atributos.Add(m_MedidaID, m_MedidaID.sqlName)
       MyBase.atributos.Add(m_id_palet_no_conforme, m_id_palet_no_conforme.sqlName)
   End Sub
End Class
