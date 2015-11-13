Public Class eliminar

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        principal.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        conectar()
        If ComboBox1.SelectedItem = "Por ID" Then
            Dim id As Integer = TextBox1.Text
            Dim strsql As String = "DELETE FROM estudiantes WHERE idestudiante=" & TextBox1.Text & ""
            Dim cmd As New OleDb.OleDbCommand(strsql, conn)


            If TextBox1.Text <> "" Then

                If buscarid(id) = 1 Then

                    cmd.CommandType = CommandType.Text
                    cmd.Connection = conn
                    cmd.CommandText = strsql

                    Try
                        cmd.ExecuteNonQuery()
                        MsgBox("Registro eliminando correctamente", MsgBoxStyle.Information, "Resultado de Busqueda")
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                    TextBox1.Text = ""
                    ComboBox1.SelectedIndex = -1
                Else
                    MsgBox("El registro no existe", MessageBoxIcon.Information, "Resulatado de busqueda")

                End If
                TextBox1.Text = ""
            Else
                MsgBox("Debe ingresar el ID", MessageBoxIcon.Information)
                TextBox1.Text = ""
            End If

        ElseIf ComboBox1.SelectedItem = "Por Cedula" Then
            Dim cedula As Integer = TextBox1.Text
            Dim strsql As String = "SELECT * FROM estudiantes WHERE identificacion=" & TextBox1.Text & ""
            Dim cmd As New OleDb.OleDbCommand(strsql, conn)

            If buscarid(cedula) = 1 Then

                cmd.CommandType = CommandType.Text
                cmd.Connection = conn
                cmd.CommandText = strsql

                Try
                    cmd.ExecuteNonQuery()
                    MsgBox("Registro eliminando correctamente", MsgBoxStyle.Information, "Resultado de Busqueda")
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
                TextBox1.Text = ""
                ComboBox1.SelectedIndex = -1
            Else
                MsgBox("El registro no existe", MessageBoxIcon.Information, "Resultado de busqueda")
            End If
            TextBox1.Text = ""
        Else
            MsgBox("Debe ingresar el Cedula", MessageBoxIcon.Information)
            TextBox1.Text = ""
        End If

        cerrar()
    End Sub

    Private Sub eliminar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conn.Close()
    End Sub
    Private Sub Button1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseHover
        Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Bold)
    End Sub
    Private Sub Button1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseMove
        Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Regular)
    End Sub
    Private Sub Button2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseHover
        Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Bold)
    End Sub
    Private Sub Button2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button2.MouseMove
        Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Regular)
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

   
End Class