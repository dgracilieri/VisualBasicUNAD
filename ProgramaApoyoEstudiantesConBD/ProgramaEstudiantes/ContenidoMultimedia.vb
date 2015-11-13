Public Class ContenidoMultimedia


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        acceso.Show()
        Me.Close()
    End Sub

    Private Sub Button3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.MouseHover
        Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Bold)
    End Sub
    Private Sub Button3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button3.MouseMove
        Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Regular)
    End Sub
End Class