Public Class Agranel


    Dim indice As Integer


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Agranel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblprecio.Text = Module1.precio11




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Btnagregar_Click(sender As Object, e As EventArgs) Handles Btnagregar.Click

        'Actualizar el precio
        Dim kilo As Double
        Dim quiere As Double

        Dim gramos As Double
        kilo = 1000
        quiere = TextBox1.Text
        gramos = (kilo * quiere) / precio11

        gramos = Math.Round(Convert.ToDouble(gramos), 6)
        Module1.quiere = quiere
        Module1.gramos = gramos

        Me.Close()
        'MessageBox.Show("Tiene que pesar:" & gramos, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)



    End Sub




End Class