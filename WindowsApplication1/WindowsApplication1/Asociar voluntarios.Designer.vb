<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbproyecto = New System.Windows.Forms.ComboBox()
        Me.cmbvoluntario = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.btnquitar = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seleccione proyecto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(66, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Seleccione voluntario"
        '
        'cmbproyecto
        '
        Me.cmbproyecto.FormattingEnabled = True
        Me.cmbproyecto.Location = New System.Drawing.Point(198, 27)
        Me.cmbproyecto.Name = "cmbproyecto"
        Me.cmbproyecto.Size = New System.Drawing.Size(262, 21)
        Me.cmbproyecto.TabIndex = 2
        '
        'cmbvoluntario
        '
        Me.cmbvoluntario.FormattingEnabled = True
        Me.cmbvoluntario.Location = New System.Drawing.Point(198, 71)
        Me.cmbvoluntario.Name = "cmbvoluntario"
        Me.cmbvoluntario.Size = New System.Drawing.Size(262, 21)
        Me.cmbvoluntario.TabIndex = 3
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(69, 131)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(572, 150)
        Me.DataGridView1.TabIndex = 4
        '
        'btnagregar
        '
        Me.btnagregar.Location = New System.Drawing.Point(507, 27)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(75, 23)
        Me.btnagregar.TabIndex = 5
        Me.btnagregar.Text = "Añadir"
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'btnquitar
        '
        Me.btnquitar.Location = New System.Drawing.Point(507, 70)
        Me.btnquitar.Name = "btnquitar"
        Me.btnquitar.Size = New System.Drawing.Size(75, 23)
        Me.btnquitar.TabIndex = 6
        Me.btnquitar.Text = "Quitar"
        Me.btnquitar.UseVisualStyleBackColor = True
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 373)
        Me.Controls.Add(Me.btnquitar)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cmbvoluntario)
        Me.Controls.Add(Me.cmbproyecto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form6"
        Me.Text = "Asociar voluntarios"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbproyecto As ComboBox
    Friend WithEvents cmbvoluntario As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnagregar As Button
    Friend WithEvents btnquitar As Button
End Class
