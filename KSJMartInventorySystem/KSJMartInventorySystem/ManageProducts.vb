Imports System.Data.OleDb

Public Class ManageProducts
    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\masri\OneDrive\Documents\GitHub\KSJ-Mart-Inventory-System\KSJMartInventorySystem\KSJMartInventorySystem\KSJMartInventorySystem.mdb"
    Private adapter As OleDbDataAdapter
    Private dt As New DataTable()

    Private Sub AddProductBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AddProductBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.KSJMartInventorySystemDataSet)
    End Sub

    Private Sub ManageProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KSJMartInventorySystemDataSet.AddProduct' table. You can move, or remove it, as needed.
        Me.AddProductTableAdapter.Fill(Me.KSJMartInventorySystemDataSet.AddProduct)
        LoadProducts("SKU")
        SortComboBox.Items.Clear()
        SortComboBox.Items.Add("SKU")
        SortComboBox.Items.Add("Supplier")
        SortComboBox.Items.Add("ProductName")
        SortComboBox.Items.Add("Brand")

        ' Optional: Set a default selected item
        SortComboBox.SelectedIndex = 0
    End Sub

    Public Sub LoadProducts(Optional sortColumn As String = "SKU")
        Try
            Using connection As New OleDbConnection(connectionString)
                Dim query As String = $"SELECT * FROM AddProduct ORDER BY {sortColumn}"
                adapter = New OleDbDataAdapter(query, connection)
                dt = New DataTable()
                adapter.Fill(dt)
                AddProductDataGridView.DataSource = dt
            End Using
        Catch ex As Exception
            Dim customMessageBox As New CustomMessageBox("Error loading products: " & ex.Message, "Error")
            customMessageBox.ShowDialog()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim addDialog As New Dialog1()
        addDialog.DataGridViewReference = AddProductDataGridView ' Pass reference here
        If addDialog.ShowDialog() = DialogResult.OK Then
            LoadProducts() ' Refresh DataGridView in case new data was added
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        HomePage.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub AddProductDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles AddProductDataGridView.CellContentClick
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        Dim searchText As String = SearchTextBox.Text.Trim()
        Dim selectedColumn As String = SortComboBox.SelectedItem.ToString()

        ' Construct query based on selected column and search text
        Dim query As String
        If searchText = String.Empty Then
            ' If no search text, just sort by the selected column
            query = $"SELECT * FROM AddProduct ORDER BY {selectedColumn}"
        Else
            ' Filter data based on the selected column only
            query = $"SELECT * FROM AddProduct WHERE {selectedColumn} LIKE @searchText ORDER BY {selectedColumn}"
        End If

        ' Fetch and display sorted and/or filtered data
        Dim filteredData As New DataTable()
        Try
            Using connection As New OleDbConnection(connectionString)
                adapter = New OleDbDataAdapter(query, connection)
                adapter.SelectCommand.Parameters.AddWithValue("@searchText", "%" & searchText & "%")
                adapter.Fill(filteredData)
                AddProductDataGridView.DataSource = filteredData
            End Using
        Catch ex As Exception
            Dim customMessageBox As New CustomMessageBox("Error searching data: " & ex.Message, "Error")
            customMessageBox.ShowDialog()
        End Try
    End Sub

    Private Function GetAllData() As DataTable
        Dim allData As New DataTable()
        Try
            Using connection As New OleDbConnection(connectionString)
                Dim query As String = "SELECT * FROM AddProduct"
                adapter = New OleDbDataAdapter(query, connection)
                adapter.Fill(allData)
            End Using
        Catch ex As Exception
            Dim customMessageBox As New CustomMessageBox("Error loading all data: " & ex.Message, "Error")
            customMessageBox.ShowDialog()
        End Try
        Return allData
    End Function

    Private Function GetFilteredData(searchText As String) As DataTable
        Dim filteredData As New DataTable()
        Try
            Using connection As New OleDbConnection(connectionString)
                Dim query As String = "SELECT * FROM AddProduct WHERE ProductName LIKE @searchText"
                adapter = New OleDbDataAdapter(query, connection)
                adapter.SelectCommand.Parameters.AddWithValue("@searchText", "%" & searchText & "%")
                adapter.Fill(filteredData)
            End Using
        Catch ex As Exception
            Dim customMessageBox As New CustomMessageBox("Error filtering data: " & ex.Message, "Error")
            customMessageBox.ShowDialog()
        End Try
        Return filteredData
    End Function

    Private Sub SortComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SortComboBox.SelectedIndexChanged
        Dim selectedColumn As String = SortComboBox.SelectedItem.ToString()
        LoadProducts(selectedColumn)
    End Sub
End Class
