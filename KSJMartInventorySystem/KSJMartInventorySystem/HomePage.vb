Public Class HomePage
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        AboutMart.Show()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Hide()
        Login.Show()

    End Sub

    Private Sub ManageStockButton_Click(sender As Object, e As EventArgs) Handles ManageStockButton.Click
        Me.Hide()
        ManageStock.Show()

    End Sub

    Private Sub ManageProductsButton_Click(sender As Object, e As EventArgs) Handles ManageProductsButton.Click
        Me.Hide()
        ManageProducts.Show()

    End Sub

    Private Sub ManageProductPicture_Click(sender As Object, e As EventArgs) Handles ManageProductPicture.Click
        Me.Hide()
        ManageProducts.Show()

    End Sub

    Private Sub ManageStockPicture_Click(sender As Object, e As EventArgs) Handles ManageStockPicture.Click
        Me.Hide()
        ManageStock.Show()

    End Sub
End Class