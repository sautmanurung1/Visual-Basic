Public Class Form9
    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JualbukuDataSet.Buku' table. You can move, or remove it, as needed.
        Me.BukuTableAdapter.Fill(Me.JualbukuDataSet.Buku)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class