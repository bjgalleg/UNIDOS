Imports System.Data.SqlClient
Public Class Eliminar_Departamento
    Private Sub btnvolver_Click(sender As Object, e As EventArgs) 
        My.Forms.Menu_Departamento.Show()
        My.Forms.Eliminar_Departamento.Close()
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
                sqlcmd.CommandText = "validar_departamento"
                sqlcmd.Parameters.Add(New SqlParameter("@DepartamentoID", SqlDbType.Int)).Value = txtcod.Text
                Dim reader As SqlDataReader
                reader = sqlcmd.ExecuteReader
                Dim r As Boolean = reader.HasRows()
                If r = True Then
                    Dim connexion As New SqlConnection(My.Settings.UNIDOSConnectionString)
                    connexion.Open()
                    Dim sqlcmdd As New SqlCommand
                    sqlcmdd.Connection = connexion
                    sqlcmdd.CommandType = CommandType.StoredProcedure
                    sqlcmdd.CommandText = "eliminardepartamento"
                    sqlcmdd.Parameters.Add(New SqlParameter("@DepartamentoID", SqlDbType.Int)).Value = txtcod.Text
                    Dim readerr As SqlDataReader = sqlcmdd.ExecuteReader()
                    MsgBox("Departamento Eliminado")
                    txtcod.Text = ""
                Else
                    MsgBox("Departamento no Encontrado")
                    txtcod.Text = ""
                End If
            End If
        Catch ex As Exception
            MsgBox("Lenar la caja o dato incorrecto ")
        End Try
    End Sub

    Private Sub Eliminar_Departamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class