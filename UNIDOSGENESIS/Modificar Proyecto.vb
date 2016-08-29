Imports System.Data.SqlClient
Public Class Modificar_Proyecto
    Private Sub btnmvolver_Click(sender As Object, e As EventArgs) Handles btnmvolver.Click
        My.Forms.Menu_Proyectos.Show()
        My.Forms.Modificar_Proyecto.Close()
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Try


            If txtbuscar.Text = "" Then
                MsgBox("No ingreso el dato")
            Else

                Dim con As New SqlConnection(My.Settings.UNIDOSConnectionString)
                Dim cmd As New SqlCommand
                con.Open()

                cmd.Connection = con
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "validar_Proyecto"

                cmd.Parameters.Add(New SqlParameter("@ProyectoID", SqlDbType.Int)).Value = txtbuscar.Text

                Dim reader As SqlDataReader
                reader = cmd.ExecuteReader

                Dim r As Boolean = reader.HasRows()
                If r = False Then
                    MessageBox.Show("El proyecto no está registrado")
                    txtbuscar.Text = ""
                Else
                    Dim conn As New SqlConnection(My.Settings.UNIDOSConnectionString)
                    Dim cmdd As New SqlCommand
                    conn.Open()
                    cmdd.Connection = conn
                    cmdd.CommandType = CommandType.StoredProcedure
                    cmdd.CommandText = "buscarproyecto"
                    cmdd.Parameters.Add(New SqlParameter("@ProyectoID", SqlDbType.Int)).Value = txtbuscar.Text
                    Dim dt As New DataTable
                    Dim da As New SqlDataAdapter

                    da.SelectCommand = cmdd
                    da.Fill(dt)

                    If dt.Rows.Count > 0 Then
                        txtcedula.Text = dt.Rows(0)(1)
                        txtnombre.Text = dt.Rows(0)(2)
                        txtmcomunidad.Text = dt.Rows(0)(3)
                        cmbmtipo.Text = dt.Rows(0)(4)
                        mfinicio.Text = dt.Rows(0)(5)
                        mffinal.Text = dt.Rows(0)(6)
                    End If

                End If
            End If
        Catch ex As Exception
            MsgBox("Algun dato debe ser erroneo")
        End Try
    End Sub

    Private Sub btnmguardar_Click(sender As Object, e As EventArgs) Handles btnmguardar.Click
        Try
            Dim conn As New SqlConnection(My.Settings.UNIDOSConnectionString)
            Dim cmdd As New SqlCommand
            conn.Open()
            cmdd.Connection = conn
            cmdd.Connection = conn
            cmdd.CommandType = CommandType.StoredProcedure
            cmdd.CommandText = "modificarproyecto"
            cmdd.Parameters.Add(New SqlParameter("@ProyectoID", SqlDbType.Int)).Value = txtbuscar.Text
            cmdd.Parameters.Add(New SqlParameter("@Cedula", SqlDbType.Int)).Value = txtcedula.Text
            cmdd.Parameters.Add(New SqlParameter("@Nombre", SqlDbType.VarChar, 50)).Value = txtnombre.Text
            cmdd.Parameters.Add(New SqlParameter("@Comunidad", SqlDbType.VarChar, 50)).Value = txtmcomunidad.Text
            cmdd.Parameters.Add(New SqlParameter("@tipo", SqlDbType.VarChar, 50)).Value = cmbmtipo.Text
            cmdd.Parameters.Add(New SqlParameter("@Fecha_inicio", SqlDbType.Date)).Value = mfinicio.Value
            cmdd.Parameters.Add(New SqlParameter("@Fecha_final", SqlDbType.Date)).Value = mffinal.Value
            Dim read As SqlDataReader
            read = cmdd.ExecuteReader
            txtnombre.Text = ""
            txtmcomunidad.Text = ""
            cmbmtipo.Text = ""
            txtcedula.Text = ""
            mfinicio.Value = Date.Now()
            mffinal.Value = Date.Now()
            MsgBox("Proyecto modificado")
        Catch ex As Exception
            MsgBox("Verifique Datos")
        End Try

    End Sub

    Private Sub Modificar_Proyecto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class