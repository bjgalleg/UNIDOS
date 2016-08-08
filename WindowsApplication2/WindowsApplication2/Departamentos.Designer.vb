<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class departamentos
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
        Me.btnnvodpto = New System.Windows.Forms.Button()
        Me.btnmoddpto = New System.Windows.Forms.Button()
        Me.btneliminardpto = New System.Windows.Forms.Button()
        Me.btnvolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnnvodpto
        '
        Me.btnnvodpto.Location = New System.Drawing.Point(96, 44)
        Me.btnnvodpto.Name = "btnnvodpto"
        Me.btnnvodpto.Size = New System.Drawing.Size(134, 23)
        Me.btnnvodpto.TabIndex = 0
        Me.btnnvodpto.Text = "Nuevo departamento"
        Me.btnnvodpto.UseVisualStyleBackColor = True
        '
        'btnmoddpto
        '
        Me.btnmoddpto.Location = New System.Drawing.Point(96, 90)
        Me.btnmoddpto.Name = "btnmoddpto"
        Me.btnmoddpto.Size = New System.Drawing.Size(134, 23)
        Me.btnmoddpto.TabIndex = 1
        Me.btnmoddpto.Text = "Modificar departamento"
        Me.btnmoddpto.UseVisualStyleBackColor = True
        '
        'btneliminardpto
        '
        Me.btneliminardpto.Location = New System.Drawing.Point(107, 134)
        Me.btneliminardpto.Name = "btneliminardpto"
        Me.btneliminardpto.Size = New System.Drawing.Size(112, 23)
        Me.btneliminardpto.TabIndex = 2
        Me.btneliminardpto.Text = "Eliminar departamento"
        Me.btneliminardpto.UseVisualStyleBackColor = True
        '
        'btnvolver
        '
        Me.btnvolver.Location = New System.Drawing.Point(126, 176)
        Me.btnvolver.Name = "btnvolver"
        Me.btnvolver.Size = New System.Drawing.Size(75, 23)
        Me.btnvolver.TabIndex = 3
        Me.btnvolver.Text = "Volver"
        Me.btnvolver.UseVisualStyleBackColor = True
        '
        'departamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 261)
        Me.Controls.Add(Me.btnvolver)
        Me.Controls.Add(Me.btneliminardpto)
        Me.Controls.Add(Me.btnmoddpto)
        Me.Controls.Add(Me.btnnvodpto)
        Me.Name = "departamentos"
        Me.Text = "Departamentos"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnnvodpto As Button
    Friend WithEvents btnmoddpto As Button
    Friend WithEvents btneliminardpto As Button
    Friend WithEvents btnvolver As Button
End Class
