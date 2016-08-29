Public Class Menu_Proyectos
    Private Sub btnnuevoproyecto_Click(sender As Object, e As EventArgs) Handles btnnuevoproyecto.Click
        My.Forms.Menu_Proyectos.Close()
        My.Forms.Nuevo_Proyecto.Show()
    End Sub

    Private Sub btnmodificarproyecto_Click(sender As Object, e As EventArgs) Handles btnmodificarproyecto.Click
        My.Forms.Menu_Proyectos.Close()
        My.Forms.Modificar_Proyecto.Show()
    End Sub

    Private Sub btneliminarproyecto_Click(sender As Object, e As EventArgs) Handles btneliminarproyecto.Click
        My.Forms.Menu_Proyectos.Close()
        My.Forms.Eliminar_Proyecto.Show()
    End Sub

    Private Sub btnvolver_Click(sender As Object, e As EventArgs) Handles btnvolver.Click
        My.Forms.Menu_Proyectos.Close()
        My.Forms.menua.Show()
    End Sub

    Private Sub Menu_Proyectos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class