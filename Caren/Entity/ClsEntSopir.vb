Public Class ClsEntSopir
    Private _id_supir As String
    Private _nama_supir As String
    Private _nomor_hape As String

    Public Property IdSupir As String
        Get
            Return _id_supir
        End Get
        Set(ByVal value As String)
            _id_supir = value
        End Set
    End Property

    Public Property NamaSupir As String
        Get
            Return _nama_supir
        End Get
        Set(ByVal value As String)
            _nama_supir = value
        End Set
    End Property

    Public Property NoHp As String
        Get
            Return _nomor_hape
        End Get
        Set(ByVal value As String)
            _nomor_hape = value
        End Set
    End Property
End Class
