<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.BukuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JualbukuDataSet = New pemvis_coba.JualbukuDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.BukuTableAdapter = New pemvis_coba.JualbukuDataSetTableAdapters.BukuTableAdapter()
        CType(Me.BukuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JualbukuDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BukuBindingSource
        '
        Me.BukuBindingSource.DataMember = "Buku"
        Me.BukuBindingSource.DataSource = Me.JualbukuDataSet
        '
        'JualbukuDataSet
        '
        Me.JualbukuDataSet.DataSetName = "JualbukuDataSet"
        Me.JualbukuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataBuku"
        ReportDataSource1.Value = Me.BukuBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "pemvis_coba.Report5.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1315, 492)
        Me.ReportViewer1.TabIndex = 0
        '
        'BukuTableAdapter
        '
        Me.BukuTableAdapter.ClearBeforeFill = True
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1315, 492)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Form9"
        Me.Text = "Laporan Data Buku"
        CType(Me.BukuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JualbukuDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BukuBindingSource As BindingSource
    Friend WithEvents JualbukuDataSet As JualbukuDataSet
    Friend WithEvents BukuTableAdapter As JualbukuDataSetTableAdapters.BukuTableAdapter
End Class
