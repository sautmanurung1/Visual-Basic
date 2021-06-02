Imports System.Data.OleDb
Public Class TambahUser
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Fmenu.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call koneksi()
        str = "select * from Login where UserID='" & TextBox2.Text & "'"
        cmd = New OleDbCommand(str, conn)
        rd = cmd.ExecuteReader
        rd.Read()

        If rd.HasRows Then
            TextBox1.Text = rd.Item("Password")
            ComboBox1.Text = rd.Item("Hak")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim str As String
        Dim pilih As MsgBoxResult
        pilih = MessageBox.Show("Apakah anda ingin mengedit user ini?", "Perhatian!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If pilih = MsgBoxResult.Yes Then
            If rd.HasRows Then
                Call koneksi()
                str = "update Login set [password] = '" & TextBox1.Text & "', hak = '" & ComboBox1.Text & "' where UserID = '" & TextBox2.Text & "'"
                cmd = New OleDbCommand(str, conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("User Berhasil Diedit!")
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim notif As MsgBoxResult
        Call koneksi()
        str = "select * from Login where userID='" & TextBox2.Text & "'AND Password='" & TextBox1.Text & "'"
        cmd = New OleDbCommand(str, conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            MessageBox.Show("User sudah ada!")
        ElseIf (Len(TextBox1.Text) > 0 And Not rd.HasRows) Then
            str = "insert into Login values ('" & TextBox2.Text & "', '" & TextBox1.Text & "', '" & ComboBox1.Text & "')"
            cmd = New OleDbCommand(str, conn)
            cmd.ExecuteNonQuery()
            notif = MessageBox.Show("User Berhasil Ditambahkan!", "Berhasil!")
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox1.Text = "" Then
            MsgBox("Masukkan dulu data nya bang!")
            TextBox1.Focus()
            Exit Sub
        Else
            If MessageBox.Show("Kenapa dihapus bang " & TextBox2.Text & " ?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                cmd = New OleDbCommand("delete * from Login where Password ='" & TextBox2.Text & "'", conn)
                cmd.ExecuteNonQuery()
                MsgBox("Sudah dihapus yah bang!")
            End If
        End If
    End Sub
End Class