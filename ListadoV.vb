Imports System.Data.SqlClient
Public Class ListadoV


    Private Sub RegresarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegresarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Btnconsultar_Click(sender As Object, e As EventArgs) Handles Btnconsultar.Click

        Dim conexion1 As String
        conexion1 = "Server=(local)\SQLEXPRESS;database=PuntoVenta;Integrated Security=True"
        Dim cn1 As New SqlConnection
        cn1.ConnectionString = conexion1

        Dim adaptador As New SqlDataAdapter("SELECT codigo,nombre,cantidad,precio,subtotal  from Vdetalle where fecha= '" & MonthCalendar1.SelectionStart.Date & "' ", cn1)
        cn1.Open()
        Dim tbl As New DataTable
        adaptador.Fill(tbl)
        DataGridView1.DataSource = tbl

        'MessageBox.Show("La fecha es incorrecta", "¡ Verifique !", MessageBoxButtons.OK, MessageBoxIcon.Error)


        cn1.Close()

    End Sub

    Private Sub ListadoV_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub CantidadP()

        Dim total As Double = 0
        Dim fila As DataGridViewRow = New DataGridViewRow()


        For Each fila In DataGridView1.Rows
            total += Convert.ToDouble(fila.Cells("cantidad").Value)
        Next
        lbltotal.Text = Convert.ToString(total)


    End Sub

    Private Sub btntotalc_Click(sender As Object, e As EventArgs) Handles btntotalc.Click

        CantidadP()

    End Sub

    Private Sub lblImprimir_Click(sender As Object, e As EventArgs) Handles lblImprimir.Click
        PrintPreviewDialog1.ShowDialog()
        PrintDocument1.Print()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        DataGridView1.DrawToBitmap(bm, New Rectangle(30, 30, Me.DataGridView1.Width, Me.DataGridView1.Height))
        e.Graphics.DrawImage(bm, 0, 0)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class