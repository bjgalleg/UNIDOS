Imports System.Data.SqlClient
Public Class Eliminar_Personas
    Private Sub btnvolver_Click(sender As Object, e As EventArgs) Handles btnvolver.Click
        My.Forms.Menu_Personas.Show()
        My.Forms.Eliminar_Personas.Close()
    End Sub
    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Try
            Dim eliminar As DialogResult
            eliminar = MessageBox.Show("Realmente desea eliminar", "Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If (eliminar = DialogResult.Yes) Then

                Dim sqlConn As New SqlConnection(My.Settings.UNIDOSConnectionString)
                sqlConn.Open()
                Dim sqlcmd As New SqlCommand
                sqlcmd.Connection = sqlConn
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.CommandText = "validar_cedula1"
                sqlcmd.Parameters.Add(New SqlParameter("@cedula", SqlDbType.Int)).Value = txtced.Text

                Dim reader As SqlDataReader
                reader = sqlcmd.ExecuteReader

                Dim r As Boolean = reader.HasRows()
                If r = True Then
                    Dim connexion As New SqlConnection(My.Settings.UNIDOSConnectionString)
                    connexion.Open()

                    Dim sqlcmdd As New SqlCommand
                    sqlcmdd.Connection = connexion
                    sqlcmdd.CommandType = CommandType.StoredProcedure
                    sqlcmdd.CommandText = "eliminarusuario"
                    sqlcmdd.Parameters.Add(New SqlParameter("@cedula", SqlDbType.Int)).Value = txtced.Text

                    Dim readerr As SqlDataReader = sqlcmdd.ExecuteReader()

                    MsgBox("Usuario Eliminado")
                Else

                    MsgBox("Usuario no Encontrado")
                End If

                txtced.Text = ""
            End If
        Catch ex As Exception
            MsgBox("Llenar la caja o dato incorrecto")
        End Try

    End Sub

    Private Sub Eliminar_Personas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class