Public Class menua
    Private Sub btnfinanzas_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub btnpersonas_Click(sender As Object, e As EventArgs) Handles btnpersonas.Click
        My.Forms.Menu_Personas.Show()
        My.Forms.menua.Close()
    End Sub

    Private Sub btnmovimientos_Click(sender As Object, e As EventArgs) Handles btnmovimientos.Click
        My.Forms.Movimientos.Show()
        My.Forms.menua.Close()
    End Sub

    Private Sub btnproyectos_Click(sender As Object, e As EventArgs) Handles btnproyectos.Click
        My.Forms.Menu_Proyectos.Show()
        My.Forms.menua.Close()
    End Sub

    Private Sub btndepartamentos_Click(sender As Object, e As EventArgs) Handles btndepartamentos.Click
        My.Forms.Menu_Departamento.Show()
        My.Forms.menua.Close()
    End Sub

    Private Sub btncerrarsecion_Click(sender As Object, e As EventArgs) Handles btncerrarsecion.Click
        My.Forms.LOGINUNIDOS.Show()
        My.Forms.menua.Close()
        Application.Restart()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Forms.Inventario.Show()
        My.Forms.menua.Close()
    End Sub

    Private Sub menua_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Forms.Entrada_Salida.Show()
        My.Forms.menua.Close()
    End Sub
End Class