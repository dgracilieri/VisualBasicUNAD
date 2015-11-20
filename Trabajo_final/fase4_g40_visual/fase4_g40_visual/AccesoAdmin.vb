Public Class AccesoAdmin
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
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If cont = 3 Then
            MsgBox("Ya agoto su cantidad de intentos debe salir y volver a ingresar", MsgBoxStyle.Information, "Acceso de Administrador")

        End If
        If TextBox1.Text = "" Then
            MsgBox("Error de be ingresar  una contraseña", MsgBoxStyle.Exclamation, "Acceso de Administrador")

        ElseIf TextBox1.Text = 123 Then
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

    Private Sub AccesoAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class