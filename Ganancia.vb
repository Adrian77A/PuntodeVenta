Imports System.Data.SqlClient

Public Class Ganancia
    Private Sub RegresarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegresarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblganancia.Click

    End Sub

    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        If txttotal.Text = "" Then
            MessageBox.Show("¡¡Falta ingresar la cantidad!!", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim total As Double
            Dim gananciaF As Double
            total = txttotal.Text
            gananciaF = (total / 100) * 20
            lblganancia.Text = gananciaF
        End If
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click

        If lblganancia.Text = "" Then
            MessageBox.Show("¡¡Calcule la ganancia!!", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim conexion3 As String
            conexion3 = "Server=(local)\SQLEXPRESS;database=PuntoVenta;Integrated Security=True"
            Dim cn3 As New SqlConnection
            cn3.ConnectionString = conexion3
            Dim cont As Integer = 1
            cont = cont + 1
            Dim adaptador As New SqlCommand("insert into Ganancia values( " & cont & " ," & txttotal.Text & " , " & lblganancia.Text & "  ,'" & MonthCalendar1.SelectionStart.Date & "')", cn3)
            cn3.Open()
            adaptador.ExecuteNonQuery()
            MsgBox("La ganancia fue guardada correctamente")
            Limpiar()
        End If
    End Sub
    Private Sub Limpiar()
        txttotal.Text = ""
        lblganancia.Text = ""
    End Sub

End Class