Public Class Modificar

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
        Dim ced, tel, edad As Integer
        Dim nom, dir As String




        If TextBox5.Text <> "" Then
            edad = TextBox5.Text
        End If

        If TextBox4.Text <> "" Then
            tel = TextBox4.Text
        End If

        If TextBox2.Text <> "" Then
            nom = TextBox2.Text
        End If

        If TextBox3.Text <> "" Then
            dir = TextBox3.Text
        End If

        If TextBox6.Text <> "" Then
            ced = TextBox6.Text
        Else
            ced = 0
        End If
       
        conectar()
        If ComboBox1.SelectedItem = "Por ID" Then


            If ced = 0 Then
                MsgBox("Error debe ingresar la Cedula", MessageBoxIcon.Error, "Error en la actualizacion")
            Else
                strsql = "UPDATE estudiante SET "
                strsql += "codigo =" & ced & ", "
                strsql += "nombre ='" & nom & "', "
                strsql += "direccion ='" & dir & "', "
                strsql += "telefono =" & tel & ", "
                strsql += "edad =" & edad & ", "
                strsql += "WHERE estudiante.id = " & ced & ""
                Dim cmd As New OleDb.OleDbCommand
                cmd.CommandType = CommandType.Text
                cmd.Connection = conn
                cmd.CommandText = strsql

                Try
                    cmd.ExecuteNonQuery()
                    MsgBox("Registro Modificado Correctamente", MsgBoxStyle.Information)
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
                limpiar3()
            End If
        ElseIf ComboBox1.SelectedItem = "Por Cedula" Then

            If ced = 0 Then
                MsgBox("Error debe ingresar la Cedula ", MessageBoxIcon.Error, "Error en la actualizacion")
            Else
                strsql = "UPDATE estudiante SET "
                strsql += "codigo =" & ced & ", "
                strsql += "nombre ='" & nom & "', "
                strsql += "direccion ='" & dir & "', "
                strsql += "telefono =" & tel & ", "
                strsql += "edad =" & edad & ", "
                strsql += "WHERE estudiante.codigo = " & ced & ""
                Dim cmd As New OleDb.OleDbCommand
                cmd.CommandType = CommandType.Text
                cmd.Connection = conn
                cmd.CommandText = strsql

                Try
                    cmd.ExecuteNonQuery()
                    MsgBox("Registro Modificado Correctamente", MsgBoxStyle.Information)
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
                limpiar3()
            End If


        End If
        cerrar()

    End Sub
End Class