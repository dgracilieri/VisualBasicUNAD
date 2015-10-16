Public Class matrices
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
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Panel2.Visible = True

        Button3.Enabled = False
        Button4.Enabled = False

        Dim i, j As Byte

        For i = 0 To DataGridView1.RowCount - 1

            For j = 0 To DataGridView1.ColumnCount - 1

                DataGridView3.Rows(i).Cells(j).Value = Val(DataGridView1.Rows(i).Cells(j).Value) * Val(DataGridView2.Rows(i).Cells(j).Value)

            Next j

        Next i
        Button5.Enabled = True
    End Sub


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim fila As Byte, columna As Byte, i As Integer
        Dim x As Integer
        Panel2.Visible = False
        For i = 0 To DataGridView1.RowCount - 1
            For x = 0 To DataGridView1.ColumnCount - 1
                DataGridView1.Rows(i).Cells(x).Value = ""
                DataGridView2.Rows(i).Cells(x).Value = ""
                DataGridView3.Rows(i).Cells(x).Value = ""
            Next x
        Next i

        fila = InputBox("Cantidad de ventas", "Ventas")
        columna = 3
        DataGridView1.RowCount = fila
        DataGridView1.ColumnCount = columna
        DataGridView2.RowCount = fila
        DataGridView2.ColumnCount = columna
        DataGridView3.RowCount = fila
        DataGridView3.ColumnCount = columna

        For i = 0 To columna - 1

            DataGridView1.Columns(i).Width = 100
            DataGridView1.RowHeadersWidth = 120
            DataGridView2.Columns(i).Width = 100
            DataGridView2.RowHeadersWidth = 120
            DataGridView3.Columns(i).Width = 100
            DataGridView3.RowHeadersWidth = 140


        Next

        For i = 0 To fila - 1
            DataGridView1.Rows(i).HeaderCell.Value = "Venta N° " + (i + 1).ToString
            DataGridView2.Rows(i).HeaderCell.Value = "Ventas N° " + (i + 1).ToString
            DataGridView3.Rows(i).HeaderCell.Value = "Total Venta N°" + (i + 1).ToString

        Next
        Button3.Enabled = True


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim x, i As Integer
        Button4.Enabled = True
        Button5.Enabled = False
        For i = 0 To DataGridView1.RowCount - 1
            For x = 0 To DataGridView1.ColumnCount - 1
                DataGridView1.Rows(i).Cells(x).Value = InputBox("Ingrese precio", "Valor del destino")
            Next x
        Next i
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim x, i As Integer
        Button1.Enabled = True
        Button6.Enabled = True
        Button3.Enabled = False
        For i = 0 To DataGridView1.RowCount - 1
            For x = 0 To DataGridView1.ColumnCount - 1
                DataGridView2.Rows(i).Cells(x).Value = InputBox("Ingrese Cantidad de tiquetes", "Cantidad tiquetes")
            Next x
        Next i
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim x, i As Integer
        Panel2.Visible = False
        For i = 0 To DataGridView1.RowCount - 1
            For x = 0 To DataGridView1.ColumnCount - 1
                DataGridView1.Rows(i).Cells(x).Value = ""
                DataGridView2.Rows(i).Cells(x).Value = ""
                DataGridView3.Rows(i).Cells(x).Value = ""
            Next x
        Next i
        Button5.Enabled = True
    End Sub
    Private Sub Button1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseHover
        Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Bold)
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Regular)
    End Sub
    Private Sub Button2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseHover
        Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Bold)
    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Regular)
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
    Private Sub Button5_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.MouseHover
        Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Bold)
    End Sub

    Private Sub Button5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.MouseLeave
        Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Regular)
    End Sub
    Private Sub Button6_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button6.MouseHover
        Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Bold)
    End Sub

    Private Sub Button6_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button6.MouseLeave
        Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Regular)
    End Sub

End Class