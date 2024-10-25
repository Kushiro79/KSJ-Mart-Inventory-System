Public Class ManageStock
    Private Sub ManageStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KSJMartInventorySystemDataSet.OrderProduct' table. You can move, or remove it, as needed.
        Me.OrderProductTableAdapter.Fill(Me.KSJMartInventorySystemDataSet.OrderProduct)

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Hide()
        Login.Show()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        HomePage.Show()

    End Sub

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles OrderProductDataGridView.CellFormatting
        If OrderProductDataGridView.Columns(e.ColumnIndex).Name = "Status" Then
            Dim status As String = e.Value.ToString()
            Select Case status
                Case "In Stock"
                    e.CellStyle.BackColor = Color.Green
                Case "Low Stock"
                    e.CellStyle.BackColor = Color.Yellow
                Case "No Stock"
                    e.CellStyle.BackColor = Color.Red
            End Select
        End If
    End Sub

End Class