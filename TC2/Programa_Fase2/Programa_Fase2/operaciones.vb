Public Class ProductoEscalar
    'Deshabilita el boton de cerrar el formulario
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

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
    End Sub

    Private Sub Button1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseHover
        Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Bold)
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Regular)
    End Sub
    Private Sub Button3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.MouseHover
        Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Bold)
    End Sub

    Private Sub Button3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.MouseLeave
        Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Regular)
    End Sub
    Private Sub Button4_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.MouseHover
        Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Bold)
    End Sub

    Private Sub Button4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.MouseLeave
        Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Regular)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ma, mb, i, j As SByte

        ma = ComboBox1.SelectedItem
        mb = ComboBox2.SelectedItem
        'Dibuja la matriz de manera dinamica adaptando el tamaño a la cantidad de filas y columnas
        If ComboBox1.SelectedItem = "" Or ComboBox2.SelectedItem = "" Then
            MsgBox("Error debe seleccionar el tamaño de la matriz para continuar", MessageBoxIcon.Information, "Creacion de matriz")
        Else
            DataGridView1.RowCount = ma
            DataGridView1.ColumnCount = mb
            DataGridView1.Visible = True
            If ComboBox1.SelectedItem = 1 Then
                DataGridView1.Size = New Size(673, 44)
            ElseIf ComboBox1.SelectedItem = 2 Then
                DataGridView1.Size = New Size(673, 66)
            ElseIf ComboBox1.SelectedItem = 3 Then
                DataGridView1.Size = New Size(673, 88)
            ElseIf ComboBox1.SelectedItem = 4 Then
                DataGridView1.Size = New Size(673, 110)
            ElseIf ComboBox1.SelectedItem = 5 Then
                DataGridView1.Size = New Size(673, 132)
            ElseIf ComboBox1.SelectedItem = 6 Then
                DataGridView1.Size = New Size(673, 154)
            ElseIf ComboBox1.SelectedItem = 7 Then
                DataGridView1.Size = New Size(673, 176)
            ElseIf ComboBox1.SelectedItem = 8 Then
                DataGridView1.Size = New Size(673, 198)
            Else
                DataGridView1.Size = New Size(673, 220)
            End If

        End If
        'Nombres para Fila y columna
        For i = 0 To mb - 1
            DataGridView1.Columns(i).HeaderText = "X " + (i + 1).ToString
        Next
        For i = 0 To ma - 1
            DataGridView1.Rows(i).HeaderCell.Value = "Y " + (i + 1).ToString
        Next
        For i = 0 To ma - 1
            For j = 0 To mb - 1
                DataGridView1.Rows(i).Cells(j).Value = InputBox("Ingrese un valor")
            Next j
        Next i
        Button1.Enabled = False
        Button2.Enabled = True

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim num, ma, mb, i, j As Byte
        num = InputBox("Ingrese un numero")
        ma = DataGridView1.RowCount
        mb = DataGridView1.ColumnCount

        For i = 0 To ma - 1
            For j = 0 To mb - 1
                DataGridView1.Rows(i).Cells(j).Value = num * Val(DataGridView1.Rows(i).Cells(j).Value)
            Next j
        Next i
        Label4.Visible = True
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = True

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Label4.Visible = False
        Dim ma, mb, i, j As Byte

        ma = DataGridView1.RowCount
        mb = DataGridView1.ColumnCount

        For i = 0 To ma - 1
            For j = 0 To mb - 1
                DataGridView1.Rows(i).Cells(j).Value = ""
            Next j
        Next i
        Button3.Visible = False
        DataGridView1.Visible = False
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
        Button1.Enabled = True

    End Sub
End Class