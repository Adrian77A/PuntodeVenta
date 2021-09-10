<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Venta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Venta))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.RegresarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.ButtonCancelar = New System.Windows.Forms.Button()
        Me.ButtonAgregar = New System.Windows.Forms.Button()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btactuali = New System.Windows.Forms.Button()
        Me.btnactualizar = New System.Windows.Forms.Button()
        Me.txtmedida = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtstock = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtmarca = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ButtonBuscar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtpago = New System.Windows.Forms.TextBox()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lstLista = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblcambio = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.btnfiados = New System.Windows.Forms.Button()
        Me.lblname = New System.Windows.Forms.Label()
        Me.lblcambio1 = New System.Windows.Forms.Label()
        Me.lblnameC = New System.Windows.Forms.Label()
        Me.lblpage = New System.Windows.Forms.Label()
        Me.ButtonCobrar = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("SimSun", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(1376, 95)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 30)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Cajero:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegresarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1924, 40)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'RegresarToolStripMenuItem
        '
        Me.RegresarToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegresarToolStripMenuItem.Image = Global.PuntoDeVenta.My.Resources.Resources.icono3
        Me.RegresarToolStripMenuItem.Name = "RegresarToolStripMenuItem"
        Me.RegresarToolStripMenuItem.Size = New System.Drawing.Size(140, 36)
        Me.RegresarToolStripMenuItem.Text = "Regresar"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(1064, 49)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 88)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Prestar Envase"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Bright", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 28)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Codigo"
        '
        'txtcodigo
        '
        Me.txtcodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigo.Location = New System.Drawing.Point(149, 53)
        Me.txtcodigo.MaxLength = 13
        Me.txtcodigo.Multiline = True
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.ShortcutsEnabled = False
        Me.txtcodigo.Size = New System.Drawing.Size(296, 38)
        Me.txtcodigo.TabIndex = 14
        Me.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ButtonCancelar
        '
        Me.ButtonCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonCancelar.Font = New System.Drawing.Font("Microsoft Tai Le", 18.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCancelar.Location = New System.Drawing.Point(921, 907)
        Me.ButtonCancelar.Name = "ButtonCancelar"
        Me.ButtonCancelar.Size = New System.Drawing.Size(280, 94)
        Me.ButtonCancelar.TabIndex = 16
        Me.ButtonCancelar.Text = "Cambio"
        Me.ButtonCancelar.UseVisualStyleBackColor = False
        '
        'ButtonAgregar
        '
        Me.ButtonAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonAgregar.Font = New System.Drawing.Font("Microsoft Tai Le", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAgregar.Location = New System.Drawing.Point(993, 109)
        Me.ButtonAgregar.Name = "ButtonAgregar"
        Me.ButtonAgregar.Size = New System.Drawing.Size(201, 102)
        Me.ButtonAgregar.TabIndex = 18
        Me.ButtonAgregar.Text = "+Agregar"
        Me.ButtonAgregar.UseVisualStyleBackColor = False
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.CheckedListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Items.AddRange(New Object() {"Efectivo", "Tarjeta"})
        Me.CheckedListBox1.Location = New System.Drawing.Point(962, 819)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(190, 62)
        Me.CheckedListBox1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(874, 784)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(196, 32)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Tipo de Pago"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.PictureBox4)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.btactuali)
        Me.GroupBox1.Controls.Add(Me.btnactualizar)
        Me.GroupBox1.Controls.Add(Me.txtmedida)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtprecio)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtcantidad)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtstock)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtmarca)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ButtonBuscar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtcodigo)
        Me.GroupBox1.Controls.Add(Me.ButtonAgregar)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(119, 159)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1439, 219)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar Producto"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Peru
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(451, 155)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(196, 59)
        Me.Button3.TabIndex = 41
        Me.Button3.Text = "Guardar"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.PuntoDeVenta.My.Resources.Resources.codigo_de_barras
        Me.PictureBox4.Location = New System.Drawing.Point(106, 52)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(45, 39)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 38
        Me.PictureBox4.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Peru
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(451, 97)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(196, 54)
        Me.Button2.TabIndex = 40
        Me.Button2.Text = "Importe"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btactuali
        '
        Me.btactuali.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btactuali.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btactuali.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btactuali.Font = New System.Drawing.Font("Lucida Bright", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btactuali.ForeColor = System.Drawing.Color.White
        Me.btactuali.Location = New System.Drawing.Point(1217, 161)
        Me.btactuali.Name = "btactuali"
        Me.btactuali.Size = New System.Drawing.Size(168, 48)
        Me.btactuali.TabIndex = 37
        Me.btactuali.Text = "Eliminar"
        Me.btactuali.UseVisualStyleBackColor = False
        '
        'btnactualizar
        '
        Me.btnactualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnactualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnactualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnactualizar.Font = New System.Drawing.Font("Lucida Bright", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnactualizar.Location = New System.Drawing.Point(1217, 109)
        Me.btnactualizar.Name = "btnactualizar"
        Me.btnactualizar.Size = New System.Drawing.Size(168, 48)
        Me.btnactualizar.TabIndex = 36
        Me.btnactualizar.Text = "Actualizar"
        Me.btnactualizar.UseVisualStyleBackColor = False
        '
        'txtmedida
        '
        Me.txtmedida.Enabled = False
        Me.txtmedida.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmedida.Location = New System.Drawing.Point(1181, 44)
        Me.txtmedida.Multiline = True
        Me.txtmedida.Name = "txtmedida"
        Me.txtmedida.Size = New System.Drawing.Size(230, 42)
        Me.txtmedida.TabIndex = 35
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("NSimSun", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(957, 50)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(208, 28)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "UnidadDeMedida"
        '
        'txtprecio
        '
        Me.txtprecio.Enabled = False
        Me.txtprecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprecio.Location = New System.Drawing.Point(792, 163)
        Me.txtprecio.Multiline = True
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(159, 42)
        Me.txtprecio.TabIndex = 34
        Me.txtprecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("NSimSun", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(671, 177)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 28)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Precio"
        '
        'txtcantidad
        '
        Me.txtcantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcantidad.Location = New System.Drawing.Point(792, 109)
        Me.txtcantidad.Multiline = True
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(159, 42)
        Me.txtcantidad.TabIndex = 26
        Me.txtcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("NSimSun", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(662, 120)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 28)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Cantidad"
        '
        'txtstock
        '
        Me.txtstock.BackColor = System.Drawing.SystemColors.Info
        Me.txtstock.Enabled = False
        Me.txtstock.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstock.Location = New System.Drawing.Point(792, 54)
        Me.txtstock.Multiline = True
        Me.txtstock.Name = "txtstock"
        Me.txtstock.Size = New System.Drawing.Size(159, 42)
        Me.txtstock.TabIndex = 25
        Me.txtstock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("NSimSun", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(662, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 28)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Stock"
        '
        'txtmarca
        '
        Me.txtmarca.Enabled = False
        Me.txtmarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmarca.Location = New System.Drawing.Point(130, 157)
        Me.txtmarca.Multiline = True
        Me.txtmarca.Name = "txtmarca"
        Me.txtmarca.Size = New System.Drawing.Size(315, 42)
        Me.txtmarca.TabIndex = 25
        Me.txtmarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("NSimSun", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(29, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 28)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Marca"
        '
        'txtnombre
        '
        Me.txtnombre.Enabled = False
        Me.txtnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.Location = New System.Drawing.Point(130, 106)
        Me.txtnombre.Multiline = True
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(315, 42)
        Me.txtnombre.TabIndex = 25
        Me.txtnombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("NSimSun", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 28)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Nombre"
        '
        'ButtonBuscar
        '
        Me.ButtonBuscar.BackColor = System.Drawing.Color.Transparent
        Me.ButtonBuscar.BackgroundImage = Global.PuntoDeVenta.My.Resources.Resources.lupa
        Me.ButtonBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonBuscar.Font = New System.Drawing.Font("Microsoft Tai Le", 16.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBuscar.ForeColor = System.Drawing.Color.Transparent
        Me.ButtonBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonBuscar.Location = New System.Drawing.Point(451, 13)
        Me.ButtonBuscar.Name = "ButtonBuscar"
        Me.ButtonBuscar.Size = New System.Drawing.Size(196, 78)
        Me.ButtonBuscar.TabIndex = 12
        Me.ButtonBuscar.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("NSimSun", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(1578, 444)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(180, 60)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Total"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("NSimSun", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(1166, 816)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(147, 28)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Pago con:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("NSimSun", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(1243, 913)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(117, 28)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Cambio:"
        '
        'txtpago
        '
        Me.txtpago.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtpago.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtpago.Font = New System.Drawing.Font("Rockwell", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpago.Location = New System.Drawing.Point(1319, 794)
        Me.txtpago.Multiline = True
        Me.txtpago.Name = "txtpago"
        Me.txtpago.Size = New System.Drawing.Size(261, 68)
        Me.txtpago.TabIndex = 32
        Me.txtpago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Font = New System.Drawing.Font("Sitka Subheading", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.Location = New System.Drawing.Point(302, 70)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(119, 55)
        Me.lbldate.TabIndex = 34
        Me.lbldate.Text = "Fecha"
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
        Me.lstLista.Location = New System.Drawing.Point(153, 386)
        Me.lstLista.Name = "lstLista"
        Me.lstLista.Size = New System.Drawing.Size(1349, 384)
        Me.lstLista.TabIndex = 35
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
        Me.ColumnHeader3.Width = 242
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
        'lblcambio
        '
        Me.lblcambio.AutoSize = True
        Me.lblcambio.Font = New System.Drawing.Font("MS PGothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcambio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblcambio.Location = New System.Drawing.Point(1608, 948)
        Me.lblcambio.Name = "lblcambio"
        Me.lblcambio.Size = New System.Drawing.Size(0, 80)
        Me.lblcambio.TabIndex = 36
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 52.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbltotal.Location = New System.Drawing.Point(1621, 542)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(93, 101)
        Me.lbltotal.TabIndex = 37
        Me.lbltotal.Text = "0"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MonthCalendar1.Enabled = False
        Me.MonthCalendar1.Location = New System.Drawing.Point(87, 794)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 38
        '
        'btnfiados
        '
        Me.btnfiados.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnfiados.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnfiados.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfiados.ForeColor = System.Drawing.Color.White
        Me.btnfiados.Location = New System.Drawing.Point(911, 49)
        Me.btnfiados.Name = "btnfiados"
        Me.btnfiados.Size = New System.Drawing.Size(128, 88)
        Me.btnfiados.TabIndex = 39
        Me.btnfiados.Text = "Fiados"
        Me.btnfiados.UseVisualStyleBackColor = False
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("NSimSun", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblname.Location = New System.Drawing.Point(1736, 131)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(0, 38)
        Me.lblname.TabIndex = 40
        '
        'lblcambio1
        '
        Me.lblcambio1.AutoSize = True
        Me.lblcambio1.Font = New System.Drawing.Font("Microsoft Sans Serif", 49.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcambio1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblcambio1.Location = New System.Drawing.Point(1536, 928)
        Me.lblcambio1.Name = "lblcambio1"
        Me.lblcambio1.Size = New System.Drawing.Size(0, 95)
        Me.lblcambio1.TabIndex = 41
        '
        'lblnameC
        '
        Me.lblnameC.AutoSize = True
        Me.lblnameC.Font = New System.Drawing.Font("SimSun", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnameC.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblnameC.Location = New System.Drawing.Point(1547, 95)
        Me.lblnameC.Name = "lblnameC"
        Me.lblnameC.Size = New System.Drawing.Size(37, 38)
        Me.lblnameC.TabIndex = 42
        Me.lblnameC.Text = ":"
        '
        'lblpage
        '
        Me.lblpage.AutoSize = True
        Me.lblpage.Font = New System.Drawing.Font("Microsoft Sans Serif", 52.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblpage.Location = New System.Drawing.Point(1416, 886)
        Me.lblpage.Name = "lblpage"
        Me.lblpage.Size = New System.Drawing.Size(93, 101)
        Me.lblpage.TabIndex = 43
        Me.lblpage.Text = "0"
        '
        'ButtonCobrar
        '
        Me.ButtonCobrar.BackColor = System.Drawing.Color.Transparent
        Me.ButtonCobrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonCobrar.Font = New System.Drawing.Font("Lucida Bright", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCobrar.ForeColor = System.Drawing.SystemColors.Window
        Me.ButtonCobrar.Image = Global.PuntoDeVenta.My.Resources.Resources.dollar
        Me.ButtonCobrar.Location = New System.Drawing.Point(389, 800)
        Me.ButtonCobrar.Name = "ButtonCobrar"
        Me.ButtonCobrar.Size = New System.Drawing.Size(479, 201)
        Me.ButtonCobrar.TabIndex = 17
        Me.ButtonCobrar.Text = "Cobrar"
        Me.ButtonCobrar.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Image = Global.PuntoDeVenta.My.Resources.Resources.logo_camila
        Me.PictureBox3.Location = New System.Drawing.Point(0, 44)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(121, 108)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.No
        Me.PictureBox2.Image = Global.PuntoDeVenta.My.Resources.Resources.icono7
        Me.PictureBox2.Location = New System.Drawing.Point(1523, 0)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(119, 91)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(1537, 550)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 85)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "$"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(1355, 886)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 85)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "$"
        '
        'Venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblpage)
        Me.Controls.Add(Me.lblnameC)
        Me.Controls.Add(Me.lblcambio1)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.btnfiados)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.lblcambio)
        Me.Controls.Add(Me.lstLista)
        Me.Controls.Add(Me.lbldate)
        Me.Controls.Add(Me.txtpago)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ButtonCobrar)
        Me.Controls.Add(Me.ButtonCancelar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Venta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents RegresarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ButtonBuscar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents ButtonCancelar As Button
    Friend WithEvents ButtonCobrar As Button
    Friend WithEvents ButtonAgregar As Button
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtmarca As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtstock As TextBox
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtpago As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtprecio As TextBox
    Friend WithEvents lbldate As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label14 As Label
    Friend WithEvents txtmedida As TextBox
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents btactuali As Button
    Friend WithEvents btnactualizar As Button
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents lblcambio As Label
    Friend WithEvents lbltotal As Label
    Public WithEvents lstLista As ListView
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents btnfiados As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents lblname As Label
    Friend WithEvents lblcambio1 As Label
    Friend WithEvents lblnameC As Label
    Friend WithEvents lblpage As Label
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
End Class
