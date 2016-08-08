<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proyectos
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
        Me.btnnuevoproyecto = New System.Windows.Forms.Button()
        Me.btnmodificarproyecto = New System.Windows.Forms.Button()
        Me.btneliminarproyecto = New System.Windows.Forms.Button()
        Me.btnvolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnnuevoproyecto
        '
        Me.btnnuevoproyecto.Location = New System.Drawing.Point(136, 37)
        Me.btnnuevoproyecto.Name = "btnnuevoproyecto"
        Me.btnnuevoproyecto.Size = New System.Drawing.Size(120, 23)
        Me.btnnuevoproyecto.TabIndex = 0
        Me.btnnuevoproyecto.Text = "Nuevo proyecto"
        Me.btnnuevoproyecto.UseVisualStyleBackColor = True
        '
        'btnmodificarproyecto
        '
        Me.btnmodificarproyecto.Location = New System.Drawing.Point(136, 83)
        Me.btnmodificarproyecto.Name = "btnmodificarproyecto"
        Me.btnmodificarproyecto.Size = New System.Drawing.Size(120, 23)
        Me.btnmodificarproyecto.TabIndex = 1
        Me.btnmodificarproyecto.Text = "Modificar proyecto"
        Me.btnmodificarproyecto.UseVisualStyleBackColor = True
        '
        'btneliminarproyecto
        '
        Me.btneliminarproyecto.Location = New System.Drawing.Point(136, 129)
        Me.btneliminarproyecto.Name = "btneliminarproyecto"
        Me.btneliminarproyecto.Size = New System.Drawing.Size(120, 23)
        Me.btneliminarproyecto.TabIndex = 2
        Me.btneliminarproyecto.Text = "Eliminar proyecto"
        Me.btneliminarproyecto.UseVisualStyleBackColor = True
        '
        'btnvolver
        '
        Me.btnvolver.Location = New System.Drawing.Point(136, 177)
        Me.btnvolver.Name = "btnvolver"
        Me.btnvolver.Size = New System.Drawing.Size(120, 23)
        Me.btnvolver.TabIndex = 3
        Me.btnvolver.Text = "Volver"
        Me.btnvolver.UseVisualStyleBackColor = True
        '
        'Proyectos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 261)
        Me.Controls.Add(Me.btnvolver)
        Me.Controls.Add(Me.btneliminarproyecto)
        Me.Controls.Add(Me.btnmodificarproyecto)
        Me.Controls.Add(Me.btnnuevoproyecto)
        Me.Name = "Proyectos"
        Me.Text = "Proyectos"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnnuevoproyecto As Button
    Friend WithEvents btnmodificarproyecto As Button
    Friend WithEvents btneliminarproyecto As Button
    Friend WithEvents btnvolver As Button
End Class
