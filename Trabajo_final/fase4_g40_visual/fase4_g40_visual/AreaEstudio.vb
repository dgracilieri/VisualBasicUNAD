Public Class AreaEstudio
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
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        principal.Show()
    End Sub

    Private Sub AreaEstudio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim contenido As String
        contenido = ComboBox1.SelectedItem
        MsgBox(contenido.ToString)

        If contenido = "Algoritmo" Then
            ContenidoAlgotirmo.Show()
            Me.Close()
        ElseIf contenido = "Estructura de datos en Visual Basic" Then
            ContenidoVB.Show()
            Me.Close()
        ElseIf contenido = "Bases de datos" Then
            contenidoBD.Show()
            Me.Close()
        ElseIf contenido = "Multimedia" Then
            ContenidoMultimedia.Show()
            Me.Close()

        End If
    End Sub
End Class