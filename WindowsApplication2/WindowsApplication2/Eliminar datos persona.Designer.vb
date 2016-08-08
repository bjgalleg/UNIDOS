<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EliminarDatos
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
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnvolver = New System.Windows.Forms.Button()
        Me.ced = New System.Windows.Forms.Label()
        Me.txtced = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(49, 134)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(75, 23)
        Me.btneliminar.TabIndex = 0
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'btnvolver
        '
        Me.btnvolver.Location = New System.Drawing.Point(166, 134)
        Me.btnvolver.Name = "btnvolver"
        Me.btnvolver.Size = New System.Drawing.Size(75, 23)
        Me.btnvolver.TabIndex = 1
        Me.btnvolver.Text = "Volver"
        Me.btnvolver.UseVisualStyleBackColor = True
        '
        'ced
        '
        Me.ced.AutoSize = True
        Me.ced.Location = New System.Drawing.Point(49, 74)
        Me.ced.Name = "ced"
        Me.ced.Size = New System.Drawing.Size(77, 13)
        Me.ced.TabIndex = 2
        Me.ced.Text = "Ingrese cédula"
        '
        'txtced
        '
        Me.txtced.Location = New System.Drawing.Point(133, 74)
        Me.txtced.Name = "txtced"
        Me.txtced.Size = New System.Drawing.Size(100, 20)
        Me.txtced.TabIndex = 3
        '
        'EliminarDatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.txtced)
        Me.Controls.Add(Me.ced)
        Me.Controls.Add(Me.btnvolver)
        Me.Controls.Add(Me.btneliminar)
        Me.Name = "EliminarDatos"
        Me.Text = "Eliminar datos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btneliminar As Button
    Friend WithEvents btnvolver As Button
    Friend WithEvents ced As Label
    Friend WithEvents txtced As TextBox
End Class
