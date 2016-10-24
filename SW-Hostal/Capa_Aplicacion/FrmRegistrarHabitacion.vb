Imports Capa_Entidades
Imports Capa_Negocio
Public Class FrmRegistrarHabitacion
    Dim oBJtipoHab_cn As New Mantenimiento_CN
    Dim oBJtipoHab_ce As New Mantenimiento_CE
    Dim IntMod As Integer
    Dim IntFila As Integer
    Dim IntIdHb As Integer
    Dim IntNroPiso As Integer
    Private Sub FrmRegistrarHabitacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Lista_TipoHabitacion()
        Call Lista_Habitaciones()
        Call Boton_Activar(True, False)
        Call Mostrar_Datagrid(dghabitacion)
    End Sub
    Sub Lista_TipoHabitacion()
        Utilitarios.LlenarCombo(cbTipoHabitacion, "select thId,th_TipoHabitacion from TipoHabitacion", "thId", "th_TipoHabitacion")
        cbTipoHabitacion.SelectedIndex = -1
    End Sub

    Sub Lista_Habitaciones()
        With dghabitacion
            .DataSource = oBJtipoHab_cn.VerData("Lista_Habitacion")
            .Columns(0).Width = 40 'id
            .Columns(1).Width = 100 'tipohabitacion
            .Columns(2).Width = 50 'nrohab
            .Columns(3).Width = 50 'precio
            .Columns(4).Width = 60 'nro piso
            .Columns(5).Width = 40 'tv
            .Columns(6).Width = 40 'cable
            .Columns(7).Width = 40 'jak
            .Columns(8).Width = 100 'estado
            .Columns(9).Visible = False 'descripcion
        End With
    End Sub
    Sub Boton_Activar(ByVal EnTru As Boolean, ByVal EnFal As Boolean)
        btnnuevo.Enabled = EnTru
        btnmodificar.Enabled = EnTru
        btnguardar.Enabled = EnFal
        btncancelar.Enabled = EnFal
        btnsalir.Enabled = EnTru
        dghabitacion.Enabled = EnTru
        GroupBox1.Enabled = EnFal
    End Sub
    Sub Limpiar_texto()
        cbTipoHabitacion.SelectedIndex = -1
        txtnrohab.Text = ""
        txtprecio.Text = ""
        cbpisohab.SelectedIndex = -1
        txtdescripcion.Text = ""
        cbjacuzzi.Checked = False
        cbcable.Checked = False
        cbtv.Checked = False
    End Sub
    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        If cbTipoHabitacion.Text = "" Then
            MsgBox("Ingrese el tipo de habitacion", vbCritical, "Error Registrar")
            cbTipoHabitacion.Focus()
            Exit Sub
        End If
        If txtnrohab.Text = "" Then
            MsgBox("Ingrese el Nro habitacion", vbCritical, "Error Registrar")
            txtnrohab.Focus()
            Exit Sub
        End If

        If txtprecio.Text = "" Then
            MsgBox("Ingrese el Precio habitacion", vbCritical, "Error Registrar")
            txtprecio.Focus()
            Exit Sub
        End If
        If cbpisohab.Text = "" Then
            MsgBox("Ingrese el Nro Piso de habitacion", vbCritical, "Error Registrar")
            cbpisohab.Focus()
            Exit Sub
        End If
        If txtdescripcion.Text = "" Then
            MsgBox("Ingrese la descripcion habitacion", vbCritical, "Error Registrar")
            txtdescripcion.Focus()
            Exit Sub
        End If

        With oBJtipoHab_ce
            .HbID = IntIdHb
            .thID = cbTipoHabitacion.SelectedValue
            .hb_nroHb = txtnrohab.Text
            .hb_NroPiso = IntNroPiso
            .hb_Precio = txtprecio.Text
            .hb_Descripcion = txtdescripcion.Text
            .hb_tv = IIf(cbtv.Checked = True, True, False)
            .hb_cable = IIf(cbcable.Checked = True, True, False)
            .hb_jakussi = IIf(cbjacuzzi.Checked = True, True, False)
            .hb_EstadoAlq = 1
            .hb_Estado = 1
        End With
        If IntMod = 0 Then
            oBJtipoHab_cn.Grabar_Hab(oBJtipoHab_ce, 1)
            MsgBox("se registro Correctamente la Habitacion", vbExclamation, "Registrar Habitacion")
        Else
            oBJtipoHab_cn.Grabar_Hab(oBJtipoHab_ce, 2)
            MsgBox("se Actualizo Correctamente la Habitacion", vbExclamation, "Modificar Habitacion")
        End If
        IntMod = 0
        IntIdHb = 0
        Call Lista_Habitaciones()
        Call Limpiar_texto()
        Call Boton_Activar(True, False)
        Call Mostrar_Datagrid(dghabitacion)

    End Sub

    Private Sub cbpisohab_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbpisohab.SelectedIndexChanged
        If cbpisohab.Text = "Piso Nro 1" Then

            IntNroPiso = 1
        ElseIf cbpisohab.Text = "Piso Nro 2" Then

            IntNroPiso = 2
        ElseIf cbpisohab.Text = "Piso Nro 3" Then

            IntNroPiso = 3

        ElseIf cbpisohab.Text = "Piso Nro 4" Then
            IntNroPiso = 4

        ElseIf cbpisohab.Text = "Piso Nro 5" Then
            IntNroPiso = 5

        End If
    End Sub

    Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
        IntMod = 0
        Call Boton_Activar(False, True)
        Call Limpiar_texto()
        cbTipoHabitacion.Focus()
    End Sub

    Sub Mostrar_Datagrid(ByVal Dg As DataGridView)
        With dghabitacion
            If .RowCount > 0 Then
                IntFila = .CurrentCell.RowIndex
                If IsDBNull(.Item(0, IntFila).Value) = False Then
                    IntIdHb = .Item("ID", IntFila).Value
                    cbTipoHabitacion.Text = .Item("TipoHab", IntFila).Value
                    txtnrohab.Text = .Item("NroHab", IntFila).Value
                    txtprecio.Text = .Item("precio", IntFila).Value
                    cbpisohab.Text = .Item("NroPiso", IntFila).Value
                    cbtv.Checked = .Item("TV", IntFila).Value
                    cbcable.Checked = .Item("Cable", IntFila).Value
                    cbjacuzzi.Checked = .Item("Jak", IntFila).Value
                    'txtnombres.Text = .Item("Estado", IntFila).Value
                    txtdescripcion.Text = .Item("hb_Descripcion", IntFila).Value
                End If
            End If

        End With
    End Sub

    Private Sub dghabitacion_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dghabitacion.CellContentClick

    End Sub

    Private Sub dghabitacion_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dghabitacion.CellMouseClick
        Call Mostrar_Datagrid(dghabitacion)
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        IntMod = 0
        IntFila = 0
        Call Mostrar_Datagrid(dghabitacion)
        Call Boton_Activar(True, False)
        btnnuevo.Focus()
    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Close()
    End Sub

    Private Sub btnmodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificar.Click
        IntMod = 1
        Call Boton_Activar(False, True)
        cbTipoHabitacion.Focus()
    End Sub

    Private Sub txtdescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdescripcion.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnguardar.Focus()
        End If
        If InStr(1, "abcdefghijklmnñopqrstuvwxyz ABCDEFGHIJKLMNÑOPQRSTUWVXYZ,;." & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtdescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdescripcion.TextChanged

    End Sub

    Private Sub txtprecio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtprecio.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtdescripcion.Focus()
        End If
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtprecio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtprecio.TextChanged

    End Sub

    Private Sub txtnrohab_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnrohab.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtdescripcion.Focus()
        End If
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtnrohab_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnrohab.TextChanged

    End Sub
End Class