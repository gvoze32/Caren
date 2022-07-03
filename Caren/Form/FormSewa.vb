Imports System.Data.Odbc

Public Class FormSewa
    Dim modeProses As Integer
    Private Sub FormSewa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtIDSewa.Text = KontrolSewa.kodebarusewa()
        txtIDCost.Text = KontrolSewa.kodebarucostumer()
        txtIDBayar.Text = KontrolSewa.kodebarubayar()

        txtIDSewa.Visible = False
        txtIDCost.Visible = False
        txtIDSopir.Visible = False
        txtIDBayar.Visible = False
        txtMerekMobil.Visible = False
        txtHargaMobil.Visible = False
        'txtHargaMobil.Visible = False

        btnMasuk.Enabled = False

        TampilMobil()
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

        If cbSopir.Checked = True Then
            txtHarga.Text = (hargamobil + 100000) * totalselisih
        Else
            txtHarga.Text = hargamobil * totalselisih
        End If

        btnMasuk.Enabled = True
    End Sub

    Private Sub btnMasuk_Click(sender As Object, e As EventArgs) Handles btnMasuk.Click
        With EntitasSewa
            .id_sewa = txtIDSewa.Text
            .tgl_ambil = txtTglAmbil.Text
            .tgl_kembali = txtTglKembali.Text
            .id_cost = txtIDCost.Text
            .id_mobil = txtMerekMobil.Text
            .id_supir = txtIDSopir.Text

        End With

        If modeProses = 1 Then
            KontrolMobil.InsertData(EntitasMobil)
            MsgBox("Data berhasil ditambahkan")
        ElseIf modeProses = 2 Then
            KontrolMobil.updateData(EntitasMobil)
            MsgBox("Data berhasil diubah")
        End If
        MsgBox("Data telah disimpan", MsgBoxStyle.Information, "Info")
    End Sub
End Class