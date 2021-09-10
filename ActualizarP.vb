Imports System.Data.SqlClient
Public Class ActualizarP
    Private Sub RegresarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegresarToolStripMenuItem.Click

        Me.Close()
    End Sub

    Private Sub ActualizarP_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub Label8_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtcodigo1.TextChanged

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonGuardar_Click(sender As Object, e As EventArgs) Handles ButtonGuardar.Click


        If txtcodigo1.Text = "" Then
            MessageBox.Show("¡¡Falta ingresar el codigo del producto !!", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Else
            If txtnombre.Text = "" Then
                MessageBox.Show("¡¡Falta ingresar el nombre del producto !!", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Else
                If ComboBoxM.Text = "" Then
                    MessageBox.Show("¡¡Falta ingresar la unidad de medida !!", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Else
                    If txtcompra.Text = "" Then
                        MessageBox.Show("¡¡Falta ingresar el precio de compra !!", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    Else
                        If txtventa.Text = "" Then
                            MessageBox.Show("¡¡Falta ingresar el precio de venta !!", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                        Else
                            If txtmarca.Text = "" Then
                                MessageBox.Show("¡¡Falta ingresar la marca !!", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                            Else
                                If txtstock.Text = "" Then
                                    MessageBox.Show("¡¡Falta ingresar el stock!!", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                                Else
                                    If ComboBoxC.Text = "" Then
                                        MessageBox.Show("¡¡Falta ingresar la clasificación!!", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                                    Else
                                        Dim conexion As String
                                        conexion = "Server=(local)\SQLEXPRESS;database=PuntoVenta;Integrated Security=True"
                                        Dim cn As New SqlConnection
                                        cn.ConnectionString = conexion

                                        Dim adaptador As New SqlCommand("update productos set nombre ='" & txtnombre.Text & "',unidadMedida='" & ComboBoxM.Text & "',precioC=" & txtcompra.Text & ",precioV=" & txtventa.Text & ",marca='" & txtmarca.Text & "',stock=" & txtstock.Text & ",clasificacion='" & ComboBoxC.Text & "' where codigo='" & txtcodigo1.Text & "'", cn)
                                        cn.Open()
                                        adaptador.ExecuteNonQuery()
                                        MessageBox.Show("Producto fue actualizado correctamente", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        limpiar()
                                        cn.Close()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub limpiar()

        txtcodigo1.Text = ""
        txtnombre.Text = ""
        ComboBoxM.Text = ""
        txtcompra.Text = ""
        txtventa.Text = ""
        txtmarca.Text = ""
        txtstock.Text = ""
        ComboBoxC.Text = ""
    End Sub

    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click

        Dim conexion1 As String
        conexion1 = "Server=(local)\SQLEXPRESS;database=PuntoVenta;Integrated Security=True"
        Dim cn1 As New SqlConnection
        cn1.ConnectionString = conexion1

        Dim adaptador As New SqlDataAdapter("select*from productos WHERE codigo='" & txtcodigo1.Text & " '", cn1)
        cn1.Open()
        Dim ds As New DataSet
        adaptador.Fill(ds, "datos")


        If ds.Tables("datos").Rows.Count > 0 Then
            txtnombre.Text = ds.Tables("datos").Rows(0).Item(1).ToString
            ComboBoxM.Text = ds.Tables("datos").Rows(0).Item(2).ToString
            txtcompra.Text = ds.Tables("datos").Rows(0).Item(3).ToString
            txtventa.Text = ds.Tables("datos").Rows(0).Item(4).ToString
            txtmarca.Text = ds.Tables("datos").Rows(0).Item(5).ToString
            txtstock.Text = ds.Tables("datos").Rows(0).Item(6).ToString
            ComboBoxC.Text = ds.Tables("datos").Rows(0).Item(8).ToString
        Else
            MessageBox.Show("El Producto no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        cn1.Close()


    End Sub

    Private Sub txtnombre_TextChanged(sender As Object, e As EventArgs) Handles txtnombre.TextChanged

    End Sub

    Private Sub txtcompra_TextChanged(sender As Object, e As EventArgs) Handles txtcompra.TextChanged

    End Sub
End Class