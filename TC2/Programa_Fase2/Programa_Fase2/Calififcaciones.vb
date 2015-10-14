Public Class Calififcaciones

    Private Sub Calififcaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Dim notas(,) As String
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.SelectedItem = "" Then
            MsgBox("Debe diligenciar todos lo campos para realizar la carga de datos", MessageBoxIcon.Information, "Sistema de calififcaciones")
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            ComboBox1.SelectedIndex = -1

        Else
            Dim i As Integer
            i = 0
            Dim aux As String
            aux = 0

            If notas(0, 0) = "" Then
                notas(i, 0) = TextBox1.Text
                notas(i, 1) = TextBox2.Text
                notas(i, 1) = ComboBox1.SelectedItem
                notas(i, 3) = TextBox3.Text
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                ComboBox1.SelectedIndex = -1

            Else
                While aux <> ""
                    aux = notas(i, 0)
                    i = i + 1
                End While
                notas(i, 0) = TextBox1.Text
                notas(i, 1) = TextBox2.Text
                notas(i, 1) = ComboBox1.SelectedItem
                notas(i, 3) = TextBox3.Text
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                ComboBox1.SelectedIndex = -1


            End If
        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim i, sum, cont As Integer
        sum = 0
        cont = 1
        For i = 0 To notas.Length
            sum = sum + Val(notas(i, 3))
            cont = cont + 1
        Next i


        MsgBox(Val(sum / cont).ToString)

    End Sub
End Class