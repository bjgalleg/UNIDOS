Imports System.Data.SqlClient
Public Class Nuevo_Proyecto
    Private Sub btnvolver_Click(sender As Object, e As EventArgs) Handles btnvolver.Click
        My.Forms.Nuevo_Proyecto.Close()
        My.Forms.Menu_Proyectos.Show()
    End Sub

    Private Sub Nuevo_Proyecto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try


            If String.IsNullOrEmpty(txtcedula.Text) Or String.IsNullOrEmpty(txtcomunidad.Text) Or
                String.IsNullOrEmpty(cmbtipo.Text) Or String.IsNullOrEmpty(finicio.Text) Or String.IsNullOrEmpty(ffinal.Text) Then

                MessageBox.Show("Favor llenar todos los campos")


            Else
                Dim conexion As New SqlConnection(My.Settings.UNIDOSConnectionString)
                conexion.Open()

                Dim sqlcmd As New SqlCommand
                sqlcmd.Connection = conexion
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.CommandText = "validar_Proyecto"

                sqlcmd.Parameters.Add(New SqlParameter("@Nombre", SqlDbType.VarChar, 50)).Value = txtnombre.Text

                Dim reader As SqlDataReader
                reader = sqlcmd.ExecuteReader

                Dim r As Boolean = reader.HasRows()
                If r = True Then

                    MessageBox.Show("El Proyecto ya está registrado ")
                    txtcedula.Text = ""
                    txtnombre.Text = ""
                    txtcomunidad.Text = ""
                    cmbtipo.Text = ""
                    finicio.Text = ""
                    ffinal.Text = ""

                Else
                    Dim connexion As New SqlConnection(My.Settings.UNIDOSConnectionString)
                    connexion.Open()
                    Dim sqlcmdd As New SqlCommand
                    sqlcmdd.Connection = connexion
                    sqlcmdd.CommandType = CommandType.StoredProcedure
                    sqlcmdd.CommandText = "ingresarproyectos"
                    sqlcmdd.Parameters.Add(New SqlParameter("@Cedula", SqlDbType.Int)).Value = txtcedula.Text
                    sqlcmdd.Parameters.Add(New SqlParameter("@Nombre", SqlDbType.VarChar, 50)).Value = txtnombre.Text
                    sqlcmdd.Parameters.Add(New SqlParameter("@Comunidad", SqlDbType.VarChar, 50)).Value = txtcomunidad.Text
                    sqlcmdd.Parameters.Add(New SqlParameter("@Tipo", SqlDbType.VarChar, 50)).Value = cmbtipo.Text
                    sqlcmdd.Parameters.Add(New SqlParameter("@Fecha_inicio", SqlDbType.Date)).Value = finicio.Value
                    sqlcmdd.Parameters.Add(New SqlParameter("@Fecha_final", SqlDbType.Date)).Value = ffinal.Value
                    Dim read As SqlDataReader
                    read = sqlcmdd.ExecuteReader
                    MessageBox.Show("Proyecto registrado exitosamente")
                    txtcedula.Text = ""
                    txtcomunidad.Text = ""
                    cmbtipo.Text = ""
                    txtnombre.Text = ""
                    finicio.Text = ""
                    ffinal.Text = ""
                End If
            End If

        Catch ex As Exception
            MsgBox("Favor revisar datos")
        End Try

    End Sub
End Class