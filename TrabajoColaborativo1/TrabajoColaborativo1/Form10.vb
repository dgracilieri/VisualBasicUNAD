Public Class Form10

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

    'Al pulsar el boton cierra el formulario actual y me lleva al formulario 12 donde esta el menu de opciones
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        Form12.Show()
    End Sub

    'Combobox donde de acuerdo a la opcion seleccionada imprimira en la pantalla un mensaje
    'en el Label7, para realizar esto se utiliza una estructura de seleccion IF ELSEIF
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If (ComboBox1.SelectedItem = "1. Aseo personal") Then
            Label7.Text = "20%"
        ElseIf (ComboBox1.SelectedItem = "2. Aseo del hogar") Then
            Label7.Text = "25%"
        Else
            Label7.Text = "0%"
        End If
    End Sub

    'Al pulsar este boton se realizaran un serie de operaciones y calculos
    'que a continuacion seran descriptas en cada seccion del codigo
    'Declaracion de variables
    'Calculo de descuento dependiendo del valor base del producto, este valor es obtenido de la operacion
    'realizada en el comboBox1 para determinar el descuento por esta razon se esta consultando el valor
    'almacenado en el Label7
    'para realizar esto se utiliza una estructura de seleccion IF ELSEIF donde el valor obtenido
    'se almacena el la variable desc
    'Calculo del porcentaje de iva aplicado sobre el valor base del producto
    'el valor obtenido es almacenado en la variable iva
    'Imprime dentro del textbox5 el valor final del producto
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
       
        Dim desc As Double
        Dim cant As Double
        Dim iva As Double

        cant = Val(TextBox1.Text) * Val(TextBox3.Text)
        
        If (Label7.Text = "20%") Then
            desc = (Val(TextBox3.Text) * 0.2) * Val(TextBox1.Text)
        ElseIf (Label7.Text = "25%") Then
            desc = (Val(TextBox3.Text) * 0.25) * Val(TextBox1.Text)
        Else
            desc = 0
        End If

        If (ComboBox2.SelectedItem = "8 %") Then
            iva = (Val(TextBox3.Text) * 0.08) * Val(TextBox1.Text)

        ElseIf (ComboBox2.SelectedItem = "16 %") Then

            iva = (Val(TextBox3.Text) * 0.16) * Val(TextBox1.Text)
        ElseIf (ComboBox2.SelectedItem = "21 %") Then
            iva = (Val(TextBox3.Text) * 0.21) * Val(TextBox1.Text)

        End If

        TextBox5.Text = (cant - desc) + iva
    End Sub

 
    Private Sub Button2_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button2.MouseMove
        Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Bold)
    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Regular)
    End Sub

  
End Class