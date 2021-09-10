Imports System.Data.SqlClient


Public Class ClientesFCon

    Private Sub ClientesFCon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Lastconection.ClientesFLast' Puede moverla o quitarla según sea necesario.
        Me.ClientesFLastTableAdapter.Fill(Me.Lastconection.ClientesFLast)
        'TODO: esta línea de código carga datos en la tabla 'PuntooriginalUltimaCF.originalNombres' Puede moverla o quitarla según sea necesario.
        Me.OriginalNombresTableAdapter.Fill(Me.PuntooriginalUltimaCF.originalNombres)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Try

            Dim conexion1 As String
            conexion1 = "Server=(local)\SQLEXPRESS;database=PuntoVenta;Integrated Security=True"
            Dim cn1 As New SqlConnection
            cn1.ConnectionString = conexion1

            Dim adaptador As New SqlDataAdapter("select fecha,codigoP,nombreP ,cantidadP ,precio,subtotal,total  from VentaF WHERE nombreC=" & txtcliente.Text & " ", cn1)
            cn1.Open()
            Dim ds As New DataSet
            adaptador.Fill(ds, "VentaF")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "VentaF"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim siguie7 As ClienteConsult = New ClienteConsult()
        siguie7.Show()

    End Sub

    Private Sub RegresarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegresarToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim total As Double = 0
        Dim fila As DataGridViewRow = New DataGridViewRow()

        For Each fila In DataGridView1.Rows
            total += Convert.ToDouble(fila.Cells("total").Value)
        Next


        lbltotal.Text = Convert.ToString(total)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Try

            Dim conexion1 As String
            conexion1 = "Server=(local)\SQLEXPRESS;database=PuntoVenta;Integrated Security=True"
            Dim cn1 As New SqlConnection
            cn1.ConnectionString = conexion1

            Dim adaptador As New SqlDataAdapter("Delete from VentaF WHERE nombreC='" & txtcliente.Text & "' ", cn1)
            cn1.Open()
            Dim ds As New DataSet

            adaptador.Fill(ds, "VentaF")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "VentaF"

            lbltotal.Text = ""

            MsgBox("Cuenta Pagada")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        DataGridView1.DrawToBitmap(bm, New Rectangle(30, 30, Me.DataGridView1.Width, Me.DataGridView1.Height))
        e.Graphics.DrawImage(bm, 0, 0)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        PrintPreviewDialog1.ShowDialog()
        PrintDocument1.Print()

    End Sub
End Class