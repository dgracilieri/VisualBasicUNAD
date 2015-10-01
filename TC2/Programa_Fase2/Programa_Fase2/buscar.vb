Public Class buscar

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If TextBox1.Text = "" Then
            MsgBox("Error no ingreso datos", MessageBoxIcon.Error, "Busqueda")

        ElseIf TextBox1.Text = 0 Then
            MsgBox("Error la posicion no existe", MessageBoxIcon.Error, "Busqueda")
            TextBox1.Text = ""


        ElseIf agendaf.agenda(Val(TextBox1.Text) - 1, 0) = "" Then
            MsgBox("Error la posicion no existe", MessageBoxIcon.Error, "Busqueda")
            TextBox1.Text = ""


        Else
            contactos.Label7.Text = agendaf.agenda(Val(TextBox1.Text) - 1, 0)
            contactos.Label8.Text = agendaf.agenda(Val(TextBox1.Text) - 1, 1)
            contactos.Label9.Text = agendaf.agenda(Val(TextBox1.Text) - 1, 2)
            contactos.Label10.Text = agendaf.agenda(Val(TextBox1.Text) - 1, 3)
            contactos.Label11.Text = agendaf.agenda(Val(TextBox1.Text) - 1, 4)
            contactos.Label12.Text = agendaf.agenda(Val(TextBox1.Text) - 1, 5)
            Me.Hide()
            contactos.Show()

        End If
    End Sub
End Class