Public Class Form11

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
    'Cierra el formulario actual y abre el forumlario 12 donde se encuentra el menu de opciones
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Form12.Show()
    End Sub

    'Al pulsar sobre este boton eliminara todos los datos contenidos en los TextBox1 y TextBox2
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""

    End Sub

    'Se agrego una accion la cual cuando se toque el TextBox1 realiza una validacion de los datos ingresados
    'Aqui dentro el condicionales se utiliza un metodo que evalua es es numero letra en ingresado
    'en este caso si se ingresa una letra no permitra guardar dicho caracter solo sera guardado
    'en el caso que el argumento sea verdadero que eso sera cuando se ingresa un numero
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress

        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    'Aqui dentro el condicionales se utiliza un metodo que evalua es es numero letra en ingresado
    'en este caso si se ingresa un numero no permitra guardar dicho caracter solo sera guardado
    'en el caso que el argumento sea verdadero que eso sera cuando se ingresa una letra ademas de permitir
    'ingresar la letra cada vez que suceda eso la convertira a mayusculas utilizando el metodo CharacterCasing.Upper
    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress

        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            TextBox2.CharacterCasing = CharacterCasing.Upper
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
            TextBox2.CharacterCasing = CharacterCasing.Upper
        Else
            e.Handled = False
        End If


    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Regular)
    End Sub

    Private Sub Button1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseMove
        Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Bold)
    End Sub
End Class