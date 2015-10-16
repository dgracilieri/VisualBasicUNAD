Public Class Adivina

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim num, adivina As Integer, x, j As Byte
        num = Int(Rnd() * 100) + 1
        MsgBox(num.ToString)
        If ComboBox1.SelectedItem = "Novato" Then
            adivina = InputBox("Ingrese un numero entre 0 y 100", "Adivne el numero")
            If adivina > 100 Or adivina < 0 Then
                MsgBox("Debe ingresar un numero que este comprendido entre 0 y 100", MessageBoxIcon.Information, "Adivine el numero")
                adivina = InputBox("Ingrese un numero entre 0 y 100", "Adivne el numero")
            Else
                For x = 1 To 15
                    If num = adivina Then
                        MsgBox("Feclidades " + TextBox1.Text + " Advinaste el numero", MsgBoxStyle.OkOnly)
                        Exit For

                    Else
                        MsgBox("continua te quedan aun " + (15 - Val(x)).ToString + "Intentos")
                        If adivina > num Then
                            MsgBox("el numero ingreso esta por encima del numero")
                        Else
                            MsgBox("el numero ingresado esta por debajo del numero")

                        End If
                        adivina = InputBox("Ingrese un numero entre 0 y 100", "Adivne el numero")
                    End If
                Next
            End If
        End If

    End Sub
End Class