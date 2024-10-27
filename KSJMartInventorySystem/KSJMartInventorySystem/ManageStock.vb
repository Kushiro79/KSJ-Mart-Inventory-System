Imports System.Data.Common
Imports System.Data.OleDb
Imports KSJMartInventorySystem.KSJMartInventorySystemDataSetTableAdapters
Public Class ManageStock
    Private connectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\Project\VB.Net\KSJ-Mart-Inventory-System\KSJMartInventorySystem\KSJMartInventorySystem\KSJMartInventorySystem.mdb"
    Private adapter As OleDbDataAdapter
    Private dt As New DataTable()
    Dim command As String

    Private Sub ManageStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KSJMartInventorySystemDataSet.OrderProduct' table. You can move, or remove it, as needed.
        Me.OrderProductTableAdapter.Fill(KSJMartInventorySystemDataSet.OrderProduct)

    End Sub



    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Hide()
        Login.Show()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        HomePage.Show()

    End Sub



    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        OrderProductBindingSource.MoveNext()
    End Sub

    Private Sub PreviousButton_Click(sender As Object, e As EventArgs) Handles PreviousButton.Click
        OrderProductBindingSource.MovePrevious()
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Try
            ' Call the UpdateQuery method with parameters
            Dim rowsAffected As Integer = OrderProductTableAdapter.UpdateQuery(
                ProductNameTextBox.Text,
                Convert.ToInt32(MinQuantityTextBox.Text), ' Ensure this is the correct type
                Convert.ToInt32(QuantityTextBox.Text), ' Ensure this is the correct type
                ArrivalDateDateTimePicker.Value,
                StatusTextBox.Text,
                SKUTextBox.Text
            )

            If rowsAffected > 0 Then
                MessageBox.Show("Update Successful")
            Else
                MessageBox.Show("No records updated.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub








    '  Private Sub OrderProductDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles OrderProductDataGridView.CellContentClick
    '     If e.RowIndex >= 0 Then
    ' Get the SKU and ProductName from the selected row in OrderProductDataGridView
    'Dim selectedSKU As String = OrderProductDataGridView.Rows(e.RowIndex).Cells("SKU").Value.ToString()
    'Dim selectedProductName As String = OrderProductDataGridView.Rows(e.RowIndex).Cells("ProductName").Value.ToString()

    '       MessageBox.Show("Selected SKU: " & selectedSKU & vbCrLf & "Selected Product Name: " & selectedProductName)

    ' Access ManageProducts form to retrieve the AddProductDataGridView
    'Dim manageProductsForm As ManageProducts = DirectCast(Application.OpenForms("ManageProducts"), ManageProducts)
    '       If manageProductsForm IsNot Nothing Then
    ' Check for matching SKU in AddProductDataGridView
    '         For Each row As DataGridViewRow In manageProductsForm.AddProductDataGridView.Rows
    '              If row.Cells("SKU").Value.ToString() = selectedSKU Then
    'Dim productName As String = row.Cells("ProductName").Value.ToString()
    '                   MessageBox.Show("Matching Product Name from AddProductDataGridView: " & productName)
    '                  Exit For
    '             End If
    '        Next
    '   Else
    '     MessageBox.Show("ManageProducts form not found.")
    '  End If
    'End If
    'End Sub
End Class