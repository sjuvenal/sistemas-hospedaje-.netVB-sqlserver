Imports Capa_Entidades
Imports Capa_Negocio
Public Class FrmBuscarCliente
    Dim oBJBuscarClie_cn As New Mantenimiento_CN
    Dim oBJBuscarClie_ce As New Mantenimiento_CE
    Dim IntMod As Integer
    Dim IntFila As Integer
    Dim IntCliid As Integer
    Dim strnombres As String
    Dim strDocumento As String
    Private Sub FrmBuscarCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Lista_Cliente("", "")
    End Sub
    Sub Lista_Cliente(ByVal STrBuscar As String, ByVal StrOpcion As String)
        With dgListarCliente
            .DataSource = oBJBuscarClie_cn.VerData("Buscar_Cliente '" & STrBuscar & "','" & StrOpcion & "'")
            .Columns(0).Width = 40
            .Columns(1).Width = 85
            .Columns(2).Width = 110
            .Columns(3).Width = 60
            .Columns(4).Width = 70
            .Columns(5).Width = 80
            .Columns(6).Width = 120
            .Columns(7).Width = 100
            '.Columns(8).Width = 70

            If .RowCount > 0 Then
                btnaceptar.Enabled = True

            Else
                btnaceptar.Enabled = False
            End If
        End With
    End Sub

    Private Sub txtbuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbuscar.TextChanged
        If rbnrodoc.Checked = True Then
            Call Lista_Cliente(txtbuscar.Text, "nrodoc")
        ElseIf rbnombres.Checked = True Then
            Call Lista_Cliente(txtbuscar.Text, "nombres")
        ElseIf rbapellidos.Checked = True Then
            Call Lista_Cliente(txtbuscar.Text, "apellidos")
        End If
    End Sub

    Private Sub rbnrodoc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbnrodoc.CheckedChanged
        txtbuscar.Focus()
    End Sub

    Private Sub rbnombres_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbnombres.CheckedChanged
        txtbuscar.Focus()
    End Sub

    Private Sub rbapellidos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbapellidos.CheckedChanged
        txtbuscar.Focus()
    End Sub

    Private Sub btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        Call Mostrar_Datagrid(dgListarCliente)
        Me.Close()
    End Sub
    Sub Mostrar_Datagrid(ByVal Dg As DataGridView)
        With dgListarCliente
            If .RowCount > 0 Then
                IntFila = .CurrentCell.RowIndex
                If IsDBNull(.Item(0, IntFila).Value) = False Then
                    GintCliId = .Item("ID", IntFila).Value
                    GStrNombres = .Item("Nombres", IntFila).Value & " " & .Item("Apellidos", IntFila).Value
                    GStrDocumento = .Item("TidoDoc", IntFila).Value & "" & .Item("NroDoc", IntFila).Value

                End If
            End If
        End With
    End Sub

    Private Sub dgListarhab_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgListarCliente.CellContentClick

    End Sub

    Private Sub dgListarhab_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgListarCliente.CellMouseClick
        Call Mostrar_Datagrid(dgListarCliente)
    End Sub

    Private Sub dgListarCliente_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgListarCliente.CellMouseDoubleClick
        Call Mostrar_Datagrid(dgListarCliente)
        Close()
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub
End Class