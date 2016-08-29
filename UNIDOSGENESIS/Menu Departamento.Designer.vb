<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Departamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu_Departamento))
        Me.btnvolver = New System.Windows.Forms.Button()
        Me.btneliminardpto = New System.Windows.Forms.Button()
        Me.btnmdpto = New System.Windows.Forms.Button()
        Me.btnnvodpto = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnvolver
        '
        Me.btnvolver.AutoSize = True
        Me.btnvolver.BackColor = System.Drawing.Color.Transparent
        Me.btnvolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnvolver.FlatAppearance.BorderSize = 0
        Me.btnvolver.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnvolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnvolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnvolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnvolver.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnvolver.ForeColor = System.Drawing.Color.White
        Me.btnvolver.Location = New System.Drawing.Point(43, 302)
        Me.btnvolver.Name = "btnvolver"
        Me.btnvolver.Size = New System.Drawing.Size(164, 29)
        Me.btnvolver.TabIndex = 7
        Me.btnvolver.Text = "Volver"
        Me.btnvolver.UseVisualStyleBackColor = False
        '
        'btneliminardpto
        '
        Me.btneliminardpto.AutoSize = True
        Me.btneliminardpto.BackColor = System.Drawing.Color.Transparent
        Me.btneliminardpto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btneliminardpto.FlatAppearance.BorderSize = 0
        Me.btneliminardpto.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btneliminardpto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btneliminardpto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btneliminardpto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btneliminardpto.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminardpto.ForeColor = System.Drawing.Color.White
        Me.btneliminardpto.Location = New System.Drawing.Point(34, 255)
        Me.btneliminardpto.Name = "btneliminardpto"
        Me.btneliminardpto.Size = New System.Drawing.Size(210, 29)
        Me.btneliminardpto.TabIndex = 6
        Me.btneliminardpto.Text = "Eliminar departamento"
        Me.btneliminardpto.UseVisualStyleBackColor = False
        '
        'btnmdpto
        '
        Me.btnmdpto.AutoSize = True
        Me.btnmdpto.BackColor = System.Drawing.Color.Transparent
        Me.btnmdpto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnmdpto.FlatAppearance.BorderSize = 0
        Me.btnmdpto.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnmdpto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnmdpto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnmdpto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnmdpto.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmdpto.ForeColor = System.Drawing.Color.White
        Me.btnmdpto.Location = New System.Drawing.Point(34, 208)
        Me.btnmdpto.Name = "btnmdpto"
        Me.btnmdpto.Size = New System.Drawing.Size(264, 29)
        Me.btnmdpto.TabIndex = 5
        Me.btnmdpto.Text = "Modificar datos departamento"
        Me.btnmdpto.UseVisualStyleBackColor = False
        '
        'btnnvodpto
        '
        Me.btnnvodpto.AutoSize = True
        Me.btnnvodpto.BackColor = System.Drawing.Color.Transparent
        Me.btnnvodpto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnnvodpto.FlatAppearance.BorderSize = 0
        Me.btnnvodpto.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnnvodpto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnnvodpto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnnvodpto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnnvodpto.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnvodpto.ForeColor = System.Drawing.Color.White
        Me.btnnvodpto.Location = New System.Drawing.Point(34, 163)
        Me.btnnvodpto.Name = "btnnvodpto"
        Me.btnnvodpto.Size = New System.Drawing.Size(189, 29)
        Me.btnnvodpto.TabIndex = 4
        Me.btnnvodpto.Text = "Nuevo departamento"
        Me.btnnvodpto.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(121, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 19)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "MENÚ DEPARTAMENTOS"
        '
        'Menu_Departamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(473, 360)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnvolver)
        Me.Controls.Add(Me.btneliminardpto)
        Me.Controls.Add(Me.btnmdpto)
        Me.Controls.Add(Me.btnnvodpto)
        Me.Name = "Menu_Departamento"
        Me.Text = "Menu_Departamento"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnvolver As Button
    Friend WithEvents btneliminardpto As Button
    Friend WithEvents btnmdpto As Button
    Friend WithEvents btnnvodpto As Button
    Friend WithEvents Label1 As Label
End Class
