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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Saldos = New System.Windows.Forms.TabPage()
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
        Me.cmbtipo = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtsalperiodo = New System.Windows.Forms.TextBox()
        Me.txtgasto = New System.Windows.Forms.TextBox()
        Me.txtingreso = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnsalirs = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.Saldos.SuspendLayout()
        CType(Me.dataMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Saldos)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(28, -1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(805, 513)
        Me.TabControl1.TabIndex = 19
        '
        'Saldos
        '
        Me.Saldos.Controls.Add(Me.txtsalperiodo)
        Me.Saldos.Controls.Add(Me.txtgasto)
        Me.Saldos.Controls.Add(Me.txtingreso)
        Me.Saldos.Controls.Add(Me.Label13)
        Me.Saldos.Controls.Add(Me.Label14)
        Me.Saldos.Controls.Add(Me.Label15)
        Me.Saldos.Controls.Add(Me.btnsalirs)
        Me.Saldos.Controls.Add(Me.btnsalir)
        Me.Saldos.Controls.Add(Me.cmbtipo)
        Me.Saldos.Controls.Add(Me.Label18)
        Me.Saldos.Controls.Add(Me.Label19)
        Me.Saldos.Controls.Add(Me.dataMovimientos)
        Me.Saldos.Controls.Add(Me.cmbproyecto)
        Me.Saldos.Controls.Add(Me.dthasta)
        Me.Saldos.Controls.Add(Me.dtdesde)
        Me.Saldos.Controls.Add(Me.Label6)
        Me.Saldos.Controls.Add(Me.Label5)
        Me.Saldos.Controls.Add(Me.Label4)
        Me.Saldos.Controls.Add(Me.Label3)
        Me.Saldos.Controls.Add(Me.btnmlimpiar)
        Me.Saldos.Controls.Add(Me.btnmbuscar)
        Me.Saldos.Controls.Add(Me.btnmvertodo)
        Me.Saldos.Location = New System.Drawing.Point(4, 25)
        Me.Saldos.Name = "Saldos"
        Me.Saldos.Padding = New System.Windows.Forms.Padding(3)
        Me.Saldos.Size = New System.Drawing.Size(797, 484)
        Me.Saldos.TabIndex = 1
        Me.Saldos.Text = "REPORTES"
        Me.Saldos.UseVisualStyleBackColor = True
        '
        'dataMovimientos
        '
        Me.dataMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataMovimientos.Location = New System.Drawing.Point(22, 225)
        Me.dataMovimientos.Name = "dataMovimientos"
        Me.dataMovimientos.Size = New System.Drawing.Size(651, 240)
        Me.dataMovimientos.TabIndex = 46
        '
        'cmbproyecto
        '
        Me.cmbproyecto.FormattingEnabled = True
        Me.cmbproyecto.Items.AddRange(New Object() {"Ingresos", "Gastos"})
        Me.cmbproyecto.Location = New System.Drawing.Point(96, 91)
        Me.cmbproyecto.Name = "cmbproyecto"
        Me.cmbproyecto.Size = New System.Drawing.Size(285, 24)
        Me.cmbproyecto.TabIndex = 32
        '
        'dthasta
        '
        Me.dthasta.Location = New System.Drawing.Point(96, 64)
        Me.dthasta.Name = "dthasta"
        Me.dthasta.Size = New System.Drawing.Size(285, 22)
        Me.dthasta.TabIndex = 31
        '
        'dtdesde
        '
        Me.dtdesde.Location = New System.Drawing.Point(96, 42)
        Me.dtdesde.Name = "dtdesde"
        Me.dtdesde.Size = New System.Drawing.Size(285, 22)
        Me.dtdesde.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(58, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 16)
        Me.Label6.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 16)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Proyecto"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 16)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Hasta:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 16)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Desde:"
        '
        'btnmlimpiar
        '
        Me.btnmlimpiar.Location = New System.Drawing.Point(268, 174)
        Me.btnmlimpiar.Name = "btnmlimpiar"
        Me.btnmlimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnmlimpiar.TabIndex = 24
        Me.btnmlimpiar.Text = "Limpiar"
        Me.btnmlimpiar.UseVisualStyleBackColor = True
        '
        'btnmbuscar
        '
        Me.btnmbuscar.Location = New System.Drawing.Point(164, 174)
        Me.btnmbuscar.Name = "btnmbuscar"
        Me.btnmbuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnmbuscar.TabIndex = 23
        Me.btnmbuscar.Text = "Buscar"
        Me.btnmbuscar.UseVisualStyleBackColor = True
        '
        'btnmvertodo
        '
        Me.btnmvertodo.Location = New System.Drawing.Point(22, 174)
        Me.btnmvertodo.Name = "btnmvertodo"
        Me.btnmvertodo.Size = New System.Drawing.Size(123, 23)
        Me.btnmvertodo.TabIndex = 21
        Me.btnmvertodo.Text = "Ver Todo"
        Me.btnmvertodo.UseVisualStyleBackColor = True
        '
        'cmbtipo
        '
        Me.cmbtipo.FormattingEnabled = True
        Me.cmbtipo.Items.AddRange(New Object() {"Ingresos", "Gastos"})
        Me.cmbtipo.Location = New System.Drawing.Point(96, 119)
        Me.cmbtipo.Name = "cmbtipo"
        Me.cmbtipo.Size = New System.Drawing.Size(285, 24)
        Me.cmbtipo.TabIndex = 49
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(58, 134)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(0, 16)
        Me.Label18.TabIndex = 48
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(20, 122)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(40, 16)
        Me.Label19.TabIndex = 47
        Me.Label19.Text = "Tipo"
        '
        'txtsalperiodo
        '
        Me.txtsalperiodo.Location = New System.Drawing.Point(638, 112)
        Me.txtsalperiodo.Name = "txtsalperiodo"
        Me.txtsalperiodo.Size = New System.Drawing.Size(142, 22)
        Me.txtsalperiodo.TabIndex = 57
        '
        'txtgasto
        '
        Me.txtgasto.Location = New System.Drawing.Point(638, 80)
        Me.txtgasto.Name = "txtgasto"
        Me.txtgasto.Size = New System.Drawing.Size(142, 22)
        Me.txtgasto.TabIndex = 56
        '
        'txtingreso
        '
        Me.txtingreso.Location = New System.Drawing.Point(638, 44)
        Me.txtingreso.Name = "txtingreso"
        Me.txtingreso.Size = New System.Drawing.Size(142, 22)
        Me.txtingreso.TabIndex = 55
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(398, 118)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(231, 16)
        Me.Label13.TabIndex = 54
        Me.Label13.Text = "Saldo de periodo seleccionado;"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(396, 83)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(121, 16)
        Me.Label14.TabIndex = 53
        Me.Label14.Text = "Total de gastos:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(398, 47)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(134, 16)
        Me.Label15.TabIndex = 52
        Me.Label15.Text = "Total de Ingresos:"
        '
        'btnsalirs
        '
        Me.btnsalirs.Location = New System.Drawing.Point(930, 116)
        Me.btnsalirs.Name = "btnsalirs"
        Me.btnsalirs.Size = New System.Drawing.Size(103, 23)
        Me.btnsalirs.TabIndex = 51
        Me.btnsalirs.Text = "Salir"
        Me.btnsalirs.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(930, 47)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(103, 23)
        Me.btnsalir.TabIndex = 50
        Me.btnsalir.Text = "Ver saldo"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'Reportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(861, 510)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Reportes"
        Me.Text = "Reportes"
        Me.TabControl1.ResumeLayout(False)
        Me.Saldos.ResumeLayout(False)
        Me.Saldos.PerformLayout()
        CType(Me.dataMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Saldos As TabPage
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
    Friend WithEvents cmbtipo As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents txtsalperiodo As TextBox
    Friend WithEvents txtgasto As TextBox
    Friend WithEvents txtingreso As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents btnsalirs As Button
    Friend WithEvents btnsalir As Button
End Class
