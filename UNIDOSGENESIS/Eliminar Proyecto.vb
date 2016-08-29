Imports System.Data.SqlClient
Public Class Eliminar_Proyecto
    Private Sub btnvolver_Click(sender As Object, e As EventArgs)
        My.Forms.Menu_Proyectos.Show()
        My.Forms.Eliminar_Proyecto.Close()
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs)
        Try
            Dim eliminar As DialogResult
            eliminar = MessageBox.Show("Realmente desea eliminar", "Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If (eliminar = DialogResult.Yes) Then
                Dim sqlConn As New SqlConnection(My.Settings.UNIDOSConnectionString)
                sqlConn.Open()
                Dim sqlcmd As New SqlCommand
                sqlcmd.Connection = sqlConn
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.CommandText = "validar_Proyectos"
                sqlcmd.Parameters.Add(New SqlParameter("@Nombre", SqlDbType.VarChar, 50)).Value = txteliminar.Text

                Dim reader As SqlDataReader
                reader = sqlcmd.ExecuteReader

                Dim r As Boolean = reader.HasRows()
                If r = True Then
                    Dim connexion As New SqlConnection(My.Settings.UNIDOSConnectionString)
                    connexion.Open()

                    Dim sqlcmdd As New SqlCommand
                    sqlcmdd.Connection = connexion
                    sqlcmdd.CommandType = CommandType.StoredProcedure
                    sqlcmdd.CommandText = "eliminarproyecto"
                    sqlcmdd.Parameters.Add(New SqlParameter("@Nombre", SqlDbType.VarChar, 50)).Value = txteliminar.Text

                    Dim readerr As SqlDataReader = sqlcmdd.ExecuteReader()

                    MsgBox("Proyecto Eliminado")
                    txteliminar.Text = ""
                Else

                    MsgBox("Proyecto no Encontrado")
                    txteliminar.Text = ""
                End If
            End If
        Catch ex As Exception
            MsgBox("Llenar la caja o dato incorrecto")
        End Try

    End Sub

    Private Sub Eliminar_Proyecto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)
    End Sub
End Class