<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBuscarCliente
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
        Me.dgListarCliente = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.rbapellidos = New System.Windows.Forms.RadioButton()
        Me.rbnrodoc = New System.Windows.Forms.RadioButton()
        Me.rbnombres = New System.Windows.Forms.RadioButton()
        Me.btnaceptar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.dgListarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgListarCliente
        '
        Me.dgListarCliente.AllowUserToAddRows = False
        Me.dgListarCliente.AllowUserToDeleteRows = False
        Me.dgListarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgListarCliente.Location = New System.Drawing.Point(4, 138)
        Me.dgListarCliente.MultiSelect = False
        Me.dgListarCliente.Name = "dgListarCliente"
        Me.dgListarCliente.ReadOnly = True
        Me.dgListarCliente.RowHeadersWidth = 10
        Me.dgListarCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgListarCliente.Size = New System.Drawing.Size(484, 287)
        Me.dgListarCliente.TabIndex = 15
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtbuscar)
        Me.GroupBox1.Controls.Add(Me.rbapellidos)
        Me.GroupBox1.Controls.Add(Me.rbnrodoc)
        Me.GroupBox1.Controls.Add(Me.rbnombres)
        Me.GroupBox1.Controls.Add(Me.btnaceptar)
        Me.GroupBox1.Controls.Add(Me.btncancelar)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(484, 79)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar Por: "
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(18, 49)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(335, 20)
        Me.txtbuscar.TabIndex = 14
        '
        'rbapellidos
        '
        Me.rbapellidos.AutoSize = True
        Me.rbapellidos.Location = New System.Drawing.Point(161, 26)
        Me.rbapellidos.Name = "rbapellidos"
        Me.rbapellidos.Size = New System.Drawing.Size(67, 17)
        Me.rbapellidos.TabIndex = 13
        Me.rbapellidos.Text = "Apellidos"
        Me.rbapellidos.UseVisualStyleBackColor = True
        '
        'rbnrodoc
        '
        Me.rbnrodoc.AutoSize = True
        Me.rbnrodoc.Location = New System.Drawing.Point(17, 26)
        Me.rbnrodoc.Name = "rbnrodoc"
        Me.rbnrodoc.Size = New System.Drawing.Size(65, 17)
        Me.rbnrodoc.TabIndex = 13
        Me.rbnrodoc.Text = "Nro Doc"
        Me.rbnrodoc.UseVisualStyleBackColor = True
        '
        'rbnombres
        '
        Me.rbnombres.AutoSize = True
        Me.rbnombres.Location = New System.Drawing.Point(88, 26)
        Me.rbnombres.Name = "rbnombres"
        Me.rbnombres.Size = New System.Drawing.Size(67, 17)
        Me.rbnombres.TabIndex = 13
        Me.rbnombres.Text = "Nombres"
        Me.rbnombres.UseVisualStyleBackColor = True
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
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Blue
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(0, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(494, 44)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "BUSCAR CLIENTE"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmBuscarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 432)
        Me.Controls.Add(Me.dgListarCliente)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label10)
        Me.Name = "FrmBuscarCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmBuscarCliente"
        CType(Me.dgListarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgListarCliente As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbapellidos As System.Windows.Forms.RadioButton
    Friend WithEvents rbnombres As System.Windows.Forms.RadioButton
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtbuscar As System.Windows.Forms.TextBox
    Friend WithEvents rbnrodoc As System.Windows.Forms.RadioButton
End Class
