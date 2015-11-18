Module ModuloFunciones
    Public cont As Integer = 0
    Public strsql As String
    Public conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & _
     Application.StartupPath & "\alumnos.accdb")
    Public Sub conectar()
        Try
            conn.Open()
            'MsgBox("exito")
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

        Dim strsql As String = "SELECT * FROM estudiante WHERE id=" & cedula & ""
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
