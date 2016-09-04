Imports System.Data.SqlClient
Public Class Form1
    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btningresar_Click(sender As Object, e As EventArgs) Handles btningresar.Click

    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click

    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        End
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Menú.ItemClicked

    End Sub

    Private Sub DEPARTAMENTOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DEPARTAMENTOSToolStripMenuItem.Click

    End Sub

    Private Sub EliminarDepartamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarDepartamentoToolStripMenuItem.Click
        Eliminardepartamento.Show()
    End Sub

    Private Sub ModificarDepartamentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarDepartamentosToolStripMenuItem.Click
        Modificardepartamento.Show()
    End Sub

    Private Sub NuevoDepartamentiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoDepartamentiToolStripMenuItem.Click
        Nuevodepartamento.Show()
    End Sub

    Private Sub IngresarNuevoProyectoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresarNuevoProyectoToolStripMenuItem.Click

    End Sub
End Class
