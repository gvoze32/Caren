Imports System.Data.Odbc

Public Class FormLogin
    Private Sub btnMasuk_Click(sender As Object, e As EventArgs) Handles btnMasuk.Click
        Dim session As String

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

        CMD = New OdbcCommand("Select * from admin where nama_admin='" & tbAdmin.Text & "'", BUKAKONEKSI)
        DTR = CMD.ExecuteReader
        DTR.Read()
        If DTR.HasRows Then
            session = DTR.Item("id_admin")
            With EntitasSewa
                .Session = session
            End With
        Else
            MsgBox("Nama admin tidak terdaftar")
        End If
    End Sub
End Class
