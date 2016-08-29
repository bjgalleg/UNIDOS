Imports System.Data.SqlClient
Public Class Modificar_datosde_persona
    Private Sub btnvolver_Click(sender As Object, e As EventArgs) Handles btnvolver.Click
        My.Forms.Modificar_datosde_persona.Close()
        My.Forms.Menu_Personas.Show()
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try


            Dim conexion As New SqlConnection(My.Settings.UNIDOSConnectionString)
            conexion.Open()
            Dim sqlcmd As New SqlCommand
            sqlcmd.Connection = conexion
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.CommandText = "modificarusuario"
            sqlcmd.Parameters.Add(New SqlParameter("@Cedula", SqlDbType.Int)).Value = txtbuscar.Text
            sqlcmd.Parameters.Add(New SqlParameter("@nombres", SqlDbType.VarChar, 50)).Value = txtmnombre.Text
            sqlcmd.Parameters.Add(New SqlParameter("@apellidos", SqlDbType.VarChar, 50)).Value = txtmapellidos.Text
            sqlcmd.Parameters.Add(New SqlParameter("@tipo", SqlDbType.VarChar, 50)).Value = cmbmtipo.Text
            sqlcmd.Parameters.Add(New SqlParameter("@telefono", SqlDbType.VarChar, 50)).Value = txtmtelefono.Text
            sqlcmd.Parameters.Add(New SqlParameter("@direccion", SqlDbType.VarChar, 50)).Value = txtmdireccion.Text
            sqlcmd.Parameters.Add(New SqlParameter("@email", SqlDbType.VarChar, 50)).Value = txtmemail.Text
            sqlcmd.Parameters.Add(New SqlParameter("@fecha_de_nacimiento", SqlDbType.Date)).Value = mfecha.Value
            sqlcmd.Parameters.Add(New SqlParameter("@departamento", SqlDbType.VarChar, 50)).Value = clbmdpto.Text
            sqlcmd.Parameters.Add(New SqlParameter("@universidad", SqlDbType.VarChar, 50)).Value = txtmuniversidad.Text
            sqlcmd.Parameters.Add(New SqlParameter("@carrera", SqlDbType.VarChar, 50)).Value = txtmcarrera.Text
            sqlcmd.Parameters.Add(New SqlParameter("@estado", SqlDbType.VarChar, 50)).Value = cmbmestado.Text

            Dim reader As SqlDataReader = sqlcmd.ExecuteReader()
            MsgBox("Persona Modificada")
            txtbuscar.Text = ""
            txtmapellidos.Text = ""
            txtmcarrera.Text = ""
            txtmdireccion.Text = ""
            txtmemail.Text = ""
            txtmnombre.Text = ""
            txtmtelefono.Text = ""
            txtmuniversidad.Text = ""
            clbmdpto.Text = ""
            cmbmestado.Text = ""
            cmbmtipo.Text = ""
        Catch ex As Exception
            MsgBox("llenar todos los datos")
        End Try
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Try


            Dim conexion As New SqlConnection(My.Settings.UNIDOSConnectionString)
            conexion.Open()

            Dim sqlcmd As New SqlCommand
            sqlcmd.Connection = conexion
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.CommandText = "buscarusuario"
            sqlcmd.Parameters.Add(New SqlParameter("@cedula", SqlDbType.Int)).Value = txtbuscar.Text

            Dim dt As New DataTable
            Dim da As New SqlDataAdapter

            da.SelectCommand = sqlcmd
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                txtmnombre.Text = dt.Rows(0)(1)
                txtmapellidos.Text = dt.Rows(0)(2)
                cmbmtipo.Text = dt.Rows(0)(3)
                txtmtelefono.Text = dt.Rows(0)(4)
                txtmdireccion.Text = dt.Rows(0)(5)
                txtmemail.Text = dt.Rows(0)(6)
                mfecha.Value = dt.Rows(0)(7)
                clbmdpto.Text = dt.Rows(0)(8)
                txtmuniversidad.Text = dt.Rows(0)(9)
                txtmcarrera.Text = dt.Rows(0)(10)
                cmbmestado.Text = dt.Rows(0)(11)
            Else
                MsgBox("Persona no existe")

            End If
        Catch ex As Exception
            MsgBox("Llenar caja o dato erroneo")
        End Try

    End Sub

    Private Sub Modificar_datosde_persona_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class