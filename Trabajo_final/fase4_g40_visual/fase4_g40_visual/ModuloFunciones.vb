Imports System.Data.OleDb
Module ModuloFunciones

    Public cont As Integer = 0
    Public strsql, valor, area As String
    Public conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & _
    Application.StartupPath & "\alumnos.accdb")
    
    Public Sub conectar()
        Try
            conn.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub
    'Funcion para cerrar la conexion a la base de datos
    Public Sub cerrar()
        conn.Close()
    End Sub

    'Funcion para realizar una consulta a la base de datos por cedula y recibe un valor como parametro
    'que corresponde a la cedula
    Function buscarced(ByVal cedula As Integer) As Double

        Dim strsql As String = "SELECT * FROM estudiante WHERE codigo=" & cedula & ""
        Dim cmd As New OleDb.OleDbCommand(strsql, conn)
        Dim ds As New DataSet, dr As OleDb.OleDbDataReader
        cmd.CommandType = CommandType.Text

        Try
            dr = cmd.ExecuteReader
            If dr.HasRows = True Then

                Return 1
            Else
                Return 0

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        dr.Close()
    End Function

    'Funcion para realizar una consulta a la base de datos por cedula y recibe un valor como parametro
    'que corresponde a la id
    Function buscarid(ByVal cedula As Integer) As Double

        Dim strsql As String = "SELECT * FROM estudiante WHERE id=" & cedula & ""
        Dim cmd As New OleDb.OleDbCommand(strsql, conn)
        Dim ds As New DataSet, dr As OleDb.OleDbDataReader
        cmd.CommandType = CommandType.Text

        Try
            dr = cmd.ExecuteReader
            If dr.HasRows = True Then

                Return 1
            Else
                Return 0

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        dr.Close()
    End Function

    Public Sub limpiar()
        Insertar.TextBox1.Text = ""
        Insertar.TextBox2.Text = ""
        Insertar.TextBox3.Text = ""
        Insertar.TextBox4.Text = ""
        Insertar.TextBox5.Text = ""
        Insertar.TextBox6.Text = ""
    End Sub

    Public Sub limpiar2()
        consultar.TextBox1.Text = ""
        consultar.TextBox1.Visible = True
        consultar.DataGridView1.Visible = False
        consultar.Size = New Size(877, 293)
    End Sub
    Public Sub limpiar3()
        Modificar.TextBox1.Text = ""
        Modificar.TextBox2.Text = ""
        Modificar.TextBox3.Text = ""
        Modificar.TextBox4.Text = ""
        Modificar.TextBox5.Text = ""
        Modificar.TextBox6.Text = ""
        Modificar.ComboBox1.SelectedIndex = -1
    End Sub



End Module
