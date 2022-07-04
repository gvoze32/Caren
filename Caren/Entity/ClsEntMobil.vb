Public Class ClsEntMobil
    Private _idMobil As String
    Private _merekMobil As String
    Private _tipeKendaraan As String
    Private _hargaSewa As Integer
    Private _Session As String

    Public Property IdMobil As String
        Get
            Return _idMobil
        End Get
        Set(value As String)
            _idMobil = value
        End Set
    End Property

    Public Property MerekMobil As String
        Get
            Return _merekMobil
        End Get
        Set(value As String)
            _merekMobil = value
        End Set
    End Property

    Public Property TipeKendaraan As String
        Get
            Return _tipeKendaraan
        End Get
        Set(value As String)
            _tipeKendaraan = value
        End Set
    End Property

    Public Property HargaSewa As Integer
        Get
            Return _hargaSewa
        End Get
        Set(value As Integer)
            _hargaSewa = value
        End Set
    End Property

    Public Property Session As String
        Get
            Return _Session
        End Get
        Set(value As String)
            _Session = value
        End Set
    End Property
End Class
