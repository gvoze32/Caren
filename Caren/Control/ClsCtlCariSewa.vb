Imports System.Data.Odbc
Public Class ClsCtlCariSewa : Implements InfProses
    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OdbcDataAdapter("select * from sewa", BUKAKONEKSI)
            DTA.Fill(DTS, "Tabel_Sewa")
            Dim grid As New DataView(DTS.Tables("Tabel_Sewa"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Try
            DTA = New OdbcDataAdapter("select * from sewa where id_sewa " & " like '%" & kunci & "%'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Cari_sewa")
            Dim grid As New DataView(DTS.Tables("Cari_sewa"))
            Return grid
        Catch ex As Exception
            Throw New ArgumentException(ex.Message)
        End Try
    End Function

    Public Function InsertData(Ob As Object) As OdbcCommand Implements InfProses.InsertData
        Throw New NotImplementedException()
    End Function

    Public Function updateData(Ob As Object) As OdbcCommand Implements InfProses.updateData
        Throw New NotImplementedException()
    End Function

    Public Function deleteData(kunci As String) As OdbcCommand Implements InfProses.deleteData
        Throw New NotImplementedException()
    End Function
End Class
