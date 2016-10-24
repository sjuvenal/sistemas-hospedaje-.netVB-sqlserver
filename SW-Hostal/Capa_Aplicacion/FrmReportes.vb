Imports Microsoft.Reporting.WinForms
Imports Capa_Entidades
Imports Capa_Negocio
Imports System.IO
Public Class FrmReportes
    'Dim Mode As DisplayMode = DisplayMode.Normal
    Dim bImprimirAuto As Boolean = False
    Dim bCerrarAuto As Boolean = False

    Dim nEstadoRec As Integer
    Dim nTipoImp As Integer
    Dim ServerReportRec As ServerReport
    Dim DtHabAlq As New DataTable
    Dim oBJDetAlq_cn As New Mantenimiento_CN
    Dim oBJDetAlq_ce As New Mantenimiento_CE

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call ImprimirBoletaOperaciones(234)
    End Sub

    Public Sub ImprimirBoletaOperaciones(ByVal nNroTrans As Integer, Optional ByVal Mode As DisplayMode = DisplayMode.Normal, Optional ByVal nTipo As Integer = 0)
        'Public Sub ImprimirBoletaOperaciones(ByVal nNroTrans As Integer, Optional ByVal Mode As DisplayMode = DisplayMode.Normal, Optional ByVal nTipo As Integer = 0)
        'Try

        DtHabAlq = oBJDetAlq_cn.Obtener_ServidorReportes()


        RptV.ProcessingMode = ProcessingMode.Remote
        RptV.ShowParameterPrompts = False

        Dim psUbiNomReporte As String = "/REPORTES/Boleta"

        Dim ServerReport As ServerReport

        ServerReport = RptV.ServerReport

        Dim Credentials As System.Net.ICredentials
        Credentials = System.Net.CredentialCache.DefaultCredentials

        Dim rsCredentials As ReportServerCredentials
        rsCredentials = ServerReport.ReportServerCredentials

        rsCredentials.NetworkCredentials = Credentials

        ServerReport.ReportServerUrl = DtHabAlq(0)(0)
        ServerReport.ReportPath = psUbiNomReporte


        Dim prmnNroTrans As New ReportParameter()
        prmnNroTrans.Name = "nNroTrans"
        prmnNroTrans.Values.Add(nNroTrans)

        Dim prmnTipo As New ReportParameter()
        prmnTipo.Name = "Tipo"
        prmnTipo.Values.Add(nTipo)

        Dim parameters() As ReportParameter = {prmnNroTrans, prmnTipo}
        ServerReport.SetParameters(parameters)

        RptV.SetDisplayMode(Mode)

        RptV.RefreshReport()

        Me.Text = "Comprobante Operaciones"

        Me.ShowDialog()

        'Catch ex As Exception
        '    MsgBox(ex.Message & Chr(13) & "Comuníquese con el Administrador de la Red", MsgBoxStyle.Exclamation, "Mensaje")
        'End Try
    End Sub

    Private Sub FrmReportes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class