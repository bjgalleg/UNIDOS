<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modificarproyecto
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
        Me.txtmproyectoid = New System.Windows.Forms.TextBox()
        Me.txtmcomunidad = New System.Windows.Forms.TextBox()
        Me.cmbmdpto = New System.Windows.Forms.ComboBox()
        Me.cmbmtipo = New System.Windows.Forms.ComboBox()
        Me.mffinal = New System.Windows.Forms.DateTimePicker()
        Me.mfinicio = New System.Windows.Forms.DateTimePicker()
        Me.btnmvolver = New System.Windows.Forms.Button()
        Me.btnmguardar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtmproyectoid
        '
        Me.txtmproyectoid.Location = New System.Drawing.Point(172, 76)
        Me.txtmproyectoid.Name = "txtmproyectoid"
        Me.txtmproyectoid.Size = New System.Drawing.Size(200, 20)
        Me.txtmproyectoid.TabIndex = 27
        '
        'txtmcomunidad
        '
        Me.txtmcomunidad.Location = New System.Drawing.Point(172, 108)
        Me.txtmcomunidad.Name = "txtmcomunidad"
        Me.txtmcomunidad.Size = New System.Drawing.Size(200, 20)
        Me.txtmcomunidad.TabIndex = 26
        '
        'cmbmdpto
        '
        Me.cmbmdpto.FormattingEnabled = True
        Me.cmbmdpto.Items.AddRange(New Object() {"SPOUDE", "DAR", "Coordinación General y TTHH", "Finanzas", "Marketing y TICS", "Artes Escénicas"})
        Me.cmbmdpto.Location = New System.Drawing.Point(172, 143)
        Me.cmbmdpto.Name = "cmbmdpto"
        Me.cmbmdpto.Size = New System.Drawing.Size(200, 21)
        Me.cmbmdpto.TabIndex = 25
        '
        'cmbmtipo
        '
        Me.cmbmtipo.FormattingEnabled = True
        Me.cmbmtipo.Location = New System.Drawing.Point(172, 173)
        Me.cmbmtipo.Name = "cmbmtipo"
        Me.cmbmtipo.Size = New System.Drawing.Size(200, 21)
        Me.cmbmtipo.TabIndex = 24
        '
        'mffinal
        '
        Me.mffinal.Location = New System.Drawing.Point(172, 248)
        Me.mffinal.Name = "mffinal"
        Me.mffinal.Size = New System.Drawing.Size(200, 20)
        Me.mffinal.TabIndex = 23
        '
        'mfinicio
        '
        Me.mfinicio.Location = New System.Drawing.Point(172, 211)
        Me.mfinicio.Name = "mfinicio"
        Me.mfinicio.Size = New System.Drawing.Size(200, 20)
        Me.mfinicio.TabIndex = 22
        '
        'btnmvolver
        '
        Me.btnmvolver.Location = New System.Drawing.Point(258, 306)
        Me.btnmvolver.Name = "btnmvolver"
        Me.btnmvolver.Size = New System.Drawing.Size(75, 23)
        Me.btnmvolver.TabIndex = 21
        Me.btnmvolver.Text = "Volver"
        Me.btnmvolver.UseVisualStyleBackColor = True
        '
        'btnmguardar
        '
        Me.btnmguardar.Location = New System.Drawing.Point(120, 306)
        Me.btnmguardar.Name = "btnmguardar"
        Me.btnmguardar.Size = New System.Drawing.Size(75, 23)
        Me.btnmguardar.TabIndex = 20
        Me.btnmguardar.Text = "Guardar"
        Me.btnmguardar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(65, 248)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Fecha final"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(65, 211)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Fecha inicio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(65, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Tipo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(65, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Departamento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(65, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Comunidad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Nombre de Proyecto"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(56, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(141, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Ingrese nombre del proyecto"
        '
        'btnbuscar
        '
        Me.btnbuscar.Location = New System.Drawing.Point(318, 24)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnbuscar.TabIndex = 29
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(203, 26)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(100, 20)
        Me.txtbuscar.TabIndex = 30
        '
        'modificarproyecto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 381)
        Me.Controls.Add(Me.txtbuscar)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtmproyectoid)
        Me.Controls.Add(Me.txtmcomunidad)
        Me.Controls.Add(Me.cmbmdpto)
        Me.Controls.Add(Me.cmbmtipo)
        Me.Controls.Add(Me.mffinal)
        Me.Controls.Add(Me.mfinicio)
        Me.Controls.Add(Me.btnmvolver)
        Me.Controls.Add(Me.btnmguardar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "modificarproyecto"
        Me.Text = "Modificar proyecto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtmproyectoid As TextBox
    Friend WithEvents txtmcomunidad As TextBox
    Friend WithEvents cmbmdpto As ComboBox
    Friend WithEvents cmbmtipo As ComboBox
    Friend WithEvents mffinal As DateTimePicker
    Friend WithEvents mfinicio As DateTimePicker
    Friend WithEvents btnmvolver As Button
    Friend WithEvents btnmguardar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnbuscar As Button
    Friend WithEvents txtbuscar As TextBox
End Class
