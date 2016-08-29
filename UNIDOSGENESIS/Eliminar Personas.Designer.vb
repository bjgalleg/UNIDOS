<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Eliminar_Personas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Eliminar_Personas))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnvolver = New System.Windows.Forms.Button()
        Me.ced = New System.Windows.Forms.Label()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.txtced = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 221)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 2
        '
        'btnvolver
        '
        Me.btnvolver.BackColor = System.Drawing.Color.DarkRed
        Me.btnvolver.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnvolver.ForeColor = System.Drawing.Color.White
        Me.btnvolver.Location = New System.Drawing.Point(194, 235)
        Me.btnvolver.Name = "btnvolver"
        Me.btnvolver.Size = New System.Drawing.Size(75, 23)
        Me.btnvolver.TabIndex = 5
        Me.btnvolver.Text = "Volver"
        Me.btnvolver.UseVisualStyleBackColor = False
        '
        'ced
        '
        Me.ced.AutoSize = True
        Me.ced.BackColor = System.Drawing.Color.Transparent
        Me.ced.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ced.ForeColor = System.Drawing.Color.White
        Me.ced.Location = New System.Drawing.Point(102, 153)
        Me.ced.Name = "ced"
        Me.ced.Size = New System.Drawing.Size(151, 17)
        Me.ced.TabIndex = 6
        Me.ced.Text = "Ingrese No. Cédula"
        '
        'btneliminar
        '
        Me.btneliminar.BackColor = System.Drawing.Color.DarkRed
        Me.btneliminar.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminar.ForeColor = System.Drawing.Color.White
        Me.btneliminar.Location = New System.Drawing.Point(77, 235)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(75, 23)
        Me.btneliminar.TabIndex = 4
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = False
        '
        'txtced
        '
        Me.txtced.Location = New System.Drawing.Point(92, 186)
        Me.txtced.Name = "txtced"
        Me.txtced.Size = New System.Drawing.Size(161, 20)
        Me.txtced.TabIndex = 7
        '
        'Eliminar_Personas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(466, 347)
        Me.Controls.Add(Me.txtced)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ced)
        Me.Controls.Add(Me.btnvolver)
        Me.Name = "Eliminar_Personas"
        Me.Text = "Eliminar_Personas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnvolver As Button
    Friend WithEvents ced As Label
    Friend WithEvents btneliminar As Button
    Friend WithEvents txtced As TextBox
End Class
