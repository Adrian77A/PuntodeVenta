Imports System.Data.SqlClient


Public Class TotalDinero
    Private Sub RegresarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegresarToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub btnmostrar_Click(sender As Object, e As EventArgs) Handles btnmostrar.Click
        Dim conexion1 As String
        conexion1 = "Server=(local)\SQLEXPRESS;database=PuntoVenta;Integrated Security=True"
        Dim cn1 As New SqlConnection
        cn1.ConnectionString = conexion1

        Dim adaptador As New SqlDataAdapter("SELECT total,recibido,tipoP,cambio  from Venta where fecha= '" & MonthCalendar1.SelectionStart.Date & "' ", cn1)
        cn1.Open()
        Dim tbl As New DataTable
        adaptador.Fill(tbl)
        DataGridView1.DataSource = tbl

        'MessageBox.Show("La fecha es incorrecta", "¡ Verifique !", MessageBoxButtons.OK, MessageBoxIcon.Error)
        cn1.Close()
    End Sub


    Private Sub TotalDinero()
        Dim total As Double = 0
        Dim fila As DataGridViewRow = New DataGridViewRow()

        For Each fila In DataGridView1.Rows
            total += Convert.ToDouble(fila.Cells("total").Value)
        Next
        lbltotal.Text = Convert.ToString(total)
    End Sub

    Private Sub TotalCambio()
        Dim total As Double = 0
        Dim fila As DataGridViewRow = New DataGridViewRow()
        For Each fila In DataGridView1.Rows
            total += Convert.ToDouble(fila.Cells("cambio").Value)
        Next
        lblcambio.Text = Convert.ToString(total)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TotalDinero()
        TotalCambio()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class