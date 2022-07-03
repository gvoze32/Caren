Imports System.Data.Odbc

Public Class FormSewa
    Dim modeProses As Integer
    Private Sub FormSewa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Memberi custom date and time
        txtTglAmbil.CustomFormat = "yyyy-MM-dd"
        txtTglKembali.CustomFormat = "yyyy-MM-dd"

        'Memanggil fungsi kodebaru
        txtIDSewa.Text = KontrolSewa.kodebarusewa()
        txtIDCost.Text = KontrolSewa.kodebarucostumer()
        txtIDBayar.Text = KontrolSewa.kodebarubayar()

        'Menghilangkan textbox
        txtIDSewa.Visible = False
        txtIDCost.Visible = False
        txtIDBayar.Visible = False
        txtIDSupir.Visible = False
        txtMerekMobil.Visible = False
        txtHargaMobil.Visible = False

        'Mematikan tombol
        btnMasuk.Enabled = False

        'Memanggil isi database ke combobox
        TampilMobil()

        'Acak Supir
        CMD = New OdbcCommand("select * from supir order by RAND()", BUKAKONEKSI)
        DTR = CMD.ExecuteReader
        If DTR.Read Then
            txtIDSupir.Text = DTR.Item(0).ToString
        End If
        BUKAKONEKSI.Close()
    End Sub

    Private Sub FormSewa_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Hide()
        FormDashboard.Show()
    End Sub

    Sub TampilMobil()
        CMD = New OdbcCommand("Select merek_mobil from mobil", BUKAKONEKSI)
        DTR = CMD.ExecuteReader
        cmbIDMobil.Items.Clear()
        Do While DTR.Read
            cmbIDMobil.Items.Add(DTR.Item("merek_mobil"))
        Loop
        BUKAKONEKSI.Close()
    End Sub

    Private Sub cmbIDMobil_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbIDMobil.SelectedIndexChanged
        CMD = New OdbcCommand("Select * from mobil where merek_mobil='" & cmbIDMobil.Text & "'", BUKAKONEKSI)
        DTR = CMD.ExecuteReader
        DTR.Read()
        If DTR.HasRows Then
            txtMerekMobil.Text = DTR.Item("id_mobil")
            txtHargaMobil.Text = DTR.Item("harga_sewa")
        Else
            MsgBox("Nama mobil tidak terdaftar")
        End If
    End Sub

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim hargamobil = CInt(txtHargaMobil.Text)
        Dim selisih As Integer
        Dim totalselisih As Integer
        selisih = DateDiff(DateInterval.Day, txtTglAmbil.Value, txtTglKembali.Value)
        totalselisih = selisih + 1

        If cbSupir.Checked = True Then
            txtHarga.Text = (hargamobil + 100000) * totalselisih
        Else
            txtHarga.Text = hargamobil * totalselisih
        End If

        btnMasuk.Enabled = True
    End Sub

    Private Sub btnMasuk_Click(sender As Object, e As EventArgs) Handles btnMasuk.Click
        With EntitasSewa
            .IDSewa = txtIDSewa.Text
            .IDCost = txtIDCost.Text
            .IDMobil = txtMerekMobil.Text
            .IDSupir = txtIDSupir.Text
            .IDBayar = txtIDBayar.Text
            .Nama = txtNama.Text
            .NIK = txtNIK.Text
            .NOHP = txtHP.Text
            .TglAmbil = txtTglAmbil.Value
            .TglKembali = txtTglKembali.Value
            .TotalBayar = txtHarga.Text
        End With

        KontrolSewa.InsertData(EntitasSewa)
        MsgBox("Data berhasil ditambahkan")
        MsgBox("Data telah disimpan", MsgBoxStyle.Information, "Info")
    End Sub
End Class