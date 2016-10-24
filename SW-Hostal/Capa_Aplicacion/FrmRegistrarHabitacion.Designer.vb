<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistrarHabitacion
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbjacuzzi = New System.Windows.Forms.CheckBox()
        Me.cbcable = New System.Windows.Forms.CheckBox()
        Me.cbtv = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnrohab = New System.Windows.Forms.TextBox()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbpisohab = New System.Windows.Forms.ComboBox()
        Me.cbTipoHabitacion = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dghabitacion = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dghabitacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbjacuzzi)
        Me.GroupBox1.Controls.Add(Me.cbcable)
        Me.GroupBox1.Controls.Add(Me.cbtv)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtnrohab)
        Me.GroupBox1.Controls.Add(Me.txtdescripcion)
        Me.GroupBox1.Controls.Add(Me.txtprecio)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cbpisohab)
        Me.GroupBox1.Controls.Add(Me.cbTipoHabitacion)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 114)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(585, 135)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Habitacion"
        '
        'cbjacuzzi
        '
        Me.cbjacuzzi.AutoSize = True
        Me.cbjacuzzi.Location = New System.Drawing.Point(498, 102)
        Me.cbjacuzzi.Name = "cbjacuzzi"
        Me.cbjacuzzi.Size = New System.Drawing.Size(61, 17)
        Me.cbjacuzzi.TabIndex = 6
        Me.cbjacuzzi.Text = "Jacuzzi"
        Me.cbjacuzzi.UseVisualStyleBackColor = True
        '
        'cbcable
        '
        Me.cbcable.AutoSize = True
        Me.cbcable.Location = New System.Drawing.Point(498, 65)
        Me.cbcable.Name = "cbcable"
        Me.cbcable.Size = New System.Drawing.Size(53, 17)
        Me.cbcable.TabIndex = 6
        Me.cbcable.Text = "Cable"
        Me.cbcable.UseVisualStyleBackColor = True
        '
        'cbtv
        '
        Me.cbtv.AutoSize = True
        Me.cbtv.Location = New System.Drawing.Point(498, 30)
        Me.cbtv.Name = "cbtv"
        Me.cbtv.Size = New System.Drawing.Size(40, 17)
        Me.cbtv.TabIndex = 6
        Me.cbtv.Text = "TV"
        Me.cbtv.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(45, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Descripcion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(291, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Piso"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(291, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nro"
        '
        'txtnrohab
        '
        Me.txtnrohab.Location = New System.Drawing.Point(335, 30)
        Me.txtnrohab.MaxLength = 2
        Me.txtnrohab.Name = "txtnrohab"
        Me.txtnrohab.Size = New System.Drawing.Size(133, 20)
        Me.txtnrohab.TabIndex = 2
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Location = New System.Drawing.Point(125, 102)
        Me.txtdescripcion.MaxLength = 100
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(343, 20)
        Me.txtdescripcion.TabIndex = 2
        '
        'txtprecio
        '
        Me.txtprecio.Location = New System.Drawing.Point(125, 69)
        Me.txtprecio.MaxLength = 6
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(133, 20)
        Me.txtprecio.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Precio"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tipo Habitacion"
        '
        'cbpisohab
        '
        Me.cbpisohab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbpisohab.FormattingEnabled = True
        Me.cbpisohab.Items.AddRange(New Object() {"Piso Nro 1", "Piso Nro 2", "Piso Nro 3", "Piso Nro 4", "Piso Nro 5"})
        Me.cbpisohab.Location = New System.Drawing.Point(332, 67)
        Me.cbpisohab.Name = "cbpisohab"
        Me.cbpisohab.Size = New System.Drawing.Size(136, 21)
        Me.cbpisohab.TabIndex = 0
        '
        'cbTipoHabitacion
        '
        Me.cbTipoHabitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoHabitacion.FormattingEnabled = True
        Me.cbTipoHabitacion.Location = New System.Drawing.Point(125, 34)
        Me.cbTipoHabitacion.Name = "cbTipoHabitacion"
        Me.cbTipoHabitacion.Size = New System.Drawing.Size(136, 21)
        Me.cbTipoHabitacion.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dghabitacion)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 254)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(593, 180)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lista de Habitaciones"
        '
        'dghabitacion
        '
        Me.dghabitacion.AllowUserToAddRows = False
        Me.dghabitacion.AllowUserToDeleteRows = False
        Me.dghabitacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dghabitacion.Location = New System.Drawing.Point(6, 19)
        Me.dghabitacion.MultiSelect = False
        Me.dghabitacion.Name = "dghabitacion"
        Me.dghabitacion.ReadOnly = True
        Me.dghabitacion.RowHeadersWidth = 20
        Me.dghabitacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dghabitacion.Size = New System.Drawing.Size(581, 154)
        Me.dghabitacion.TabIndex = 0
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
        Me.Label10.Size = New System.Drawing.Size(612, 44)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "MANTENIMIENTO DE HABITACIONES"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnnuevo)
        Me.GroupBox3.Controls.Add(Me.btncancelar)
        Me.GroupBox3.Controls.Add(Me.btnmodificar)
        Me.GroupBox3.Controls.Add(Me.btnsalir)
        Me.GroupBox3.Controls.Add(Me.btnguardar)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 47)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(585, 67)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        '
        'btnnuevo
        '
        Me.btnnuevo.Location = New System.Drawing.Point(6, 19)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(73, 34)
        Me.btnnuevo.TabIndex = 0
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(251, 19)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(73, 34)
        Me.btncancelar.TabIndex = 2
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnmodificar
        '
        Me.btnmodificar.Location = New System.Drawing.Point(85, 19)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(74, 34)
        Me.btnmodificar.TabIndex = 2
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(486, 19)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(93, 34)
        Me.btnsalir.TabIndex = 2
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(165, 19)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(80, 34)
        Me.btnguardar.TabIndex = 1
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'FrmRegistrarHabitacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 439)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmRegistrarHabitacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmRegistrarHabitacion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dghabitacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbTipoHabitacion As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtnrohab As System.Windows.Forms.TextBox
    Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtprecio As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dghabitacion As System.Windows.Forms.DataGridView
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnnuevo As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnmodificar As System.Windows.Forms.Button
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents cbjacuzzi As System.Windows.Forms.CheckBox
    Friend WithEvents cbcable As System.Windows.Forms.CheckBox
    Friend WithEvents cbtv As System.Windows.Forms.CheckBox
    Friend WithEvents cbpisohab As System.Windows.Forms.ComboBox
End Class
