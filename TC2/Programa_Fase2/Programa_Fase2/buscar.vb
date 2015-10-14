Public Class buscar
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If TextBox1.Text = "" Then
            MsgBox("Error no ingreso datos", MessageBoxIcon.Error, "Busqueda")

        ElseIf TextBox1.Text = 0 Then
            MsgBox("Error la posicion no existe", MessageBoxIcon.Error, "Busqueda")
            TextBox1.Text = ""


        ElseIf agendaf.agenda(Val(TextBox1.Text) - 1, 0) = "" Then
            MsgBox("Error la posicion no existe", MessageBoxIcon.Error, "Busqueda")
            TextBox1.Text = ""


        Else
            
            buscacontacto.DataGridView1.Rows(0).Cells(0).Value = agendaf.agenda(Val(TextBox1.Text) - 1, 0)
            buscacontacto.DataGridView1.Rows(0).Cells(1).Value = agendaf.agenda(Val(TextBox1.Text) - 1, 1)
            buscacontacto.DataGridView1.Rows(0).Cells(2).Value = agendaf.agenda(Val(TextBox1.Text) - 1, 2)
            buscacontacto.DataGridView1.Rows(0).Cells(3).Value = agendaf.agenda(Val(TextBox1.Text) - 1, 3)
            buscacontacto.DataGridView1.Rows(0).Cells(4).Value = agendaf.agenda(Val(TextBox1.Text) - 1, 4)
            buscacontacto.DataGridView1.Rows(0).Cells(5).Value = agendaf.agenda(Val(TextBox1.Text) - 1, 5)

            Me.Hide()
            buscacontacto.Show()

        End If
    End Sub

    Private Sub Button1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseHover
        Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Bold)
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Regular)
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseHover
        Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Bold)
    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Regular)
    End Sub

    
    Private Sub buscar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class