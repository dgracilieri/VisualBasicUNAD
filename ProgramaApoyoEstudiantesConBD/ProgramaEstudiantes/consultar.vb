Public Class consultar


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim tam, tamf As Integer
        If ComboBox1.SelectedItem = "" Then
            MsgBox("Error debe ingresar un criterio de busqueda", MessageBoxIcon.Error, "Busqueda")
        ElseIf ComboBox1.SelectedItem = "ID" Then
            conectar()
            llenarTablaid()
            DataGridView1.Visible = True
            Me.Size = New Size(729, 420)
            cerrar()
        ElseIf ComboBox1.SelectedItem = "Cedula" Then
            conectar()
            llenartablaced()
            DataGridView1.Visible = True
            Me.Size = New Size(729, 420)
            cerrar()

        ElseIf ComboBox1.SelectedItem = "Todos" Then
            TextBox1.Visible = False
            conectar()
            llenartabla()
            tam = (DataGridView1.Rows.Count - 1) * 35
            DataGridView1.Size = New Size(640, Val(tam))
            tamf = Val(tam) + 400
            Me.Size = New Size(729, Val(tamf))
            cerrar()
            DataGridView1.Visible = True
            
        End If


    End Sub

    Private Sub consultar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cerrar()
        ComboBox1.SelectedIndex = -1
    End Sub

    Private Sub llenarTablaid()
        Dim ds As New DataSet, dt As New DataTable
        Dim strsql As String = "SELECT est.identificacion AS Cedula, est.nombre AS Nombre, est.direccion AS Direccion, est.telefono AS Telefono, est.edad AS Edad, area.nombre "
        strsql += " AS AREA FROM estudiantes AS est, area WHERE est.idarea=area.idarea AND est.idestudiante=" & TextBox1.Text & ""
        Dim adp As New OleDb.OleDbDataAdapter(strsql, conn)
        Dim cmd As New OleDb.OleDbCommand(strsql, conn)
        cmd.Parameters.AddWithValue("@parametro", TextBox1.Text)
        ds.Tables.Add("tabla")
        adp.Fill(ds.Tables("tabla"))
        Me.DataGridView1.DataSource = ds.Tables("tabla")

    End Sub

    Private Sub llenartablaced()
        Dim ds As New DataSet, dt As New DataTable
        Dim strsql As String = "SELECT est.identificacion, est.nombre, est.direccion, est.telefono, est.edad, area.nombre AS AREA FROM estudiantes AS est, area "
        strsql += "WHERE est.idarea=area.idarea AND est.identificacion = " & TextBox1.Text & ""
        Dim adp As New OleDb.OleDbDataAdapter(strsql, conn)
        Dim cmd As New OleDb.OleDbCommand(strsql, conn)
        cmd.Parameters.AddWithValue("@parametro", TextBox1.Text)
        ds.Tables.Add("tabla")
        adp.Fill(ds.Tables("tabla"))
        Me.DataGridView1.DataSource = ds.Tables("tabla")
    End Sub

    Private Sub llenartabla()
        Dim ds As New DataSet, dt As New DataTable
        Dim strsql As String = "SELECT DISTINCT est.identificacion, est.nombre, est.direccion, est.telefono, est.edad, area.nombre AS AREA FROM estudiantes AS est, area "
        strsql += " WHERE est.idarea=area.idarea"
        Dim adp As New OleDb.OleDbDataAdapter(strsql, conn)
        Dim cmd As New OleDb.OleDbCommand(strsql, conn)
        cmd.Parameters.AddWithValue("@parametro", TextBox1.Text)
        ds.Tables.Add("tabla")
        adp.Fill(ds.Tables("tabla"))
        Me.DataGridView1.DataSource = ds.Tables("tabla")
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        DataGridView1.Visible = False
        ComboBox1.SelectedIndex = -1
        TextBox1.Visible = True

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
    End Sub

   
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "Todos" Then
            TextBox1.Visible = False
        ElseIf ComboBox1.SelectedItem = "ID" Then
            limpiar()
        ElseIf ComboBox1.SelectedItem = "Cedula" Then
            limpiar()
        End If
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
    Private Sub Button3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.MouseHover
        Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Bold)
    End Sub
    Private Sub Button3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button3.MouseMove
        Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Regular)
    End Sub
End Class