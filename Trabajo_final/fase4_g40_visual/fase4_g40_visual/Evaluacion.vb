Public Class Evaluacion
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
    Private Sub Algoritmos()
        Dim notas1, notas2, notas3, notas4, notas5, notas6 As Integer


        If ComboBox1.SelectedItem = "Falso" Then
            notas1 = 0.83
        Else
            notas1 = 0.83
        End If
        If ComboBox2.SelectedItem = "Falso" Then
            notas2 = 0.83
        Else
            notas2 = 0
        End If
        If ComboBox3.SelectedItem = "Verdadero" Then
            notas3 = 0.83
        Else
            notas3 = 0
        End If
        If ComboBox4.SelectedItem = "Falso" Then
            notas4 = 0.83
        Else
            notas4 = 0
        End If

        If ComboBox5.SelectedItem = "Falso" Then
            notas5 = 0.83
        Else
            notas5 = 0
        End If

        If ComboBox6.SelectedItem = "Falso" Then
            notas6 = 1
        Else
            notas6 = 0
        End If
        promedio = (Val(notas1) + Val(notas2) + Val(notas3) + Val(notas4) + Val(notas5) + Val(notas6))
    End Sub
    Private Sub BD()
        Dim notas1, notas2, notas3, notas4, notas5, notas6 As Integer


        If ComboBox12.SelectedItem = "Verdadero" Then
            notas1 = 0.83
        Else
            notas1 = 0.83
        End If
        If ComboBox11.SelectedItem = "Falso" Then
            notas2 = 0.83
        Else
            notas2 = 0
        End If
        If ComboBox10.SelectedItem = "Verdadero" Then
            notas3 = 0.83
        Else
            notas3 = 0
        End If
        If ComboBox9.SelectedItem = "Verdadero" Then
            notas4 = 0.83
        Else
            notas4 = 0
        End If

        If ComboBox8.SelectedItem = "Falso" Then
            notas5 = 0.83
        Else
            notas5 = 0
        End If

        If ComboBox7.SelectedItem = "Verdadero" Then
            notas6 = 1
        Else
            notas6 = 0
        End If
        promedio = (Val(notas1) + Val(notas2) + Val(notas3) + Val(notas4) + Val(notas5) + Val(notas6))
    End Sub
    Private Sub VB()
        Dim notas1, notas2, notas3, notas4, notas5, notas6 As Integer

        If ComboBox24.SelectedItem = "Verdadero" Then
            notas1 = 0.83
        Else
            notas1 = 0.83
        End If
        If ComboBox23.SelectedItem = "Falso" Then
            notas2 = 0.83
        Else
            notas2 = 0
        End If
        If ComboBox22.SelectedItem = "Verdadero" Then
            notas3 = 0.83
        Else
            notas3 = 0
        End If
        If ComboBox21.SelectedItem = "Falso" Then
            notas4 = 0.83
        Else
            notas4 = 0
        End If

        If ComboBox20.SelectedItem = "Falso" Then
            notas5 = 0.83
        Else
            notas5 = 0
        End If

        If ComboBox19.SelectedItem = "Verdadero" Then
            notas6 = 1
        Else
            notas6 = 0
        End If
        promedio = (Val(notas1) + Val(notas2) + Val(notas3) + Val(notas4) + Val(notas5) + Val(notas6))
    End Sub
    Private Sub Multimedia()
        Dim notas1, notas2, notas3, notas4, notas5, notas6 As Integer


        If ComboBox18.SelectedItem = "Verdadero" Then
            notas1 = 0.83
        Else
            notas1 = 0.83
        End If
        If ComboBox17.SelectedItem = "Falso" Then
            notas2 = 0.83
        Else
            notas2 = 0
        End If
        If ComboBox16.SelectedItem = "Verdadero" Then
            notas3 = 0.83
        Else
            notas3 = 0
        End If
        If ComboBox15.SelectedItem = "Falso" Then
            notas4 = 0.83
        Else
            notas4 = 0
        End If

        If ComboBox14.SelectedItem = "Falso" Then
            notas5 = 0.83
        Else
            notas5 = 0
        End If

        If ComboBox13.SelectedItem = "Verdadero" Then
            notas6 = 1
        Else
            notas6 = 0
        End If
        promedio = (Val(notas1) + Val(notas2) + Val(notas3) + Val(notas4) + Val(notas5) + Val(notas6))
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        AreaEstudio.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If materia = "Algoritmo" Then
            Algoritmos()
            strsql = "UPDATE estudiante SET "
            strsql += "calif_algorit =" & promedio & " "
            strsql += "WHERE codigo = " & codigo & ""
            Dim cmd As New OleDb.OleDbCommand
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            cmd.CommandText = strsql
            Try
                cmd.ExecuteNonQuery()
                ComboBox1.SelectedIndex = -1
                ComboBox2.SelectedIndex = -1
                ComboBox3.SelectedIndex = -1
                ComboBox4.SelectedIndex = -1
                ComboBox5.SelectedIndex = -1
                ComboBox6.SelectedIndex = -1

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        ElseIf materia = "Bases de datos" Then
            BD()
            strsql = "UPDATE estudiante SET "
            strsql += "calif_bd =" & promedio & " "
            strsql += "WHERE codigo = " & codigo & ""
            Dim cmd As New OleDb.OleDbCommand
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            cmd.CommandText = strsql
            Try
                cmd.ExecuteNonQuery()
                ComboBox12.SelectedIndex = -1
                ComboBox11.SelectedIndex = -1
                ComboBox10.SelectedIndex = -1
                ComboBox9.SelectedIndex = -1
                ComboBox8.SelectedIndex = -1
                ComboBox7.SelectedIndex = -1
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        ElseIf materia = "Visual Basic" Then
            VB()
            strsql = "UPDATE estudiante SET "
            strsql += "calif_vb =" & promedio & " "
            strsql += "WHERE codigo = " & codigo & ""
            Dim cmd As New OleDb.OleDbCommand
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            cmd.CommandText = strsql
            Try
                cmd.ExecuteNonQuery()
                ComboBox24.SelectedIndex = -1
                ComboBox23.SelectedIndex = -1
                ComboBox22.SelectedIndex = -1
                ComboBox21.SelectedIndex = -1
                ComboBox20.SelectedIndex = -1
                ComboBox19.SelectedIndex = -1
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        ElseIf materia = "Multimedia" Then
            Multimedia()
            strsql = "UPDATE estudiante SET "
            strsql += "calif_multi =" & promedio & " "
            strsql += "WHERE codigo = " & codigo & ""
            Dim cmd As New OleDb.OleDbCommand
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            cmd.CommandText = strsql
            Try
                cmd.ExecuteNonQuery()
                ComboBox18.SelectedIndex = -1
                ComboBox17.SelectedIndex = -1
                ComboBox16.SelectedIndex = -1
                ComboBox15.SelectedIndex = -1
                ComboBox14.SelectedIndex = -1
                ComboBox13.SelectedIndex = -1
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If

        

    End Sub
End Class