Imports Capa_Negocio
Public Class FrmLogin
    Dim CONT, con As Integer
    Dim Login, Permisos As New DataTable
    Dim oBJBuscarClie_cn As New Mantenimiento_CN
    Private Sub btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        If txtusuario.Text = String.Empty Then
            ErrorProvider1.SetError(txtusuario, "Ingrese su Nombre de Usuario")
            MsgBox("Ingrese su Nombre de Usuario", vbCritical, "Error Ingresar")
            txtusuario.Focus()
            Exit Sub
        Else
            ErrorProvider1.SetError(txtusuario, Nothing)
        End If
        If txtPass.Text = String.Empty Then
            ErrorProvider1.SetError(txtPass, "Ingrese su Contraseña")
            MsgBox("Ingrese su Contraseña", vbCritical, "Error Ingresar")
            txtPass.Focus()
            Exit Sub
        Else
            ErrorProvider1.SetError(txtPass, Nothing)
        End If
        Login = oBJBuscarClie_cn.Login(txtusuario.Text, txtPass.Text)
        If Login.Rows.Count > 0 Then
            GIntUsuId = Login.Rows(0).Item(0)
            ProgressBar1.Value = 0
            'activando al timer
            txtPass.Enabled = False
            txtusuario.Enabled = False
            btnaceptar.Enabled = False
            Timer1.Enabled = True
            ProgressBar1.Visible = True
        Else
            CONT = CONT + 1
            If CONT = 3 Then
                MsgBox("Ha intentado ingresar al Sistema Demasiadas Veces " & Chr(13) & _
                       "con  Contraseña o Usuario  incorrecto; Intentelo mas Tarde", vbCritical, "Error de Acceso")
                Application.Exit()
            End If
            'MsgBox("Usuario o Password Incorrectos", MsgBoxStyle.Information, "Error de Ingreso")
            MsgBox("Usuario o Password Incorrectos" & Chr(13) & _
        "Le quedan Solamente : " & 3 - CONT & " Intentos", vbExclamation, "Mensaje")
            txtusuario.Focus()
        End If

    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'Si el progress bar es menor que 100
        If ProgressBar1.Value < 100 Then
            'Entonces ejecuta el aumento de 1 en 1 en progressbar1
            ProgressBar1.Value = ProgressBar1.Value + 1
            'Cargando.Text = "Cargando" & " " & ProgressBar1.Value & " % .."
        ElseIf ProgressBar1.Value = "100" Then
            Timer1.Enabled = False
            MDIHostal_Viletta.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub txtPass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPass.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnaceptar_Click(btnaceptar, New System.EventArgs)
        End If
    End Sub

    Private Sub txtPass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPass.TextChanged

    End Sub

    Private Sub txtusuario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtusuario.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtPass.Focus()
        End If
    End Sub

    Private Sub txtusuario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtusuario.TextChanged

    End Sub

    Private Sub FrmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtusuario.Focus()
    End Sub
End Class