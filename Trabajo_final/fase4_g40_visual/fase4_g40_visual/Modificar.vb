Public Class Modificar
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
        AreaAdmin.Show()
        Me.Close()
    End Sub

    Private Sub TextBox6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox6.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ced, tel, edad, aux3, aux4, aux5 As Integer
        Dim nom, dir, aux1, aux2 As String
        valor = TextBox6.Text
        strsql = "SELECT nombre, direccion, telefono, edad FROM estudiante "
        strsql += "WHERE codigo=" & valor & ""
        Dim strsqlid As String = "SELECT codigo,nombre, direccion, telefono, edad FROM estudiante "
        strsqlid += "WHERE id=" & valor & ""
        Dim cmd As New OleDb.OleDbCommand(strsql, conn)
        Dim cmd1 As New OleDb.OleDbCommand(strsqlid, conn)
        Dim ds As New DataSet, dr As OleDb.OleDbDataReader




        If ComboBox1.SelectedItem = "Cedula" Then

            cmd.CommandType = CommandType.Text
            Try
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    aux1 = dr(0)
                    aux2 = dr(1)
                    aux3 = dr(2)
                    aux4 = dr(3)

                End If

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try


            If TextBox2.Text <> "" Then
                nom = TextBox2.Text
            Else
                nom = aux1
            End If
            If TextBox3.Text <> "" Then
                dir = TextBox3.Text
            Else
                dir = aux2
            End If
            If TextBox4.Text <> "" Then
                tel = TextBox4.Text
            Else
                tel = aux3
            End If
            If TextBox5.Text <> "" Then
                edad = TextBox5.Text
            Else
                edad = aux4
            End If


            strsql = "UPDATE estudiante SET "
            strsql += "codigo =" & valor & ", "
            strsql += "nombre ='" & nom & "', "
            strsql += "direccion ='" & dir & "', "
            strsql += "telefono =" & tel & ", "
            strsql += "edad =" & edad & " "
            strsql += "WHERE codigo = " & valor & ""
            Dim cmd2 As New OleDb.OleDbCommand
            cmd2.CommandType = CommandType.Text
            cmd2.Connection = conn
            cmd2.CommandText = strsql

            Try
                cmd2.ExecuteNonQuery()
                MsgBox("Registro Modificado Correctamente", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            limpiar3()


        ElseIf ComboBox1.SelectedItem = "ID" Then


            cmd1.CommandType = CommandType.Text
            Try
                dr = cmd1.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    aux1 = dr(1)
                    aux2 = dr(2)
                    aux3 = dr(3)
                    aux4 = dr(4)
                    aux5 = dr(0)

                End If

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try


            If TextBox2.Text <> "" Then
                nom = TextBox2.Text
            Else
                nom = aux1
            End If
            If TextBox3.Text <> "" Then
                dir = TextBox3.Text
            Else
                dir = aux2
            End If
            If TextBox4.Text <> "" Then
                tel = TextBox4.Text
            Else
                tel = aux3
            End If
            If TextBox5.Text <> "" Then
                edad = TextBox5.Text
            Else
                edad = aux4
            End If
            If TextBox1.Text <> "" Then
                ced = TextBox1.Text
            Else
                ced = aux5
            End If

            strsql = "UPDATE estudiante SET "
            strsql += "codigo =" & ced & ", "
            strsql += "nombre ='" & nom & "', "
            strsql += "direccion ='" & dir & "', "
            strsql += "telefono =" & tel & ", "
            strsql += "edad =" & edad & " "
            strsql += "WHERE id = " & valor & ""
            Dim cmd2 As New OleDb.OleDbCommand
            cmd2.CommandType = CommandType.Text
            cmd2.Connection = conn
            cmd2.CommandText = strsql

            Try
                cmd2.ExecuteNonQuery()
                MsgBox("Registro Modificado Correctamente", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            limpiar3()
        End If

    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "Cedula" Then

            TextBox1.Enabled = False
        Else
            TextBox1.Enabled = True
        End If
    End Sub


End Class