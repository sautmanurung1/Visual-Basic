<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.chkShow = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(45, 240)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 35)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "&Login"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(130, 63)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(155, 22)
        Me.TextBox1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(130, 139)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.TextBox2.Size = New System.Drawing.Size(155, 22)
        Me.TextBox2.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(159, 240)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 35)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "&Batal"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'chkShow
        '
        Me.chkShow.AutoSize = True
        Me.chkShow.Location = New System.Drawing.Point(15, 190)
        Me.chkShow.Name = "chkShow"
        Me.chkShow.Size = New System.Drawing.Size(129, 21)
        Me.chkShow.TabIndex = 6
        Me.chkShow.Text = "Show Password"
        Me.chkShow.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 299)
        Me.Controls.Add(Me.chkShow)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents chkShow As CheckBox
End Class
