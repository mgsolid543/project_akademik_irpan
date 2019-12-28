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
End Class
