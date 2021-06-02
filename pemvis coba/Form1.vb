Imports System.Data.OleDb
Public Class DataJenis
    Sub kosong()
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub
    Sub isi()
        TextBox2.Clear()
        TextBox2.Focus()
    End Sub
    Sub tampiljenis()
        da = New OleDbDataAdapter("select * from Jenis", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Jenis")
        DataGridView1.DataSource = ds.Tables("Jenis")
        DataGridView1.Refresh()
    End Sub
    Sub aturgrid()
        DataGridView1.Columns(0).Width = 200
        DataGridView1.Columns(1).Width = 200
        DataGridView1.Columns(0).HeaderText = "KodeJenis"
        DataGridView1.Columns(1).HeaderText = "Jenis"
    End Sub
    Private Sub DataJenis_load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call koneksi()
        Call tampiljenis()
        Call kosong()
        Call aturgrid()
    End Sub
    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Masukkan dulu datanya Bang!")
            TextBox1.Focus()
            Exit Sub
        Else
            cmd = New OleDbCommand("select Kodejenis From Jenis Where Kodejenis ='" & TextBox1.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then

                Dim str As String
                str = "insert into Jenis values ('" & TextBox1.Text & "','" & TextBox2.Text & "' )"
                cmd = New OleDbCommand(str, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data sudah tersimpan dengan baik dan benar", MsgBoxStyle.Information, "Perhatian")
            End If
            Call tampiljenis()
            Call kosong()
            TextBox1.Focus()
        End If
    End Sub
    Private Sub TextBox2_Keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        TextBox2.MaxLength = 50
        If e.KeyChar = Chr(13) Then
            TextBox2.Text = UCase(TextBox2.Text)
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Masukkan dulu datanya bang!")
            TextBox1.Focus()
            Exit Sub
        Else
            Call koneksi()
            Dim str As String
            str = "update Jenis set Jenis='" & TextBox2.Text & "',Kodejenis='" & TextBox1.Text & "' where Kodejenis='" & TextBox1.Text & "'"
            cmd = New OleDbCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Selamat data abang sudah berhasil diubah dengan baik dan benar")
            Call tampiljenis()
            Call kosong()
            TextBox1.Focus()
        End If
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer
        i = Me.DataGridView1.CurrentRow.Index
        With DataGridView1.Rows.Item(i)
            Me.TextBox1.Text = .Cells(0).Value
            Me.TextBox2.Text = .Cells(1).Value
        End With
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Then
            MsgBox("Masukkan dulu data nya bang!")
            TextBox1.Focus()
            Exit Sub
        Else
            If MessageBox.Show("Kenapa dihapus bang Data Jenis " & TextBox1.Text & " ?", "", MessageBoxButtons.YesNoCancel) = Windows.Forms.DialogResult.Yes Then
                cmd = New OleDbCommand("delete * from Jenis where Kodejenis='" & TextBox1.Text & "'", conn)
                cmd.ExecuteNonQuery()
                MsgBox("Sudah dihapus yah bang!")
                Call kosong()
                Call tampiljenis()
            Else
                Call kosong()
            End If
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call kosong()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Dim result = MessageBox.Show("Kok keluar bang !", "Peringatan ndak guna", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        cmd = New OleDbCommand("select * from Jenis where Kodejenis like '%" & TextBox3.Text & "%'", conn)
        rd = cmd.ExecuteReader()
        rd.Read()
        If rd.HasRows Then
            da = New OleDbDataAdapter("select * from Jenis where KodeJenis like '%" & TextBox3.Text & "%'", conn)
            ds = New DataSet
            da.Fill(ds, "Dapat")
            DataGridView1.DataSource = ds.Tables("Dapat")
            DataGridView1.ReadOnly = True
        Else
            MsgBox("Kosong bang datanya!")
        End If

    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        TextBox1.MaxLength = 2
        If e.KeyChar = Chr(13) Then
            cmd = New OleDbCommand("select * from Jenis where Kodejenis='" & TextBox1.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = True Then
                TextBox2.Text = rd.Item(1)
                TextBox2.Focus()
            Else
                Call isi()
                TextBox2.Focus()
            End If
        End If
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Call koneksi()
        Dim str As String
        str = "select * from Jenis where Kodejenis= '" & TextBox1.Text & "'"
        cmd = New OleDbCommand(str, conn)
        rd = cmd.ExecuteReader
        rd.Read()

        If rd.HasRows Then

            TextBox1.Text = rd.Item("Kodejenis")
            TextBox2.Text = rd.Item("Jenis")
            MessageBox.Show("Kode Jenis sudah pernah digunakan bang!")
        End If

    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Fmenu.Show()
        Me.Hide()
    End Sub
End Class
