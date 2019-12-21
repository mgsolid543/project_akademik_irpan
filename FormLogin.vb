﻿Imports MySql.Data.MySqlClient

Public Class FormLogin

    Private Sub ButtonKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonKeluar.Click
        End
    End Sub

    Private Sub ButtonBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBatal.Click
        TextBoxUsername.Text = ""
        TextBoxPassword.Text = ""
        ButtonMasuk.Enabled = True
        TextBoxUsername.Focus()
    End Sub

    Private Sub FormLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ButtonBatal_Click(sender, e)
    End Sub

    Private Sub ButtonMasuk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMasuk.Click
        Try
            Dim strSQL As String = "select * from login where username = @t_us and password = @t_ps"
            Dim mycommand As New MySqlCommand(strSQL, Koneksi)

            mycommand.Parameters.Add("t_us", MySqlDbType.Text).Value = TextBoxUsername.Text
            mycommand.Parameters.Add("t_ps", MySqlDbType.Text).Value = TextBoxPassword.Text

            Dim rdr As MySqlDataReader = mycommand.ExecuteReader

            If rdr.Read = False Then
                MsgBox("Data tidak ada!!!", vbYes, "Login")
                TextBoxUsername.Text = ""
                TextBoxPassword.Text = ""
                TextBoxUsername.Focus()
            Else
                FormUtama.Show()
                Me.Hide()
            End If
            rdr.Close()
        Catch sqlEx As MySqlException
            Throw New Exception(sqlEx.Message.ToString())
        End Try
    End Sub
End Class