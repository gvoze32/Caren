Public Class FormCariSewa
    Dim baris As Integer
    Private Sub FormCariSewa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
    End Sub

    Private Sub FormMobil_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Hide()
        FormDashboard.Show()
    End Sub

    Private Sub RefreshGrid()
        DTGrid = KontrolCariSewa.tampilData.ToTable
        DGCariSewa.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGCariSewa.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGCariSewa.CurrentCell = DGCariSewa.Item(1, baris)
        End If
    End Sub

    Private Sub TampilCari(kunci As String)
        DTGrid = KontrolCariSewa.cariData(kunci).ToTable

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGCariSewa.DataSource = DTGrid
            DGCariSewa.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGCariSewa.CurrentCell = DGCariSewa.Item(1, baris)
        Else
            MsgBox("Data tidak ditemukan")
            RefreshGrid()
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
End Class