Public Class areas

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
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim calculo As Double
        If ComboBox1.SelectedItem = "" Then
            MsgBox("Error debe seleccionar una figura", MessageBoxIcon.Error, "Area Calculada")
            TextBox1.Text = ""
            TextBox2.Text = ""

        ElseIf ComboBox1.SelectedItem = "Cuadrado" Or ComboBox1.SelectedItem = "Rectangulo" Then
            If TextBox1.Text = "" Or TextBox2.Text = "" Then
                MsgBox("Error debe ingresar la base y la altura", MessageBoxIcon.Error, "Area Calculada")
            Else
                calculo = Val(TextBox1.Text) * Val(TextBox2.Text)
                MsgBox("El area de la figura seleccionada es " + calculo.ToString, MsgBoxStyle.OkOnly, "Area Calculada")
            End If
            
            TextBox1.Text = ""
            TextBox2.Text = ""
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Then
                MsgBox("Error debe ingresar la base y la altura", MessageBoxIcon.Error, "Area Calculada")
            Else
                calculo = (Val(TextBox1.Text) * Val(TextBox2.Text)) / 2
                MsgBox("El area de la figura seleccionada es " + calculo.ToString, MsgBoxStyle.OkOnly, "Area Calculada")
            End If
            
            TextBox1.Text = ""
            TextBox2.Text = ""
            End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

   
    Private Sub Button1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseMove
        Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Bold)
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Regular)
    End Sub
    Private Sub Button2_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button2.MouseMove
        Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Bold)
    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Regular)
    End Sub
End Class