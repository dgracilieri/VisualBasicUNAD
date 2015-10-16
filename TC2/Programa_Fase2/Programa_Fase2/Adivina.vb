Public Class Adivina
    'Deshabilita el boton de cerrar el formulario
    Dim _enabledCerrar As Boolean = False
    <System.ComponentModel.DefaultValue(False), System.ComponentModel.Description("Define si se habilita el botón cerrar en el formulario")> _
    Public Property EnabledCerrar() As Boolean
        Get
            Return _enabledCerrar
        End Get
        Set(ByVal Value As Boolean)
            If _enabledCerrar <> Value Then
                _enabledCerrar = Value
            End If
        End Set
    End Property
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            If _enabledCerrar = False Then
                Const CS_NOCLOSE As Integer = &H200
                cp.ClassStyle = cp.ClassStyle Or CS_NOCLOSE
            End If
            Return cp
        End Get
    End Property
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

        If ComboBox1.SelectedItem = "Novato" Then
            adivina = InputBox("Ingrese un numero entre 0 y 100", "Adivine el numero")
           
            For x = 1 To 15

                If adivina > 100 Or adivina < 0 Then
                    MsgBox("Debe ingresar un numero que este comprendido entre 0 y 100", MessageBoxIcon.Information, "Adivine el numero")
                    adivina = InputBox("Ingrese un numero entre 0 y 100", "Adivine el numero")
                    x = x - 1
                ElseIf num = adivina Then
                    MsgBox("Felicidades " + TextBox1.Text + " Adivinaste el numero en tan solo " + x.ToString + " Intentos", MsgBoxStyle.OkOnly, "Adivine el numero")
                        Exit For

                    Else
                        MsgBox("Continua te quedan aun " + (15 - Val(x)).ToString + " Intentos", MessageBoxIcon.Information, "Adivine el numero")
                        If adivina > num Then
                            MsgBox("El numero ingreso esta por encima del numero buscado", MessageBoxIcon.Information, "Adivine el numero")
                        Else
                            MsgBox("El numero ingresado esta por debajo del numero buscado", MessageBoxIcon.Information, "Adivine el numero")

                        End If
                        adivina = InputBox("Ingrese un numero entre 0 y 100", "Adivine el numero")
                        If adivina > 100 Or adivina < 0 Then
                            MsgBox("Debe ingresar un numero que este comprendido entre 0 y 100", MessageBoxIcon.Information, "Adivine el numero")
                            adivina = InputBox("Ingrese un numero entre 0 y 100", "Adivine el numero")

                        End If
                    End If

            Next

        ElseIf ComboBox1.SelectedItem = "Avanzado" Then
            adivina = InputBox("Ingrese un numero entre 0 y 100", "Adivine el numero")

            For x = 1 To 7

                If adivina > 100 Or adivina < 0 Then
                    MsgBox("Debe ingresar un numero que este comprendido entre 0 y 100", MessageBoxIcon.Information, "Adivine el numero")
                    adivina = InputBox("Ingrese un numero entre 0 y 100", "Adivine el numero")
                    x = x - 1
                ElseIf num = adivina Then
                    MsgBox("Felicidades " + TextBox1.Text + " Adivinaste el numero en tan solo " + x.ToString + " Intentos", MsgBoxStyle.OkOnly, "Adivine el numero")
                    Exit For

                Else
                    MsgBox("Continua te quedan aun " + (7 - Val(x)).ToString + " Intentos", MessageBoxIcon.Information, "Adivine el numero")
                    If adivina > num Then
                        MsgBox("El numero ingreso esta por encima del numero buscado", MessageBoxIcon.Information, "Adivine el numero")
                    Else
                        MsgBox("El numero ingresado esta por debajo del numero buscado", MessageBoxIcon.Information, "Adivine el numero")

                    End If
                    adivina = InputBox("Ingrese un numero entre 0 y 100", "Adivine el numero")
                    If adivina > 100 Or adivina < 0 Then
                        MsgBox("Debe ingresar un numero que este comprendido entre 0 y 100", MessageBoxIcon.Information, "Adivine el numero")
                        adivina = InputBox("Ingrese un numero entre 0 y 100", "Adivine el numero")

                    End If
                End If

            Next
        End If
    End Sub
    Private Sub Button1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseHover
        Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Bold)
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Regular)
    End Sub
    Private Sub Button3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.MouseHover
        Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Bold)
    End Sub

    Private Sub Button3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.MouseLeave
        Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Regular)
    End Sub
    

    Private Sub Adivina_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class