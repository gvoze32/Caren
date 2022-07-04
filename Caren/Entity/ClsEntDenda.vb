Public Class ClsEntDenda
    Private _idBayar As String
    Private _denda As String
    Private _total_bayar As String
    Private _id_sewa As String

    Public Property IdBayar As String
        Get
            Return _idBayar
        End Get
        Set(ByVal value As String)
            _idBayar = value
        End Set
    End Property

    Public Property Denda As String
        Get
            Return _denda
        End Get
        Set(ByVal value As String)
            _denda = value
        End Set
    End Property

    Public Property TotalBayar As String
        Get
            Return _total_bayar
        End Get
        Set(ByVal value As String)
            _total_bayar = value
        End Set
    End Property

    Public Property IdSewa As String
        Get
            Return _id_sewa
        End Get
        Set(ByVal value As String)
            _id_sewa = value
        End Set
    End Property

End Class
