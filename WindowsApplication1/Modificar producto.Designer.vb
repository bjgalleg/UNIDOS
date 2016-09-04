<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modificarproducto
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
        Me.txttipo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Departamento = New System.Windows.Forms.Label()
        Me.cmbnombre = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.cmbdpto = New System.Windows.Forms.ComboBox()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.DarkOrchid
        Me.btnguardar.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.btnguardar.Location = New System.Drawing.Point(122, 267)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(99, 23)
        Me.btnguardar.TabIndex = 155
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'btnvolver
        '
        Me.btnvolver.BackColor = System.Drawing.Color.DarkOrchid
        Me.btnvolver.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.btnvolver.Location = New System.Drawing.Point(227, 267)
        Me.btnvolver.Name = "btnvolver"
        Me.btnvolver.Size = New System.Drawing.Size(103, 23)
        Me.btnvolver.TabIndex = 154
        Me.btnvolver.Text = "Volver"
        Me.btnvolver.UseVisualStyleBackColor = False
        '
        'txttipo
        '
        Me.txttipo.Location = New System.Drawing.Point(210, 157)
        Me.txttipo.Name = "txttipo"
        Me.txttipo.Size = New System.Drawing.Size(100, 20)
        Me.txttipo.TabIndex = 153
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(119, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 147
        Me.Label4.Text = "Stock inicial"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(119, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 146
        Me.Label3.Text = "Precio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(119, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 145
        Me.Label2.Text = "Nombre"
        '
        'Departamento
        '
        Me.Departamento.AccessibleDescription = "Label1"
        Me.Departamento.AutoSize = True
        Me.Departamento.Location = New System.Drawing.Point(119, 100)
        Me.Departamento.Name = "Departamento"
        Me.Departamento.Size = New System.Drawing.Size(74, 13)
        Me.Departamento.TabIndex = 144
        Me.Departamento.Text = "Departamento"
        '
        'cmbnombre
        '
        Me.cmbnombre.Location = New System.Drawing.Point(210, 128)
        Me.cmbnombre.Name = "cmbnombre"
        Me.cmbnombre.Size = New System.Drawing.Size(100, 20)
        Me.cmbnombre.TabIndex = 157
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(210, 190)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 158
        '
        'cmbdpto
        '
        Me.cmbdpto.FormattingEnabled = True
        Me.cmbdpto.Location = New System.Drawing.Point(210, 100)
        Me.cmbdpto.Name = "cmbdpto"
        Me.cmbdpto.Size = New System.Drawing.Size(121, 21)
        Me.cmbdpto.TabIndex = 159
        '
        'txtbuscar
        '
        Me.txtbuscar.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.txtbuscar.Location = New System.Drawing.Point(210, 58)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(100, 24)
        Me.txtbuscar.TabIndex = 198
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(18, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 17)
        Me.Label1.TabIndex = 197
        Me.Label1.Text = "Ingrese  código de producto"
        '
        'btnbuscar
        '
        Me.btnbuscar.BackColor = System.Drawing.Color.DarkOrchid
        Me.btnbuscar.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.btnbuscar.Location = New System.Drawing.Point(346, 55)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnbuscar.TabIndex = 196
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.UseVisualStyleBackColor = False
        '
        'Modificarproducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 436)
        Me.Controls.Add(Me.txtbuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.cmbdpto)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.cmbnombre)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btnvolver)
        Me.Controls.Add(Me.txttipo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Departamento)
        Me.Name = "Modificarproducto"
        Me.Text = "Modificar producto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnguardar As Button
    Friend WithEvents btnvolver As Button
    Friend WithEvents txttipo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Departamento As Label
    Friend WithEvents cmbnombre As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents cmbdpto As ComboBox
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnbuscar As Button
End Class
