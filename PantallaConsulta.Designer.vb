<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PantallaConsulta
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnVolverCon = New Guna.UI2.WinForms.Guna2Button()
        Me.LISTA = New System.Windows.Forms.ListView()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmsLISTA = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.btnEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnEditar = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsLISTA.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DarkGray
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(-1, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(485, 22)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "2023, Aplicacion creada por RamcesXD"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnVolverCon
        '
        Me.btnVolverCon.BorderRadius = 2
        Me.btnVolverCon.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnVolverCon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnVolverCon.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnVolverCon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnVolverCon.FillColor = System.Drawing.Color.CornflowerBlue
        Me.btnVolverCon.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnVolverCon.ForeColor = System.Drawing.Color.White
        Me.btnVolverCon.Location = New System.Drawing.Point(385, 115)
        Me.btnVolverCon.Name = "btnVolverCon"
        Me.btnVolverCon.Size = New System.Drawing.Size(87, 43)
        Me.btnVolverCon.TabIndex = 7
        Me.btnVolverCon.Text = "Volver"
        '
        'LISTA
        '
        Me.LISTA.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.LISTA.ContextMenuStrip = Me.cmsLISTA
        Me.LISTA.FullRowSelect = True
        Me.LISTA.HideSelection = False
        Me.LISTA.Location = New System.Drawing.Point(12, 12)
        Me.LISTA.MultiSelect = False
        Me.LISTA.Name = "LISTA"
        Me.LISTA.Size = New System.Drawing.Size(460, 97)
        Me.LISTA.TabIndex = 9
        Me.LISTA.UseCompatibleStateImageBehavior = False
        Me.LISTA.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "ID"
        Me.ColumnHeader6.Width = 100
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Nombre"
        Me.ColumnHeader7.Width = 144
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Edad"
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Escuela"
        Me.ColumnHeader9.Width = 144
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Pasatiempo"
        Me.ColumnHeader10.Width = 108
        '
        'cmsLISTA
        '
        Me.cmsLISTA.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnEliminar, Me.btnEditar})
        Me.cmsLISTA.Name = "cmsLISTA"
        Me.cmsLISTA.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmsLISTA.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.cmsLISTA.RenderStyle.ColorTable = Nothing
        Me.cmsLISTA.RenderStyle.RoundedEdges = True
        Me.cmsLISTA.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.cmsLISTA.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmsLISTA.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.cmsLISTA.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.cmsLISTA.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cmsLISTA.Size = New System.Drawing.Size(181, 70)
        '
        'btnEliminar
        '
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(180, 22)
        Me.btnEliminar.Text = "Eliminar"
        '
        'btnEditar
        '
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(180, 22)
        Me.btnEditar.Text = "Editar"
        '
        'PantallaConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 183)
        Me.Controls.Add(Me.LISTA)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnVolverCon)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PantallaConsulta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PantallaConsulta"
        Me.cmsLISTA.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents btnVolverCon As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LISTA As ListView
    Friend WithEvents cmsLISTA As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents btnEliminar As ToolStripMenuItem
    Friend WithEvents btnEditar As ToolStripMenuItem
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
End Class
