<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Movimientos
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnmsalir = New System.Windows.Forms.Button()
        Me.btnmeliminar = New System.Windows.Forms.Button()
        Me.btnmmodificar = New System.Windows.Forms.Button()
        Me.txtmonto = New System.Windows.Forms.TextBox()
        Me.txtdetalle = New System.Windows.Forms.TextBox()
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker()
        Me.cbmingresos = New System.Windows.Forms.ComboBox()
        Me.cbmtipo = New System.Windows.Forms.ComboBox()
        Me.txtmovimiento = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnmagregar = New System.Windows.Forms.Button()
        Me.dgvmovimiento = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dataMovimientos = New System.Windows.Forms.DataGridView()
        Me.cmconcepto = New System.Windows.Forms.ComboBox()
        Me.dthasta = New System.Windows.Forms.DateTimePicker()
        Me.dtdesde = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnmlimpiar = New System.Windows.Forms.Button()
        Me.btnmbuscar = New System.Windows.Forms.Button()
        Me.btnmvertodo = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.txtsalperiodo = New System.Windows.Forms.TextBox()
        Me.txtgasto = New System.Windows.Forms.TextBox()
        Me.txtingreso = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnsalirs = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.dehasta = New System.Windows.Forms.DateTimePicker()
        Me.dedesde = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.UNIDOSBGDataSet = New UNIDOSGENESIS.UNIDOSBGDataSet()
        Me.UNIDOSBGDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UNIDOSBGDataSet1 = New UNIDOSGENESIS.UNIDOSBGDataSet1()
        Me.PROYECTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PROYECTOSTableAdapter = New UNIDOSGENESIS.UNIDOSBGDataSet1TableAdapters.PROYECTOSTableAdapter()
        Me.UNIDOSBGDataSet2 = New UNIDOSGENESIS.UNIDOSBGDataSet2()
        Me.PROYECTOSBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PROYECTOSTableAdapter1 = New UNIDOSGENESIS.UNIDOSBGDataSet2TableAdapters.PROYECTOSTableAdapter()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvmovimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dataMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.UNIDOSBGDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UNIDOSBGDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UNIDOSBGDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROYECTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UNIDOSBGDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROYECTOSBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(805, 513)
        Me.TabControl1.TabIndex = 18
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnmsalir)
        Me.TabPage1.Controls.Add(Me.btnmeliminar)
        Me.TabPage1.Controls.Add(Me.btnmmodificar)
        Me.TabPage1.Controls.Add(Me.txtmonto)
        Me.TabPage1.Controls.Add(Me.txtdetalle)
        Me.TabPage1.Controls.Add(Me.dtpfecha)
        Me.TabPage1.Controls.Add(Me.cbmingresos)
        Me.TabPage1.Controls.Add(Me.cbmtipo)
        Me.TabPage1.Controls.Add(Me.txtmovimiento)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.btnmagregar)
        Me.TabPage1.Controls.Add(Me.dgvmovimiento)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(797, 484)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Movimientos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnmsalir
        '
        Me.btnmsalir.Location = New System.Drawing.Point(643, 137)
        Me.btnmsalir.Name = "btnmsalir"
        Me.btnmsalir.Size = New System.Drawing.Size(81, 25)
        Me.btnmsalir.TabIndex = 62
        Me.btnmsalir.Text = "Salir"
        Me.btnmsalir.UseVisualStyleBackColor = True
        '
        'btnmeliminar
        '
        Me.btnmeliminar.Location = New System.Drawing.Point(643, 108)
        Me.btnmeliminar.Name = "btnmeliminar"
        Me.btnmeliminar.Size = New System.Drawing.Size(81, 23)
        Me.btnmeliminar.TabIndex = 61
        Me.btnmeliminar.Text = "Eliminar"
        Me.btnmeliminar.UseVisualStyleBackColor = True
        '
        'btnmmodificar
        '
        Me.btnmmodificar.Location = New System.Drawing.Point(643, 79)
        Me.btnmmodificar.Name = "btnmmodificar"
        Me.btnmmodificar.Size = New System.Drawing.Size(81, 23)
        Me.btnmmodificar.TabIndex = 60
        Me.btnmmodificar.Text = "Modificar"
        Me.btnmmodificar.UseVisualStyleBackColor = True
        '
        'txtmonto
        '
        Me.txtmonto.Location = New System.Drawing.Point(285, 199)
        Me.txtmonto.Name = "txtmonto"
        Me.txtmonto.Size = New System.Drawing.Size(282, 22)
        Me.txtmonto.TabIndex = 59
        '
        'txtdetalle
        '
        Me.txtdetalle.Location = New System.Drawing.Point(285, 176)
        Me.txtdetalle.Name = "txtdetalle"
        Me.txtdetalle.Size = New System.Drawing.Size(282, 22)
        Me.txtdetalle.TabIndex = 58
        '
        'dtpfecha
        '
        Me.dtpfecha.Location = New System.Drawing.Point(285, 152)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(282, 22)
        Me.dtpfecha.TabIndex = 57
        '
        'cbmingresos
        '
        Me.cbmingresos.DataSource = Me.PROYECTOSBindingSource1
        Me.cbmingresos.DisplayMember = "Nombre"
        Me.cbmingresos.FormattingEnabled = True
        Me.cbmingresos.Location = New System.Drawing.Point(285, 125)
        Me.cbmingresos.Name = "cbmingresos"
        Me.cbmingresos.Size = New System.Drawing.Size(282, 24)
        Me.cbmingresos.TabIndex = 56
        Me.cbmingresos.ValueMember = "ProyectoID"
        '
        'cbmtipo
        '
        Me.cbmtipo.FormattingEnabled = True
        Me.cbmtipo.Items.AddRange(New Object() {"Ingresos", "Gastos"})
        Me.cbmtipo.Location = New System.Drawing.Point(285, 100)
        Me.cbmtipo.Name = "cbmtipo"
        Me.cbmtipo.Size = New System.Drawing.Size(282, 24)
        Me.cbmtipo.TabIndex = 55
        '
        'txtmovimiento
        '
        Me.txtmovimiento.Location = New System.Drawing.Point(285, 49)
        Me.txtmovimiento.Name = "txtmovimiento"
        Me.txtmovimiento.Size = New System.Drawing.Size(282, 22)
        Me.txtmovimiento.TabIndex = 54
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(199, 203)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 16)
        Me.Label12.TabIndex = 53
        Me.Label12.Text = "Monto:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(196, 180)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 16)
        Me.Label11.TabIndex = 52
        Me.Label11.Text = "Detalle:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(199, 155)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 16)
        Me.Label10.TabIndex = 51
        Me.Label10.Text = "Fecha:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(201, 130)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 16)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "Proyecto"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(211, 105)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 16)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Tipo:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(175, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 16)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Movimientoid:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(369, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 16)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "MOVIMIENTOS"
        '
        'btnmagregar
        '
        Me.btnmagregar.Location = New System.Drawing.Point(643, 49)
        Me.btnmagregar.Name = "btnmagregar"
        Me.btnmagregar.Size = New System.Drawing.Size(81, 23)
        Me.btnmagregar.TabIndex = 46
        Me.btnmagregar.Text = "Guardar"
        Me.btnmagregar.UseVisualStyleBackColor = True
        '
        'dgvmovimiento
        '
        Me.dgvmovimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvmovimiento.Location = New System.Drawing.Point(73, 238)
        Me.dgvmovimiento.Name = "dgvmovimiento"
        Me.dgvmovimiento.Size = New System.Drawing.Size(651, 240)
        Me.dgvmovimiento.TabIndex = 45
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dataMovimientos)
        Me.TabPage2.Controls.Add(Me.cmconcepto)
        Me.TabPage2.Controls.Add(Me.dthasta)
        Me.TabPage2.Controls.Add(Me.dtdesde)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.btnmlimpiar)
        Me.TabPage2.Controls.Add(Me.btnmbuscar)
        Me.TabPage2.Controls.Add(Me.btnmvertodo)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(797, 484)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Buscar"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dataMovimientos
        '
        Me.dataMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataMovimientos.Location = New System.Drawing.Point(22, 225)
        Me.dataMovimientos.Name = "dataMovimientos"
        Me.dataMovimientos.Size = New System.Drawing.Size(651, 240)
        Me.dataMovimientos.TabIndex = 46
        '
        'cmconcepto
        '
        Me.cmconcepto.FormattingEnabled = True
        Me.cmconcepto.Items.AddRange(New Object() {"Ingresos", "Gastos"})
        Me.cmconcepto.Location = New System.Drawing.Point(200, 128)
        Me.cmconcepto.Name = "cmconcepto"
        Me.cmconcepto.Size = New System.Drawing.Size(285, 24)
        Me.cmconcepto.TabIndex = 32
        '
        'dthasta
        '
        Me.dthasta.Location = New System.Drawing.Point(200, 101)
        Me.dthasta.Name = "dthasta"
        Me.dthasta.Size = New System.Drawing.Size(285, 22)
        Me.dthasta.TabIndex = 31
        '
        'dtdesde
        '
        Me.dtdesde.Location = New System.Drawing.Point(200, 79)
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
        Me.Label5.Location = New System.Drawing.Point(123, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 16)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Concepto:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(126, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 16)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Hasta:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(123, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 16)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Desde:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(270, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 16)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "BUSCAR"
        '
        'btnmlimpiar
        '
        Me.btnmlimpiar.Location = New System.Drawing.Point(314, 174)
        Me.btnmlimpiar.Name = "btnmlimpiar"
        Me.btnmlimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnmlimpiar.TabIndex = 24
        Me.btnmlimpiar.Text = "Limpiar"
        Me.btnmlimpiar.UseVisualStyleBackColor = True
        '
        'btnmbuscar
        '
        Me.btnmbuscar.Location = New System.Drawing.Point(205, 174)
        Me.btnmbuscar.Name = "btnmbuscar"
        Me.btnmbuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnmbuscar.TabIndex = 23
        Me.btnmbuscar.Text = "Buscar"
        Me.btnmbuscar.UseVisualStyleBackColor = True
        '
        'btnmvertodo
        '
        Me.btnmvertodo.Location = New System.Drawing.Point(510, 99)
        Me.btnmvertodo.Name = "btnmvertodo"
        Me.btnmvertodo.Size = New System.Drawing.Size(123, 23)
        Me.btnmvertodo.TabIndex = 21
        Me.btnmvertodo.Text = "Ver Todo"
        Me.btnmvertodo.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.txtsalperiodo)
        Me.TabPage3.Controls.Add(Me.txtgasto)
        Me.TabPage3.Controls.Add(Me.txtingreso)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Controls.Add(Me.btnsalirs)
        Me.TabPage3.Controls.Add(Me.btnsalir)
        Me.TabPage3.Controls.Add(Me.dehasta)
        Me.TabPage3.Controls.Add(Me.dedesde)
        Me.TabPage3.Controls.Add(Me.Label16)
        Me.TabPage3.Controls.Add(Me.Label17)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(797, 484)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Saldo"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'txtsalperiodo
        '
        Me.txtsalperiodo.Location = New System.Drawing.Point(478, 321)
        Me.txtsalperiodo.Name = "txtsalperiodo"
        Me.txtsalperiodo.Size = New System.Drawing.Size(142, 22)
        Me.txtsalperiodo.TabIndex = 23
        '
        'txtgasto
        '
        Me.txtgasto.Location = New System.Drawing.Point(478, 289)
        Me.txtgasto.Name = "txtgasto"
        Me.txtgasto.Size = New System.Drawing.Size(142, 22)
        Me.txtgasto.TabIndex = 22
        '
        'txtingreso
        '
        Me.txtingreso.Location = New System.Drawing.Point(478, 253)
        Me.txtingreso.Name = "txtingreso"
        Me.txtingreso.Size = New System.Drawing.Size(142, 22)
        Me.txtingreso.TabIndex = 21
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(211, 324)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(231, 16)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Saldo de periodo seleccionado;"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(209, 289)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(121, 16)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "Total de gastos:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(211, 253)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(134, 16)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "Total de Ingresos:"
        '
        'btnsalirs
        '
        Me.btnsalirs.Location = New System.Drawing.Point(661, 319)
        Me.btnsalirs.Name = "btnsalirs"
        Me.btnsalirs.Size = New System.Drawing.Size(103, 23)
        Me.btnsalirs.TabIndex = 17
        Me.btnsalirs.Text = "Salir"
        Me.btnsalirs.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(661, 158)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(103, 23)
        Me.btnsalir.TabIndex = 16
        Me.btnsalir.Text = "Ver saldo"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'dehasta
        '
        Me.dehasta.Location = New System.Drawing.Point(295, 172)
        Me.dehasta.Name = "dehasta"
        Me.dehasta.Size = New System.Drawing.Size(283, 22)
        Me.dehasta.TabIndex = 15
        '
        'dedesde
        '
        Me.dedesde.Location = New System.Drawing.Point(295, 140)
        Me.dedesde.Name = "dedesde"
        Me.dedesde.Size = New System.Drawing.Size(283, 22)
        Me.dedesde.TabIndex = 14
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(211, 177)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(53, 16)
        Me.Label16.TabIndex = 13
        Me.Label16.Text = "Hasta:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(208, 145)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(58, 16)
        Me.Label17.TabIndex = 12
        Me.Label17.Text = "Desde:"
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
        'UNIDOSBGDataSet1
        '
        Me.UNIDOSBGDataSet1.DataSetName = "UNIDOSBGDataSet1"
        Me.UNIDOSBGDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PROYECTOSBindingSource
        '
        Me.PROYECTOSBindingSource.DataMember = "PROYECTOS"
        Me.PROYECTOSBindingSource.DataSource = Me.UNIDOSBGDataSet1
        '
        'PROYECTOSTableAdapter
        '
        Me.PROYECTOSTableAdapter.ClearBeforeFill = True
        '
        'UNIDOSBGDataSet2
        '
        Me.UNIDOSBGDataSet2.DataSetName = "UNIDOSBGDataSet2"
        Me.UNIDOSBGDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PROYECTOSBindingSource1
        '
        Me.PROYECTOSBindingSource1.DataMember = "PROYECTOS"
        Me.PROYECTOSBindingSource1.DataSource = Me.UNIDOSBGDataSet2
        '
        'PROYECTOSTableAdapter1
        '
        Me.PROYECTOSTableAdapter1.ClearBeforeFill = True
        '
        'Movimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(878, 524)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Movimientos"
        Me.Text = "Movimientos"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgvmovimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dataMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.UNIDOSBGDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UNIDOSBGDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UNIDOSBGDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROYECTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UNIDOSBGDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROYECTOSBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents cmconcepto As ComboBox
    Friend WithEvents dthasta As DateTimePicker
    Friend WithEvents dtdesde As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnmlimpiar As Button
    Friend WithEvents btnmbuscar As Button
    Friend WithEvents btnmvertodo As Button
    Friend WithEvents txtmonto As TextBox
    Friend WithEvents txtdetalle As TextBox
    Friend WithEvents dtpfecha As DateTimePicker
    Friend WithEvents cbmingresos As ComboBox
    Friend WithEvents cbmtipo As ComboBox
    Friend WithEvents txtmovimiento As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnmagregar As Button
    Friend WithEvents dgvmovimiento As DataGridView
    Friend WithEvents MovimientoIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubtipoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DetalleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MontoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents txtsalperiodo As TextBox
    Friend WithEvents txtgasto As TextBox
    Friend WithEvents txtingreso As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents btnsalirs As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents dehasta As DateTimePicker
    Friend WithEvents dedesde As DateTimePicker
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents btnmsalir As Button
    Friend WithEvents btnmeliminar As Button
    Friend WithEvents btnmmodificar As Button
    Friend WithEvents dataMovimientos As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents UNIDOSBGDataSetBindingSource As BindingSource
    Friend WithEvents UNIDOSBGDataSet As UNIDOSBGDataSet
    Friend WithEvents UNIDOSBGDataSet1 As UNIDOSBGDataSet1
    Friend WithEvents PROYECTOSBindingSource As BindingSource
    Friend WithEvents PROYECTOSTableAdapter As UNIDOSBGDataSet1TableAdapters.PROYECTOSTableAdapter
    Friend WithEvents UNIDOSBGDataSet2 As UNIDOSBGDataSet2
    Friend WithEvents PROYECTOSBindingSource1 As BindingSource
    Friend WithEvents PROYECTOSTableAdapter1 As UNIDOSBGDataSet2TableAdapters.PROYECTOSTableAdapter
End Class
