Imports System.Data.SqlClient
Public Class menuv
    Private Sub btnvolver_Click(sender As Object, e As EventArgs)
        My.Forms.LOGINUNIDOS.Show()
        My.Forms.menuv.Close()
    End Sub

    Private Sub menuv_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnproyectos_Click(sender As Object, e As EventArgs) Handles btnproyectos.Click
        Menu_Proyectos.Show()
        Me.Close()
    End Sub

    Private Sub btnpersonas_Click(sender As Object, e As EventArgs) Handles btnpersonas.Click
        Menu_Personas.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Inventario.Show()
        Me.Close()
    End Sub

    Private Sub btncerrarsecion_Click(sender As Object, e As EventArgs) Handles btncerrarsecion.Click
        LOGINUNIDOS.Show()
        Me.Close()
    End Sub
End Class