<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentaFiados
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.RegresarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblfecha = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.bnguardar = New System.Windows.Forms.Button()
        Me.btnimporte = New System.Windows.Forms.Button()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.txtstock = New System.Windows.Forms.TextBox()
        Me.txtmarca = New System.Windows.Forms.TextBox()
        Me.txtunidad = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.bnteliminar = New System.Windows.Forms.Button()
        Me.btnactualizar = New System.Windows.Forms.Button()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtcliente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.VistaNombresFBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PuntoVentaSetVistaPrueba = New PuntoDeVenta.PuntoVentaSetVistaPrueba()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lstLista = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PuntoVentaDataSetClientesFiados = New PuntoDeVenta.PuntoVentaDataSetClientesFiados()
        Me.ClientesFBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesFTableAdapter = New PuntoDeVenta.PuntoVentaDataSetClientesFiadosTableAdapters.ClientesFTableAdapter()
        Me.PuntoVentaDataSetProductosAClientesF = New PuntoDeVenta.PuntoVentaDataSetProductosAClientesF()
        Me.ClientesFBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesFTableAdapter1 = New PuntoDeVenta.PuntoVentaDataSetProductosAClientesFTableAdapters.ClientesFTableAdapter()
        Me.PuntoVentaDataSetProceduroPrueba = New PuntoDeVenta.PuntoVentaDataSetProceduroPrueba()
        Me.ClientesFBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesFTableAdapter2 = New PuntoDeVenta.PuntoVentaDataSetProceduroPruebaTableAdapters.ClientesFTableAdapter()
        Me.VistaNombresFTableAdapter = New PuntoDeVenta.PuntoVentaSetVistaPruebaTableAdapters.VistaNombresFTableAdapter()
        Me.PuntooriginalUltimaCF = New PuntoDeVenta.PuntooriginalUltimaCF()
        Me.OriginalNombresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OriginalNombresTableAdapter = New PuntoDeVenta.PuntooriginalUltimaCFTableAdapters.originalNombresTableAdapter()
        Me.PuntoVentaLastClient = New PuntoDeVenta.PuntoVentaLastClient()
        Me.ClientesFLastBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesFLastTableAdapter = New PuntoDeVenta.PuntoVentaLastClientTableAdapters.ClientesFLastTableAdapter()
        Me.lblvendedor = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.VistaNombresFBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PuntoVentaSetVistaPrueba, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PuntoVentaDataSetClientesFiados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesFBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PuntoVentaDataSetProductosAClientesF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesFBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PuntoVentaDataSetProceduroPrueba, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesFBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PuntooriginalUltimaCF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OriginalNombresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PuntoVentaLastClient, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesFLastBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegresarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(127, 1051)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'RegresarToolStripMenuItem
        '
        Me.RegresarToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegresarToolStripMenuItem.Image = Global.PuntoDeVenta.My.Resources.Resources.icono3
        Me.RegresarToolStripMenuItem.Name = "RegresarToolStripMenuItem"
        Me.RegresarToolStripMenuItem.Size = New System.Drawing.Size(114, 32)
        Me.RegresarToolStripMenuItem.Text = "Regresar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 72.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(130, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(798, 147)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Productos Fiados"
        '
        'lblfecha
        '
        Me.lblfecha.AutoSize = True
        Me.lblfecha.Font = New System.Drawing.Font("Sitka Subheading", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfecha.Location = New System.Drawing.Point(1125, 90)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(102, 55)
        Me.lblfecha.TabIndex = 11
        Me.lblfecha.Text = "Labe"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.bnguardar)
        Me.GroupBox1.Controls.Add(Me.btnimporte)
        Me.GroupBox1.Controls.Add(Me.txtprecio)
        Me.GroupBox1.Controls.Add(Me.txtcantidad)
        Me.GroupBox1.Controls.Add(Me.txtstock)
        Me.GroupBox1.Controls.Add(Me.txtmarca)
        Me.GroupBox1.Controls.Add(Me.txtunidad)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.bnteliminar)
        Me.GroupBox1.Controls.Add(Me.btnactualizar)
        Me.GroupBox1.Controls.Add(Me.btnagregar)
        Me.GroupBox1.Controls.Add(Me.btnbuscar)
        Me.GroupBox1.Controls.Add(Me.txtcodigo)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.PictureBox4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(158, 276)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1670, 236)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar Producto"
        '
        'bnguardar
        '
        Me.bnguardar.BackColor = System.Drawing.Color.Peru
        Me.bnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bnguardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnguardar.Location = New System.Drawing.Point(528, 169)
        Me.bnguardar.Name = "bnguardar"
        Me.bnguardar.Size = New System.Drawing.Size(185, 51)
        Me.bnguardar.TabIndex = 44
        Me.bnguardar.Text = "Guardar"
        Me.bnguardar.UseVisualStyleBackColor = False
        '
        'btnimporte
        '
        Me.btnimporte.BackColor = System.Drawing.Color.Peru
        Me.btnimporte.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnimporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnimporte.Location = New System.Drawing.Point(527, 114)
        Me.btnimporte.Name = "btnimporte"
        Me.btnimporte.Size = New System.Drawing.Size(185, 51)
        Me.btnimporte.TabIndex = 43
        Me.btnimporte.Text = "Importe"
        Me.btnimporte.UseVisualStyleBackColor = False
        '
        'txtprecio
        '
        Me.txtprecio.Enabled = False
        Me.txtprecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprecio.Location = New System.Drawing.Point(855, 182)
        Me.txtprecio.Multiline = True
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(166, 42)
        Me.txtprecio.TabIndex = 28
        Me.txtprecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcantidad
        '
        Me.txtcantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcantidad.Location = New System.Drawing.Point(855, 108)
        Me.txtcantidad.Multiline = True
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(166, 42)
        Me.txtcantidad.TabIndex = 27
        Me.txtcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtstock
        '
        Me.txtstock.Enabled = False
        Me.txtstock.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstock.Location = New System.Drawing.Point(855, 43)
        Me.txtstock.Multiline = True
        Me.txtstock.Name = "txtstock"
        Me.txtstock.Size = New System.Drawing.Size(166, 42)
        Me.txtstock.TabIndex = 27
        Me.txtstock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtmarca
        '
        Me.txtmarca.Enabled = False
        Me.txtmarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmarca.Location = New System.Drawing.Point(122, 168)
        Me.txtmarca.Multiline = True
        Me.txtmarca.Name = "txtmarca"
        Me.txtmarca.Size = New System.Drawing.Size(387, 42)
        Me.txtmarca.TabIndex = 27
        Me.txtmarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtunidad
        '
        Me.txtunidad.Enabled = False
        Me.txtunidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtunidad.Location = New System.Drawing.Point(1277, 42)
        Me.txtunidad.Multiline = True
        Me.txtunidad.Name = "txtunidad"
        Me.txtunidad.Size = New System.Drawing.Size(315, 42)
        Me.txtunidad.TabIndex = 27
        Me.txtunidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtnombre
        '
        Me.txtnombre.Enabled = False
        Me.txtnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.Location = New System.Drawing.Point(122, 100)
        Me.txtnombre.Multiline = True
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(387, 42)
        Me.txtnombre.TabIndex = 26
        Me.txtnombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'bnteliminar
        '
        Me.bnteliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bnteliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnteliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bnteliminar.ForeColor = System.Drawing.Color.White
        Me.bnteliminar.Location = New System.Drawing.Point(1248, 165)
        Me.bnteliminar.Name = "bnteliminar"
        Me.bnteliminar.Size = New System.Drawing.Size(198, 59)
        Me.bnteliminar.TabIndex = 46
        Me.bnteliminar.Text = "Eliminar"
        Me.bnteliminar.UseVisualStyleBackColor = False
        '
        'btnactualizar
        '
        Me.btnactualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnactualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnactualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnactualizar.Font = New System.Drawing.Font("Lucida Bright", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnactualizar.Location = New System.Drawing.Point(1248, 90)
        Me.btnactualizar.Name = "btnactualizar"
        Me.btnactualizar.Size = New System.Drawing.Size(198, 61)
        Me.btnactualizar.TabIndex = 45
        Me.btnactualizar.Text = "Actualizar"
        Me.btnactualizar.UseVisualStyleBackColor = False
        '
        'btnagregar
        '
        Me.btnagregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnagregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnagregar.Location = New System.Drawing.Point(1053, 89)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(171, 135)
        Me.btnagregar.TabIndex = 45
        Me.btnagregar.Text = "+Agregar"
        Me.btnagregar.UseVisualStyleBackColor = False
        '
        'btnbuscar
        '
        Me.btnbuscar.BackColor = System.Drawing.Color.Transparent
        Me.btnbuscar.BackgroundImage = Global.PuntoDeVenta.My.Resources.Resources.lupa
        Me.btnbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnbuscar.ForeColor = System.Drawing.Color.Transparent
        Me.btnbuscar.Location = New System.Drawing.Point(527, 37)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(185, 71)
        Me.btnbuscar.TabIndex = 44
        Me.btnbuscar.UseVisualStyleBackColor = False
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(164, 36)
        Me.txtcodigo.MaxLength = 13
        Me.txtcodigo.Multiline = True
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.ShortcutsEnabled = False
        Me.txtcodigo.Size = New System.Drawing.Size(345, 40)
        Me.txtcodigo.TabIndex = 40
        Me.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("NSimSun", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(1060, 48)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(208, 28)
        Me.Label14.TabIndex = 36
        Me.Label14.Text = "UnidadDeMedida"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("NSimSun", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(757, 188)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 28)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Precio"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("NSimSun", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(729, 114)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 28)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Cantidad"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("NSimSun", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(757, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 28)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Stock"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.PuntoDeVenta.My.Resources.Resources.codigo_de_barras
        Me.PictureBox4.Location = New System.Drawing.Point(122, 37)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(45, 39)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 39
        Me.PictureBox4.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("NSimSun", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(34, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 28)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Marca"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("NSimSun", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 28)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Bright", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 28)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Codigo"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.txtcliente)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(158, 148)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1034, 111)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Elegir Cliente"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(734, 34)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(167, 51)
        Me.Button1.TabIndex = 42
        Me.Button1.Text = "Elegir"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtcliente
        '
        Me.txtcliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcliente.Location = New System.Drawing.Point(472, 33)
        Me.txtcliente.Multiline = True
        Me.txtcliente.Name = "txtcliente"
        Me.txtcliente.Size = New System.Drawing.Size(240, 52)
        Me.txtcliente.TabIndex = 41
        Me.txtcliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("NSimSun", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(432, 28)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Ingrese el codigo del cliente:"
        '
        'VistaNombresFBindingSource
        '
        Me.VistaNombresFBindingSource.DataMember = "VistaNombresF"
        Me.VistaNombresFBindingSource.DataSource = Me.PuntoVentaSetVistaPrueba
        '
        'PuntoVentaSetVistaPrueba
        '
        Me.PuntoVentaSetVistaPrueba.DataSetName = "PuntoVentaSetVistaPrueba"
        Me.PuntoVentaSetVistaPrueba.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Enabled = False
        Me.MonthCalendar1.Location = New System.Drawing.Point(1612, 9)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 16
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("NSimSun", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(1499, 575)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(280, 80)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Total:"
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnguardar.Font = New System.Drawing.Font("Baskerville Old Face", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.Location = New System.Drawing.Point(1432, 885)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(404, 80)
        Me.btnguardar.TabIndex = 29
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 54.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbltotal.Location = New System.Drawing.Point(1540, 695)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(93, 102)
        Me.lbltotal.TabIndex = 38
        Me.lbltotal.Text = "0"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'lstLista
        '
        Me.lstLista.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.lstLista.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstLista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lstLista.Font = New System.Drawing.Font("Sitka Text", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstLista.FullRowSelect = True
        Me.lstLista.GridLines = True
        Me.lstLista.HideSelection = False
        Me.lstLista.Location = New System.Drawing.Point(151, 518)
        Me.lstLista.Name = "lstLista"
        Me.lstLista.Size = New System.Drawing.Size(1275, 388)
        Me.lstLista.TabIndex = 39
        Me.lstLista.UseCompatibleStateImageBehavior = False
        Me.lstLista.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Codigo"
        Me.ColumnHeader1.Width = 184
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nombre"
        Me.ColumnHeader2.Width = 213
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Cantidad(Ud/g)"
        Me.ColumnHeader3.Width = 241
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Precio"
        Me.ColumnHeader4.Width = 195
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Subtotal"
        Me.ColumnHeader5.Width = 159
        '
        'PuntoVentaDataSetClientesFiados
        '
        Me.PuntoVentaDataSetClientesFiados.DataSetName = "PuntoVentaDataSetClientesFiados"
        Me.PuntoVentaDataSetClientesFiados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesFBindingSource
        '
        Me.ClientesFBindingSource.DataMember = "ClientesF"
        Me.ClientesFBindingSource.DataSource = Me.PuntoVentaDataSetClientesFiados
        '
        'ClientesFTableAdapter
        '
        Me.ClientesFTableAdapter.ClearBeforeFill = True
        '
        'PuntoVentaDataSetProductosAClientesF
        '
        Me.PuntoVentaDataSetProductosAClientesF.DataSetName = "PuntoVentaDataSetProductosAClientesF"
        Me.PuntoVentaDataSetProductosAClientesF.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesFBindingSource1
        '
        Me.ClientesFBindingSource1.DataMember = "ClientesF"
        Me.ClientesFBindingSource1.DataSource = Me.PuntoVentaDataSetProductosAClientesF
        '
        'ClientesFTableAdapter1
        '
        Me.ClientesFTableAdapter1.ClearBeforeFill = True
        '
        'PuntoVentaDataSetProceduroPrueba
        '
        Me.PuntoVentaDataSetProceduroPrueba.DataSetName = "PuntoVentaDataSetProceduroPrueba"
        Me.PuntoVentaDataSetProceduroPrueba.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesFBindingSource2
        '
        Me.ClientesFBindingSource2.DataMember = "ClientesF"
        Me.ClientesFBindingSource2.DataSource = Me.PuntoVentaDataSetProceduroPrueba
        '
        'ClientesFTableAdapter2
        '
        Me.ClientesFTableAdapter2.ClearBeforeFill = True
        '
        'VistaNombresFTableAdapter
        '
        Me.VistaNombresFTableAdapter.ClearBeforeFill = True
        '
        'PuntooriginalUltimaCF
        '
        Me.PuntooriginalUltimaCF.DataSetName = "PuntooriginalUltimaCF"
        Me.PuntooriginalUltimaCF.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OriginalNombresBindingSource
        '
        Me.OriginalNombresBindingSource.DataMember = "originalNombres"
        Me.OriginalNombresBindingSource.DataSource = Me.PuntooriginalUltimaCF
        '
        'OriginalNombresTableAdapter
        '
        Me.OriginalNombresTableAdapter.ClearBeforeFill = True
        '
        'PuntoVentaLastClient
        '
        Me.PuntoVentaLastClient.DataSetName = "PuntoVentaLastClient"
        Me.PuntoVentaLastClient.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesFLastBindingSource
        '
        Me.ClientesFLastBindingSource.DataMember = "ClientesFLast"
        Me.ClientesFLastBindingSource.DataSource = Me.PuntoVentaLastClient
        '
        'ClientesFLastTableAdapter
        '
        Me.ClientesFLastTableAdapter.ClearBeforeFill = True
        '
        'lblvendedor
        '
        Me.lblvendedor.AutoSize = True
        Me.lblvendedor.Font = New System.Drawing.Font("Sitka Subheading", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvendedor.Location = New System.Drawing.Point(1223, 19)
        Me.lblvendedor.Name = "lblvendedor"
        Me.lblvendedor.Size = New System.Drawing.Size(102, 55)
        Me.lblvendedor.TabIndex = 40
        Me.lblvendedor.Text = "Labe"
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.No
        Me.PictureBox2.Image = Global.PuntoDeVenta.My.Resources.Resources.icono7
        Me.PictureBox2.Location = New System.Drawing.Point(1410, 0)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(114, 97)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1078, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 29)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Cajero:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 54.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(1441, 695)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 102)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "$"
        '
        'VentaFiados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(1920, 1051)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblvendedor)
        Me.Controls.Add(Me.lstLista)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lblfecha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "VentaFiados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Venta Productos Fiados"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.VistaNombresFBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PuntoVentaSetVistaPrueba, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PuntoVentaDataSetClientesFiados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesFBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PuntoVentaDataSetProductosAClientesF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesFBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PuntoVentaDataSetProceduroPrueba, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesFBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PuntooriginalUltimaCF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OriginalNombresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PuntoVentaLastClient, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesFLastBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents RegresarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents lblfecha As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents btnbuscar As Button
    Friend WithEvents btnagregar As Button
    Friend WithEvents btnactualizar As Button
    Friend WithEvents bnteliminar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtunidad As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtmarca As TextBox
    Friend WithEvents txtprecio As TextBox
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents txtstock As TextBox
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Label11 As Label
    Friend WithEvents btnguardar As Button
    Friend WithEvents lbltotal As Label
    Friend WithEvents Timer1 As Timer
    Public WithEvents lstLista As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents PuntoVentaDataSetClientesFiados As PuntoVentaDataSetClientesFiados
    Friend WithEvents ClientesFBindingSource As BindingSource
    Friend WithEvents ClientesFTableAdapter As PuntoVentaDataSetClientesFiadosTableAdapters.ClientesFTableAdapter
    Friend WithEvents PuntoVentaDataSetProductosAClientesF As PuntoVentaDataSetProductosAClientesF
    Friend WithEvents ClientesFBindingSource1 As BindingSource
    Friend WithEvents ClientesFTableAdapter1 As PuntoVentaDataSetProductosAClientesFTableAdapters.ClientesFTableAdapter
    Friend WithEvents PuntoVentaDataSetProceduroPrueba As PuntoVentaDataSetProceduroPrueba
    Friend WithEvents ClientesFBindingSource2 As BindingSource
    Friend WithEvents ClientesFTableAdapter2 As PuntoVentaDataSetProceduroPruebaTableAdapters.ClientesFTableAdapter
    Friend WithEvents PuntoVentaSetVistaPrueba As PuntoVentaSetVistaPrueba
    Friend WithEvents VistaNombresFBindingSource As BindingSource
    Friend WithEvents VistaNombresFTableAdapter As PuntoVentaSetVistaPruebaTableAdapters.VistaNombresFTableAdapter
    Friend WithEvents PuntooriginalUltimaCF As PuntooriginalUltimaCF
    Friend WithEvents OriginalNombresBindingSource As BindingSource
    Friend WithEvents OriginalNombresTableAdapter As PuntooriginalUltimaCFTableAdapters.originalNombresTableAdapter
    Friend WithEvents PuntoVentaLastClient As PuntoVentaLastClient
    Friend WithEvents ClientesFLastBindingSource As BindingSource
    Friend WithEvents ClientesFLastTableAdapter As PuntoVentaLastClientTableAdapters.ClientesFLastTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents txtcliente As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents bnguardar As Button
    Friend WithEvents btnimporte As Button
    Friend WithEvents lblvendedor As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
End Class
