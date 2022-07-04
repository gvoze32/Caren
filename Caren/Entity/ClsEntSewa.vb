Public Class ClsEntSewa
    Private _id_sewa As String
    Private _tgl_ambil As String
    Private _tgl_kembali As String
    Private _id_cost As String
    Private _id_mobil As String
    Private _id_supir As String
    Private _nama As String
    Private _nik As String
    Private _nohp As String
    Private _merekmobil As String
    Private _id_bayar As String
    Private _total_bayar As Integer
    Private _session As String

    Public Property IDSewa As String
        Get
            Return _id_sewa
        End Get
        Set(ByVal value As String)
            _id_sewa = value
        End Set
    End Property

    Public Property TglAmbil As String
        Get
            Return _tgl_ambil
        End Get
        Set(ByVal value As String)
            _tgl_ambil = value
        End Set
    End Property

    Public Property TglKembali As String
        Get
            Return _tgl_kembali
        End Get
        Set(ByVal value As String)
            _tgl_kembali = value
        End Set
    End Property

    Public Property IDCost As String
        Get
            Return _id_cost
        End Get
        Set(ByVal value As String)
            _id_cost = value
        End Set
    End Property

    Public Property IDMobil As String
        Get
            Return _id_mobil
        End Get
        Set(ByVal value As String)
            _id_mobil = value
        End Set
    End Property

    Public Property IDSupir As String
        Get
            Return _id_supir
        End Get
        Set(ByVal value As String)
            _id_supir = value
        End Set
    End Property

    Public Property Nama As String
        Get
            Return _nama
        End Get
        Set(ByVal value As String)
            _nama = value
        End Set
    End Property

    Public Property NIK As String
        Get
            Return _nik
        End Get
        Set(ByVal value As String)
            _nik = value
        End Set
    End Property

    Public Property NOHP As String
        Get
            Return _nohp
        End Get
        Set(ByVal value As String)
            _nohp = value
        End Set
    End Property

    Public Property MerekMobil As String
        Get
            Return _merekmobil
        End Get
        Set(ByVal value As String)
            _merekmobil = value
        End Set
    End Property

    Public Property IDBayar As String
        Get
            Return _id_bayar
        End Get
        Set(ByVal value As String)
            _id_bayar = value
        End Set
    End Property

    Public Property TotalBayar As Integer
        Get
            Return _total_bayar
        End Get
        Set(ByVal value As Integer)
            _total_bayar = value
        End Set
    End Property

    Public Property Session As String
        Get
            Return _session
        End Get
        Set(ByVal value As String)
            _session = value
        End Set
    End Property
End Class
