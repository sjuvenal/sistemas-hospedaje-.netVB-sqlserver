Imports Capa_Entidades
Imports Capa_Negocio


Imports System.Globalization
Public Class FrmRegistarAlquiler
    Dim oBJAlq_cn As New Mantenimiento_CN
    Dim oBJAlq_ce As New Mantenimiento_CE
    Dim IntMod As Integer
    Dim IntFila As Integer
    Dim IntAlqId As Integer
    Dim tt As Integer
    Dim i As Integer = 0
    Private Sub btnbuscarhabitacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscarhabitacion.Click
        FrmBuscarHabitacion.ShowDialog()
        FrmBuscarHabitacion = Nothing
        'habitacion
        If GIntHabID <> 0 Then
            'GIntHabID()
            txttipohabitacion.Text = GStrTipoHab
            txtprecio.Text = GDbPrecio
            txtnrohab.Text = GIntNroHab
            txtnropiso.Text = GStrNroPiso
            cbxTV.Checked = GblTV
            cbxCABLE.Checked = GBlClable
            cbxJAK.Checked = GBlJak
        Else
            'GIntHabID()
            txttipohabitacion.Text = ""
            txtprecio.Text = ""
            txtnrohab.Text = ""
            txtnropiso.Text = ""
            cbxTV.Checked = False
            cbxCABLE.Checked = False
            cbxJAK.Checked = False
        End If
    End Sub

    Private Sub btnbuscarcliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscarcliente.Click
        FrmBuscarCliente.ShowDialog()
        FrmBuscarCliente = Nothing

        If GintCliId <> 0 Then
            'Public GintCliId As Integer
            txtcliente.Text = GStrNombres
            txtdocumento.Text = GStrDocumento
        Else
            'Public GintCliId As Integer
            txtcliente.Text = ""
            txtdocumento.Text = ""
        End If

    End Sub


    Private Sub FrmRegistarAlquiler_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
   

        Boton_Activar(True, False)

    End Sub
    Sub Boton_Activar(ByVal EnTru As Boolean, ByVal EnFal As Boolean)
        btnnuevo.Enabled = EnTru
        btnguardar.Enabled = EnFal
        btncancelar.Enabled = EnFal
        btnsalir.Enabled = EnTru
        GroupBox1.Enabled = EnFal
        GroupBox2.Enabled = EnFal
        GroupBox3.Enabled = EnFal

        
    End Sub
    Sub Limpiar_texto()
        txttipohabitacion.Text = ""
        txtnrohab.Text = ""
        txtprecio.Text = ""
        txtnropiso.Text = ""
        txtcliente.Text = ""
        txtdocumento.Text = ""
        txtdescripcion.Text = ""

        rbdias.Checked = False
        rbhoras.Checked = False
        cbxcontrol.Checked = False
        cbxllaves.Checked = False
        cbxplaya.Checked = False

        cbxTV.Checked = False
        cbxCABLE.Checked = False
        cbxJAK.Checked = False

        GStrTipoHab = ""
        GDbPrecio = 0
        GIntNroHab = 0
        GStrNroPiso = ""
        GblTV = False
        GBlClable = False
        GBlJak = False
        GintCliId = 0
        GStrNombres = ""
        GStrDocumento = ""
       
    End Sub
    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        If txttipohabitacion.Text = "" Then
            MsgBox("Ingrese la habitacion", vbCritical, "Error Registrar")
            btnbuscarhabitacion.Focus()
            Exit Sub
        End If
        If txtcliente.Text = "" Then
            MsgBox("Ingrese el cliente", vbCritical, "Error Registrar")
            txtcliente.Focus()
            Exit Sub
        End If

        If txtdias.Text = "" Then
            MsgBox("Ingrese datos del alquiler x [DIAS] [HORAS]", vbCritical, "Error Registrar")
            txtcliente.Focus()
            Exit Sub
        End If

        If txtdescripcion.Text = "" Then
            MsgBox("Ingrese el descripcion del alquiler", vbCritical, "Error Registrar")
            txtcliente.Focus()
            Exit Sub
        End If
        With oBJAlq_ce
            .AlId = IntAlqId
            .ClId = GintCliId
            .HbID = GIntHabID
            .UsId = 1

            .Al_FechaIngreso = DTPFcEntrada.Value.Date
            .Al_HoraIngreso = DTPhrEntrada.Text
            .Al_FechaSalida = DTPFcSalida.Value.Date
            .Al_HoraSalida = DTPhrSalida.Text

            .Al_Descripcion = txtdescripcion.Text & IIf(cbxcontrol.Checked = True, ", " & cbxcontrol.Text, "") & IIf(cbxllaves.Checked = True, ", " & cbxllaves.Text, "") & IIf(cbxplaya.Checked = True, ", " & cbxplaya.Text, "") & IIf(cbxdni.Checked = True, ", Dejo su " & cbxdni.Text, "")
            .Al_Estado = 1
        End With
        If IntMod = 0 Then
            oBJAlq_cn.Grabar_Alquiler(oBJAlq_ce, 1)
            MsgBox("Se registro Correctamente el Cliente", vbExclamation, "Registrar Clientes")
        Else
            oBJAlq_cn.Grabar_Alquiler(oBJAlq_ce, 1)
            MsgBox("Se Modifico Correctamente el Cliente", vbExclamation, "Modificar Clientes")
        End If
        IntMod = 0
        IntAlqId = 0

        Call Boton_Activar(True, False)
        Call Limpiar_texto()

    End Sub


    Private Sub DTPFcSalida_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTPFcSalida.ValueChanged
        If rbdias.Checked = True Then
            Call CalcularTiempo()
        End If

    End Sub

    Private Sub txtdescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdescripcion.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnguardar.Focus()
        End If
        If InStr(1, "abcdefghijklmnñopqrstuvwxyz ABCDEFGHIJKLMNÑOPQRSTUWVXYZ,(." & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtdias_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdias.TextChanged, txtdescripcion.TextChanged

    End Sub
    Sub CalcularTiempo()



        If DTPFcSalida.Value < DTPFcEntrada.Value Then
            DTPFcSalida.Value = Today
        End If

        Dim HoraMinEntrada() As String = Split(FormatDateTime(Me.DTPhrEntrada.Value, DateFormat.ShortTime), ":")
        Dim HoraMinSalida() As String = Split(FormatDateTime(Me.DTPhrSalida.Value, DateFormat.ShortTime), ":")



        'If DTPFcSalida.Value < DTPFcEntrada.Value Then
        '    DTPhrSalida.Value = DTPhrEntrada.Value
        'End If



        'Text = HoraMinEntrada(0) - HoraMinSalida(0)
        'Text = HoraMinEntrada(1) - HoraMinSalida(1)



        Dim IntDias As Integer = (DTPFcSalida.Value.Day - DTPFcEntrada.Value.Day)
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
                DTPFcSalida.Value = DTPFcSalida.Value.AddDays(1)
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

        If rbdias.Checked = True Then
            txtdias.Text = IIf(IntDias <> 0, IntDias & " Dias ", "") & IIf(IntHora <> 0, IntHora & " Hora ", "") & IIf(IntMin <> 0, IntMin & " Minutos ", "")
        Else
            txtdias.Text = IIf(IntHora <> 0, IntHora & " Hora ", "") & IIf(IntMin <> 0, IntMin & " Minutos ", "")
        End If

    End Sub
    Private Sub DTPhrSalida_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTPhrSalida.ValueChanged

        Dim HoraMinEntrada() As String = Split(FormatDateTime(Me.DTPhrEntrada.Value, DateFormat.ShortTime), ":")
        Dim HoraMinSalida() As String = Split(FormatDateTime(Me.DTPhrSalida.Value, DateFormat.ShortTime), ":")
        If DTPFcSalida.Value < DTPFcEntrada.Value Then
            If HoraMinEntrada(0) > HoraMinSalida(0) Then
                DTPhrSalida.Value = DTPhrEntrada.Value
            End If
        End If
        Call CalcularTiempo()
    End Sub

    Private Sub DTPhrEntrada_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTPhrEntrada.ValueChanged
        Dim hour As String = DTPhrEntrada.Value.ToString("hh", CultureInfo.CurrentCulture)
        Dim minute As String = DTPhrEntrada.Value.ToString("mm", CultureInfo.CurrentCulture)
        If hour.Length = 2 Then
            SendKeys.SendWait("{Right}")
        End If
        '12 horas
        Me.Text = hour & ":" & minute
    End Sub

    Private Sub DTPFcEntrada_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTPFcEntrada.ValueChanged

    End Sub

    Private Sub rbdias_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbdias.CheckedChanged
        DTPFcEntrada.Enabled = False
        DTPFcSalida.Enabled = True
        DTPhrEntrada.Enabled = False
        DTPhrSalida.Enabled = False
        DTPFcSalida.Value = DTPFcEntrada.Value
        txtdias.Text = ""
    End Sub

    Private Sub rbhoras_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbhoras.CheckedChanged
        DTPhrEntrada.Enabled = False
        DTPhrSalida.Enabled = True
        DTPFcEntrada.Enabled = False
        DTPFcSalida.Enabled = False
        DTPFcSalida.Value = DTPFcEntrada.Value
        txtdias.Text = ""
    End Sub

    Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
        Boton_Activar(False, True)
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        IntMod = 0
        IntFila = 0
        Call Boton_Activar(True, False)
        btnnuevo.Focus()
    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub
End Class