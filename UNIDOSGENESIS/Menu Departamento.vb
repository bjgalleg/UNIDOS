Public Class Menu_Departamento
    Private Sub btnnvodpto_Click(sender As Object, e As EventArgs) Handles btnnvodpto.Click
        My.Forms.Nuevo_Departamento.Show()
        My.Forms.Menu_Departamento.Close()
    End Sub

    Private Sub btnmdpto_Click(sender As Object, e As EventArgs) Handles btnmdpto.Click
        My.Forms.Modificar_Departamento.Show()
        My.Forms.Menu_Departamento.Close()

    End Sub

    Private Sub btneliminardpto_Click(sender As Object, e As EventArgs) Handles btneliminardpto.Click
        My.Forms.Eliminar_Departamento.Show()
        My.Forms.Menu_Departamento.Close()
    End Sub

    Private Sub Menu_Departamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnvolver_Click(sender As Object, e As EventArgs) Handles btnvolver.Click
        My.Forms.menua.Show()
        My.Forms.Menu_Departamento.Close()
    End Sub
End Class