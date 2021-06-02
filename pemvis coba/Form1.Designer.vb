<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataJenis
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(15, 151)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 38)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "&Simpan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Kode Jenis"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(142, 47)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(15, 223)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(773, 215)
        Me.DataGridView1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nama Jenis"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(142, 108)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(205, 22)
        Me.TextBox2.TabIndex = 5
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(123, 151)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 38)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "&Ubah"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(231, 151)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 38)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "&Hapus"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(339, 151)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(102, 38)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "&Batal"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(15, 195)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(773, 22)
        Me.TextBox3.TabIndex = 10
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(447, 151)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(102, 38)
        Me.Button6.TabIndex = 31
        Me.Button6.Text = "&Kembali"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'DataJenis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "DataJenis"
        Me.Text = "Data Jenis Buku"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button6 As Button
End Class
