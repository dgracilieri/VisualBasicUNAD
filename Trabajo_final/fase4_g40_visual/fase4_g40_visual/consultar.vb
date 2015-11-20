Public Class consultar
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
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim tam, tamf As Integer
        If ComboBox1.SelectedItem = "" Then
            MsgBox("Error debe ingresar un criterio de busqueda", MessageBoxIcon.Error, "Busqueda de Registros")
        ElseIf ComboBox1.SelectedItem = "ID" Then

            llenarTablaid()
            DataGridView1.Visible = True
            DataGridView1.Size = New Size(519, 46)

        ElseIf ComboBox1.SelectedItem = "Cedula" Then

            llenartablaced()
            DataGridView1.Visible = True
            DataGridView1.Size = New Size(519, 46)


        ElseIf ComboBox1.SelectedItem = "Todos" Then

            llenartabla()
            tam = (DataGridView1.Rows.Count - 1) * 35

            If tam = 0 Then
                MsgBox("No hay registros para mostrar", MessageBoxIcon.Information, "Busqueda de Registros")
            Else

                DataGridView1.Size = New Size(519, Val(tam))
                tamf = Val(tam) + 200
                Me.Size = New Size(877, Val(tamf))
                DataGridView1.Visible = True
            End If
            

        End If
    End Sub

    Private Sub llenarTablaid()
        Dim ds As New DataSet, dt As New DataTable
        strsql = "SELECT codigo AS Cedula, nombre AS Nombre, direccion AS Direccion,telefono AS Telefono,edad AS Edad "
        strsql += "FROM estudiante  WHERE id=" & TextBox1.Text & ""
        Dim adp As New OleDb.OleDbDataAdapter(strsql, conn)
        Dim cmd As New OleDb.OleDbCommand(strsql, conn)
        cmd.Parameters.AddWithValue("@parametro", TextBox1.Text)
        ds.Tables.Add("tabla")
        adp.Fill(ds.Tables("tabla"))
        Me.DataGridView1.DataSource = ds.Tables("tabla")

    End Sub

    Private Sub llenartablaced()
        Dim ds As New DataSet, dt As New DataTable
        Dim strsql As String = "SELECT codigo AS Cedula,nombre AS Nombre,direccion AS Direccion,telefono AS Telefono"
        strsql += ", edad AS Edad FROM estudiante WHERE  codigo = " & TextBox1.Text & ""
        Dim adp As New OleDb.OleDbDataAdapter(strsql, conn)
        Dim cmd As New OleDb.OleDbCommand(strsql, conn)
        cmd.Parameters.AddWithValue("@parametro", TextBox1.Text)
        ds.Tables.Add("tabla")
        adp.Fill(ds.Tables("tabla"))
        Me.DataGridView1.DataSource = ds.Tables("tabla")
    End Sub

    Private Sub llenartabla()
        Dim ds As New DataSet, dt As New DataTable
        Dim strsql As String = "SELECT codigo AS Cedula,nombre AS Nombre,direccion AS Direccion,telefono AS Telefono,edad AS Edad FROM estudiante"
        Dim adp As New OleDb.OleDbDataAdapter(strsql, conn)
        Dim cmd As New OleDb.OleDbCommand(strsql, conn)
        cmd.Parameters.AddWithValue("@parametro", TextBox1.Text)
        ds.Tables.Add("tabla")
        adp.Fill(ds.Tables("tabla"))
        Me.DataGridView1.DataSource = ds.Tables("tabla")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        AreaAdmin.Show()
        Me.Close()
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "Todos" Then
            TextBox1.Visible = False
        ElseIf ComboBox1.SelectedItem = "ID" Then
            limpiar2()
        ElseIf ComboBox1.SelectedItem = "Cedula" Then
            limpiar2()

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        limpiar2()
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