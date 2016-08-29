<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menua
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menua))
        Me.btnpersonas = New System.Windows.Forms.Button()
        Me.btndepartamentos = New System.Windows.Forms.Button()
        Me.btnmovimientos = New System.Windows.Forms.Button()
        Me.btnproyectos = New System.Windows.Forms.Button()
        Me.btncerrarsecion = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnpersonas
        '
        Me.btnpersonas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnpersonas.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpersonas.ForeColor = System.Drawing.Color.Maroon
        Me.btnpersonas.Location = New System.Drawing.Point(22, 31)
        Me.btnpersonas.Name = "btnpersonas"
        Me.btnpersonas.Size = New System.Drawing.Size(183, 31)
        Me.btnpersonas.TabIndex = 0
        Me.btnpersonas.Text = "Personas"
        Me.btnpersonas.UseVisualStyleBackColor = True
        '
        'btndepartamentos
        '
        Me.btndepartamentos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btndepartamentos.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndepartamentos.ForeColor = System.Drawing.Color.Maroon
        Me.btndepartamentos.Location = New System.Drawing.Point(22, 133)
        Me.btndepartamentos.Name = "btndepartamentos"
        Me.btndepartamentos.Size = New System.Drawing.Size(183, 32)
        Me.btndepartamentos.TabIndex = 2
        Me.btndepartamentos.Text = "Departamentos"
        Me.btndepartamentos.UseVisualStyleBackColor = True
        '
        'btnmovimientos
        '
        Me.btnmovimientos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnmovimientos.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmovimientos.ForeColor = System.Drawing.Color.Maroon
        Me.btnmovimientos.Location = New System.Drawing.Point(303, 31)
        Me.btnmovimientos.Name = "btnmovimientos"
        Me.btnmovimientos.Size = New System.Drawing.Size(183, 31)
        Me.btnmovimientos.TabIndex = 3
        Me.btnmovimientos.Text = "Movimientos"
        Me.btnmovimientos.UseVisualStyleBackColor = True
        '
        'btnproyectos
        '
        Me.btnproyectos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnproyectos.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnproyectos.ForeColor = System.Drawing.Color.Maroon
        Me.btnproyectos.Location = New System.Drawing.Point(303, 83)
        Me.btnproyectos.Name = "btnproyectos"
        Me.btnproyectos.Size = New System.Drawing.Size(183, 32)
        Me.btnproyectos.TabIndex = 4
        Me.btnproyectos.Text = "Proyectos"
        Me.btnproyectos.UseVisualStyleBackColor = True
        '
        'btncerrarsecion
        '
        Me.btncerrarsecion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btncerrarsecion.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncerrarsecion.ForeColor = System.Drawing.Color.Maroon
        Me.btncerrarsecion.Location = New System.Drawing.Point(179, 304)
        Me.btncerrarsecion.Name = "btncerrarsecion"
        Me.btncerrarsecion.Size = New System.Drawing.Size(151, 32)
        Me.btncerrarsecion.TabIndex = 5
        Me.btncerrarsecion.Text = "Cerrar Sesion"
        Me.btncerrarsecion.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Maroon
        Me.Button1.Location = New System.Drawing.Point(22, 83)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(183, 32)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Inventario"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Maroon
        Me.Button2.Location = New System.Drawing.Point(303, 133)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(183, 32)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Entradas-Salidas"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'menua
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(521, 371)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btncerrarsecion)
        Me.Controls.Add(Me.btnproyectos)
        Me.Controls.Add(Me.btnmovimientos)
        Me.Controls.Add(Me.btndepartamentos)
        Me.Controls.Add(Me.btnpersonas)
        Me.Name = "menua"
        Me.Text = "menua"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnpersonas As Button
    Friend WithEvents btndepartamentos As Button
    Friend WithEvents btnmovimientos As Button
    Friend WithEvents btnproyectos As Button
    Friend WithEvents btncerrarsecion As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
