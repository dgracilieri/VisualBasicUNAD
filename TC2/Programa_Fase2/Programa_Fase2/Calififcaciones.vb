Public Class Calififcaciones

    Private Sub Calififcaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Dim notas(20, 20) As String
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

            If notas(0, 3) = "" Then

                notas(0, 0) = TextBox1.Text
                notas(i, 1) = TextBox2.Text
                notas(i, 2) = ComboBox1.SelectedItem
                notas(0, 3) = TextBox3.Text
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                ComboBox1.SelectedIndex = -1

            Else
                While notas(i, 3) <> ""
                    i = i + 1
                End While
                notas(i, 0) = TextBox1.Text
                notas(i, 1) = TextBox2.Text
                notas(i, 2) = ComboBox1.SelectedItem
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
        Dim i, sum, cont, aux As Double
        sum = 0
        cont = 0
        For i = 0 To 20
            aux = notas(i, 3)
            sum = Val(sum) + Val(aux)
            If notas(i, 3) <> "" Then
                cont = cont + 1
            End If
        Next i
        sum = sum / cont
        MsgBox("El promedio de todas las notas ingresadas es: " + sum.ToString, MsgBoxStyle.OkOnly, "Promedio")

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim borrar As String
        borrar = InputBox("Ingrese el codigo del registro que desea borrar", "Borrado de registro")
        If IsNumeric(borrar) = False Or borrar = "" Then
            MsgBox("Debe ingresar un numeropara poder borrar el registro", MessageBoxIcon.Information, "Borrado de Registro")
        Else
            notas(borrar, 0) = ""
            notas(borrar, 1) = ""
            notas(borrar, 2) = ""
            notas(borrar, 3) = ""


        End If
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


    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
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

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
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
     
        Dim i, j, aux As Integer
        Dim notaso(20) As String

        'copio notas al vector
        For i = 0 To 20
            notaso(i) = notas(i, 3)
        Next i

        For i = 0 To 20 Step 1
            For j = 0 To 19 Step 1
                If notaso(j) > notaso(j + 1) Then
                    aux = Val(notaso(j + 1))

                    notaso(j + 1) = notaso(j)
                    notaso(j) = aux
                End If
            Next j
        Next i
        j = 0

        While notaso(j) = 0
            j = j + 1
        End While

        MsgBox("La nota menor  es: " + notaso(j).ToString, MsgBoxStyle.OkOnly, "Nota menor")


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim i, j, aux As Double
        Dim notaso(20) As Double

        'copio notas al vector
        For i = 0 To 20
            notaso(i) = notas(i, 3)
        Next i

        For i = 0 To 20 Step 1
            For j = 0 To 19 Step 1
                If notaso(j) < notaso(j + 1) Then
                    aux = Val(notaso(j + 1))
                    notaso(j + 1) = notaso(j)
                    notaso(j) = aux
                End If
            Next j
        Next i
        MsgBox("La nota mayor  es: " + notaso(0).ToString, MsgBoxStyle.OkOnly, "Nota mayor")
        
    End Sub
End Class

