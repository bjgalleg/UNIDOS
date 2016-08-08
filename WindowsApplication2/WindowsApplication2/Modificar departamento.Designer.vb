<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modificardepartamento
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
        Me.cmbmresponsable = New System.Windows.Forms.ComboBox()
        Me.txtmfunciones = New System.Windows.Forms.TextBox()
        Me.txtmnombredpto = New System.Windows.Forms.TextBox()
        Me.btnañadir = New System.Windows.Forms.Button()
        Me.cmbmmiembros = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnmvolver = New System.Windows.Forms.Button()
        Me.btnmguardar = New System.Windows.Forms.Button()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbmresponsable
        '
        Me.cmbmresponsable.FormattingEnabled = True
        Me.cmbmresponsable.Location = New System.Drawing.Point(106, 140)
        Me.cmbmresponsable.Name = "cmbmresponsable"
        Me.cmbmresponsable.Size = New System.Drawing.Size(224, 21)
        Me.cmbmresponsable.TabIndex = 23
        '
        'txtmfunciones
        '
        Me.txtmfunciones.Location = New System.Drawing.Point(173, 107)
        Me.txtmfunciones.Name = "txtmfunciones"
        Me.txtmfunciones.Size = New System.Drawing.Size(224, 20)
        Me.txtmfunciones.TabIndex = 22
        '
        'txtmnombredpto
        '
        Me.txtmnombredpto.Location = New System.Drawing.Point(173, 79)
        Me.txtmnombredpto.Name = "txtmnombredpto"
        Me.txtmnombredpto.Size = New System.Drawing.Size(224, 20)
        Me.txtmnombredpto.TabIndex = 21
        '
        'btnañadir
        '
        Me.btnañadir.Location = New System.Drawing.Point(352, 174)
        Me.btnañadir.Name = "btnañadir"
        Me.btnañadir.Size = New System.Drawing.Size(75, 23)
        Me.btnañadir.TabIndex = 20
        Me.btnañadir.Text = "Añadir"
        Me.btnañadir.UseVisualStyleBackColor = True
        '
        'cmbmmiembros
        '
        Me.cmbmmiembros.FormattingEnabled = True
        Me.cmbmmiembros.Location = New System.Drawing.Point(106, 176)
        Me.cmbmmiembros.Name = "cmbmmiembros"
        Me.cmbmmiembros.Size = New System.Drawing.Size(224, 21)
        Me.cmbmmiembros.TabIndex = 19
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(41, 222)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(386, 88)
        Me.DataGridView1.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Miembros"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Responsable"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Descripcion de funciones"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Nombre del departamento"
        '
        'btnmvolver
        '
        Me.btnmvolver.Location = New System.Drawing.Point(255, 342)
        Me.btnmvolver.Name = "btnmvolver"
        Me.btnmvolver.Size = New System.Drawing.Size(75, 23)
        Me.btnmvolver.TabIndex = 13
        Me.btnmvolver.Text = "Volver"
        Me.btnmvolver.UseVisualStyleBackColor = True
        '
        'btnmguardar
        '
        Me.btnmguardar.Location = New System.Drawing.Point(127, 342)
        Me.btnmguardar.Name = "btnmguardar"
        Me.btnmguardar.Size = New System.Drawing.Size(75, 23)
        Me.btnmguardar.TabIndex = 12
        Me.btnmguardar.Text = "Guardar"
        Me.btnmguardar.UseVisualStyleBackColor = True
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(208, 40)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(131, 20)
        Me.txtbuscar.TabIndex = 33
        '
        'btnbuscar
        '
        Me.btnbuscar.Location = New System.Drawing.Point(345, 38)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnbuscar.TabIndex = 32
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(37, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(165, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Ingrese nombre del departamento"
        '
        'modificardepartamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 444)
        Me.Controls.Add(Me.txtbuscar)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbmresponsable)
        Me.Controls.Add(Me.txtmfunciones)
        Me.Controls.Add(Me.txtmnombredpto)
        Me.Controls.Add(Me.btnañadir)
        Me.Controls.Add(Me.cmbmmiembros)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnmvolver)
        Me.Controls.Add(Me.btnmguardar)
        Me.Name = "modificardepartamento"
        Me.Text = "Modificar departamento"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbmresponsable As ComboBox
    Friend WithEvents txtmfunciones As TextBox
    Friend WithEvents txtmnombredpto As TextBox
    Friend WithEvents btnañadir As Button
    Friend WithEvents cmbmmiembros As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnmvolver As Button
    Friend WithEvents btnmguardar As Button
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents btnbuscar As Button
    Friend WithEvents Label7 As Label
End Class
