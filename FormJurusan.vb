Imports MySql.Data.MySqlClient

Public Class FormJurusan
    Public strSQL As String
    Public DB As MySqlConnection
    Public CMD As MySqlCommand
    Public ADP As MySqlDataAdapter
    Public DR As MySqlDataReader
    Public DS As New DataSet

    Public simpan, hapus As String

    Sub tambah()
        DataGridView1.Enabled = False
        TextBoxKodeJurusan.ReadOnly = False

        TextBoxKodeJurusan.Clear()
        TextBoxNamaJurusan.Clear()
        TextBoxKodeJurusan.Enabled = True
        TextBoxNamaJurusan.Enabled = True
        TextBoxKodeJurusan.Focus()

        ButtonTambah.Enabled = False
        ButtonHapus.Enabled = False
        ButtonUbah.Enabled = True
        ButtonSimpan.Enabled = True
        ButtonBatal.Enabled = True
    End Sub

    Sub ubah()
        TextBoxKodeJurusan.Enabled = True
        TextBoxNamaJurusan.Enabled = True
        TextBoxKodeJurusan.Focus()

        ButtonTambah.Enabled = True
        ButtonHapus.Enabled = True
        ButtonUbah.Enabled = True
        ButtonSimpan.Enabled = False
        ButtonBatal.Enabled = True
    End Sub

    Sub batal()
        DataGridView1.Enabled = True
        TextBoxKodeJurusan.Clear()
        TextBoxNamaJurusan.Clear()

        TextBoxKodeJurusan.Enabled = True
        TextBoxNamaJurusan.Enabled = True
        TextBoxKodeJurusan.Focus()

        ButtonTambah.Enabled = True
        ButtonHapus.Enabled = True
        ButtonUbah.Enabled = True
        ButtonSimpan.Enabled = False
        ButtonBatal.Enabled = True
    End Sub

    Sub bersih()
        TextBoxKodeJurusan.Clear()
        TextBoxNamaJurusan.Clear()
        TextBoxKodeJurusan.Focus()
    End Sub

    Sub isiGrid()
        ModuleKoneksi.bukaDB()
        DA = New MySqlDataAdapter("select * from jurusan", Koneksi)

        ds = New DataSet
        DA.Fill(DS, "jurusan")

        DataGridView1.DataSource = DS.Tables("jurusan")
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub ButtonKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonKeluar.Click
        FormUtama.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonTambah.Click
        Call tambah()
    End Sub

    Private Sub ButtonBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBatal.Click
        Call batal()
    End Sub

    Private Sub FormJurusan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call isiGrid()
        ubah()
    End Sub

    Private Sub ButtonSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSimpan.Click
        Call bukaDB()
        CMD = New MySqlCommand("select kodejurusan from jurusan where kodejurusan = '" & TextBoxKodeJurusan.Text & "'", Koneksi)
        RD = CMD.ExecuteReader
        RD.Read()

        If ButtonTambah.Enabled = False Then
            If RD.HasRows Then
                MsgBox("Maaf, Data dengan Kode Jurusan tersebut telah ada", MsgBoxStyle.Exclamation, "Peringatan")
            Else
                If (MessageBox.Show("Simpan data Jurusan baru?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) = DialogResult.Yes Then
                    Call bukaDB()
                    simpan = "insert into jurusan (kodejurusan, namajurusan) values ('" & TextBoxKodeJurusan.Text & "', '" & TextBoxNamaJurusan.Text & "')"

                    CMD = New MySqlCommand(simpan, Koneksi)

                    CMD.ExecuteNonQuery()

                    Call isiGrid()
                    Call batal()
                    TextBoxKodeJurusan.Focus()

                    MsgBox("Data Jurusan sudah tersimpan.", MsgBoxStyle.Information, "Info")
                    RD.Close()
                End If
            End If
        End If
    End Sub

    Private Sub ButtonUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonUbah.Click
        Call bukaDB()
        Try
            Using conn As New MySqlConnection(Koneksi.ConnectionString)
                conn.Open()
                Dim command As New MySqlCommand("update jurusan set kodejurusan=@kodejurusan, namaruangan=@namajurusan where kodejurusan=@kodejurusan", conn)

                With command.Parameters
                    .AddWithValue("@kodejurusan", TextBoxKodeJurusan.Text)
                    .AddWithValue("@namajurusan", TextBoxNamaJurusan.Text)
                End With

                command.ExecuteNonQuery()
                MessageBox.Show("Data jurusan sukses tersimpan", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Kesalahan dalam ubah data", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Call isiGrid()
        Call bersih()
    End Sub

    Private Sub ButtonHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHapus.Click
        If TextBoxKodeJurusan.Text = "" Then
            MessageBox.Show("Pilih dahulu data jurusan yang akan Anda hapus pada tabel di atas!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If TextBoxKodeJurusan.Text <> "" Then
                If MessageBox.Show("Apakah Anda yakin akan mengahapus data jurusan ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Call bukaDB()
                    hapus = "delete from jurusan where kodejurusan = '" & TextBoxKodeJurusan.Text & "'"
                    CMD = New MySqlCommand(hapus, Koneksi)

                    CMD.ExecuteNonQuery()
                    Call isiGrid()
                    Call bersih()
                    TextBoxKodeJurusan.Focus()
                    MessageBox.Show("Data jurusan berhasil dihapus", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        TextBoxKodeJurusan.ReadOnly = True
        bukaDB()
        CMD = New MySqlCommand("select * from jurusan where kodejurusan = '" & TextBoxKodeJurusan.Text & "'", Koneksi)

        Try
            Dim gridbaris As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            TextBoxKodeJurusan.Text = gridbaris.Cells(0).Value.ToString
            TextBoxNamaJurusan.Text = gridbaris.Cells(1).Value.ToString
        Catch ex As Exception
            MsgBox("Pilih data jurusan yang ada di dalam tabel", MsgBoxStyle.Information, "Info")
        End Try
    End Sub
End Class