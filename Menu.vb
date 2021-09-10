Public Class Menu
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        Dim clave As String
        clave = Microsoft.VisualBasic.Interaction.InputBox("Ingrese su clave de Acceso", "Seguridad", "Clave", 100, 50)

        If clave = "" Then
            MessageBox.Show("Si no conoce su clave debe pedir autorización al responsable del Punto de Venta", "Información")
            Application.Restart()
            Dim siguiente1 As MenuAdministrador = New MenuAdministrador()
            siguiente1.Show()
        ElseIf clave = "tm501" Then
            Dim siguiente1 As MenuAdministrador = New MenuAdministrador()
            siguiente1.Show()
        ElseIf clave <> "tm501" Then
            MessageBox.Show("Clave Incorrecta.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.[Stop])
            Application.Restart()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim clave As String
        Dim nombre As String

        nombre = InputBox("Ingrese Nombre", "Registro de Datos", "Nombre", 50, 50)
        Module1.Unombre = nombre
        clave = Microsoft.VisualBasic.Interaction.InputBox("Ingrese su clave de Acceso", "Seguridad", "Clave", 70, 50)
        If clave = "" Then
            MessageBox.Show("Si no conoce su clave debe pedir autorización al responsable del Punto de Venta", "Información")
            Application.Restart()
            Dim siguiente1 As Venta = New Venta()
            siguiente1.Show()
        ElseIf clave = "m027a" Then
            Dim siguiente1 As Venta = New Venta()
            siguiente1.Show()
        ElseIf clave <> "m027a" Then
            MessageBox.Show("Clave Incorrecta.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.[Stop])
            Application.Restart()
        End If


    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click

        Dim confirma As DialogResult = MessageBox.Show("¿Estás seguro de terminar el Punto de Venta?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirma = DialogResult.Yes Then Application.[Exit]()

    End Sub

    Private Sub lblhora_Click(sender As Object, e As EventArgs) Handles lblhora.Click

        lblhora.Text = TimeOfDay
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label4.Text = TimeOfDay
        Label4.Text = Date.Now

    End Sub
End Class
