Public Class Proyectos
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnvolver_Click(sender As Object, e As EventArgs) Handles btnvolver.Click
        Me.Close()
    End Sub

    Private Sub btneliminarproyecto_Click(sender As Object, e As EventArgs) Handles btneliminarproyecto.Click
        eliminarproyecto.Show()
    End Sub

    Private Sub btnmodificarproyecto_Click(sender As Object, e As EventArgs) Handles btnmodificarproyecto.Click
        modificarproyecto.Show()
    End Sub

    Private Sub btnnuevoproyecto_Click(sender As Object, e As EventArgs) Handles btnnuevoproyecto.Click
        nuevoproyecto.Show()
    End Sub
End Class