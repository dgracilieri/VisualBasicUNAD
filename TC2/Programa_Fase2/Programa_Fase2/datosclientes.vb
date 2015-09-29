Public Class datosclientes
    Public matriz(2, 10) As String
    Dim i As Integer
    Dim x As Integer
    Dim contador As Integer

    Private Sub datosclientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        Dim x As Integer
        While contador <= Val(arreglo.TextBox2.Text)
            contador = contador + 1
            For i = 0 To Val(arreglo.TextBox2.Text)
                matriz(i, x) = Label2.Text
                For x = 0 To Val(arreglo.TextBox2.Text)
                    matriz(i, x) = TextBox1.Text
                    x = x + 1
                    matriz(i, x) = TextBox2.Text
                Next
            Next

        End While
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Label2.Text = contador

    End Sub
End Class