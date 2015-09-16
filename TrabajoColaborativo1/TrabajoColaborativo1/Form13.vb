Public Class Form13
    Dim res As Double
    Dim potencia As Integer

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

    'Al pulsar sobre esta opcion del menu nos mostrara el formulario 12 pero antes cerrara el formulario actual
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
        Form12.Show()
    End Sub

    'Posiciona en curso en el TextBox1
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Focus()
    End Sub

    'Al pulsar el Button1 limpiara los datos almacenados en los TextBox1,2,3 y 4
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub
    'Boton para realizar la operacion del producto
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
       


        'Evalua si la base de los numeros a operar son iguales
        'Como la base son iguales procede a realizar la suma de potencias
        'Resuelvo el numero elevando el numero al exponente obtenido
        'Evalua si los numeros a operar poseen base diferente pero el mismo exponente
        'para lo cual evalua si el el contenido del TextBox1 es diferente al contenido del TextBox3 y 
        'ademas debe cumplir la condicion que el contenido del TextBox2 y el TextBox4 sean iguales
        'Almacena el contenido de TextBox2 en la variable potencia
        'Realiza el calculo de realizas el producto de los datos contenidos
        'en el TextBox1 y el TextBox3 para luego elevarlo a la potencia y por ultimo lo almacena 
        'en la variable res
        'Muestra en una ventana adicional el contenido de la variable res y se le asigna un mensaje
        'en la parte superior de esta ventana
        'En el caso que no se cumpla ninguna de las condiciones anteriores aparece una ventana
        'adicional dando un mesaje con un simbolo de error
        'Luego de realizar todas las operaciones limpia cada uno de los TextBox y posiciona el cursor en 
        'el TextBox1
        If (TextBox1.Text = TextBox3.Text) Then

            potencia = Val(TextBox2.Text) + Val(TextBox4.Text)
            res = Val(TextBox1.Text) ^ potencia
            MsgBox(res, MessageBoxButtons.OK, "Resultado")

        ElseIf (TextBox1.Text <> TextBox3.Text) And (TextBox2.Text = TextBox4.Text) Then

            potencia = TextBox2.Text
            res = (Val(TextBox1.Text) * Val(TextBox3.Text)) ^ potencia
            MsgBox(res, MessageBoxButtons.OK, "Resultado")


        Else
           
            MsgBox("Para poder procesar los datos deben tener la misma base o mismo exponente", MessageBoxIcon.Error, "Resultado")

        End If


        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox1.Focus()


    End Sub
    'Boton para realizar la operacion de la division 
    'Condicional IF donde evalua que el contenido del TextBox1 sea igual al TextBox2
    'Si la condicion se cumple entonces realiza la resta entre los exponentes
    'que estan almacenados en TextBox2 y TextBox4 y este resultado es lamacenado en la 
    'variable potencia
    'Este condicional esta dentro del anterior donde ademas evalua que potencia no sea un numero
    'negativo ya que en tal caso debra tomar acciones
    'Si el resultado de la condicion se cumple primero divide 1 sobre el valor del TextBox1
    'y luego lo eleva al valor absoluto del exponente
    'Muestra en una ventana adicional el contenido de la variable res y se le asigna un mensaje
    'en la parte superior de esta ventana
    'Como solo se cumplio el primer condicional esto quiere decir que potencia no dio un numero
    'negativo como resultado, entonces simplemente realiza la operacion y lo almacena en la variable res
    'Muestra en una ventana adicional el contenido de la variable res y se le asigna un mensaje
    'en la parte superior de esta ventana
    'Luego de realizar todas las operaciones limpia cada uno de los TextBox y posiciona el cursor en 
    'el TextBox1
    'Evalua si los numeros a operar poseen base diferente pero el mismo exponente
    'para lo cual evalua si el el contenido del TextBox1 es diferente al contenido del TextBox3 y 
    'ademas debe cumplir la condicion que el contenido del TextBox2 y el TextBox4 sean iguales
    'Almacena el contenido de TextBox2 en la variable potencia
    'Realiza el calculo de realizas la division de los datos contenidos
    'en el TextBox1 y el TextBox3 para luego elevarlo a la potencia y por ultimo lo almacena 
    'en la variable res
    'Muestra en una ventana adicional el contenido de la variable res y se le asigna un mensaje
    'en la parte superior de esta ventana
    'En el caso que no se cumpla ninguna de las condiciones anteriores aparece una ventana
    'adicional dando un mesaje con un simbolo de error
    'Luego de realizar todas las operaciones limpia cada uno de los TextBox y posiciona el cursor en 
    'el TextBox1
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        If (TextBox1.Text = TextBox3.Text) Then
         
            potencia = Val(TextBox2.Text) - Val(TextBox4.Text)

            If (potencia < 0) Then
              
                res = (1 / Val(TextBox1.Text)) ^ Math.Abs(potencia)
                MsgBox(res, MessageBoxButtons.OK, "Resultado")

            Else

                res = Val(TextBox1.Text) ^ potencia
                MsgBox(res, MessageBoxButtons.OK, "Resultado")


            End If
           
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox1.Focus()

        ElseIf (TextBox1.Text <> TextBox3.Text) And (TextBox2.Text = TextBox4.Text) Then

            potencia = TextBox2.Text
            res = (Val(TextBox1.Text) / Val(TextBox3.Text)) ^ potencia
            MsgBox(res, MessageBoxButtons.OK, "Resultado")

        Else
          
            MsgBox("Para poder procesar los datos deben tener la misma base o mismo expornente", MessageBoxIcon.Error)

        End If
      

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox1.Focus()

    End Sub

    Private Sub Button3_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button3.MouseMove
        Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Bold)
    End Sub

    Private Sub Button3_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.MouseLeave
        Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Regular)
    End Sub
End Class