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

    'Public Sub carga_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    cerrar()

    'End Sub

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
            MsgBox("-Numero de identificacion" & vbNewLine & "-Nombre completo" & vbNewLine & "-Direccion de residencia" & vbNewLine & "-Telefono" & vbNewLine & "-Edad" & vbNewLine & "-Area", MsgBoxStyle.Information, "Datos minimos para la carga")

        Else

            Dim id, edad, tel, area As Integer
            Dim nom, dir As String
            id = TextBox1.Text
            edad = TextBox5.Text
            tel = TextBox4.Text
            nom = TextBox2.Text
            dir = TextBox3.Text

            If ComboBox1.SelectedItem = "Algoritmos" Then
                area = 1
            ElseIf ComboBox1.SelectedItem = "Estructuras de programacion basica en Visual Basic" Then
                area = 2
            ElseIf ComboBox1.SelectedItem = "Base de Datos" Then
                area = 3
            ElseIf ComboBox1.SelectedItem = "Multimedia" Then
                area = 4
            End If
            'Llamo a la funcion para realizar la conexion a la base de datos
            conectar()
            'Valido si existe un registro con esa cedula ingresado previamente
            If buscarced(TextBox1.Text) = 0 Then
                Dim strsql As String = "insert into estudiantes (identificacion, nombre, direccion, telefono, edad, idarea) "
                strsql += " VALUES (" & id & ",'" & nom & "','" & dir & "'," & tel & "," & edad & "," & area & ")"
                Dim cmd As New OleDb.OleDbCommand
                cmd.CommandType = CommandType.Text
                cmd.Connection = conn
                cmd.CommandText = strsql


                'Informo de errores en la carga del registro
                Try
                    cmd.ExecuteNonQuery()
                    MsgBox("Registro Cargado Existosamente", MsgBoxStyle.Information)
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

            Else
                MsgBox("La cedukla ya existe en el sistema y no es posible registrar cedulas duplicadas", MessageBoxIcon.Information, "Carga de registros")
            End If
        End If
        'Cierro la conexionn a la base de datos
        cerrar()


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


End Class