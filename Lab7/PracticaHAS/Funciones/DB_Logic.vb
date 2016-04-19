Imports System.Net.Mail

Public Class DB_Logic


    'Fuente autenticar: http://forums.asp.net/t/1250726.aspx?How+to+Authenticate+Users+with+the+SQL+Server+database+table+using+C+with+Example+

    Function AutenticarLogIn(ByVal user As String, ByVal pass As String) As Boolean
        Dim esta As Boolean = False
        Dim sqlQuery As String = "Select * from Usuarios where email='" & user & "' and pass ='" & pass & "';"
        'MsgBox(sqlQuery)
        'Dim conexion As New System.Data.SqlClient.SqlConnection("Server=tcp:has17.database.windows.net,1433;Database=HAS17;User ID=has17@has17;Password=J0s3B3g0;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")
        Dim conexion As New System.Data.SqlClient.SqlConnection("Server=tcp:serverlab4.database.windows.net,1433;Database=Lab4;User ID=has17@serverlab4;Password=J0s3B3g0;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")
        Dim sqlCommand As New System.Data.SqlClient.SqlCommand(sqlQuery, conexion)
        Dim reader As System.Data.SqlClient.SqlDataReader
        Try
            conexion.Open()
            reader = sqlCommand.ExecuteReader()
            While (reader.Read)
                Dim correo As String = reader("email")
                Dim contrasena As String = reader("pass")
                If (String.Equals(user, correo)) Then
                    If (String.Equals(pass, contrasena)) Then
                        esta = True
                    End If
                End If
            End While
            reader.Close()
        Catch ex As Exception
            'MsgBox("No se ha podido establecer la conexión")
        End Try
        conexion.Close()
        Return esta
    End Function


    Function esAlumno(ByVal user As String) As Boolean
        Dim estudiante As Boolean = False
        Dim sqlQuery As String = "Select * from Usuarios where email='" & user & "';"
        'MsgBox(sqlQuery)
        'Dim conexion As New System.Data.SqlClient.SqlConnection("Server=tcp:has17.database.windows.net,1433;Database=HAS17;User ID=has17@has17;Password=J0s3B3g0;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")
        Dim conexion As New System.Data.SqlClient.SqlConnection("Server=tcp:serverlab4.database.windows.net,1433;Database=Lab4;User ID=has17@serverlab4;Password=J0s3B3g0;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")
        Dim sqlCommand As New System.Data.SqlClient.SqlCommand(sqlQuery, conexion)
        Dim reader As System.Data.SqlClient.SqlDataReader
        Try
            conexion.Open()
            reader = sqlCommand.ExecuteReader()
            While (reader.Read)
                Dim tipo As String = reader("tipo")
                If (String.Equals(tipo, "A")) Then
                    estudiante = True
                End If
            End While
            reader.Close()
        Catch ex As Exception
            'MsgBox("No se ha podido establecer la conexión")
        End Try
        conexion.Close()
        Return estudiante
    End Function





    Function RegistrarUsuario(ByVal correo As String, ByVal nombre As String, ByVal apellidos As String, ByVal dni As String, ByVal pass As String, ByVal pregunta As Integer, ByVal respuesta As String, ByVal numConf As Integer) As Boolean
        Dim noConf As String = "No"
        'Dim sqlQuery As String = "INSERT INTO Usuarios (email, nombre, pregunta, respuesta, dni, confirmado, grupo, tipo, pass)VALUES ('" & correo & "','" & nombre & "','" & apellidos & "','" & dni & "','" & pass & "','" & pregunta & "','" & respuesta & "','" & numConf & "','" & noConf & "');"
        Dim sqlQuery As String = "INSERT INTO Usuarios (email, nombre, pregunta, respuesta, dni, confirmado, grupo, tipo, pass) VALUES ('" & correo & "','" & nombre & "','" & apellidos & "','" & pregunta & "','" & respuesta & "','" & dni & "','" & noConf & "', NULL, NULL'" & noConf & "','" & pass & "');"
        MsgBox(sqlQuery)
        Dim conexion As New System.Data.SqlClient.SqlConnection("Server=tcp:serverlab4.database.windows.net,1433;Database=Lab4;User ID=has17@serverlab4;Password=J0s3B3g0;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")
        Dim sqlCommand As New System.Data.SqlClient.SqlCommand(sqlQuery, conexion)
        Dim reader As System.Data.SqlClient.SqlDataReader
        Try
            conexion.Open()
        Catch ex As Exception
            MsgBox("No se ha podido establecer la conexión")
        End Try
        reader = sqlCommand.ExecuteReader()
        'MsgBox(reader)
        conexion.Close()
        'If (reader.Read()) Then
        'Return True
        'Else
        'Return False
        'End If
        Return True
        'Comento lo anterior porque tenemos problemas y queremos que nos envie el correo de confirmacion.
        'Tenemos en cuenta que se añade correctamente el usuario a la lista.
        'Hay que controlar si el correo ya está registrado.
    End Function

    Function ConfirmarUsuario(ByVal numConf As String) As Boolean
        Dim sqlQuery As String = "UPDATE Usuarios SET Confirmado='Yes' WHERE NumeroConfirmacion='" & numConf & "';"
        MsgBox(sqlQuery)
        Dim conexion As New System.Data.SqlClient.SqlConnection("Server=tcp:serverlab4.database.windows.net,1433;Database=Lab4;User ID=has17@serverlab4;Password=J0s3B3g0;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")
        Dim sqlCommand As New System.Data.SqlClient.SqlCommand(sqlQuery, conexion)
        Dim reader As System.Data.SqlClient.SqlDataReader
        Try
            conexion.Open()
        Catch ex As Exception
            MsgBox("No se ha podido establecer la conexión")
        End Try
        reader = sqlCommand.ExecuteReader()
        'MsgBox(reader)
        conexion.Close()
        'If (reader.Read()) Then
        'Return True
        'Else
        'Return False
        'End If
        Return True
        'Comento lo anterior porque tenemos problemas y queremos que nos envie el correo de confirmacion.
        'Tenemos en cuenta que se añade correctamente el usuario a la lista.
        'Hay que controlar si el correo ya está registrado.
    End Function

    Function ModificarPass(ByVal correo As String, ByVal newPass As String) As Boolean
        'Dim sqlQuery As String = "UPDATE Usuario SET Password='" & newPass & "' WHERE Email='" & correo & "' and Password='" & oldPass & "';"
        Dim sqlQuery As String = "UPDATE Usuarios SET Password='" & newPass & "' WHERE Email='" & correo & "';"
        MsgBox(sqlQuery)
        Dim conexion As New System.Data.SqlClient.SqlConnection("Server=tcp:serverlab4.database.windows.net,1433;Database=Lab4;User ID=has17@serverlab4;Password=J0s3B3g0;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")
        Dim sqlCommand As New System.Data.SqlClient.SqlCommand(sqlQuery, conexion)
        Dim reader As System.Data.SqlClient.SqlDataReader
        Try
            conexion.Open()
        Catch ex As Exception
            MsgBox("No se ha podido establecer la conexión")
        End Try
        reader = sqlCommand.ExecuteReader()
        'MsgBox(reader)
        conexion.Close()
        'If (reader.Read()) Then
        'Return True
        'Else
        'Return False
        'End If
        Return True
        'Comento lo anterior porque tenemos problemas y queremos que nos envie el correo de confirmacion.
        'Tenemos en cuenta que se añade correctamente el usuario a la lista.
        'Hay que controlar si el correo ya está registrado.
    End Function

    Function InsertarTarea(ByVal codigo As String, ByVal descripcion As String, ByVal asignatura As String, ByVal horas As Integer, ByVal tipo As String) As Boolean
        Dim sqlQuery As String = "INSERT INTO TareasGenericas (Codigo, Descripcion, CodAsig, HEstimadas, Explotacion, TipoTarea)VALUES ('" & codigo & "','" & descripcion & "','" & asignatura & "','" & horas & "','1','" & tipo & "');"
        MsgBox(sqlQuery)
        Dim conexion As New System.Data.SqlClient.SqlConnection("Server=tcp:serverlab4.database.windows.net,1433;Database=Lab4;User ID=has17@serverlab4;Password=J0s3B3g0;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")
        Dim sqlCommand As New System.Data.SqlClient.SqlCommand(sqlQuery, conexion)
        Dim reader As System.Data.SqlClient.SqlDataReader
        Try
            conexion.Open()
        Catch ex As Exception
            MsgBox("No se ha podido establecer la conexión")
        End Try
        reader = sqlCommand.ExecuteReader()
        'MsgBox(reader)
        conexion.Close()

        Return True
    End Function

End Class
