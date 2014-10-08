Namespace Movimientos
    Namespace Procesos
        Public Class DBO_Procesos
            Inherits DataBussines

            Private m_Id As DataBussinesParameter
            Private m_Descripcion As DataBussinesParameter
            Private m_TipoProductoParaLote As DataBussinesParameter
            Private m_TipoLoteID As DataBussinesParameter
            Private m_ConMuestra As DataBussinesParameter
            Private m_TipoMovimientoID As DataBussinesParameter

            Public Sub New()
                MyBase.New()
                m_Id = New DataBussinesParameter("@ProcesoID", "ProcesoID")
                m_Descripcion = New DataBussinesParameter("@Descripcion", "Descripcion")
                m_TipoProductoParaLote = New DataBussinesParameter("@TipoProductoParaLote", "TipoProductoParaLote")
                m_TipoLoteID = New DataBussinesParameter("@TipoLoteID", "TipoLoteID")
                m_ConMuestra = New DataBussinesParameter("@ConMuestra", "ConMuestra")
                m_TipoMovimientoID = New DataBussinesParameter("@TipoMovimientoID", "TipoMovimientoID")
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

            Public Property TipoProductoParaLote() As String
                Get
                    If m_TipoProductoParaLote.value Is Convert.DBNull Then
                        Return String.Empty
                    End If
                    Return CType(m_TipoProductoParaLote.value, String)
                End Get
                Set(ByVal value As String)
                    m_TipoProductoParaLote.value = value
                End Set
            End Property

            Public Property TipoLoteID() As Integer
                Get
                    If m_TipoLoteID.value Is Convert.DBNull Then
                        Return 0
                    End If
                    Return CType(m_TipoLoteID.value, Integer)
                End Get
                Set(ByVal value As Integer)
                    m_TipoLoteID.value = value
                End Set
            End Property

            Public Property ConMuestra() As Boolean
                Get
                    If m_ConMuestra.value Is Convert.DBNull Then
                        Return False
                    End If
                    Return CType(m_ConMuestra.value, Boolean)
                End Get
                Set(ByVal value As Boolean)
                    m_ConMuestra.value = value
                End Set
            End Property

            Public Property TipoMovimientoID() As Integer
                Get
                    If m_TipoMovimientoID.value Is Convert.DBNull Then
                        Return 0
                    End If
                    Return CType(m_TipoMovimientoID.value, Integer)
                End Get
                Set(ByVal value As Integer)
                    m_TipoMovimientoID.value = value
                End Set
            End Property

            Private Sub añadirParametros()
                MyBase.atributos.Add(m_Id, m_Id.sqlName)
                MyBase.atributos.Add(m_Descripcion, m_Descripcion.sqlName)
                MyBase.atributos.Add(m_TipoProductoParaLote, m_TipoProductoParaLote.sqlName)
                MyBase.atributos.Add(m_TipoLoteID, m_TipoLoteID.sqlName)
                MyBase.atributos.Add(m_ConMuestra, m_ConMuestra.sqlName)
                MyBase.atributos.Add(m_TipoMovimientoID, m_TipoMovimientoID.sqlName)
            End Sub
        End Class
    End Namespace
End Namespace