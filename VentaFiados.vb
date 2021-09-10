Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class VentaFiados

    Dim indice As Integer

    Dim stockF1 As Integer


    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblfecha.Click

    End Sub

    Private Sub RegresarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegresarToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Suma()

    End Sub
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub


    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click

        If txtcliente.Text = "" Then
            MessageBox.Show("¡¡Falta ingresar el codigo del cliente !!", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Hand)

        Else

            Dim conexion3 As String
            conexion3 = "Server=(local)\SQLEXPRESS;database=PuntoVenta;Integrated Security=True"
            Dim cn3 As New SqlConnection
            cn3.ConnectionString = conexion3

            Dim cont As Integer = 1
            cont = cont + 1

            cn3.Open()

            For i = 0 To lstLista.Items.Count - 1
                Dim adaptador1 As New SqlCommand("insert into VentaF values(" & cont & ",'" & txtcliente.Text & "','" & MonthCalendar1.SelectionStart.Date & "',@codigoP,@nombreP,@cantidadP,@precio,@subtotal, " & lbltotal.Text & ")", cn3)
                adaptador1.Parameters.AddWithValue("@codigoP", lstLista.Items(i).SubItems(0).Text)
                adaptador1.Parameters.AddWithValue("@nombreP", lstLista.Items(i).SubItems(1).Text)
                adaptador1.Parameters.AddWithValue("@cantidadP", lstLista.Items(i).SubItems(2).Text)
                adaptador1.Parameters.AddWithValue("@precio", lstLista.Items(i).SubItems(3).Text)
                adaptador1.Parameters.AddWithValue("@subtotal", lstLista.Items(i).SubItems(4).Text)
                adaptador1.ExecuteNonQuery()
            Next
            'MessageBox.Show("La venta  fue guardada correctamente", "Guardando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MsgBox("La venta  fue guardada correctamente")
            borrarCampos()
            reiniciar()
            txtcodigo.Select()

            cn3.Close()
        End If
    End Sub


    'Metodo para borrar los campos
    Sub borrarCampos()
        txtcodigo.Text = ""
        txtnombre.Text = ""
        txtmarca.Text = ""
        txtstock.Text = ""
        txtcantidad.Text = ""
        txtprecio.Text = ""
        txtunidad.Text = ""
        txtcliente.Text = ""

    End Sub



    Sub reiniciar()

        lstLista.Items.Clear()

    End Sub


    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        If txtcodigo.Text = "" Then
            MessageBox.Show("¡¡Falta ingresar el codigo del producto !!", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Else
            Dim conexion1 As String
            conexion1 = "Server=(local)\SQLEXPRESS;database=PuntoVenta;Integrated Security=True"
            Dim cn1 As New SqlConnection
            cn1.ConnectionString = conexion1

            Dim adaptador As New SqlDataAdapter("select*from productos WHERE codigo='" & txtcodigo.Text & "' ", cn1)
            cn1.Open()
            Dim ds As New DataSet
            adaptador.Fill(ds, "datos")

            If ds.Tables("datos").Rows.Count > 0 Then
                txtnombre.Text = ds.Tables("datos").Rows(0).Item(1).ToString
                txtmarca.Text = ds.Tables("datos").Rows(0).Item(5).ToString
                txtstock.Text = ds.Tables("datos").Rows(0).Item(6).ToString
                txtprecio.Text = ds.Tables("datos").Rows(0).Item(4).ToString
                txtunidad.Text = ds.Tables("datos").Rows(0).Item(2).ToString
            Else
                MessageBox.Show("El Producto no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cn1.Close()
            End If
        End If
    End Sub

    Private Sub VentaFiados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PuntoVentaLastClient.ClientesFLast' Puede moverla o quitarla según sea necesario.
        Me.ClientesFLastTableAdapter.Fill(Me.PuntoVentaLastClient.ClientesFLast)
        'TODO: esta línea de código carga datos en la tabla 'PuntooriginalUltimaCF.originalNombres' Puede moverla o quitarla según sea necesario.
        Me.OriginalNombresTableAdapter.Fill(Me.PuntooriginalUltimaCF.originalNombres)
        'TODO: esta línea de código carga datos en la tabla 'PuntoVentaSetVistaPrueba.VistaNombresF' Puede moverla o quitarla según sea necesario.
        Me.VistaNombresFTableAdapter.Fill(Me.PuntoVentaSetVistaPrueba.VistaNombresF)
        'TODO: esta línea de código carga datos en la tabla 'PuntoVentaDataSetProceduroPrueba.ClientesF' Puede moverla o quitarla según sea necesario.
        Me.ClientesFTableAdapter2.Fill(Me.PuntoVentaDataSetProceduroPrueba.ClientesF)
        'TODO: esta línea de código carga datos en la tabla 'PuntoVentaDataSetClientesFiados.ClientesF' Puede moverla o quitarla según sea necesario.
        Me.ClientesFTableAdapter.Fill(Me.PuntoVentaDataSetClientesFiados.ClientesF)


        Dim name As String

        name = Module1.Unombre
        lblvendedor.Text = name

        txtcodigo.Select()

        lblfecha.Text = TimeOfDay()

    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click

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
        medida1 = txtunidad.Text
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

    Private Sub bnteliminar_Click(sender As Object, e As EventArgs) Handles bnteliminar.Click

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



    Private Sub Button1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim siguient8 As ClienteConsult = New ClienteConsult()
        siguient8.Show()
    End Sub

    Private Sub btnimporte_Click(sender As Object, e As EventArgs) Handles btnimporte.Click
        Dim precio As Double
        precio = Double.Parse(lstLista.Items(indice).SubItems(3).Text)

        Module1.precio11 = precio

        Dim f2 As New Agranel()
        f2.Show()

    End Sub

    Private Sub ModifiAgranel()
        Dim gram As Double
        Dim money As Double

        gram = Module1.gramos
        money = Module1.quiere

        lstLista.Items(indice).SubItems(2).Text = gram
        lstLista.Items(indice).SubItems(4).Text = money

    End Sub

    Private Sub bnguardar_Click(sender As Object, e As EventArgs) Handles bnguardar.Click
        ModifiAgranel()
    End Sub

    Private Sub btnguardar_KeyDown(sender As Object, e As KeyEventArgs) Handles btnguardar.KeyDown

    End Sub

    Private Sub buscarTo1()

        If txtcodigo.Text = "" Then
            MessageBox.Show("¡¡Falta ingresar el codigo del producto !!", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Else
            Dim conexion1 As String
            conexion1 = "Server=(local)\SQLEXPRESS;database=PuntoVenta;Integrated Security=True"
            Dim cn1 As New SqlConnection
            cn1.ConnectionString = conexion1

            Dim adaptador As New SqlDataAdapter("select*from productos WHERE codigo='" & txtcodigo.Text & "' ", cn1)
            cn1.Open()
            Dim ds As New DataSet
            adaptador.Fill(ds, "datos")

            If ds.Tables("datos").Rows.Count > 0 Then
                txtnombre.Text = ds.Tables("datos").Rows(0).Item(1).ToString
                txtmarca.Text = ds.Tables("datos").Rows(0).Item(5).ToString
                txtstock.Text = ds.Tables("datos").Rows(0).Item(6).ToString
                txtprecio.Text = ds.Tables("datos").Rows(0).Item(4).ToString
                txtunidad.Text = ds.Tables("datos").Rows(0).Item(2).ToString
            Else
                MessageBox.Show("El Producto no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cn1.Close()
            End If
        End If
    End Sub

    Private Sub Agregarfini1()

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
        medida1 = txtunidad.Text
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

    Private Sub VentaFiados_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            buscarTo1()
        End If
        If e.KeyCode = Keys.F4 Then
            Agregarfini1()
        End If

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub lbltotal_Click(sender As Object, e As EventArgs) Handles lbltotal.Click

    End Sub
End Class