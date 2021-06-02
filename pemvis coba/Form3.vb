Imports System.Data.OleDb
Public Class Login
    Private Sub chkShow_CheckedChanged(sender As Object, e As EventArgs) Handles chkShow.CheckedChanged
        If chkShow.Checked Then
            TextBox2.PasswordChar = ""
        Else
            TextBox2.PasswordChar = "*"
        End If

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call koneksi()
        cmd = New OleDbCommand("select * from Login where userID='" & TextBox1.Text & "'AND Password='" & TextBox2.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            Me.Visible = False
            Fmenu.Show()
            Fmenu.ToolStripStatusLabel1.Text = rd.GetString(0)
            Fmenu.ToolStripStatusLabel2.Text = rd.GetString(1)
            Fmenu.ToolStripStatusLabel3.Text = rd.GetString(2)
            If Fmenu.ToolStripStatusLabel3.Text <> "User" Then
                Fmenu.LaporanToolStripMenuItem.Enabled = True
                Fmenu.GantiUserToolStripMenuItem.Enabled = True
            Else
                Fmenu.LaporanToolStripMenuItem.Enabled = False
                Fmenu.TambahUserToolStripMenuItem.Enabled = False
            End If
        Else
            MsgBox("User Tidak Ditemukan, Harap di masukkan lagi !!!")
            TextBox1.Focus()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim result = MessageBox.Show("Kok keluar bang !", "Peringatan ndak guna", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
    Private Sub usrname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then TextBox2.Focus()

    End Sub

    Private Sub passwd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = Chr(13) Then Button1.PerformClick()
    End Sub
End Class