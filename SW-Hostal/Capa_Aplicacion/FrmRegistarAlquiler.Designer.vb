<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistarAlquiler
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
        Me.txtcliente = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnbuscarhabitacion = New System.Windows.Forms.Button()
        Me.txtnrohab = New System.Windows.Forms.TextBox()
        Me.cbxJAK = New System.Windows.Forms.CheckBox()
        Me.cbxTV = New System.Windows.Forms.CheckBox()
        Me.cbxCABLE = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.txtnropiso = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txttipohabitacion = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnbuscarcliente = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtdocumento = New System.Windows.Forms.TextBox()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rbhoras = New System.Windows.Forms.RadioButton()
        Me.rbdias = New System.Windows.Forms.RadioButton()
        Me.cbxplaya = New System.Windows.Forms.CheckBox()
        Me.cbxllaves = New System.Windows.Forms.CheckBox()
        Me.cbxcontrol = New System.Windows.Forms.CheckBox()
        Me.DTPhrEntrada = New System.Windows.Forms.DateTimePicker()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.DTPhrSalida = New System.Windows.Forms.DateTimePicker()
        Me.DTPFcSalida = New System.Windows.Forms.DateTimePicker()
        Me.DTPFcEntrada = New System.Windows.Forms.DateTimePicker()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.txtdias = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.cbxdni = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtcliente
        '
        Me.txtcliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtcliente.Location = New System.Drawing.Point(74, 30)
        Me.txtcliente.Name = "txtcliente"
        Me.txtcliente.ReadOnly = True
        Me.txtcliente.Size = New System.Drawing.Size(234, 20)
        Me.txtcliente.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnbuscarhabitacion)
        Me.GroupBox1.Controls.Add(Me.txtnrohab)
        Me.GroupBox1.Controls.Add(Me.cbxJAK)
        Me.GroupBox1.Controls.Add(Me.cbxTV)
        Me.GroupBox1.Controls.Add(Me.cbxCABLE)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtprecio)
        Me.GroupBox1.Controls.Add(Me.txtnropiso)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txttipohabitacion)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 93)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(392, 136)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "BUSCAR HABITACION"
        '
        'btnbuscarhabitacion
        '
        Me.btnbuscarhabitacion.Location = New System.Drawing.Point(320, 26)
        Me.btnbuscarhabitacion.Name = "btnbuscarhabitacion"
        Me.btnbuscarhabitacion.Size = New System.Drawing.Size(60, 94)
        Me.btnbuscarhabitacion.TabIndex = 2
        Me.btnbuscarhabitacion.Text = "Buscar Hab"
        Me.btnbuscarhabitacion.UseVisualStyleBackColor = True
        '
        'txtnrohab
        '
        Me.txtnrohab.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtnrohab.Location = New System.Drawing.Point(106, 52)
        Me.txtnrohab.Name = "txtnrohab"
        Me.txtnrohab.ReadOnly = True
        Me.txtnrohab.Size = New System.Drawing.Size(119, 20)
        Me.txtnrohab.TabIndex = 0
        '
        'cbxJAK
        '
        Me.cbxJAK.AutoSize = True
        Me.cbxJAK.Enabled = False
        Me.cbxJAK.Location = New System.Drawing.Point(241, 81)
        Me.cbxJAK.Name = "cbxJAK"
        Me.cbxJAK.Size = New System.Drawing.Size(59, 17)
        Me.cbxJAK.TabIndex = 1
        Me.cbxJAK.Text = "Jakuzy"
        Me.cbxJAK.UseVisualStyleBackColor = True
        '
        'cbxTV
        '
        Me.cbxTV.AutoSize = True
        Me.cbxTV.Enabled = False
        Me.cbxTV.Location = New System.Drawing.Point(241, 26)
        Me.cbxTV.Name = "cbxTV"
        Me.cbxTV.Size = New System.Drawing.Size(73, 17)
        Me.cbxTV.TabIndex = 1
        Me.cbxTV.Text = "TV- Cable"
        Me.cbxTV.UseVisualStyleBackColor = True
        '
        'cbxCABLE
        '
        Me.cbxCABLE.AutoSize = True
        Me.cbxCABLE.Enabled = False
        Me.cbxCABLE.Location = New System.Drawing.Point(241, 51)
        Me.cbxCABLE.Name = "cbxCABLE"
        Me.cbxCABLE.Size = New System.Drawing.Size(73, 17)
        Me.cbxCABLE.TabIndex = 1
        Me.cbxCABLE.Text = "TV- Cable"
        Me.cbxCABLE.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(63, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Precio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(73, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Piso"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(71, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Nro"
        '
        'txtprecio
        '
        Me.txtprecio.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtprecio.Location = New System.Drawing.Point(106, 78)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.ReadOnly = True
        Me.txtprecio.Size = New System.Drawing.Size(119, 20)
        Me.txtprecio.TabIndex = 0
        '
        'txtnropiso
        '
        Me.txtnropiso.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtnropiso.Location = New System.Drawing.Point(106, 107)
        Me.txtnropiso.Name = "txtnropiso"
        Me.txtnropiso.ReadOnly = True
        Me.txtnropiso.Size = New System.Drawing.Size(119, 20)
        Me.txtnropiso.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Tipo Habitacion"
        '
        'txttipohabitacion
        '
        Me.txttipohabitacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txttipohabitacion.Location = New System.Drawing.Point(106, 23)
        Me.txttipohabitacion.Name = "txttipohabitacion"
        Me.txttipohabitacion.ReadOnly = True
        Me.txttipohabitacion.Size = New System.Drawing.Size(119, 20)
        Me.txttipohabitacion.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnbuscarcliente)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtdocumento)
        Me.GroupBox2.Controls.Add(Me.txtcliente)
        Me.GroupBox2.Location = New System.Drawing.Point(414, 93)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(396, 88)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "BUSCAR CLIENTE"
        '
        'btnbuscarcliente
        '
        Me.btnbuscarcliente.Location = New System.Drawing.Point(326, 30)
        Me.btnbuscarcliente.Name = "btnbuscarcliente"
        Me.btnbuscarcliente.Size = New System.Drawing.Size(60, 52)
        Me.btnbuscarcliente.TabIndex = 2
        Me.btnbuscarcliente.Text = "Buscar Cliente"
        Me.btnbuscarcliente.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Documento"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cliente"
        '
        'txtdocumento
        '
        Me.txtdocumento.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtdocumento.Location = New System.Drawing.Point(74, 62)
        Me.txtdocumento.Name = "txtdocumento"
        Me.txtdocumento.ReadOnly = True
        Me.txtdocumento.Size = New System.Drawing.Size(234, 20)
        Me.txtdocumento.TabIndex = 0
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(637, 49)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(69, 96)
        Me.btnguardar.TabIndex = 5
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cbxdni)
        Me.GroupBox3.Controls.Add(Me.rbhoras)
        Me.GroupBox3.Controls.Add(Me.rbdias)
        Me.GroupBox3.Controls.Add(Me.cbxplaya)
        Me.GroupBox3.Controls.Add(Me.cbxllaves)
        Me.GroupBox3.Controls.Add(Me.cbxcontrol)
        Me.GroupBox3.Controls.Add(Me.DTPhrEntrada)
        Me.GroupBox3.Controls.Add(Me.btncancelar)
        Me.GroupBox3.Controls.Add(Me.DTPhrSalida)
        Me.GroupBox3.Controls.Add(Me.DTPFcSalida)
        Me.GroupBox3.Controls.Add(Me.DTPFcEntrada)
        Me.GroupBox3.Controls.Add(Me.txtdescripcion)
        Me.GroupBox3.Controls.Add(Me.txtdias)
        Me.GroupBox3.Controls.Add(Me.btnguardar)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 235)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(794, 153)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "DATOS DEL ALQUILER"
        '
        'rbhoras
        '
        Me.rbhoras.AutoSize = True
        Me.rbhoras.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbhoras.Location = New System.Drawing.Point(94, 16)
        Me.rbhoras.Name = "rbhoras"
        Me.rbhoras.Size = New System.Drawing.Size(61, 17)
        Me.rbhoras.TabIndex = 9
        Me.rbhoras.TabStop = True
        Me.rbhoras.Text = "X horas"
        Me.rbhoras.UseVisualStyleBackColor = False
        '
        'rbdias
        '
        Me.rbdias.AutoSize = True
        Me.rbdias.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbdias.Location = New System.Drawing.Point(21, 16)
        Me.rbdias.Name = "rbdias"
        Me.rbdias.Size = New System.Drawing.Size(56, 17)
        Me.rbdias.TabIndex = 9
        Me.rbdias.TabStop = True
        Me.rbdias.Text = "X Dias"
        Me.rbdias.UseVisualStyleBackColor = False
        '
        'cbxplaya
        '
        Me.cbxplaya.AutoSize = True
        Me.cbxplaya.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxplaya.Location = New System.Drawing.Point(552, 16)
        Me.cbxplaya.Name = "cbxplaya"
        Me.cbxplaya.Size = New System.Drawing.Size(52, 17)
        Me.cbxplaya.TabIndex = 1
        Me.cbxplaya.Text = "Playa"
        Me.cbxplaya.UseVisualStyleBackColor = False
        '
        'cbxllaves
        '
        Me.cbxllaves.AutoSize = True
        Me.cbxllaves.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxllaves.Checked = True
        Me.cbxllaves.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbxllaves.Location = New System.Drawing.Point(491, 16)
        Me.cbxllaves.Name = "cbxllaves"
        Me.cbxllaves.Size = New System.Drawing.Size(55, 17)
        Me.cbxllaves.TabIndex = 1
        Me.cbxllaves.Text = "Laves"
        Me.cbxllaves.UseVisualStyleBackColor = False
        '
        'cbxcontrol
        '
        Me.cbxcontrol.AutoSize = True
        Me.cbxcontrol.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxcontrol.Checked = True
        Me.cbxcontrol.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbxcontrol.Location = New System.Drawing.Point(426, 16)
        Me.cbxcontrol.Name = "cbxcontrol"
        Me.cbxcontrol.Size = New System.Drawing.Size(59, 17)
        Me.cbxcontrol.TabIndex = 1
        Me.cbxcontrol.Text = "Control"
        Me.cbxcontrol.UseVisualStyleBackColor = False
        '
        'DTPhrEntrada
        '
        Me.DTPhrEntrada.Enabled = False
        Me.DTPhrEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DTPhrEntrada.Location = New System.Drawing.Point(294, 50)
        Me.DTPhrEntrada.Name = "DTPhrEntrada"
        Me.DTPhrEntrada.ShowUpDown = True
        Me.DTPhrEntrada.Size = New System.Drawing.Size(98, 20)
        Me.DTPhrEntrada.TabIndex = 8
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(712, 49)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(72, 96)
        Me.btncancelar.TabIndex = 5
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'DTPhrSalida
        '
        Me.DTPhrSalida.Enabled = False
        Me.DTPhrSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DTPhrSalida.Location = New System.Drawing.Point(294, 86)
        Me.DTPhrSalida.Name = "DTPhrSalida"
        Me.DTPhrSalida.ShowUpDown = True
        Me.DTPhrSalida.Size = New System.Drawing.Size(98, 20)
        Me.DTPhrSalida.TabIndex = 8
        '
        'DTPFcSalida
        '
        Me.DTPFcSalida.Enabled = False
        Me.DTPFcSalida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFcSalida.Location = New System.Drawing.Point(101, 86)
        Me.DTPFcSalida.Name = "DTPFcSalida"
        Me.DTPFcSalida.Size = New System.Drawing.Size(98, 20)
        Me.DTPFcSalida.TabIndex = 8
        '
        'DTPFcEntrada
        '
        Me.DTPFcEntrada.Enabled = False
        Me.DTPFcEntrada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFcEntrada.Location = New System.Drawing.Point(101, 51)
        Me.DTPFcEntrada.Name = "DTPFcEntrada"
        Me.DTPFcEntrada.Size = New System.Drawing.Size(98, 20)
        Me.DTPFcEntrada.TabIndex = 8
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Location = New System.Drawing.Point(426, 65)
        Me.txtdescripcion.Multiline = True
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(200, 80)
        Me.txtdescripcion.TabIndex = 7
        '
        'txtdias
        '
        Me.txtdias.Location = New System.Drawing.Point(106, 125)
        Me.txtdias.Name = "txtdias"
        Me.txtdias.Size = New System.Drawing.Size(286, 20)
        Me.txtdias.TabIndex = 7
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(225, 92)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 13)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Hora Salida"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(67, 125)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(28, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Dias"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(217, 57)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Hora Entrada"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(26, 92)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Fecha Salida"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(423, 49)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 13)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Descripcion Alquiler"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Fecha Entrada"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Location = New System.Drawing.Point(-2, 15)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(803, 19)
        Me.Label13.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Blue
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(0, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(816, 44)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "MANTENIMIENTO DE ALQUILER"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(738, 51)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(72, 39)
        Me.btnsalir.TabIndex = 5
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btnnuevo
        '
        Me.btnnuevo.Location = New System.Drawing.Point(16, 53)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(392, 34)
        Me.btnnuevo.TabIndex = 4
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'cbxdni
        '
        Me.cbxdni.AutoSize = True
        Me.cbxdni.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxdni.Checked = True
        Me.cbxdni.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbxdni.Location = New System.Drawing.Point(610, 16)
        Me.cbxdni.Name = "cbxdni"
        Me.cbxdni.Size = New System.Drawing.Size(45, 17)
        Me.cbxdni.TabIndex = 10
        Me.cbxdni.Text = "DNI"
        Me.cbxdni.UseVisualStyleBackColor = False
        '
        'FrmRegistarAlquiler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 393)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnnuevo)
        Me.Name = "FrmRegistarAlquiler"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmRegistarAlquiler"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtcliente As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnbuscarhabitacion As System.Windows.Forms.Button
    Friend WithEvents cbxJAK As System.Windows.Forms.CheckBox
    Friend WithEvents cbxCABLE As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtprecio As System.Windows.Forms.TextBox
    Friend WithEvents txtnropiso As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txttipohabitacion As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnbuscarcliente As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtdocumento As System.Windows.Forms.TextBox
    Friend WithEvents txtnrohab As System.Windows.Forms.TextBox
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtdias As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DTPFcSalida As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPFcEntrada As System.Windows.Forms.DateTimePicker
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents cbxTV As System.Windows.Forms.CheckBox
    Friend WithEvents btnnuevo As System.Windows.Forms.Button
    Friend WithEvents DTPhrSalida As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DTPhrEntrada As System.Windows.Forms.DateTimePicker
    Friend WithEvents rbhoras As System.Windows.Forms.RadioButton
    Friend WithEvents rbdias As System.Windows.Forms.RadioButton
    Friend WithEvents cbxplaya As System.Windows.Forms.CheckBox
    Friend WithEvents cbxllaves As System.Windows.Forms.CheckBox
    Friend WithEvents cbxcontrol As System.Windows.Forms.CheckBox
    Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cbxdni As System.Windows.Forms.CheckBox
End Class
