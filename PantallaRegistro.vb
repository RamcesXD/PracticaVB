Public Class PantallaRegistro

    Friend Sub LIMPIAR()
        tbNombre.Clear()
        cbEdad.Items.Clear()
        cbEscuela.Items.Clear()
        cbPasatiempo.Items.Clear()

    End Sub

    Friend Sub COMPLETADO()
        If tbNombre.Text <> "" And cbEdad.Text <> "" And cbEscuela.Text <> "" And cbPasatiempo.Text <> "" Then
            btnGuardar.Enabled = True
        Else
            btnGuardar.Enabled = False
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnVolverReg.Click
        Me.Close()
        PantallaInicio.Show()

    End Sub

    Private Sub Guna2HtmlLabel1_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel1.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If tbNombre.Tag = 0 Then

            Dim schoolSel As String = cbEscuela.Text                'Todas estas lineas ante de la llamada del metodo INSERTAR DATOS funcionan para 
            Dim hbbSel As String = cbPasatiempo.Text                'extraer el int de la escuela que seleccione el usuario

            Dim schoolPartes() As String = schoolSel.Split(" "c)    'split divide el string donde se guarda la escuela, en un arreglo y en la pocision 0
            Dim hbbPartes() As String = schoolSel.Split(" "c)       'es donde tengo los numeros de cada uno

            INSERTAR_DATOS("kid", "IDkid, kidFN, age, IDschool, IDhobbie", "" & PK("kid", "IDkid") & ",'" & tbNombre.Text & "', " & cbEdad.Text & ", '" & schoolPartes(0) & "', '" & hbbPartes(0) & "'")
            LIMPIAR()
        Else
            Dim schoolSel As String = cbEscuela.Text                'Todas estas lineas ante de la llamada del metodo INSERTAR DATOS funcionan para 
            Dim hbbSel As String = cbPasatiempo.Text                'extraer el int de la escuela que seleccione el usuario

            Dim schoolPartes() As String = schoolSel.Split(" "c)    'split divide el string donde se guarda la escuela, en un arreglo y en la pocision 0
            Dim hbbPartes() As String = schoolSel.Split(" "c)

            ACTUALIZAR("kid", "kidFN = '" & tbNombre.Text & "', age = " & cbEdad.Text & ", IDschool = " & schoolPartes(0) & ", IDhobbie = " & hbbPartes(0) & "", "IDkid", "" & tbNombre.Tag & "")
            LIMPIAR()

        End If



    End Sub

    Private Sub cbEscuela_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEscuela.SelectedIndexChanged
        COMPLETADO()


    End Sub

    Private Sub tbNombre_TextChanged(sender As Object, e As EventArgs) Handles tbNombre.TextChanged
        COMPLETADO()

    End Sub

    Private Sub cbEdad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEdad.SelectedIndexChanged
        COMPLETADO()

    End Sub

    Private Sub cbPasatiempo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPasatiempo.SelectedIndexChanged
        COMPLETADO()

    End Sub
End Class