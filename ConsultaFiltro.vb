Imports System.Data.SqlClient
Public Class ConsultaFiltro
    Private Sub RegresarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegresarToolStripMenuItem.Click

        Me.Close()
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
                txtmedida.Text = ds.Tables("datos").Rows(0).Item(2).ToString
                txtPcompra.Text = ds.Tables("datos").Rows(0).Item(3).ToString
                txtPVenta.Text = ds.Tables("datos").Rows(0).Item(4).ToString
                txtmarca.Text = ds.Tables("datos").Rows(0).Item(5).ToString
                txtstock.Text = ds.Tables("datos").Rows(0).Item(6).ToString
                txtcaducidad.Text = ds.Tables("datos").Rows(0).Item(7).ToString
                txtclasificacion.Text = ds.Tables("datos").Rows(0).Item(8).ToString

            Else
                MessageBox.Show("El Producto no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cn1.Close()

            End If
        End If
    End Sub

    Private Sub ConsultaFiltro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtcodigo.Select()

    End Sub
End Class