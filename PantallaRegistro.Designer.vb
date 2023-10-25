<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PantallaRegistro
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
        Me.btnGuardar = New Guna.UI2.WinForms.Guna2Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnVolverReg = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbNombre = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cbEscuela = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cbPasatiempo = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cbEdad = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.SuspendLayout()
        '
        'btnGuardar
        '
        Me.btnGuardar.BorderRadius = 2
        Me.btnGuardar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGuardar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGuardar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGuardar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(337, 382)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(87, 43)
        Me.btnGuardar.TabIndex = 9
        Me.btnGuardar.Text = "Guardar"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DarkGray
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(-2, 428)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(523, 22)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "2023, Aplicacion creada por RamcesXD"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnVolverReg
        '
        Me.btnVolverReg.BorderRadius = 2
        Me.btnVolverReg.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnVolverReg.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnVolverReg.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnVolverReg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnVolverReg.FillColor = System.Drawing.Color.CornflowerBlue
        Me.btnVolverReg.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnVolverReg.ForeColor = System.Drawing.Color.White
        Me.btnVolverReg.Location = New System.Drawing.Point(430, 382)
        Me.btnVolverReg.Name = "btnVolverReg"
        Me.btnVolverReg.Size = New System.Drawing.Size(87, 43)
        Me.btnVolverReg.TabIndex = 7
        Me.btnVolverReg.Text = "Volver"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(81, 118)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(63, 22)
        Me.Guna2HtmlLabel1.TabIndex = 10
        Me.Guna2HtmlLabel1.Text = "Nombre:"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(81, 170)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(45, 22)
        Me.Guna2HtmlLabel2.TabIndex = 11
        Me.Guna2HtmlLabel2.Text = "Edad:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(77, 221)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Escuela:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(77, 271)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 20)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Pasatiempo:"
        '
        'tbNombre
        '
        Me.tbNombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbNombre.DefaultText = ""
        Me.tbNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbNombre.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbNombre.Location = New System.Drawing.Point(181, 104)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbNombre.PlaceholderText = ""
        Me.tbNombre.SelectedText = ""
        Me.tbNombre.Size = New System.Drawing.Size(260, 36)
        Me.tbNombre.TabIndex = 15
        '
        'cbEscuela
        '
        Me.cbEscuela.BackColor = System.Drawing.Color.Transparent
        Me.cbEscuela.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbEscuela.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEscuela.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbEscuela.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbEscuela.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbEscuela.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbEscuela.ItemHeight = 30
        Me.cbEscuela.Location = New System.Drawing.Point(181, 205)
        Me.cbEscuela.Name = "cbEscuela"
        Me.cbEscuela.Size = New System.Drawing.Size(140, 36)
        Me.cbEscuela.TabIndex = 18
        '
        'cbPasatiempo
        '
        Me.cbPasatiempo.BackColor = System.Drawing.Color.Transparent
        Me.cbPasatiempo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbPasatiempo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPasatiempo.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbPasatiempo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbPasatiempo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbPasatiempo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbPasatiempo.ItemHeight = 30
        Me.cbPasatiempo.Location = New System.Drawing.Point(181, 254)
        Me.cbPasatiempo.Name = "cbPasatiempo"
        Me.cbPasatiempo.Size = New System.Drawing.Size(140, 36)
        Me.cbPasatiempo.TabIndex = 19
        '
        'cbEdad
        '
        Me.cbEdad.BackColor = System.Drawing.Color.Transparent
        Me.cbEdad.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbEdad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEdad.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbEdad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbEdad.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbEdad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbEdad.ItemHeight = 30
        Me.cbEdad.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cbEdad.Location = New System.Drawing.Point(181, 156)
        Me.cbEdad.Name = "cbEdad"
        Me.cbEdad.Size = New System.Drawing.Size(140, 36)
        Me.cbEdad.TabIndex = 20
        '
        'PantallaRegistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 450)
        Me.Controls.Add(Me.cbEdad)
        Me.Controls.Add(Me.cbPasatiempo)
        Me.Controls.Add(Me.cbEscuela)
        Me.Controls.Add(Me.tbNombre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnVolverReg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PantallaRegistro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PantallaRegistro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGuardar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnVolverReg As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbNombre As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cbEscuela As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cbPasatiempo As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cbEdad As Guna.UI2.WinForms.Guna2ComboBox
End Class
