Public Class arreglo
    Public arreglo(10) As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim i As Integer
        Dim x As Integer
        x = Val(TextBox3.Text) - 1
        TextBox3.Text = ""


        For i = 0 To Val(x)
            arreglo(i) = InputBox("Cargando")

            
        Next


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim aux As Integer
        Dim dato As String
        aux = Val(TextBox2.Text)
        dato = arreglo(aux)
        Label1.Text = dato
        Label1.Visible = True

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub arreglo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class