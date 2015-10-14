Public Class Presupuesto
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
    Dim dinero As Double
    Dim gastos(3, 100) As String
    Dim codigo As Integer
    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged

        If ComboBox2.SelectedItem = "Codigo" And ComboBox2.Focus Then
            'codigo = InputBox("ingrese el codigo")
            Label12.Visible = True
            TextBox4.Visible = True
            Button6.Visible = True
            codigo = Val(TextBox4.Text)
        ElseIf ComboBox2.SelectedItem = "Todos" And ComboBox2.Focus Then


            Panel6.Visible = True
            Dim i As Integer
            DataGridView1.Rows.Add()
            Do
                Panel6.Visible = True
                DataGridView1.Rows(i).Cells(0).Value = gastos(i, 0)
                DataGridView1.Rows(i).Cells(1).Value = gastos(i, 1)
                DataGridView1.Rows(i).Cells(2).Value = gastos(i, 2)
                DataGridView1.Rows(i).Cells(3).Value = gastos(i, 3)

                i = i + 1

            Loop While gastos(i, 0) <> ""



        Else
            Panel6.Visible = False

        End If




    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        dinero = Val(TextBox1.Text)
        Label11.Text = Val(TextBox1.Text) + Val(Label11.Text)
        TextBox1.Text = ""
    End Sub




    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSymbol(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = False
        Else

            e.Handled = True
        End If
    End Sub

    Private Sub Presupuesto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label11.Text = "0"

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim cont As Integer
        cont = 0
        Dim restante As Double
        restante = Val(Label11.Text)





        If Val(TextBox2.Text) > Val(Label11.Text) Or Label11.Text < 0 Then
            MsgBox("El valor que desea ingresar supera su presupuesto", MessageBoxIcon.Information, "Presupuesto")
            TextBox2.Text = ""
            TextBox3.Text = ""
            ComboBox1.SelectedIndex = -1
            DateTimePicker1.Checked = False


        Else

            If TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.SelectedItem = "" Or DateTimePicker1.Checked = False Then
                MsgBox("Debe completar todos los campos para realizar la carga", MessageBoxIcon.Information, "Presupuesto")
                TextBox2.Text = ""
                TextBox3.Text = ""
                ComboBox1.SelectedIndex = -1
                DateTimePicker1.Checked = False
            Else
                Label11.Text = Val(Label11.Text) - Val(TextBox2.Text)

                If gastos(0, 0) = "" Then
                    gastos(cont, 0) = TextBox2.Text
                    gastos(cont, 1) = ComboBox1.SelectedItem
                    gastos(cont, 2) = DateTimePicker1.Value
                    gastos(cont, 3) = TextBox3.Text
                    TextBox2.Text = ""
                    TextBox3.Text = ""
                    ComboBox1.SelectedIndex = -1
                Else
                    While gastos(cont, 0) <> ""
                        cont = cont + 1

                    End While

                    gastos(cont, 0) = TextBox2.Text
                    gastos(cont, 1) = ComboBox1.SelectedItem
                    gastos(cont, 2) = DateTimePicker1.Value
                    gastos(cont, 3) = TextBox3.Text
                    TextBox2.Text = ""
                    TextBox3.Text = ""
                    ComboBox1.SelectedIndex = -1
                    DateTimePicker1.Checked = False


                End If
            End If
        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Label11.Text = ""
    End Sub


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Hide()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim pos As Integer
        InputBox("Ingrese la posicion del registro", MsgBoxStyle.OkOnly, "borrado")
        gastos(pos, 0) = ""
        gastos(pos, 1) = ""
        gastos(pos, 2) = ""
        gastos(pos, 3) = ""
    End Sub


    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If gastos(codigo, 0) <> "" Then
            Panel6.Visible = True

            DataGridView1.Rows(0).Cells(0).Value = gastos(codigo, 0)
            DataGridView1.Rows(0).Cells(1).Value = gastos(codigo, 1)
            DataGridView1.Rows(0).Cells(2).Value = gastos(codigo, 2)
            DataGridView1.Rows(0).Cells(3).Value = gastos(codigo, 3)
        End If


    End Sub


End Class