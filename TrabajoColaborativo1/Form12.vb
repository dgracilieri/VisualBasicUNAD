Public Class Form12
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


    Private Sub TimerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerToolStripMenuItem.Click

        Form4.Show()
    End Sub
    'Al pulsar sobre esta opcion del menu nos mostrara el formulario 5
    Private Sub CalculaTiempoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculaTiempoToolStripMenuItem.Click
        Form5.Show()
    End Sub
    'Al pulsar sobre esta opcion del menu nos mostrara el formulario 8 pero antes eliminara cualquier dato
    'almacenado en el Label5 del formulario 8
    Private Sub CambiaFormatoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambiaFormatoToolStripMenuItem.Click
        Form8.Label5.Text = ""
        Form8.Show()
    End Sub
    'Al pulsar sobre esta opcion del menu nos mostrara el formulario 9 pero antes eliminara cualquier dato
    'almacenado en el Label10, 11, 12 y 13 del formulario 9
    Private Sub CalculaSueldoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculaSueldoToolStripMenuItem.Click
        Form9.Label10.Text = ""
        Form9.Label11.Text = ""
        Form9.Label12.Text = ""
        Form9.Label13.Text = ""
        Form9.Show()
    End Sub
    'Al pulsar sobre esta opcion del menu nos mostrara el formulario 11
    Private Sub RecibeTextoONumerosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecibeTextoONumerosToolStripMenuItem.Click
        Form11.Show()
    End Sub

    'Al pulsar sobre esta opcion del menu nos mostrara el formulario 10 pero antes eliminara cualquier dato
    'almacenado en el Label7 del formulario 10
    Private Sub ProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductosToolStripMenuItem.Click
        Form10.Label7.Text = ""
        Form10.Show()
    End Sub

    'Al pulsar sobre esta opcion del menu nos mostrara el formulario 13
    Private Sub CalculadoraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculadoraToolStripMenuItem.Click
        Form13.Show()
    End Sub
    'Al pulsar sobre esta opcion del menu cerrara el programa
    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub SalirToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Form14.Show()
    End Sub
    'Al pulsar sobre esta opcion del menu cerrara el programa
    Private Sub SalirToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem1.Click
        Me.Close()
        Application.Exit()

    End Sub

    Private Sub ImagenesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImagenesToolStripMenuItem.Click
        Form15.Show()
    End Sub

    Private Sub MouseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MouseToolStripMenuItem.Click
        Form16.Show()
    End Sub
End Class