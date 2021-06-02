Imports System.Data.OleDb
Public Class DataBuku
    Sub kosong()
        TextBox1.Clear()
        ComboBox1.Text = ""
        TextBox2.Clear()
        TextBox7.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox8.Clear()
        TextBox1.Focus()
    End Sub

    Sub isi()
        ComboBox1.Text = ""
        TextBox2.Clear()
        TextBox7.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        ComboBox1.Focus()
    End Sub

    Sub tampilbuku()
        da = New OleDbDataAdapter("select * from Buku", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Buku")
        DataGridView1.DataSource = ds.Tables("Buku")
        DataGridView1.Refresh()
    End Sub

    Sub tampiljenis()
        cmd = New OleDbCommand("select Kodejenis from Jenis", conn)
        rd = cmd.ExecuteReader()
        Do While rd.Read
            ComboBox1.Items.Add(rd.Item(0))
        Loop
    End Sub

    Sub aturgrid()
        'untuk mengatur luas Column pada DataGridView
        DataGridView1.Columns(0).Width = 60
        DataGridView1.Columns(1).Width = 50
        DataGridView1.Columns(2).Width = 100
        DataGridView1.Columns(3).Width = 100
        DataGridView1.Columns(4).Width = 100
        DataGridView1.Columns(5).Width = 100
        DataGridView1.Columns(6).Width = 100
        DataGridView1.Columns(7).Width = 300

        'untuk mengatur luas Judul Header pada DataGridView
        DataGridView1.Columns(0).HeaderText = "KODE BARANG"
        DataGridView1.Columns(1).HeaderText = "KODE JENIS"
        DataGridView1.Columns(2).HeaderText = "JUDUL"
        DataGridView1.Columns(3).HeaderText = "PENGARANG"
        DataGridView1.Columns(4).HeaderText = "PENERBIT"
        DataGridView1.Columns(5).HeaderText = "JUMLAH"
        DataGridView1.Columns(6).HeaderText = "HARGA"
        DataGridView1.Columns(7).HeaderText = "DESKRIPSI"
    End Sub

    Private Sub DataBuku_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Call tampiljenis()
        Call tampilbuku()
        Call kosong()
        Call aturgrid()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call kosong()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Dim result = MessageBox.Show("Kok keluar bang !", "Peringatan ndak guna", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        cmd = New OleDbCommand("select * from Jenis where Kodejenis='" & ComboBox1.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            TextBox8.Text = rd.Item(1)
        Else
            MsgBox("Kode Kosong banget bang")
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button6.Click
        If TextBox1.Text = "" Or ComboBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Then
            MsgBox("Data Kok Belum lengkap bang !")
            TextBox1.Focus()
            Exit Sub
        Else
            cmd = New OleDbCommand("select * from Buku where KodeBuku='" & TextBox1.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                Dim str As String
                str = "insert into Buku values ('" & TextBox1.Text & "','" & ComboBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "' )"
                cmd = New OleDbCommand(str, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data nya udah kesimpan yahh bang ", MsgBoxStyle.Information, "Perhatian")
            End If
            Call tampilbuku()
            Call kosong()
            TextBox1.Focus()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Call koneksi()
        Dim str As String
        str = "select * from Buku where KodeBuku= '" & TextBox1.Text & "'"
        cmd = New OleDbCommand(str, conn)
        rd = cmd.ExecuteReader
        rd.Read()

        If rd.HasRows Then
            TextBox1.Text = rd.Item("KodeBuku")
            TextBox2.Text = rd.Item("Judul")
            TextBox3.Text = rd.Item("Pengarang")
            TextBox4.Text = rd.Item("Penerbit")
            TextBox5.Text = rd.Item("Jumlahbuku")
            TextBox6.Text = rd.Item("Harga")
            TextBox7.Text = rd.Item("Deskripsi")
            ComboBox1.Text = rd.Item("Kodejenis")
            TextBox8.Text = rd.Item("Jenis")
            MessageBox.Show("Kode Jenis sudah pernah digunakan bang!")
        End If
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged
        cmd = New OleDbCommand("select * from Buku where KodeBuku like '%" & TextBox9.Text & "%'", conn)
        rd = cmd.ExecuteReader()
        rd.Read()
        If rd.HasRows Then
            da = New OleDbDataAdapter("select * from Buku where KodeBuku like '%" & TextBox9.Text & "%'", conn)
            ds = New DataSet
            da.Fill(ds, "Dapat")
            DataGridView1.DataSource = ds.Tables("Dapat")
            DataGridView1.ReadOnly = True
        Else
            MsgBox("Kosong bang datanya!")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or ComboBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Then
            MsgBox("Masukkan dulu datanya bang!")
            TextBox1.Focus()
            Exit Sub
        Else
            Call koneksi()
            Dim str As String
            str = "update Buku set Judul='" & TextBox2.Text & "',KodeBuku='" & TextBox1.Text & "',Pengarang='" & TextBox3.Text & "',Penerbit='" & TextBox4.Text & "',Jumlahbuku='" & TextBox5.Text & "',Harga='" & TextBox6.Text & "',Deskripsi='" & TextBox7.Text & "',Kodejenis='" & ComboBox1.Text & " ' where KodeBuku='" & TextBox1.Text & "'"
            cmd = New OleDbCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Selamat data abang sudah berhasil diubah dengan baik dan benar")
            Call tampiljenis()
            Call kosong()
            TextBox1.Focus()
        End If
    End Sub
    Private Sub TextBox1_Keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        TextBox1.MaxLength = 5
        If e.KeyChar = Chr(13) Then
            TextBox1.Text = UCase(TextBox1.Text)
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer
        i = Me.DataGridView1.CurrentRow.Index
        With DataGridView1.Rows.Item(i)
            Me.TextBox1.Text = .Cells(0).Value
            Me.TextBox2.Text = .Cells(1).Value
            Me.TextBox3.Text = .Cells(2).Value
            Me.TextBox4.Text = .Cells(3).Value
            Me.TextBox5.Text = .Cells(4).Value
            Me.TextBox6.Text = .Cells(5).Value
            Me.TextBox7.Text = .Cells(6).Value
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            MsgBox("Masukkan dulu data nya bang!")
            TextBox1.Focus()
            Exit Sub
        Else
            If MessageBox.Show("Kenapa dihapus bang " & TextBox2.Text & " ?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                cmd = New OleDbCommand("delete * from Buku where Judul ='" & TextBox2.Text & "'", conn)
                cmd.ExecuteNonQuery()
                MsgBox("Sudah dihapus yah bang!")
                Call kosong()
                Call tampilbuku()
            Else
                Call kosong()
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Fmenu.Show()
        Me.Hide()
    End Sub
End Class