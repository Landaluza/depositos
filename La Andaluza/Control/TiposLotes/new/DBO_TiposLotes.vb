Public Class DBO_TiposLotes
Inherits DataBussines

   Private m_Id As DataBussinesParameter
   Private m_Descripcion As DataBussinesParameter
   Private m_Abreviatura As DataBussinesParameter
   Private m_Orden As DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New DataBussinesParameter("@TipoLoteID","TipoLoteID")
       m_Descripcion= New DataBussinesParameter("@Descripcion","Descripcion")
       m_Abreviatura= New DataBussinesParameter("@Abreviatura","Abreviatura")
       m_Orden= New DataBussinesParameter("@Orden","Orden")
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

   Public Property Orden() As Int32
       Get
            Return If(IsDBNull(m_Orden.value), Nothing, Convert.ToInt32(m_Orden.value))
       End Get
       Set(ByVal value As Int32)
           m_Orden.value = value
       End Set
   End Property



   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_Descripcion, m_Descripcion.sqlName)
       MyBase.atributos.Add(m_Abreviatura, m_Abreviatura.sqlName)
       MyBase.atributos.Add(m_Orden, m_Orden.sqlName)
   End Sub
End Class
