Imports System.Data.SqlClient
Imports Capa_Entidades
Public Class Mantenimiento_CD
    Private _con As New Conexion
    Private _com As New SqlCommand
    Public Function Grabar_TipoHab(ByVal ObjEnt_Man As Mantenimiento_CE, ByVal IntModif As Integer) As String
        'grabar soporte tecnico Rcepcion
        Dim sql As String = "set dateformat dmy exec Mantenimiento_TipoHabitacion " & ObjEnt_Man.thID & ",'" + ObjEnt_Man.th_TipoHab + "'," + ObjEnt_Man.th_Precio + ",'" + ObjEnt_Man.th_descripcion + "'," & IntModif & ""
        Dim cmd As New SqlCommand(sql, _con.Abrir)
        cmd.ExecuteNonQuery()
        _con.Cerrar()
        Return "BUENA JUVENAL"
    End Function
    Public Function Grabar_Habitaciones(ByVal ObjEnt_Man As Mantenimiento_CE, ByVal IntModif As Integer) As String
        Dim sql As String = "set dateformat dmy exec Mantenimiento_Habitacion " & ObjEnt_Man.HbID & "," & ObjEnt_Man.thID & "," & ObjEnt_Man.hb_nroHb & "," & ObjEnt_Man.hb_NroPiso & "," & ObjEnt_Man.hb_Precio & ",'" & ObjEnt_Man.hb_Descripcion & "'," & ObjEnt_Man.hb_tv & "," & ObjEnt_Man.hb_cable & "," & ObjEnt_Man.hb_jakussi & "," & ObjEnt_Man.hb_EstadoAlq & "," & ObjEnt_Man.hb_Estado
        Dim cmd As New SqlCommand(sql, _con.Abrir)
        cmd.ExecuteNonQuery()
        _con.Cerrar()
        Return "BUENA JUVENAL"
    End Function
    Public Function Grabar_Clientes(ByVal ObjEnt_Man As Mantenimiento_CE, ByVal IntModif As Integer) As String
        Dim sql As String = "set dateformat dmy exec Mantenimiento_Clientes " & ObjEnt_Man.ClId & ",'" & ObjEnt_Man.Cl_Nombres & "','" & ObjEnt_Man.Cl_ApPaterno & "','" & ObjEnt_Man.Cl_ApMaterno & "'," & ObjEnt_Man.Cl_Sexo & "," & ObjEnt_Man.TiID & "," & ObjEnt_Man.Cl_TipoDocIdent & "," & ObjEnt_Man.Cl_Lugar & ",'" & ObjEnt_Man.Cl_Direccion & "'," & ObjEnt_Man.Cl_Estado
        Dim cmd As New SqlCommand(sql, _con.Abrir)
        cmd.ExecuteNonQuery()
        _con.Cerrar()
        Return "BUENA JUVENAL"
    End Function
    Public Function Grabar_Alquiler(ByVal ObjEnt_Man As Mantenimiento_CE, ByVal IntModif As Integer) As String
        Dim sql As String = "set dateformat dmy exec Mantenimiento_Alquiler " & ObjEnt_Man.AlId & "," & ObjEnt_Man.ClId & "," & ObjEnt_Man.HbID & "," & ObjEnt_Man.UsId & ",'" & ObjEnt_Man.Al_FechaIngreso & "','" & ObjEnt_Man.Al_HoraIngreso & "','" & ObjEnt_Man.Al_FechaSalida & "','" & ObjEnt_Man.Al_HoraSalida & "','" & ObjEnt_Man.Al_Descripcion & "'," & ObjEnt_Man.Al_Estado
        Dim cmd As New SqlCommand(sql, _con.Abrir)
        cmd.ExecuteNonQuery()
        _con.Cerrar()
        Return "BUENA JUVENAL"
    End Function
    Public Function ADministrar_Alquiler(ByVal ObjEnt_Man As Mantenimiento_CE, ByVal IntCom As Integer) As String
        Dim sql As String = "set dateformat dmy exec Administrar_Hospedaje " & ObjEnt_Man.AlId & "," & ObjEnt_Man.HbID & "," & IntCom
        Dim cmd As New SqlCommand(sql, _con.Abrir)
        cmd.ExecuteNonQuery()
        _con.Cerrar()
        Return "BUENA JUVENAL"
    End Function
    Public Function Ingresar_Usuario(ByVal StrUsuario As String, ByVal StrPass As String) As DataTable
        Dim _con As New Conexion
        Dim _com As New SqlCommand
        _com.Connection = _con.Abrir
        _com.CommandType = CommandType.Text
        _com.CommandText = "buscar_Login '" & StrUsuario & "','" & StrPass & "'"
        Dim dap As New SqlDataAdapter(_com)
        Dim dt As New DataTable
        dap.Fill(dt)
        Return dt
    End Function
    Public Function Obtener_NroPiso() As DataTable
        Dim _con As New Conexion
        Dim _com As New SqlCommand
        _com.Connection = _con.Abrir
        _com.CommandType = CommandType.Text
        _com.CommandText = "Listar_NroPiso"
        Dim dap As New SqlDataAdapter(_com)
        Dim dt As New DataTable
        dap.Fill(dt)
        Return dt
    End Function
    Public Function Obtener_HabitacionNroPiso(ByVal IntNroPiso As Integer) As DataTable
        Dim _con As New Conexion
        Dim _com As New SqlCommand
        _com.Connection = _con.Abrir
        _com.CommandType = CommandType.Text
        _com.CommandText = "Listar_HabitacionNroPiso " & IntNroPiso
        Dim dap As New SqlDataAdapter(_com)
        Dim dt As New DataTable
        dap.Fill(dt)
        Return dt
    End Function
    Public Function Obtener_HabitacionAlquilada(ByVal IntIdHab As Integer) As DataTable
        Dim _con As New Conexion
        Dim _com As New SqlCommand
        _com.Connection = _con.Abrir
        _com.CommandType = CommandType.Text
        _com.CommandText = "Buscar_habitacionAlquilada " & IntIdHab
        Dim dap As New SqlDataAdapter(_com)
        Dim dt As New DataTable
        dap.Fill(dt)
        Return dt
    End Function
    Public Function Obtener_ServidorReportes() As DataTable
        Dim _con As New Conexion
        Dim _com As New SqlCommand
        _com.Connection = _con.Abrir
        _com.CommandType = CommandType.Text
        _com.CommandText = "select cValorVar from VarNegocio"
        Dim dap As New SqlDataAdapter(_com)
        Dim dt As New DataTable
        dap.Fill(dt)
        Return dt
    End Function

    Public Function Obtener_Comprobante(ByVal IntIdAlq As Integer, ByVal IntIdHab As Integer) As DataTable
        Dim _con As New Conexion
        Dim _com As New SqlCommand
        _com.Connection = _con.Abrir
        _com.CommandType = CommandType.Text
        _com.CommandText = "Listar_Comprobante " & IntIdAlq & "," & IntIdHab
        Dim dap As New SqlDataAdapter(_com)
        Dim dt As New DataTable
        dap.Fill(dt)
        Return dt
    End Function
End Class
