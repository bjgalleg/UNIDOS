Public Class menupersonas
    Private Sub btningresar_Click(sender As Object, e As EventArgs) Handles btningresar.Click
        IngresarPersonas.Show()
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        modificarpersona.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        EliminarDatos.Show()
    End Sub
End Class