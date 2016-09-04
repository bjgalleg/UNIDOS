Imports System.Data.SqlClient
Public Class Modificarproyecto
    Private Sub btnvolver_Click(sender As Object, e As EventArgs) Handles btnvolver.Click
        Me.Close()
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try


            If txtbuscar.Text = "" Then
                MsgBox("Por favor seleccione un proyecto")
            Else

                Dim con As New SqlConnection(My.Settings.UNIDOSConnectionString)
                Dim cmd As New SqlCommand
                con.Open()

                cmd.Connection = con
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "validar_Proyecto"

                cmd.Parameters.Add(New SqlParameter("@nombreproyecto", SqlDbType.Text)).Value = txtbuscar.Text

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
                    cmdd.Parameters.Add(New SqlParameter("@nombreproyecto", SqlDbType.Text)).Value = txtbuscar.Text
                    Dim dt As New DataTable
                    Dim da As New SqlDataAdapter

                    da.SelectCommand = cmdd
                    da.Fill(dt)

                    If dt.Rows.Count > 0 Then
                        cmbproyecto.Text = dt.Rows(0)(1)
                        txtcomunidad.Text = dt.Rows(0)(2)
                        cmbtipo.Text = dt.Rows(0)(3)
                        finicio.Text = dt.Rows(0)(4)
                        ffinal.Text = dt.Rows(0)(5)
                    End If

                End If
            End If
        Catch ex As Exception
            MsgBox("Revisar datos", vbCritical)
        End Try
    End Sub
End Class