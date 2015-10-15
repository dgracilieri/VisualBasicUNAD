Public Class matrices

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i, x, j, filasa, filasb, aux As Integer
     


        filasa = DataGridView1.Rows.GetRowCount(DataGridViewElementStates.Visible)
        filasb = DataGridView2.Rows.GetRowCount(DataGridViewElementStates.Visible)


        If filasa <> filasb Then
            MsgBox("En necesario que complete los datos de costos y cantidad de viajes", MsgBoxStyle.Information, "Ventas pasajes")
        Else

            For i = 0 To filasa - 2

                For j = 0 To 3 - 1
                    aux = Val(DataGridView1.Rows(i).Cells(j).Value) * Val(DataGridView2.Rows(i).Cells(j).Value)

                    DataGridView3.Rows(i).Cells(j).Value = Val(aux)


                Next j




            Next i

        End If



    End Sub

    
    Private Sub DataGridView1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DataGridView1.KeyPress



        DataGridView1.Rows(0).HeaderCell.Value = (1 + 1).ToString



    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim x, i As Integer
        x = InputBox("Ingrese la cantidad de datos")
        Dim precios(x) As Integer
        For i = 0 To x

            precios(i) = InputBox("Ingrese precio")
        Next
        DataGridView1.DataSource = precios


        
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class