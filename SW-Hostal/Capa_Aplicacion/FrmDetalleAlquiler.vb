Imports Capa_Entidades
Imports Capa_Negocio
Public Class FrmDetalleAlquiler
    Dim oBJDetAlq_cn As New Mantenimiento_CN
    Dim oBJDetAlq_ce As New Mantenimiento_CE
    Dim DtNroPiso, DtHabNroPiso As New DataTable
    Dim IntFila As Integer

    Private Sub FrmDetalleAlquiler_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call cargarDetalle()
    End Sub
    Sub cargarDetalle()
        Dim iii As Integer = 0
        Dim intcol As Integer = 1
        DtNroPiso = oBJDetAlq_cn.Obtener_NroPiso()
        For i As Integer = 0 To DtNroPiso.Rows.Count - 1

            DgDetalle.Rows.Add()
            DgDetalle.Item(0, iii).Value = "Piso Nro " & DtNroPiso(i)(0)
            'Me.DgDetalle.Item(0, iii).Style.BackColor = Color.Blue
            Me.DgDetalle.Rows(iii).DefaultCellStyle.BackColor = Color.Blue
            Me.DgDetalle.Rows(iii).Height = 20
            iii += 1
            DtHabNroPiso = oBJDetAlq_cn.Obtener_HabitacionNroPiso(DtNroPiso(i)(0))
            DgDetalle.Rows.Add()
            For ii As Integer = 0 To DtHabNroPiso.Rows.Count - 1

                DgDetalle.Item(intcol, iii).Value = "Hab-" & DtHabNroPiso(ii)(0) & "-" & Chr(13) &
                  DtHabNroPiso(ii)(1) & Chr(13) &
                  DtHabNroPiso(ii)(3) & Chr(13)
                DgDetalle.Item(intcol + 5, iii).Value = DtHabNroPiso(ii)(4)

                DgDetalle.Item(intcol, iii).Style.Alignment = DataGridViewContentAlignment.MiddleCenter 'centro
                If DtHabNroPiso(ii)(2) = 1 Then
                    Me.DgDetalle.Item(intcol, iii).Style.BackColor = Color.Green
                Else
                    Me.DgDetalle.Item(intcol, iii).Style.BackColor = Color.Red
                End If
                intcol += 1
                If intcol = 5 Then
                    intcol = 1
                    iii += 1
                    DgDetalle.Rows.Add()
                End If
            Next
            intcol = 1
            iii += 1
        Next
    End Sub

    Private Sub DgDetalle_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DgDetalle.CellMouseClick
        Dim IntIdHab As Integer
        With DgDetalle
            If .RowCount > 0 Then
                IntFila = .CurrentCell.RowIndex

                If e.ColumnIndex = .Columns.Item("Hab1").Index Then

                    IntIdHab = .Item(6, IntFila).Value

                ElseIf e.ColumnIndex = .Columns.Item("Hab2").Index Then

                    IntIdHab = .Item(7, IntFila).Value

                ElseIf e.ColumnIndex = .Columns.Item("Hab3").Index Then

                    IntIdHab = .Item(8, IntFila).Value

                ElseIf e.ColumnIndex = .Columns.Item("Hab4").Index Then

                    IntIdHab = .Item(9, IntFila).Value

                End If
                FrmDetalleHabitacion.Buscar_HabitacionAlq(IntIdHab)
            End If
        End With
    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub btnalquiler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnalquiler.Click
        frmreporteDiario.MdiParent = MDIHostal_Viletta
        frmreporteDiario.Show()
    End Sub
End Class