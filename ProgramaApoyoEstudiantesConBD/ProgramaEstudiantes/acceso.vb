Public Class acceso

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        principal.Show()
        Me.Close()
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


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        
        
        conn.Close()
        conn.Open()
        Dim valor As Integer = TextBox1.Text
        Dim strsql As String = "SELECT est.idarea AS AREA FROM estudiantes AS est, area WHERE est.idarea=area.idarea AND est.identificacion" & valor & ""
        Dim cmd As New OleDb.OleDbCommand(strsql, conn)
        Dim strsqlprg As String = "SELECT est.idarea AS AREA, est.nombre FROM estudiantes AS est "
        strsqlprg += "WHERE est.identificacion=" & valor & ""
        Dim cmd1 As New OleDb.OleDbCommand(strsqlprg, conn)
        Dim ds As New DataSet, dr As OleDb.OleDbDataReader

        If ComboBox1.SelectedItem = "Usuarios Registrados" Then

            If buscarced(valor) = 1 Then
                Dim prog = 2
                
                cmd1.CommandType = CommandType.Text
                Try
                    dr = cmd1.ExecuteReader
                    dr.Read()
                    If dr.HasRows Then


                        Dim prg As String = dr(0)
                        Dim nom As String = dr(1)
                       
                        If prg = 1 Then
                            ContenidoAlgoritmo.Show()
                            ContenidoAlgoritmo.Text = "Bienvenido " + nom + " Al sistema de apoyo"
                        ElseIf prg = 2 Then
                            ContenidoEstructura.Show()
                            ContenidoEstructura.Text = "Bienvenido " + nom + " Al sistema de apoyo"
                        ElseIf prg = 3 Then
                            ContenidoBD.Show()
                            ContenidoBD.Text = "Bienvenido " + nom + " Al sistema de apoyo"
                        ElseIf prg = 4 Then
                            ContenidoMultimedia.Show()
                            ContenidoMultimedia.Text = "Bienvenido " + nom + " Al sistema de apoyo"

                        End If


                    End If
                Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            Else
                mensaje.Show()
                conn.Close()
            End If


        Else
            mensaje.Show()
            conn.Close()
        End If
        conn.Close()
        Me.Hide()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "Usuarios Nuevos" Then
            TextBox1.Visible = False
            TextBox1.Text = 0
            Label2.Visible = False
        ElseIf ComboBox1.SelectedItem = "Usuarios Registrados" Then
            TextBox1.Visible = True
            TextBox1.Text = ""
            Label2.Visible = True

        End If

    End Sub

    Private Sub acceso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class