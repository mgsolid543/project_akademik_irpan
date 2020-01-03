Imports MySql.Data.MySqlClient
Public Class FormMataKuliah
    Public strSQL As String
    Public DB As MySqlConnection
    Public CMD As MySqlCommand
    Public ADP As MySqlDataAdapter
    Public DR As MySqlDataReader
    Public DS As New DataSet

    Public simpan, hapus As String

    Sub tambah()
        DataGridView1.Enabled = False
        TextBoxKode.ReadOnly = False

        TextBoxKode.Clear()
        TextBoxNama.Clear()
        TextBoxSKS.Clear()

        TextBoxKode.Enabled = True
        TextBoxNama.Enabled = True
        TextBoxSKS.Enabled = True

        TextBoxKode.Focus()

        ButtonTambah.Enabled = False
        ButtonHapus.Enabled = False
        ButtonUbah.Enabled = True
        ButtonSimpan.Enabled = True
        ButtonBatal.Enabled = True
    End Sub

    Sub ubah()
        TextBoxKode.Enabled = True
        TextBoxNama.Enabled = True
        TextBoxSKS.Enabled = True
        TextBoxKode.Focus()

        ButtonTambah.Enabled = True
        ButtonHapus.Enabled = True
        ButtonUbah.Enabled = True
        ButtonSimpan.Enabled = False
        ButtonBatal.Enabled = True
    End Sub

    Sub batal()
        DataGridView1.Enabled = True
        TextBoxKode.Clear()
        TextBoxNama.Clear()
        TextBoxSKS.Clear()

        TextBoxKode.Enabled = True
        TextBoxNama.Enabled = True
        TextBoxSKS.Enabled = True
        TextBoxKode.Focus()

        ButtonTambah.Enabled = True
        ButtonHapus.Enabled = True
        ButtonUbah.Enabled = True
        ButtonSimpan.Enabled = False
        ButtonBatal.Enabled = True
    End Sub

    Sub bersih()
        TextBoxKode.Clear()
        TextBoxNama.Clear()
        TextBoxSKS.Clear()
        TextBoxKode.Focus()
    End Sub

    Sub isiGrid()
        ModuleKoneksi.bukaDB()
        DA = New MySqlDataAdapter("select * from matakuliah", Koneksi)

        ds = New DataSet
        DA.Fill(DS, "matakuliah")

        DataGridView1.DataSource = DS.Tables("matakuliah")
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub ButtonKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonKeluar.Click
        FormUtama.Show()
        Me.Hide()
    End Sub

    Private Sub FormMataKuliah_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call isiGrid()
        Call ubah()
    End Sub

    Private Sub ButtonTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonTambah.Click
        Call tambah()
    End Sub

    Private Sub ButtonBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBatal.Click
        Call batal()
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        TextBoxKode.ReadOnly = True
        bukaDB()
        CMD = New MySqlCommand("select * from matakuliah where kodemk = '" & TextBoxKode.Text & "'", Koneksi)

        Try
            Dim gridbaris As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            TextBoxKode.Text = gridbaris.Cells(0).Value.ToString
            TextBoxNama.Text = gridbaris.Cells(1).Value.ToString
            TextBoxSKS.Text = gridbaris.Cells(2).Value.ToString

        Catch ex As Exception
            MsgBox("Pilih data mata kuliah yang ada di dalam tabel", MsgBoxStyle.Information, "Info")
        End Try
    End Sub

    Private Sub ButtonUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonUbah.Click
        Call bukaDB()
        Try
            Using conn As New MySqlConnection(Koneksi.ConnectionString)
                conn.Open()
                Dim command As New MySqlCommand("update matakuliah set kodemk=@kodemk, namamk=@namamk, sks=@sks where kodemk=@kodemk", conn)

                With command.Parameters
                    .AddWithValue("@kodemk", TextBoxKode.Text)
                    .AddWithValue("@namamk", TextBoxNama.Text)
                    .AddWithValue("@sks", TextBoxSKS.Text)
                End With

                command.ExecuteNonQuery()
                MessageBox.Show("Data Mata Kuliah sukses tersimpan", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Kesalahan dalam ubah data", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Call isiGrid()
        Call bersih()
    End Sub

    Private Sub ButtonHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHapus.Click
        If TextBoxKode.Text = "" Then
            MessageBox.Show("Pilih dahulu data mata kuliah yang akan Anda hapus pada tabel di atas!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If TextBoxKode.Text <> "" Then
                If MessageBox.Show("Apakah Anda yakin akan mengahapus data mata kuliah ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Call bukaDB()
                    hapus = "delete from matakuliah where kodemk = '" & TextBoxKode.Text & "'"
                    CMD = New MySqlCommand(hapus, Koneksi)

                    CMD.ExecuteNonQuery()
                    Call isiGrid()
                    Call bersih()
                    TextBoxKode.Focus()
                    MessageBox.Show("Data mata kuliah berhasil dihapus", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub

    Private Sub ButtonSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSimpan.Click
        Call bukaDB()
        CMD = New MySqlCommand("select kodemk from matakuliah where kodemk = '" & TextBoxKode.Text & "'", Koneksi)
        RD = CMD.ExecuteReader
        RD.Read()

        If ButtonTambah.Enabled = False Then
            If RD.HasRows Then
                MsgBox("Maaf, Data dengan Kode Mata Kuliah tersebut telah ada", MsgBoxStyle.Exclamation, "Peringatan")
            Else
                If (MessageBox.Show("Simpan data mata kuliah baru?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) = DialogResult.Yes Then
                    Call bukaDB()
                    simpan = "insert into matakuliah (kodemk, namamk, sks) values ('" & TextBoxKode.Text & "', '" & TextBoxNama.Text & "', '" & TextBoxSKS.Text & "')"

                    CMD = New MySqlCommand(simpan, Koneksi)

                    CMD.ExecuteNonQuery()

                    Call isiGrid()
                    Call batal()
                    TextBoxKode.Focus()

                    MsgBox("Data Mata Kuliah sudah tersimpan.", MsgBoxStyle.Information, "Info")
                    RD.Close()
                End If
            End If
        End If
    End Sub
End Class