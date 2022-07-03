Public Class ClsEntSewa
    Private _id_sewa As String
    Private _tgl_ambil As Date
    Private _tgl_kembali As Date
    Private _id_cost As String
    Private _id_mobil As String
    Private _id_supir As String
    Private _nama As String
    Private _nik As Integer
    Private _nohp As Integer
    Private _merekmobil As String
    Private _id_bayar As String
    Private _total_bayar As Integer

    Public Property IDSewa As String
        Get
            Return _id_sewa
        End Get
        Set(ByVal value As String)
            _id_sewa = value
        End Set
    End Property

    Public Property TglAmbil As Date
        Get
            Return _tgl_ambil
        End Get
        Set(ByVal value As Date)
            _tgl_ambil = value
        End Set
    End Property

    Public Property TglKembali As Date
        Get
            Return _tgl_kembali
        End Get
        Set(ByVal value As Date)
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

    Public Property NIK As Integer
        Get
            Return _nik
        End Get
        Set(ByVal value As Integer)
            _nik = value
        End Set
    End Property

    Public Property NOHP As Integer
        Get
            Return _nohp
        End Get
        Set(ByVal value As Integer)
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
End Class
