Public Class Form8
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JualbukuDataSet.Jenis' table. You can move, or remove it, as needed.
        Me.JenisTableAdapter.Fill(Me.JualbukuDataSet.Jenis)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class