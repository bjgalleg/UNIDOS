<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class nuevodepartamento
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
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btnvolver = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cmbmiembros = New System.Windows.Forms.ComboBox()
        Me.btnañadir = New System.Windows.Forms.Button()
        Me.txtnombredpto = New System.Windows.Forms.TextBox()
        Me.txtfunciones = New System.Windows.Forms.TextBox()
        Me.cmbresponsable = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(126, 294)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(75, 23)
        Me.btnguardar.TabIndex = 0
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'btnvolver
        '
        Me.btnvolver.Location = New System.Drawing.Point(254, 294)
        Me.btnvolver.Name = "btnvolver"
        Me.btnvolver.Size = New System.Drawing.Size(75, 23)
        Me.btnvolver.TabIndex = 1
        Me.btnvolver.Text = "Volver"
        Me.btnvolver.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre del departamento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Descripcion de funciones"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Responsable"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Miembros"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(40, 174)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(386, 88)
        Me.DataGridView1.TabIndex = 6
        '
        'cmbmiembros
        '
        Me.cmbmiembros.FormattingEnabled = True
        Me.cmbmiembros.Location = New System.Drawing.Point(105, 128)
        Me.cmbmiembros.Name = "cmbmiembros"
        Me.cmbmiembros.Size = New System.Drawing.Size(224, 21)
        Me.cmbmiembros.TabIndex = 7
        '
        'btnañadir
        '
        Me.btnañadir.Location = New System.Drawing.Point(351, 126)
        Me.btnañadir.Name = "btnañadir"
        Me.btnañadir.Size = New System.Drawing.Size(75, 23)
        Me.btnañadir.TabIndex = 8
        Me.btnañadir.Text = "Añadir"
        Me.btnañadir.UseVisualStyleBackColor = True
        '
        'txtnombredpto
        '
        Me.txtnombredpto.Location = New System.Drawing.Point(172, 31)
        Me.txtnombredpto.Name = "txtnombredpto"
        Me.txtnombredpto.Size = New System.Drawing.Size(224, 20)
        Me.txtnombredpto.TabIndex = 9
        '
        'txtfunciones
        '
        Me.txtfunciones.Location = New System.Drawing.Point(172, 59)
        Me.txtfunciones.Name = "txtfunciones"
        Me.txtfunciones.Size = New System.Drawing.Size(224, 20)
        Me.txtfunciones.TabIndex = 10
        '
        'cmbresponsable
        '
        Me.cmbresponsable.FormattingEnabled = True
        Me.cmbresponsable.Location = New System.Drawing.Point(105, 92)
        Me.cmbresponsable.Name = "cmbresponsable"
        Me.cmbresponsable.Size = New System.Drawing.Size(224, 21)
        Me.cmbresponsable.TabIndex = 11
        '
        'nuevodepartamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 431)
        Me.Controls.Add(Me.cmbresponsable)
        Me.Controls.Add(Me.txtfunciones)
        Me.Controls.Add(Me.txtnombredpto)
        Me.Controls.Add(Me.btnañadir)
        Me.Controls.Add(Me.cmbmiembros)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnvolver)
        Me.Controls.Add(Me.btnguardar)
        Me.Name = "nuevodepartamento"
        Me.Text = "Departamentos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnguardar As Button
    Friend WithEvents btnvolver As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cmbmiembros As ComboBox
    Friend WithEvents btnañadir As Button
    Friend WithEvents txtnombredpto As TextBox
    Friend WithEvents txtfunciones As TextBox
    Friend WithEvents cmbresponsable As ComboBox
End Class
