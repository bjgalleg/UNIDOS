<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Departamentos
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
        Me.btnmdpto = New System.Windows.Forms.Button()
        Me.btneliminardpto = New System.Windows.Forms.Button()
        Me.btnvolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnnvodpto
        '
        Me.btnnvodpto.Location = New System.Drawing.Point(68, 58)
        Me.btnnvodpto.Name = "btnnvodpto"
        Me.btnnvodpto.Size = New System.Drawing.Size(164, 23)
        Me.btnnvodpto.TabIndex = 0
        Me.btnnvodpto.Text = "Nuevo departamento"
        Me.btnnvodpto.UseVisualStyleBackColor = True
        '
        'btnmdpto
        '
        Me.btnmdpto.Location = New System.Drawing.Point(68, 101)
        Me.btnmdpto.Name = "btnmdpto"
        Me.btnmdpto.Size = New System.Drawing.Size(164, 23)
        Me.btnmdpto.TabIndex = 1
        Me.btnmdpto.Text = "Modificar datos departamento"
        Me.btnmdpto.UseVisualStyleBackColor = True
        '
        'btneliminardpto
        '
        Me.btneliminardpto.Location = New System.Drawing.Point(68, 148)
        Me.btneliminardpto.Name = "btneliminardpto"
        Me.btneliminardpto.Size = New System.Drawing.Size(164, 23)
        Me.btneliminardpto.TabIndex = 2
        Me.btneliminardpto.Text = "Eliminar departamento"
        Me.btneliminardpto.UseVisualStyleBackColor = True
        '
        'btnvolver
        '
        Me.btnvolver.Location = New System.Drawing.Point(68, 194)
        Me.btnvolver.Name = "btnvolver"
        Me.btnvolver.Size = New System.Drawing.Size(164, 23)
        Me.btnvolver.TabIndex = 3
        Me.btnvolver.Text = "Volver"
        Me.btnvolver.UseVisualStyleBackColor = True
        '
        'Departamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnvolver)
        Me.Controls.Add(Me.btneliminardpto)
        Me.Controls.Add(Me.btnmdpto)
        Me.Controls.Add(Me.btnnvodpto)
        Me.Name = "Departamentos"
        Me.Text = "Departamentos"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnnvodpto As Button
    Friend WithEvents btnmdpto As Button
    Friend WithEvents btneliminardpto As Button
    Friend WithEvents btnvolver As Button
End Class
