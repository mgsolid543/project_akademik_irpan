Imports MySql.Data.MySqlClient



Public Class FormRuangan

    Public strSQL As String
    Public DB As MySqlConnection
    Public CMD As MySqlCommand
    Public ADP As MySqlDataAdapter
    Public DR As MySqlDataReader
    Public DS As New DataSet

    Public simpan, hapus As String

    Sub tambah()
        DataGridView1.Enabled = False
        TextBoxKodeRuangan.Clear()
        TextBoxNamaRuangan.Clear()
        TextBoxKodeRuangan.Enabled = True
        TextBoxNamaRuangan.Enabled = True
        TextBoxKodeRuangan.Focus()

        ButtonTambah.Enabled = False
        ButtonHapus.Enabled = False
        ButtonUbah.Enabled = True
        ButtonSimpan.Enabled = True
        ButtonBatal.Enabled = True
    End Sub

    Sub ubah()
        TextBoxKodeRuangan.Enabled = True
        TextBoxNamaRuangan.Enabled = True
        TextBoxKodeRuangan.Focus()

        ButtonTambah.Enabled = True
        ButtonHapus.Enabled = True
        ButtonUbah.Enabled = True
        ButtonSimpan.Enabled = False
        ButtonBatal.Enabled = True
    End Sub

    Sub batal()
        DataGridView1.Enabled = True
        TextBoxKodeRuangan.Clear()
        TextBoxNamaRuangan.Clear()

        TextBoxKodeRuangan.Enabled = True
        TextBoxNamaRuangan.Enabled = True
        TextBoxKodeRuangan.Focus()

        ButtonTambah.Enabled = True
        ButtonHapus.Enabled = True
        ButtonUbah.Enabled = True
        ButtonSimpan.Enabled = False
        ButtonBatal.Enabled = True
    End Sub

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
        ubah()
    End Sub
End Class