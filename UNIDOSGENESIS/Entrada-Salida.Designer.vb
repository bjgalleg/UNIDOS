<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Entrada_Salida
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Entrada_Salida))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.ENTRADA = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtactual = New System.Windows.Forms.TextBox()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btningreso_producto = New System.Windows.Forms.Button()
        Me.cbocedula = New System.Windows.Forms.ComboBox()
        Me.cboproducto = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SALIDAS = New System.Windows.Forms.TabPage()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtactual1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcantidad1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnsacar_producto = New System.Windows.Forms.Button()
        Me.txtcedula1 = New System.Windows.Forms.ComboBox()
        Me.cboproducto1 = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.ENTRADA.SuspendLayout()
        Me.SALIDAS.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(529, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 28)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.ENTRADA)
        Me.TabControl1.Controls.Add(Me.SALIDAS)
        Me.TabControl1.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(23, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(500, 461)
        Me.TabControl1.TabIndex = 12
        '
        'ENTRADA
        '
        Me.ENTRADA.BackgroundImage = CType(resources.GetObject("ENTRADA.BackgroundImage"), System.Drawing.Image)
        Me.ENTRADA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ENTRADA.Controls.Add(Me.Label7)
        Me.ENTRADA.Controls.Add(Me.txtactual)
        Me.ENTRADA.Controls.Add(Me.txtcantidad)
        Me.ENTRADA.Controls.Add(Me.Label5)
        Me.ENTRADA.Controls.Add(Me.btningreso_producto)
        Me.ENTRADA.Controls.Add(Me.cbocedula)
        Me.ENTRADA.Controls.Add(Me.cboproducto)
        Me.ENTRADA.Controls.Add(Me.Label1)
        Me.ENTRADA.Controls.Add(Me.Label2)
        Me.ENTRADA.Location = New System.Drawing.Point(4, 28)
        Me.ENTRADA.Name = "ENTRADA"
        Me.ENTRADA.Padding = New System.Windows.Forms.Padding(3)
        Me.ENTRADA.Size = New System.Drawing.Size(492, 429)
        Me.ENTRADA.TabIndex = 0
        Me.ENTRADA.Text = "ENTRADAS"
        Me.ENTRADA.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(329, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 19)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Stock"
        '
        'txtactual
        '
        Me.txtactual.Enabled = False
        Me.txtactual.Location = New System.Drawing.Point(391, 181)
        Me.txtactual.Name = "txtactual"
        Me.txtactual.Size = New System.Drawing.Size(85, 26)
        Me.txtactual.TabIndex = 16
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(201, 236)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(121, 26)
        Me.txtcantidad.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(50, 246)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 19)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Cantidad"
        '
        'btningreso_producto
        '
        Me.btningreso_producto.Location = New System.Drawing.Point(349, 243)
        Me.btningreso_producto.Name = "btningreso_producto"
        Me.btningreso_producto.Size = New System.Drawing.Size(121, 28)
        Me.btningreso_producto.TabIndex = 13
        Me.btningreso_producto.Text = "Ingresar Producto"
        Me.btningreso_producto.UseVisualStyleBackColor = True
        '
        'cbocedula
        '
        Me.cbocedula.FormattingEnabled = True
        Me.cbocedula.Location = New System.Drawing.Point(201, 119)
        Me.cbocedula.Name = "cbocedula"
        Me.cbocedula.Size = New System.Drawing.Size(121, 27)
        Me.cbocedula.TabIndex = 10
        '
        'cboproducto
        '
        Me.cboproducto.FormattingEnabled = True
        Me.cboproducto.Items.AddRange(New Object() {"2"})
        Me.cboproducto.Location = New System.Drawing.Point(202, 184)
        Me.cboproducto.Name = "cboproducto"
        Me.cboproducto.Size = New System.Drawing.Size(121, 27)
        Me.cboproducto.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 19)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Cedula Persona"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 19)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Codigo Producto"
        '
        'SALIDAS
        '
        Me.SALIDAS.BackgroundImage = CType(resources.GetObject("SALIDAS.BackgroundImage"), System.Drawing.Image)
        Me.SALIDAS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SALIDAS.Controls.Add(Me.Label9)
        Me.SALIDAS.Controls.Add(Me.Label8)
        Me.SALIDAS.Controls.Add(Me.txtactual1)
        Me.SALIDAS.Controls.Add(Me.Label3)
        Me.SALIDAS.Controls.Add(Me.txtcantidad1)
        Me.SALIDAS.Controls.Add(Me.Label6)
        Me.SALIDAS.Controls.Add(Me.btnsacar_producto)
        Me.SALIDAS.Controls.Add(Me.txtcedula1)
        Me.SALIDAS.Controls.Add(Me.cboproducto1)
        Me.SALIDAS.Location = New System.Drawing.Point(4, 28)
        Me.SALIDAS.Name = "SALIDAS"
        Me.SALIDAS.Padding = New System.Windows.Forms.Padding(3)
        Me.SALIDAS.Size = New System.Drawing.Size(492, 429)
        Me.SALIDAS.TabIndex = 1
        Me.SALIDAS.Text = "SALIDAS"
        Me.SALIDAS.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(43, 182)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(146, 19)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Codigo Producto"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(321, 182)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 19)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Stock"
        '
        'txtactual1
        '
        Me.txtactual1.Enabled = False
        Me.txtactual1.Location = New System.Drawing.Point(383, 175)
        Me.txtactual1.Name = "txtactual1"
        Me.txtactual1.Size = New System.Drawing.Size(85, 26)
        Me.txtactual1.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 19)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Cedula Persona"
        '
        'txtcantidad1
        '
        Me.txtcantidad1.Location = New System.Drawing.Point(194, 234)
        Me.txtcantidad1.Name = "txtcantidad1"
        Me.txtcantidad1.Size = New System.Drawing.Size(121, 26)
        Me.txtcantidad1.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(43, 234)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 19)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Cantidad"
        '
        'btnsacar_producto
        '
        Me.btnsacar_producto.Location = New System.Drawing.Point(329, 232)
        Me.btnsacar_producto.Name = "btnsacar_producto"
        Me.btnsacar_producto.Size = New System.Drawing.Size(121, 28)
        Me.btnsacar_producto.TabIndex = 13
        Me.btnsacar_producto.Text = "Sacar Producto"
        Me.btnsacar_producto.UseVisualStyleBackColor = True
        '
        'txtcedula1
        '
        Me.txtcedula1.FormattingEnabled = True
        Me.txtcedula1.Location = New System.Drawing.Point(194, 130)
        Me.txtcedula1.Name = "txtcedula1"
        Me.txtcedula1.Size = New System.Drawing.Size(121, 27)
        Me.txtcedula1.TabIndex = 11
        '
        'cboproducto1
        '
        Me.cboproducto1.FormattingEnabled = True
        Me.cboproducto1.Items.AddRange(New Object() {"2"})
        Me.cboproducto1.Location = New System.Drawing.Point(194, 182)
        Me.cboproducto1.Name = "cboproducto1"
        Me.cboproducto1.Size = New System.Drawing.Size(121, 27)
        Me.cboproducto1.TabIndex = 12
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(561, 109)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(572, 159)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Entrada_Salida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(665, 495)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Entrada_Salida"
        Me.Text = "Entrada_Salida"
        Me.TabControl1.ResumeLayout(False)
        Me.ENTRADA.ResumeLayout(False)
        Me.ENTRADA.PerformLayout()
        Me.SALIDAS.ResumeLayout(False)
        Me.SALIDAS.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents ENTRADA As TabPage
    Friend WithEvents SALIDAS As TabPage
    Friend WithEvents Label7 As Label
    Friend WithEvents txtactual As TextBox
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btningreso_producto As Button
    Friend WithEvents cbocedula As ComboBox
    Friend WithEvents cboproducto As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtactual1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtcantidad1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnsacar_producto As Button
    Friend WithEvents txtcedula1 As ComboBox
    Friend WithEvents cboproducto1 As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
