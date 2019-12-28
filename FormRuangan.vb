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

    Private Sub ButtonTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonTambah.Click
        Call tambah()
    End Sub

    Private Sub ButtonSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSimpan.Click
        Call bukaDB()
        CMD = New MySqlCommand("select koderuangan from ruangan where koderuangan = '" & TextBoxKodeRuangan.Text & "'", Koneksi)
        RD = CMD.ExecuteReader
        RD.Read()

        If ButtonTambah.Enabled = False Then
            If RD.HasRows Then
                MsgBox("Maaf, Data dengan Kode Ruangan tersebut telah ada", MsgBoxStyle.Exclamation, "Peringatan")
            Else
                If (MessageBox.Show("Simpan data ruangan baru?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) = DialogResult.Yes Then
                    Call bukaDB()
                    simpan = "insert into ruangan (koderuangan, namaruangan) values ('" & TextBoxKodeRuangan.Text & "', '" & TextBoxNamaRuangan.Text & "')"

                    CMD = New MySqlCommand(simpan, Koneksi)

                    CMD.ExecuteNonQuery()

                    Call isiGrid()
                    Call batal()
                    TextBoxKodeRuangan.Focus()

                    MsgBox("Data ruangan sudah tersimpan.", MsgBoxStyle.Information, "Info")
                    RD.Close()
                End If
            End If
        End If
    End Sub
End Class