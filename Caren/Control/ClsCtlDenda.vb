Imports System.Data.Odbc

Public Class ClsCtlDenda : Implements InfProses
    Public Function updateData(Ob As Object) As OdbcCommand Implements InfProses.updateData
        Dim data As New ClsEntDenda
        data = Ob
        CMD = New OdbcCommand("update bayar set denda='" & data.Denda & "'," & "total_bayar='" & data.TotalBayar & "' where id_bayar='" & data.IdBayar & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OdbcCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function deleteData(kunci As String) As OdbcCommand Implements InfProses.deleteData
        CMD = New OdbcCommand("delete from bayar where id_bayar='" & kunci & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OdbcCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OdbcDataAdapter("select * from bayar", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_Bayar")
            Dim grid As New DataView(DTS.Tables("Tabel_Bayar"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Try
            DTA = New OdbcDataAdapter("select * from bayar where id_bayar " & " like '%" & kunci & "%'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Cari_bayar")
            Dim grid As New DataView(DTS.Tables("Cari_bayar"))
            Return grid
        Catch ex As Exception
            Throw New ArgumentException(ex.Message)
        End Try
    End Function

    Function CekDendaDireferensi(kunci As String) As Boolean
        Dim cek As Boolean
        cek = False
        Try
            DTA = New OdbcDataAdapter("Select count(id_bayar) from memeriksa " _
                                       & "where id_bayar='" & kunci & "'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "cek")
            If DTS.Tables("cek").Rows(0)(0).ToString > 0 Then cek = True
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return cek
    End Function

    Public Function InsertData(Ob As Object) As OdbcCommand Implements InfProses.InsertData
        Throw New NotImplementedException()
    End Function
End Class