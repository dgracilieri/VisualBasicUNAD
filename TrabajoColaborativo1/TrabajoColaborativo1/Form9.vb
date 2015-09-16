Public Class Form9

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

    'Al ingresar datos en el TextBox 2 realiza un calculo y lo almacena dentro del Label10
    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

        Label10.Text = (TextBox1.Text * TextBox2.Text) / 100

    End Sub
    'Al pulsar el button2 cierra el formulario actual y muestra el formulario 12
    'donde se encuentra el menu de opciones
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        Form12.Show()
    End Sub

    'Al ingresar datos en el TextBox 3 realiza un calculo y lo almacena dentro del Label11
    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        Label11.Text = (TextBox1.Text * TextBox3.Text) / 100

    End Sub
    'Al ingresar datos en el TextBox 4 realiza un calculo y lo almacena dentro del Label12
    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

        Label12.Text = (TextBox1.Text * TextBox4.Text) / 100

    End Sub

    'Al pulsar el Button 1 realizara cada uno de los calxculos pertinentes realizando las isguinetes tareas
    '1. declaracion de una variable de tipo privada 2. evalua que todos los campos esten completos
    '3. Si no hay error realiza los calculos y los coloca el el Label13
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim desc As Double
        If (TextBox1.Text = "") Or (TextBox2.Text = "") Or (TextBox3.Text = "") Or (TextBox4.Text = "") Or (TextBox6.Text = "") Then
            MsgBox("Debe completar todos los campos para realizar el calculo", MessageBoxIcon.Error)

        Else
            desc = Val(Label10.Text) + Val(Label11.Text) + Val(Label12.Text)
            Label13.Text = (Val(TextBox1.Text) + Val(TextBox6.Text)) - desc

        End If

    End Sub

    Private Sub Button2_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button2.MouseMove
        Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Bold)
    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Regular)
    End Sub
End Class