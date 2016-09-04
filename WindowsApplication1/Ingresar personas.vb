Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'UNIDOSDataSet.DEPARTAMENTO' Puede moverla o quitarla según sea necesario.
        Me.DEPARTAMENTOTableAdapter.Fill(Me.UNIDOSDataSet.DEPARTAMENTO)

    End Sub

    Private Sub txtcedula_TextChanged(sender As Object, e As EventArgs) Handles txtcedula.TextChanged

    End Sub
End Class