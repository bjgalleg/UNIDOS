Imports System.Data.SqlClient

Public Class Ingresar_Persona
    Private Sub btnvolver_Click(sender As Object, e As EventArgs) Handles btnvolver.Click
        My.Forms.Menu_Personas.Show()
        My.Forms.Ingresar_Persona.Close()
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try


            If String.IsNullOrEmpty(txtcedula.Text) Or String.IsNullOrEmpty(cmbestado.Text) Or String.IsNullOrEmpty(cmbtipo.Text) Or
                String.IsNullOrEmpty(txtnombre.Text) Or String.IsNullOrEmpty(txtapellidos.Text) Or String.IsNullOrEmpty(clbdpto.Text) Or
             String.IsNullOrEmpty(txttelefono.Text) Or String.IsNullOrEmpty(txtemail.Text) Or String.IsNullOrEmpty(fecha.Text) Or
                String.IsNullOrEmpty(txtuniversidad.Text) Or String.IsNullOrEmpty(txtcarrera.Text) Then

                MessageBox.Show("Favor llenar todos los campos")


            Else
                Dim conexion As New SqlConnection(My.Settings.UNIDOSConnectionString)
                conexion.Open()

                Dim sqlcmd As New SqlCommand
                sqlcmd.Connection = conexion
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.CommandText = "validar_cedula1"

                sqlcmd.Parameters.Add(New SqlParameter("@cedula", SqlDbType.Int)).Value = txtcedula.Text

                Dim reader As SqlDataReader
                reader = sqlcmd.ExecuteReader

                Dim r As Boolean = reader.HasRows()
                If r = True Then

                    MessageBox.Show("La persona ya está registrada ")
                    txtcedula.Text = ""
                    txtnombre.Text = ""
                    txtapellidos.Text = ""
                    cmbtipo.Text = ""
                    txttelefono.Text = ""
                    txtdireccion.Text = ""
                    txtemail.Text = ""
                    fecha.Text = ""
                    clbdpto.Text = ""
                    txtuniversidad.Text = ""
                    txtcarrera.Text = ""
                    cmbestado.Text = ""

                Else
                    Dim connexion As New SqlConnection(My.Settings.UNIDOSConnectionString)
                    connexion.Open()

                    Dim sqlcmdd As New SqlCommand
                    sqlcmdd.Connection = connexion

                    sqlcmdd.CommandType = CommandType.StoredProcedure
                    sqlcmdd.CommandText = "ingresarusuario"

                    sqlcmdd.Parameters.Add(New SqlParameter("@cedula", SqlDbType.Int)).Value = txtcedula.Text
                    sqlcmdd.Parameters.Add(New SqlParameter("@nombres", SqlDbType.VarChar, 50)).Value = txtnombre.Text
                    sqlcmdd.Parameters.Add(New SqlParameter("@apellidos", SqlDbType.VarChar, 50)).Value = txtapellidos.Text
                    sqlcmdd.Parameters.Add(New SqlParameter("@tipo", SqlDbType.VarChar, 50)).Value = cmbtipo.Text
                    sqlcmdd.Parameters.Add(New SqlParameter("@telefono", SqlDbType.VarChar, 50)).Value = txttelefono.Text
                    sqlcmdd.Parameters.Add(New SqlParameter("@direccion", SqlDbType.VarChar, 50)).Value = txtdireccion.Text
                    sqlcmdd.Parameters.Add(New SqlParameter("@email", SqlDbType.VarChar, 50)).Value = txtemail.Text
                    sqlcmdd.Parameters.Add(New SqlParameter("@fecha_de_nacimiento", SqlDbType.Date)).Value = fecha.Value
                    sqlcmdd.Parameters.Add(New SqlParameter("@departamento", SqlDbType.VarChar, 50)).Value = clbdpto.Text
                    sqlcmdd.Parameters.Add(New SqlParameter("@universidad", SqlDbType.VarChar, 50)).Value = txtuniversidad.Text
                    sqlcmdd.Parameters.Add(New SqlParameter("@carrera", SqlDbType.VarChar, 50)).Value = txtcarrera.Text
                    sqlcmdd.Parameters.Add(New SqlParameter("@estado", SqlDbType.VarChar, 50)).Value = cmbestado.Text


                    Dim read As SqlDataReader
                    read = sqlcmdd.ExecuteReader
                    MessageBox.Show("Persona Registrada")

                    txtcedula.Text = ""
                    txtnombre.Text = ""
                    txtapellidos.Text = ""
                    cmbtipo.Text = ""
                    txttelefono.Text = ""
                    txtdireccion.Text = ""
                    txtemail.Text = ""
                    fecha.Text = ""
                    clbdpto.Text = ""
                    txtuniversidad.Text = ""
                    txtcarrera.Text = ""
                    cmbestado.Text = ""

                End If
            End If

        Catch ex As Exception
            MsgBox("LLene las cajas o datos incorrectos")
        End Try

    End Sub

    Private Sub Ingresar_Persona_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txttelefono_TextChanged(sender As Object, e As EventArgs) Handles txttelefono.TextChanged

    End Sub
End Class