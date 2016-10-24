Imports Capa_Datos
Imports Capa_Entidades
Public Class Mantenimiento_CN
    Dim Mantenimiento_CD As New Mantenimiento_CD
    Dim Mantenimiento_CE As New Mantenimiento_CE
    Public Function VerData(ByVal sql As String) As DataTable
        Return Consultas.VerConsulta(sql)
    End Function
    Function Grabar_TipoHab(ByVal ObjTH As Mantenimiento_CE, ByVal IntModif As Integer) As String
        Return Mantenimiento_CD.Grabar_TipoHab(ObjTH, IntModif)
    End Function
    Function Grabar_Hab(ByVal ObjHb As Mantenimiento_CE, ByVal IntModif As Integer) As String
        Return Mantenimiento_CD.Grabar_Habitaciones(ObjHb, IntModif)
    End Function
    Function Grabar_Clientes(ByVal ObjClien As Mantenimiento_CE, ByVal IntModif As Integer) As String
        Return Mantenimiento_CD.Grabar_Clientes(ObjClien, IntModif)
    End Function
    Function Grabar_Alquiler(ByVal ObjAlquiler As Mantenimiento_CE, ByVal IntModif As Integer) As String
        Return Mantenimiento_CD.Grabar_Alquiler(ObjAlquiler, IntModif)
    End Function
    Public Function Login(ByVal objUsuario As String, ByVal objPass As String) As DataTable
        Return Mantenimiento_CD.Ingresar_Usuario(objUsuario, objPass)
    End Function
    Public Function Obtener_NroPiso() As DataTable
        Return Mantenimiento_CD.Obtener_NroPiso()
    End Function
    Public Function Obtener_HabitacionNroPiso(ByVal IntNroPiso As Integer) As DataTable
        Return Mantenimiento_CD.Obtener_HabitacionNroPiso(IntNroPiso)
    End Function
    Public Function Obtener_HabitacionAlquilada(ByVal IntIdHab As Integer) As DataTable
        Return Mantenimiento_CD.Obtener_HabitacionAlquilada(IntIdHab)
    End Function
    Function ADministrar_Alquiler(ByVal ObjAdm As Mantenimiento_CE, ByVal IntComp As Integer) As String
        Return Mantenimiento_CD.ADministrar_Alquiler(ObjAdm, IntComp)
    End Function
    Public Function Obtener_ServidorReportes() As DataTable
        Return Mantenimiento_CD.Obtener_ServidorReportes()
    End Function
    Public Function Obtener_Comprobante(ByVal IntIdAlq As Integer, ByVal IntIdHab As Integer) As DataTable
        Return Mantenimiento_CD.Obtener_Comprobante(IntIdAlq, IntIdHab)
    End Function
End Class
