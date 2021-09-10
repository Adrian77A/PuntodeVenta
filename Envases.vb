Imports System.Data.SqlClient

Public Class Envases
    Private Sub Envases_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PuntoVentaDataClientes.Clientes1' Puede moverla o quitarla según sea necesario.
        Me.Clientes1TableAdapter.Fill(Me.PuntoVentaDataClientes.Clientes1)
        txtcodigo.Select()

    End Sub

    Private Sub RegresarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegresarToolStripMenuItem.Click

        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtnombre.TextChanged

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtapellidos.TextChanged

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ButtonAnadir.Click
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
                    MessageBox.Show("¡¡Falta ingresar el apellido del cliente!!", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Else
                    If contador <> 10 Then
                        MessageBox.Show("¡¡Solo se aceptan 10 caracteres en el Telefono!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    Else
                        If txtenvase.Text = "" Then
                            MessageBox.Show("¡¡Falta ingresar el numero de envases !!", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                        Else
                            If txtdescripcion.Text = "" Then
                                MessageBox.Show("¡¡Falta ingresar la descripción!!", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                            Else
                                Dim conexion As String
                                conexion = "Server=(local)\SQLEXPRESS;database=PuntoVenta;Integrated Security=True"
                                Dim cn As New SqlConnection
                                cn.ConnectionString = conexion
                                Dim adaptador As New SqlCommand("insert into Clientes1 values(" & txtcodigo.Text & ",'" & txtnombre.Text & "','" & txtapellidos.Text & "'," & txttelefono.Text & "," & txtenvase.Text & ",'" & txtdescripcion.Text & "')", cn)
                                cn.Open()
                                adaptador.ExecuteNonQuery()
                                MsgBox("Se registro los datos correctamente")
                                limpiar()
                                cn.Close()
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub limpiar()
        txtcodigo.Text = ""
        txtnombre.Text = ""
        txtapellidos.Text = ""
        txttelefono.Text = ""
        txtenvase.Text = ""
        txtdescripcion.Text = ""

    End Sub

    Private Sub ButtonActualizar_Click(sender As Object, e As EventArgs) Handles ButtonActualizar.Click

        Dim conexion As String
        conexion = "Server=(local)\SQLEXPRESS;database=PuntoVenta;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim adaptador As New SqlCommand("update Clientes1 set nombre = '" & txtnombre.Text & "', apellidos= '" & txtapellidos.Text & "',telefono = " & txttelefono.Text & ", envase= " & txtenvase.Text & ",descripcion= '" & txtdescripcion.Text & "' where codigo= " & txtcodigo.Text & "", cn)
        cn.Open()
        adaptador.ExecuteNonQuery()
        MsgBox("Datos Actualizados")

        cn.Close()

    End Sub

    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click
        Dim conexion As String
        conexion = "Server=(local)\SQLEXPRESS;database=PuntoVenta;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim adaptador As New SqlCommand("Delete From Clientes1 Where codigo= " & txtcodigo.Text & "", cn)
        cn.Open()
        adaptador.ExecuteNonQuery()
        MsgBox("Cliente Eliminado")

        cn.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
    End Sub

    Private Sub DataGridView1_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseClick

        txtcodigo.Text = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()
        txtnombre.Text = DataGridView1.SelectedRows(0).Cells(1).Value.ToString()
        txtapellidos.Text = DataGridView1.SelectedRows(0).Cells(2).Value.ToString()
        txttelefono.Text = DataGridView1.SelectedRows(0).Cells(3).Value.ToString()
        txtenvase.Text = DataGridView1.SelectedRows(0).Cells(4).Value.ToString()
        txtdescripcion.Text = DataGridView1.SelectedRows(0).Cells(5).Value.ToString()

    End Sub

    Private Sub txtdescripcion_TextChanged(sender As Object, e As EventArgs) Handles txtdescripcion.TextChanged

    End Sub
End Class