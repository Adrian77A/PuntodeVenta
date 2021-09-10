Imports System.Data.SqlClient
Public Class ProvedoresCantidad
    Private Sub RegresarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegresarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btnmostrar_Click(sender As Object, e As EventArgs) Handles btnmostrar.Click



        Dim conexion1 As String
        conexion1 = "Server=(local)\SQLEXPRESS;database=PuntoVenta;Integrated Security=True"
        Dim cn1 As New SqlConnection
        cn1.ConnectionString = conexion1
        Dim adaptador As New SqlDataAdapter("SELECT codigo,nombre,cantidad,descripcion  from Proveedores where fecha= '" & MonthCalendar1.SelectionStart.Date & "' ", cn1)
            cn1.Open()
            Dim tbl As New DataTable
            adaptador.Fill(tbl)
        DataGridView1.DataSource = tbl
    End Sub


    Private Sub Total()
        Dim total As Double = 0
        Dim fila As DataGridViewRow = New DataGridViewRow()
        For Each fila In DataGridView1.Rows
            total += Convert.ToDouble(fila.Cells("cantidad").Value)
        Next
        lbltotal.Text = Convert.ToString(total)
    End Sub

    Private Sub bntsumar_Click(sender As Object, e As EventArgs) Handles bntsumar.Click
        Total()
    End Sub
End Class