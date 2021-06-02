<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pemakai
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 163)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 37)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "&Simpan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Kode Pemakai"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(188, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(250, 22)
        Me.TextBox1.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 241)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(776, 197)
        Me.DataGridView1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nama Pemakai"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(188, 46)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(250, 22)
        Me.TextBox2.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Status Pemakai"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(188, 87)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(250, 22)
        Me.TextBox3.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Password Pemakai"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(188, 127)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(250, 22)
        Me.TextBox4.TabIndex = 9
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(120, 163)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 37)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "&Ubah"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(228, 163)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 37)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "&Hapus"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(336, 163)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(102, 37)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "&Batal"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(444, 163)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(102, 37)
        Me.Button5.TabIndex = 13
        Me.Button5.Text = "&Kembali"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(12, 206)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(776, 22)
        Me.TextBox5.TabIndex = 15
        '
        'Pemakai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Pemakai"
        Me.Text = "Nama Pemakai"
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
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents TextBox5 As TextBox
End Class
