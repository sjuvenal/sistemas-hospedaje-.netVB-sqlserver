<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistrarTipoHabitacion
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbdatos = New System.Windows.Forms.GroupBox()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.txttipohabitacion = New System.Windows.Forms.TextBox()
        Me.gbregistros = New System.Windows.Forms.GroupBox()
        Me.dgtipohabitacion = New System.Windows.Forms.DataGridView()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.gbdatos.SuspendLayout()
        Me.gbregistros.SuspendLayout()
        CType(Me.dgtipohabitacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo Habitacion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Descripcion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(386, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Precio"
        Me.Label3.Visible = False
        '
        'gbdatos
        '
        Me.gbdatos.Controls.Add(Me.txtprecio)
        Me.gbdatos.Controls.Add(Me.txtdescripcion)
        Me.gbdatos.Controls.Add(Me.txttipohabitacion)
        Me.gbdatos.Controls.Add(Me.Label1)
        Me.gbdatos.Controls.Add(Me.Label3)
        Me.gbdatos.Controls.Add(Me.Label2)
        Me.gbdatos.Location = New System.Drawing.Point(12, 119)
        Me.gbdatos.Name = "gbdatos"
        Me.gbdatos.Size = New System.Drawing.Size(495, 99)
        Me.gbdatos.TabIndex = 1
        Me.gbdatos.TabStop = False
        Me.gbdatos.Text = "Datos Tipo de Habitacion"
        '
        'txtprecio
        '
        Me.txtprecio.Location = New System.Drawing.Point(429, 25)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(43, 20)
        Me.txtprecio.TabIndex = 1
        Me.txtprecio.Text = "1"
        Me.txtprecio.Visible = False
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Location = New System.Drawing.Point(107, 57)
        Me.txtdescripcion.MaxLength = 100
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(369, 20)
        Me.txtdescripcion.TabIndex = 2
        '
        'txttipohabitacion
        '
        Me.txttipohabitacion.Location = New System.Drawing.Point(107, 25)
        Me.txttipohabitacion.Name = "txttipohabitacion"
        Me.txttipohabitacion.Size = New System.Drawing.Size(273, 20)
        Me.txttipohabitacion.TabIndex = 0
        '
        'gbregistros
        '
        Me.gbregistros.Controls.Add(Me.dgtipohabitacion)
        Me.gbregistros.Location = New System.Drawing.Point(12, 220)
        Me.gbregistros.Name = "gbregistros"
        Me.gbregistros.Size = New System.Drawing.Size(495, 199)
        Me.gbregistros.TabIndex = 1
        Me.gbregistros.TabStop = False
        Me.gbregistros.Text = "Listado Tipo Habitacion"
        '
        'dgtipohabitacion
        '
        Me.dgtipohabitacion.AllowUserToAddRows = False
        Me.dgtipohabitacion.AllowUserToDeleteRows = False
        Me.dgtipohabitacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgtipohabitacion.Location = New System.Drawing.Point(16, 26)
        Me.dgtipohabitacion.Name = "dgtipohabitacion"
        Me.dgtipohabitacion.ReadOnly = True
        Me.dgtipohabitacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgtipohabitacion.Size = New System.Drawing.Size(476, 167)
        Me.dgtipohabitacion.TabIndex = 0
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
        'btnmodificar
        '
        Me.btnmodificar.Location = New System.Drawing.Point(85, 19)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(74, 34)
        Me.btnmodificar.TabIndex = 2
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.UseVisualStyleBackColor = True
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
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(396, 19)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(93, 34)
        Me.btnsalir.TabIndex = 2
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
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
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Blue
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(0, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(516, 44)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "MANTENIMIENTO DE TIPO HAB"
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
        Me.GroupBox3.Size = New System.Drawing.Size(495, 67)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'FrmRegistrarTipoHabitacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 431)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.gbregistros)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.gbdatos)
        Me.Name = "FrmRegistrarTipoHabitacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmRegistrarTipoHabitacion"
        Me.gbdatos.ResumeLayout(False)
        Me.gbdatos.PerformLayout()
        Me.gbregistros.ResumeLayout(False)
        CType(Me.dgtipohabitacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gbdatos As System.Windows.Forms.GroupBox
    Friend WithEvents txtprecio As System.Windows.Forms.TextBox
    Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txttipohabitacion As System.Windows.Forms.TextBox
    Friend WithEvents gbregistros As System.Windows.Forms.GroupBox
    Friend WithEvents dgtipohabitacion As System.Windows.Forms.DataGridView
    Friend WithEvents btnnuevo As System.Windows.Forms.Button
    Friend WithEvents btnmodificar As System.Windows.Forms.Button
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
End Class
