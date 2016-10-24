<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBuscarHabitacion
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
        Me.btnaceptar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbnropiso = New System.Windows.Forms.RadioButton()
        Me.rbtipohab = New System.Windows.Forms.RadioButton()
        Me.Cbbuscar = New System.Windows.Forms.ComboBox()
        Me.dgListarhab = New System.Windows.Forms.DataGridView()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgListarhab, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label10.Size = New System.Drawing.Size(506, 44)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "BUSCAR HABITACION"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnaceptar
        '
        Me.btnaceptar.Location = New System.Drawing.Point(359, 19)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(56, 53)
        Me.btnaceptar.TabIndex = 10
        Me.btnaceptar.Text = "Aceptar"
        Me.btnaceptar.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(421, 17)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(57, 53)
        Me.btncancelar.TabIndex = 10
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbnropiso)
        Me.GroupBox1.Controls.Add(Me.rbtipohab)
        Me.GroupBox1.Controls.Add(Me.Cbbuscar)
        Me.GroupBox1.Controls.Add(Me.btnaceptar)
        Me.GroupBox1.Controls.Add(Me.btncancelar)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(484, 79)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar Por: "
        '
        'rbnropiso
        '
        Me.rbnropiso.AutoSize = True
        Me.rbnropiso.Location = New System.Drawing.Point(131, 26)
        Me.rbnropiso.Name = "rbnropiso"
        Me.rbnropiso.Size = New System.Drawing.Size(65, 17)
        Me.rbnropiso.TabIndex = 13
        Me.rbnropiso.Text = "Nro Piso"
        Me.rbnropiso.UseVisualStyleBackColor = True
        '
        'rbtipohab
        '
        Me.rbtipohab.AutoSize = True
        Me.rbtipohab.Location = New System.Drawing.Point(17, 26)
        Me.rbtipohab.Name = "rbtipohab"
        Me.rbtipohab.Size = New System.Drawing.Size(98, 17)
        Me.rbtipohab.TabIndex = 13
        Me.rbtipohab.Text = "Tipo habitacion"
        Me.rbtipohab.UseVisualStyleBackColor = True
        '
        'Cbbuscar
        '
        Me.Cbbuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbbuscar.FormattingEnabled = True
        Me.Cbbuscar.Location = New System.Drawing.Point(17, 49)
        Me.Cbbuscar.Name = "Cbbuscar"
        Me.Cbbuscar.Size = New System.Drawing.Size(179, 21)
        Me.Cbbuscar.TabIndex = 12
        '
        'dgListarhab
        '
        Me.dgListarhab.AllowUserToAddRows = False
        Me.dgListarhab.AllowUserToDeleteRows = False
        Me.dgListarhab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgListarhab.Location = New System.Drawing.Point(10, 132)
        Me.dgListarhab.MultiSelect = False
        Me.dgListarhab.Name = "dgListarhab"
        Me.dgListarhab.ReadOnly = True
        Me.dgListarhab.RowHeadersWidth = 10
        Me.dgListarhab.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgListarhab.Size = New System.Drawing.Size(484, 287)
        Me.dgListarhab.TabIndex = 12
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Location = New System.Drawing.Point(10, 421)
        Me.txtdescripcion.Multiline = True
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(484, 35)
        Me.txtdescripcion.TabIndex = 13
        '
        'FrmBuscarHabitacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 462)
        Me.Controls.Add(Me.txtdescripcion)
        Me.Controls.Add(Me.dgListarhab)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label10)
        Me.Name = "FrmBuscarHabitacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmBuscarHabitacion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgListarhab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbnropiso As System.Windows.Forms.RadioButton
    Friend WithEvents rbtipohab As System.Windows.Forms.RadioButton
    Friend WithEvents Cbbuscar As System.Windows.Forms.ComboBox
    Friend WithEvents dgListarhab As System.Windows.Forms.DataGridView
    Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
End Class
