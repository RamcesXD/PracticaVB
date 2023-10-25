Public Class PantallaConsulta

    Friend Sub COMPLETADO()
        If LISTA.SelectedItems.Count > 0 Then
            btnEliminar.Enabled = True
        Else
            btnEliminar.Enabled = False

        End If

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnVolverCon.Click
        Me.Hide()
        PantallaInicio.Show()

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If LISTA.SelectedItems.Count > 0 Then
            If MsgBox("Esta seguro que desea eliminar esta informacion?", vbQuestion + vbYesNo, "Eliminar") = vbYes Then
                BORRAR("kid", "IDkid", LISTA.SelectedItems(0).SubItems(0).Text)
                LISTA.Items.Clear()
                Me.Hide()
                PantallaInicio.Show()
            End If
        End If

    End Sub

    Private Sub LISTA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LISTA.SelectedIndexChanged
        COMPLETADO()

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If LISTA.SelectedItems.Count > 0 Then
            PantallaRegistro.tbNombre.Tag = LISTA.SelectedItems(0).SubItems(0).Text
            PantallaRegistro.tbNombre.Text = LISTA.SelectedItems(0).SubItems(1).Text
            PantallaRegistro.cbEdad.Text = LISTA.SelectedItems(0).SubItems(2).Text
            PantallaRegistro.cbEscuela.Items.Add(LISTA.SelectedItems(0).SubItems(3).Text)
            PantallaRegistro.cbEscuela.Text = LISTA.SelectedItems(0).SubItems(3).Text
            PantallaRegistro.cbPasatiempo.Items.Add(LISTA.SelectedItems(0).SubItems(4).Text)
            PantallaRegistro.cbPasatiempo.Text = LISTA.SelectedItems(0).SubItems(4).Text
            MOSTRAR_ESCUELAS()
            MOSTRAR_HOBBIES()

            Me.Close()
            PantallaRegistro.Show()
            LISTA.Items.Clear()
        End If
    End Sub
End Class