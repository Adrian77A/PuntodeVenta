Imports System.Data.SqlClient

Public Class AgregarC
    Private Sub RegresarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegresarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        Dim entrada As String
        Dim contador As Integer

        entrada = txttelefono.Text
        contador = Len(entrada)

        If txtcodigo.Text = "" Then
            MessageBox.Show("¡¡Falta ingresar el codigo del cliente !!", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Else
            If txtnombre.Text = "" Then
                MessageBox.Show("¡¡Falta ingresar el nombre del cliente !!", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Else
                If txtapellidos.Text = "" Then
                    MessageBox.Show("¡¡Falta ingresar los apellidos del cliente !!", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Else
                    If contador <> 10 Then
                        MessageBox.Show("¡¡Solo se aceptan 10 caracteres en el telefono!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    Else
                        If txtdireccion.Text = "" Then
                            MessageBox.Show("¡¡Falta ingresar la dirección !!", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                        Else
                            Dim conexion As String
                            conexion = "Server=(local)\SQLEXPRESS;database=PuntoVenta;Integrated Security=True"
                            Dim cn As New SqlConnection
                            cn.ConnectionString = conexion

                            Dim adaptador As New SqlCommand("insert into ClientesF values(" & txtcodigo.Text & ",'" & txtnombre.Text & "','" & txtapellidos.Text & "'," & txttelefono.Text & ",'" & txtdireccion.Text & "')", cn)
                            cn.Open()
                            adaptador.ExecuteNonQuery()
                            MsgBox("Se registro el cliente correctamente")

                            txtcodigo.Text = ""
                            txtnombre.Text = ""
                            txtapellidos.Text = ""
                            txttelefono.Text = ""
                            txtdireccion.Text = ""
                            cn.Close()
                        End If
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click

        Dim entrada As String
        Dim contador As Integer

        entrada = txttelefono.Text
        contador = Len(entrada)

        If txtcodigo.Text = "" Then
            MessageBox.Show("¡¡Falta ingresar el codigo del cliente !!", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Else
            If txtnombre.Text = "" Then
                MessageBox.Show("¡¡Falta ingresar el nombre del cliente !!", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Else
                If txtapellidos.Text = "" Then
                    MessageBox.Show("¡¡Falta ingresar el nombre del cliente !!", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Else
                    If contador <> 10 Then
                        MessageBox.Show("¡¡Solo se aceptan 10 caracteres en el numero!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    Else
                        If txtdireccion.Text = "" Then
                            MessageBox.Show("¡¡Falta ingresar la direccion del cliente !!", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                        Else
                            Dim conexion As String
                            conexion = "Server=(local)\SQLEXPRESS;database=PuntoVenta;Integrated Security=True"
                            Dim cn As New SqlConnection
                            cn.ConnectionString = conexion

                            Dim adaptador As New SqlCommand("update ClientesF set nombre = '" & txtnombre.Text & "', apellidos= '" & txtapellidos.Text & "',telefono = " & txttelefono.Text & ",direccion= '" & txtdireccion.Text & "' where codigo= " & txtcodigo.Text & "", cn)
                            cn.Open()
                            adaptador.ExecuteNonQuery()
                            MsgBox("Datos Actualizados")

                            cn.Close()

                        End If
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub AgregarC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PuntoVentaDataSetClientesF.ClientesF' Puede moverla o quitarla según sea necesario.
        Me.ClientesFTableAdapter.Fill(Me.PuntoVentaDataSetClientesF.ClientesF)

    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click


        Dim conexion As String
        conexion = "Server=(local)\SQLEXPRESS;database=PuntoVenta;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim adaptador As New SqlCommand("Delete From ClientesF Where codigo= " & txtcodigo.Text & "", cn)
        cn.Open()
        adaptador.ExecuteNonQuery()
        MsgBox("Cliente Eliminado")

        cn.Close()



    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseClick

        txtcodigo.Text = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()
        txtnombre.Text = DataGridView1.SelectedRows(0).Cells(1).Value.ToString()
        txtapellidos.Text = DataGridView1.SelectedRows(0).Cells(2).Value.ToString()
        txttelefono.Text = DataGridView1.SelectedRows(0).Cells(3).Value.ToString()
        txtdireccion.Text = DataGridView1.SelectedRows(0).Cells(4).Value.ToString()

    End Sub
End Class