Public Class FormSopir
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
            With DGSopir.Rows(br)
                txtIDSopir.Text = .Cells(0).Value.ToString
                txtNamaSopir.Text = .Cells(1).Value.ToString
                txtNoHp.Text = .Cells(2).Value.ToString
            End With
        End If
    End Sub

    Private Sub FormSopir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
        txtIDSopir.Enabled = False
    End Sub

    Private Sub FormSopir_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Hide()
        FormDashboard.Show()
    End Sub

    Private Sub RefreshGrid()
        DTGrid = KontrolSopir.tampilData.ToTable
        DGSopir.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGSopir.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGSopir.CurrentCell = DGSopir.Item(1, baris)
            AturButton(True)
            IsiBox(baris)
        End If
    End Sub

    Private Sub TampilCari(kunci As String)
        DTGrid = KontrolSopir.cariData(kunci).ToTable

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGSopir.DataSource = DTGrid
            DGSopir.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGSopir.CurrentCell = DGSopir.Item(1, baris)
            IsiBox(baris)
        Else
            MsgBox("Data tidak ditemukan")
            RefreshGrid()
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        AturButton(False)
        modeProses = 1
        txtNamaSopir.Text = ""
        txtNoHp.Text = ""
        txtIDSopir.Text = KontrolSopir.kodebaru()
        txtNamaSopir.Focus()
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        AturButton(False)
        txtNamaSopir.Focus()
        modeProses = 2
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        RefreshGrid()
        AturButton(True)
        modeProses = 0
    End Sub

    Private Sub DGSopir_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGSopir.CellClick
        If modeProses = 0 Then
            baris = e.RowIndex
            DGSopir.Rows(baris).Selected = True
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
        With EntitasSopir
            .IdSupir = txtIDSopir.Text
            .NamaSupir = txtNamaSopir.Text
            .NoHp = txtNoHp.Text
        End With

        If modeProses = 1 Then
            KontrolSopir.InsertData(EntitasSopir)
            MsgBox("Data berhasil ditambahkan")
        ElseIf modeProses = 2 Then
            KontrolSopir.updateData(EntitasSopir)
            MsgBox("Data berhasil diubah")
        End If
        MsgBox("Data telah disimpan", MsgBoxStyle.Information, "Info")
        RefreshGrid()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim status_referensi As Boolean
        status_referensi = KontrolSopir.CekSopirDireferensi(txtIDSopir.Text)
        If status_referensi Then
            MsgBox("Data masih digunakan, tidak boleh dihapus", MsgBoxStyle.Exclamation, "peringatan")
            Exit Sub
        End If

        If MsgBox("Apakah Anda yakin akan menghapus " & txtIDSopir.Text & "-" & txtNamaSopir.Text & "?",
                  MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            KontrolSopir.deleteData(txtIDSopir.Text)
        End If
        RefreshGrid()
    End Sub
End Class