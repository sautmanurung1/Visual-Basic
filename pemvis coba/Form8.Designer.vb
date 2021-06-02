<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Me.JenisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JualbukuDataSet = New pemvis_coba.JualbukuDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.JenisTableAdapter = New pemvis_coba.JualbukuDataSetTableAdapters.JenisTableAdapter()
        CType(Me.JenisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JualbukuDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'JenisBindingSource
        '
        Me.JenisBindingSource.DataMember = "Jenis"
        Me.JenisBindingSource.DataSource = Me.JualbukuDataSet
        '
        'JualbukuDataSet
        '
        Me.JualbukuDataSet.DataSetName = "JualbukuDataSet"
        Me.JualbukuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataJenis"
        ReportDataSource1.Value = Me.JenisBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "pemvis_coba.Report4.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1024, 494)
        Me.ReportViewer1.TabIndex = 0
        '
        'JenisTableAdapter
        '
        Me.JenisTableAdapter.ClearBeforeFill = True
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 494)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Form8"
        Me.Text = "Laporan Data Jenis"
        CType(Me.JenisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JualbukuDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents JenisBindingSource As BindingSource
    Friend WithEvents JualbukuDataSet As JualbukuDataSet
    Friend WithEvents JenisTableAdapter As JualbukuDataSetTableAdapters.JenisTableAdapter
End Class
