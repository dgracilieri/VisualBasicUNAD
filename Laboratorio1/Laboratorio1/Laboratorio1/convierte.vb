Public Class convierte
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
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

   
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

    Private Sub TextBox3_keyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        If CheckBox1.Checked = True Then
            GroupBox2.Visible = True
        Else
            GroupBox2.Visible = False
        End If

    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        CheckBox1.Checked = False
        CheckBox3.Checked = False
        If CheckBox2.Checked = True Then
            GroupBox3.Visible = True
        Else
            GroupBox3.Visible = False
        End If

    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        CheckBox2.Checked = False
        CheckBox1.Checked = False
        If CheckBox3.Checked = True Then
            GroupBox4.Visible = True
        Else
            GroupBox4.Visible = False
        End If

    End Sub

   


  
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim aux As Double
        If CheckBox1.Checked = True Then
            If ComboBox1.SelectedItem = "Centimetros" And ComboBox4.SelectedItem = "Centimetros" Then
                MsgBox("No hay comversion a realizar ya que la operacion no requiere conversion", MsgBoxStyle.OkOnly, "Conversion de unidades")
                TextBox1.Text = ""
            ElseIf ComboBox1.SelectedItem = "Centimetros" And ComboBox4.SelectedItem = "Metros" Then
                aux = Val(TextBox1.Text) * 0.01
                MsgBox(aux.ToString + " Metro", MsgBoxStyle.OkOnly, "Conversion de unidades")
                TextBox1.Text = ""
            ElseIf ComboBox1.SelectedItem = "Centimetros" And ComboBox4.SelectedItem = "Km" Then
                aux = Val(TextBox1.Text) * 0.00001
                MsgBox(aux.ToString + " Km", MsgBoxStyle.OkOnly, "Conversion de unidades")
                TextBox1.Text = ""
            ElseIf ComboBox1.SelectedItem = "Metros" And ComboBox4.SelectedItem = "Centimetros" Then
                aux = Val(TextBox1.Text) * 100
                MsgBox(aux.ToString + " Centimetros", MsgBoxStyle.OkOnly, "Conversion de unidades")
                TextBox1.Text = ""
            ElseIf ComboBox1.SelectedItem = "Metros" And ComboBox4.SelectedItem = "Metros" Then
                MsgBox("No hay comversion a realizar ya que la operacion no requiere conversion", MsgBoxStyle.OkOnly, "Conversion de unidades")
                TextBox1.Text = ""
            ElseIf ComboBox1.SelectedItem = "Metros" And ComboBox4.SelectedItem = "Km" Then
                aux = Val(TextBox1.Text) * 0.001
                MsgBox(aux.ToString + " Km", MsgBoxStyle.OkOnly, "Conversion de unidades")
                TextBox1.Text = ""
            ElseIf ComboBox1.SelectedItem = "Km" And ComboBox4.SelectedItem = "Centimetros" Then
                aux = Val(TextBox1.Text) * 100000
                MsgBox(aux.ToString + " Centimetros", MsgBoxStyle.OkOnly, "Conversion de unidades")
                TextBox1.Text = ""
            ElseIf ComboBox1.SelectedItem = "Km" And ComboBox4.SelectedItem = "Metros" Then
                aux = Val(TextBox1.Text) * 1000
                MsgBox(aux.ToString + " Centimetros", MsgBoxStyle.OkOnly, "Conversion de unidades")
                TextBox1.Text = ""
            ElseIf ComboBox1.SelectedItem = "Km" And ComboBox4.SelectedItem = "Km" Then
                MsgBox("No hay comversion a realizar ya que la operacion no requiere conversion", MsgBoxStyle.OkOnly, "Conversion de unidades")
                TextBox1.Text = ""

            End If
        ElseIf CheckBox2.Checked = True Then
            If ComboBox2.SelectedItem = "M/s" And ComboBox6.SelectedItem = "Km/h" Then
                aux = Val(Val(TextBox2.Text) / 1000) * 3600
                MsgBox(aux.ToString + " Km/h", MsgBoxStyle.OkOnly, "conversion de unidades")
                TextBox2.Text = ""
            ElseIf ComboBox2.SelectedItem = "Km/h" And ComboBox6.SelectedItem = "M/s" Then
                aux = Val(Val(TextBox2.Text) * 3600) / 1000
                MsgBox(aux.ToString + " M/s", MsgBoxStyle.OkOnly, "conversion de unidades")
                TextBox2.Text = ""
            ElseIf ComboBox2.SelectedItem = "M/s" And ComboBox6.SelectedItem = "M/s" Then
                MsgBox("No hay comversion a realizar ya que la operacion no requiere conversion", MsgBoxStyle.OkOnly, "Conversion de unidades")
                TextBox2.Text = ""
            ElseIf ComboBox2.SelectedItem = "Km/h" And ComboBox6.SelectedItem = "Km/h" Then
                MsgBox("No hay comversion a realizar ya que la operacion no requiere conversion", MsgBoxStyle.OkOnly, "Conversion de unidades")
                TextBox2.Text = ""

            End If

        ElseIf CheckBox3.Checked = True Then
            If ComboBox3.SelectedItem = "Segundo" And ComboBox5.SelectedItem = "Segundo" Then
                MsgBox("No hay comversion a realizar ya que la operacion no requiere conversion", MsgBoxStyle.OkOnly, "Conversion de unidades")
                TextBox3.Text = ""
            ElseIf ComboBox3.SelectedItem = "Segundo" And ComboBox5.SelectedItem = "Minuto" Then
                aux = Val(TextBox3.Text) * 0.01666666667
                MsgBox(aux.ToString + " Minutos", MsgBoxStyle.OkOnly, "Conversion de unidades")
                TextBox3.Text = ""
            ElseIf ComboBox3.SelectedItem = "Segundo" And ComboBox5.SelectedItem = "Hora" Then
                aux = Val(TextBox3.Text) * 0.000277777778
                MsgBox(aux.ToString + " Horas", MsgBoxStyle.OkOnly, "Conversion de unidades")
                TextBox3.Text = ""
            ElseIf ComboBox3.SelectedItem = "Minuto" And ComboBox5.SelectedItem = "Segundo" Then
                aux = Val(TextBox3.Text) * 60
                MsgBox(aux.ToString + " Minutos", MsgBoxStyle.OkOnly, "Conversion de unidades")
                TextBox3.Text = ""
            ElseIf ComboBox3.SelectedItem = "Minuto" And ComboBox5.SelectedItem = "Hora" Then
                aux = Val(TextBox3.Text) * 0.01666666667
                MsgBox(aux.ToString + " Horas", MsgBoxStyle.OkOnly, "Conversion de unidades")
                TextBox3.Text = ""
            ElseIf ComboBox3.SelectedItem = "Minuto" And ComboBox5.SelectedItem = "Minuto" Then
                MsgBox("No hay comversion a realizar ya que la operacion no requiere conversion", MsgBoxStyle.OkOnly, "Conversion de unidades")
                TextBox3.Text = ""
            ElseIf ComboBox3.SelectedItem = "Hora" And ComboBox5.SelectedItem = "Segundo" Then
                aux = Val(TextBox3.Text) * 3600
                MsgBox(aux.ToString + " Minutos", MsgBoxStyle.OkOnly, "Conversion de unidades")
                TextBox3.Text = ""
            ElseIf ComboBox3.SelectedItem = "Hora" And ComboBox5.SelectedItem = "Minuto" Then
                aux = Val(TextBox3.Text) * 60
                MsgBox(aux.ToString + " Horas", MsgBoxStyle.OkOnly, "Conversion de unidades")
                TextBox3.Text = ""
            ElseIf ComboBox3.SelectedItem = "Hora" And ComboBox5.SelectedItem = "Hora" Then
                MsgBox("No hay comversion a realizar ya que la operacion no requiere conversion", MsgBoxStyle.OkOnly, "Conversion de unidades")
                TextBox3.Text = ""

            End If


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

    Private Sub convierte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class