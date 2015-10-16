Public Class matrices

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

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class