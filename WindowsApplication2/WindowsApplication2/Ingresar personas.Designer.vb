<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IngresarPersonas
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
        Me.cmbestado = New System.Windows.Forms.ComboBox()
        Me.txtcarrera = New System.Windows.Forms.TextBox()
        Me.txtuniversidad = New System.Windows.Forms.TextBox()
        Me.cmbtipo = New System.Windows.Forms.ComboBox()
        Me.fecha = New System.Windows.Forms.DateTimePicker()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.txtapellidos = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.btnmcedula = New System.Windows.Forms.TextBox()
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
        Me.ced1 = New System.Windows.Forms.Label()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btnvolver = New System.Windows.Forms.Button()
        Me.txtcedula = New System.Windows.Forms.TextBox()
        Me.ced = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.clbdpto = New System.Windows.Forms.CheckedListBox()
        Me.SuspendLayout()
        '
        'cmbestado
        '
        Me.cmbestado.FormattingEnabled = True
        Me.cmbestado.Items.AddRange(New Object() {"Estudiante", "Egresado", "Graduado", "Estudios no concluidos"})
        Me.cmbestado.Location = New System.Drawing.Point(167, 269)
        Me.cmbestado.Name = "cmbestado"
        Me.cmbestado.Size = New System.Drawing.Size(197, 21)
        Me.cmbestado.TabIndex = 101
        '
        'txtcarrera
        '
        Me.txtcarrera.Location = New System.Drawing.Point(167, 246)
        Me.txtcarrera.Name = "txtcarrera"
        Me.txtcarrera.Size = New System.Drawing.Size(197, 20)
        Me.txtcarrera.TabIndex = 100
        '
        'txtuniversidad
        '
        Me.txtuniversidad.Location = New System.Drawing.Point(167, 220)
        Me.txtuniversidad.Name = "txtuniversidad"
        Me.txtuniversidad.Size = New System.Drawing.Size(197, 20)
        Me.txtuniversidad.TabIndex = 99
        '
        'cmbtipo
        '
        Me.cmbtipo.FormattingEnabled = True
        Me.cmbtipo.Items.AddRange(New Object() {"Voluntario", "Donante", "Cliente"})
        Me.cmbtipo.Location = New System.Drawing.Point(167, 295)
        Me.cmbtipo.Name = "cmbtipo"
        Me.cmbtipo.Size = New System.Drawing.Size(197, 21)
        Me.cmbtipo.TabIndex = 97
        '
        'fecha
        '
        Me.fecha.Location = New System.Drawing.Point(492, 117)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(200, 20)
        Me.fecha.TabIndex = 96
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(492, 91)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(200, 20)
        Me.txtemail.TabIndex = 95
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(492, 67)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(200, 20)
        Me.txttelefono.TabIndex = 94
        '
        'txtapellidos
        '
        Me.txtapellidos.Location = New System.Drawing.Point(164, 122)
        Me.txtapellidos.Name = "txtapellidos"
        Me.txtapellidos.Size = New System.Drawing.Size(200, 20)
        Me.txtapellidos.TabIndex = 93
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(164, 96)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(200, 20)
        Me.txtnombre.TabIndex = 92
        '
        'btnmcedula
        '
        Me.btnmcedula.Location = New System.Drawing.Point(95, -43)
        Me.btnmcedula.Name = "btnmcedula"
        Me.btnmcedula.Size = New System.Drawing.Size(200, 20)
        Me.btnmcedula.TabIndex = 91
        '
        'est1
        '
        Me.est1.AutoSize = True
        Me.est1.Location = New System.Drawing.Point(61, 272)
        Me.est1.Name = "est1"
        Me.est1.Size = New System.Drawing.Size(40, 13)
        Me.est1.TabIndex = 90
        Me.est1.Text = "Estado"
        '
        'car1
        '
        Me.car1.AutoSize = True
        Me.car1.Location = New System.Drawing.Point(60, 246)
        Me.car1.Name = "car1"
        Me.car1.Size = New System.Drawing.Size(41, 13)
        Me.car1.TabIndex = 89
        Me.car1.Text = "Carrera"
        '
        'uni1
        '
        Me.uni1.AutoSize = True
        Me.uni1.Location = New System.Drawing.Point(57, 223)
        Me.uni1.Name = "uni1"
        Me.uni1.Size = New System.Drawing.Size(63, 13)
        Me.uni1.TabIndex = 88
        Me.uni1.Text = "Universidad"
        '
        'dpto1
        '
        Me.dpto1.AutoSize = True
        Me.dpto1.Location = New System.Drawing.Point(389, 216)
        Me.dpto1.Name = "dpto1"
        Me.dpto1.Size = New System.Drawing.Size(74, 13)
        Me.dpto1.TabIndex = 87
        Me.dpto1.Text = "Departamento"
        '
        'fec1
        '
        Me.fec1.AutoSize = True
        Me.fec1.Location = New System.Drawing.Point(385, 123)
        Me.fec1.Name = "fec1"
        Me.fec1.Size = New System.Drawing.Size(106, 13)
        Me.fec1.TabIndex = 86
        Me.fec1.Text = "Fecha de nacimiento"
        '
        'mail1
        '
        Me.mail1.AutoSize = True
        Me.mail1.Location = New System.Drawing.Point(385, 94)
        Me.mail1.Name = "mail1"
        Me.mail1.Size = New System.Drawing.Size(35, 13)
        Me.mail1.TabIndex = 85
        Me.mail1.Text = "E-mail"
        '
        'tel1
        '
        Me.tel1.AutoSize = True
        Me.tel1.Location = New System.Drawing.Point(385, 70)
        Me.tel1.Name = "tel1"
        Me.tel1.Size = New System.Drawing.Size(49, 13)
        Me.tel1.TabIndex = 84
        Me.tel1.Text = "Teléfono"
        '
        'ti1
        '
        Me.ti1.AutoSize = True
        Me.ti1.Location = New System.Drawing.Point(60, 298)
        Me.ti1.Name = "ti1"
        Me.ti1.Size = New System.Drawing.Size(28, 13)
        Me.ti1.TabIndex = 83
        Me.ti1.Text = "Tipo"
        '
        'ap1
        '
        Me.ap1.AutoSize = True
        Me.ap1.Location = New System.Drawing.Point(57, 122)
        Me.ap1.Name = "ap1"
        Me.ap1.Size = New System.Drawing.Size(49, 13)
        Me.ap1.TabIndex = 82
        Me.ap1.Text = "Apellidos"
        '
        'nom1
        '
        Me.nom1.AutoSize = True
        Me.nom1.Location = New System.Drawing.Point(57, 96)
        Me.nom1.Name = "nom1"
        Me.nom1.Size = New System.Drawing.Size(49, 13)
        Me.nom1.TabIndex = 81
        Me.nom1.Text = "Nombres"
        '
        'ced1
        '
        Me.ced1.AutoSize = True
        Me.ced1.Location = New System.Drawing.Point(-11, -40)
        Me.ced1.Name = "ced1"
        Me.ced1.Size = New System.Drawing.Size(40, 13)
        Me.ced1.TabIndex = 80
        Me.ced1.Text = "Cédula"
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(328, 341)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(75, 23)
        Me.btnguardar.TabIndex = 79
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'btnvolver
        '
        Me.btnvolver.Location = New System.Drawing.Point(433, 341)
        Me.btnvolver.Name = "btnvolver"
        Me.btnvolver.Size = New System.Drawing.Size(75, 23)
        Me.btnvolver.TabIndex = 78
        Me.btnvolver.Text = "Volver"
        Me.btnvolver.UseVisualStyleBackColor = True
        '
        'txtcedula
        '
        Me.txtcedula.Location = New System.Drawing.Point(164, 70)
        Me.txtcedula.Name = "txtcedula"
        Me.txtcedula.Size = New System.Drawing.Size(200, 20)
        Me.txtcedula.TabIndex = 102
        '
        'ced
        '
        Me.ced.AutoSize = True
        Me.ced.Location = New System.Drawing.Point(60, 70)
        Me.ced.Name = "ced"
        Me.ced.Size = New System.Drawing.Size(40, 13)
        Me.ced.TabIndex = 103
        Me.ced.Text = "Cédula"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 13)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "DATOS PERSONALES"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 13)
        Me.Label2.TabIndex = 105
        Me.Label2.Text = "INFORMACIÓN ADICIONAL"
        '
        'clbdpto
        '
        Me.clbdpto.FormattingEnabled = True
        Me.clbdpto.Items.AddRange(New Object() {"Spoude", "DAR", "Artes", "Coord. General y TTHH", "Finanzas"})
        Me.clbdpto.Location = New System.Drawing.Point(469, 217)
        Me.clbdpto.Name = "clbdpto"
        Me.clbdpto.Size = New System.Drawing.Size(153, 94)
        Me.clbdpto.TabIndex = 106
        '
        'IngresarPersonas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 509)
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
        Me.Controls.Add(Me.btnmcedula)
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
        Me.Controls.Add(Me.ced1)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btnvolver)
        Me.Name = "IngresarPersonas"
        Me.Text = "Ingresar Personas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbestado As ComboBox
    Friend WithEvents txtcarrera As TextBox
    Friend WithEvents txtuniversidad As TextBox
    Friend WithEvents cmbtipo As ComboBox
    Friend WithEvents fecha As DateTimePicker
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents txtapellidos As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents btnmcedula As TextBox
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
    Friend WithEvents ced1 As Label
    Friend WithEvents btnguardar As Button
    Friend WithEvents btnvolver As Button
    Friend WithEvents txtcedula As TextBox
    Friend WithEvents ced As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents clbdpto As CheckedListBox
End Class
