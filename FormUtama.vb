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

    Private Sub SemuaMahasiswaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SemuaMahasiswaToolStripMenuItem.Click
        Dim reportSemuaMahasiswa = New FormReportSemuaMahasiswa
        reportSemuaMahasiswa.MdiParent = Me
        reportSemuaMahasiswa.Show()
    End Sub

    Private Sub MahasiswaNIMTertentuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MahasiswaNIMTertentuToolStripMenuItem.Click
        Dim reportMahasiswaNIM = New FormReportNIMMahasiswa
        reportMahasiswaNIM.MdiParent = Me
        reportMahasiswaNIM.Show()
    End Sub

    Private Sub DosenNIPTertentuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DosenNIPTertentuToolStripMenuItem.Click
        Dim reportDosenNIP = New FormReportDosenNIPTertentu
        reportDosenNIP.MdiParent = Me
        reportDosenNIP.Show()
    End Sub

    Private Sub KRSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KRSToolStripMenuItem.Click
        Dim krs = New FormKRS
        krs.MdiParent = Me
        krs.Show()
    End Sub

    Private Sub KHSNilaiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KHSNilaiToolStripMenuItem.Click
        Dim khs = New FormKHS
        khs.MdiParent = Me
        khs.Show()
    End Sub
End Class
