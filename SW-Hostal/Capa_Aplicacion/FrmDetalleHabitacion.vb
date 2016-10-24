Imports Capa_Entidades
Imports Capa_Negocio
Public Class FrmDetalleHabitacion
    Dim oBJDetAlq_cn As New Mantenimiento_CN
    Dim oBJDetAlq_ce As New Mantenimiento_CE
    Dim DtHabAlq As New DataTable
    Dim IntFila As Integer
    Dim i, tt As Integer
    Dim IntDias As Integer
    Dim IntHbId As Integer
    Dim IntAlqId As Integer
    Private Sub FrmDetalleHabitacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Sub Buscar_HabitacionAlq(ByVal IntIdHab As Integer)
        DtHabAlq = oBJDetAlq_cn.Obtener_HabitacionAlquilada(IntIdHab)
        If DtHabAlq.Rows.Count > 0 Then
            Label10.Text = "NRO H" & DtHabAlq(0)(2) & " - " & DtHabAlq(0)(4)
            IntHbId = IntIdHab
            txttipo.Text = DtHabAlq(0)(1)
            txtprecio.Text = DtHabAlq(0)(3)
            cbxTV.Checked = DtHabAlq(0)(5)
            cbxCABLE.Checked = DtHabAlq(0)(6)
            cbxJAK.Checked = DtHabAlq(0)(7)
            IntAlqId = DtHabAlq(0)("AlId")
            txtfechaentrada.Text = DtHabAlq(0)("Al_FechaIngreso")
            DTPhrEntrada.Text = DtHabAlq(0)("Al_HoraIngreso")
            txtfechatermino.Text = DtHabAlq(0)("Al_FechaSalida")
            DTPhrSalida.Text = DtHabAlq(0)("Al_HoraSalida")
            txtdescripcion.Text = DtHabAlq(0)("al_Descripcion")
            IntDias = DtHabAlq(0)("Dias")
            Call CalcularTiempo()
            Me.ShowDialog()
        Else
            Me.Close()
        End If

    End Sub

    Sub CalcularTiempo()

        Dim HoraMinEntrada() As String = Split(FormatDateTime(Me.DTPhrEntrada.Value, DateFormat.ShortTime), ":")
        Dim HoraMinSalida() As String = Split(FormatDateTime(Me.DTPhrSalida.Value, DateFormat.ShortTime), ":")

        'Dim IntDias As Integer = (DTPFcSalida.Value.Day - DTPFcEntrada.Value.Day)
        Dim IntHora As Integer = (DTPhrSalida.Value.Hour - DTPhrEntrada.Value.Hour)
        Dim IntMin As Integer

        IntHora = HoraMinSalida(0) - HoraMinEntrada(0)

        IntMin = HoraMinEntrada(1) - HoraMinSalida(1)

        If (DTPhrSalida.Value.Minute - DTPhrEntrada.Value.Minute) < 0 Then

            IntMin = ((HoraMinEntrada(1) - 60) * -1) + HoraMinSalida(1)
            IntHora = IntHora - 1

        Else

            IntMin = (DTPhrSalida.Value.Minute - DTPhrEntrada.Value.Minute)

        End If

        If IntHora < 0 Then

            If i = 0 Then
                'DTPFcSalida.Value = DTPFcSalida.Value.AddDays(1)
            End If

            i = 1

            IntHora = (tt + 1) + HoraMinSalida(0)
        Else
            tt = IntHora
        End If

        If IntHora = 23 Then
            tt = 0
            i = 0
        End If

        txtdias.Text = IIf(IntDias <> 0, IntDias & " Dias ", "") & IIf(IntHora <> 0, IntHora & " Hora ", "") & IIf(IntMin <> 0, IntMin & " Minutos ", "")


    End Sub

    Private Sub btnadm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadm.Click
        If GroupBox1.Visible = True Then
            With oBJDetAlq_ce
                .AlId = IntAlqId
                .HbID = IntHbId
            End With
            oBJDetAlq_cn.ADministrar_Alquiler(oBJDetAlq_ce, IIf(RBOLETA.Checked = True, 1, 2))
            GroupBox1.Visible = False
            Call ImprimirDoc(IntAlqId, IntHbId)
            FrmDetalleAlquiler.cargarDetalle()
            Me.Close()
        Else
            GroupBox1.Visible = True
        End If
    End Sub
    Sub ImprimirDoc(ByVal Alid As Integer, ByVal Alhb As Integer)

        DtHabAlq = oBJDetAlq_cn.Obtener_Comprobante(Alid, Alhb)
        If DtHabAlq.Rows.Count > 0 Then

            Dim app As Microsoft.Office.Interop.Excel._Application = New Microsoft.Office.Interop.Excel.Application()
            Dim workbook As Microsoft.Office.Interop.Excel._Workbook = app.Workbooks.Add(Type.Missing)
            Dim worksheet As Microsoft.Office.Interop.Excel._Worksheet = Nothing
            worksheet = workbook.Sheets("Hoja1")
            worksheet = workbook.ActiveSheet
            'Aca se agregan las cabeceras de nuestro datagrid.


            worksheet.Cells(1, 1) = "COMPRBANTE"
            worksheet.Cells(1, 2) = DtHabAlq(0)(1)
            worksheet.Cells(1, 3) = "NRO DOC"
            worksheet.Cells(1, 4) = "'0000" & DtHabAlq(0)(2) & " - 00000" & DtHabAlq(0)(3)

            worksheet.Cells(2, 1) = "CLIENTE"
            worksheet.Cells(2, 2) = DtHabAlq(0)(4)
            worksheet.Cells(2, 3) = "FECHA"
            worksheet.Cells(2, 4) = DtHabAlq(0)(0)

            worksheet.Cells(3, 1) = "HABITACION"
            worksheet.Cells(3, 2) = DtHabAlq(0)(5)


            worksheet.Cells(4, 1) = "TIPO HABITACION"
            worksheet.Cells(4, 2) = DtHabAlq(0)(6)

            worksheet.Cells(5, 1) = "PRECIO"
            worksheet.Cells(5, 2) = DtHabAlq(0)(9)

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

        End If
    End Sub
    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        GroupBox1.Visible = False
        Close()
    End Sub
End Class