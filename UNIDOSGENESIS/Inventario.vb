Imports System.Data.SqlClient
Public Class Inventario
    Private Sub btnmsalir_Click(sender As Object, e As EventArgs) Handles btnmsalir.Click
        My.Forms.menua.Show()
        My.Forms.Inventario.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Forms.menua.Show()
        My.Forms.Inventario.Close()
    End Sub
    Sub mostrar()
        Dim connexion As New SqlConnection(My.Settings.UNIDOSConnectionString)
        connexion.Open()
        Dim sqlCmdo As New SqlCommand
        sqlCmdo.Connection = connexion
        sqlCmdo.CommandType = CommandType.StoredProcedure
        sqlCmdo.CommandText = "mostrarinventario"
        Dim sqlDAT As New SqlDataAdapter()
        sqlDAT.SelectCommand = sqlCmdo
        Dim sqlDTa As New DataTable
        sqlDAT.Fill(sqlDTa)
        dataproducto.DataSource = sqlDTa

    End Sub

    Private Sub btnmagregar_Click(sender As Object, e As EventArgs) Handles btnmagregar.Click
        Try


            If String.IsNullOrEmpty(cmcategoriaid.Text) Or String.IsNullOrEmpty(txtcantidad.Text) Or String.IsNullOrEmpty(txtnombre.Text) Or String.IsNullOrEmpty(txtprecio.Text) Then

                MessageBox.Show("Llenar todos los campos")


            Else
                Dim conexion As New SqlConnection(My.Settings.UNIDOSConnectionString)
                conexion.Open()

                Dim sqlcmd As New SqlCommand
                sqlcmd.Connection = conexion
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.CommandText = "buscarinventario"

                sqlcmd.Parameters.Add(New SqlParameter("@Producto", SqlDbType.VarChar, 50)).Value = txtnombre.Text


                Dim reader As SqlDataReader
                reader = sqlcmd.ExecuteReader

                Dim r As Boolean = reader.HasRows()
                If r = True Then

                    MessageBox.Show("Inventario ya ha sido registrado anteriormente ")
                    txtproductoid.Text = ""
                    txtnombre.Text = ""
                    cmcategoriaid.Text = ""
                    txtprecio.Text = ""
                    txtcantidad.Text = ""
                    conexion.Close()
                    reader.Close()
                Else
                    Dim connexion As New SqlConnection(My.Settings.UNIDOSConnectionString)
                    connexion.Open()
                    Dim sqlcmdd As New SqlCommand
                    sqlcmdd.Connection = connexion
                    sqlcmdd.CommandType = CommandType.StoredProcedure
                    sqlcmdd.CommandText = "ingresoinventario"
                    sqlcmdd.Parameters.Add(New SqlParameter("@Producto", SqlDbType.VarChar, 50)).Value = txtnombre.Text
                    sqlcmdd.Parameters.Add(New SqlParameter("@CategoriaID", SqlDbType.Int)).Value = cmcategoriaid.Text
                    sqlcmdd.Parameters.Add(New SqlParameter("@Cedula", SqlDbType.Int)).Value = txtcedula.Text
                    sqlcmdd.Parameters.Add(New SqlParameter("@Precio", SqlDbType.Int)).Value = txtprecio.Text
                    sqlcmdd.Parameters.Add(New SqlParameter("@Cantidad", SqlDbType.Int)).Value = txtcantidad.Text
                    Dim read As SqlDataReader
                    read = sqlcmdd.ExecuteReader
                    MessageBox.Show("Inventario Registrado")
                    conexion.Close()
                    read.Close()
                    mostrar()
                End If
                txtproductoid.Text = ""
                cmcategoriaid.Text = ""
                txtnombre.Text = ""
                txtcedula.Text = ""
                txtprecio.Text = ""
                txtcantidad.Text = ""
            End If
        Catch ex As Exception
            MsgBox("Un dato esta erroneo")
        End Try
    End Sub

    Private Sub txtnombre_TextChanged(sender As Object, e As EventArgs) Handles txtnombre.TextChanged

    End Sub
    Sub mostrarcate()
        Dim connexion As New SqlConnection(My.Settings.UNIDOSConnectionString)
        connexion.Open()
        Dim sqlCmdo As New SqlCommand
        sqlCmdo.Connection = connexion
        sqlCmdo.CommandType = CommandType.StoredProcedure
        sqlCmdo.CommandText = "mostrarcate"
        Dim sqlDAT As New SqlDataAdapter()
        sqlDAT.SelectCommand = sqlCmdo
        Dim sqlDTa As New DataTable
        sqlDAT.Fill(sqlDTa)
        datacategoria.DataSource = sqlDTa

    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try


            If String.IsNullOrEmpty(txtdescripcion.Text) Or String.IsNullOrEmpty(txnombre.Text) Then
                MessageBox.Show("Llenar los campos")
            Else
                Dim conexion As New SqlConnection(My.Settings.UNIDOSConnectionString)
                conexion.Open()

                Dim sqlcmd As New SqlCommand
                sqlcmd.Connection = conexion
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.CommandText = "buscarcategoria"
                sqlcmd.Parameters.Add(New SqlParameter("@Nombre", SqlDbType.VarChar, 50)).Value = txnombre.Text
                Dim reader As SqlDataReader
                reader = sqlcmd.ExecuteReader
                Dim r As Boolean = reader.HasRows()
                If r = True Then
                    MessageBox.Show("Categoria ya ha sido registrado anteriormente ")
                    txcategoriaid.Text = ""
                    txnombre.Text = ""
                    txtdescripcion.Text = ""
                    conexion.Close()
                    reader.Close()
                Else
                    Dim connexion As New SqlConnection(My.Settings.UNIDOSConnectionString)
                    connexion.Open()
                    Dim sqlcmdd As New SqlCommand
                    sqlcmdd.Connection = connexion
                    sqlcmdd.CommandType = CommandType.StoredProcedure
                    sqlcmdd.CommandText = "ingresocategoria"
                    sqlcmdd.Parameters.Add(New SqlParameter("@Nombre", SqlDbType.VarChar, 50)).Value = txnombre.Text
                    sqlcmdd.Parameters.Add(New SqlParameter("@Descripcion", SqlDbType.VarChar, 50)).Value = txtdescripcion.Text
                    Dim read As SqlDataReader
                    read = sqlcmdd.ExecuteReader
                    MessageBox.Show("Categoria Registrada")
                    conexion.Close()
                    read.Close()
                    mostrarcate()
                End If
                txcategoriaid.Text = ""
                txnombre.Text = ""
                txtdescripcion.Text = ""
            End If
        Catch ex As Exception
            MsgBox("Un dato esta erroneo")
        End Try
    End Sub

    Private Sub Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'UNIDOSBGDataSet.CATEGORIA' table. You can move, or remove it, as needed.
        Me.CATEGORIATableAdapter.Fill(Me.UNIDOSBGDataSet.CATEGORIA)

        mostrar()
        mostrarcate()
    End Sub

    Private Sub btnmmodificar_Click(sender As Object, e As EventArgs) Handles btnmmodificar.Click
        Try
            If String.IsNullOrEmpty(cmcategoriaid.Text) Or String.IsNullOrEmpty(txtcantidad.Text) Or String.IsNullOrEmpty(txtnombre.Text) Or String.IsNullOrEmpty(txtprecio.Text) Or String.IsNullOrEmpty(txtproductoid.Text) Then
                MessageBox.Show("Llenar los campos")
            Else
                Dim con As New SqlConnection(My.Settings.UNIDOSConnectionString)
                Dim cmd As New SqlCommand
                con.Open()
                cmd.Connection = con
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "buscarinventario"
                cmd.Parameters.Add(New SqlParameter("@ProductoID", SqlDbType.Int)).Value = txtproductoid.Text
                Dim reader As SqlDataReader
                reader = cmd.ExecuteReader
                Dim r As Boolean = reader.HasRows()
                If r = False Then
                    MessageBox.Show("El Producto no está registrado")
                    txtproductoid.Text = ""
                    cmcategoriaid.Text = ""
                    txtnombre.Text = ""
                    txtprecio.Text = ""
                    txtcantidad.Text = ""
                Else
                    Dim conn As New SqlConnection(My.Settings.UNIDOSConnectionString)
                    Dim cmdd As New SqlCommand
                    conn.Open()
                    cmdd.Connection = conn
                    cmdd.Connection = conn
                    cmdd.CommandType = CommandType.StoredProcedure
                    cmdd.CommandText = "modificarproducto"
                    cmdd.Parameters.Add(New SqlParameter("@ProductoID", SqlDbType.Int)).Value = txtproductoid.Text
                    cmdd.Parameters.Add(New SqlParameter("@Producto", SqlDbType.VarChar, 50)).Value = txtnombre.Text
                    cmdd.Parameters.Add(New SqlParameter("@CategoriaID", SqlDbType.Int)).Value = cmcategoriaid.Text
                    cmdd.Parameters.Add(New SqlParameter("@Cedula", SqlDbType.Int)).Value = txtcedula.Text
                    cmdd.Parameters.Add(New SqlParameter("@Precio", SqlDbType.Int)).Value = txtprecio.Text
                    cmdd.Parameters.Add(New SqlParameter("@Cantidad", SqlDbType.Int)).Value = txtcantidad.Text
                    Dim read As SqlDataReader
                    read = cmdd.ExecuteReader
                    MsgBox("Producto modificado")
                    mostrar()

                End If
            End If
        Catch ex As Exception
            MsgBox("Algun dato es erroneo")
        End Try
        txtproductoid.Text = ""
        cmcategoriaid.Text = ""
        txtnombre.Text = ""
        txtcedula.Text = ""
        txtprecio.Text = ""
        txtcantidad.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            If String.IsNullOrEmpty(txnombre.Text) Or String.IsNullOrEmpty(txcategoriaid.Text) Or String.IsNullOrEmpty(txtdescripcion.Text) Then
                MessageBox.Show("Llenar los campos")
            Else
                Dim con As New SqlConnection(My.Settings.UNIDOSConnectionString)
                Dim cmd As New SqlCommand
                con.Open()
                cmd.Connection = con
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "buscarcategoria1"
                cmd.Parameters.Add(New SqlParameter("@CategoriaID", SqlDbType.Int)).Value = txcategoriaid.Text
                Dim reader As SqlDataReader
                reader = cmd.ExecuteReader
                Dim r As Boolean = reader.HasRows()
                If r = False Then
                    MessageBox.Show("La Categoria no está registrada")
                    txcategoriaid.Text = ""
                    txnombre.Text = ""
                    txtdescripcion.Text = ""
                Else
                    Dim conn As New SqlConnection(My.Settings.UNIDOSConnectionString)
                    Dim cmdd As New SqlCommand
                    conn.Open()
                    cmdd.Connection = conn
                    cmdd.Connection = conn
                    cmdd.CommandType = CommandType.StoredProcedure
                    cmdd.CommandText = "modificarcategoria"
                    cmdd.Parameters.Add(New SqlParameter("@CategoriaID", SqlDbType.Int)).Value = txcategoriaid.Text
                    cmdd.Parameters.Add(New SqlParameter("@Nombre", SqlDbType.VarChar, 50)).Value = txnombre.Text
                    cmdd.Parameters.Add(New SqlParameter("@Descripcion", SqlDbType.VarChar, 50)).Value = txtdescripcion.Text
                    Dim read As SqlDataReader
                    read = cmdd.ExecuteReader
                    MsgBox("Categoria modificada")
                    mostrarcate()
                End If
            End If
        Catch ex As Exception
            MsgBox("Algun dato es erroneo")
        End Try
        txcategoriaid.Text = ""
        txnombre.Text = ""
        txtdescripcion.Text = ""
    End Sub

    Private Sub btnmeliminar_Click(sender As Object, e As EventArgs) Handles btnmeliminar.Click
        Try


            Dim sqlConn As New SqlConnection(My.Settings.UNIDOSConnectionString)
            sqlConn.Open()
            Dim sqlcmd As New SqlCommand
            sqlcmd.Connection = sqlConn
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.CommandText = "buscarinventario"
            sqlcmd.Parameters.Add(New SqlParameter("@ProductoID", SqlDbType.Int)).Value = txtproductoid.Text

            Dim reader As SqlDataReader
            reader = sqlcmd.ExecuteReader

            Dim r As Boolean = reader.HasRows()
            If r = True Then
                Dim connexion As New SqlConnection(My.Settings.UNIDOSConnectionString)
                connexion.Open()

                Dim sqlcmdd As New SqlCommand
                sqlcmdd.Connection = connexion
                sqlcmdd.CommandType = CommandType.StoredProcedure
                sqlcmdd.CommandText = "eliminarinventario"
                sqlcmdd.Parameters.Add(New SqlParameter("@ProductoID", SqlDbType.Int)).Value = txtproductoid.Text

                Dim readerr As SqlDataReader = sqlcmdd.ExecuteReader()
                MsgBox("Producto Eliminado")
            Else
                MsgBox("Producto no Encontrado")
            End If
            txcategoriaid.Text = ""
            txnombre.Text = ""
            txtdescripcion.Text = ""
        Catch ex As Exception
            MsgBox("Dato erroneo")
        End Try
        mostrar()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim sqlConn As New SqlConnection(My.Settings.UNIDOSConnectionString)
            sqlConn.Open()
            Dim sqlcmd As New SqlCommand
            sqlcmd.Connection = sqlConn
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.CommandText = "buscarcategoria1"
            sqlcmd.Parameters.Add(New SqlParameter("@CategoriaID", SqlDbType.Int)).Value = txcategoriaid.Text

            Dim reader As SqlDataReader
            reader = sqlcmd.ExecuteReader

            Dim r As Boolean = reader.HasRows()
            If r = True Then
                Dim connexion As New SqlConnection(My.Settings.UNIDOSConnectionString)
                connexion.Open()

                Dim sqlcmdd As New SqlCommand
                sqlcmdd.Connection = connexion
                sqlcmdd.CommandType = CommandType.StoredProcedure
                sqlcmdd.CommandText = "eliminarcategoria"
                sqlcmdd.Parameters.Add(New SqlParameter("@CategoriaID", SqlDbType.Int)).Value = txcategoriaid.Text

                Dim readerr As SqlDataReader = sqlcmdd.ExecuteReader()
                MsgBox("Categoria Eliminada")
            Else
                MsgBox("Categoria no Encontrada")
            End If
            txcategoriaid.Text = ""
            txnombre.Text = ""
            txtdescripcion.Text = ""
        Catch ex As Exception
            MsgBox("Dato erroneo")
        End Try
        mostrarcate()
    End Sub
End Class