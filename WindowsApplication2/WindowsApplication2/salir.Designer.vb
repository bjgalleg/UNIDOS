<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class finanzas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnnuevoregistro = New System.Windows.Forms.Button()
        Me.nuevaconsulta = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnnuevoregistro
        '
        Me.btnnuevoregistro.Location = New System.Drawing.Point(147, 74)
        Me.btnnuevoregistro.Name = "btnnuevoregistro"
        Me.btnnuevoregistro.Size = New System.Drawing.Size(148, 23)
        Me.btnnuevoregistro.TabIndex = 0
        Me.btnnuevoregistro.Text = "Nuevo registro"
        Me.btnnuevoregistro.UseVisualStyleBackColor = True
        '
        'nuevaconsulta
        '
        Me.nuevaconsulta.Location = New System.Drawing.Point(147, 135)
        Me.nuevaconsulta.Name = "nuevaconsulta"
        Me.nuevaconsulta.Size = New System.Drawing.Size(148, 23)
        Me.nuevaconsulta.TabIndex = 1
        Me.nuevaconsulta.Text = "Nueva consulta"
        Me.nuevaconsulta.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(184, 207)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 23)
        Me.btnsalir.TabIndex = 2
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'finanzas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 389)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.nuevaconsulta)
        Me.Controls.Add(Me.btnnuevoregistro)
        Me.Name = "finanzas"
        Me.Text = "Finanzas"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnnuevoregistro As Button
    Friend WithEvents nuevaconsulta As Button
    Friend WithEvents btnsalir As Button
End Class
