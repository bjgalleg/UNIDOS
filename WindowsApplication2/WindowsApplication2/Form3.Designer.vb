<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class menuv
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnreportes = New System.Windows.Forms.Button()
        Me.btnpago = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(107, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Menú voluntario"
        '
        'btnreportes
        '
        Me.btnreportes.Location = New System.Drawing.Point(44, 69)
        Me.btnreportes.Name = "btnreportes"
        Me.btnreportes.Size = New System.Drawing.Size(75, 41)
        Me.btnreportes.TabIndex = 1
        Me.btnreportes.Text = "Reportes"
        Me.btnreportes.UseVisualStyleBackColor = True
        '
        'btnpago
        '
        Me.btnpago.Location = New System.Drawing.Point(165, 69)
        Me.btnpago.Name = "btnpago"
        Me.btnpago.Size = New System.Drawing.Size(75, 41)
        Me.btnpago.TabIndex = 2
        Me.btnpago.Text = "Ingresar pago"
        Me.btnpago.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(110, 149)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 23)
        Me.btnsalir.TabIndex = 3
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'menuv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnpago)
        Me.Controls.Add(Me.btnreportes)
        Me.Controls.Add(Me.Label1)
        Me.Name = "menuv"
        Me.Text = "Menu voluntario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnreportes As Button
    Friend WithEvents btnpago As Button
    Friend WithEvents btnsalir As Button
End Class
