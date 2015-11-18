Public Class AccesoAdmin

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If cont = 3 Then
            MsgBox("Ya agoto su cantidad de intentos debe salir y volver a ingresar")

        End If
        If TextBox1.Text = 123 Then
            AreaAdmin.Show()
            Me.Close()
        ElseIf cont < 3 Then
            MsgBox("La contraseña ingresada no es valida", MessageBoxIcon.Information, "Acceso de administrador")
            cont = cont + 1
            TextBox1.Text = ""
        End If


        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cont = 0
        principal.Show()
        Me.Close()
    End Sub
End Class