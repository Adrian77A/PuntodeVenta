Imports System.Data.SqlClient

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports WL




Public Class Venta


    Dim indice As Integer

    Dim stockF1 As Integer


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim name As String

        name = Module1.Unombre
        lblnameC.Text = name
        MessageBox.Show("Bienvenido Cajero: " & name, "Registro de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtcodigo.Select()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RegresarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegresarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim siguiente As Envases = New Envases()
        siguiente.Show()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ButtonCobrar.Click
        If CheckedListBox1.Text = "" Then
            MessageBox.Show("¡¡Falta ingresar el tipo de Pago !!", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim conexion3 As String
            conexion3 = "Server=(local)\SQLEXPRESS;database=PuntoVenta;Integrated Security=True"
            Dim cn3 As New SqlConnection
            cn3.ConnectionString = conexion3

            Dim cont As Integer = 1
            cont = cont + 1

            CheckedListBox1.Text = ""
            Dim adaptador As New SqlCommand("insert into Venta values( " & cont & " , '" & MonthCalendar1.SelectionStart.Date & "'," & lbltotal.Text & ",'" & txtpago.Text & "','" & CheckedListBox1.Text & "','" & lblpage.Text & "')", cn3)
            cn3.Open()
            adaptador.ExecuteNonQuery()
            'MessageBox.Show("La venta  fue guardada correctamente", "Guardando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)

            For i = 0 To lstLista.Items.Count - 1
                Dim adaptador1 As New SqlCommand("insert into Vdetalle values(" & cont & ",'" & MonthCalendar1.SelectionStart.Date & "',@codigo,@nombre,@cantidad,@precio,@subtotal)", cn3)
                adaptador1.Parameters.AddWithValue("@codigo", lstLista.Items(i).SubItems(0).Text)
                adaptador1.Parameters.AddWithValue("@nombre", lstLista.Items(i).SubItems(1).Text)
                adaptador1.Parameters.AddWithValue("@cantidad", lstLista.Items(i).SubItems(2).Text)
                adaptador1.Parameters.AddWithValue("@precio", lstLista.Items(i).SubItems(3).Text)
                adaptador1.Parameters.AddWithValue("@subtotal", lstLista.Items(i).SubItems(4).Text)
                adaptador1.ExecuteNonQuery()
            Next
            ImpresionT()
            MsgBox("La venta  fue guardada correctamente")
            borrarCampos()
            reiniciar()
            txtcodigo.Select()
            lblcambio1.Text = ""
            lblpage.Text = ""

            cn3.Close()
        End If

    End Sub

    Sub ImpresionT()
        PrintDialog1.Document = PrintDocument1
        PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings


        PrintDialog1.AllowSomePages = True

        If PrintDialog1.ShowDialog = DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            PrintDocument1.Print()

        End If
        'With PrintDocument1
        '.PrinterSettings.DefaultPageSettings.Landscape = False
        '.Print()


        'End With

    End Sub
    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged

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
                txtmarca.Text = ds.Tables("datos").Rows(0).Item(5).ToString
                txtstock.Text = ds.Tables("datos").Rows(0).Item(6).ToString
                txtprecio.Text = ds.Tables("datos").Rows(0).Item(4).ToString
                txtmedida.Text = ds.Tables("datos").Rows(0).Item(2).ToString
            Else
                MessageBox.Show("El Producto no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cn1.Close()
            End If
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub txtmarca_TextChanged(sender As Object, e As EventArgs) Handles txtmarca.TextChanged

    End Sub

    Private Sub txtpago_TextChanged(sender As Object, e As EventArgs) Handles txtpago.TextChanged

    End Sub

    Private Sub txtcambio_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtsubtotal_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles lbldate.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        lbldate.Text = TimeOfDay()
        lbldate.Text = Date.Now()

        Suma()

    End Sub

    Private Sub ButtonAgregar_Click(sender As Object, e As EventArgs) Handles ButtonAgregar.Click

        Dim codigo As Long
        Dim nombre As String
        Dim cantidadP1 As Integer
        Dim stock As Integer
        Dim precio As Double
        Dim subtotalT As Double
        Dim medida1 As String
        Dim medo1 As String

        codigo = txtcodigo.Text
        nombre = txtnombre.Text
        cantidadP1 = txtcantidad.Text
        stock = txtstock.Text
        medida1 = txtmedida.Text
        precio = txtprecio.Text
        medo1 = "Agranel"

        subtotalT = precio * cantidadP1
        stockF1 = stock
        If cantidadP1 <= stock Then
            'Para agregar los productos

            With lstLista.Items.Add(codigo)
                .SubItems.Add(nombre)
                .SubItems.Add(cantidadP1)
                .SubItems.Add(precio)
                .SubItems.Add(subtotalT)
            End With
            actualizarstock()
            borrarCampos()
            txtcodigo.Select()
        Else
            MessageBox.Show("La cantidad de producto es mayor al Stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)


        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtmedida.TextChanged

    End Sub


    'Metodo para borrar los campos
    Sub borrarCampos()
        txtcodigo.Text = ""
        txtnombre.Text = ""
        txtmarca.Text = ""
        txtstock.Text = ""
        txtcantidad.Text = ""
        txtprecio.Text = ""
        txtmedida.Text = ""

    End Sub


    Sub reiniciar()

        lstLista.Items.Clear()
        lblcambio.Text = ""
        txtpago.Text = ""

    End Sub

    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click

        Dim subtotalT As Double
        Dim precio As Double
        Dim cantidadP1 As Integer
        cantidadP1 = txtcantidad.Text
        precio = txtprecio.Text

        subtotalT = precio * cantidadP1

        'Pasamos los valores de la caja de texto
        lstLista.Items(indice).SubItems(0).Text = txtcodigo.Text
        lstLista.Items(indice).SubItems(1).Text = txtnombre.Text


        lstLista.Items(indice).SubItems(2).Text = txtcantidad.Text
        lstLista.Items(indice).SubItems(3).Text = txtprecio.Text


        lstLista.Items(indice).SubItems(4).Text = subtotalT

        'No la he probado
        actualizarstock()
        borrarCampos()

    End Sub

    Private Sub ModifiAgranel()

        Dim gram As Double
        Dim money As Double
        Dim codigo As Long
        Dim stock As Double

        gram = Module1.gramos
        money = Module1.quiere

        lstLista.Items(indice).SubItems(2).Text = gram
        lstLista.Items(indice).SubItems(4).Text = money
        stock = txtstock.Text
        codigo = txtcodigo.Text

        Dim conexion1 As String
        conexion1 = "Server=(local)\SQLEXPRESS;database=PuntoVenta;Integrated Security=True"
        Dim cn1 As New SqlConnection
        cn1.ConnectionString = conexion1
        stock -= gram
        Dim adaptador1 As New SqlCommand("update productos set stock=" & stock & " where codigo ='" & txtcodigo.Text & "'", cn1)
        cn1.Open()
        adaptador1.ExecuteNonQuery()
        MsgBox("El producto fue agregado")
        cn1.Close()
        borrarCampos()
    End Sub

    Private Sub lstLista_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstLista.SelectedIndexChanged
        'Obtener el indice de la fila seleccionada

        indice = lstLista.FocusedItem.Index

        'Obtenemos los datos de la fila seleccionada
        Dim codigo As Long
        Dim nombre As String
        Dim cantidadP As Integer
        Dim precio As Double


        If (indice >= 0) Then

            codigo = Long.Parse(lstLista.Items(indice).SubItems(0).Text)
        nombre = lstLista.Items(indice).SubItems(1).Text
        cantidadP = Integer.Parse(lstLista.Items(indice).SubItems(2).Text)
        precio = Double.Parse(lstLista.Items(indice).SubItems(3).Text)


            'Pasarlos a las cajas de texto
            txtcodigo.Text = codigo
            txtnombre.Text = nombre
            txtcantidad.Text = cantidadP
            txtprecio.Text = precio
            txtstock.Text = stockF1

        End If

    End Sub

    Private Sub btactuali_Click(sender As Object, e As EventArgs) Handles btactuali.Click

        'Eliminar fila
        lstLista.Items.RemoveAt(indice)
        indice = -1
        eliminarstock()
        borrarCampos()

    End Sub

    Private Sub Suma()
        Dim suma As Double
        Dim i As Integer
        suma = 0
        For i = 0 To lstLista.Items.Count - 1
            suma = suma +
                CDbl(lstLista.Items(i).SubItems(4).Text)
        Next
        lbltotal.Text = suma

    End Sub

    Private Sub Cambio()
        Dim pago As Double
        Dim cambio As Double
        Dim suma As Double
        suma = lbltotal.Text
        pago = txtpago.Text

        cambio = pago - suma
        lblpage.Text = cambio
    End Sub

    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonCancelar.Click

        If txtpago.Text = "" Then
            MessageBox.Show("Ingrese la cantidad que pago", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Cambio()
        End If

    End Sub

    Private Sub bntagranel_Click(sender As Object, e As EventArgs)

        Dim siguientea As Agranel = New Agranel()
        siguientea.Show()

    End Sub

    Private Sub Venta_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            buscarTo()
        End If
        If e.KeyCode = Keys.F2 Then
            Agregarfini()
        End If
    End Sub

    Private Sub buscarTo()
        If txtcodigo.Text = "" Then
            MessageBox.Show("¡¡Falta ingresar el codigo del producto !!", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Else
            Dim conexion1 As String
            conexion1 = "Server=(local)\SQLEXPRESS;database=PuntoVenta;Integrated Security=True"
            Dim cn1 As New SqlConnection
            cn1.ConnectionString = conexion1
            Dim adaptador As New SqlDataAdapter("select*from productos WHERE codigo='" & txtcodigo.Text & " '", cn1)
            cn1.Open()
            Dim ds As New DataSet
            adaptador.Fill(ds, "datos")

            If ds.Tables("datos").Rows.Count > 0 Then
                txtnombre.Text = ds.Tables("datos").Rows(0).Item(1).ToString
                txtmarca.Text = ds.Tables("datos").Rows(0).Item(5).ToString
                txtstock.Text = ds.Tables("datos").Rows(0).Item(6).ToString
                txtprecio.Text = ds.Tables("datos").Rows(0).Item(4).ToString
                txtmedida.Text = ds.Tables("datos").Rows(0).Item(2).ToString
            Else
                MessageBox.Show("El Producto no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cn1.Close()
            End If
        End If
    End Sub

    Private Sub Agregarfini()

        Dim codigo As Long
        Dim nombre As String
        Dim cantidadP1 As Integer
        Dim stock As Integer
        Dim precio As Double
        Dim subtotalT As Double
        Dim medida1 As String
        Dim medo1 As String

        codigo = txtcodigo.Text
        nombre = txtnombre.Text
        cantidadP1 = txtcantidad.Text
        stock = txtstock.Text
        medida1 = txtmedida.Text
        precio = txtprecio.Text
        medo1 = "Agranel"

        subtotalT = precio * cantidadP1
        stockF1 = stock
        If cantidadP1 <= stock Then
            'Para agregar los productos

            With lstLista.Items.Add(codigo)
                .SubItems.Add(nombre)
                .SubItems.Add(cantidadP1)
                .SubItems.Add(precio)
                .SubItems.Add(subtotalT)

            End With
            actualizarstock()
            borrarCampos()

        Else
            MessageBox.Show("La cantidad de producto es mayor al Stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub actualizarstock()


        Dim codigo As Long
        Dim cantidadP1 As Integer
        Dim stock As Integer

        stock = txtstock.Text
        codigo = txtcodigo.Text
        cantidadP1 = txtcantidad.Text


        Dim conexion1 As String
        conexion1 = "Server=(local)\SQLEXPRESS;database=PuntoVenta;Integrated Security=True"
        Dim cn1 As New SqlConnection
        cn1.ConnectionString = conexion1
        stock -= cantidadP1

        Dim adaptador1 As New SqlCommand("update productos set stock=" & stock & " where codigo ='" & txtcodigo.Text & "'", cn1)
        cn1.Open()

        adaptador1.ExecuteNonQuery()
        'MessageBox.Show("Producto fue actualizado correctamente", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

        cn1.Close()

    End Sub


    Private Sub eliminarstock()

        Dim conexion1 As String
        conexion1 = "Server=(local)\SQLEXPRESS;database=PuntoVenta;Integrated Security=True"
        Dim cn1 As New SqlConnection
        cn1.ConnectionString = conexion1

        Dim adaptador1 As New SqlCommand("update productos set stock=" & stockF1 & " where codigo ='" & txtcodigo.Text & "'", cn1)
        cn1.Open()

        adaptador1.ExecuteNonQuery()
        MessageBox.Show("Producto fue Eliminado Correctamente", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

        cn1.Close()


    End Sub

    Private Sub btnfiados_Click(sender As Object, e As EventArgs) Handles btnfiados.Click


        Dim siguiente3 As VentaFiados = New VentaFiados()
        siguiente3.Show()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim precio As Double
        precio = Double.Parse(lstLista.Items(indice).SubItems(3).Text)

        Module1.precio11 = precio

        Dim f2 As New Agranel()
        f2.Show()

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        ModifiAgranel()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub lbltotal_Click(sender As Object, e As EventArgs) Handles lbltotal.Click

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtcodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcodigo.KeyPress

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim H As Integer = 0
        Dim name As String
        name = Module1.Unombre
        lblnameC.Text = name

        Dim cambio As Double
        Dim efectivo1 As Double
        Dim Total As Double
        Dim otros As Double

        Total = lbltotal.Text
        efectivo1 = txtpago.Text
        cambio = lblpage.Text
        otros = 0


        H = 40
        e.Graphics.DrawString("Super 'Cami'", New Drawing.Font("Lucida Handwriting", 16), Brushes.Black, 0, H)
        H += 30


        e.Graphics.DrawString("--------------------------------------------------------", New Drawing.Font("Times New Roman", 10), Brushes.Black, 1, H)
        H += 30

        e.Graphics.DrawString("Sucursal:01  Multifamiliar 3 L4", New Drawing.Font("Times New Roman", 10), Brushes.Black, 0, H)
        H += 20


        e.Graphics.DrawString("Centro, C.P.43990,Sahagún,Hgo.", New Drawing.Font("Times New Roman", 10), Brushes.Black, 0, H)
        H += 20


        e.Graphics.DrawString("Caja: 01  Vendedor: " & name, New Drawing.Font("Times New Roman", 10), Brushes.Black, 0, H)
        H += 20

        e.Graphics.DrawString("Producto  Cantidad  Precio", New Drawing.Font("Times New Roman", 10), Brushes.Black, 1, H)
        H += 20


        e.Graphics.DrawString("--------------------------------------------------------", New Drawing.Font("Times New Roman", 10), Brushes.Black, 1, H)
        H += 10

        For i = 0 To lstLista.Items.Count - 1

            e.Graphics.DrawString(lstLista.Items(i).SubItems(1).Text, New Drawing.Font("Times New Roman", 10), Brushes.Black, 1, H)

            'e.Graphics.DrawString(lstLista.Items(i).SubItems(0).Text, New Drawing.Font("Times New Roman", 10), Brushes.Black, 100, H)

            e.Graphics.DrawString(lstLista.Items(i).SubItems(2).Text, New Drawing.Font("Times New Roman", 10), Brushes.Black, 100, H)

            e.Graphics.DrawString("$" & lstLista.Items(i).SubItems(3).Text, New Drawing.Font("Times New Roman", 10), Brushes.Black, 120, H)

            H += 20
        Next

        e.Graphics.DrawString("--------------------------------------------------------", New Drawing.Font("Times New Roman", 10), Brushes.Black, 1, H)
        H += 20

        e.Graphics.DrawString("TOTAL    ---->", New Drawing.Font("Times New Roman", 10), Brushes.Black, 0, H)
        e.Graphics.DrawString("$" & Total, New Drawing.Font("Times New Roman", 10), Brushes.Black, 120, H)
        H += 20

        e.Graphics.DrawString("EFECTIVO ---->", New Drawing.Font("Times New Roman", 10), Brushes.Black, 0, H)
        e.Graphics.DrawString("$" & efectivo1, New Drawing.Font("Times New Roman", 10), Brushes.Black, 120, H)
        H += 20


        e.Graphics.DrawString("OTROS    ---->", New Drawing.Font("Times New Roman", 10), Brushes.Black, 0, H)
        e.Graphics.DrawString("$" & otros, New Drawing.Font("Times New Roman", 10), Brushes.Black, 120, H)
        H += 20

        e.Graphics.DrawString("CAMBIO   ---->", New Drawing.Font("Times New Roman", 10), Brushes.Black, 0, H)
        e.Graphics.DrawString("$" & cambio, New Drawing.Font("Times New Roman", 10), Brushes.Black, 120, H)
        H += 20

        e.Graphics.DrawString(Date.Now(), New Drawing.Font("Times New Roman", 10), Brushes.Black, 41, H)
        H += 20
        e.Graphics.DrawString("¡GRACIAS POR SU PREFERENCIA!", New Drawing.Font("Gloucester MT", 8), Brushes.Black, 0, H)
        H += 20


        e.Graphics.DrawString(" NO FISCAL ", New Drawing.Font("Times New Roman", 9), Brushes.Black, 65, H)
        H += 20
    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged

    End Sub
End Class