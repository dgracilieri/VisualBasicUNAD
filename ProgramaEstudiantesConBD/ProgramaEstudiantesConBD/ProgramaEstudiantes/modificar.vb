﻿Public Class modificar


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Asigno valores ingresados a variables
        Dim id, edad, tel, prog, ced As Integer
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
        If TextBox1.Text <> "" Then
            id = TextBox1.Text
        End If


        If ComboBox2.SelectedItem = "Derecho" Then
            prog = 6
        ElseIf ComboBox1.SelectedItem = "Ing. Sistemas" Then
            prog = 1
        ElseIf ComboBox2.SelectedItem = "Ing. Telecomunicaciones" Then
            prog = 2
        ElseIf ComboBox2.SelectedItem = "Psicologia" Then
            prog = 4
        ElseIf ComboBox2.SelectedItem = "Economia" Then
            prog = 5
        ElseIf ComboBox2.SelectedItem = "Agronomia" Then
            prog = 3
        ElseIf ComboBox2.SelectedItem = "Filosofia" Then
            prog = 7
        ElseIf ComboBox2.SelectedItem = "Sociologia" Then
            prog = 5
        Else
            prog = 0
        End If

        'Se habre conexion a BD 
        conectar()
        If ComboBox1.SelectedItem = "Por ID" Then

            If ced = 0 Or prog = 0 Then
                MsgBox("Error debe ingresar la Cedula y el programa a que pertenece", MessageBoxIcon.Error, "Error en la actualizacion")
            Else
                Dim strsql As String = "UPDATE estudiantes SET "
                strsql += "identificacion =" & ced & ", "
                strsql += "nombre ='" & nom & "', "
                strsql += "direccion ='" & dir & "', "
                strsql += "telefono =" & tel & ", "
                strsql += "edad =" & edad & ", "
                strsql += "idprograma =" & prog & " "
                strsql += "WHERE estudiantes.idestudiante = " & id & ""
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
                limpiar2()
            End If

        ElseIf ComboBox1.SelectedItem = "Por Cedula" Then

            If ced = 0 Or prog = 0 Then
                MsgBox("Error debe ingresar la Cedula y el programa a que pertenece 2", MessageBoxIcon.Error, "Error en la actualizacion")
            Else
                Dim strsql As String = "UPDATE estudiantes SET "
                strsql += "identificacion =" & ced & ", "
                strsql += "nombre ='" & nom & "', "
                strsql += "direccion ='" & dir & "', "
                strsql += "telefono =" & tel & ", "
                strsql += "edad =" & edad & ", "
                strsql += "idprograma =" & prog & " "
                strsql += "WHERE estudiantes.identificacion = " & ced & ""
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
                limpiar2()
            End If


        End If
            cerrar()
    End Sub

    Private Sub modificar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
End Class