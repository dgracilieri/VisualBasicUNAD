Public Class Form5

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

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        Me.Close()
        Form12.Show()
    End Sub

    'En este Button se realizan todos los calculos 
    '1. Declaran variables privadas
    '2. Se evaluan condiciones que debn cumplirse para cada caso
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dist As Double
        Dim tiempo As Double
        Dim vel As Double
        Dim res As Double

        If (TextBox1.Text <> "" And TextBox2.Text <> "" And ComboBox1.SelectedItem = "Metros" And ComboBox2.SelectedItem = "Segundos") Then

            dist = Val(TextBox1.Text) * 0.001
            tiempo = Val(TextBox2.Text) * 0.03
            res = dist / tiempo
            MsgBox(res & " " & "KM/h", MsgBoxStyle.OkOnly, "Calculo Velocidad")
            TextBox1.Text = ""
            TextBox2.Text = ""

        ElseIf (TextBox1.Text <> "" And TextBox2.Text <> "" And ComboBox1.SelectedItem = "Metros" And ComboBox2.SelectedItem = "Minutos") Then
            dist = Val(TextBox1.Text) * 0.001
            tiempo = Val(TextBox2.Text) * 0.016
            res = dist / tiempo
            MsgBox(res & " " & "KM/h", MsgBoxStyle.OkOnly, "Calculo Velocidad")
            TextBox1.Text = ""
            TextBox2.Text = ""

        ElseIf (TextBox1.Text <> "" And TextBox2.Text <> "" And ComboBox1.SelectedItem = "Metros" And ComboBox2.SelectedItem = "Horas") Then
            dist = Val(TextBox1.Text) * 0.001
            tiempo = Val(TextBox2.Text)
            res = dist / tiempo
            MsgBox(res & " " & "KM/h", MsgBoxStyle.OkOnly, "Calculo Velocidad")
            TextBox1.Text = ""
            TextBox2.Text = ""

        ElseIf (TextBox1.Text <> "" And TextBox2.Text <> "" And ComboBox1.SelectedItem = "Kilometros" And ComboBox2.SelectedItem = "Segundos") Then
            dist = Val(TextBox1.Text)
            tiempo = Val(TextBox2.Text) * 0.03
            res = dist / tiempo
            MsgBox(res & " " & "KM/h", MsgBoxStyle.OkOnly, "Calculo Velocidad")
            TextBox1.Text = ""
            TextBox2.Text = ""

        ElseIf (TextBox1.Text <> "" And TextBox2.Text <> "" And ComboBox1.SelectedItem = "Kilometros" And ComboBox2.SelectedItem = "Minutos") Then
            dist = Val(TextBox1.Text)
            tiempo = Val(TextBox2.Text) * 0.016
            res = dist / tiempo
            MsgBox(res & " " & "KM/h", MsgBoxStyle.OkOnly, "Calculo Velocidad")
            TextBox1.Text = ""
            TextBox2.Text = ""

        ElseIf (TextBox1.Text <> "" And TextBox2.Text <> "" And ComboBox1.SelectedItem = "Kilometros" And ComboBox2.SelectedItem = "Horas") Then
            dist = Val(TextBox1.Text)
            tiempo = Val(TextBox2.Text)
            res = dist / tiempo
            MsgBox(res & " " & "KM/h", MsgBoxStyle.OkOnly, "Calculo Velocidad")
            TextBox1.Text = ""
            TextBox2.Text = ""

        ElseIf (TextBox1.Text <> "" And TextBox3.Text <> "" And ComboBox1.SelectedItem = "Metros" And ComboBox3.SelectedItem = "Km/h") Then
            dist = Val(TextBox1.Text) * 0.001
            vel = Val(TextBox3.Text)
            res = dist / vel
            MsgBox(res & " " & "Horas", MsgBoxStyle.OkOnly, "Calculo de tiempo")
            TextBox1.Text = ""
            TextBox3.Text = ""

        ElseIf (TextBox1.Text <> "" And TextBox3.Text <> "" And ComboBox1.SelectedItem = "Kilometros" And ComboBox3.SelectedItem = "Km/h") Then
            dist = Val(TextBox1.Text)
            vel = Val(TextBox3.Text)
            res = dist / vel
            MsgBox(res & " " & "Horas", MsgBoxStyle.OkOnly, "Calculo de tiempo")
            TextBox1.Text = ""
            TextBox3.Text = ""

        ElseIf (TextBox2.Text <> "" And TextBox3.Text <> "" And ComboBox2.SelectedItem = "Segundos" And ComboBox3.SelectedItem = "Km/h") Then
            tiempo = Val(TextBox2.Text) * 0.001
            dist = Val(TextBox3.Text)
            res = tiempo * dist
            MsgBox(res & " " & "KM", MsgBoxStyle.OkOnly, "Calculo de distancia")
            TextBox3.Text = ""
            TextBox2.Text = ""

        ElseIf (TextBox2.Text <> "" And TextBox3.Text <> "" And ComboBox2.SelectedItem = "Minutos" And ComboBox3.SelectedItem = "Km/h") Then
            tiempo = Val(TextBox2.Text) * 0.03
            dist = Val(TextBox3.Text)
            res = tiempo * dist
            MsgBox(res & " " & "KM", MsgBoxStyle.OkOnly, "Calculo de distancia")
            TextBox3.Text = ""
            TextBox2.Text = ""

        ElseIf (TextBox2.Text <> "" And TextBox3.Text <> "" And ComboBox2.SelectedItem = "horas" And ComboBox3.SelectedItem = "Km/h") Then
            tiempo = Val(TextBox2.Text)
            dist = Val(TextBox3.Text)
            res = tiempo * dist
            MsgBox(res & " " & "KM", MsgBoxStyle.OkOnly, "Calculo de distancia")
            TextBox3.Text = ""
            TextBox2.Text = ""

        ElseIf (TextBox2.Text <> "" And TextBox3.Text <> "" And ComboBox2.SelectedItem = "Segundos" And ComboBox3.SelectedItem = "M/s") Then
            tiempo = Val(TextBox2.Text) * 0.001
            dist = Val(TextBox3.Text) * 3.6
            res = tiempo * dist
            MsgBox(res & " " & "KM", MsgBoxStyle.OkOnly, "Calculo de distancia")
            TextBox3.Text = ""
            TextBox2.Text = ""

        ElseIf (TextBox2.Text <> "" And TextBox3.Text <> "" And ComboBox2.SelectedItem = "Minutos" And ComboBox3.SelectedItem = "M/s") Then
            tiempo = Val(TextBox2.Text) * 0.03
            dist = Val(TextBox3.Text) * 3.6
            res = tiempo * dist
            MsgBox(res & " " & "KM", MsgBoxStyle.OkOnly, "Calculo de distancia")
            TextBox3.Text = ""
            TextBox2.Text = ""

        ElseIf (TextBox2.Text <> "" And TextBox3.Text <> "" And ComboBox2.SelectedItem = "horas" And ComboBox3.SelectedItem = "M/s") Then
            tiempo = Val(TextBox2.Text)
            dist = Val(TextBox3.Text) * 3.6
            res = tiempo * dist
            MsgBox(res & " " & "KM", MsgBoxStyle.OkOnly, "Calculo de distancia")
            TextBox3.Text = ""
            TextBox2.Text = ""
        Else
            MsgBox("los datos ingresados son insuficientes", MessageBoxIcon.Error)
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
        End If
    End Sub

End Class