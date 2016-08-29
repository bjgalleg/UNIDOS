<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modificar_Proyecto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Modificar_Proyecto))
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtmcomunidad = New System.Windows.Forms.TextBox()
        Me.cmbmtipo = New System.Windows.Forms.ComboBox()
        Me.mffinal = New System.Windows.Forms.DateTimePicker()
        Me.mfinicio = New System.Windows.Forms.DateTimePicker()
        Me.btnmvolver = New System.Windows.Forms.Button()
        Me.btnmguardar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtcedula = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtbuscar
        '
        Me.txtbuscar.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbuscar.Location = New System.Drawing.Point(400, 13)
        Me.txtbuscar.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(237, 25)
        Me.txtbuscar.TabIndex = 47
        '
        'btnbuscar
        '
        Me.btnbuscar.BackColor = System.Drawing.Color.DarkRed
        Me.btnbuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscar.ForeColor = System.Drawing.Color.White
        Me.btnbuscar.Location = New System.Drawing.Point(660, 10)
        Me.btnbuscar.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(125, 30)
        Me.btnbuscar.TabIndex = 46
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(30, 20)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(220, 17)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Ingrese Codigo del proyecto"
        '
        'txtmcomunidad
        '
        Me.txtmcomunidad.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmcomunidad.Location = New System.Drawing.Point(305, 147)
        Me.txtmcomunidad.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtmcomunidad.Name = "txtmcomunidad"
        Me.txtmcomunidad.Size = New System.Drawing.Size(496, 25)
        Me.txtmcomunidad.TabIndex = 43
        '
        'cmbmtipo
        '
        Me.cmbmtipo.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbmtipo.FormattingEnabled = True
        Me.cmbmtipo.Items.AddRange(New Object() {"Proyecto colaborativo", "Proyecto único", "Misión universitaria", "Misión comunitaria"})
        Me.cmbmtipo.Location = New System.Drawing.Point(305, 201)
        Me.cmbmtipo.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmbmtipo.Name = "cmbmtipo"
        Me.cmbmtipo.Size = New System.Drawing.Size(496, 25)
        Me.cmbmtipo.TabIndex = 41
        '
        'mffinal
        '
        Me.mffinal.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mffinal.Location = New System.Drawing.Point(305, 299)
        Me.mffinal.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.mffinal.Name = "mffinal"
        Me.mffinal.Size = New System.Drawing.Size(496, 25)
        Me.mffinal.TabIndex = 40
        '
        'mfinicio
        '
        Me.mfinicio.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mfinicio.Location = New System.Drawing.Point(305, 251)
        Me.mfinicio.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.mfinicio.Name = "mfinicio"
        Me.mfinicio.Size = New System.Drawing.Size(496, 25)
        Me.mfinicio.TabIndex = 39
        '
        'btnmvolver
        '
        Me.btnmvolver.BackColor = System.Drawing.Color.DarkRed
        Me.btnmvolver.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmvolver.ForeColor = System.Drawing.Color.White
        Me.btnmvolver.Location = New System.Drawing.Point(442, 353)
        Me.btnmvolver.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnmvolver.Name = "btnmvolver"
        Me.btnmvolver.Size = New System.Drawing.Size(125, 30)
        Me.btnmvolver.TabIndex = 38
        Me.btnmvolver.Text = "Volver"
        Me.btnmvolver.UseVisualStyleBackColor = False
        '
        'btnmguardar
        '
        Me.btnmguardar.BackColor = System.Drawing.Color.DarkRed
        Me.btnmguardar.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmguardar.ForeColor = System.Drawing.Color.White
        Me.btnmguardar.Location = New System.Drawing.Point(116, 353)
        Me.btnmguardar.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnmguardar.Name = "btnmguardar"
        Me.btnmguardar.Size = New System.Drawing.Size(125, 30)
        Me.btnmguardar.TabIndex = 37
        Me.btnmguardar.Text = "Guardar"
        Me.btnmguardar.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(30, 299)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 17)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Fecha final"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(30, 251)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 17)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Fecha inicio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(30, 209)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 17)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Tipo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(30, 158)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 17)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Comunidad"
        '
        'txtnombre
        '
        Me.txtnombre.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.Location = New System.Drawing.Point(305, 104)
        Me.txtnombre.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(496, 25)
        Me.txtnombre.TabIndex = 49
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(30, 115)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(162, 17)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Nombre de Proyecto"
        '
        'txtcedula
        '
        Me.txtcedula.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcedula.Location = New System.Drawing.Point(305, 68)
        Me.txtcedula.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtcedula.Name = "txtcedula"
        Me.txtcedula.Size = New System.Drawing.Size(496, 25)
        Me.txtcedula.TabIndex = 51
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(30, 71)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 17)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Responsable (Ingrese cédula)"
        '
        'Modificar_Proyecto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(824, 535)
        Me.Controls.Add(Me.txtcedula)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtbuscar)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtmcomunidad)
        Me.Controls.Add(Me.cmbmtipo)
        Me.Controls.Add(Me.mffinal)
        Me.Controls.Add(Me.mfinicio)
        Me.Controls.Add(Me.btnmvolver)
        Me.Controls.Add(Me.btnmguardar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Modificar_Proyecto"
        Me.Text = "Modificar_Proyecto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents btnbuscar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtmcomunidad As TextBox
    Friend WithEvents cmbmtipo As ComboBox
    Friend WithEvents mffinal As DateTimePicker
    Friend WithEvents mfinicio As DateTimePicker
    Friend WithEvents btnmvolver As Button
    Friend WithEvents btnmguardar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtcedula As TextBox
    Friend WithEvents Label1 As Label
End Class
