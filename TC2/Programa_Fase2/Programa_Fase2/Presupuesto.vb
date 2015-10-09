Public Class Presupuesto
    Dim dinero As Double
    Dim gastos(3, 100) As String

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim codigo As Integer
        If ComboBox2.SelectedItem = "Codigo" Then
            codigo = InputBox("ingrese el codigo")
            If gastos(codigo, 0) <> "" Then
                MsgBox("Valor del gasto " + gastos(codigo, 0) + "Tipo del gasto " + gastos(codigo, 1) + "Fecha del gastos " + gastos(codigo, 2))

            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        dinero = Val(TextBox1.Text)
        Label11.Text = TextBox1.Text
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

        If gastos(0, 0) = "" Then
            gastos(cont, 0) = TextBox2.Text
            gastos(cont, 1) = ComboBox1.SelectedItem
            gastos(cont, 2) = DateTimePicker1.Value
            gastos(cont, 3) = TextBox3.Text
            TextBox2.Text = ""
            TextBox3.Text = ""
            

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
            

        End If
    End Sub
End Class