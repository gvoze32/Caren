Imports System.Data.Odbc

Public Class ClsCtlSopir : Implements InfProses
    Public Function InsertData(Ob As Object) As OdbcCommand Implements InfProses.InsertData
        Dim data As New ClsEntSopir
        data = Ob
        CMD = New OdbcCommand("insert into supir values('" & data.IdSupir & "','" & data.NamaSupir & "','" & data.NoHp & "')", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OdbcCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function updateData(Ob As Object) As OdbcCommand Implements InfProses.updateData
        Dim data As New ClsEntSopir
        data = Ob
        CMD = New OdbcCommand("update supir set nama_supir='" & data.NamaSupir & "'," & "nomor_hape='" & data.NoHp & "' where id_supir='" & data.IdSupir & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OdbcCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function deleteData(kunci As String) As OdbcCommand Implements InfProses.deleteData
        CMD = New OdbcCommand("delete from supir where id_supir='" & kunci & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OdbcCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OdbcDataAdapter("select * from supir", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_Supir")
            Dim grid As New DataView(DTS.Tables("Tabel_Supir"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Try
            DTA = New OdbcDataAdapter("select * from supir where nama_supir " & " like '%" & kunci & "%'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Cari_supir")
            Dim grid As New DataView(DTS.Tables("Cari_supir"))
            Return grid
        Catch ex As Exception
            Throw New ArgumentException(ex.Message)
        End Try
    End Function

    Function kodebaru() As String
        Dim baru As String
        Dim kodeakhir As Integer
        Try
            DTA = New OdbcDataAdapter("select max(right(id_supir,3)) from supir", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "D" & Strings.Right("00" & kodeakhir + 1, 3)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Function CekSopirDireferensi(kunci As String) As Boolean
        Dim cek As Boolean
        cek = False
        Try
            DTA = New OdbcDataAdapter("Select count(id_supir) from sewa " _
                                       & "where id_supir='" & kunci & "'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "cek")
            If DTS.Tables("cek").Rows(0)(0).ToString > 0 Then cek = True
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return cek
    End Function
End Class