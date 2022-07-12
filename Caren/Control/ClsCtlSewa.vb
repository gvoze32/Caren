Imports System.Data.Odbc
Public Class ClsCtlSewa : Implements InfProses
    Public Function InsertData(Ob As Object) As OdbcCommand Implements InfProses.InsertData
        Dim data As New ClsEntSewa
        data = Ob
        CMD = New OdbcCommand("insert into sewa values('" & data.IDSewa & "','" & Format(data.TglAmbil, "yyyy/MM/dd") & "','" & Format(data.TglKembali, "yyyy/MM/dd") & "','" & data.IDCost & "','" & data.IDMobil & "','" & data.IDSupir & "')", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OdbcCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function InsertDataNonSupir(Ob As Object) As OdbcCommand
        Dim data As New ClsEntSewa
        data = Ob
        CMD = New OdbcCommand("insert into sewa (id_sewa, tgl_ambil, tgl_kembali, id_cost, id_mobil) values ('" & data.IDSewa & "','" & Format(data.TglAmbil, "yyyy/MM/dd") & "','" & Format(data.TglKembali, "yyyy/MM/dd") & "','" & data.IDCost & "','" & data.IDMobil & "')", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OdbcCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function InsertDataCost(Ob As Object) As OdbcCommand
        Dim data As New ClsEntSewa
        data = Ob
        CMD = New OdbcCommand("insert into costumer values('" & data.IDCost & "','" & data.Nama & "','" & data.NIK & "','" & data.NOHP & "','" & data.Session & "')", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OdbcCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function InsertDataBayar(Ob As Object) As OdbcCommand
        Dim data As New ClsEntSewa
        data = Ob
        CMD = New OdbcCommand("insert into bayar(id_bayar, total_bayar, id_sewa) values ('" & data.IDBayar & "','" & data.TotalBayar & "','" & data.IDSewa & "')", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OdbcCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Function kodebarusewa() As String
        Dim baru As String
        Dim kodeakhir As Integer
        Try
            DTA = New OdbcDataAdapter("select max(right(id_sewa,3)) from sewa", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "S" & Strings.Right("00" & kodeakhir + 1, 3)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Function kodebarucostumer() As String
        Dim baru As String
        Dim kodeakhir As Integer
        Try
            DTA = New OdbcDataAdapter("select max(right(id_cost,3)) from costumer", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "C" & Strings.Right("00" & kodeakhir + 1, 3)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Function kodebarubayar() As String
        Dim baru As String
        Dim kodeakhir As Integer
        Try
            DTA = New OdbcDataAdapter("select max(right(id_bayar,3)) from bayar", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "B" & Strings.Right("00" & kodeakhir + 1, 3)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function updateData(Ob As Object) As OdbcCommand Implements InfProses.updateData
        Throw New NotImplementedException()
    End Function

    Public Function deleteData(kunci As String) As OdbcCommand Implements InfProses.deleteData
        Throw New NotImplementedException()
    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Throw New NotImplementedException()
    End Function

    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Throw New NotImplementedException()
    End Function
End Class