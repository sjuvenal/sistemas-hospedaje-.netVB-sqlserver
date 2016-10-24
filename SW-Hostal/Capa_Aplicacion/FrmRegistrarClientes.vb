Imports Capa_Entidades
Imports Capa_Negocio
Public Class FrmRegistrarClientes
    Dim oBJClientes_cn As New Mantenimiento_CN
    Dim oBJClientes_ce As New Mantenimiento_CE
    Dim IntMod As Integer
    Dim IntFila As Integer
    Dim IntCliId As Integer
    Private Sub FrmRegistrarClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Lista_Pais()
        Call Lista_Clientes()
        Call Boton_Activar(True, False)
        Call Mostrar_Datagrid(DgClientes)
    End Sub
    Sub Boton_Activar(ByVal EnTru As Boolean, ByVal EnFal As Boolean)
        btnnuevo.Enabled = EnTru
        btnmodificar.Enabled = EnTru
        btnguardar.Enabled = EnFal
        btncancelar.Enabled = EnFal
        btnsalir.Enabled = EnTru
        DgClientes.Enabled = EnTru
        GroupBox1.Enabled = EnFal
        GroupBox3.Enabled = EnFal
        txtnrodoc.Enabled = EnFal
    End Sub
    Sub Limpiar_texto()
        txtnombres.Text = ""
        txtpaterno.Text = ""
        txtmaterno.Text = ""
        CbrEstado.Checked = True
        cbtipodociden.SelectedIndex = -1
        txtnrodoc.Text = ""
        rbmasculino.Checked = True
        cbpais.SelectedIndex = -1
        cbprovincia.SelectedIndex = -1
        cbdistrito.SelectedIndex = -1
        cbciudad.SelectedIndex = -1
        txtdireccion.Text = ""
    End Sub
    Sub Lista_Pais()
        Utilitarios.LlenarCombo(cbpais, "select PaId,Pa_Pais from pais order by Pa_Pais", "PaId", "Pa_Pais")
        cbpais.SelectedIndex = -1
        Utilitarios.LlenarCombo(cbtipodociden, "select tIiD,Ti_Identificacion from tipoIdentificacion order by Ti_Identificacion", "tIiD", "Ti_Identificacion")
        cbtipodociden.SelectedIndex = -1
    End Sub
    Sub Lista_Clientes()
        With DgClientes
            .DataSource = oBJClientes_cn.VerData("Lista_Clientes")
            .Columns(0).Width = 40 'id
            .Columns(1).Width = 100 'nombres
            .Columns(2).Width = 100 'paterno
            .Columns(3).Width = 100 'materno
            .Columns(4).Width = 70 'sexo
            .Columns(5).Visible = False 'tipodoc
            .Columns(6).Visible = False 'nro
            .Columns(7).Width = 150 'direccion
            .Columns(8).Width = 100 'distrito
            .Columns(9).Visible = False 'provicnia
            .Columns(10).Visible = False 'region
            .Columns(11).Width = 60 'pais
            .Columns(12).Width = 140 'fecharegistro
            .Columns(13).Width = 40 'estado
            .Columns(14).Visible = False
            .Columns(15).Visible = False
            .Columns(16).Visible = False
            .Columns(17).Visible = False
            .Columns(18).Visible = False
            .Columns(19).Visible = False
            .Columns(20).Visible = False


        End With
    End Sub
    Sub Buscar_Ciudad(ByVal IntCiudad As Integer)
        Utilitarios.LlenarCombo(cbciudad, "select ReId,re_region from region WHERE Paid=' " & IntCiudad & "' order by re_region", "ReId", "re_region")
        cbciudad.SelectedIndex = -1
    End Sub
    Sub Buscar_Provincia(ByVal IntProv As Integer)
        Utilitarios.LlenarCombo(cbprovincia, "select PrId,Pr_provincia from provincia where ReId=' " & IntProv & "' order by Pr_provincia", "PrId", "Pr_provincia")
        cbprovincia.SelectedIndex = -1
    End Sub
    Sub Buscar_Distrito(ByVal IntDist As Integer)
        Utilitarios.LlenarCombo(cbdistrito, "select DiId,Di_distrito from distrito where PrId='" & IntDist & "' order by Di_distrito", "DiId", "Di_distrito")
        cbdistrito.SelectedIndex = -1
    End Sub
    Private Sub cbpais_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbpais.SelectionChangeCommitted
        Buscar_Ciudad(cbpais.SelectedValue)
    End Sub
    Private Sub cbciudad_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbciudad.SelectionChangeCommitted
        Call Buscar_Provincia(cbciudad.SelectedValue)
    End Sub
    Private Sub cbprovincia_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbprovincia.SelectionChangeCommitted
        Call Buscar_Distrito(cbciudad.SelectedValue)
    End Sub

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        If txtnombres.Text = "" Then
            MsgBox("Ingrese nombres del cliente", vbCritical, "Error Registrar")
            txtnombres.Focus()
            Exit Sub
        End If
        If txtpaterno.Text = "" Then
            MsgBox("Ingrese apellido del cliente", vbCritical, "Error Registrar")
            txtpaterno.Focus()
            Exit Sub
        End If

        If txtmaterno.Text = "" Then
            MsgBox("Ingrese apellido del cliente", vbCritical, "Error Registrar")
            txtmaterno.Focus()
            Exit Sub
        End If
        If cbtipodociden.Text = "" Then
            MsgBox("Ingrese tipo doc del cliente", vbCritical, "Error Registrar")
            cbtipodociden.Focus()
            Exit Sub
        End If
        If txtnrodoc.Text = "" Then
            MsgBox("Ingrese nro de documento cliente", vbCritical, "Error Registrar")
            txtnrodoc.Focus()
            Exit Sub
        End If

        If cbpais.Text = "" Then
            MsgBox("Ingrese pais del cliente", vbCritical, "Error Registrar")
            cbpais.Focus()
            Exit Sub
        End If
        If cbciudad.Text = "" Then
            MsgBox("Ingrese ciudad del cliente", vbCritical, "Error Registrar")
            cbciudad.Focus()
            Exit Sub
        End If
        If cbprovincia.Text = "" Then
            MsgBox("Ingrese provincia del cliente", vbCritical, "Error Registrar")
            cbprovincia.Focus()
            Exit Sub
        End If
        If cbdistrito.Text = "" Then
            MsgBox("Ingrese distrito del cliente", vbCritical, "Error Registrar")
            cbdistrito.Focus()
            Exit Sub
        End If
        If txtdireccion.Text = "" Then
            MsgBox("Ingrese direccion del cliente", vbCritical, "Error Registrar")
            txtdireccion.Focus()
            Exit Sub
        End If
        With oBJClientes_ce
            .ClId = IntCliId
            .Cl_Nombres = txtnombres.Text
            .Cl_ApPaterno = txtpaterno.Text
            .Cl_ApMaterno = txtmaterno.Text
            .Cl_Sexo = IIf(rbmasculino.Checked = True, True, False)
            .TiID = cbtipodociden.SelectedValue
            .Cl_TipoDocIdent = txtnrodoc.Text
            .Cl_Lugar = cbdistrito.SelectedValue
            .Cl_Direccion = txtdireccion.Text
            .Cl_Estado = CbrEstado.CheckAlign
        End With
        If IntMod = 0 Then
            oBJClientes_cn.Grabar_Clientes(oBJClientes_ce, 1)
            MsgBox("Se registro Correctamente el Cliente", vbExclamation, "Registrar Clientes")
        Else
            oBJClientes_cn.Grabar_Clientes(oBJClientes_ce, 1)
            MsgBox("Se Modifico Correctamente el Cliente", vbExclamation, "Modificar Clientes")
        End If
        IntMod = 0
        IntCliId = 0
        Call Lista_Clientes()
        Call Boton_Activar(True, False)
        Call Limpiar_texto()
    End Sub

    Private Sub DgClientes_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgClientes.CellContentClick
        
    End Sub
    Sub Mostrar_Datagrid(ByVal Dg As DataGridView)
        With DgClientes
            If .RowCount > 0 Then
                IntFila = .CurrentCell.RowIndex
                If IsDBNull(.Item(0, IntFila).Value) = False Then
                    IntCliId = .Item("ID", IntFila).Value
                    txtnombres.Text = .Item("Nombres", IntFila).Value
                    txtpaterno.Text = .Item("Paterno", IntFila).Value
                    txtmaterno.Text = .Item("Materno", IntFila).Value
                    If .Item("IdSexo", IntFila).Value = True Then
                        rbmasculino.Checked = True
                    Else
                        rbfemenino.Checked = True
                    End If
                    cbtipodociden.SelectedValue = .Item("IdTipoDocIdent", IntFila).Value
                    txtnrodoc.Text = .Item("NroDoc", IntFila).Value
                    txtdireccion.Text = .Item("Direccion", IntFila).Value
                    cbpais.SelectedValue = .Item("IdPais", IntFila).Value
                    Call Buscar_Ciudad(.Item("IdPais", IntFila).Value)
                    cbciudad.SelectedValue = .Item("IdRegion", IntFila).Value
                    Call Buscar_Provincia(.Item("IdRegion", IntFila).Value)
                    cbprovincia.SelectedValue = .Item("IdProvincia", IntFila).Value
                    Call Buscar_Distrito(.Item("IdProvincia", IntFila).Value)
                    cbdistrito.SelectedValue = .Item("IdDistrito", IntFila).Value
                    CbrEstado.Checked = .Item("Estado", IntFila).Value
                End If
            End If
            txtnrodoc.Enabled = False
        End With
    End Sub

    Private Sub cbpais_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbpais.SelectedIndexChanged

    End Sub

    Private Sub DgClientes_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DgClientes.CellMouseClick
        Call Mostrar_Datagrid(DgClientes)
    End Sub

    Private Sub btnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
        IntMod = 0
        Call Boton_Activar(False, True)
        Call Limpiar_texto()
        txtnombres.Focus()
    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        IntMod = 0
        IntFila = 0
        Call Mostrar_Datagrid(DgClientes)
        Call Boton_Activar(True, False)
        btnnuevo.Focus()
    End Sub

    Private Sub btnmodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificar.Click
        IntMod = 1
        Call Boton_Activar(False, True)
        txtnrodoc.Enabled = False
        txtnombres.Focus()
    End Sub

    Private Sub txtnombres_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnombres.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtpaterno.Focus()
        End If
        If InStr(1, "abcdefghijklmnñopqrstuvwxyz ABCDEFGHIJKLMNÑOPQRSTUWVXYZ" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtnombres_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnombres.TextChanged

    End Sub

    Private Sub txtpaterno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpaterno.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtpaterno.Focus()
        End If
        If InStr(1, "abcdefghijklmnñopqrstuvwxyz ABCDEFGHIJKLMNÑOPQRSTUWVXYZ" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtpaterno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpaterno.TextChanged

    End Sub

    Private Sub txtmaterno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmaterno.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cbtipodociden.Focus()
        End If
        If InStr(1, "abcdefghijklmnñopqrstuvwxyz ABCDEFGHIJKLMNÑOPQRSTUWVXYZ" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtmaterno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmaterno.TextChanged

    End Sub

    Private Sub txtnrodoc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnrodoc.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cbtipodociden.Focus()
        End If
        If InStr(1, "1234567890" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtnrodoc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnrodoc.TextChanged

    End Sub

    Private Sub txtdireccion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdireccion.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cbtipodociden.Focus()
        End If
        If InStr(1, "abcdefghijklmnñopqrstuvwxyz ABCDEFGHIJKLMNÑOPQRSTUWVXYZ," & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtdireccion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdireccion.TextChanged

    End Sub

    Private Sub cbtipodociden_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbtipodociden.SelectedIndexChanged

    End Sub
End Class