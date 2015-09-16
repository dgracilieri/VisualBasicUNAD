Public Class Form4


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Form12.Show()
        Me.Hide()
    End Sub
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

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form12.Show()

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        WebBrowser1.Navigate(TextBox1.Text)

    End Sub

    'En este punto se evalua los valores minimos y maximos loas cuales debe alcanzar el proressbar1
    'En la primera asignacion de variable se asigna el valor maximo
    Private Sub WebBrowser1_ProgressChanged(sender As Object, e As WebBrowserProgressChangedEventArgs) Handles WebBrowser1.ProgressChanged
       
        ProgressBar1.Maximum = e.MaximumProgress
        If e.CurrentProgress = -1 Then ProgressBar1.Value = e.MaximumProgress
        If e.CurrentProgress >= e.MaximumProgress Then
            ProgressBar1.Value = ProgressBar1.Maximum
        End If
        If e.CurrentProgress <= "0" Then
            ProgressBar1.Value = ProgressBar1.Minimum
        End If

    End Sub

    'Muestra la url ingresada durante el tiempo que dura cargando la pagina web
    Private Sub Timer1_Tick_1(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick


        If (WebBrowser1.IsBusy = False) Then
            ToolStripStatusLabel1.Text = WebBrowser1.StatusText
        Else
            ToolStripStatusLabel1.Text = WebBrowser1.Url.ToString

        End If



    End Sub

    'Codigo para redimensionar el tamaño de los contenidos en caso que la venta sea maximizada
    Private Sub Form4_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        TextBox1.Width = Me.Width - 170
        TextBox1.Left = Me.Left + 70
        WebBrowser1.Width = Me.Width - 50
        WebBrowser1.Height = Me.Height - 140
        Button2.Left = Me.Width - 100
        Button1.Left = Me.Width - 130
        Button1.Top = Me.Height - 95

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        TextBox1.Focus()
    End Sub

    Private Sub Button1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseMove
        Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Bold)
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Regular)
    End Sub
End Class