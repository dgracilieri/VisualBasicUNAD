Public Class Capitales
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


    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsLower(e.KeyChar) Then
            TextBox1.CharacterCasing = CharacterCasing.Upper
        ElseIf Char.IsNumber(e.KeyChar) Then
            e.Handled = True

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim capital(11) As String
        capital(0) = "BUENOS AIRES"
        capital(1) = "SUCRE"
        capital(2) = "BRASILIA"
        capital(3) = "SANTIAGO"
        capital(4) = "BOGOTA"
        capital(5) = "QUITO"
        capital(6) = "GEORGETOWN"
        capital(7) = "ASUNCION"
        capital(8) = "LIMA"
        capital(9) = "PARAMARIBO"
        capital(10) = "MONTEVIDEO"
        capital(11) = "CARACAS"

        Dim cont As UInteger
        cont = 0
        Dim cont2 As Integer
        cont2 = 0

        While cont <= 11

            If TextBox1.Text = capital(cont) Then
                If TextBox1.Text = capital(0) Then
                    MsgBox(TextBox1.Text.ToString + " Es la capital de Argentina", MsgBoxStyle.OkOnly, "Capitales de Sudamerica")
                    TextBox1.Text = ""
                ElseIf TextBox1.Text = capital(1) Then
                    MsgBox(TextBox1.Text.ToString + " Es la capital de Bolivia", MsgBoxStyle.OkOnly, "Capitales de Sudamerica")
                    TextBox1.Text = ""
                ElseIf TextBox1.Text = capital(2) Then
                    MsgBox(TextBox1.Text.ToString + " Es la capital de Brasil", MsgBoxStyle.OkOnly, "Capitales de Sudamerica")
                    TextBox1.Text = ""
                ElseIf TextBox1.Text = capital(3) Then
                    MsgBox(TextBox1.Text.ToString + " Es la capital de Chile", MsgBoxStyle.OkOnly, "Capitales de Sudamerica")
                    TextBox1.Text = ""
                ElseIf TextBox1.Text = capital(4) Then
                    MsgBox(TextBox1.Text.ToString + " Es la capital de Colombia", MsgBoxStyle.OkOnly, "Capitales de Sudamerica")
                    TextBox1.Text = ""
                ElseIf TextBox1.Text = capital(5) Then
                    MsgBox(TextBox1.Text.ToString + " Es la capital de Ecuador", MsgBoxStyle.OkOnly, "Capitales de Sudamerica")
                    TextBox1.Text = ""
                ElseIf TextBox1.Text = capital(6) Then
                    MsgBox(TextBox1.Text.ToString + " Es la capital de Guyana", MsgBoxStyle.OkOnly, "Capitales de Sudamerica")
                    TextBox1.Text = ""
                ElseIf TextBox1.Text = capital(7) Then
                    MsgBox(TextBox1.Text.ToString + " Es la capital de Paraguay", MsgBoxStyle.OkOnly, "Capitales de Sudamerica")
                    TextBox1.Text = ""
                ElseIf TextBox1.Text = capital(8) Then
                    MsgBox(TextBox1.Text.ToString + " Es la capital de Peru", MsgBoxStyle.OkOnly, "Capitales de Sudamerica")
                    TextBox1.Text = ""
                ElseIf TextBox1.Text = capital(9) Then
                    MsgBox(TextBox1.Text.ToString + " Es la capital de Surinam", MsgBoxStyle.OkOnly, "Capitales de Sudamerica")
                    TextBox1.Text = ""
                ElseIf TextBox1.Text = capital(10) Then
                    MsgBox(TextBox1.Text.ToString + " Es la capital de Montevideo", MsgBoxStyle.OkOnly, "Capitales de Sudamerica")
                    TextBox1.Text = ""
                ElseIf TextBox1.Text = capital(11) Then
                    MsgBox(TextBox1.Text.ToString + " Es la capital de Venezuela", MsgBoxStyle.OkOnly, "Capitales de Sudamerica")
                    TextBox1.Text = ""

                End If
                Exit While
            Else
                cont2 = cont2 + 1

            End If
            cont = cont + 1


        End While

        If cont2 = 12 Then
            TextBox1.Text = ""
            MsgBox("Error la ciudad ingresa no pertenece a ninguna de las captitales de sudamerica", MessageBoxIcon.Error, "Capitales de Sudamerica")

        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Text = ""
    End Sub

    Private Sub Button1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseHover
        Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Bold)
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Regular)
    End Sub

    Private Sub Button2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseHover
        Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Bold)
    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Regular)
    End Sub

    Private Sub Button3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.MouseHover
        Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Bold)
    End Sub

    Private Sub Button3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.MouseLeave
        Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Regular)
    End Sub

    Private Sub Capitales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class