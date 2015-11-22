Public Class AreaEstudio
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
    

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Label5.Visible = False
        DataGridView1.Visible = False
        Me.Close()
        principal.Show()
    End Sub

    Private Sub AreaEstudio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim contenido As String
        Dim valor As Integer = Label4.Text
        contenido = ComboBox1.SelectedItem

        nombre(valor)


        If contenido = "Algoritmo" Then
            ContenidoAlgotirmo.Show()
            ContenidoAlgotirmo.Text = "Bienvenido " + nom + " Al sistema de apoyo"
            Me.Close()
        ElseIf contenido = "Estructura de datos en Visual Basic" Then
            ContenidoVB.Show()
            ContenidoVB.Text = "Bienvenido " + nom + " Al sistema de apoyo"
            Me.Close()
        ElseIf contenido = "Bases de datos" Then
            contenidoBD.Show()
            contenidoBD.Text = "Bienvenido " + nom + " Al sistema de apoyo"
            Me.Close()
        ElseIf contenido = "Multimedia" Then
            ContenidoMultimedia.Show()
            ContenidoMultimedia.Text = "Bienvenido " + nom + " Al sistema de apoyo"
            Me.Close()

        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        calificacion()
        Label5.Visible = True
        DataGridView1.Visible = True
    End Sub

    Private Sub calificacion()
        Dim ds As New DataSet, dt As New DataTable
        strsql = "SELECT calif_bd AS BaseDatos, calif_algorit As Algoritmo, calif_multi AS Multimedia, calif_vb AS VisualBasic  "
        strsql += "FROM estudiante WHERE codigo=" & Label4.Text & ""
        Dim adp As New OleDb.OleDbDataAdapter(strsql, conn)
        Dim cmd As New OleDb.OleDbCommand(strsql, conn)
        cmd.Parameters.AddWithValue("@parametro", Label4.Text)
        ds.Tables.Add("tabla")
        adp.Fill(ds.Tables("tabla"))
        Me.DataGridView1.DataSource = ds.Tables("tabla")
      
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub ComboBox1_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedValueChanged
        Label5.Visible = False
        DataGridView1.Visible = False
    End Sub

 
End Class