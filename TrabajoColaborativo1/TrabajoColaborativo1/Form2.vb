Public Class Form2
    
    'Este codigo deshabilita fun boton cerrar 
    Private Sub Form2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If (e.CloseReason = CloseReason.UserClosing) Then
            e.Cancel = True

        End If
    End Sub
    'Abre el formulario 6
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form6.Show()

    End Sub
    'Evalua si la contraseña ingresada posee la longitud adecuda para la misma realizando sal siguinetes tareas
    '1. Declara variable para almacena la longitud del los caracteres ingresados
    '2. Evalua si los caracteres ingresados son menores a los requeridos si son menores
    'a traves de una ventana adicional informa al usuario
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim contador As Integer
        contador = Len(TextBox1.Text)
        If (contador > 6) Then
            MsgBox("la longitud maxima para la contraseña son de 6 caracteres", MessageBoxIcon.Information)
            TextBox1.Text = ""

        End If
    End Sub

    'Evalua la contraseña ingresada donde se tiene en cuenta lo siguiente
    '1. Que la contraseña no sea vacio 
    '2. Que la contraseña coincida con el valor almacenador y en cada caso si sucede algun error
    'informara al usuario con una ventana adicional
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim contador As Integer
        contador = Len(TextBox1.Text)

        If (contador = 0) Then

            MsgBox("No ingreso contraseña vuelvalo a intentar", MessageBoxIcon.Error)

        ElseIf TextBox1.Text = 123 Then
            Form6.Close()
            Form12.Show()
            Me.Hide()
        Else
            MsgBox("Error la contraseña ingresada no es valida", MessageBoxIcon.Error)
            TextBox1.Text = ""

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        TextBox1.Text = ""

    End Sub
End Class