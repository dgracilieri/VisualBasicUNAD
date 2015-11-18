Public Class Insertar

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        AreaAdmin.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim codigo, tel, edad, id As Integer
        Dim nom, dir As String

        codigo = TextBox1.Text
        tel = TextBox4.Text
        edad = TextBox5.Text
        nom = TextBox2.Text
        dir = TextBox4.Text
        id = 1

        'Busca una posicion disponible pára realizar la carga de datos
        conectar()
        While buscarid(id) <> 0
            id = id + 1
        End While
        cerrar()
        'Llamo a la funcion para realizar la conexion a la base de datos

        'MsgBox(id.ToString)
        conectar()
        'Valido si existe un registro con esa cedula ingresado previamente

        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
            MsgBox("Error debe diligenciar todos los campos obligatorios para continuar", MessageBoxIcon.Information, "Carga de registros")
            limpiar()
        Else

            If buscarced(TextBox1.Text) = 0 Then

                strsql = "insert into estudiante (id, codigo, nombre, direccion, telefono, edad) "
                strsql += " VALUES (" & id & "," & codigo & ",'" & nom & "','" & dir & "'," & tel & "," & edad & ")"

                Dim cmd As New OleDb.OleDbCommand
                cmd.CommandType = CommandType.Text
                cmd.Connection = conn
                cmd.CommandText = strsql

                'Informo de errores en la carga del registro
                Try
                    cmd.ExecuteNonQuery()
                    MsgBox("Registro Cargado Existosamente", MsgBoxStyle.Information, "Carga de registros")
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
                limpiar()


            Else

                MsgBox("La cedula ya existe en el sistema y no es posible registrar cedulas duplicadas", MessageBoxIcon.Information, "Carga de registros")
                limpiar()

            End If

        End If
        cerrar()
        'Cierro la conexionn a la base de datos

    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class