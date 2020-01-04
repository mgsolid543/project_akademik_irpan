Public Class FormUtama

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click

    End Sub

    Private Sub KeluarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem1.Click
        Dim login = New FormLogin
        login.MdiParent = Me
        login.Show()
    End Sub

    Private Sub RuanganToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RuanganToolStripMenuItem.Click
        Dim ruangan = New FormRuangan
        ruangan.MdiParent = Me
        ruangan.Show()
    End Sub

    Private Sub MahasiswaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MahasiswaToolStripMenuItem.Click
        Dim mahasiswa = New FormMahasiswa
        mahasiswa.MdiParent = Me
        mahasiswa.Show()
    End Sub

    Private Sub DosenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DosenToolStripMenuItem.Click
        Dim dosen = New FormDosen
        dosen.MdiParent = Me
        dosen.Show()
    End Sub

    Private Sub MataKuliahToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MataKuliahToolStripMenuItem.Click
        Dim matakuliah = New FormMataKuliah
        matakuliah.MdiParent = Me
        matakuliah.Show()
    End Sub

    Private Sub ProgramStudiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgramStudiToolStripMenuItem.Click
        Dim jurusan = New FormJurusan
        jurusan.MdiParent = Me
        jurusan.Show()
    End Sub

    Private Sub JadwalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JadwalToolStripMenuItem.Click
        Dim jadwal = New FormJadwal
        jadwal.MdiParent = Me
        jadwal.Show()
    End Sub
End Class
