<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gastos
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
        Me.txttipo = New System.Windows.Forms.TextBox()
        Me.fecha = New System.Windows.Forms.DateTimePicker()
        Me.txtmonto = New System.Windows.Forms.TextBox()
        Me.txtdetalle = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtproyecto = New System.Windows.Forms.ComboBox()
        Me.txtsubtipo = New System.Windows.Forms.ComboBox()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btnvolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txttipo
        '
        Me.txttipo.Location = New System.Drawing.Point(147, 103)
        Me.txttipo.Name = "txttipo"
        Me.txttipo.Size = New System.Drawing.Size(100, 20)
        Me.txttipo.TabIndex = 24
        Me.txttipo.Text = "Gasto"
        '
        'fecha
        '
        Me.fecha.Location = New System.Drawing.Point(147, 190)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(200, 20)
        Me.fecha.TabIndex = 23
        '
        'txtmonto
        '
        Me.txtmonto.Location = New System.Drawing.Point(147, 227)
        Me.txtmonto.Name = "txtmonto"
        Me.txtmonto.Size = New System.Drawing.Size(100, 20)
        Me.txtmonto.TabIndex = 22
        '
        'txtdetalle
        '
        Me.txtdetalle.Location = New System.Drawing.Point(147, 257)
        Me.txtdetalle.Name = "txtdetalle"
        Me.txtdetalle.Size = New System.Drawing.Size(100, 20)
        Me.txtdetalle.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(56, 257)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Detalle"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(56, 227)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Monto"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(56, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Fecha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "ProyectoID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Subtipo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Tipo"
        '
        'txtproyecto
        '
        Me.txtproyecto.FormattingEnabled = True
        Me.txtproyecto.Location = New System.Drawing.Point(147, 162)
        Me.txtproyecto.Name = "txtproyecto"
        Me.txtproyecto.Size = New System.Drawing.Size(121, 21)
        Me.txtproyecto.TabIndex = 14
        '
        'txtsubtipo
        '
        Me.txtsubtipo.FormattingEnabled = True
        Me.txtsubtipo.Items.AddRange(New Object() {"Gasto administrativos", "Gastos operativos"})
        Me.txtsubtipo.Location = New System.Drawing.Point(147, 133)
        Me.txtsubtipo.Name = "txtsubtipo"
        Me.txtsubtipo.Size = New System.Drawing.Size(121, 21)
        Me.txtsubtipo.TabIndex = 13
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.DarkOrchid
        Me.btnguardar.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.btnguardar.Location = New System.Drawing.Point(93, 306)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(99, 23)
        Me.btnguardar.TabIndex = 141
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'btnvolver
        '
        Me.btnvolver.BackColor = System.Drawing.Color.DarkOrchid
        Me.btnvolver.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.btnvolver.Location = New System.Drawing.Point(198, 306)
        Me.btnvolver.Name = "btnvolver"
        Me.btnvolver.Size = New System.Drawing.Size(103, 23)
        Me.btnvolver.TabIndex = 140
        Me.btnvolver.Text = "Volver"
        Me.btnvolver.UseVisualStyleBackColor = False
        '
        'Gastos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 380)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btnvolver)
        Me.Controls.Add(Me.txttipo)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(Me.txtmonto)
        Me.Controls.Add(Me.txtdetalle)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtproyecto)
        Me.Controls.Add(Me.txtsubtipo)
        Me.Name = "Gastos"
        Me.Text = "Gastos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txttipo As TextBox
    Friend WithEvents fecha As DateTimePicker
    Friend WithEvents txtmonto As TextBox
    Friend WithEvents txtdetalle As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtproyecto As ComboBox
    Friend WithEvents txtsubtipo As ComboBox
    Friend WithEvents btnguardar As Button
    Friend WithEvents btnvolver As Button
End Class
