<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistrarClientes
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CbrEstado = New System.Windows.Forms.CheckBox()
        Me.txtmaterno = New System.Windows.Forms.TextBox()
        Me.txtpaterno = New System.Windows.Forms.TextBox()
        Me.cbtipodociden = New System.Windows.Forms.ComboBox()
        Me.txtnombres = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rbfemenino = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rbmasculino = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnrodoc = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DgClientes = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.cbdistrito = New System.Windows.Forms.ComboBox()
        Me.cbprovincia = New System.Windows.Forms.ComboBox()
        Me.cbpais = New System.Windows.Forms.ComboBox()
        Me.cbciudad = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CbrEstado)
        Me.GroupBox1.Controls.Add(Me.txtmaterno)
        Me.GroupBox1.Controls.Add(Me.txtpaterno)
        Me.GroupBox1.Controls.Add(Me.cbtipodociden)
        Me.GroupBox1.Controls.Add(Me.txtnombres)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.rbfemenino)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.rbmasculino)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtnrodoc)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 108)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(868, 88)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Del Cliente"
        '
        'CbrEstado
        '
        Me.CbrEstado.AutoSize = True
        Me.CbrEstado.Location = New System.Drawing.Point(347, 25)
        Me.CbrEstado.Name = "CbrEstado"
        Me.CbrEstado.Size = New System.Drawing.Size(59, 17)
        Me.CbrEstado.TabIndex = 4
        Me.CbrEstado.Text = "Estado"
        Me.CbrEstado.UseVisualStyleBackColor = True
        '
        'txtmaterno
        '
        Me.txtmaterno.Location = New System.Drawing.Point(266, 52)
        Me.txtmaterno.MaxLength = 100
        Me.txtmaterno.Name = "txtmaterno"
        Me.txtmaterno.Size = New System.Drawing.Size(135, 20)
        Me.txtmaterno.TabIndex = 1
        '
        'txtpaterno
        '
        Me.txtpaterno.Location = New System.Drawing.Point(76, 52)
        Me.txtpaterno.MaxLength = 100
        Me.txtpaterno.Name = "txtpaterno"
        Me.txtpaterno.Size = New System.Drawing.Size(113, 20)
        Me.txtpaterno.TabIndex = 1
        '
        'cbtipodociden
        '
        Me.cbtipodociden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbtipodociden.FormattingEnabled = True
        Me.cbtipodociden.Location = New System.Drawing.Point(540, 19)
        Me.cbtipodociden.Name = "cbtipodociden"
        Me.cbtipodociden.Size = New System.Drawing.Size(150, 21)
        Me.cbtipodociden.TabIndex = 3
        '
        'txtnombres
        '
        Me.txtnombres.Location = New System.Drawing.Point(76, 20)
        Me.txtnombres.MaxLength = 100
        Me.txtnombres.Name = "txtnombres"
        Me.txtnombres.Size = New System.Drawing.Size(190, 20)
        Me.txtnombres.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(195, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Ap_Materno"
        '
        'rbfemenino
        '
        Me.rbfemenino.AutoSize = True
        Me.rbfemenino.Location = New System.Drawing.Point(789, 42)
        Me.rbfemenino.Name = "rbfemenino"
        Me.rbfemenino.Size = New System.Drawing.Size(71, 17)
        Me.rbfemenino.TabIndex = 2
        Me.rbfemenino.Text = "Femenino"
        Me.rbfemenino.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Ap_Paterno"
        '
        'rbmasculino
        '
        Me.rbmasculino.AutoSize = True
        Me.rbmasculino.Checked = True
        Me.rbmasculino.Location = New System.Drawing.Point(766, 20)
        Me.rbmasculino.Name = "rbmasculino"
        Me.rbmasculino.Size = New System.Drawing.Size(73, 17)
        Me.rbmasculino.TabIndex = 2
        Me.rbmasculino.TabStop = True
        Me.rbmasculino.Text = "Masculino"
        Me.rbmasculino.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'txtnrodoc
        '
        Me.txtnrodoc.Location = New System.Drawing.Point(540, 52)
        Me.txtnrodoc.MaxLength = 30
        Me.txtnrodoc.Name = "txtnrodoc"
        Me.txtnrodoc.Size = New System.Drawing.Size(150, 20)
        Me.txtnrodoc.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(729, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Sexo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(471, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Documento"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(451, 59)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Nro Documento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(635, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Distrito"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(410, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Provincia"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(207, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Ciudad"
        '
        'btnnuevo
        '
        Me.btnnuevo.Location = New System.Drawing.Point(11, 61)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(110, 41)
        Me.btnnuevo.TabIndex = 1
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'btnmodificar
        '
        Me.btnmodificar.Location = New System.Drawing.Point(127, 61)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(110, 41)
        Me.btnmodificar.TabIndex = 1
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.UseVisualStyleBackColor = True
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(243, 61)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(110, 41)
        Me.btnguardar.TabIndex = 1
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(359, 61)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(110, 41)
        Me.btncancelar.TabIndex = 1
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(769, 61)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(110, 41)
        Me.btnsalir.TabIndex = 1
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DgClientes)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 288)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(868, 234)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lista de Clientes"
        '
        'DgClientes
        '
        Me.DgClientes.AllowUserToAddRows = False
        Me.DgClientes.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgClientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgClientes.Location = New System.Drawing.Point(6, 19)
        Me.DgClientes.MultiSelect = False
        Me.DgClientes.Name = "DgClientes"
        Me.DgClientes.ReadOnly = True
        Me.DgClientes.RowHeadersWidth = 20
        Me.DgClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgClientes.Size = New System.Drawing.Size(853, 186)
        Me.DgClientes.TabIndex = 0
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
        Me.Label10.Size = New System.Drawing.Size(889, 44)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "MANTENIMIENTO DE CLIENTES"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtdireccion)
        Me.GroupBox3.Controls.Add(Me.cbdistrito)
        Me.GroupBox3.Controls.Add(Me.cbprovincia)
        Me.GroupBox3.Controls.Add(Me.cbpais)
        Me.GroupBox3.Controls.Add(Me.cbciudad)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 202)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(868, 80)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Lugar"
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(88, 53)
        Me.txtdireccion.MaxLength = 200
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(736, 20)
        Me.txtdireccion.TabIndex = 1
        '
        'cbdistrito
        '
        Me.cbdistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbdistrito.FormattingEnabled = True
        Me.cbdistrito.Location = New System.Drawing.Point(680, 19)
        Me.cbdistrito.Name = "cbdistrito"
        Me.cbdistrito.Size = New System.Drawing.Size(144, 21)
        Me.cbdistrito.TabIndex = 6
        '
        'cbprovincia
        '
        Me.cbprovincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbprovincia.FormattingEnabled = True
        Me.cbprovincia.Location = New System.Drawing.Point(467, 19)
        Me.cbprovincia.Name = "cbprovincia"
        Me.cbprovincia.Size = New System.Drawing.Size(144, 21)
        Me.cbprovincia.TabIndex = 6
        '
        'cbpais
        '
        Me.cbpais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbpais.FormattingEnabled = True
        Me.cbpais.Location = New System.Drawing.Point(88, 17)
        Me.cbpais.Name = "cbpais"
        Me.cbpais.Size = New System.Drawing.Size(97, 21)
        Me.cbpais.TabIndex = 6
        '
        'cbciudad
        '
        Me.cbciudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbciudad.FormattingEnabled = True
        Me.cbciudad.Location = New System.Drawing.Point(253, 19)
        Me.cbciudad.Name = "cbciudad"
        Me.cbciudad.Size = New System.Drawing.Size(129, 21)
        Me.cbciudad.TabIndex = 6
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(18, 56)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Direccion"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(18, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(27, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Pais"
        '
        'FrmRegistrarClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 502)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btnmodificar)
        Me.Controls.Add(Me.btnnuevo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmRegistrarClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmRegistrarClientes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DgClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbfemenino As System.Windows.Forms.RadioButton
    Friend WithEvents rbmasculino As System.Windows.Forms.RadioButton
    Friend WithEvents txtnrodoc As System.Windows.Forms.TextBox
    Friend WithEvents txtmaterno As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtpaterno As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtnombres As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnnuevo As System.Windows.Forms.Button
    Friend WithEvents btnmodificar As System.Windows.Forms.Button
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DgClientes As System.Windows.Forms.DataGridView
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cbdistrito As System.Windows.Forms.ComboBox
    Friend WithEvents cbprovincia As System.Windows.Forms.ComboBox
    Friend WithEvents cbciudad As System.Windows.Forms.ComboBox
    Friend WithEvents cbpais As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cbtipodociden As System.Windows.Forms.ComboBox
    Friend WithEvents txtdireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents CbrEstado As System.Windows.Forms.CheckBox
End Class
