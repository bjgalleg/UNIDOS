<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modificar_Departamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Modificar_Departamento))
        Me.txtproyectoid = New System.Windows.Forms.ComboBox()
        Me.PROYECTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UNIDOSBGDataSet = New UNIDOSGENESIS.UNIDOSBGDataSet()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtmovimientoid = New System.Windows.Forms.ComboBox()
        Me.MOVIMIENTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbresponsable = New System.Windows.Forms.ComboBox()
        Me.txtfunciones = New System.Windows.Forms.TextBox()
        Me.txtnombredpto = New System.Windows.Forms.TextBox()
        Me.dgvdepartamento = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnvolver = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnbusdepart = New System.Windows.Forms.Button()
        Me.MOVIMIENTOSTableAdapter = New UNIDOSGENESIS.UNIDOSBGDataSetTableAdapters.MOVIMIENTOSTableAdapter()
        Me.PROYECTOSTableAdapter = New UNIDOSGENESIS.UNIDOSBGDataSetTableAdapters.PROYECTOSTableAdapter()
        CType(Me.PROYECTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UNIDOSBGDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MOVIMIENTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvdepartamento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtproyectoid
        '
        Me.txtproyectoid.DataSource = Me.PROYECTOSBindingSource
        Me.txtproyectoid.DisplayMember = "ProyectoID"
        Me.txtproyectoid.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtproyectoid.ForeColor = System.Drawing.Color.Black
        Me.txtproyectoid.FormattingEnabled = True
        Me.txtproyectoid.Location = New System.Drawing.Point(375, 237)
        Me.txtproyectoid.Name = "txtproyectoid"
        Me.txtproyectoid.Size = New System.Drawing.Size(224, 23)
        Me.txtproyectoid.TabIndex = 44
        '
        'PROYECTOSBindingSource
        '
        Me.PROYECTOSBindingSource.DataMember = "PROYECTOS"
        Me.PROYECTOSBindingSource.DataSource = Me.UNIDOSBGDataSet
        '
        'UNIDOSBGDataSet
        '
        Me.UNIDOSBGDataSet.DataSetName = "UNIDOSBGDataSet"
        Me.UNIDOSBGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(99, 245)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 17)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "ProyectoID"
        '
        'txtmovimientoid
        '
        Me.txtmovimientoid.DataSource = Me.MOVIMIENTOSBindingSource
        Me.txtmovimientoid.DisplayMember = "MovimientoID"
        Me.txtmovimientoid.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmovimientoid.ForeColor = System.Drawing.Color.Black
        Me.txtmovimientoid.FormattingEnabled = True
        Me.txtmovimientoid.Location = New System.Drawing.Point(375, 200)
        Me.txtmovimientoid.Name = "txtmovimientoid"
        Me.txtmovimientoid.Size = New System.Drawing.Size(224, 23)
        Me.txtmovimientoid.TabIndex = 42
        '
        'MOVIMIENTOSBindingSource
        '
        Me.MOVIMIENTOSBindingSource.DataMember = "MOVIMIENTOS"
        Me.MOVIMIENTOSBindingSource.DataSource = Me.UNIDOSBGDataSet
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(99, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 17)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "MovimientoID"
        '
        'cmbresponsable
        '
        Me.cmbresponsable.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbresponsable.ForeColor = System.Drawing.Color.Black
        Me.cmbresponsable.FormattingEnabled = True
        Me.cmbresponsable.Location = New System.Drawing.Point(375, 161)
        Me.cmbresponsable.Name = "cmbresponsable"
        Me.cmbresponsable.Size = New System.Drawing.Size(224, 23)
        Me.cmbresponsable.TabIndex = 38
        '
        'txtfunciones
        '
        Me.txtfunciones.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfunciones.ForeColor = System.Drawing.Color.Black
        Me.txtfunciones.Location = New System.Drawing.Point(375, 121)
        Me.txtfunciones.Name = "txtfunciones"
        Me.txtfunciones.Size = New System.Drawing.Size(224, 22)
        Me.txtfunciones.TabIndex = 37
        '
        'txtnombredpto
        '
        Me.txtnombredpto.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombredpto.ForeColor = System.Drawing.Color.Black
        Me.txtnombredpto.Location = New System.Drawing.Point(375, 82)
        Me.txtnombredpto.Name = "txtnombredpto"
        Me.txtnombredpto.Size = New System.Drawing.Size(224, 22)
        Me.txtnombredpto.TabIndex = 36
        '
        'dgvdepartamento
        '
        Me.dgvdepartamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdepartamento.Location = New System.Drawing.Point(94, 303)
        Me.dgvdepartamento.Name = "dgvdepartamento"
        Me.dgvdepartamento.Size = New System.Drawing.Size(505, 88)
        Me.dgvdepartamento.TabIndex = 35
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(99, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 17)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Responsable"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(97, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(197, 17)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Descripcion de funciones"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(97, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 17)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Nombre del departamento"
        '
        'btnvolver
        '
        Me.btnvolver.BackColor = System.Drawing.Color.DarkRed
        Me.btnvolver.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnvolver.ForeColor = System.Drawing.Color.White
        Me.btnvolver.Location = New System.Drawing.Point(424, 408)
        Me.btnvolver.Name = "btnvolver"
        Me.btnvolver.Size = New System.Drawing.Size(102, 39)
        Me.btnvolver.TabIndex = 31
        Me.btnvolver.Text = "Volver"
        Me.btnvolver.UseVisualStyleBackColor = False
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.DarkRed
        Me.btnguardar.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.ForeColor = System.Drawing.Color.White
        Me.btnguardar.Location = New System.Drawing.Point(218, 408)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(102, 39)
        Me.btnguardar.TabIndex = 30
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'txtbuscar
        '
        Me.txtbuscar.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbuscar.ForeColor = System.Drawing.Color.White
        Me.txtbuscar.Location = New System.Drawing.Point(377, 48)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(173, 22)
        Me.txtbuscar.TabIndex = 46
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(97, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(263, 17)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Ingrese Codigo del Departamento"
        '
        'btnbusdepart
        '
        Me.btnbusdepart.BackColor = System.Drawing.Color.DarkRed
        Me.btnbusdepart.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbusdepart.ForeColor = System.Drawing.Color.White
        Me.btnbusdepart.Location = New System.Drawing.Point(576, 50)
        Me.btnbusdepart.Name = "btnbusdepart"
        Me.btnbusdepart.Size = New System.Drawing.Size(75, 23)
        Me.btnbusdepart.TabIndex = 47
        Me.btnbusdepart.Text = "Buscar"
        Me.btnbusdepart.UseVisualStyleBackColor = False
        '
        'MOVIMIENTOSTableAdapter
        '
        Me.MOVIMIENTOSTableAdapter.ClearBeforeFill = True
        '
        'PROYECTOSTableAdapter
        '
        Me.PROYECTOSTableAdapter.ClearBeforeFill = True
        '
        'Modificar_Departamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(675, 457)
        Me.Controls.Add(Me.btnbusdepart)
        Me.Controls.Add(Me.txtbuscar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtproyectoid)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtmovimientoid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbresponsable)
        Me.Controls.Add(Me.txtfunciones)
        Me.Controls.Add(Me.txtnombredpto)
        Me.Controls.Add(Me.dgvdepartamento)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnvolver)
        Me.Controls.Add(Me.btnguardar)
        Me.Name = "Modificar_Departamento"
        Me.Text = "Modificar_Departamento"
        CType(Me.PROYECTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UNIDOSBGDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MOVIMIENTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvdepartamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtproyectoid As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtmovimientoid As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbresponsable As ComboBox
    Friend WithEvents txtfunciones As TextBox
    Friend WithEvents txtnombredpto As TextBox
    Friend WithEvents dgvdepartamento As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnvolver As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnbusdepart As Button
    Friend WithEvents UNIDOSBGDataSet As UNIDOSBGDataSet
    Friend WithEvents MOVIMIENTOSBindingSource As BindingSource
    Friend WithEvents MOVIMIENTOSTableAdapter As UNIDOSBGDataSetTableAdapters.MOVIMIENTOSTableAdapter
    Friend WithEvents PROYECTOSBindingSource As BindingSource
    Friend WithEvents PROYECTOSTableAdapter As UNIDOSBGDataSetTableAdapters.PROYECTOSTableAdapter
End Class
