Public Class Mantenimiento_CE

    'tipo de habitaciones
    Public Property thID As Integer
    Public Property th_TipoHab As String
    Public Property th_Precio As String
    Public Property th_descripcion As String


    'habitaciones
    Public Property HbID As Integer
    Public Property hb_nroHb As Integer
    Public Property hb_NroPiso As Integer
    Public Property hb_Precio As String
    Public Property hb_Descripcion As String
    Public Property hb_tv As Boolean
    Public Property hb_cable As Boolean
    Public Property hb_jakussi As Boolean
    Public Property hb_EstadoAlq As Integer
    Public Property hb_Estado As Integer

    'clientes
    Public Property ClId As Integer
    Public Property Cl_Nombres As String
    Public Property Cl_ApPaterno As String
    Public Property Cl_ApMaterno As String
    Public Property Cl_Sexo As Boolean
    Public Property TiID As Integer
    Public Property Cl_TipoDocIdent As Integer
    Public Property Cl_Lugar As Integer
    Public Property Cl_Direccion As String
    Public Property Cl_Estado As Boolean

    'alquiler

    Public Property AlId As Integer
    'Public Property ClId As Integer
    'Public Property HbId As Integer 
    Public Property UsId As Integer
    Public Property Al_FechaIngreso As DateTime
    Public Property Al_HoraIngreso As String
    Public Property Al_FechaSalida As DateTime
    Public Property Al_HoraSalida As String
    Public Property Al_Descripcion As String
    Public Property Al_Estado As Integer

End Class
