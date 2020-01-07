Imports MySql.Data.MySqlClient

Public Class FormKHS
    Public strSQL As String
    Public db As MySqlConnection
    Public cmd As MySqlCommand
    Public dadapter As MySqlDataAdapter
    Public datardr As MySqlDataReader
    Public ds As DataSet
    Dim conn As AksesData.KoneksiDB

    Public display, simpan, ubah, hapus As String

    Private Sub FormJadwal_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        FormUtama.Enabled = True
    End Sub

    Private Sub tambah()
        DataGridView1.Enabled = False
        TextBoxKode.ReadOnly = False

        TextBoxKode.Clear()

        TextBoxMataKuliah.Clear()
        TextBoxMahasiswa.Clear()

        TextBoxNilai.Clear()

        TextBoxKode.Enabled = True

        TextBoxMataKuliah.Enabled = True
        ComboBoxMataKuliah.Enabled = True

        TextBoxMahasiswa.Enabled = True
        ComboBoxMahasiswa.Enabled = True

        TextBoxKode.Focus()

        ButtonTambah.Enabled = False
        ButtonHapus.Enabled = False
        ButtonUbah.Enabled = True
        ButtonSimpan.Enabled = True
        ButtonBatal.Enabled = True
    End Sub

    Private Sub comboMataKuliah()
        Call bukaDB()
        cmd = New MySqlCommand("select * from matakuliah", Koneksi)
        datardr = cmd.ExecuteReader
        ComboBoxMataKuliah.Items.Clear()
        Do While datardr.Read
            ComboBoxMataKuliah.Items.Add(datardr("kodemk"))
        Loop
        datardr.Close()
    End Sub

    Private Sub comboMahasiswa()
        Call bukaDB()
        cmd = New MySqlCommand("select * from mahasiswa", Koneksi)
        datardr = cmd.ExecuteReader
        ComboBoxMahasiswa.Items.Clear()
        Do While datardr.Read
            ComboBoxMahasiswa.Items.Add(datardr("nim"))
        Loop
        datardr.Close()
    End Sub

    Private Sub bersih()
        TextBoxKode.Text = ""
        ComboBoxMataKuliah.Text = ""
        TextBoxMataKuliah.Text = ""
        ComboBoxMahasiswa.Text = ""
        TextBoxMahasiswa.Text = ""
        TextBoxNilai.Text = ""
        TextBoxKode.Focus()
    End Sub

    Private Sub displayData()
        ModuleKoneksi.bukaDB()
        display = "select * from khs"
        DA = New MySqlDataAdapter(display, Koneksi)
        ds = New DataSet
        DA.Fill(ds, "khs")
        DataGridView1.Refresh()
        DataGridView1.DataSource = ds.Tables("khs")
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub ButtonKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonKeluar.Click
        FormUtama.Show()
        Me.Hide()
    End Sub

    Private Sub FormJadwal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bukaDB()
        bersih()
        comboMataKuliah()
        comboMahasiswa()
        DataGridView1.Refresh()
        displayData()
        ButtonSimpan.Enabled = False
    End Sub

    Private Sub ComboBoxMataKuliah_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxMataKuliah.LostFocus
        Try
            Call bukaDB()
            cmd = New MySqlCommand("select * from matakuliah where kodemk = '" & ComboBoxMataKuliah.Text & "'", Koneksi)

            datardr = cmd.ExecuteReader
            If datardr.HasRows Then
                datardr.Read()
                TextBoxMataKuliah.Text = datardr("namamk")
                ComboBoxMataKuliah.Focus()
            Else
                ComboBoxMataKuliah.Text = ""
            End If
            datardr.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ComboBoxMataKuliah_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxMataKuliah.SelectedIndexChanged
        Try
            Call bukaDB()
            cmd = New MySqlCommand("select * from matakuliah where kodemk = '" & ComboBoxMataKuliah.Text & "'", Koneksi)

            datardr = cmd.ExecuteReader
            If datardr.HasRows Then
                datardr.Read()
                TextBoxMataKuliah.Text = datardr("namamk")
                ComboBoxMataKuliah.Focus()
            Else
                ComboBoxMataKuliah.Text = ""
            End If
            datardr.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ComboBoxMahasiswa_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxMahasiswa.LostFocus
        Try
            Call bukaDB()
            cmd = New MySqlCommand("select * from mahasiswa where nim = '" & ComboBoxMahasiswa.Text & "'", Koneksi)

            datardr = cmd.ExecuteReader
            If datardr.HasRows Then
                datardr.Read()
                TextBoxMahasiswa.Text = datardr("nama")
                ComboBoxMahasiswa.Focus()
            Else
                ComboBoxMahasiswa.Text = ""
            End If
            datardr.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ComboBoxMahasiswa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxMahasiswa.SelectedIndexChanged
        Try
            Call bukaDB()
            cmd = New MySqlCommand("select * from mahasiswa where nim = '" & ComboBoxMahasiswa.Text & "'", Koneksi)

            datardr = cmd.ExecuteReader
            If datardr.HasRows Then
                datardr.Read()
                TextBoxMahasiswa.Text = datardr("nama")
                ComboBoxMahasiswa.Focus()
            Else
                ComboBoxMahasiswa.Text = ""
            End If
            datardr.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ButtonBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBatal.Click
        bersih()
    End Sub

    Private Sub ButtonTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonTambah.Click
        tambah()
    End Sub

    Private Sub ButtonSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSimpan.Click
        Call bukaDB()
        cmd = New MySqlCommand("select * from khs where kodekhs = '" & TextBoxKode.Text & "'", Koneksi)
        RD = cmd.ExecuteReader
        RD.Read()

        If ButtonSimpan.Enabled = True Then
            If RD.HasRows Then
                MsgBox("Maaf, Data KHS dengan Kode KHS tersebut telah ada", MsgBoxStyle.Exclamation, "Peringatan")
                Call bukaDB()
                Call displayData()
            Else
                If MessageBox.Show("Simpan data KHS Baru?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Call bukaDB()
                    simpan = "insert into khs(kodekhs, mahasiswa, matakuliah, nilai) values ('" &
                                TextBoxKode.Text & "','" &
                                ComboBoxMahasiswa.Text & "','" &
                                ComboBoxMataKuliah.Text & "','" &
                                TextBoxNilai.Text & "')"

                    cmd = New MySqlCommand(simpan, Koneksi)
                    cmd.ExecuteNonQuery()
                    Call displayData()
                    TextBoxKode.Focus()
                    MsgBox("Data KHS sudah tersimpan", MsgBoxStyle.Information, "Info")
                    RD.Close()
                End If
                Call displayData()
                Call bersih()
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        TextBoxKode.ReadOnly = True
        bukaDB()
        cmd = New MySqlCommand("select * from khs where kodekhs = '" & TextBoxKode.Text & "'", Koneksi)

        Try
            Dim gridbaris As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            TextBoxKode.Text = gridbaris.Cells(0).Value.ToString
            ComboBoxMahasiswa.Text = gridbaris.Cells(1).Value.ToString
            ComboBoxMataKuliah.Text = gridbaris.Cells(2).Value.ToString
            TextBoxNilai.Text = gridbaris.Cells(3).Value.ToString
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Error")
            'MsgBox("Pilih data KHS yang ada di dalam tabel", MsgBoxStyle.Information, "Info")
        End Try
    End Sub

    Private Sub ButtonUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonUbah.Click
        Call bukaDB()
        Try
            Using conn As New MySqlConnection(Koneksi.ConnectionString)
                conn.Open()

                ubah = "update khs set kodekhs = '" & TextBoxKode.Text & "'," &
                                "matakuliah = '" & ComboBoxMataKuliah.Text & "'," &
                                "mahasiswa = '" & ComboBoxMahasiswa.Text & "'," &
                                "nilai = '" & TextBoxNilai.Text & "'" &
                                "where kodekhs = '" & TextBoxKode.Text & "'"

                Dim command As New MySqlCommand(ubah, conn)
                command.ExecuteNonQuery()
                MessageBox.Show("Data KHS sukses tersimpan", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Kesalahan dalam ubah data", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Call displayData()
        Call bersih()
    End Sub

    Private Sub ButtonHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHapus.Click
        If TextBoxKode.Text = "" Then
            MessageBox.Show("Pilih dahulu data KHS yang akan Anda hapus pada tabel di atas!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If TextBoxKode.Text <> "" Then
                If MessageBox.Show("Apakah Anda yakin akan menghapus data KHS ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Call bukaDB()
                    hapus = "delete from khs where kodekhs = '" & TextBoxKode.Text & "'"
                    cmd = New MySqlCommand(hapus, Koneksi)

                    cmd.ExecuteNonQuery()
                    Call displayData()
                    Call bersih()
                    TextBoxKode.Focus()
                    MessageBox.Show("Data KHS berhasil dihapus", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub
End Class