Imports System.Data.SqlClient
Public Class Login
    Dim sqlConn As New SqlConnection
    Private Sub Crear_Conexion()
        sqlConn.ConnectionString = " Data Source=USUARIO\SQLEXPRESS;Initial Catalog=master;Integrated Security=True"
        sqlConn.Open()
    End Sub
    Private Sub cerrar_Conexion()
        sqlConn.Close()
    End Sub


    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click

        Crear_Conexion()
        Dim sqlcmd As New SqlCommand
        sqlcmd.Connection = sqlConn
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.CommandText = "Consultar_Usuario"
        sqlcmd.Parameters.Add(New SqlParameter("@usuar", SqlDbType.Char, 20)).Value = txtusuario.Text
        sqlcmd.Parameters.Add(New SqlParameter("@clave", SqlDbType.Char, 10)).Value = txtcontraseña.Text

        Dim reader As SqlDataReader = sqlcmd.ExecuteReader()
        If reader.HasRows Then
            Do While reader.Read()
                If Trim(reader.GetString(4)) = "supervisor" Then
                    Me.Hide()
                    menua.Show()
                ElseIf Trim(reader.GetString(4)) = "asistente" Then
                    Me.Hide()
                    menuv.Show()
                End If

            Loop
        Else
            MsgBox("Verificar usuario", MsgBoxStyle.Critical)
        End If


        cerrar_Conexion()


        Exit Sub



    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
