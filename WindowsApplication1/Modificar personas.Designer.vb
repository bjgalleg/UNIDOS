<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.components = New System.ComponentModel.Container()
        Me.txtmdireccion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnbuscar = New System.Windows.Forms.Button()
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
        Me.fec1 = New System.Windows.Forms.Label()
        Me.mail1 = New System.Windows.Forms.Label()
        Me.tel1 = New System.Windows.Forms.Label()
        Me.ti1 = New System.Windows.Forms.Label()
        Me.ap1 = New System.Windows.Forms.Label()
        Me.nom1 = New System.Windows.Forms.Label()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btnvolver = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UNIDOSBGDataSet = New WindowsApplication1.UNIDOSBGDataSet()
        Me.UNIDOSBGDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.UNIDOSBGDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UNIDOSBGDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtmdireccion
        '
        Me.txtmdireccion.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.txtmdireccion.Location = New System.Drawing.Point(169, 235)
        Me.txtmdireccion.Name = "txtmdireccion"
        Me.txtmdireccion.Size = New System.Drawing.Size(200, 24)
        Me.txtmdireccion.TabIndex = 197
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(18, 236)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 17)
        Me.Label4.TabIndex = 196
        Me.Label4.Text = "Dirección"
        '
        'txtbuscar
        '
        Me.txtbuscar.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.txtbuscar.Location = New System.Drawing.Point(227, 28)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(100, 24)
        Me.txtbuscar.TabIndex = 195
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(18, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(203, 17)
        Me.Label3.TabIndex = 194
        Me.Label3.Text = "Ingrese número de cédula"
        '
        'btnbuscar
        '
        Me.btnbuscar.BackColor = System.Drawing.Color.DarkOrchid
        Me.btnbuscar.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.btnbuscar.Location = New System.Drawing.Point(346, 25)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnbuscar.TabIndex = 193
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.UseVisualStyleBackColor = False
        '
        'cmbmestado
        '
        Me.cmbmestado.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.cmbmestado.FormattingEnabled = True
        Me.cmbmestado.Items.AddRange(New Object() {"Estudiante", "Egresado", "Graduado", "Estudios no concluidos", "Sin estudios superiores"})
        Me.cmbmestado.Location = New System.Drawing.Point(142, 349)
        Me.cmbmestado.Name = "cmbmestado"
        Me.cmbmestado.Size = New System.Drawing.Size(197, 25)
        Me.cmbmestado.TabIndex = 189
        '
        'txtmcarrera
        '
        Me.txtmcarrera.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.txtmcarrera.Location = New System.Drawing.Point(142, 327)
        Me.txtmcarrera.Name = "txtmcarrera"
        Me.txtmcarrera.Size = New System.Drawing.Size(197, 24)
        Me.txtmcarrera.TabIndex = 188
        '
        'txtmuniversidad
        '
        Me.txtmuniversidad.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.txtmuniversidad.Location = New System.Drawing.Point(142, 304)
        Me.txtmuniversidad.Name = "txtmuniversidad"
        Me.txtmuniversidad.Size = New System.Drawing.Size(197, 24)
        Me.txtmuniversidad.TabIndex = 187
        '
        'cmbmtipo
        '
        Me.cmbmtipo.DataSource = Me.UNIDOSBGDataSetBindingSource
        Me.cmbmtipo.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.cmbmtipo.FormattingEnabled = True
        Me.cmbmtipo.Location = New System.Drawing.Point(142, 376)
        Me.cmbmtipo.Name = "cmbmtipo"
        Me.cmbmtipo.Size = New System.Drawing.Size(197, 25)
        Me.cmbmtipo.TabIndex = 186
        '
        'mfecha
        '
        Me.mfecha.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.mfecha.Location = New System.Drawing.Point(169, 261)
        Me.mfecha.Name = "mfecha"
        Me.mfecha.Size = New System.Drawing.Size(200, 24)
        Me.mfecha.TabIndex = 185
        '
        'txtmemail
        '
        Me.txtmemail.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.txtmemail.Location = New System.Drawing.Point(169, 208)
        Me.txtmemail.Name = "txtmemail"
        Me.txtmemail.Size = New System.Drawing.Size(200, 24)
        Me.txtmemail.TabIndex = 184
        '
        'txtmtelefono
        '
        Me.txtmtelefono.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.txtmtelefono.Location = New System.Drawing.Point(169, 184)
        Me.txtmtelefono.Name = "txtmtelefono"
        Me.txtmtelefono.Size = New System.Drawing.Size(200, 24)
        Me.txtmtelefono.TabIndex = 183
        '
        'txtmapellidos
        '
        Me.txtmapellidos.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.txtmapellidos.Location = New System.Drawing.Point(125, 143)
        Me.txtmapellidos.Name = "txtmapellidos"
        Me.txtmapellidos.Size = New System.Drawing.Size(200, 24)
        Me.txtmapellidos.TabIndex = 182
        '
        'txtmnombre
        '
        Me.txtmnombre.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.txtmnombre.Location = New System.Drawing.Point(124, 110)
        Me.txtmnombre.Name = "txtmnombre"
        Me.txtmnombre.Size = New System.Drawing.Size(200, 24)
        Me.txtmnombre.TabIndex = 181
        '
        'est1
        '
        Me.est1.AutoSize = True
        Me.est1.BackColor = System.Drawing.Color.Transparent
        Me.est1.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.est1.ForeColor = System.Drawing.Color.Black
        Me.est1.Location = New System.Drawing.Point(36, 353)
        Me.est1.Name = "est1"
        Me.est1.Size = New System.Drawing.Size(60, 17)
        Me.est1.TabIndex = 180
        Me.est1.Text = "Estado"
        '
        'car1
        '
        Me.car1.AutoSize = True
        Me.car1.BackColor = System.Drawing.Color.Transparent
        Me.car1.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.car1.ForeColor = System.Drawing.Color.Black
        Me.car1.Location = New System.Drawing.Point(35, 327)
        Me.car1.Name = "car1"
        Me.car1.Size = New System.Drawing.Size(69, 17)
        Me.car1.TabIndex = 179
        Me.car1.Text = "Carrera"
        '
        'uni1
        '
        Me.uni1.AutoSize = True
        Me.uni1.BackColor = System.Drawing.Color.Transparent
        Me.uni1.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.uni1.ForeColor = System.Drawing.Color.Black
        Me.uni1.Location = New System.Drawing.Point(32, 304)
        Me.uni1.Name = "uni1"
        Me.uni1.Size = New System.Drawing.Size(101, 17)
        Me.uni1.TabIndex = 178
        Me.uni1.Text = "Universidad"
        '
        'fec1
        '
        Me.fec1.AutoSize = True
        Me.fec1.BackColor = System.Drawing.Color.Transparent
        Me.fec1.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.fec1.ForeColor = System.Drawing.Color.Black
        Me.fec1.Location = New System.Drawing.Point(18, 264)
        Me.fec1.Name = "fec1"
        Me.fec1.Size = New System.Drawing.Size(164, 17)
        Me.fec1.TabIndex = 176
        Me.fec1.Text = "Fecha de nacimiento"
        '
        'mail1
        '
        Me.mail1.AutoSize = True
        Me.mail1.BackColor = System.Drawing.Color.Transparent
        Me.mail1.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.mail1.ForeColor = System.Drawing.Color.Black
        Me.mail1.Location = New System.Drawing.Point(18, 208)
        Me.mail1.Name = "mail1"
        Me.mail1.Size = New System.Drawing.Size(55, 17)
        Me.mail1.TabIndex = 175
        Me.mail1.Text = "E-mail"
        '
        'tel1
        '
        Me.tel1.AutoSize = True
        Me.tel1.BackColor = System.Drawing.Color.Transparent
        Me.tel1.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.tel1.ForeColor = System.Drawing.Color.Black
        Me.tel1.Location = New System.Drawing.Point(18, 184)
        Me.tel1.Name = "tel1"
        Me.tel1.Size = New System.Drawing.Size(74, 17)
        Me.tel1.TabIndex = 174
        Me.tel1.Text = "Teléfono"
        '
        'ti1
        '
        Me.ti1.AutoSize = True
        Me.ti1.BackColor = System.Drawing.Color.Transparent
        Me.ti1.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.ti1.ForeColor = System.Drawing.Color.Black
        Me.ti1.Location = New System.Drawing.Point(35, 379)
        Me.ti1.Name = "ti1"
        Me.ti1.Size = New System.Drawing.Size(119, 17)
        Me.ti1.TabIndex = 173
        Me.ti1.Text = "Departamento"
        '
        'ap1
        '
        Me.ap1.AutoSize = True
        Me.ap1.BackColor = System.Drawing.Color.Transparent
        Me.ap1.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.ap1.ForeColor = System.Drawing.Color.Black
        Me.ap1.Location = New System.Drawing.Point(18, 143)
        Me.ap1.Name = "ap1"
        Me.ap1.Size = New System.Drawing.Size(79, 17)
        Me.ap1.TabIndex = 172
        Me.ap1.Text = "Apellidos"
        '
        'nom1
        '
        Me.nom1.AutoSize = True
        Me.nom1.BackColor = System.Drawing.Color.Transparent
        Me.nom1.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.nom1.ForeColor = System.Drawing.Color.Black
        Me.nom1.Location = New System.Drawing.Point(17, 110)
        Me.nom1.Name = "nom1"
        Me.nom1.Size = New System.Drawing.Size(75, 17)
        Me.nom1.TabIndex = 171
        Me.nom1.Text = "Nombres"
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.DarkOrchid
        Me.btnguardar.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.btnguardar.Location = New System.Drawing.Point(413, 319)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(99, 23)
        Me.btnguardar.TabIndex = 170
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'btnvolver
        '
        Me.btnvolver.BackColor = System.Drawing.Color.DarkOrchid
        Me.btnvolver.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.btnvolver.Location = New System.Drawing.Point(518, 319)
        Me.btnvolver.Name = "btnvolver"
        Me.btnvolver.Size = New System.Drawing.Size(103, 23)
        Me.btnvolver.TabIndex = 169
        Me.btnvolver.Text = "Volver"
        Me.btnvolver.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Voluntario", "Responsable", "Donante"})
        Me.ComboBox1.Location = New System.Drawing.Point(125, 74)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(197, 25)
        Me.ComboBox1.TabIndex = 203
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(18, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 17)
        Me.Label1.TabIndex = 202
        Me.Label1.Text = "Tipo"
        '
        'UNIDOSBGDataSet
        '
        Me.UNIDOSBGDataSet.DataSetName = "UNIDOSBGDataSet"
        Me.UNIDOSBGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UNIDOSBGDataSetBindingSource
        '
        Me.UNIDOSBGDataSetBindingSource.DataSource = Me.UNIDOSBGDataSet
        Me.UNIDOSBGDataSetBindingSource.Position = 0
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 481)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtmdireccion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtbuscar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnbuscar)
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
        Me.Controls.Add(Me.fec1)
        Me.Controls.Add(Me.mail1)
        Me.Controls.Add(Me.tel1)
        Me.Controls.Add(Me.ti1)
        Me.Controls.Add(Me.ap1)
        Me.Controls.Add(Me.nom1)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btnvolver)
        Me.Name = "Form3"
        Me.Text = "Modificar personas"
        CType(Me.UNIDOSBGDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UNIDOSBGDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtmdireccion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnbuscar As Button
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
    Friend WithEvents fec1 As Label
    Friend WithEvents mail1 As Label
    Friend WithEvents tel1 As Label
    Friend WithEvents ti1 As Label
    Friend WithEvents ap1 As Label
    Friend WithEvents nom1 As Label
    Friend WithEvents btnguardar As Button
    Friend WithEvents btnvolver As Button
    Friend WithEvents UNIDOSBGDataSetBindingSource As BindingSource
    Friend WithEvents UNIDOSBGDataSet As UNIDOSBGDataSet
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
End Class
