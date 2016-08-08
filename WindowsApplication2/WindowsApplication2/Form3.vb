Imports System.Data.SqlClient
Public Class menuv
    Public conn As New SqlConnection  'declaracion obj conexion
    Public Sub Conexión()
        Dim cadena As New SqlConnectionStringBuilder
        cadena.DataSource = "USUARIO\SQLEXPRESS"   'nombre del servidor
        cadena.InitialCatalog = "master"  'nombre de la BD
        cadena.IntegratedSecurity = True 'Authentication for windows
        'primer paso: instanciar obj de conexion
        cadena.ConnectionString = "Data Source=USUARIO\SQLEXPRESS;Initial Catalog=master;Integrated Security=True"
    End Sub

    Private Sub nuevousuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        End
    End Sub
End Class

