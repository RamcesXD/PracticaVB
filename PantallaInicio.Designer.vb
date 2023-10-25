<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PantallaInicio
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
        Me.btnSalir = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbConsultaID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnConsultar = New Guna.UI2.WinForms.Guna2Button()
        Me.btnRegistrar = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.BorderRadius = 2
        Me.btnSalir.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSalir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSalir.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSalir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSalir.FillColor = System.Drawing.Color.IndianRed
        Me.btnSalir.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Location = New System.Drawing.Point(440, 232)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(87, 43)
        Me.btnSalir.TabIndex = 0
        Me.btnSalir.Text = "Salir"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.NavajoWhite
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGray
        Me.Label1.Location = New System.Drawing.Point(0, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(540, 85)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Consulta de Niños"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(126, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ID del Niño/a:"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DarkGray
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(0, 278)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(540, 22)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "2023, Aplicacion creada por RamcesXD"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbConsultaID
        '
        Me.tbConsultaID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbConsultaID.DefaultText = ""
        Me.tbConsultaID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbConsultaID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbConsultaID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbConsultaID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbConsultaID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbConsultaID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbConsultaID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbConsultaID.Location = New System.Drawing.Point(237, 148)
        Me.tbConsultaID.Name = "tbConsultaID"
        Me.tbConsultaID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbConsultaID.PlaceholderText = ""
        Me.tbConsultaID.SelectedText = ""
        Me.tbConsultaID.Size = New System.Drawing.Size(87, 43)
        Me.tbConsultaID.TabIndex = 4
        '
        'btnConsultar
        '
        Me.btnConsultar.BorderRadius = 2
        Me.btnConsultar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnConsultar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnConsultar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnConsultar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnConsultar.FillColor = System.Drawing.Color.DarkGray
        Me.btnConsultar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnConsultar.ForeColor = System.Drawing.Color.White
        Me.btnConsultar.Location = New System.Drawing.Point(333, 148)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(87, 43)
        Me.btnConsultar.TabIndex = 5
        Me.btnConsultar.Text = "Consultar"
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BorderRadius = 2
        Me.btnRegistrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnRegistrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnRegistrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRegistrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnRegistrar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnRegistrar.ForeColor = System.Drawing.Color.White
        Me.btnRegistrar.Location = New System.Drawing.Point(347, 232)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(87, 43)
        Me.btnRegistrar.TabIndex = 6
        Me.btnRegistrar.Text = "Registrar"
        '
        'PantallaInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 300)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.tbConsultaID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSalir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PantallaInicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSalir As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbConsultaID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnConsultar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnRegistrar As Guna.UI2.WinForms.Guna2Button
End Class
