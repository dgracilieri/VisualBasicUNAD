Public Class menu

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ArrayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArrayToolStripMenuItem.Click
        agendaf.Show()
    End Sub

  
    Private Sub Op1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Op1ToolStripMenuItem.Click
        distancia.Show()
    End Sub
End Class