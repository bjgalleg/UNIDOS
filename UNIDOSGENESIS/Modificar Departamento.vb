Imports System.Data.SqlClient
Public Class Modificar_Departamento
    Private Sub btnbusdepart_Click(sender As Object, e As EventArgs) Handles btnbusdepart.Click
        Try
            If txtbuscar.Text = "" Then
                MsgBox("No ingreso el dato")
            Else
                Dim con As New SqlConnection(My.Settings.UNIDOSConnectionString)
                Dim cmd As New SqlCommand
                con.Open()
                cmd.Connection = con
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "validar_departamento"
                cmd.Parameters.Add(New SqlParameter("@DepartamentoID", SqlDbType.Int)).Value = txtbuscar.Text
                Dim reader As SqlDataReader
                reader = cmd.ExecuteReader
                Dim r As Boolean = reader.HasRows()
                If r = False Then
                    MessageBox.Show("El Departamento  no está registrado")
                    txtbuscar.Text = ""
                Else
                    Dim conn As New SqlConnection(My.Settings.UNIDOSConnectionString)
                    Dim cmdd As New SqlCommand
                    conn.Open()
                    cmdd.Connection = conn
                    cmdd.CommandType = CommandType.StoredProcedure
                    cmdd.CommandText = "buscardepartamento"
                    cmdd.Parameters.Add(New SqlParameter("@DepartamentoID", SqlDbType.Int)).Value = txtbuscar.Text
                    Dim dt As New DataTable
                    Dim da As New SqlDataAdapter
                    da.SelectCommand = cmdd
                    da.Fill(dt)
                    If dt.Rows.Count > 0 Then

                        txtnombredpto.Text = dt.Rows(0)(1)
                        txtfunciones.Text = dt.Rows(0)(2)
                        cmbresponsable.Text = dt.Rows(0)(3)
                        txtmovimientoid.Text = dt.Rows(0)(4)
                        txtproyectoid.Text = dt.Rows(0)(5)
                    End If

                End If
            End If
        Catch ex As Exception
            MsgBox("Algun dato debe ser erroneo")
        End Try
    End Sub

    Private Sub Modificar_Departamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'UNIDOSBGDataSet.PROYECTOS' table. You can move, or remove it, as needed.
        Me.PROYECTOSTableAdapter.Fill(Me.UNIDOSBGDataSet.PROYECTOS)
        'TODO: This line of code loads data into the 'UNIDOSBGDataSet.MOVIMIENTOS' table. You can move, or remove it, as needed.
        Me.MOVIMIENTOSTableAdapter.Fill(Me.UNIDOSBGDataSet.MOVIMIENTOS)

        mostrar()
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try
            If txtbuscar.Text = "" Then
                MsgBox("No ingreso el dato")
            Else
                Dim conn As New SqlConnection(My.Settings.UNIDOSConnectionString)
                Dim cmdd As New SqlCommand
                conn.Open()
                cmdd.Connection = conn
                cmdd.Connection = conn
                cmdd.CommandType = CommandType.StoredProcedure
                cmdd.CommandText = "modificardepartamento"
                cmdd.Parameters.Add(New SqlParameter("@DepartamentoID", SqlDbType.Int)).Value = txtbuscar.Text
                cmdd.Parameters.Add(New SqlParameter("@Nombre", SqlDbType.VarChar, 50)).Value = txtnombredpto.Text
                cmdd.Parameters.Add(New SqlParameter("@funcion", SqlDbType.VarChar, 50)).Value = txtfunciones.Text
                cmdd.Parameters.Add(New SqlParameter("@Responsable", SqlDbType.VarChar, 50)).Value = cmbresponsable.Text
                cmdd.Parameters.Add(New SqlParameter("@MovimientoID", SqlDbType.Int)).Value = txtmovimientoid.Text
                cmdd.Parameters.Add(New SqlParameter("@ProyectoID", SqlDbType.Int)).Value = txtproyectoid.Text
                Dim read As SqlDataReader
                read = cmdd.ExecuteReader

                txtnombredpto.Text = ""
                txtfunciones.Text = ""
                cmbresponsable.Text = ""
                txtmovimientoid.Text = ""
                txtproyectoid.Text = ""
                txtbuscar.Text = ""
                MsgBox("Proyecto modificado")
            End If
        Catch ex As Exception
            MsgBox("Verifique Datos")
        End Try
        mostrar()
    End Sub
    Sub mostrar()
        Dim connexion As New SqlConnection(My.Settings.UNIDOSConnectionString)
        connexion.Open()
        Dim sqlCmdo As New SqlCommand
        sqlCmdo.Connection = connexion

        sqlCmdo.CommandType = CommandType.StoredProcedure
        sqlCmdo.CommandText = "mostrardepartamento"
        Dim sqlDAT As New SqlDataAdapter()
        sqlDAT.SelectCommand = sqlCmdo
        Dim sqlDTa As New DataTable
        sqlDAT.Fill(sqlDTa)
        dgvdepartamento.DataSource = sqlDTa

    End Sub

    Private Sub btnvolver_Click(sender As Object, e As EventArgs) Handles btnvolver.Click
        My.Forms.Menu_Departamento.Show()
        My.Forms.Modificar_Departamento.Close()
    End Sub
End Class