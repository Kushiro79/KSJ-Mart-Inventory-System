Imports System.Windows.Forms
Imports System.Data.OleDb
Public Class Dialog1
    Public Property DataGridViewReference As DataGridView
    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Documents\GitHub\KSJ-Mart-Inventory-System\KSJMartInventorySystem\KSJMartInventorySystem\KSJMartInventorySystem.mdb"

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If SaveProducts() Then
            MessageBox.Show("Product added successfully.")
            ' Refreshing the DataGridViews in ManageProducts and ManageStock forms
            Dim manageProductsForm As ManageProducts = DirectCast(Application.OpenForms("ManageProducts"), ManageProducts)
            Dim manageStockForm As ManageStock = DirectCast(Application.OpenForms("ManageStock"), ManageStock)
            If manageProductsForm IsNot Nothing Then
                manageProductsForm.LoadProducts() ' Refresh AddProductDataGridView
            Else
                MessageBox.Show("ManageProducts form not found.")
            End If


            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            MessageBox.Show("Failed to add product.")
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


    Private Sub Dialog1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProducts()
    End Sub


    Private Function SaveProducts() As Boolean
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()

                Dim query As String = "INSERT INTO AddProduct (ProductName, SKU, Supplier, Price, Brand) VALUES (?, ?, ?, ?, ?)"
                Using command As New OleDbCommand(query, connection)
                    command.Parameters.AddWithValue("@ProductName", ProductNameTextBox.Text)
                    command.Parameters.AddWithValue("@SKU", SKUTextBox.Text)
                    command.Parameters.AddWithValue("@Supplier", SupplierTextBox.Text)
                    command.Parameters.AddWithValue("@Price", PriceTextBox.Text)
                    command.Parameters.AddWithValue("@Brand", BrandTextBox.Text)

                    command.ExecuteNonQuery()
                End Using

                Dim queryOrderProduct As String = "INSERT INTO OrderProduct (SKU, ProductName) VALUES (?, ?)"
                Using command As New OleDbCommand(queryOrderProduct, connection)
                    command.Parameters.AddWithValue("@SKU", SKUTextBox.Text)
                    command.Parameters.AddWithValue("@ProductName", ProductNameTextBox.Text)
                    command.ExecuteNonQuery()
                End Using

                Return True
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            Return False
        End Try
    End Function


    Private Sub LoadProducts()

        Using connection As New OleDbConnection(connectionString)
            Dim query As String = "SELECT * FROM AddProduct"
            Dim adapter As New OleDbDataAdapter(query, connection)
            Dim dataTable As New DataTable()

            adapter.Fill(dataTable)
            If DataGridViewReference IsNot Nothing Then
                DataGridViewReference.DataSource = dataTable

            End If
        End Using

    End Sub

End Class