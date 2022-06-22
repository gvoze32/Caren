Public Class FormLogin
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles txtLogin.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnMasuk_Click(sender As Object, e As EventArgs) Handles btnMasuk.Click
        FormDashboard.Show()

        Me.Hide()
    End Sub
End Class
