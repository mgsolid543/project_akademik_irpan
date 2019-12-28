Imports MySql.Data.MySqlClient



Public Class FormRuangan

    Sub bersih()
        TextBoxKodeRuangan.Clear()
        TextBoxNamaRuangan.Clear()
        TextBoxKodeRuangan.Focus()
    End Sub

    Sub isiGrid()
        ModuleKoneksi.bukaDB()
        DA = New MySqlDataAdapter("select * from ruangan", Koneksi)

        ds = New DataSet
        DA.Fill(ds, "ruangan")

        DataGridView1.DataSource = ds.Tables("ruangan")
        DataGridView1.ReadOnly = True
    End Sub


    Private Sub ButtonKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonKeluar.Click
        FormUtama.Show()
        Me.Hide()
    End Sub

    Private Sub FormRuangan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call isiGrid()
    End Sub
End Class