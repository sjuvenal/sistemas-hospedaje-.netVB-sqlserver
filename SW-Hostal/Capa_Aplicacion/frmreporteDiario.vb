Imports Capa_Entidades
Imports Capa_Negocio
Public Class frmreporteDiario
    Dim oBJtipoHab_cn As New Mantenimiento_CN
    Dim oBJtipoHab_ce As New Mantenimiento_CE
    Dim DtHabAlq As New DataTable
    Private Sub frmreporteDiario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Sub Lista_tipoHabitacion()
        With dgvCasosPendientes
            .DataSource = oBJtipoHab_cn.VerData("[dbo].[ListarAlquilerTransac] '" & DateTimePicker1.Value.Date.Date & "'")
            '.DataSource = oBJtipoHab_cn.VerData(" [dbo].[ListarAlquilerTransac] '11/12/2015'")
        End With
    End Sub

    Private Sub btnexportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        Lista_tipoHabitacion()
        If dgvCasosPendientes.RowCount > 0 Then
            btnexportar.Enabled = True
        Else
            btnexportar.Enabled = False
        End If
    End Sub
    Sub reporte()
        Dim app As Microsoft.Office.Interop.Excel._Application = New Microsoft.Office.Interop.Excel.Application()
        Dim workbook As Microsoft.Office.Interop.Excel._Workbook = app.Workbooks.Add(Type.Missing)
        Dim worksheet As Microsoft.Office.Interop.Excel._Worksheet = Nothing
        worksheet = workbook.Sheets("Hoja1")
        worksheet = workbook.ActiveSheet
        'Aca se agregan las cabeceras de nuestro datagrid.

        For i As Integer = 1 To Me.dgvCasosPendientes.Columns.Count
            worksheet.Cells(1, i) = Me.dgvCasosPendientes.Columns(i - 1).HeaderText
        Next

        'Aca se ingresa el detalle recorrera la tabla celda por celda

        For i As Integer = 0 To Me.dgvCasosPendientes.Rows.Count - 1
            For j As Integer = 0 To Me.dgvCasosPendientes.Columns.Count - 1

                worksheet.Cells(i + 2, j + 1) = Me.dgvCasosPendientes.Rows(i).Cells(j).Value.ToString()


            Next
        Next


        'Aca le damos el formato a nuestro excel

        worksheet.Rows.Item(1).Font.Bold = 1
        worksheet.Rows.Item(1).HorizontalAlignment = 3
        worksheet.Columns.AutoFit()
        worksheet.Columns.HorizontalAlignment = 2

        app.Visible = True
        app = Nothing
        workbook = Nothing
        worksheet = Nothing
        FileClose(1)
        GC.Collect()
    End Sub

    Private Sub btnexportar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexportar.Click
        If dgvCasosPendientes.RowCount > 0 Then
            reporte()
        End If
       



    End Sub

   
    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Close()
    End Sub
End Class