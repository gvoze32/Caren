Imports System.Data.Odbc

Public Class FormLogin
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles txtLogin.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnMasuk_Click(sender As Object, e As EventArgs) Handles btnMasuk.Click
        If tbAdmin.Text = "" Or tbPassword.Text = "" Then
            MsgBox("data login belum lengkap")
        Else
            CMD = New OdbcCommand("SELECT * FROM admin WHERE nama_admin='" + tbAdmin.Text + "' AND password='" + tbPassword.Text + "'", BUKAKONEKSI)
            DTR = CMD.ExecuteReader
            DTR.Read()
            If DTR.HasRows Then
                MsgBox("Login berhasil, selamat datang " & tbAdmin.Text & "!",
                   MsgBoxStyle.Information, "Successfull Login")
                FormDashboard.Show()
                Me.Hide()
            Else
                MsgBox("Login gagal ",
                   MsgBoxStyle.Exclamation, "Error Login")
            End If
        End If
    End Sub
End Class
