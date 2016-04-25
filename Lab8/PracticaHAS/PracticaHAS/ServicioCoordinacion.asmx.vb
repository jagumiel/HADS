Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel

' Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente.
' <System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class ServicioCoordinacion
    Inherits System.Web.Services.WebService
    Dim misFunciones As New Funciones.MisFunciones

    <WebMethod()> _
    Public Function MediaDedicacionAlumnos(miAsignatura As String) As Double
        Return misFunciones.MediaDedicacionAlumnos(miAsignatura)
    End Function

End Class