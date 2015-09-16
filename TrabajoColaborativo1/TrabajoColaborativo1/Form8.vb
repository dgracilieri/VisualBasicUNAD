Public Class Form8

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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form7.Close()
        Me.Close()
        Form12.Show()
    End Sub

    'Ciclo para cambiar de colores de acuerdo al tipo de color seleccionado se evaluan y se aplica una accion para realizar el cambio de color
    'Determina los cambios de tamaño de letra, Determina los cambios de formato
    'Determina los cambios de fuentes de letra
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim tam As Integer
        Dim color As String
        tam = 0
        color = ComboBox2.SelectedItem


        If (color = "Rojo") Then
            Label5.ForeColor = Drawing.Color.Red
        ElseIf (color = "Verde") Then
            Label5.ForeColor = Drawing.Color.Green
        ElseIf (color = "Azul") Then
            Label5.ForeColor = Drawing.Color.Blue
        ElseIf (color = "Naranja") Then
            Label5.ForeColor = Drawing.Color.Orange

        End If


        If (ComboBox1.SelectedItem = "") Then
            Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8)
        Else
            Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", ComboBox1.SelectedItem)
        End If

        Dim fuente As String
        If ComboBox4.SelectedItem = "" Then
            fuente = ComboBox4.SelectedItem
        Else
            fuente = "Microsoft Sans Serif"
        End If

        If ComboBox3.SelectedItem = "Bold" And ComboBox1.SelectedItem = "" Then
            Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Bold)
        ElseIf ComboBox3.SelectedItem = "Bold" And ComboBox1.SelectedItem <> "" Then
            Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", ComboBox1.SelectedItem, FontStyle.Bold)

        ElseIf ComboBox3.SelectedItem = "Regular" And ComboBox1.SelectedItem = "" Then
            Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular)
        ElseIf ComboBox3.SelectedItem = "Regular" And ComboBox1.SelectedItem <> "" Then
            Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", ComboBox1.SelectedItem, FontStyle.Regular)
        ElseIf ComboBox3.SelectedItem = "Italic" And ComboBox1.SelectedItem = "" Then
            Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Italic)
        ElseIf ComboBox3.SelectedItem = "Italic" And ComboBox1.SelectedItem <> "" Then
            Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", ComboBox1.SelectedItem, FontStyle.Italic)

        End If


            If (ComboBox4.SelectedItem = "Arial" And ComboBox1.SelectedItem = "" and ComboBox3.SelectedItem = "" ) Then
            Label5.Font = New System.Drawing.Font("Arial", 8, FontStyle.Regular)
        ElseIf (ComboBox4.SelectedItem = "Arial" And ComboBox1.SelectedItem <> "" And ComboBox3.SelectedItem = "") Then
            Label5.Font = New System.Drawing.Font("Arial", ComboBox1.SelectedItem, FontStyle.Regular)
        ElseIf (ComboBox4.SelectedItem = "Arial" And ComboBox1.SelectedItem = "" And ComboBox3.SelectedItem <> "") Then
            If ComboBox3.SelectedItem = "Bold" Then
                Label5.Font = New System.Drawing.Font("Arial", 8, FontStyle.Bold)
            ElseIf ComboBox3.SelectedItem = "Italic" Then
                Label5.Font = New System.Drawing.Font("Arial", 8, FontStyle.Italic)
            Else
                Label5.Font = New System.Drawing.Font("Arial", 8, FontStyle.Regular)
            End If




  
            ElseIf (ComboBox4.SelectedItem = "Verdana" And ComboBox1.SelectedItem = "") Then
                Label5.Font = New System.Drawing.Font("Verdana", 8)
            ElseIf (ComboBox4.SelectedItem = "Verdana" And ComboBox1.SelectedItem <> "") Then
                Label5.Font = New System.Drawing.Font("Verdana", ComboBox1.SelectedItem)
            ElseIf (ComboBox4.SelectedItem = "Times New Roman" And ComboBox1.SelectedItem = "") Then
                Label5.Font = New System.Drawing.Font("Times New Roman", 8)
            ElseIf (ComboBox4.SelectedItem = "Times New Roman" And ComboBox1.SelectedItem) Then
                Label5.Font = New System.Drawing.Font("Times New Roman", ComboBox1.SelectedItem)
            ElseIf (ComboBox4.SelectedItem = "Calibri" And ComboBox1.SelectedItem = "") Then
                Label5.Font = New System.Drawing.Font("Calibri", 8)
            ElseIf (ComboBox4.SelectedItem = "Calibri" And ComboBox1.SelectedItem <> "") Then
                Label5.Font = New System.Drawing.Font("Calibri", ComboBox1.SelectedItem)

            End If
    End Sub



    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Label5.Text = ""
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
        ComboBox3.SelectedIndex = -1
        ComboBox4.SelectedIndex = -1
        Form7.Show()
    End Sub


    Private Sub Button2_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button2.MouseMove
        Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Bold)
    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Regular)
    End Sub
End Class