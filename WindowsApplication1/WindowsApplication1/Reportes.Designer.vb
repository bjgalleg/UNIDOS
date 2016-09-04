<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reportes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reportes))
        Me.txtsalperiodo = New System.Windows.Forms.TextBox()
        Me.txtgasto = New System.Windows.Forms.TextBox()
        Me.txtingreso = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmbtipo = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.dataMovimientos = New System.Windows.Forms.DataGridView()
        Me.cmbproyecto = New System.Windows.Forms.ComboBox()
        Me.dthasta = New System.Windows.Forms.DateTimePicker()
        Me.dtdesde = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnmlimpiar = New System.Windows.Forms.Button()
        Me.btnmbuscar = New System.Windows.Forms.Button()
        Me.btnmvertodo = New System.Windows.Forms.Button()
        CType(Me.dataMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtsalperiodo
        '
        Me.txtsalperiodo.Location = New System.Drawing.Point(669, 114)
        Me.txtsalperiodo.Name = "txtsalperiodo"
        Me.txtsalperiodo.Size = New System.Drawing.Size(142, 20)
        Me.txtsalperiodo.TabIndex = 77
        '
        'txtgasto
        '
        Me.txtgasto.Location = New System.Drawing.Point(669, 82)
        Me.txtgasto.Name = "txtgasto"
        Me.txtgasto.Size = New System.Drawing.Size(142, 20)
        Me.txtgasto.TabIndex = 76
        '
        'txtingreso
        '
        Me.txtingreso.Location = New System.Drawing.Point(669, 46)
        Me.txtingreso.Name = "txtingreso"
        Me.txtingreso.Size = New System.Drawing.Size(142, 20)
        Me.txtingreso.TabIndex = 75
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(429, 120)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(156, 13)
        Me.Label13.TabIndex = 74
        Me.Label13.Text = "Saldo de periodo seleccionado;"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(427, 85)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(83, 13)
        Me.Label14.TabIndex = 73
        Me.Label14.Text = "Total de gastos:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(429, 49)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(92, 13)
        Me.Label15.TabIndex = 72
        Me.Label15.Text = "Total de Ingresos:"
        '
        'cmbtipo
        '
        Me.cmbtipo.FormattingEnabled = True
        Me.cmbtipo.Items.AddRange(New Object() {"Ingresos", "Gastos"})
        Me.cmbtipo.Location = New System.Drawing.Point(127, 121)
        Me.cmbtipo.Name = "cmbtipo"
        Me.cmbtipo.Size = New System.Drawing.Size(285, 21)
        Me.cmbtipo.TabIndex = 71
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(89, 136)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(0, 13)
        Me.Label18.TabIndex = 70
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(51, 124)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(28, 13)
        Me.Label19.TabIndex = 69
        Me.Label19.Text = "Tipo"
        '
        'dataMovimientos
        '
        Me.dataMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataMovimientos.Location = New System.Drawing.Point(53, 227)
        Me.dataMovimientos.Name = "dataMovimientos"
        Me.dataMovimientos.Size = New System.Drawing.Size(651, 240)
        Me.dataMovimientos.TabIndex = 68
        '
        'cmbproyecto
        '
        Me.cmbproyecto.FormattingEnabled = True
        Me.cmbproyecto.Items.AddRange(New Object() {"Ingresos", "Gastos"})
        Me.cmbproyecto.Location = New System.Drawing.Point(127, 93)
        Me.cmbproyecto.Name = "cmbproyecto"
        Me.cmbproyecto.Size = New System.Drawing.Size(285, 21)
        Me.cmbproyecto.TabIndex = 67
        '
        'dthasta
        '
        Me.dthasta.Location = New System.Drawing.Point(127, 66)
        Me.dthasta.Name = "dthasta"
        Me.dthasta.Size = New System.Drawing.Size(285, 20)
        Me.dthasta.TabIndex = 66
        '
        'dtdesde
        '
        Me.dtdesde.Location = New System.Drawing.Point(127, 44)
        Me.dtdesde.Name = "dtdesde"
        Me.dtdesde.Size = New System.Drawing.Size(285, 20)
        Me.dtdesde.TabIndex = 65
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(89, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 13)
        Me.Label6.TabIndex = 64
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(51, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Proyecto"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Hasta:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Desde:"
        '
        'btnmlimpiar
        '
        Me.btnmlimpiar.Location = New System.Drawing.Point(299, 176)
        Me.btnmlimpiar.Name = "btnmlimpiar"
        Me.btnmlimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnmlimpiar.TabIndex = 60
        Me.btnmlimpiar.Text = "Limpiar"
        Me.btnmlimpiar.UseVisualStyleBackColor = True
        '
        'btnmbuscar
        '
        Me.btnmbuscar.Location = New System.Drawing.Point(195, 176)
        Me.btnmbuscar.Name = "btnmbuscar"
        Me.btnmbuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnmbuscar.TabIndex = 59
        Me.btnmbuscar.Text = "Buscar"
        Me.btnmbuscar.UseVisualStyleBackColor = True
        '
        'btnmvertodo
        '
        Me.btnmvertodo.Location = New System.Drawing.Point(53, 176)
        Me.btnmvertodo.Name = "btnmvertodo"
        Me.btnmvertodo.Size = New System.Drawing.Size(123, 23)
        Me.btnmvertodo.TabIndex = 58
        Me.btnmvertodo.Text = "Ver Todo"
        Me.btnmvertodo.UseVisualStyleBackColor = True
        '
        'Reportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(861, 510)
        Me.Controls.Add(Me.txtsalperiodo)
        Me.Controls.Add(Me.txtgasto)
        Me.Controls.Add(Me.txtingreso)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.cmbtipo)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.dataMovimientos)
        Me.Controls.Add(Me.cmbproyecto)
        Me.Controls.Add(Me.dthasta)
        Me.Controls.Add(Me.dtdesde)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnmlimpiar)
        Me.Controls.Add(Me.btnmbuscar)
        Me.Controls.Add(Me.btnmvertodo)
        Me.Name = "Reportes"
        Me.Text = "Reportes"
        CType(Me.dataMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtsalperiodo As TextBox
    Friend WithEvents txtgasto As TextBox
    Friend WithEvents txtingreso As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents cmbtipo As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents dataMovimientos As DataGridView
    Friend WithEvents cmbproyecto As ComboBox
    Friend WithEvents dthasta As DateTimePicker
    Friend WithEvents dtdesde As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnmlimpiar As Button
    Friend WithEvents btnmbuscar As Button
    Friend WithEvents btnmvertodo As Button
End Class
