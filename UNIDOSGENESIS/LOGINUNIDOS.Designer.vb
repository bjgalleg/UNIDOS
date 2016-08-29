<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LOGINUNIDOS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LOGINUNIDOS))
        Me.txtusuario = New System.Windows.Forms.TextBox()
        Me.txtcedula = New System.Windows.Forms.TextBox()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.btningresar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtusuario
        '
        Me.txtusuario.Location = New System.Drawing.Point(132, 187)
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(184, 20)
        Me.txtusuario.TabIndex = 0
        '
        'txtcedula
        '
        Me.txtcedula.Location = New System.Drawing.Point(132, 228)
        Me.txtcedula.Name = "txtcedula"
        Me.txtcedula.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtcedula.Size = New System.Drawing.Size(184, 20)
        Me.txtcedula.TabIndex = 1
        '
        'btnlimpiar
        '
        Me.btnlimpiar.BackColor = System.Drawing.Color.DarkRed
        Me.btnlimpiar.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlimpiar.ForeColor = System.Drawing.Color.White
        Me.btnlimpiar.Location = New System.Drawing.Point(331, 208)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(81, 29)
        Me.btnlimpiar.TabIndex = 4
        Me.btnlimpiar.Text = "Limpiar"
        Me.btnlimpiar.UseVisualStyleBackColor = False
        '
        'btningresar
        '
        Me.btningresar.BackColor = System.Drawing.Color.DarkRed
        Me.btningresar.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btningresar.ForeColor = System.Drawing.Color.White
        Me.btningresar.Location = New System.Drawing.Point(331, 165)
        Me.btningresar.Name = "btningresar"
        Me.btningresar.Size = New System.Drawing.Size(81, 29)
        Me.btningresar.TabIndex = 3
        Me.btningresar.Text = "Ingresar"
        Me.btningresar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(59, 187)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(31, 228)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Contraseña"
        '
        'btnsalir
        '
        Me.btnsalir.BackColor = System.Drawing.Color.DarkRed
        Me.btnsalir.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalir.ForeColor = System.Drawing.Color.White
        Me.btnsalir.Location = New System.Drawing.Point(331, 251)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(81, 31)
        Me.btnsalir.TabIndex = 7
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(59, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(302, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "ORGANIZACIÓN MISIONERA UNIDOS"
        '
        'LOGINUNIDOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(434, 345)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnlimpiar)
        Me.Controls.Add(Me.btningresar)
        Me.Controls.Add(Me.txtcedula)
        Me.Controls.Add(Me.txtusuario)
        Me.Name = "LOGINUNIDOS"
        Me.Text = "LOGINUNIDOS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtusuario As TextBox
    Friend WithEvents txtcedula As TextBox
    Friend WithEvents btnlimpiar As Button
    Friend WithEvents btningresar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnsalir As Button
    Friend WithEvents Label3 As Label
End Class
