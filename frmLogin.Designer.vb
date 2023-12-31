<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.txtIngrContrasena = New System.Windows.Forms.TextBox()
        Me.txtIngrUsuario = New System.Windows.Forms.TextBox()
        Me.lblIngrContrasena = New System.Windows.Forms.Label()
        Me.lblIngrUsuario = New System.Windows.Forms.Label()
        Me.pbIngreso = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.pbIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtIngrContrasena
        '
        Me.txtIngrContrasena.Location = New System.Drawing.Point(210, 297)
        Me.txtIngrContrasena.Name = "txtIngrContrasena"
        Me.txtIngrContrasena.Size = New System.Drawing.Size(280, 22)
        Me.txtIngrContrasena.TabIndex = 9
        '
        'txtIngrUsuario
        '
        Me.txtIngrUsuario.Location = New System.Drawing.Point(210, 257)
        Me.txtIngrUsuario.Name = "txtIngrUsuario"
        Me.txtIngrUsuario.Size = New System.Drawing.Size(280, 22)
        Me.txtIngrUsuario.TabIndex = 8
        '
        'lblIngrContrasena
        '
        Me.lblIngrContrasena.AutoSize = True
        Me.lblIngrContrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngrContrasena.Location = New System.Drawing.Point(71, 297)
        Me.lblIngrContrasena.Name = "lblIngrContrasena"
        Me.lblIngrContrasena.Size = New System.Drawing.Size(111, 20)
        Me.lblIngrContrasena.TabIndex = 7
        Me.lblIngrContrasena.Text = "Contraseña:"
        '
        'lblIngrUsuario
        '
        Me.lblIngrUsuario.AutoSize = True
        Me.lblIngrUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngrUsuario.Location = New System.Drawing.Point(71, 257)
        Me.lblIngrUsuario.Name = "lblIngrUsuario"
        Me.lblIngrUsuario.Size = New System.Drawing.Size(80, 20)
        Me.lblIngrUsuario.TabIndex = 6
        Me.lblIngrUsuario.Text = "Usuario:"
        '
        'pbIngreso
        '
        Me.pbIngreso.BackgroundImage = Global.PruebaVirtual1.My.Resources.Resources._26540_puertas_manuel_garcia_muneco_3d_sujetando_llave_delante_de_candado
        Me.pbIngreso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbIngreso.Location = New System.Drawing.Point(166, 12)
        Me.pbIngreso.Name = "pbIngreso"
        Me.pbIngreso.Size = New System.Drawing.Size(257, 221)
        Me.pbIngreso.TabIndex = 5
        Me.pbIngreso.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(133, 350)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 36)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Ingresar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(333, 350)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(116, 36)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 398)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtIngrContrasena)
        Me.Controls.Add(Me.txtIngrUsuario)
        Me.Controls.Add(Me.lblIngrContrasena)
        Me.Controls.Add(Me.lblIngrUsuario)
        Me.Controls.Add(Me.pbIngreso)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso al Sistema"
        CType(Me.pbIngreso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtIngrContrasena As TextBox
    Friend WithEvents txtIngrUsuario As TextBox
    Friend WithEvents lblIngrContrasena As Label
    Friend WithEvents lblIngrUsuario As Label
    Friend WithEvents pbIngreso As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
