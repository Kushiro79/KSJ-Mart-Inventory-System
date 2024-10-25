Public Class ManageProducts
    Private Sub AddProductBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AddProductBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.KSJMartInventorySystemDataSet)

    End Sub

    Private Sub ManageProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KSJMartInventorySystemDataSet.AddProduct' table. You can move, or remove it, as needed.
        Me.AddProductTableAdapter.Fill(Me.KSJMartInventorySystemDataSet.AddProduct)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dialog1.ShowDialog()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        HomePage.Show()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Hide()
        Login.Show()

    End Sub
End Class