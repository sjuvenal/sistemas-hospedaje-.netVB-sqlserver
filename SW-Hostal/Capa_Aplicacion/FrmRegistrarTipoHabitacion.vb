Imports Capa_Entidades
Imports Capa_Negocio
Public Class FrmRegistrarTipoHabitacion
    Dim oBJtipoHab_cn As New Mantenimiento_CN
    Dim oBJtipoHab_ce As New Mantenimiento_CE
    Dim IntMod As Integer
    Dim IntFila As Integer
    Dim IntIdTH As Integer
    Private Sub FrmRegistrarTipoHabitacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Lista_tipoHabitacion()
        Call Boton_Activar(True, False)
        IntFila = 0
        Call Mostrar_Datagrid(dgtipohabitacion)
    End Sub
    Sub Lista_tipoHabitacion()
        With dgtipohabitacion
            .DataSource = oBJtipoHab_cn.VerData("Lista_TipoHabitacion")
        End With
    End Sub
    Sub Boton_Activar(ByVal EnTru As Boolean, ByVal EnFal As Boolean)
        btnnuevo.Enabled = EnTru
        btnmodificar.Enabled = EnTru
        btnguardar.Enabled = EnFal
        btncancelar.Enabled = EnFal
        btnsalir.Enabled = EnTru
        gbregistros.Enabled = EnTru
        gbdatos.Enabled = EnFal
    End Sub
    Sub Limpiar_texto()
        txttipohabitacion.Text = ""
        txtprecio.Text = ""
        txtdescripcion.Text = ""
    End Sub
    Sub Mostrar_Datagrid(ByVal Dg As DataGridView)
        With Dg
            If .RowCount > 0 Then
                IntFila = .CurrentCell.RowIndex
                If IsDBNull(.Item(0, IntFila).Value) = False Then
                    IntIdTH = .Item(0, IntFila).Value
                    txttipohabitacion.Text = .Item(1, IntFila).Value
                    txtprecio.Text = .Item(2, IntFila).Value
                    txtdescripcion.Text = .Item(3, IntFila).Value
                End If
            End If

        End With
    End Sub
    Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
        IntMod = 0
        Call Boton_Activar(False, True)
        Call Limpiar_texto()
        txttipohabitacion.Focus()
    End Sub

    Private Sub btnmodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificar.Click
        IntMod = 1
        Call Boton_Activar(False, True)
        txttipohabitacion.Focus()
    End Sub

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        If txttipohabitacion.Text = "" Then
            MsgBox("Ingrese el tipo de habitacion", vbCritical, "Error Registrar")
            txttipohabitacion.Focus()
            Exit Sub
        End If
        If txtdescripcion.Text = "" Then
            MsgBox("Ingrese el descripcion del tipo de habitacion", vbCritical, "Error Registrar")
            txtdescripcion.Focus()
            Exit Sub
        End If
        With oBJtipoHab_ce
            .thID = IntIdTH
            .th_TipoHab = txttipohabitacion.Text
            .th_Precio = 15
            .th_descripcion = txtdescripcion.Text
        End With
        If IntMod = 0 Then
            oBJtipoHab_cn.Grabar_TipoHab(oBJtipoHab_ce, 1)
            MsgBox("El Tipo de habitacion se registro Correctamente", vbExclamation, "Registrar TH")
        Else
            oBJtipoHab_cn.Grabar_TipoHab(oBJtipoHab_ce, 2)
            MsgBox("El Tipo de habitacion se Modifico Correctamente", vbExclamation, "Modificar TH")
        End If
        IntMod = 0
        IntIdTH = 0
        Call Lista_tipoHabitacion()
        Call Boton_Activar(True, False)
        Call Limpiar_texto()
    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        IntMod = 0
        IntFila = 0
        Call Mostrar_Datagrid(dgtipohabitacion)
        Call Boton_Activar(True, False)
        btnnuevo.Focus()
    End Sub

    Private Sub dgtipohabitacion_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgtipohabitacion.CellContentClick

    End Sub

    Private Sub dgtipohabitacion_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgtipohabitacion.CellMouseClick
        Call Mostrar_Datagrid(dgtipohabitacion)
    End Sub

    Private Sub txttipohabitacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttipohabitacion.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtdescripcion.Focus()
        End If
        If InStr(1, "abcdefghijklmnñopqrstuvwxyz ABCDEFGHIJKLMNÑOPQRSTUWVXYZ" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txttipohabitacion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttipohabitacion.TextChanged

    End Sub

    Private Sub txtdescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdescripcion.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtdescripcion.Focus()
        End If
        If InStr(1, "abcdefghijklmnñopqrstuvwxyz ABCDEFGHIJKLMNÑOPQRSTUWVXYZ,;." & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtdescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdescripcion.TextChanged

    End Sub
End Class