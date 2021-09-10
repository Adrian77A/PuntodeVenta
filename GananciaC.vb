Public Class GananciaC
    Private Sub RegresarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegresarToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub GananciaC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PuntoVentaDataSet2.Ganancia' Puede moverla o quitarla según sea necesario.
        Me.GananciaTableAdapter.Fill(Me.PuntoVentaDataSet2.Ganancia)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        DataGridView1.DrawToBitmap(bm, New Rectangle(30, 30, Me.DataGridView1.Width, Me.DataGridView1.Height))
        e.Graphics.DrawImage(bm, 0, 0)

    End Sub

    Private Sub btnimprimir_Click(sender As Object, e As EventArgs)

        PrintPreviewDialog1.ShowDialog()
        PrintDocument1.Print()
    End Sub
End Class