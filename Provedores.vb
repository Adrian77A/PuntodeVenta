
Imports System.Data.SqlClient

Public Class Provedores
    Private Sub DataGridView1_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseClick

        txtcodigo.Text = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()
        txtnombre.Text = DataGridView1.SelectedRows(0).Cells(1).Value.ToString()
        txtcantidad.Text = DataGridView1.SelectedRows(0).Cells(2).Value.ToString()
        txtdescripcion.Text = DataGridView1.SelectedRows(0).Cells(3).Value.ToString()
        MonthCalendar1.Text = DataGridView1.SelectedRows(0).Cells(4).Value.ToString()

    End Sub

    Private Sub RegresarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegresarToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub Btnagregar_Click(sender As Object, e As EventArgs) Handles Btnagregar.Click


        If txtcodigo.Text = "" Then
            MessageBox.Show("¡¡Falta ingresar el codigo !!", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Else
            If txtnombre.Text = "" Then
                MessageBox.Show("¡¡Falta ingresar el nombre !!", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Else
                If txtcantidad.Text = "" Then
                    MessageBox.Show("¡¡Falta ingresar la cantidad!!", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Else
                    If txtdescripcion.Text = "" Then
                        MessageBox.Show("¡¡Falta ingresar la descripcion!!", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    Else
                        Dim conexion As String
                        conexion = "Server=(local)\SQLEXPRESS;database=PuntoVenta;Integrated Security=True"
                        Dim cn As New SqlConnection
                        cn.ConnectionString = conexion

                        Dim adaptador As New SqlCommand("insert into Proveedores values(" & txtcodigo.Text & ",'" & txtnombre.Text & "'," & txtcantidad.Text & ",'" & txtdescripcion.Text & "' , '" & MonthCalendar1.SelectionStart.Date & "')", cn)
                        cn.Open()
                        adaptador.ExecuteNonQuery()
                        MsgBox("Se registro los datos correctamente")

                        txtcodigo.Text = ""
                        txtnombre.Text = ""
                        txtcantidad.Text = ""
                        txtdescripcion.Text = ""
                        MonthCalendar1.Text = ""
                        cn.Close()
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim conexion As String
        conexion = "Server=(local)\SQLEXPRESS;database=PuntoVenta;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim adaptador As New SqlCommand("Delete From Proveedores  Where codigo= " & txtcodigo.Text & "", cn)
        cn.Open()
        adaptador.ExecuteNonQuery()
        MsgBox("Proveedor Eliminado")

        cn.Close()
    End Sub

    Private Sub Provedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PuntoVentaDataSet1.Proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.PuntoVentaDataSet1.Proveedores)

    End Sub

    Private Sub TotalDinero()


    End Sub

    Private Sub Btncalcularsuma_Click(sender As Object, e As EventArgs)

        TotalDinero()

    End Sub

    Private Sub txtnombre_TextChanged(sender As Object, e As EventArgs) Handles txtnombre.TextChanged

    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click

        Dim conexion As String
        conexion = "Server=(local)\SQLEXPRESS;database=PuntoVenta;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim adaptador As New SqlCommand("update Proveedores set nombre='" & txtnombre.Text & "',cantidad=" & txtcantidad.Text & ",descripcion='" & txtdescripcion.Text & "',fecha='" & MonthCalendar1.SelectionStart.Date & "' where codigo= " & txtcodigo.Text & "", cn)
        cn.Open()
        adaptador.ExecuteNonQuery()
        MsgBox("Datos Actualizados")

        cn.Close()

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class