<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Proyectos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu_Proyectos))
        Me.btnvolver = New System.Windows.Forms.Button()
        Me.btneliminarproyecto = New System.Windows.Forms.Button()
        Me.btnmodificarproyecto = New System.Windows.Forms.Button()
        Me.btnnuevoproyecto = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnvolver
        '
        Me.btnvolver.BackColor = System.Drawing.Color.Transparent
        Me.btnvolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnvolver.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnvolver.ForeColor = System.Drawing.Color.White
        Me.btnvolver.Location = New System.Drawing.Point(57, 282)
        Me.btnvolver.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.btnvolver.Name = "btnvolver"
        Me.btnvolver.Size = New System.Drawing.Size(207, 34)
        Me.btnvolver.TabIndex = 7
        Me.btnvolver.Text = "Volver"
        Me.btnvolver.UseVisualStyleBackColor = False
        '
        'btneliminarproyecto
        '
        Me.btneliminarproyecto.BackColor = System.Drawing.Color.Transparent
        Me.btneliminarproyecto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btneliminarproyecto.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminarproyecto.ForeColor = System.Drawing.Color.White
        Me.btneliminarproyecto.Location = New System.Drawing.Point(57, 243)
        Me.btneliminarproyecto.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.btneliminarproyecto.Name = "btneliminarproyecto"
        Me.btneliminarproyecto.Size = New System.Drawing.Size(207, 31)
        Me.btneliminarproyecto.TabIndex = 6
        Me.btneliminarproyecto.Text = "Eliminar proyecto"
        Me.btneliminarproyecto.UseVisualStyleBackColor = False
        '
        'btnmodificarproyecto
        '
        Me.btnmodificarproyecto.BackColor = System.Drawing.Color.Transparent
        Me.btnmodificarproyecto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnmodificarproyecto.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodificarproyecto.ForeColor = System.Drawing.Color.White
        Me.btnmodificarproyecto.Location = New System.Drawing.Point(57, 207)
        Me.btnmodificarproyecto.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.btnmodificarproyecto.Name = "btnmodificarproyecto"
        Me.btnmodificarproyecto.Size = New System.Drawing.Size(207, 28)
        Me.btnmodificarproyecto.TabIndex = 5
        Me.btnmodificarproyecto.Text = "Modificar proyecto"
        Me.btnmodificarproyecto.UseVisualStyleBackColor = False
        '
        'btnnuevoproyecto
        '
        Me.btnnuevoproyecto.BackColor = System.Drawing.Color.Transparent
        Me.btnnuevoproyecto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnnuevoproyecto.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnuevoproyecto.ForeColor = System.Drawing.Color.White
        Me.btnnuevoproyecto.Location = New System.Drawing.Point(57, 168)
        Me.btnnuevoproyecto.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.btnnuevoproyecto.Name = "btnnuevoproyecto"
        Me.btnnuevoproyecto.Size = New System.Drawing.Size(207, 31)
        Me.btnnuevoproyecto.TabIndex = 4
        Me.btnnuevoproyecto.Text = "Nuevo proyecto"
        Me.btnnuevoproyecto.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 14.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(120, 109)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 21)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "MENÚ PROYECTOS"
        '
        'Menu_Proyectos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(469, 357)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnvolver)
        Me.Controls.Add(Me.btneliminarproyecto)
        Me.Controls.Add(Me.btnmodificarproyecto)
        Me.Controls.Add(Me.btnnuevoproyecto)
        Me.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.Name = "Menu_Proyectos"
        Me.Text = "Menu_Proyectos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnvolver As Button
    Friend WithEvents btneliminarproyecto As Button
    Friend WithEvents btnmodificarproyecto As Button
    Friend WithEvents btnnuevoproyecto As Button
    Friend WithEvents Label1 As Label
End Class
