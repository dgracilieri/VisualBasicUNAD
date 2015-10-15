Public Class cargadestino

    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer
        i = ComboBox1.SelectedItem
        If ComboBox1.SelectedItem >= i Then
            i = i - 1
            TextBox1.Text = ""
            ComboBox1.SelectedIndex = -1

        Else
            Me.Hide()

        End If


  
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox1.Visible = False
        TextBox1.Visible = True
    End Sub
End Class