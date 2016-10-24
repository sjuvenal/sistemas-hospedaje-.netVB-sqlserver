Imports Capa_Entidades
Imports Capa_Negocio
Public Class FrmBuscarHabitacion
    Dim oBJBuscarHab_cn As New Mantenimiento_CN
    Dim oBJBuscarHab_ce As New Mantenimiento_CE
    Dim IntMod As Integer
    Dim IntFila As Integer
    Dim IntHbId As Integer
    Dim StrTipoHab As String
    Dim IntNroHab As Integer
    Dim DbPrecio As Double
    Dim StrNroPiso As String
    Dim StrBuscar As String
    Dim StrEstado As String
    Private Sub FrmBuscarHabitacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Lista_hab(1, "")
        rbtipohab.Checked = True
    End Sub
    Sub Lista_hab(ByVal IntBuscar As Integer, ByVal StrOpcion As String)
        With dgListarhab
            .DataSource = oBJBuscarHab_cn.VerData("Buscar_Habitacion " & IntBuscar & ",'" & StrOpcion & "'")
            .Columns(0).Width = 40
            .Columns(1).Width = 85
            .Columns(2).Width = 45
            .Columns(3).Width = 50
            .Columns(4).Width = 60
            .Columns(5).Width = 40
            .Columns(6).Width = 40
            .Columns(7).Width = 40
            .Columns(8).Width = 70
            .Columns(9).Visible = False
            If .RowCount > 0 Then
                btnaceptar.Enabled = True

            Else
                btnaceptar.Enabled = False
            End If
        End With
    End Sub

    Private Sub rbtipohab_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtipohab.CheckedChanged
        Call Lista_hab(1, "")
        Utilitarios.LlenarCombo(Cbbuscar, "select ThId,th_TipoHabitacion from TipoHabitacion order by th_TipoHabitacion", "ThId", "th_TipoHabitacion")
        Cbbuscar.SelectedIndex = -1
        StrBuscar = "tipohabitacion"
    End Sub

    Private Sub rbnropiso_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbnropiso.CheckedChanged
        Call Lista_hab(1, "")
        Utilitarios.LlenarCombo(Cbbuscar, "select distinct hb_NroPiso,'Piso Nro' + cast(hb_NroPiso as CHAR) NroPiso from habitacion where hb_NroPiso is not null order by hb_NroPiso", "hb_NroPiso", "NroPiso")
        Cbbuscar.SelectedIndex = -1
        StrBuscar = "nropiso"
    End Sub

    Private Sub Cbbuscar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cbbuscar.SelectedIndexChanged

    End Sub

    Private Sub Cbbuscar_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cbbuscar.SelectionChangeCommitted
        Call Lista_hab(Cbbuscar.SelectedValue, StrBuscar)
    End Sub

    Private Sub dgListarhab_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgListarhab.CellContentClick

    End Sub
    Sub Mostrar_Datagrid(ByVal Dg As DataGridView)
        With dgListarhab
            If .RowCount > 0 Then
                IntFila = .CurrentCell.RowIndex
                If IsDBNull(.Item(0, IntFila).Value) = False Then
                    GIntHabID = .Item("ID", IntFila).Value
                    GStrTipoHab = .Item("TipoHab", IntFila).Value
                    GIntNroHab = .Item("NroHab", IntFila).Value
                    GDbPrecio = .Item("Precio", IntFila).Value
                    GStrNroPiso = .Item("NroPiso", IntFila).Value
                    GblTV = .Item("TV", IntFila).Value
                    GBlClable = .Item("Cable", IntFila).Value
                    GBlJak = .Item("Jak", IntFila).Value
                    txtdescripcion.Text = .Item("hb_descripcion", IntFila).Value
                    StrEstado = .Item("Estado", IntFila).Value
                End If
            End If
        End With
    End Sub

    Private Sub dgListarhab_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgListarhab.CellMouseClick
        Call Mostrar_Datagrid(dgListarhab)
    End Sub

    Private Sub dgListarhab_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgListarhab.CellMouseDoubleClick
        Call Mostrar_Datagrid(dgListarhab)
        If StrEstado <> "Alquilado" Then
            Me.Close()
        Else
            MsgBox("Esta habitacion esta Alquilado", vbCritical, "Error Alquilar")
        End If
    End Sub

    Private Sub btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        Call Mostrar_Datagrid(dgListarhab)
        If StrEstado <> "Alquilado" Then
            Me.Close()
        Else
            MsgBox("Esta habitacion esta Alquilado", vbCritical, "Error Alquilar")
        End If
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        GIntHabID = 0
        Me.Close()
    End Sub
End Class