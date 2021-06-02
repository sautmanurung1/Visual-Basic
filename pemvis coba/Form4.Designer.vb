<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Fmenu
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MasterDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataJenisBukuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataBukuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanDataJenisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanDataBukuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PengaturanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PemakaiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GantiUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.JualbukuDataSet1 = New pemvis_coba.JualbukuDataSet()
        Me.BukuTableAdapter1 = New pemvis_coba.JualbukuDataSetTableAdapters.BukuTableAdapter()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.JualbukuDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterDataToolStripMenuItem, Me.PengaturanToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(783, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MasterDataToolStripMenuItem
        '
        Me.MasterDataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataJenisBukuToolStripMenuItem, Me.DataBukuToolStripMenuItem, Me.LaporanToolStripMenuItem})
        Me.MasterDataToolStripMenuItem.Name = "MasterDataToolStripMenuItem"
        Me.MasterDataToolStripMenuItem.Size = New System.Drawing.Size(104, 24)
        Me.MasterDataToolStripMenuItem.Text = "Master Data"
        '
        'DataJenisBukuToolStripMenuItem
        '
        Me.DataJenisBukuToolStripMenuItem.Name = "DataJenisBukuToolStripMenuItem"
        Me.DataJenisBukuToolStripMenuItem.Size = New System.Drawing.Size(195, 26)
        Me.DataJenisBukuToolStripMenuItem.Text = "Data Jenis Buku"
        '
        'DataBukuToolStripMenuItem
        '
        Me.DataBukuToolStripMenuItem.Name = "DataBukuToolStripMenuItem"
        Me.DataBukuToolStripMenuItem.Size = New System.Drawing.Size(195, 26)
        Me.DataBukuToolStripMenuItem.Text = "Data Buku"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanDataJenisToolStripMenuItem, Me.LaporanDataBukuToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(195, 26)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'LaporanDataJenisToolStripMenuItem
        '
        Me.LaporanDataJenisToolStripMenuItem.Name = "LaporanDataJenisToolStripMenuItem"
        Me.LaporanDataJenisToolStripMenuItem.Size = New System.Drawing.Size(218, 26)
        Me.LaporanDataJenisToolStripMenuItem.Text = "Laporan Data Jenis"
        '
        'LaporanDataBukuToolStripMenuItem
        '
        Me.LaporanDataBukuToolStripMenuItem.Name = "LaporanDataBukuToolStripMenuItem"
        Me.LaporanDataBukuToolStripMenuItem.Size = New System.Drawing.Size(218, 26)
        Me.LaporanDataBukuToolStripMenuItem.Text = "Laporan Data Buku"
        '
        'PengaturanToolStripMenuItem
        '
        Me.PengaturanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PemakaiToolStripMenuItem, Me.TambahUserToolStripMenuItem, Me.GantiUserToolStripMenuItem})
        Me.PengaturanToolStripMenuItem.Name = "PengaturanToolStripMenuItem"
        Me.PengaturanToolStripMenuItem.Size = New System.Drawing.Size(97, 24)
        Me.PengaturanToolStripMenuItem.Text = "Pengaturan"
        '
        'PemakaiToolStripMenuItem
        '
        Me.PemakaiToolStripMenuItem.Name = "PemakaiToolStripMenuItem"
        Me.PemakaiToolStripMenuItem.Size = New System.Drawing.Size(173, 26)
        Me.PemakaiToolStripMenuItem.Text = "Pemakai "
        '
        'TambahUserToolStripMenuItem
        '
        Me.TambahUserToolStripMenuItem.Name = "TambahUserToolStripMenuItem"
        Me.TambahUserToolStripMenuItem.Size = New System.Drawing.Size(173, 26)
        Me.TambahUserToolStripMenuItem.Text = "TambahUser"
        '
        'GantiUserToolStripMenuItem
        '
        Me.GantiUserToolStripMenuItem.Name = "GantiUserToolStripMenuItem"
        Me.GantiUserToolStripMenuItem.Size = New System.Drawing.Size(173, 26)
        Me.GantiUserToolStripMenuItem.Text = "Ganti User"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(65, 24)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Algerian", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(705, 36)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Selamat Datang Di Menu Saut Manurung"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Algerian", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(681, 36)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Jangan Lupa Like,Komen dan Subscribe"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 537)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(783, 26)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(153, 20)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(153, 20)
        Me.ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(153, 20)
        Me.ToolStripStatusLabel3.Text = "ToolStripStatusLabel3"
        '
        'JualbukuDataSet1
        '
        Me.JualbukuDataSet1.DataSetName = "JualbukuDataSet"
        Me.JualbukuDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BukuTableAdapter1
        '
        Me.BukuTableAdapter1.ClearBeforeFill = True
        '
        'Fmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 563)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Fmenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.JualbukuDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MasterDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataJenisBukuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataBukuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PengaturanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PemakaiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TambahUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents JualbukuDataSet1 As JualbukuDataSet
    Friend WithEvents BukuTableAdapter1 As JualbukuDataSetTableAdapters.BukuTableAdapter
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanDataJenisToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanDataBukuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GantiUserToolStripMenuItem As ToolStripMenuItem
End Class
