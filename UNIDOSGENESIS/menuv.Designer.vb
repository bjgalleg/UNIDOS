<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menuv
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menuv))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btncerrarsecion = New System.Windows.Forms.Button()
        Me.btnproyectos = New System.Windows.Forms.Button()
        Me.btnpersonas = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(87, 175)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(183, 32)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Inventario"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btncerrarsecion
        '
        Me.btncerrarsecion.BackColor = System.Drawing.Color.Transparent
        Me.btncerrarsecion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btncerrarsecion.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncerrarsecion.ForeColor = System.Drawing.Color.White
        Me.btncerrarsecion.Location = New System.Drawing.Point(102, 284)
        Me.btncerrarsecion.Name = "btncerrarsecion"
        Me.btncerrarsecion.Size = New System.Drawing.Size(151, 32)
        Me.btncerrarsecion.TabIndex = 12
        Me.btncerrarsecion.Text = "Cerrar Sesion"
        Me.btncerrarsecion.UseVisualStyleBackColor = False
        '
        'btnproyectos
        '
        Me.btnproyectos.BackColor = System.Drawing.Color.Transparent
        Me.btnproyectos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnproyectos.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnproyectos.ForeColor = System.Drawing.Color.White
        Me.btnproyectos.Location = New System.Drawing.Point(87, 227)
        Me.btnproyectos.Name = "btnproyectos"
        Me.btnproyectos.Size = New System.Drawing.Size(183, 32)
        Me.btnproyectos.TabIndex = 11
        Me.btnproyectos.Text = "Proyectos"
        Me.btnproyectos.UseVisualStyleBackColor = False
        '
        'btnpersonas
        '
        Me.btnpersonas.BackColor = System.Drawing.Color.Transparent
        Me.btnpersonas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnpersonas.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpersonas.ForeColor = System.Drawing.Color.White
        Me.btnpersonas.Location = New System.Drawing.Point(87, 127)
        Me.btnpersonas.Name = "btnpersonas"
        Me.btnpersonas.Size = New System.Drawing.Size(183, 31)
        Me.btnpersonas.TabIndex = 8
        Me.btnpersonas.Text = "Personas"
        Me.btnpersonas.UseVisualStyleBackColor = False
        '
        'menuv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(471, 350)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btncerrarsecion)
        Me.Controls.Add(Me.btnproyectos)
        Me.Controls.Add(Me.btnpersonas)
        Me.Name = "menuv"
        Me.Text = "menuv"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents btncerrarsecion As Button
    Friend WithEvents btnproyectos As Button
    Friend WithEvents btnpersonas As Button
End Class
