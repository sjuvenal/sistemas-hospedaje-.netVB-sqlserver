<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDetalleHabitacion
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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnadm = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txttipo = New System.Windows.Forms.TextBox()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.txtfechaentrada = New System.Windows.Forms.TextBox()
        Me.txtfechatermino = New System.Windows.Forms.TextBox()
        Me.txtdias = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.cbxJAK = New System.Windows.Forms.CheckBox()
        Me.cbxTV = New System.Windows.Forms.CheckBox()
        Me.cbxCABLE = New System.Windows.Forms.CheckBox()
        Me.DTPhrEntrada = New System.Windows.Forms.DateTimePicker()
        Me.DTPhrSalida = New System.Windows.Forms.DateTimePicker()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.RBOLETA = New System.Windows.Forms.RadioButton()
        Me.RBFACTURA = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Label10.Size = New System.Drawing.Size(495, 44)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "NRO H1 - NRO PISO 2"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnadm
        '
        Me.btnadm.Location = New System.Drawing.Point(381, 58)
        Me.btnadm.Name = "btnadm"
        Me.btnadm.Size = New System.Drawing.Size(98, 120)
        Me.btnadm.TabIndex = 11
        Me.btnadm.Text = "Finalizar Alquiler"
        Me.btnadm.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Tipo Habitacion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Precio"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(25, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(312, 4)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Fech Inicio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Fecha Termino"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 198)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Tiempo Estimado"
        '
        'txttipo
        '
        Me.txttipo.Location = New System.Drawing.Point(115, 58)
        Me.txttipo.Name = "txttipo"
        Me.txttipo.Size = New System.Drawing.Size(181, 20)
        Me.txttipo.TabIndex = 14
        '
        'txtprecio
        '
        Me.txtprecio.Location = New System.Drawing.Point(115, 84)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(181, 20)
        Me.txtprecio.TabIndex = 14
        '
        'txtfechaentrada
        '
        Me.txtfechaentrada.Location = New System.Drawing.Point(115, 124)
        Me.txtfechaentrada.Name = "txtfechaentrada"
        Me.txtfechaentrada.Size = New System.Drawing.Size(107, 20)
        Me.txtfechaentrada.TabIndex = 14
        '
        'txtfechatermino
        '
        Me.txtfechatermino.Location = New System.Drawing.Point(115, 158)
        Me.txtfechatermino.Name = "txtfechatermino"
        Me.txtfechatermino.Size = New System.Drawing.Size(107, 20)
        Me.txtfechatermino.TabIndex = 14
        '
        'txtdias
        '
        Me.txtdias.Location = New System.Drawing.Point(115, 195)
        Me.txtdias.Name = "txtdias"
        Me.txtdias.Size = New System.Drawing.Size(207, 20)
        Me.txtdias.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 226)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Detalle Alquiler"
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Location = New System.Drawing.Point(15, 242)
        Me.txtdescripcion.Multiline = True
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(462, 55)
        Me.txtdescripcion.TabIndex = 14
        '
        'cbxJAK
        '
        Me.cbxJAK.AutoSize = True
        Me.cbxJAK.Enabled = False
        Me.cbxJAK.Location = New System.Drawing.Point(302, 98)
        Me.cbxJAK.Name = "cbxJAK"
        Me.cbxJAK.Size = New System.Drawing.Size(59, 17)
        Me.cbxJAK.TabIndex = 17
        Me.cbxJAK.Text = "Jakuzy"
        Me.cbxJAK.UseVisualStyleBackColor = True
        '
        'cbxTV
        '
        Me.cbxTV.AutoSize = True
        Me.cbxTV.Enabled = False
        Me.cbxTV.Location = New System.Drawing.Point(302, 57)
        Me.cbxTV.Name = "cbxTV"
        Me.cbxTV.Size = New System.Drawing.Size(73, 17)
        Me.cbxTV.TabIndex = 16
        Me.cbxTV.Text = "TV- Cable"
        Me.cbxTV.UseVisualStyleBackColor = True
        '
        'cbxCABLE
        '
        Me.cbxCABLE.AutoSize = True
        Me.cbxCABLE.Enabled = False
        Me.cbxCABLE.Location = New System.Drawing.Point(302, 77)
        Me.cbxCABLE.Name = "cbxCABLE"
        Me.cbxCABLE.Size = New System.Drawing.Size(73, 17)
        Me.cbxCABLE.TabIndex = 15
        Me.cbxCABLE.Text = "TV- Cable"
        Me.cbxCABLE.UseVisualStyleBackColor = True
        '
        'DTPhrEntrada
        '
        Me.DTPhrEntrada.Enabled = False
        Me.DTPhrEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DTPhrEntrada.Location = New System.Drawing.Point(228, 124)
        Me.DTPhrEntrada.Name = "DTPhrEntrada"
        Me.DTPhrEntrada.ShowUpDown = True
        Me.DTPhrEntrada.Size = New System.Drawing.Size(98, 20)
        Me.DTPhrEntrada.TabIndex = 19
        '
        'DTPhrSalida
        '
        Me.DTPhrSalida.Enabled = False
        Me.DTPhrSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DTPhrSalida.Location = New System.Drawing.Point(228, 158)
        Me.DTPhrSalida.Name = "DTPhrSalida"
        Me.DTPhrSalida.ShowUpDown = True
        Me.DTPhrSalida.Size = New System.Drawing.Size(98, 20)
        Me.DTPhrSalida.TabIndex = 18
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(381, 184)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(98, 55)
        Me.btnsalir.TabIndex = 20
        Me.btnsalir.Text = "Close"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'RBOLETA
        '
        Me.RBOLETA.AutoSize = True
        Me.RBOLETA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBOLETA.Location = New System.Drawing.Point(48, 66)
        Me.RBOLETA.Name = "RBOLETA"
        Me.RBOLETA.Size = New System.Drawing.Size(96, 24)
        Me.RBOLETA.TabIndex = 21
        Me.RBOLETA.TabStop = True
        Me.RBOLETA.Text = "BOLETA"
        Me.RBOLETA.UseVisualStyleBackColor = True
        '
        'RBFACTURA
        '
        Me.RBFACTURA.AutoSize = True
        Me.RBFACTURA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBFACTURA.Location = New System.Drawing.Point(174, 66)
        Me.RBFACTURA.Name = "RBFACTURA"
        Me.RBFACTURA.Size = New System.Drawing.Size(110, 24)
        Me.RBFACTURA.TabIndex = 21
        Me.RBFACTURA.TabStop = True
        Me.RBFACTURA.Text = "FACTURA"
        Me.RBFACTURA.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RBOLETA)
        Me.GroupBox1.Controls.Add(Me.RBFACTURA)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(363, 181)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "EMITIR DOCUEMNTO"
        Me.GroupBox1.Visible = False
        '
        'FrmDetalleHabitacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 309)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.DTPhrEntrada)
        Me.Controls.Add(Me.DTPhrSalida)
        Me.Controls.Add(Me.cbxJAK)
        Me.Controls.Add(Me.cbxTV)
        Me.Controls.Add(Me.cbxCABLE)
        Me.Controls.Add(Me.txtdescripcion)
        Me.Controls.Add(Me.txtdias)
        Me.Controls.Add(Me.txtfechatermino)
        Me.Controls.Add(Me.txtfechaentrada)
        Me.Controls.Add(Me.txtprecio)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txttipo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnadm)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label3)
        Me.Name = "FrmDetalleHabitacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmDetalleHabitacion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnadm As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txttipo As System.Windows.Forms.TextBox
    Friend WithEvents txtprecio As System.Windows.Forms.TextBox
    Friend WithEvents txtfechaentrada As System.Windows.Forms.TextBox
    Friend WithEvents txtfechatermino As System.Windows.Forms.TextBox
    Friend WithEvents txtdias As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents cbxJAK As System.Windows.Forms.CheckBox
    Friend WithEvents cbxTV As System.Windows.Forms.CheckBox
    Friend WithEvents cbxCABLE As System.Windows.Forms.CheckBox
    Friend WithEvents DTPhrEntrada As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPhrSalida As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents RBOLETA As System.Windows.Forms.RadioButton
    Friend WithEvents RBFACTURA As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
