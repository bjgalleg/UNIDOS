<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modificar_datosde_persona
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Modificar_datosde_persona))
        Me.txtmdireccion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.clbmdpto = New System.Windows.Forms.CheckedListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbmestado = New System.Windows.Forms.ComboBox()
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
        Me.SuspendLayout()
        '
        'txtmdireccion
        '
        Me.txtmdireccion.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.txtmdireccion.Location = New System.Drawing.Point(527, 140)
        Me.txtmdireccion.Name = "txtmdireccion"
        Me.txtmdireccion.Size = New System.Drawing.Size(200, 24)
        Me.txtmdireccion.TabIndex = 168
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(376, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 17)
        Me.Label4.TabIndex = 167
        Me.Label4.Text = "Dirección"
        '
        'txtbuscar
        '
        Me.txtbuscar.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.txtbuscar.Location = New System.Drawing.Point(269, 21)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(100, 24)
        Me.txtbuscar.TabIndex = 166
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(60, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(203, 17)
        Me.Label3.TabIndex = 165
        Me.Label3.Text = "Ingrese número de cédula"
        '
        'btnbuscar
        '
        Me.btnbuscar.BackColor = System.Drawing.Color.DarkOrchid
        Me.btnbuscar.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.btnbuscar.Location = New System.Drawing.Point(388, 18)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnbuscar.TabIndex = 164
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.UseVisualStyleBackColor = False
        '
        'clbmdpto
        '
        Me.clbmdpto.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.clbmdpto.FormattingEnabled = True
        Me.clbmdpto.Items.AddRange(New Object() {"Spoude", "DAR", "Artes", "Coord. General y TTHH", "Finanzas"})
        Me.clbmdpto.Location = New System.Drawing.Point(527, 239)
        Me.clbmdpto.Name = "clbmdpto"
        Me.clbmdpto.Size = New System.Drawing.Size(145, 99)
        Me.clbmdpto.TabIndex = 163
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(48, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(223, 17)
        Me.Label2.TabIndex = 162
        Me.Label2.Text = "INFORMACIÓN ADICIONAL"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(51, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 17)
        Me.Label1.TabIndex = 161
        Me.Label1.Text = "DATOS PERSONALES"
        '
        'cmbmestado
        '
        Me.cmbmestado.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.cmbmestado.FormattingEnabled = True
        Me.cmbmestado.Items.AddRange(New Object() {"Estudiante", "Egresado", "Graduado", "Estudios no concluidos", "Sin estudios superiores"})
        Me.cmbmestado.Location = New System.Drawing.Point(158, 287)
        Me.cmbmestado.Name = "cmbmestado"
        Me.cmbmestado.Size = New System.Drawing.Size(197, 25)
        Me.cmbmestado.TabIndex = 158
        '
        'txtmcarrera
        '
        Me.txtmcarrera.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.txtmcarrera.Location = New System.Drawing.Point(158, 265)
        Me.txtmcarrera.Name = "txtmcarrera"
        Me.txtmcarrera.Size = New System.Drawing.Size(197, 24)
        Me.txtmcarrera.TabIndex = 157
        '
        'txtmuniversidad
        '
        Me.txtmuniversidad.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.txtmuniversidad.Location = New System.Drawing.Point(158, 242)
        Me.txtmuniversidad.Name = "txtmuniversidad"
        Me.txtmuniversidad.Size = New System.Drawing.Size(197, 24)
        Me.txtmuniversidad.TabIndex = 156
        '
        'cmbmtipo
        '
        Me.cmbmtipo.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.cmbmtipo.FormattingEnabled = True
        Me.cmbmtipo.Items.AddRange(New Object() {"Voluntario", "Responsable", "Donante"})
        Me.cmbmtipo.Location = New System.Drawing.Point(158, 314)
        Me.cmbmtipo.Name = "cmbmtipo"
        Me.cmbmtipo.Size = New System.Drawing.Size(197, 25)
        Me.cmbmtipo.TabIndex = 155
        '
        'mfecha
        '
        Me.mfecha.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.mfecha.Location = New System.Drawing.Point(527, 166)
        Me.mfecha.Name = "mfecha"
        Me.mfecha.Size = New System.Drawing.Size(200, 24)
        Me.mfecha.TabIndex = 154
        '
        'txtmemail
        '
        Me.txtmemail.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.txtmemail.Location = New System.Drawing.Point(527, 113)
        Me.txtmemail.Name = "txtmemail"
        Me.txtmemail.Size = New System.Drawing.Size(200, 24)
        Me.txtmemail.TabIndex = 153
        '
        'txtmtelefono
        '
        Me.txtmtelefono.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.txtmtelefono.Location = New System.Drawing.Point(527, 89)
        Me.txtmtelefono.Name = "txtmtelefono"
        Me.txtmtelefono.Size = New System.Drawing.Size(200, 24)
        Me.txtmtelefono.TabIndex = 152
        '
        'txtmapellidos
        '
        Me.txtmapellidos.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.txtmapellidos.Location = New System.Drawing.Point(155, 133)
        Me.txtmapellidos.Name = "txtmapellidos"
        Me.txtmapellidos.Size = New System.Drawing.Size(200, 24)
        Me.txtmapellidos.TabIndex = 151
        '
        'txtmnombre
        '
        Me.txtmnombre.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.txtmnombre.Location = New System.Drawing.Point(155, 107)
        Me.txtmnombre.Name = "txtmnombre"
        Me.txtmnombre.Size = New System.Drawing.Size(200, 24)
        Me.txtmnombre.TabIndex = 150
        '
        'est1
        '
        Me.est1.AutoSize = True
        Me.est1.BackColor = System.Drawing.Color.Transparent
        Me.est1.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.est1.ForeColor = System.Drawing.Color.White
        Me.est1.Location = New System.Drawing.Point(52, 291)
        Me.est1.Name = "est1"
        Me.est1.Size = New System.Drawing.Size(60, 17)
        Me.est1.TabIndex = 149
        Me.est1.Text = "Estado"
        '
        'car1
        '
        Me.car1.AutoSize = True
        Me.car1.BackColor = System.Drawing.Color.Transparent
        Me.car1.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.car1.ForeColor = System.Drawing.Color.White
        Me.car1.Location = New System.Drawing.Point(51, 265)
        Me.car1.Name = "car1"
        Me.car1.Size = New System.Drawing.Size(69, 17)
        Me.car1.TabIndex = 148
        Me.car1.Text = "Carrera"
        '
        'uni1
        '
        Me.uni1.AutoSize = True
        Me.uni1.BackColor = System.Drawing.Color.Transparent
        Me.uni1.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.uni1.ForeColor = System.Drawing.Color.White
        Me.uni1.Location = New System.Drawing.Point(48, 242)
        Me.uni1.Name = "uni1"
        Me.uni1.Size = New System.Drawing.Size(101, 17)
        Me.uni1.TabIndex = 147
        Me.uni1.Text = "Universidad"
        '
        'dpto1
        '
        Me.dpto1.AutoSize = True
        Me.dpto1.BackColor = System.Drawing.Color.Transparent
        Me.dpto1.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.dpto1.ForeColor = System.Drawing.Color.White
        Me.dpto1.Location = New System.Drawing.Point(380, 235)
        Me.dpto1.Name = "dpto1"
        Me.dpto1.Size = New System.Drawing.Size(119, 17)
        Me.dpto1.TabIndex = 146
        Me.dpto1.Text = "Departamento"
        '
        'fec1
        '
        Me.fec1.AutoSize = True
        Me.fec1.BackColor = System.Drawing.Color.Transparent
        Me.fec1.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.fec1.ForeColor = System.Drawing.Color.White
        Me.fec1.Location = New System.Drawing.Point(376, 169)
        Me.fec1.Name = "fec1"
        Me.fec1.Size = New System.Drawing.Size(164, 17)
        Me.fec1.TabIndex = 145
        Me.fec1.Text = "Fecha de nacimiento"
        '
        'mail1
        '
        Me.mail1.AutoSize = True
        Me.mail1.BackColor = System.Drawing.Color.Transparent
        Me.mail1.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.mail1.ForeColor = System.Drawing.Color.White
        Me.mail1.Location = New System.Drawing.Point(376, 113)
        Me.mail1.Name = "mail1"
        Me.mail1.Size = New System.Drawing.Size(55, 17)
        Me.mail1.TabIndex = 144
        Me.mail1.Text = "E-mail"
        '
        'tel1
        '
        Me.tel1.AutoSize = True
        Me.tel1.BackColor = System.Drawing.Color.Transparent
        Me.tel1.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.tel1.ForeColor = System.Drawing.Color.White
        Me.tel1.Location = New System.Drawing.Point(376, 89)
        Me.tel1.Name = "tel1"
        Me.tel1.Size = New System.Drawing.Size(74, 17)
        Me.tel1.TabIndex = 143
        Me.tel1.Text = "Teléfono"
        '
        'ti1
        '
        Me.ti1.AutoSize = True
        Me.ti1.BackColor = System.Drawing.Color.Transparent
        Me.ti1.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.ti1.ForeColor = System.Drawing.Color.White
        Me.ti1.Location = New System.Drawing.Point(51, 317)
        Me.ti1.Name = "ti1"
        Me.ti1.Size = New System.Drawing.Size(43, 17)
        Me.ti1.TabIndex = 142
        Me.ti1.Text = "Tipo"
        '
        'ap1
        '
        Me.ap1.AutoSize = True
        Me.ap1.BackColor = System.Drawing.Color.Transparent
        Me.ap1.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.ap1.ForeColor = System.Drawing.Color.White
        Me.ap1.Location = New System.Drawing.Point(48, 133)
        Me.ap1.Name = "ap1"
        Me.ap1.Size = New System.Drawing.Size(79, 17)
        Me.ap1.TabIndex = 141
        Me.ap1.Text = "Apellidos"
        '
        'nom1
        '
        Me.nom1.AutoSize = True
        Me.nom1.BackColor = System.Drawing.Color.Transparent
        Me.nom1.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.nom1.ForeColor = System.Drawing.Color.White
        Me.nom1.Location = New System.Drawing.Point(48, 107)
        Me.nom1.Name = "nom1"
        Me.nom1.Size = New System.Drawing.Size(75, 17)
        Me.nom1.TabIndex = 140
        Me.nom1.Text = "Nombres"
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.DarkOrchid
        Me.btnguardar.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.btnguardar.Location = New System.Drawing.Point(332, 354)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(99, 23)
        Me.btnguardar.TabIndex = 139
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'btnvolver
        '
        Me.btnvolver.BackColor = System.Drawing.Color.DarkOrchid
        Me.btnvolver.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.btnvolver.Location = New System.Drawing.Point(437, 354)
        Me.btnvolver.Name = "btnvolver"
        Me.btnvolver.Size = New System.Drawing.Size(103, 23)
        Me.btnvolver.TabIndex = 138
        Me.btnvolver.Text = "Volver"
        Me.btnvolver.UseVisualStyleBackColor = False
        '
        'Modificar_datosde_persona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(748, 431)
        Me.Controls.Add(Me.txtmdireccion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtbuscar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.clbmdpto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbmestado)
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
        Me.Name = "Modificar_datosde_persona"
        Me.Text = "Modificar_datosde_persona"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtmdireccion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnbuscar As Button
    Friend WithEvents clbmdpto As CheckedListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbmestado As ComboBox
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
End Class
