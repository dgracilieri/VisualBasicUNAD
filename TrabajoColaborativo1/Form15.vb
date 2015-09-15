Public Class Form15

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

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
        Form12.Show()
    End Sub

    Private Sub Form15_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    'Boton  de Algoritmos
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'Redimensiona el formulario
        Me.Size = New System.Drawing.Size(600, 520)
        'Ubicacion del formulario centrado
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Location = New Point(700, 200)
        'Cambia propiedad de visible en los botones
        Button7.Visible = True
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        'Cambia la ubicacion del PictureBox en base el nuevo tamaño del formulario y le asigna un nuevo tamaño
        PictureBox1.Location = New Point(10, 10)
        PictureBox1.Size = New System.Drawing.Size(400, 400)
        'Cambia la ubicacion de los botones y el TextBox en base el nuevo tamaño del formulario
        Button7.Location = New Point(12, 435)
        Button5.Location = New Point(460, 435)
        PictureBox1.Visible = True
        TextBox1.Visible = True
        TextBox1.Location = New Point(430, 10)
        'Cambiat tamaño del TextBox
        TextBox1.Size = New System.Drawing.Size(140, 400)
        TextBox1.Text = "Se utilizan para resolver problemas de diferentes tipos generalmente en las areas de las Matematicas, logica y Ciencia de la computacion"

    End Sub
    'Boton para volver al menu del programa
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        'Cambia propiedad de visible en los botones
        Button1.Visible = True
        Button2.Visible = True
        Button3.Visible = True
        Button4.Visible = True
        Button7.Visible = False
        TextBox1.Visible = False
        TextBox2.Visible = False
        TextBox3.Visible = False
        'Redimensiona el formulario
        Me.Size = New System.Drawing.Size(305, 276)
        'Ubicacion del formulario en la pantalla
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Location = New Point(800, 350)


        Button5.Location = New Point(172, 183)
        'Vuelve a ocultar el PictureBox
        If PictureBox1.Visible = True Then
            PictureBox1.Visible = False
        ElseIf PictureBox2.Visible = True Then
            PictureBox2.Visible = False
        ElseIf PictureBox3.Visible = True Then
            PictureBox3.Visible = False
        ElseIf PictureBox4.Visible = True Then
            PictureBox4.Visible = False
        End If
    End Sub
    'Boton de estructura de datos
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Redimensiona el formulario
        Me.Size = New System.Drawing.Size(540, 480)
        'Ubicacion del formulario centrado
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Location = New Point(700, 200)
        'Cambia propiedad de visible en los botones
        Button7.Visible = True
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        'Cambia la ubicacion del PictureBox en base el nuevo tamaño del formulario y le asigna un nuevo tamaño
        PictureBox2.Location = New Point(10, 10)
        PictureBox2.Size = New System.Drawing.Size(497, 374)
        'Cambia la ubicacion de los botones y el TextBox en base el nuevo tamaño del formulario
        Button7.Location = New Point(12, 395)
        Button5.Location = New Point(410, 395)
        PictureBox2.Visible = True
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    'Boton de base de datos
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Redimensiona el formulario
        Me.Size = New System.Drawing.Size(600, 510)
        'Ubicacion del formulario centrado
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Location = New Point(700, 200)
        'Cambia propiedad de visible en los botones
        Button7.Visible = True
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        'Cambia la ubicacion del PictureBox en base el nuevo tamaño del formulario y le asigna un nuevo tamaño
        PictureBox3.Location = New Point(10, 10)
        PictureBox3.Size = New System.Drawing.Size(400, 405)
        'Cambia la ubicacion de los botones y el TextBox en base el nuevo tamaño del formulario
        Button7.Location = New Point(12, 425)
        Button5.Location = New Point(460, 425)
        PictureBox3.Visible = True
        TextBox2.Visible = True
        TextBox2.Location = New Point(420, 10)
        'Cambia tamaño del TextBox
        TextBox2.Size = New System.Drawing.Size(150, 400)
        TextBox2.Text = "Base de datos"
    End Sub
    'Boton de multimedia
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'Redimensiona el formulario
        Me.Size = New System.Drawing.Size(485, 550)
        'Ubicacion del formulario centrado
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Location = New Point(700, 200)
        'Cambia propiedad de visible en los botones
        Button7.Visible = True
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        'Cambia la ubicacion del PictureBox en base el nuevo tamaño del formulario y le asigna un nuevo tamaño
        PictureBox4.Location = New Point(10, 10)
        PictureBox4.Size = New System.Drawing.Size(450, 337)
        'Cambia la ubicacion de los botones y el TextBox en base el nuevo tamaño del formulario
        Button7.Location = New Point(12, 470)
        Button5.Location = New Point(360, 470)
        PictureBox4.Visible = True
        TextBox3.Visible = True
        TextBox3.Location = New Point(12, 360)
        'Cambia tamaño del TextBox
        TextBox3.Size = New System.Drawing.Size(445, 100)
        TextBox3.Text = "Multimedia"
    End Sub
End Class