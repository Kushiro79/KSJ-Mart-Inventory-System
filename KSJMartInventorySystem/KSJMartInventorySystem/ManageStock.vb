Imports System.Data.OleDb
Public Class ManageStock
    Private connectionString As String = "Provider=Microsoft.Jet.OLEDB.12.0; Data Source=C:\Project\VB.Net\KSJ-Mart-Inventory-System\KSJMartInventorySystem\KSJMartInventorySystem\KSJMartInventorySystem.mdb"
    Private adapter As OleDbDataAdapter
    Private dt As New DataTable()

    Private Sub ManageStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KSJMartInventorySystemDataSet.OrderProduct' table. You can move, or remove it, as needed.
        Me.OrderProductTableAdapter.Fill(Me.KSJMartInventorySystemDataSet.OrderProduct)
        RefreshOrderProductDataGridView()

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




    Public Sub RefreshOrderProductDataGridView()
         Try
            Using connection As New OleDbConnection(connectionString)
                ' Fetch from OrderProduct instead of AddProduct
                Dim query As String = "SELECT SKU, ProductName FROM OrderProduct"
                Dim adapter As New OleDbDataAdapter(query, connection)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                OrderProductDataGridView.DataSource = dt
            End Using
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