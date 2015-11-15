Public Class carga
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
    Public registro(1, 6) As String
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
        principal.Show()
    End Sub

    Public Sub carga_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conn.Close()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub


    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("-Numero de identificacion" & vbNewLine & "-Nombre completo" & vbNewLine & "-Direccion de residencia" & vbNewLine & "-Telefono" & vbNewLine & "-Edad" & vbNewLine & "-Programa", MsgBoxStyle.Information, "Datos minimos para la carga")

        Else

            Dim id, edad, tel, prog As Integer
            Dim nom, dir As String
            id = TextBox1.Text
            edad = TextBox5.Text
            tel = TextBox4.Text
            nom = TextBox2.Text
            dir = TextBox3.Text

            If ComboBox1.SelectedItem = "Derecho" Then
                prog = 6
            ElseIf ComboBox1.SelectedItem = "Ing. Sistemas" Then
                prog = 1
            ElseIf ComboBox1.SelectedItem = "Ing. Telecomunicaciones" Then
                prog = 2
            ElseIf ComboBox1.SelectedItem = "Psicologia" Then
                prog = 4
            ElseIf ComboBox1.SelectedItem = "Economia" Then
                prog = 5
            ElseIf ComboBox1.SelectedItem = "Agronomia" Then
                prog = 3
            ElseIf ComboBox1.SelectedItem = "Filosofia" Then
                prog = 7
            ElseIf ComboBox1.SelectedItem = "Sociologia" Then
                prog = 5



            End If
            'Llamo a la funcion para realizar la conexion a la base de datos
            conectar()
            Dim strsql As String = "insert into estudiantes (identificacion, nombre, direccion, telefono, edad, idprograma) "
            strsql += " VALUES (" & id & ",'" & nom & "','" & dir & "'," & tel & "," & edad & "," & prog & ")"
            Dim cmd As New OleDb.OleDbCommand
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            cmd.CommandText = strsql


            'Informo de errores en la carga del registro
            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro cargado", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            'Limpio formulario de carga de datos
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            ComboBox1.SelectedIndex = -1
            cerrar()

        End If


    End Sub

    Private Sub Button1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseHover
        Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Bold)
    End Sub
    Private Sub Button1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseMove
        Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Regular)
    End Sub

    Private Sub Button3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.MouseHover
        Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Bold)
    End Sub
    Private Sub Button3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button3.MouseMove
        Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Regular)
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub
End Class