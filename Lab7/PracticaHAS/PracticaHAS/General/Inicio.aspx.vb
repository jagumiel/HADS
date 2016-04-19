Imports System.Security.Cryptography

Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub ButtonLogIn_Click(sender As Object, e As EventArgs) Handles ButtonLogIn.Click
        '1.-Recogemos los valores que ha introducido el usuario
        Dim databaseLogic As New Funciones.DB_Logic
        Dim user As String = BoxUsuario.Text
        Dim pass As String = BoxPass.Text
        '2.-Mandamos una query para ver si es correcto.
        'Nota:Hacer el hash

        Dim md5Hash As MD5 = MD5.Create()
        Dim passCifrada As String = Funciones.MisFunciones.GetMd5Hash(md5Hash, pass)

        If (databaseLogic.AutenticarLogIn(user, passCifrada) = True) Then
            Respuesta.Text = "Login Correcto."
            Session("Email") = BoxUsuario.Text
            If (databaseLogic.esAlumno(user)) Then
                Session("Rol") = "A"
                FormsAuthentication.SetAuthCookie("Alumno", False)
                'System.Web.Security.FormsAuthentication.RedirectFromLoginPage("Alumno", False)
                Application("numAlum") += 1
                Application("alumsOnline").Add(Session("Email"), Session("Email"))
                Response.Redirect("~/Alumnos/Alumno.aspx")
            Else
                Application("numProfes") += 1
                Application("profesOnline").Add(Session("Email"), Session("Email"))
                'El admin se cuenta también tambien un profe.
                If (BoxUsuario.Text.Equals("vadillo@ehu.es")) Then
                    Session("Rol") = "P"
                    FormsAuthentication.SetAuthCookie("vadillo@ehu.es", False)
                    Response.Redirect("~/Especiales/ExportarTareasXMLDocument.aspx")
                ElseIf (BoxUsuario.Text.Equals("vadillo@ehu.es")) Then
                    Session("Rol") = "P"
                    FormsAuthentication.SetAuthCookie("admin@ehu.es", False)
                    Response.Redirect("~/Admin/CambiarPassAdmin.aspx")
                Else
                    Session("Rol") = "P"
                    FormsAuthentication.SetAuthCookie("Profesor", False)
                    Response.Redirect("~/Profesores/Profesor.aspx")
                End If
                Respuesta.Text = "Login Incorrecto."
            End If
        End If
    End Sub
End Class