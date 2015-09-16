Public Class Form16


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Form12.Show()

    End Sub

    
   

  
   
    Private Sub Button1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseMove
        Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Bold)
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Regular)
    End Sub
    

 

    Private Sub Button2_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button2.MouseMove
        Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Bold)
        Dim sonido As System.Media.SoundPlayer
        sonido = New System.Media.SoundPlayer(My.Resources.Alarm03)
        sonido.Play()
    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Regular)

    End Sub

    Private Sub Button3_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button3.MouseMove
        Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Bold)
        PictureBox1.Visible = True
        PictureBox1.Size = New System.Drawing.Size(100, 100)

    End Sub
    Private Sub Button3_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.MouseLeave
        Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Regular)
        PictureBox1.Visible = False
    End Sub


   
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        
    End Sub

    Private Sub Form16_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button4.MouseMove
        Me.Close()
        Form17.Show()

    End Sub

    Private Sub Button5_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button5.MouseMove
        Button5.Font = New System.Drawing.Font("Arial", 12, FontStyle.Bold)
        Button5.ForeColor = Color.DarkBlue
    End Sub

    Private Sub Button5_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.MouseLeave
        Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Regular)
        Button5.ForeColor = Color.Black


    End Sub
End Class