Public Class velocidad
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

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim tiempo As Double
        Dim vel As Double
        Dim dist As Double

        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" Then
            MsgBox("Error debe ingresar datos en dos campos", MessageBoxIcon.Error)
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
        ElseIf TextBox1.Text = "" And TextBox2.Text = "" And TextBox3.Text = "" Then

            MsgBox("Error debe ingresar datos en al menos dos campos", MessageBoxIcon.Error)
        ElseIf TextBox1.Text = "" And TextBox2.Text = "" Then
            MsgBox("Error debe ingresar datos en al menos dos campos", MessageBoxIcon.Error)
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
        ElseIf TextBox1.Text = "" And TextBox3.Text = "" Then
            MsgBox("Error debe ingresar datos en al menos dos campos", MessageBoxIcon.Error)
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
        ElseIf TextBox2.Text = "" And TextBox3.Text = "" Then
            MsgBox("Error debe ingresar datos en al menos dos campos", MessageBoxIcon.Error)
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
        ElseIf TextBox1.Text <> "" And TextBox2.Text <> "" Then
            tiempo = Val(TextBox1.Text) / Val(TextBox2.Text)
            MsgBox("El tiempo calculado es de " + tiempo.ToString + " Segundos")
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
        ElseIf TextBox1.Text <> "" And TextBox3.Text <> "" Then
            vel = Val(TextBox1.Text) / Val(TextBox3.Text)
            MsgBox("La velocidad calculada es " + vel.ToString + " M/seg")
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
        ElseIf TextBox2.Text <> "" And TextBox3.Text <> "" Then
            dist = Val(TextBox2.Text) * Val(TextBox3.Text)
            MsgBox("La distancia calculada es " + dist.ToString + " Metros")
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""

        End If



    End Sub
    'Solo permite ingresar datos numericos
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    'Solo permite ingresar datos numericos
    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    'Solo permite ingresar datos numericos
    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
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