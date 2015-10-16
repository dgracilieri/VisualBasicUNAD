Public Class menu
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

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ArrayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArrayToolStripMenuItem.Click
        agendaf.Show()
    End Sub


    Private Sub Op1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Op1ToolStripMenuItem.Click
        distancia.Show()
    End Sub

    Private Sub Op2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Op2ToolStripMenuItem.Click
        Capitales.Show()
    End Sub

    Private Sub Op3ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Op3ToolStripMenuItem.Click
        Presupuesto.Show()
    End Sub

    Private Sub Op9ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Op9ToolStripMenuItem.Click

    End Sub

    Private Sub Op6ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Op6ToolStripMenuItem.Click
        Calififcaciones.Show()
    End Sub

    Private Sub Op4ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Op4ToolStripMenuItem.Click
        valida.Show()
    End Sub

    Private Sub Op5ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Op5ToolStripMenuItem.Click
        matrices.Show()
    End Sub

    Private Sub Op8ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Op8ToolStripMenuItem.Click
        Adivina.Show()
    End Sub
End Class