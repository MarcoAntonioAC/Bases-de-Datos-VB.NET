<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbcPrincipal = New System.Windows.Forms.TabControl()
        Me.tabInsertar = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.lblNombres = New System.Windows.Forms.Label()
        Me.lblIdentificacion = New System.Windows.Forms.Label()
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.txtIdentificacion = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.tbcPrincipal.SuspendLayout()
        Me.tabInsertar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 2
        '
        'tbcPrincipal
        '
        Me.tbcPrincipal.Controls.Add(Me.tabInsertar)
        Me.tbcPrincipal.Controls.Add(Me.TabPage2)
        Me.tbcPrincipal.Location = New System.Drawing.Point(1, -2)
        Me.tbcPrincipal.Name = "tbcPrincipal"
        Me.tbcPrincipal.SelectedIndex = 0
        Me.tbcPrincipal.Size = New System.Drawing.Size(493, 373)
        Me.tbcPrincipal.TabIndex = 3
        '
        'tabInsertar
        '
        Me.tabInsertar.Controls.Add(Me.Button2)
        Me.tabInsertar.Controls.Add(Me.lblDireccion)
        Me.tabInsertar.Controls.Add(Me.lblCorreo)
        Me.tabInsertar.Controls.Add(Me.lblApellidos)
        Me.tabInsertar.Controls.Add(Me.lblNombres)
        Me.tabInsertar.Controls.Add(Me.lblIdentificacion)
        Me.tabInsertar.Controls.Add(Me.btnInsertar)
        Me.tabInsertar.Controls.Add(Me.txtDireccion)
        Me.tabInsertar.Controls.Add(Me.txtApellidos)
        Me.tabInsertar.Controls.Add(Me.txtCorreo)
        Me.tabInsertar.Controls.Add(Me.txtNombres)
        Me.tabInsertar.Controls.Add(Me.txtIdentificacion)
        Me.tabInsertar.Location = New System.Drawing.Point(4, 22)
        Me.tabInsertar.Name = "tabInsertar"
        Me.tabInsertar.Padding = New System.Windows.Forms.Padding(3)
        Me.tabInsertar.Size = New System.Drawing.Size(485, 347)
        Me.tabInsertar.TabIndex = 0
        Me.tabInsertar.Text = "Insertar"
        Me.tabInsertar.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button2.Font = New System.Drawing.Font("Neou", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button2.Location = New System.Drawing.Point(358, 262)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 40)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "SALIR"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(13, 224)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(55, 13)
        Me.lblDireccion.TabIndex = 10
        Me.lblDireccion.Text = "Dirección:"
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Location = New System.Drawing.Point(13, 174)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(41, 13)
        Me.lblCorreo.TabIndex = 9
        Me.lblCorreo.Text = "Correo:"
        '
        'lblApellidos
        '
        Me.lblApellidos.AutoSize = True
        Me.lblApellidos.Location = New System.Drawing.Point(13, 122)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(55, 13)
        Me.lblApellidos.TabIndex = 8
        Me.lblApellidos.Text = "Apellidos: "
        '
        'lblNombres
        '
        Me.lblNombres.AutoSize = True
        Me.lblNombres.Location = New System.Drawing.Point(13, 70)
        Me.lblNombres.Name = "lblNombres"
        Me.lblNombres.Size = New System.Drawing.Size(47, 13)
        Me.lblNombres.TabIndex = 7
        Me.lblNombres.Text = "Nombre:"
        '
        'lblIdentificacion
        '
        Me.lblIdentificacion.AutoSize = True
        Me.lblIdentificacion.Location = New System.Drawing.Point(13, 17)
        Me.lblIdentificacion.Name = "lblIdentificacion"
        Me.lblIdentificacion.Size = New System.Drawing.Size(66, 13)
        Me.lblIdentificacion.TabIndex = 6
        Me.lblIdentificacion.Text = "ID CLIENTE"
        '
        'btnInsertar
        '
        Me.btnInsertar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnInsertar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnInsertar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnInsertar.Font = New System.Drawing.Font("Neou", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsertar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnInsertar.Location = New System.Drawing.Point(16, 263)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(124, 40)
        Me.btnInsertar.TabIndex = 5
        Me.btnInsertar.Text = "Guardar"
        Me.btnInsertar.UseVisualStyleBackColor = False
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(74, 221)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(367, 20)
        Me.txtDireccion.TabIndex = 4
        '
        'txtApellidos
        '
        Me.txtApellidos.Location = New System.Drawing.Point(74, 119)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(227, 20)
        Me.txtApellidos.TabIndex = 3
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(74, 171)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(227, 20)
        Me.txtCorreo.TabIndex = 2
        '
        'txtNombres
        '
        Me.txtNombres.Location = New System.Drawing.Point(74, 67)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(227, 20)
        Me.txtNombres.TabIndex = 1
        '
        'txtIdentificacion
        '
        Me.txtIdentificacion.Location = New System.Drawing.Point(85, 14)
        Me.txtIdentificacion.Name = "txtIdentificacion"
        Me.txtIdentificacion.Size = New System.Drawing.Size(55, 20)
        Me.txtIdentificacion.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(485, 347)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Consultar"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 334)
        Me.Controls.Add(Me.tbcPrincipal)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Consulta a Base de Datos"
        Me.tbcPrincipal.ResumeLayout(False)
        Me.tabInsertar.ResumeLayout(False)
        Me.tabInsertar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbcPrincipal As System.Windows.Forms.TabControl
    Friend WithEvents tabInsertar As System.Windows.Forms.TabPage
    Friend WithEvents lblIdentificacion As System.Windows.Forms.Label
    Friend WithEvents btnInsertar As System.Windows.Forms.Button
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtApellidos As System.Windows.Forms.TextBox
    Friend WithEvents txtCorreo As System.Windows.Forms.TextBox
    Friend WithEvents txtNombres As System.Windows.Forms.TextBox
    Friend WithEvents txtIdentificacion As System.Windows.Forms.TextBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents lblCorreo As System.Windows.Forms.Label
    Friend WithEvents lblApellidos As System.Windows.Forms.Label
    Friend WithEvents lblNombres As System.Windows.Forms.Label

End Class
