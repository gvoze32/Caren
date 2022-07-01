Public Class FormMobil
    Dim modeProses As Integer
    Dim baris As Integer

    Private Sub AturButton(st As Boolean)
        btnTambah.Enabled = st
        btnUbah.Enabled = st
        btnHapus.Enabled = st
        btnSimpan.Enabled = Not st
        btnBatal.Enabled = Not st

        GroupBox1.Enabled = st
    End Sub

    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGMobil.Rows(br)
                txtIDMobil.Text = .Cells(0).Value.ToString
                txtMerekMobil.Text = .Cells(1).Value.ToString
                txtTipeMobil.Text = .Cells(2).Value.ToString
                txtHargaSewa.Text = .Cells(3).Value.ToString
                txtIDAdmin.Text = .Cells(4).Value.ToString
            End With
        End If
    End Sub

    Private Sub FormMobil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
        txtIDMobil.Enabled = False
    End Sub

    Private Sub FormMobil_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Hide()
        FormDashboard.Show()
    End Sub

    Private Sub RefreshGrid()
        DTGrid = KontrolMobil.tampilData.ToTable
        DGMobil.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGMobil.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGMobil.CurrentCell = DGMobil.Item(1, baris)
            AturButton(True)
            IsiBox(baris)
        End If
    End Sub

    Private Sub TampilCari(kunci As String)
        DTGrid = KontrolMobil.cariData(kunci).ToTable

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGMobil.DataSource = DTGrid
            DGMobil.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGMobil.CurrentCell = DGMobil.Item(1, baris)
            IsiBox(baris)
        Else
            MsgBox("Data tidak ditemukan")
            RefreshGrid()
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        AturButton(False)
        modeProses = 1
        txtMerekMobil.Text = ""
        txtIDMobil.Text = KontrolMobil.kodebaru()
        txtMerekMobil.Focus()
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        AturButton(False)
        txtMerekMobil.Focus()
        modeProses = 2
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        RefreshGrid()
        AturButton(True)
        modeProses = 0
    End Sub

    Private Sub DGMobil_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGMobil.CellClick
        If modeProses = 0 Then
            baris = e.RowIndex
            DGMobil.Rows(baris).Selected = True
            IsiBox(baris)
        End If
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        If txtCari.Text = "" Then
            Call RefreshGrid()
        Else
            Call TampilCari(txtCari.Text)
            txtCari.Focus()
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        With EntitasMobil
            .IdMobil = txtIDMobil.Text
            .MerekMobil = txtMerekMobil.Text
            .TipeKendaraan = txtTipeMobil.Text
            .HargaSewa = txtHargaSewa.Text
            .IdAdmin = txtIDAdmin.Text
        End With

        If modeProses = 1 Then
            KontrolMobil.InsertData(EntitasMobil)
            MsgBox("Data berhasil ditambahkan")
        ElseIf modeProses = 2 Then
            KontrolMobil.updateData(EntitasMobil)
            MsgBox("Data berhasil diubah")
        End If
        MsgBox("Data telah disimpan", MsgBoxStyle.Information, "Info")
        RefreshGrid()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim status_referensi As Boolean
        status_referensi = KontrolMobil.CekMobilDireferensi(txtIDMobil.Text)
        If status_referensi Then
            MsgBox("Data masih digunakan, tidak boleh dihapus", MsgBoxStyle.Exclamation, "peringatan")
            Exit Sub
        End If

        If MsgBox("Apakah Anda yakin akan menghapus " & txtIDMobil.Text & "-" & txtMerekMobil.Text & "?",
                  MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            KontrolMobil.deleteData(txtIDMobil.Text)
        End If
        RefreshGrid()
    End Sub
End Class