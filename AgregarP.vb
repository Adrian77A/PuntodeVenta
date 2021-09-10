Imports System.Data.SqlClient

Public Class AgregarP
    Private Sub MenuStrip4_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip4.ItemClicked

        Me.Close()
    End Sub

    Private Sub AgregarP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtcodigo.Select()

    End Sub

    Private Sub MenuStrip3_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub RegresarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegresarToolStripMenuItem.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxC.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If txtcodigo.Text = "" Then
            MessageBox.Show("¡¡Falta ingresar el codigo del producto !!", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Else
            If txtnombre.Text = "" Then
                MessageBox.Show("¡¡Falta ingresar el nombre del producto !!", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Else
                If ComboBoxM.Text = "" Then
                    MessageBox.Show("¡¡Falta ingresar la unidad de medida !!", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Else
                    If txtPcompra.Text = "" Then
                        MessageBox.Show("¡¡Falta ingresar el precio de compra !!", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    Else
                        If txtPVenta.Text = "" Then
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

                                        Dim adaptador As New SqlCommand("insert into productos values('" & txtcodigo.Text & "','" & txtnombre.Text & "','" & ComboBoxM.Text & "'," & txtPcompra.Text & "," & txtPVenta.Text & ",'" & txtmarca.Text & "'," & txtstock.Text & ",'" & MonthCalendarC.SelectionStart.Date & "', '" & ComboBoxC.Text & "')", cn)
                                        cn.Open()
                                        adaptador.ExecuteNonQuery()
                                        MessageBox.Show("El producto fue guardado correctamente", "Guardando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        txtcodigo.Text = ""
                                        txtnombre.Text = ""
                                        ComboBoxM.Text = ""
                                        txtPcompra.Text = ""
                                        txtPVenta.Text = ""
                                        txtmarca.Text = ""
                                        txtstock.Text = ""
                                        MonthCalendarC.Text = ""
                                        ComboBoxC.Text = ""
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

    Private Sub ComboBoxM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxM.SelectedIndexChanged

    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Dim conexion1 As String
        conexion1 = "Server=(local)\SQLEXPRESS;database=PuntoVenta;Integrated Security=True"
        Dim cn1 As New SqlConnection
        cn1.ConnectionString = conexion1

        Dim adaptador As New SqlDataAdapter("select*from productos WHERE codigo='" & txtcodigo.Text & " '", cn1)
        cn1.Open()
        Dim ds As New DataSet
        adaptador.Fill(ds, "datos")
        If ds.Tables("datos").Rows.Count > 0 Then
            MessageBox.Show("El Producto actualmente esta registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            txtnombre.Enabled = True
            ComboBoxM.Enabled = True
            txtPcompra.Enabled = True
            txtPVenta.Enabled = True
            txtmarca.Enabled = True
            txtstock.Enabled = True
            MonthCalendarC.Enabled = True
            ComboBoxC.Enabled = True
        End If
        cn1.Close()

    End Sub
End Class