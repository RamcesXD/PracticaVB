Public Class PantallaInicio
    Friend Sub COMPLETADO()
        If tbConsultaID.Text <> "" Then
            btnConsultar.Enabled = True
        Else
            btnConsultar.Enabled = False
        End If

    End Sub


    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Me.Hide()
        PantallaRegistro.Show()

        MOSTRAR_ESCUELAS()
        MOSTRAR_HOBBIES()


    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click

        CONSULTA_KIDS("kid", tbConsultaID.Text)
        If PantallaConsulta.LISTA.Items.Count > 0 Then
            Me.Hide()
            PantallaConsulta.Show()
        Else
            MsgBox("No se encontro a un niño/a registrado/a!", vbInformation + vbOKOnly, "Error")
            PantallaConsulta.LISTA.Items.Clear()

        End If

        tbConsultaID.Clear()
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles tbConsultaID.TextChanged
        COMPLETADO()

    End Sub
End Class
