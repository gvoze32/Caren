Public Class FormDashboard
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnSewa.Click
        FormSewa.Show()

        Me.Hide()
    End Sub

    Private Sub btnMobil_Click(sender As Object, e As EventArgs) Handles btnMobil.Click
        FormMobil.Show()

        Me.Hide()
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        FormCariSewa.Show()

        Me.Hide()
    End Sub

    Private Sub btnSopir_Click(sender As Object, e As EventArgs) Handles btnSopir.Click
        FormSopir.Show()

        Me.Hide()
    End Sub

    Private Sub btnDenda_Click(sender As Object, e As EventArgs) Handles btnDenda.Click
        FormDenda.Show()

        Me.Hide()
    End Sub
End Class