Public Class FormDenda
    Dim modeProses As Integer
    Dim baris As Integer

    Private Sub AturButton(st As Boolean)
        btnUbah.Enabled = st
        btnHapus.Enabled = st
        btnSimpan.Enabled = Not st
        btnBatal.Enabled = Not st

        GroupBox1.Enabled = st
    End Sub

    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGDenda.Rows(br)
                txtIDDenda.Text = .Cells(0).Value.ToString
                txtTotalDenda.Text = .Cells(1).Value.ToString
                txtTotalBayar.Text = .Cells(2).Value.ToString
            End With
        End If
    End Sub

    Private Sub FormDenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
        txtIDDenda.Enabled = False
        txtTotalDenda.Enabled = False
        txtTotalBayar.Enabled = False
    End Sub

    Private Sub FormDenda_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Hide()
        FormDashboard.Show()
    End Sub

    Private Sub RefreshGrid()
        DTGrid = KontrolDenda.tampilData.ToTable
        DGDenda.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGDenda.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGDenda.CurrentCell = DGDenda.Item(1, baris)
            AturButton(True)
            IsiBox(baris)
        End If
    End Sub

    Private Sub TampilCari(kunci As String)
        DTGrid = KontrolDenda.cariData(kunci).ToTable

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGDenda.DataSource = DTGrid
            DGDenda.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGDenda.CurrentCell = DGDenda.Item(1, baris)
            IsiBox(baris)
        Else
            MsgBox("Data tidak ditemukan")
            RefreshGrid()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        AturButton(False)
        txtTotalDenda.Enabled = True
        txtTotalBayar.Enabled = True
        txtTotalDenda.Focus()
        modeProses = 2
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        RefreshGrid()
        AturButton(True)
        modeProses = 0
    End Sub

    Private Sub DGDenda_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGDenda.CellClick
        If modeProses = 0 Then
            baris = e.RowIndex
            DGDenda.Rows(baris).Selected = True
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
        With EntitasDenda
            .IdBayar = txtIDDenda.Text
            .Denda = txtTotalDenda.Text
            .TotalBayar = txtTotalBayar.Text
        End With

        If modeProses = 1 Then
            KontrolDenda.InsertData(EntitasDenda)
            MsgBox("Data berhasil ditambahkan")
        ElseIf modeProses = 2 Then
            KontrolDenda.updateData(EntitasDenda)
            MsgBox("Data berhasil diubah")
        End If
        MsgBox("Data telah disimpan", MsgBoxStyle.Information, "Info")
        RefreshGrid()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim status_referensi As Boolean
        status_referensi = KontrolDenda.CekDendaDireferensi(txtIDDenda.Text)
        If status_referensi Then
            MsgBox("Data masih digunakan, tidak boleh dihapus", MsgBoxStyle.Exclamation, "peringatan")
            Exit Sub
        End If

        If MsgBox("Apakah Anda yakin akan menghapus " & txtIDDenda.Text & "-" & txtTotalDenda.Text & "?",
                  MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            KontrolDenda.deleteData(txtIDDenda.Text)
        End If
        RefreshGrid()
    End Sub

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim totaldenda = CInt(txtTotalDenda.Text)
        Dim totalbayar = CInt(txtTotalBayar.Text)

        txtTotalBayar.Text = totaldenda + totalbayar
    End Sub
End Class