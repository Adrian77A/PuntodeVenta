Imports System.Data.SqlClient
Public Class EliminarPP
    Private Sub RegresarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegresarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub EliminarPP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtcodigo.Select()
    End Sub

    Private Sub txtnombre_TextChanged(sender As Object, e As EventArgs) Handles txtnombre.TextChanged

    End Sub

    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click

        If txtcodigo.Text = "" Then
            MessageBox.Show("¡¡Falta ingresar el codigo del producto !!", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Else
            Dim conexion1 As String
            conexion1 = "Server=(local)\SQLEXPRESS;database=PuntoVenta;Integrated Security=True"
            Dim cn1 As New SqlConnection
            cn1.ConnectionString = conexion1

            Dim adaptador As New SqlDataAdapter("select*from productos WHERE codigo='" & txtcodigo.Text & "'", cn1)
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
                MsgBox("¡El producto no existe!")
                cn1.Close()
            End If
        End If
    End Sub

    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click
        Dim conexion2 As String
        conexion2 = "Server=(local)\SQLEXPRESS;database=PuntoVenta;Integrated Security=True"
        Dim cn2 As New SqlConnection
        cn2.ConnectionString = conexion2

        Dim adaptador2 As New SqlCommand("Delete From Productos Where codigo='" & txtcodigo.Text & "'", cn2)
        cn2.Open()
        adaptador2.ExecuteNonQuery()
        MsgBox("Producto Eliminado")

        cn2.Close()

        txtnombre.Text = ""
        ComboBoxM.Text = ""
        txtcompra.Text = ""
        txtventa.Text = ""
        txtmarca.Text = ""
        txtstock.Text = ""
        ComboBoxC.Text = ""
        txtcodigo.Text = ""
        txtcodigo.Select()

    End Sub

    Private Sub txtcompra_TextChanged(sender As Object, e As EventArgs) Handles txtcompra.TextChanged

    End Sub
End Class