Imports System.Data.SqlClient

Public Class MenuAdministrador
    Private Sub MenuAdministrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RegresarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegresarToolStripMenuItem.Click

        Me.Close()
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click

    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click

    End Sub

    Private Sub AgregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem.Click

        Dim siguiente1 As AgregarP = New AgregarP()
        siguiente1.Show()

    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarToolStripMenuItem.Click

        Dim siguiente2 As ActualizarP = New ActualizarP()
        siguiente2.Show()

    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click

        Dim s3 As EliminarPP = New EliminarPP()
        s3.Show()

    End Sub

    Private Sub ConsultasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultasToolStripMenuItem.Click
    End Sub

    Private Sub GeneralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GeneralToolStripMenuItem.Click

        Dim siguienteC As ConsultaP = New ConsultaP()
        siguienteC.Show()
    End Sub

    Private Sub FiltradoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FiltradoToolStripMenuItem.Click
        Dim siguienteF As ConsultaFiltro = New ConsultaFiltro()
        siguienteF.Show()

    End Sub

    Private Sub VentaDelDiaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentaDelDiaToolStripMenuItem.Click

        Dim siguienteF1 As ListadoV = New ListadoV()
        siguienteF1.Show()
    End Sub

    Private Sub ListadoDeVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeVentasToolStripMenuItem.Click

        Dim siguiente5 As TotalDinero = New TotalDinero()
        siguiente5.Show()

    End Sub

    Private Sub AgregarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem1.Click
        Dim siguiente6 As AgregarC = New AgregarC
        siguiente6.Show()

    End Sub

    Private Sub CuandoDebenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuandoDebenToolStripMenuItem.Click


        Dim siguiente50 As ClientesFCon = New ClientesFCon
        siguiente50.Show()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
    End Sub

    Private Sub CantidadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CantidadToolStripMenuItem.Click
        Dim sig As ProvedoresCantidad = New ProvedoresCantidad
        sig.Show()
    End Sub

    Private Sub ProveedoresToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem1.Click

        Dim siguiente57 As Provedores = New Provedores
        siguiente57.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub CalcularGanacíaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularGanacíaToolStripMenuItem.Click
        Dim sga As Ganancia = New Ganancia
        sga.Show()

    End Sub

    Private Sub lblcalcular_Click(sender As Object, e As EventArgs) Handles lblcalcular.Click



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

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
    Private Sub TotalDinero15()


        Dim total As Double = 0
        Dim fila As DataGridViewRow = New DataGridViewRow()

        For Each fila In DataGridView1.Rows
            total += Convert.ToDouble(fila.Cells("total").Value)
        Next


        Label2.Text = Convert.ToString(total)



    End Sub


    Private Sub lblcalculart_Click(sender As Object, e As EventArgs) Handles lblcalculart.Click

        TotalDinero15()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        Dim sga1 As GananciaC = New GananciaC
        sga1.Show()

    End Sub
End Class