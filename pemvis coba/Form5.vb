Imports System.Data.OleDb
Public Class Pemakai
    Sub kosong()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
    End Sub
    Sub isi()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox2.Focus()
    End Sub
    Sub tampilpemakai()
        da = New OleDbDataAdapter("select * from Pemakai", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Pemakai")
        DataGridView1.DataSource = ds.Tables("Pemakai")
        DataGridView1.Refresh()
    End Sub
    Sub aturgrid()
        DataGridView1.Columns(0).Width = 200
        DataGridView1.Columns(1).Width = 200
        DataGridView1.Columns(2).Width = 200
        DataGridView1.Columns(3).Width = 200
        DataGridView1.Columns(0).HeaderText = "Kode Pemakai"
        DataGridView1.Columns(1).HeaderText = "Nama Pemakai"
        DataGridView1.Columns(2).HeaderText = "Status Pemakai"
        DataGridView1.Columns(3).HeaderText = "Password Pemakai"
    End Sub
    Private Sub DataJenis_load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call koneksi()
        Call tampilpemakai()
        Call kosong()
        Call aturgrid()
    End Sub
    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        cmd = New OleDbCommand("select * from Pemakai where KodePemakai like '%" & TextBox5.Text & "%'", conn)
        rd = cmd.ExecuteReader()
        rd.Read()
        If rd.HasRows Then
            da = New OleDbDataAdapter("select * from Pemakai where KodePemakai like '%" & TextBox5.Text & "%'", conn)
            ds = New DataSet
            da.Fill(ds, "Dapat")
            DataGridView1.DataSource = ds.Tables("Dapat")
            DataGridView1.ReadOnly = True
        Else
            MsgBox("Kosong bang datanya!")
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Fmenu.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        Dim result = MessageBox.Show("Kok keluar bang !", "Peringatan ndak guna", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call kosong()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MsgBox("Masukkan dulu datanya Bang!")
            TextBox1.Focus()
            Exit Sub
        Else
            cmd = New OleDbCommand("select KodePemakai From Pemakai Where KodePemakai ='" & TextBox1.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then

                Dim str As String
                str = "insert into Pemakai values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "' )"
                cmd = New OleDbCommand(str, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data sudah tersimpan dengan baik dan benar", MsgBoxStyle.Information, "Perhatian")
            End If
            Call tampilpemakai()
            Call kosong()
            TextBox1.Focus()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MsgBox("Masukkan dulu datanya bang!")
            TextBox1.Focus()
            Exit Sub
        Else
            Call koneksi()
            Dim str As String
            str = "update Pemakai set NamaPemakai='" & TextBox2.Text & "',KodePemakai='" & TextBox1.Text & "',StatusPemakai='" & TextBox3.Text & ",PasswordPemakai='" & TextBox4.Text & "' where KodePemakai='" & TextBox1.Text & "'"
            cmd = New OleDbCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Selamat data abang sudah berhasil diubah dengan baik dan benar")
            Call tampilpemakai()
            Call kosong()
            TextBox1.Focus()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Call koneksi()
        Dim str As String
        str = "select * from Pemakai where KodePemakai= '" & TextBox1.Text & "'"
        cmd = New OleDbCommand(str, conn)
        rd = cmd.ExecuteReader
        rd.Read()

        If rd.HasRows Then

            TextBox1.Text = rd.Item("KodePemakai")
            TextBox2.Text = rd.Item("NamaPemakai")
            TextBox3.Text = rd.Item("StatusPemakai")
            TextBox4.Text = rd.Item("PasswdPemakai")
            MessageBox.Show("Kode Jenis sudah pernah digunakan bang!")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Then
            MsgBox("Masukkan dulu data nya bang!")
            TextBox1.Focus()
            Exit Sub
        Else
            If MessageBox.Show("Kenapa dihapus bang Data Jenis " & TextBox1.Text & " ?", "", MessageBoxButtons.YesNoCancel) = Windows.Forms.DialogResult.Yes Then
                cmd = New OleDbCommand("delete * from Pemakai where KodePemakai='" & TextBox1.Text & "'", conn)
                cmd.ExecuteNonQuery()
                MsgBox("Sudah dihapus yah bang!")
                Call kosong()
                Call tampilpemakai()
            Else
                Call kosong()
            End If
        End If
    End Sub
End Class