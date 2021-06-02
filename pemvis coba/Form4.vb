Public Class Fmenu
    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Dim result = MessageBox.Show("Kok keluar bang !", "Peringatan ndak guna", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub DataJenisBukuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataJenisBukuToolStripMenuItem.Click
        Dim DataJenis = New DataJenis
        DataJenis.show()
        Me.Hide()
    End Sub

    Private Sub DataBukuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataBukuToolStripMenuItem.Click
        Dim DataBuku = New DataBuku
        DataBuku.Show()
        Me.Hide()
    End Sub

    Private Sub PemakaiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PemakaiToolStripMenuItem.Click
        Dim Pemakai = New Pemakai
        Pemakai.Show()
        Me.Hide()
    End Sub

    Private Sub TambahUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahUserToolStripMenuItem.Click
        Dim TambahUser = New TambahUser
        TambahUser.show()
        Me.Hide()
    End Sub
    Private Sub LaporanDataJenisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanDataJenisToolStripMenuItem.Click
        Form8.Show()
    End Sub

    Private Sub LaporanDataBukuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanDataBukuToolStripMenuItem.Click
        Form9.Show()
    End Sub

    Private Sub GantiUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GantiUserToolStripMenuItem.Click
        Login.Show()
        Me.Hide()
    End Sub
End Class