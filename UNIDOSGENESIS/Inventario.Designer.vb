<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventario
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inventario))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtcedula = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.btnmsalir = New System.Windows.Forms.Button()
        Me.btnmeliminar = New System.Windows.Forms.Button()
        Me.btnmmodificar = New System.Windows.Forms.Button()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.cmcategoriaid = New System.Windows.Forms.ComboBox()
        Me.CATEGORIABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UNIDOSBGDataSet = New UNIDOSGENESIS.UNIDOSBGDataSet()
        Me.txtproductoid = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnmagregar = New System.Windows.Forms.Button()
        Me.dataproducto = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txnombre = New System.Windows.Forms.TextBox()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txcategoriaid = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.datacategoria = New System.Windows.Forms.DataGridView()
        Me.CATEGORIATableAdapter = New UNIDOSGENESIS.UNIDOSBGDataSetTableAdapters.CATEGORIATableAdapter()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.CATEGORIABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UNIDOSBGDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataproducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.datacategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(750, 517)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtcedula)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txtprecio)
        Me.TabPage1.Controls.Add(Me.txtnombre)
        Me.TabPage1.Controls.Add(Me.btnmsalir)
        Me.TabPage1.Controls.Add(Me.btnmeliminar)
        Me.TabPage1.Controls.Add(Me.btnmmodificar)
        Me.TabPage1.Controls.Add(Me.txtcantidad)
        Me.TabPage1.Controls.Add(Me.cmcategoriaid)
        Me.TabPage1.Controls.Add(Me.txtproductoid)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.btnmagregar)
        Me.TabPage1.Controls.Add(Me.dataproducto)
        Me.TabPage1.Location = New System.Drawing.Point(26, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(720, 509)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Productos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtcedula
        '
        Me.txtcedula.Location = New System.Drawing.Point(279, 168)
        Me.txtcedula.Name = "txtcedula"
        Me.txtcedula.Size = New System.Drawing.Size(200, 22)
        Me.txtcedula.TabIndex = 84
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(179, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 15)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Cedula"
        '
        'txtprecio
        '
        Me.txtprecio.Location = New System.Drawing.Point(279, 202)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(200, 22)
        Me.txtprecio.TabIndex = 82
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(279, 103)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(200, 22)
        Me.txtnombre.TabIndex = 81
        '
        'btnmsalir
        '
        Me.btnmsalir.Location = New System.Drawing.Point(546, 176)
        Me.btnmsalir.Name = "btnmsalir"
        Me.btnmsalir.Size = New System.Drawing.Size(83, 23)
        Me.btnmsalir.TabIndex = 80
        Me.btnmsalir.Text = "Salir"
        Me.btnmsalir.UseVisualStyleBackColor = True
        '
        'btnmeliminar
        '
        Me.btnmeliminar.Location = New System.Drawing.Point(546, 147)
        Me.btnmeliminar.Name = "btnmeliminar"
        Me.btnmeliminar.Size = New System.Drawing.Size(83, 23)
        Me.btnmeliminar.TabIndex = 79
        Me.btnmeliminar.Text = "Eliminar"
        Me.btnmeliminar.UseVisualStyleBackColor = True
        '
        'btnmmodificar
        '
        Me.btnmmodificar.Location = New System.Drawing.Point(546, 118)
        Me.btnmmodificar.Name = "btnmmodificar"
        Me.btnmmodificar.Size = New System.Drawing.Size(83, 23)
        Me.btnmmodificar.TabIndex = 78
        Me.btnmmodificar.Text = "Modificar"
        Me.btnmmodificar.UseVisualStyleBackColor = True
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(279, 230)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(200, 22)
        Me.txtcantidad.TabIndex = 76
        '
        'cmcategoriaid
        '
        Me.cmcategoriaid.DataSource = Me.CATEGORIABindingSource
        Me.cmcategoriaid.DisplayMember = "CategoriaID"
        Me.cmcategoriaid.FormattingEnabled = True
        Me.cmcategoriaid.Location = New System.Drawing.Point(279, 133)
        Me.cmcategoriaid.Name = "cmcategoriaid"
        Me.cmcategoriaid.Size = New System.Drawing.Size(200, 23)
        Me.cmcategoriaid.TabIndex = 74
        Me.cmcategoriaid.ValueMember = "CategoriaID"
        '
        'CATEGORIABindingSource
        '
        Me.CATEGORIABindingSource.DataMember = "CATEGORIA"
        Me.CATEGORIABindingSource.DataSource = Me.UNIDOSBGDataSet
        '
        'UNIDOSBGDataSet
        '
        Me.UNIDOSBGDataSet.DataSetName = "UNIDOSBGDataSet"
        Me.UNIDOSBGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtproductoid
        '
        Me.txtproductoid.Location = New System.Drawing.Point(279, 58)
        Me.txtproductoid.Name = "txtproductoid"
        Me.txtproductoid.Size = New System.Drawing.Size(200, 22)
        Me.txtproductoid.TabIndex = 72
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(179, 230)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 15)
        Me.Label11.TabIndex = 70
        Me.Label11.Text = "Cantidad"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(179, 202)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 15)
        Me.Label10.TabIndex = 69
        Me.Label10.Text = "Precio"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(173, 133)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 15)
        Me.Label9.TabIndex = 68
        Me.Label9.Text = "CategoriaID"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(179, 103)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 15)
        Me.Label8.TabIndex = 67
        Me.Label8.Text = "Nombre"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(179, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 15)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "ProductoID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(311, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 15)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "PRODUCTOS"
        '
        'btnmagregar
        '
        Me.btnmagregar.Location = New System.Drawing.Point(546, 88)
        Me.btnmagregar.Name = "btnmagregar"
        Me.btnmagregar.Size = New System.Drawing.Size(83, 23)
        Me.btnmagregar.TabIndex = 64
        Me.btnmagregar.Text = "Guardar"
        Me.btnmagregar.UseVisualStyleBackColor = True
        '
        'dataproducto
        '
        Me.dataproducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataproducto.Location = New System.Drawing.Point(45, 258)
        Me.dataproducto.Name = "dataproducto"
        Me.dataproducto.Size = New System.Drawing.Size(651, 210)
        Me.dataproducto.TabIndex = 63
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txnombre)
        Me.TabPage2.Controls.Add(Me.txtdescripcion)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.txcategoriaid)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.Button4)
        Me.TabPage2.Controls.Add(Me.datacategoria)
        Me.TabPage2.Location = New System.Drawing.Point(26, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(720, 509)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Categoria"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txnombre
        '
        Me.txnombre.Location = New System.Drawing.Point(251, 112)
        Me.txnombre.Name = "txnombre"
        Me.txnombre.Size = New System.Drawing.Size(200, 22)
        Me.txnombre.TabIndex = 100
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Location = New System.Drawing.Point(251, 140)
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(200, 22)
        Me.txtdescripcion.TabIndex = 99
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(497, 141)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 23)
        Me.Button1.TabIndex = 98
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(497, 112)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(82, 23)
        Me.Button2.TabIndex = 97
        Me.Button2.Text = "Eliminar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(497, 83)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(82, 23)
        Me.Button3.TabIndex = 96
        Me.Button3.Text = "Modificar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txcategoriaid
        '
        Me.txcategoriaid.Location = New System.Drawing.Point(251, 53)
        Me.txcategoriaid.Name = "txcategoriaid"
        Me.txcategoriaid.Size = New System.Drawing.Size(200, 22)
        Me.txcategoriaid.TabIndex = 90
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(116, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 15)
        Me.Label5.TabIndex = 86
        Me.Label5.Text = "Descripcion:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(116, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 15)
        Me.Label6.TabIndex = 85
        Me.Label6.Text = "Nombre:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(116, 56)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(91, 15)
        Me.Label13.TabIndex = 84
        Me.Label13.Text = "CategoriaID:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(301, 12)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(91, 15)
        Me.Label14.TabIndex = 83
        Me.Label14.Text = "CATEGORIA"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(497, 53)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(82, 23)
        Me.Button4.TabIndex = 82
        Me.Button4.Text = "Guardar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'datacategoria
        '
        Me.datacategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datacategoria.Location = New System.Drawing.Point(45, 193)
        Me.datacategoria.Name = "datacategoria"
        Me.datacategoria.Size = New System.Drawing.Size(651, 240)
        Me.datacategoria.TabIndex = 81
        '
        'CATEGORIATableAdapter
        '
        Me.CATEGORIATableAdapter.ClearBeforeFill = True
        '
        'Inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(764, 530)
        Me.Controls.Add(Me.TabControl1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "Inventario"
        Me.Text = "Inventario"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.CATEGORIABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UNIDOSBGDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataproducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.datacategoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnmsalir As Button
    Friend WithEvents btnmeliminar As Button
    Friend WithEvents btnmmodificar As Button
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents cmcategoriaid As ComboBox
    Friend WithEvents txtproductoid As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnmagregar As Button
    Friend WithEvents dataproducto As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents txcategoriaid As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents datacategoria As DataGridView
    Friend WithEvents txtprecio As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txnombre As TextBox
    Friend WithEvents txtdescripcion As TextBox
    Friend WithEvents txtcedula As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents UNIDOSBGDataSet As UNIDOSBGDataSet
    Friend WithEvents CATEGORIABindingSource As BindingSource
    Friend WithEvents CATEGORIATableAdapter As UNIDOSBGDataSetTableAdapters.CATEGORIATableAdapter
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
