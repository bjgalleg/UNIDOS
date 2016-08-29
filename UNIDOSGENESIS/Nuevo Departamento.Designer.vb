<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Nuevo_Departamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Nuevo_Departamento))
        Me.cmbresponsable = New System.Windows.Forms.ComboBox()
        Me.PERSONASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UNIDOSBGDataSet = New UNIDOSGENESIS.UNIDOSBGDataSet()
        Me.txtfunciones = New System.Windows.Forms.TextBox()
        Me.txtnombredpto = New System.Windows.Forms.TextBox()
        Me.dgvdepartamento = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnvolver = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.MOVIMIENTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PROYECTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MOVIMIENTOSTableAdapter = New UNIDOSGENESIS.UNIDOSBGDataSetTableAdapters.MOVIMIENTOSTableAdapter()
        Me.MOVIMIENTOSBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PROYECTOSTableAdapter = New UNIDOSGENESIS.UNIDOSBGDataSetTableAdapters.PROYECTOSTableAdapter()
        Me.PERSONASTableAdapter = New UNIDOSGENESIS.UNIDOSBGDataSetTableAdapters.PERSONASTableAdapter()
        CType(Me.PERSONASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UNIDOSBGDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvdepartamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MOVIMIENTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROYECTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MOVIMIENTOSBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbresponsable
        '
        Me.cmbresponsable.DataSource = Me.PERSONASBindingSource
        Me.cmbresponsable.DisplayMember = "Nombres"
        Me.cmbresponsable.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbresponsable.FormattingEnabled = True
        Me.cmbresponsable.Location = New System.Drawing.Point(244, 105)
        Me.cmbresponsable.Name = "cmbresponsable"
        Me.cmbresponsable.Size = New System.Drawing.Size(224, 25)
        Me.cmbresponsable.TabIndex = 23
        '
        'PERSONASBindingSource
        '
        Me.PERSONASBindingSource.DataMember = "PERSONAS"
        Me.PERSONASBindingSource.DataSource = Me.UNIDOSBGDataSet
        '
        'UNIDOSBGDataSet
        '
        Me.UNIDOSBGDataSet.DataSetName = "UNIDOSBGDataSet"
        Me.UNIDOSBGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtfunciones
        '
        Me.txtfunciones.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfunciones.Location = New System.Drawing.Point(244, 57)
        Me.txtfunciones.Name = "txtfunciones"
        Me.txtfunciones.Size = New System.Drawing.Size(224, 25)
        Me.txtfunciones.TabIndex = 22
        '
        'txtnombredpto
        '
        Me.txtnombredpto.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombredpto.Location = New System.Drawing.Point(244, 29)
        Me.txtnombredpto.Name = "txtnombredpto"
        Me.txtnombredpto.Size = New System.Drawing.Size(224, 25)
        Me.txtnombredpto.TabIndex = 21
        '
        'dgvdepartamento
        '
        Me.dgvdepartamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdepartamento.Location = New System.Drawing.Point(53, 169)
        Me.dgvdepartamento.Name = "dgvdepartamento"
        Me.dgvdepartamento.Size = New System.Drawing.Size(386, 88)
        Me.dgvdepartamento.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(37, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 17)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Responsable"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(35, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(197, 17)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Descripcion de funciones"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(35, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 17)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Nombre del departamento"
        '
        'btnvolver
        '
        Me.btnvolver.BackColor = System.Drawing.Color.DarkRed
        Me.btnvolver.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnvolver.ForeColor = System.Drawing.Color.White
        Me.btnvolver.Location = New System.Drawing.Point(271, 272)
        Me.btnvolver.Name = "btnvolver"
        Me.btnvolver.Size = New System.Drawing.Size(75, 23)
        Me.btnvolver.TabIndex = 13
        Me.btnvolver.Text = "Volver"
        Me.btnvolver.UseVisualStyleBackColor = False
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.DarkRed
        Me.btnguardar.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.ForeColor = System.Drawing.Color.White
        Me.btnguardar.Location = New System.Drawing.Point(143, 272)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(75, 23)
        Me.btnguardar.TabIndex = 12
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'MOVIMIENTOSBindingSource
        '
        Me.MOVIMIENTOSBindingSource.DataMember = "MOVIMIENTOS"
        Me.MOVIMIENTOSBindingSource.DataSource = Me.UNIDOSBGDataSet
        '
        'PROYECTOSBindingSource
        '
        Me.PROYECTOSBindingSource.DataMember = "PROYECTOS"
        Me.PROYECTOSBindingSource.DataSource = Me.UNIDOSBGDataSet
        '
        'MOVIMIENTOSTableAdapter
        '
        Me.MOVIMIENTOSTableAdapter.ClearBeforeFill = True
        '
        'MOVIMIENTOSBindingSource1
        '
        Me.MOVIMIENTOSBindingSource1.DataMember = "MOVIMIENTOS"
        Me.MOVIMIENTOSBindingSource1.DataSource = Me.UNIDOSBGDataSet
        '
        'PROYECTOSTableAdapter
        '
        Me.PROYECTOSTableAdapter.ClearBeforeFill = True
        '
        'PERSONASTableAdapter
        '
        Me.PERSONASTableAdapter.ClearBeforeFill = True
        '
        'Nuevo_Departamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(498, 359)
        Me.Controls.Add(Me.cmbresponsable)
        Me.Controls.Add(Me.txtfunciones)
        Me.Controls.Add(Me.txtnombredpto)
        Me.Controls.Add(Me.dgvdepartamento)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnvolver)
        Me.Controls.Add(Me.btnguardar)
        Me.Name = "Nuevo_Departamento"
        Me.Text = "Nuevo_Departamento"
        CType(Me.PERSONASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UNIDOSBGDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvdepartamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MOVIMIENTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROYECTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MOVIMIENTOSBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbresponsable As ComboBox
    Friend WithEvents txtfunciones As TextBox
    Friend WithEvents txtnombredpto As TextBox
    Friend WithEvents dgvdepartamento As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnvolver As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents UNIDOSBGDataSet As UNIDOSBGDataSet
    Friend WithEvents MOVIMIENTOSBindingSource As BindingSource
    Friend WithEvents MOVIMIENTOSTableAdapter As UNIDOSBGDataSetTableAdapters.MOVIMIENTOSTableAdapter
    Friend WithEvents MOVIMIENTOSBindingSource1 As BindingSource
    Friend WithEvents PROYECTOSBindingSource As BindingSource
    Friend WithEvents PROYECTOSTableAdapter As UNIDOSBGDataSetTableAdapters.PROYECTOSTableAdapter
    Friend WithEvents PERSONASBindingSource As BindingSource
    Friend WithEvents PERSONASTableAdapter As UNIDOSBGDataSetTableAdapters.PERSONASTableAdapter
End Class
