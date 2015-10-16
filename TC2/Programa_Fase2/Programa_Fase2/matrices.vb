Public Class matrices

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i, j As Byte

        For i = 0 To DataGridView1.RowCount - 1

            For j = 0 To DataGridView1.ColumnCount - 1

                DataGridView3.Rows(i).Cells(j).Value = Val(DataGridView1.Rows(i).Cells(j).Value) * Val(DataGridView2.Rows(i).Cells(j).Value)

            Next j

        Next i

    End Sub


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim fila As Byte, columna As Byte, i As Integer

        fila = InputBox("Cantidad de ventas")
        columna = 3
        DataGridView1.RowCount = fila
        DataGridView1.ColumnCount = columna
        DataGridView2.RowCount = fila
        DataGridView2.ColumnCount = columna
        DataGridView3.RowCount = fila
        DataGridView3.ColumnCount = columna

        For i = 0 To columna - 1

            DataGridView1.Columns(i).Width = 100
            DataGridView2.Columns(i).Width = 100
            DataGridView3.Columns(i).Width = 100

        Next

        For i = 0 To fila - 1
            DataGridView1.Rows(i).HeaderCell.Value = "Codigo Venta" + i.ToString
            DataGridView2.Rows(i).HeaderCell.Value = "Codigo Venta" + i.ToString
            DataGridView3.Rows(i).HeaderCell.Value = "Codigo Venta" + i.ToString

        Next



    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim x, i As Integer

        For i = 0 To DataGridView1.RowCount - 1
            For x = 0 To DataGridView1.ColumnCount - 1
                DataGridView1.Rows(i).Cells(x).Value = InputBox("Ingrese precio")
            Next x
        Next i
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim x, i As Integer

        For i = 0 To DataGridView1.RowCount - 1
            For x = 0 To DataGridView1.ColumnCount - 1
                DataGridView2.Rows(i).Cells(x).Value = InputBox("Ingrese precio")
            Next x
        Next i
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim x, i As Integer

        For i = 0 To DataGridView1.RowCount - 1
            For x = 0 To DataGridView1.ColumnCount - 1
                DataGridView1.Rows(i).Cells(x).Value = ""
                DataGridView2.Rows(i).Cells(x).Value = ""
                DataGridView3.Rows(i).Cells(x).Value = ""
            Next x
        Next i
    End Sub

End Class