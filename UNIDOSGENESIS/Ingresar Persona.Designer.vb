<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ingresar_Persona
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ingresar_Persona))
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.clbdpto = New System.Windows.Forms.CheckedListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ced = New System.Windows.Forms.Label()
        Me.txtcedula = New System.Windows.Forms.TextBox()
        Me.cmbestado = New System.Windows.Forms.ComboBox()
        Me.txtcarrera = New System.Windows.Forms.TextBox()
        Me.txtuniversidad = New System.Windows.Forms.TextBox()
        Me.cmbtipo = New System.Windows.Forms.ComboBox()
        Me.fecha = New System.Windows.Forms.DateTimePicker()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.txtapellidos = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
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
        'txtdireccion
        '
        Me.txtdireccion.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdireccion.Location = New System.Drawing.Point(525, 123)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(279, 22)
        Me.txtdireccion.TabIndex = 164
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(340, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 15)
        Me.Label3.TabIndex = 163
        Me.Label3.Text = "Dirección"
        '
        'clbdpto
        '
        Me.clbdpto.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clbdpto.FormattingEnabled = True
        Me.clbdpto.Items.AddRange(New Object() {"Spoude", "DAR", "Artes", "Coord. General y TTHH", "Finanzas"})
        Me.clbdpto.Location = New System.Drawing.Point(465, 221)
        Me.clbdpto.Name = "clbdpto"
        Me.clbdpto.Size = New System.Drawing.Size(197, 89)
        Me.clbdpto.TabIndex = 162
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 15)
        Me.Label2.TabIndex = 161
        Me.Label2.Text = "INFORMACIÓN ADICIONAL"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(15, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 15)
        Me.Label1.TabIndex = 160
        Me.Label1.Text = "DATOS PERSONALES"
        '
        'ced
        '
        Me.ced.AutoSize = True
        Me.ced.BackColor = System.Drawing.Color.Transparent
        Me.ced.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ced.ForeColor = System.Drawing.Color.White
        Me.ced.Location = New System.Drawing.Point(15, 75)
        Me.ced.Name = "ced"
        Me.ced.Size = New System.Drawing.Size(53, 15)
        Me.ced.TabIndex = 159
        Me.ced.Text = "Cédula"
        '
        'txtcedula
        '
        Me.txtcedula.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcedula.Location = New System.Drawing.Point(119, 75)
        Me.txtcedula.Name = "txtcedula"
        Me.txtcedula.Size = New System.Drawing.Size(200, 22)
        Me.txtcedula.TabIndex = 158
        '
        'cmbestado
        '
        Me.cmbestado.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbestado.FormattingEnabled = True
        Me.cmbestado.Items.AddRange(New Object() {"Estudiante", "Egresado", "Graduado", "Estudios no concluidos"})
        Me.cmbestado.Location = New System.Drawing.Point(122, 274)
        Me.cmbestado.Name = "cmbestado"
        Me.cmbestado.Size = New System.Drawing.Size(197, 23)
        Me.cmbestado.TabIndex = 157
        '
        'txtcarrera
        '
        Me.txtcarrera.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcarrera.Location = New System.Drawing.Point(122, 251)
        Me.txtcarrera.Name = "txtcarrera"
        Me.txtcarrera.Size = New System.Drawing.Size(197, 22)
        Me.txtcarrera.TabIndex = 156
        '
        'txtuniversidad
        '
        Me.txtuniversidad.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuniversidad.Location = New System.Drawing.Point(122, 225)
        Me.txtuniversidad.Name = "txtuniversidad"
        Me.txtuniversidad.Size = New System.Drawing.Size(197, 22)
        Me.txtuniversidad.TabIndex = 155
        '
        'cmbtipo
        '
        Me.cmbtipo.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbtipo.FormattingEnabled = True
        Me.cmbtipo.Items.AddRange(New Object() {"Voluntario", "Donante", "Cliente"})
        Me.cmbtipo.Location = New System.Drawing.Point(122, 300)
        Me.cmbtipo.Name = "cmbtipo"
        Me.cmbtipo.Size = New System.Drawing.Size(197, 23)
        Me.cmbtipo.TabIndex = 154
        '
        'fecha
        '
        Me.fecha.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.Location = New System.Drawing.Point(525, 150)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(279, 22)
        Me.fecha.TabIndex = 153
        '
        'txtemail
        '
        Me.txtemail.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.Location = New System.Drawing.Point(525, 99)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(279, 22)
        Me.txtemail.TabIndex = 152
        '
        'txttelefono
        '
        Me.txttelefono.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttelefono.Location = New System.Drawing.Point(525, 75)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(279, 22)
        Me.txttelefono.TabIndex = 151
        '
        'txtapellidos
        '
        Me.txtapellidos.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtapellidos.Location = New System.Drawing.Point(119, 127)
        Me.txtapellidos.Name = "txtapellidos"
        Me.txtapellidos.Size = New System.Drawing.Size(200, 22)
        Me.txtapellidos.TabIndex = 150
        '
        'txtnombre
        '
        Me.txtnombre.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.Location = New System.Drawing.Point(119, 101)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(200, 22)
        Me.txtnombre.TabIndex = 149
        '
        'est1
        '
        Me.est1.AutoSize = True
        Me.est1.BackColor = System.Drawing.Color.Transparent
        Me.est1.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.est1.ForeColor = System.Drawing.Color.White
        Me.est1.Location = New System.Drawing.Point(16, 277)
        Me.est1.Name = "est1"
        Me.est1.Size = New System.Drawing.Size(51, 15)
        Me.est1.TabIndex = 148
        Me.est1.Text = "Estado"
        '
        'car1
        '
        Me.car1.AutoSize = True
        Me.car1.BackColor = System.Drawing.Color.Transparent
        Me.car1.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.car1.ForeColor = System.Drawing.Color.White
        Me.car1.Location = New System.Drawing.Point(15, 251)
        Me.car1.Name = "car1"
        Me.car1.Size = New System.Drawing.Size(58, 15)
        Me.car1.TabIndex = 147
        Me.car1.Text = "Carrera"
        '
        'uni1
        '
        Me.uni1.AutoSize = True
        Me.uni1.BackColor = System.Drawing.Color.Transparent
        Me.uni1.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uni1.ForeColor = System.Drawing.Color.White
        Me.uni1.Location = New System.Drawing.Point(12, 228)
        Me.uni1.Name = "uni1"
        Me.uni1.Size = New System.Drawing.Size(90, 15)
        Me.uni1.TabIndex = 146
        Me.uni1.Text = "Universidad"
        '
        'dpto1
        '
        Me.dpto1.AutoSize = True
        Me.dpto1.BackColor = System.Drawing.Color.Transparent
        Me.dpto1.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpto1.ForeColor = System.Drawing.Color.White
        Me.dpto1.Location = New System.Drawing.Point(344, 221)
        Me.dpto1.Name = "dpto1"
        Me.dpto1.Size = New System.Drawing.Size(103, 15)
        Me.dpto1.TabIndex = 145
        Me.dpto1.Text = "Departamento"
        '
        'fec1
        '
        Me.fec1.AutoSize = True
        Me.fec1.BackColor = System.Drawing.Color.Transparent
        Me.fec1.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fec1.ForeColor = System.Drawing.Color.White
        Me.fec1.Location = New System.Drawing.Point(340, 153)
        Me.fec1.Name = "fec1"
        Me.fec1.Size = New System.Drawing.Size(145, 15)
        Me.fec1.TabIndex = 144
        Me.fec1.Text = "Fecha de nacimiento"
        '
        'mail1
        '
        Me.mail1.AutoSize = True
        Me.mail1.BackColor = System.Drawing.Color.Transparent
        Me.mail1.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mail1.ForeColor = System.Drawing.Color.White
        Me.mail1.Location = New System.Drawing.Point(340, 99)
        Me.mail1.Name = "mail1"
        Me.mail1.Size = New System.Drawing.Size(52, 15)
        Me.mail1.TabIndex = 143
        Me.mail1.Text = "E-mail"
        '
        'tel1
        '
        Me.tel1.AutoSize = True
        Me.tel1.BackColor = System.Drawing.Color.Transparent
        Me.tel1.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tel1.ForeColor = System.Drawing.Color.White
        Me.tel1.Location = New System.Drawing.Point(340, 75)
        Me.tel1.Name = "tel1"
        Me.tel1.Size = New System.Drawing.Size(67, 15)
        Me.tel1.TabIndex = 142
        Me.tel1.Text = "Teléfono"
        '
        'ti1
        '
        Me.ti1.AutoSize = True
        Me.ti1.BackColor = System.Drawing.Color.Transparent
        Me.ti1.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ti1.ForeColor = System.Drawing.Color.White
        Me.ti1.Location = New System.Drawing.Point(15, 303)
        Me.ti1.Name = "ti1"
        Me.ti1.Size = New System.Drawing.Size(39, 15)
        Me.ti1.TabIndex = 141
        Me.ti1.Text = "Tipo"
        '
        'ap1
        '
        Me.ap1.AutoSize = True
        Me.ap1.BackColor = System.Drawing.Color.Transparent
        Me.ap1.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ap1.ForeColor = System.Drawing.Color.White
        Me.ap1.Location = New System.Drawing.Point(12, 127)
        Me.ap1.Name = "ap1"
        Me.ap1.Size = New System.Drawing.Size(74, 15)
        Me.ap1.TabIndex = 140
        Me.ap1.Text = "Apellidos"
        '
        'nom1
        '
        Me.nom1.AutoSize = True
        Me.nom1.BackColor = System.Drawing.Color.Transparent
        Me.nom1.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nom1.ForeColor = System.Drawing.Color.White
        Me.nom1.Location = New System.Drawing.Point(12, 101)
        Me.nom1.Name = "nom1"
        Me.nom1.Size = New System.Drawing.Size(67, 15)
        Me.nom1.TabIndex = 139
        Me.nom1.Text = "Nombres"
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.BlueViolet
        Me.btnguardar.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.Location = New System.Drawing.Point(202, 358)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(91, 38)
        Me.btnguardar.TabIndex = 138
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'btnvolver
        '
        Me.btnvolver.BackColor = System.Drawing.Color.BlueViolet
        Me.btnvolver.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnvolver.Location = New System.Drawing.Point(556, 358)
        Me.btnvolver.Name = "btnvolver"
        Me.btnvolver.Size = New System.Drawing.Size(84, 38)
        Me.btnvolver.TabIndex = 137
        Me.btnvolver.Text = "Volver"
        Me.btnvolver.UseVisualStyleBackColor = False
        '
        'Ingresar_Persona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(844, 408)
        Me.Controls.Add(Me.txtdireccion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.clbdpto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ced)
        Me.Controls.Add(Me.txtcedula)
        Me.Controls.Add(Me.cmbestado)
        Me.Controls.Add(Me.txtcarrera)
        Me.Controls.Add(Me.txtuniversidad)
        Me.Controls.Add(Me.cmbtipo)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txttelefono)
        Me.Controls.Add(Me.txtapellidos)
        Me.Controls.Add(Me.txtnombre)
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
        Me.Name = "Ingresar_Persona"
        Me.Text = "Ingresar_Persona"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtdireccion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents clbdpto As CheckedListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ced As Label
    Friend WithEvents txtcedula As TextBox
    Friend WithEvents cmbestado As ComboBox
    Friend WithEvents txtcarrera As TextBox
    Friend WithEvents txtuniversidad As TextBox
    Friend WithEvents cmbtipo As ComboBox
    Friend WithEvents fecha As DateTimePicker
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents txtapellidos As TextBox
    Friend WithEvents txtnombre As TextBox
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
