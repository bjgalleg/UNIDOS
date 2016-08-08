<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modificarpersona
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
        Me.clbmdpto = New System.Windows.Forms.CheckedListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ced = New System.Windows.Forms.Label()
        Me.txtmcedula = New System.Windows.Forms.TextBox()
        Me.txtmestado = New System.Windows.Forms.ComboBox()
        Me.txtmcarrera = New System.Windows.Forms.TextBox()
        Me.txtmuniversidad = New System.Windows.Forms.TextBox()
        Me.cmbmtipo = New System.Windows.Forms.ComboBox()
        Me.mfecha = New System.Windows.Forms.DateTimePicker()
        Me.txtmemail = New System.Windows.Forms.TextBox()
        Me.txtmtelefono = New System.Windows.Forms.TextBox()
        Me.txtmapellidos = New System.Windows.Forms.TextBox()
        Me.txtmnombre = New System.Windows.Forms.TextBox()
        Me.est1 = New System.Windows.Forms.Label()
        Me.car1 = New System.Windows.Forms.Label()
        Me.uni1 = New System.Windows.Forms.Label()
        Me.dpto1 = New System.Windows.Forms.Label()
        Me.fec1 = New System.Windows.Forms.Label()
        Me.mail1 = New System.Windows.Forms.Label()
        Me.tel1 = New System.Windows.Forms.Label()
        Me.ti1 = New System.Windows.Forms.Label()
        Me.ap1 = New System.Windows.Forms.Label()
        Me.nom1 = New System.Windows.Forms.Label()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btnvolver = New System.Windows.Forms.Button()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'clbmdpto
        '
        Me.clbmdpto.FormattingEnabled = True
        Me.clbmdpto.Items.AddRange(New Object() {"Spoude", "DAR", "Artes", "Coord. General y TTHH", "Finanzas"})
        Me.clbmdpto.Location = New System.Drawing.Point(485, 271)
        Me.clbmdpto.Name = "clbmdpto"
        Me.clbmdpto.Size = New System.Drawing.Size(153, 94)
        Me.clbmdpto.TabIndex = 132
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(73, 227)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 13)
        Me.Label2.TabIndex = 131
        Me.Label2.Text = "INFORMACIÓN ADICIONAL"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(76, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 13)
        Me.Label1.TabIndex = 130
        Me.Label1.Text = "DATOS PERSONALES"
        '
        'ced
        '
        Me.ced.AutoSize = True
        Me.ced.Location = New System.Drawing.Point(76, 124)
        Me.ced.Name = "ced"
        Me.ced.Size = New System.Drawing.Size(40, 13)
        Me.ced.TabIndex = 129
        Me.ced.Text = "Cédula"
        '
        'txtmcedula
        '
        Me.txtmcedula.Location = New System.Drawing.Point(180, 124)
        Me.txtmcedula.Name = "txtmcedula"
        Me.txtmcedula.Size = New System.Drawing.Size(200, 20)
        Me.txtmcedula.TabIndex = 128
        '
        'txtmestado
        '
        Me.txtmestado.FormattingEnabled = True
        Me.txtmestado.Items.AddRange(New Object() {"Estudiante", "Egresado", "Graduado", "Estudios no concluidos"})
        Me.txtmestado.Location = New System.Drawing.Point(183, 323)
        Me.txtmestado.Name = "txtmestado"
        Me.txtmestado.Size = New System.Drawing.Size(197, 21)
        Me.txtmestado.TabIndex = 127
        '
        'txtmcarrera
        '
        Me.txtmcarrera.Location = New System.Drawing.Point(183, 300)
        Me.txtmcarrera.Name = "txtmcarrera"
        Me.txtmcarrera.Size = New System.Drawing.Size(197, 20)
        Me.txtmcarrera.TabIndex = 126
        '
        'txtmuniversidad
        '
        Me.txtmuniversidad.Location = New System.Drawing.Point(183, 274)
        Me.txtmuniversidad.Name = "txtmuniversidad"
        Me.txtmuniversidad.Size = New System.Drawing.Size(197, 20)
        Me.txtmuniversidad.TabIndex = 125
        '
        'cmbmtipo
        '
        Me.cmbmtipo.FormattingEnabled = True
        Me.cmbmtipo.Items.AddRange(New Object() {"Voluntario", "Donante", "Cliente"})
        Me.cmbmtipo.Location = New System.Drawing.Point(183, 349)
        Me.cmbmtipo.Name = "cmbmtipo"
        Me.cmbmtipo.Size = New System.Drawing.Size(197, 21)
        Me.cmbmtipo.TabIndex = 124
        '
        'mfecha
        '
        Me.mfecha.Location = New System.Drawing.Point(508, 171)
        Me.mfecha.Name = "mfecha"
        Me.mfecha.Size = New System.Drawing.Size(200, 20)
        Me.mfecha.TabIndex = 123
        '
        'txtmemail
        '
        Me.txtmemail.Location = New System.Drawing.Point(508, 145)
        Me.txtmemail.Name = "txtmemail"
        Me.txtmemail.Size = New System.Drawing.Size(200, 20)
        Me.txtmemail.TabIndex = 122
        '
        'txtmtelefono
        '
        Me.txtmtelefono.Location = New System.Drawing.Point(508, 121)
        Me.txtmtelefono.Name = "txtmtelefono"
        Me.txtmtelefono.Size = New System.Drawing.Size(200, 20)
        Me.txtmtelefono.TabIndex = 121
        '
        'txtmapellidos
        '
        Me.txtmapellidos.Location = New System.Drawing.Point(180, 176)
        Me.txtmapellidos.Name = "txtmapellidos"
        Me.txtmapellidos.Size = New System.Drawing.Size(200, 20)
        Me.txtmapellidos.TabIndex = 120
        '
        'txtmnombre
        '
        Me.txtmnombre.Location = New System.Drawing.Point(180, 150)
        Me.txtmnombre.Name = "txtmnombre"
        Me.txtmnombre.Size = New System.Drawing.Size(200, 20)
        Me.txtmnombre.TabIndex = 119
        '
        'est1
        '
        Me.est1.AutoSize = True
        Me.est1.Location = New System.Drawing.Point(77, 326)
        Me.est1.Name = "est1"
        Me.est1.Size = New System.Drawing.Size(40, 13)
        Me.est1.TabIndex = 118
        Me.est1.Text = "Estado"
        '
        'car1
        '
        Me.car1.AutoSize = True
        Me.car1.Location = New System.Drawing.Point(76, 300)
        Me.car1.Name = "car1"
        Me.car1.Size = New System.Drawing.Size(41, 13)
        Me.car1.TabIndex = 117
        Me.car1.Text = "Carrera"
        '
        'uni1
        '
        Me.uni1.AutoSize = True
        Me.uni1.Location = New System.Drawing.Point(73, 277)
        Me.uni1.Name = "uni1"
        Me.uni1.Size = New System.Drawing.Size(63, 13)
        Me.uni1.TabIndex = 116
        Me.uni1.Text = "Universidad"
        '
        'dpto1
        '
        Me.dpto1.AutoSize = True
        Me.dpto1.Location = New System.Drawing.Point(405, 270)
        Me.dpto1.Name = "dpto1"
        Me.dpto1.Size = New System.Drawing.Size(74, 13)
        Me.dpto1.TabIndex = 115
        Me.dpto1.Text = "Departamento"
        '
        'fec1
        '
        Me.fec1.AutoSize = True
        Me.fec1.Location = New System.Drawing.Point(401, 177)
        Me.fec1.Name = "fec1"
        Me.fec1.Size = New System.Drawing.Size(106, 13)
        Me.fec1.TabIndex = 114
        Me.fec1.Text = "Fecha de nacimiento"
        '
        'mail1
        '
        Me.mail1.AutoSize = True
        Me.mail1.Location = New System.Drawing.Point(401, 148)
        Me.mail1.Name = "mail1"
        Me.mail1.Size = New System.Drawing.Size(35, 13)
        Me.mail1.TabIndex = 113
        Me.mail1.Text = "E-mail"
        '
        'tel1
        '
        Me.tel1.AutoSize = True
        Me.tel1.Location = New System.Drawing.Point(401, 124)
        Me.tel1.Name = "tel1"
        Me.tel1.Size = New System.Drawing.Size(49, 13)
        Me.tel1.TabIndex = 112
        Me.tel1.Text = "Teléfono"
        '
        'ti1
        '
        Me.ti1.AutoSize = True
        Me.ti1.Location = New System.Drawing.Point(76, 352)
        Me.ti1.Name = "ti1"
        Me.ti1.Size = New System.Drawing.Size(28, 13)
        Me.ti1.TabIndex = 111
        Me.ti1.Text = "Tipo"
        '
        'ap1
        '
        Me.ap1.AutoSize = True
        Me.ap1.Location = New System.Drawing.Point(73, 176)
        Me.ap1.Name = "ap1"
        Me.ap1.Size = New System.Drawing.Size(49, 13)
        Me.ap1.TabIndex = 110
        Me.ap1.Text = "Apellidos"
        '
        'nom1
        '
        Me.nom1.AutoSize = True
        Me.nom1.Location = New System.Drawing.Point(73, 150)
        Me.nom1.Name = "nom1"
        Me.nom1.Size = New System.Drawing.Size(49, 13)
        Me.nom1.TabIndex = 109
        Me.nom1.Text = "Nombres"
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(344, 395)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(75, 23)
        Me.btnguardar.TabIndex = 108
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'btnvolver
        '
        Me.btnvolver.Location = New System.Drawing.Point(449, 395)
        Me.btnvolver.Name = "btnvolver"
        Me.btnvolver.Size = New System.Drawing.Size(75, 23)
        Me.btnvolver.TabIndex = 107
        Me.btnvolver.Text = "Volver"
        Me.btnvolver.UseVisualStyleBackColor = True
        '
        'btnbuscar
        '
        Me.btnbuscar.Location = New System.Drawing.Point(404, 20)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnbuscar.TabIndex = 133
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(76, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 13)
        Me.Label3.TabIndex = 134
        Me.Label3.Text = "Ingrese número de cédula"
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(212, 23)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(100, 20)
        Me.txtbuscar.TabIndex = 135
        '
        'modificarpersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 503)
        Me.Controls.Add(Me.txtbuscar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.clbmdpto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ced)
        Me.Controls.Add(Me.txtmcedula)
        Me.Controls.Add(Me.txtmestado)
        Me.Controls.Add(Me.txtmcarrera)
        Me.Controls.Add(Me.txtmuniversidad)
        Me.Controls.Add(Me.cmbmtipo)
        Me.Controls.Add(Me.mfecha)
        Me.Controls.Add(Me.txtmemail)
        Me.Controls.Add(Me.txtmtelefono)
        Me.Controls.Add(Me.txtmapellidos)
        Me.Controls.Add(Me.txtmnombre)
        Me.Controls.Add(Me.est1)
        Me.Controls.Add(Me.car1)
        Me.Controls.Add(Me.uni1)
        Me.Controls.Add(Me.dpto1)
        Me.Controls.Add(Me.fec1)
        Me.Controls.Add(Me.mail1)
        Me.Controls.Add(Me.tel1)
        Me.Controls.Add(Me.ti1)
        Me.Controls.Add(Me.ap1)
        Me.Controls.Add(Me.nom1)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btnvolver)
        Me.Name = "modificarpersona"
        Me.Text = "Modificar datos de persona"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents clbmdpto As CheckedListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ced As Label
    Friend WithEvents txtmcedula As TextBox
    Friend WithEvents txtmestado As ComboBox
    Friend WithEvents txtmcarrera As TextBox
    Friend WithEvents txtmuniversidad As TextBox
    Friend WithEvents cmbmtipo As ComboBox
    Friend WithEvents mfecha As DateTimePicker
    Friend WithEvents txtmemail As TextBox
    Friend WithEvents txtmtelefono As TextBox
    Friend WithEvents txtmapellidos As TextBox
    Friend WithEvents txtmnombre As TextBox
    Friend WithEvents est1 As Label
    Friend WithEvents car1 As Label
    Friend WithEvents uni1 As Label
    Friend WithEvents dpto1 As Label
    Friend WithEvents fec1 As Label
    Friend WithEvents mail1 As Label
    Friend WithEvents tel1 As Label
    Friend WithEvents ti1 As Label
    Friend WithEvents ap1 As Label
    Friend WithEvents nom1 As Label
    Friend WithEvents btnguardar As Button
    Friend WithEvents btnvolver As Button
    Friend WithEvents btnbuscar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtbuscar As TextBox
End Class
