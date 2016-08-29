Imports System.Data.SqlClient
Public Class Movimientos
    Sub mostrar()
        Dim connexion As New SqlConnection(My.Settings.UNIDOSConnectionString)
        connexion.Open()
        Dim sqlCmdo As New SqlCommand
        sqlCmdo.Connection = connexion

        sqlCmdo.CommandType = CommandType.StoredProcedure
        sqlCmdo.CommandText = "moschatrartodo"
        Dim sqlDAT As New SqlDataAdapter()
        sqlDAT.SelectCommand = sqlCmdo
        Dim sqlDTa As New DataTable
        sqlDAT.Fill(sqlDTa)
        dgvmovimiento.DataSource = sqlDTa

    End Sub



    Private Sub Movimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'UNIDOSBGDataSet2.PROYECTOS' Puede moverla o quitarla según sea necesario.
        Me.PROYECTOSTableAdapter1.Fill(Me.UNIDOSBGDataSet2.PROYECTOS)
        'TODO: esta línea de código carga datos en la tabla 'UNIDOSBGDataSet1.PROYECTOS' Puede moverla o quitarla según sea necesario.
        Me.PROYECTOSTableAdapter.Fill(Me.UNIDOSBGDataSet1.PROYECTOS)
        mostrar()
    End Sub

    Private Sub btnmsaldo_Click(sender As Object, e As EventArgs)
        My.Forms.Movimientos.Close()
    End Sub

    Private Sub btnmsalir_Click(sender As Object, e As EventArgs)
        My.Forms.Movimientos.Close()
        My.Forms.menua.Show()
    End Sub
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvmovimiento.CellContentClick

    End Sub

    Private Sub btnmagregar_Click_1(sender As Object, e As EventArgs) Handles btnmagregar.Click
        Try


            If String.IsNullOrEmpty(cbmtipo.Text) Or String.IsNullOrEmpty(cbmingresos.Text) Or String.IsNullOrEmpty(dtpfecha.Text) Or String.IsNullOrEmpty(txtdetalle.Text) Or String.IsNullOrEmpty(txtmonto.Text) Then

                MessageBox.Show("Llenar los campos")


            Else

                Dim connexion As New SqlConnection(My.Settings.UNIDOSConnectionString)
                connexion.Open()
                Dim sqlcmdd As New SqlCommand
                sqlcmdd.Connection = connexion
                sqlcmdd.CommandType = CommandType.StoredProcedure
                sqlcmdd.CommandText = "INGRESOMOVIMIENTO"
                sqlcmdd.Parameters.Add(New SqlParameter("@tipo", SqlDbType.VarChar, 50)).Value = cbmtipo.Text
                sqlcmdd.Parameters.Add(New SqlParameter("@subtipo", SqlDbType.VarChar, 50)).Value = cbmingresos.Text
                sqlcmdd.Parameters.Add(New SqlParameter("@fecha", SqlDbType.Date)).Value = dtpfecha.Text
                sqlcmdd.Parameters.Add(New SqlParameter("@detalle", SqlDbType.VarChar, 50)).Value = txtdetalle.Text
                sqlcmdd.Parameters.Add(New SqlParameter("@monto", SqlDbType.Int)).Value = txtmonto.Text
                Dim read As SqlDataReader
                read = sqlcmdd.ExecuteReader
                MessageBox.Show("La transaccion fue registrado de manera exitosa")

                read.Close()
                mostrar()
                txtmovimiento.Text = ""
                cbmtipo.Text = ""
                cbmingresos.Text = ""
                dtpfecha.Text = ""
                txtdetalle.Text = ""
                txtmonto.Text = ""
            End If
        Catch ex As Exception
            MsgBox("Revisar datos")
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvmovimiento.CellClick



    End Sub

    Private Sub btnmmodificar_Click(sender As Object, e As EventArgs) Handles btnmmodificar.Click
        Try
            If String.IsNullOrEmpty(txtmovimiento.Text) Then
                MsgBox("Ingresar datos")
            Else

                Dim con As New SqlConnection(My.Settings.UNIDOSConnectionString)
                Dim cmd As New SqlCommand
                con.Open()

                cmd.Connection = con
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "validarmovimiento"

                cmd.Parameters.Add(New SqlParameter("@MovimientoID", SqlDbType.Int)).Value = txtmovimiento.Text

                Dim reader As SqlDataReader
                reader = cmd.ExecuteReader

                Dim r As Boolean = reader.HasRows()
                If r = False Then
                    MessageBox.Show("Dato incorrecto, favor revisar movimiento.")
                    txtmovimiento.Text = ""
                Else
                    Dim conexion As New SqlConnection(My.Settings.UNIDOSConnectionString)
                    conexion.Open()

                    Dim sqlCmd As New SqlCommand
                    sqlCmd.Connection = conexion
                    sqlCmd.CommandType = CommandType.StoredProcedure
                    sqlCmd.CommandText = "modificarmovimientos"
                    sqlCmd.Parameters.Add(New SqlParameter("@movimientoid", SqlDbType.Int)).Value = txtmovimiento.Text
                    sqlCmd.Parameters.Add(New SqlParameter("@tipo", SqlDbType.VarChar, 50)).Value = cbmtipo.Text
                    sqlCmd.Parameters.Add(New SqlParameter("@subtipo", SqlDbType.VarChar, 50)).Value = cbmingresos.Text
                    sqlCmd.Parameters.Add(New SqlParameter("@fecha", SqlDbType.Date)).Value = dtpfecha.Text
                    sqlCmd.Parameters.Add(New SqlParameter("@detalle", SqlDbType.VarChar, 50)).Value = txtdetalle.Text
                    sqlCmd.Parameters.Add(New SqlParameter("@monto", SqlDbType.Int)).Value = txtmonto.Text
                    Dim read As SqlDataReader
                    read = sqlCmd.ExecuteReader
                    MessageBox.Show("Datos Modificados")
                    cbmtipo.Text = " "
                    cbmingresos.Text = " "
                    txtdetalle.Clear()
                    txtmonto.Clear()
                    txtmovimiento.Clear()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Revisar datos ingresados")
        End Try
        mostrar()
    End Sub

    Private Sub btnmeliminar_Click_1(sender As Object, e As EventArgs) Handles btnmeliminar.Click
        Try
            If txtmovimiento.Text = "" Then
                MsgBox("Ingresar datos")
            Else

                Dim con As New SqlConnection(My.Settings.UNIDOSConnectionString)
                Dim cmd As New SqlCommand
                con.Open()

                cmd.Connection = con
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "validarmovimiento"

                cmd.Parameters.Add(New SqlParameter("@MovimientoID", SqlDbType.Int)).Value = txtmovimiento.Text

                Dim reader As SqlDataReader
                reader = cmd.ExecuteReader

                Dim r As Boolean = reader.HasRows()
                If r = False Then
                    MessageBox.Show("El Movimiento no está registrado")
                    txtmovimiento.Text = ""
                Else
                    Dim conexion As New SqlConnection(My.Settings.UNIDOSConnectionString)
                    conexion.Open()
                    Dim sqlCm As New SqlCommand
                    sqlCm.Connection = conexion
                    sqlCm.CommandType = CommandType.StoredProcedure
                    sqlCm.CommandText = "eliminarmovimiento"
                    sqlCm.Parameters.Add(New SqlParameter("@movimientoid", SqlDbType.Int)).Value = txtmovimiento.Text
                    Dim read As SqlDataReader
                    read = sqlCm.ExecuteReader
                    MessageBox.Show("Datos Borrados")
                    mostrar()
                    cbmtipo.Text = " "
                    cbmingresos.Text = " "
                    txtdetalle.Clear()
                    txtmonto.Clear()
                    txtmovimiento.Clear()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("favor evisar movimiento")

        End Try

    End Sub

    Private Sub btnmsalir_Click_1(sender As Object, e As EventArgs) Handles btnmsalir.Click
        My.Forms.menua.Show()
        My.Forms.Movimientos.Close()
    End Sub

    Private Sub btnmsaldo_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnmlimpiar_Click(sender As Object, e As EventArgs) Handles btnmlimpiar.Click
        cmconcepto.Text = ""
        dtdesde.Value = Date.Now()
        dthasta.Value = Date.Now()
        Me.dataMovimientos.DataSource = Nothing
    End Sub

    Private Sub btnmvertodo_Click(sender As Object, e As EventArgs) Handles btnmvertodo.Click
        Try


            Dim con As New SqlConnection(My.Settings.UNIDOSConnectionString)
            Dim cmd As New SqlCommand
            con.Open()

            cmd.Connection = con
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "consultarmovimiento"
            cmd.Parameters.Add(New SqlParameter("@desde", SqlDbType.Date)).Value = dtdesde.Text
            cmd.Parameters.Add(New SqlParameter("@hasta", SqlDbType.Date)).Value = dthasta.Text
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                dataMovimientos.DataSource = dt
            End If
        Catch ex As Exception
            MsgBox("Llenar la caja o un dato es erroneo")
        End Try
    End Sub

    Private Sub btnmbuscar_Click(sender As Object, e As EventArgs) Handles btnmbuscar.Click
        Try


            Dim con As New SqlConnection(My.Settings.UNIDOSConnectionString)
            Dim cmd As New SqlCommand
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "consultarmovimientoesp"
            cmd.Parameters.Add(New SqlParameter("@desde", SqlDbType.Date)).Value = dtdesde.Text
            cmd.Parameters.Add(New SqlParameter("@hasta", SqlDbType.Date)).Value = dthasta.Text
            cmd.Parameters.Add(New SqlParameter("@Tipo", SqlDbType.VarChar, 50)).Value = cmconcepto.Text
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                dataMovimientos.DataSource = dt
            End If
        Catch ex As Exception
            MsgBox("Lene la caja o dato erroneo")
        End Try
    End Sub

    Private Sub btnsalirs_Click(sender As Object, e As EventArgs) Handles btnsalirs.Click
        menua.Show()
        My.Forms.Movimientos.Close()
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Try


            Dim con As New SqlConnection(My.Settings.UNIDOSConnectionString)
            Dim cmd As New SqlCommand
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "consultasaldoIo"
            cmd.Parameters.Add(New SqlParameter("@desde", SqlDbType.Date)).Value = dedesde.Text
            cmd.Parameters.Add(New SqlParameter("@hasta", SqlDbType.Date)).Value = dehasta.Text
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                txtingreso.Text = dt.Rows(0)(1)
            End If
            Dim conn As New SqlConnection(My.Settings.UNIDOSConnectionString)
            Dim cmdd As New SqlCommand
            conn.Open()
            cmdd.Connection = con
            cmdd.CommandType = CommandType.StoredProcedure
            cmdd.CommandText = "consultasaldog"
            cmdd.Parameters.Add(New SqlParameter("@desde", SqlDbType.Date)).Value = dedesde.Text
            cmdd.Parameters.Add(New SqlParameter("@hasta", SqlDbType.Date)).Value = dehasta.Text
            Dim dtt As New DataTable
            Dim daa As New SqlDataAdapter
            daa.SelectCommand = cmdd
            daa.Fill(dtt)
            If dtt.Rows.Count > 0 Then
                txtgasto.Text = dtt.Rows(0)(1)
            End If
            txtsalperiodo.Text = txtingreso.Text - txtgasto.Text
        Catch ex As Exception
            MsgBox("Datos incompletos. favor revisar")
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cbmtipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbmtipo.SelectedIndexChanged
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub
End Class