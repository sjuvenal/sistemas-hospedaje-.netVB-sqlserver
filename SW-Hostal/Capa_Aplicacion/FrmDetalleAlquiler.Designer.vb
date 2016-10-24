<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDetalleAlquiler
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DgDetalle = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hab1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hab2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hab3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hab4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnalquiler = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        CType(Me.DgDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgDetalle
        '
        Me.DgDetalle.AllowUserToAddRows = False
        Me.DgDetalle.AllowUserToDeleteRows = False
        Me.DgDetalle.BackgroundColor = System.Drawing.Color.White
        Me.DgDetalle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DgDetalle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgDetalle.ColumnHeadersVisible = False
        Me.DgDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Hab1, Me.Hab2, Me.Hab3, Me.Hab4, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10})
        Me.DgDetalle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DgDetalle.GridColor = System.Drawing.Color.White
        Me.DgDetalle.Location = New System.Drawing.Point(12, 12)
        Me.DgDetalle.Name = "DgDetalle"
        Me.DgDetalle.ReadOnly = True
        Me.DgDetalle.RowHeadersWidth = 20
        Me.DgDetalle.RowTemplate.Height = 50
        Me.DgDetalle.Size = New System.Drawing.Size(641, 517)
        Me.DgDetalle.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 60
        '
        'Hab1
        '
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Hab1.DefaultCellStyle = DataGridViewCellStyle1
        Me.Hab1.HeaderText = "Hab1"
        Me.Hab1.Name = "Hab1"
        Me.Hab1.ReadOnly = True
        Me.Hab1.Width = 120
        '
        'Hab2
        '
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Hab2.DefaultCellStyle = DataGridViewCellStyle2
        Me.Hab2.HeaderText = "Hab2"
        Me.Hab2.Name = "Hab2"
        Me.Hab2.ReadOnly = True
        Me.Hab2.Width = 120
        '
        'Hab3
        '
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Hab3.DefaultCellStyle = DataGridViewCellStyle3
        Me.Hab3.HeaderText = "Hab3"
        Me.Hab3.Name = "Hab3"
        Me.Hab3.ReadOnly = True
        Me.Hab3.Width = 120
        '
        'Hab4
        '
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Hab4.DefaultCellStyle = DataGridViewCellStyle4
        Me.Hab4.HeaderText = "Hab4"
        Me.Hab4.Name = "Hab4"
        Me.Hab4.ReadOnly = True
        Me.Hab4.Width = 120
        '
        'Column6
        '
        Me.Column6.HeaderText = "Column6"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 50
        '
        'Column7
        '
        Me.Column7.HeaderText = "hab11"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Visible = False
        Me.Column7.Width = 30
        '
        'Column8
        '
        Me.Column8.HeaderText = "hab22"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Visible = False
        Me.Column8.Width = 30
        '
        'Column9
        '
        Me.Column9.HeaderText = "hba33"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Visible = False
        Me.Column9.Width = 30
        '
        'Column10
        '
        Me.Column10.HeaderText = "hab44"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Visible = False
        Me.Column10.Width = 30
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnalquiler)
        Me.GroupBox1.Controls.Add(Me.btnsalir)
        Me.GroupBox1.Location = New System.Drawing.Point(659, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(104, 517)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'btnalquiler
        '
        Me.btnalquiler.Location = New System.Drawing.Point(6, 19)
        Me.btnalquiler.Name = "btnalquiler"
        Me.btnalquiler.Size = New System.Drawing.Size(92, 60)
        Me.btnalquiler.TabIndex = 0
        Me.btnalquiler.Text = "Alquilar"
        Me.btnalquiler.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(6, 451)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(92, 60)
        Me.btnsalir.TabIndex = 0
        Me.btnsalir.Text = "Close"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'FrmDetalleAlquiler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 541)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DgDetalle)
        Me.Name = "FrmDetalleAlquiler"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmDetalleAlquiler"
        CType(Me.DgDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DgDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Hab1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Hab2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Hab3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Hab4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnalquiler As System.Windows.Forms.Button
    Friend WithEvents btnsalir As System.Windows.Forms.Button
End Class
