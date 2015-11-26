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
        If ComboBox1.SelectedItem = "Falso" Then
            notas2 = 0.83
        Else
            notas2 = 0
        End If
        If ComboBox1.SelectedItem = "Verdadero" Then
            notas3 = 0.83
        Else
            notas3 = 0
        End If
        If ComboBox1.SelectedItem = "Falso" Then
            notas4 = 0.83
        Else
            notas4 = 0
        End If

        If ComboBox1.SelectedItem = "Falso" Then
            notas5 = 0.83
        Else
            notas5 = 0
        End If

        If ComboBox1.SelectedItem = "Falso" Then
            notas6 = 1
        Else
            notas6 = 0
        End If
        promedio = (Val(notas1) + Val(notas2) + Val(notas3) + Val(notas4) + Val(notas5) + Val(notas6))
    End Sub
    Private Sub BD()
        Dim notas1, notas2, notas3, notas4, notas5, notas6 As Integer


        If ComboBox1.SelectedItem = "Verdadero" Then
            notas1 = 0.83
        Else
            notas1 = 0.83
        End If
        If ComboBox1.SelectedItem = "Falso" Then
            notas2 = 0.83
        Else
            notas2 = 0
        End If
        If ComboBox1.SelectedItem = "Verdadero" Then
            notas3 = 0.83
        Else
            notas3 = 0
        End If
        If ComboBox1.SelectedItem = "Verdadero" Then
            notas4 = 0.83
        Else
            notas4 = 0
        End If

        If ComboBox1.SelectedItem = "Falso" Then
            notas5 = 0.83
        Else
            notas5 = 0
        End If

        If ComboBox1.SelectedItem = "Verdadero" Then
            notas6 = 1
        Else
            notas6 = 0
        End If
        promedio = (Val(notas1) + Val(notas2) + Val(notas3) + Val(notas4) + Val(notas5) + Val(notas6))
    End Sub
    Private Sub VB()
        Dim notas1, notas2, notas3, notas4, notas5, notas6 As Integer

        If ComboBox1.SelectedItem = "Falso" Then
            notas1 = 0.83
        Else
            notas1 = 0.83
        End If
        If ComboBox1.SelectedItem = "Falso" Then
            notas2 = 0.83
        Else
            notas2 = 0
        End If
        If ComboBox1.SelectedItem = "Verdadero" Then
            notas3 = 0.83
        Else
            notas3 = 0
        End If
        If ComboBox1.SelectedItem = "Falso" Then
            notas4 = 0.83
        Else
            notas4 = 0
        End If

        If ComboBox1.SelectedItem = "Falso" Then
            notas5 = 0.83
        Else
            notas5 = 0
        End If

        If ComboBox1.SelectedItem = "Falso" Then
            notas6 = 1
        Else
            notas6 = 0
        End If
        promedio = (Val(notas1) + Val(notas2) + Val(notas3) + Val(notas4) + Val(notas5) + Val(notas6))
    End Sub
    Private Sub Multimedia()
        Dim notas1, notas2, notas3, notas4, notas5, notas6 As Integer


        If ComboBox1.SelectedItem = "Falso" Then
            notas1 = 0.83
        Else
            notas1 = 0.83
        End If
        If ComboBox1.SelectedItem = "Falso" Then
            notas2 = 0.83
        Else
            notas2 = 0
        End If
        If ComboBox1.SelectedItem = "Verdadero" Then
            notas3 = 0.83
        Else
            notas3 = 0
        End If
        If ComboBox1.SelectedItem = "Falso" Then
            notas4 = 0.83
        Else
            notas4 = 0
        End If

        If ComboBox1.SelectedItem = "Falso" Then
            notas5 = 0.83
        Else
            notas5 = 0
        End If

        If ComboBox1.SelectedItem = "Falso" Then
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
                MsgBox("Nota actualizada Correctamente", MsgBoxStyle.Information, "Actualizacion de Notas")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        ElseIf materia = "BD" Then
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
                MsgBox("Nota actualizada Correctamente", MsgBoxStyle.Information, "Actualizacion de Notas")
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
                MsgBox("Nota actualizada Correctamente", MsgBoxStyle.Information, "Actualizacion de Notas")
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
                MsgBox("Nota actualizada Correctamente", MsgBoxStyle.Information, "Actualizacion de Notas")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If

        

    End Sub
End Class