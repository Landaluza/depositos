Namespace Movimientos
    Namespace Tipos

    Public Class Tipos
        Inherits DataBussines

        Private m_Id As DataBussinesParameter
        Private m_Abreviatura As DataBussinesParameter
        Private m_Descripcion As DataBussinesParameter
        Private m_Observaciones As DataBussinesParameter

        Public Sub New()
            MyBase.New()
            m_Id = New DataBussinesParameter("@Id", "Id")
            m_Abreviatura = New DataBussinesParameter("@Abreviatura", "Abreviatura")
            m_Descripcion = New DataBussinesParameter("@Descripcion", "Descripcion")
            m_Observaciones = New DataBussinesParameter("@Observaciones", "Observaciones")
            MyBase.primaryKey = m_Id
            añadirParametros()
        End Sub

        Public Property ID() As Integer
            Get
                If m_Id.value Is Convert.DBNull Then
                    Return 0
                End If
                Return CType(m_Id.value, Integer)
            End Get
            Set(ByVal value As Integer)
                Me.primaryKey.value = value
                m_Id.value = value
            End Set
        End Property

        Public Property Abreviatura() As String
            Get
                If m_Abreviatura.value Is Convert.DBNull Then
                    Return Nothing
                End If
                Return Convert.ToString(m_Abreviatura.value)
            End Get
            Set(ByVal value As String)
                m_Abreviatura.value = value
            End Set
        End Property

        Public Property Descripcion() As String
            Get
                If m_Descripcion.value Is Convert.DBNull Then
                    Return String.Empty
                End If
                Return CType(m_Descripcion.value, String)
            End Get
            Set(ByVal value As String)
                m_Descripcion.value = value
            End Set
        End Property

        Public Property Observaciones() As String
            Get
                If m_Observaciones.value Is Convert.DBNull Then
                    Return String.Empty
                End If
                Return CType(m_Observaciones.value, String)
            End Get
            Set(ByVal value As String)
                m_Observaciones.value = value
            End Set
        End Property

        Private Sub añadirParametros()
            MyBase.atributos.Add(m_Id, m_Id.sqlName)
            MyBase.atributos.Add(m_Abreviatura, m_Abreviatura.sqlName)
            MyBase.atributos.Add(m_Descripcion, m_Descripcion.sqlName)
            MyBase.atributos.Add(m_Observaciones, m_Observaciones.sqlName)
        End Sub
    End Class

    End Namespace

End Namespace
