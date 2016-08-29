<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Eliminar_Departamento
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Eliminar_Departamento))
        Me.txtcod = New System.Windows.Forms.TextBox()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.ced = New System.Windows.Forms.Label()
        Me.btnvolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtcod
        '
        Me.txtcod.Location = New System.Drawing.Point(277, 125)
        Me.txtcod.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtcod.Name = "txtcod"
        Me.txtcod.Size = New System.Drawing.Size(164, 25)
        Me.txtcod.TabIndex = 15
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(44, 176)
        Me.btneliminar.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(125, 30)
        Me.btneliminar.TabIndex = 12
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'ced
        '
        Me.ced.AutoSize = True
        Me.ced.BackColor = System.Drawing.Color.Transparent
        Me.ced.ForeColor = System.Drawing.Color.White
        Me.ced.Location = New System.Drawing.Point(14, 128)
        Me.ced.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ced.Name = "ced"
        Me.ced.Size = New System.Drawing.Size(253, 17)
        Me.ced.TabIndex = 14
        Me.ced.Text = "Ingrese código de departamento"
        '
        'btnvolver
        '
        Me.btnvolver.Location = New System.Drawing.Point(277, 176)
        Me.btnvolver.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnvolver.Name = "btnvolver"
        Me.btnvolver.Size = New System.Drawing.Size(125, 30)
        Me.btnvolver.TabIndex = 13
        Me.btnvolver.Text = "Volver"
        Me.btnvolver.UseVisualStyleBackColor = True
        '
        'Eliminar_Departamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(477, 350)
        Me.Controls.Add(Me.txtcod)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.ced)
        Me.Controls.Add(Me.btnvolver)
        Me.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Eliminar_Departamento"
        Me.Text = "Eliminar_Departamento"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtcod As TextBox
    Friend WithEvents btneliminar As Button
    Friend WithEvents ced As Label
    Friend WithEvents btnvolver As Button
End Class
