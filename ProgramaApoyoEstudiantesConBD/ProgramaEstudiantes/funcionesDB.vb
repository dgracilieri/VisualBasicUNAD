Module funcionesDB
    'Cadena de conexion a la base de datos

    Public conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & _
     Application.StartupPath & "\multimedia.accdb")
    Public valor As String

    'Funcion para establecer la conexion a la base de datos e informar si existe algun error en la conexion
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
    'funcion para limpiar el form consultar
    Public Sub limpiar()
        consultar.TextBox1.Visible = True
        consultar.TextBox1.Text = ""
        consultar.DataGridView1.Visible = False
        consultar.Size = New Size(729, 321)
    End Sub
    'funcion para limpiar el form consultar
    Public Sub limpiar2()
        modificar.TextBox1.Text = ""
        modificar.TextBox2.Text = ""
        modificar.TextBox3.Text = ""
        modificar.TextBox4.Text = ""
        modificar.TextBox5.Text = ""
        modificar.TextBox6.Text = ""
        modificar.ComboBox1.SelectedIndex = -1
        modificar.ComboBox2.SelectedIndex = -1
    End Sub

    'Funcion para realizar una consulta a la base de datos por cedula y recibe un valor como parametro
    'que corresponde a la cedula
    Function buscarced(ByVal cedula As Integer) As Double

        Dim strsql As String = "SELECT * FROM estudiantes WHERE identificacion=" & cedula & ""
        Dim cmd As New OleDb.OleDbCommand(strsql, conn)
        Dim ds As New DataSet, dr As OleDb.OleDbDataReader
        cmd.CommandType = CommandType.Text

        Try
            dr = cmd.ExecuteReader
            If dr.HasRows Then

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

        Dim strsql As String = "SELECT * FROM estudiantes WHERE idestudiante=" & cedula & ""
        Dim cmd As New OleDb.OleDbCommand(strsql, conn)
        Dim ds As New DataSet, dr As OleDb.OleDbDataReader
        cmd.CommandType = CommandType.Text

        Try
            dr = cmd.ExecuteReader
            If dr.HasRows Then

                Return 1
            Else
                Return 0

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        dr.Close()
    End Function

   

End Module
