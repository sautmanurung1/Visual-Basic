<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DataBuku
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Buku"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(305, 16)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox1.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(102, 18)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 248)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(722, 200)
        Me.DataGridView1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Judul"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(102, 52)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(635, 22)
        Me.TextBox2.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(222, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Jenis Buku"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(318, 97)
        Me.TextBox7.Multiline = True
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(416, 45)
        Me.TextBox7.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Pengarang"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(102, 86)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(197, 22)
        Me.TextBox3.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Penerbit"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(102, 120)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(197, 22)
        Me.TextBox4.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 17)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Jumlah Buku"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(107, 155)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(95, 22)
        Me.TextBox5.TabIndex = 14
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(305, 150)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(121, 22)
        Me.TextBox6.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(217, 153)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 17)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Harga buku"
        '
        'TextBox8
        '
        Me.TextBox8.Enabled = False
        Me.TextBox8.HideSelection = False
        Me.TextBox8.Location = New System.Drawing.Point(454, 19)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(280, 22)
        Me.TextBox8.TabIndex = 18
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(12, 220)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(722, 22)
        Me.TextBox9.TabIndex = 19
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(15, 183)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(102, 31)
        Me.Button6.TabIndex = 24
        Me.Button6.Text = "&Simpan"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(123, 183)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 31)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "&Ubah"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(231, 183)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 31)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "&Hapus"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(339, 183)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 31)
        Me.Button3.TabIndex = 27
        Me.Button3.Text = "&Batal"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(315, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 17)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Deksripsi"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(447, 183)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(102, 31)
        Me.Button5.TabIndex = 30
        Me.Button5.Text = "&Kembali"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'DataBuku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 450)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "DataBuku"
        Me.Text = "Form Data Buku"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Button5 As Button
End Class
