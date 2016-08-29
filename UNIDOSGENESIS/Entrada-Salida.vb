Imports System.Data.SqlClient
Public Class Entrada_Salida


    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim conn As New SqlConnection(My.Settings.UNIDOSConnectionString)
        Dim cmdd As New SqlCommand
        conn.Open()
        cmdd.Connection = conn
        cmdd.CommandType = CommandType.StoredProcedure
        cmdd.CommandText = "buscarcantidad"
        cmdd.Parameters.Add(New SqlParameter("@ProductoID", SqlDbType.Int)).Value = cboproducto.Text
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        da.SelectCommand = cmdd
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            txtactual.Text = dt.Rows(0)(0)
        End If
    End Sub



    Private Sub cboproducto1_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim conexion As New SqlConnection(My.Settings.UNIDOSConnectionString)
        Dim cmd As New SqlCommand
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "buscarcantidad"
        cmd.Parameters.Add(New SqlParameter("@ProductoID", SqlDbType.Int)).Value = cboproducto1.Text
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        da.SelectCommand = cmd
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            txtactual1.Text = dt.Rows(0)(0)
        End If
    End Sub


    Private Sub btningreso_producto_Click(sender As Object, e As EventArgs) Handles btningreso_producto.Click
        Try
            If String.IsNullOrEmpty(cbocedula.Text) Or String.IsNullOrEmpty(cboproducto.Text) Or String.IsNullOrEmpty(txtcantidad.Text) Then
                MessageBox.Show("Favor de ingresar los datos completos")
            Else
                Dim ingreso As Double

                Dim conexion As New SqlConnection(My.Settings.UNIDOSConnectionString)
                Dim cmd As New SqlCommand
                ingreso = CDbl(txtcantidad.Text) + CDbl(txtactual.Text)
                conexion.Open()

                cmd.Connection = conexion
                cmd.Connection = conexion
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "modificar_inventario"
                cmd.Parameters.Add(New SqlParameter("@ProductoID", SqlDbType.Int)).Value = cboproducto.Text
                cmd.Parameters.Add(New SqlParameter("@Cantidad", SqlDbType.Int)).Value = ingreso
                Dim read As SqlDataReader
                read = cmd.ExecuteReader
                MsgBox("Ingreso exitoso")
                cboproducto.Text = ""
                cbocedula.Text = ""
                txtcantidad.Text = ""
                txtactual.Text = ""
            End If
        Catch ex As Exception
            MsgBox("Favor de revisar que esten todos los campos llenos")
        End Try
    End Sub

    Private Sub btnsacar_producto_Click(sender As Object, e As EventArgs) Handles btnsacar_producto.Click
        Try
            If String.IsNullOrEmpty(txtcedula1.Text) Or String.IsNullOrEmpty(cboproducto1.Text) Or String.IsNullOrEmpty(txtcantidad1.Text) Then
                MessageBox.Show("Favor de ingresar los datos completos")
            Else
                Dim Salida As Double
                Dim conexion As New SqlConnection(My.Settings.UNIDOSConnectionString)
                Dim cmd As New SqlCommand
                Salida = CDbl(txtactual1.Text) - CDbl(txtcantidad1.Text)
                If Salida < 0 Then
                    MsgBox("No hay suficiente Stock")
                Else

                    conexion.Open()
                    cmd.Connection = conexion
                    cmd.Connection = conexion
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "modificar_inventario"
                    cmd.Parameters.Add(New SqlParameter("@ProductoID", SqlDbType.Int)).Value = cboproducto1.Text
                    cmd.Parameters.Add(New SqlParameter("@Cantidad", SqlDbType.Int)).Value = Salida
                    Dim read As SqlDataReader
                    read = cmd.ExecuteReader
                    MsgBox("Salida exitosa")
                    cboproducto1.Text = ""
                    txtcedula1.Text = ""
                    txtcantidad1.Text = ""
                    txtactual1.Text = ""
                End If
            End If
        Catch ex As Exception
            MsgBox("Favor de revisar que esten todos los campos llenos")
        End Try
    End Sub

    Private Sub txtactual1_TextChanged(sender As Object, e As EventArgs) Handles txtactual1.TextChanged

    End Sub

    Private Sub cboproducto1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cboproducto1.SelectedIndexChanged

    End Sub
End Class