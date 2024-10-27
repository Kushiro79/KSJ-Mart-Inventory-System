Imports System.Data.OleDb

Public Class ManageProducts
    Private connectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\Project\VB.Net\KSJ-Mart-Inventory-System\KSJMartInventorySystem\KSJMartInventorySystem\KSJMartInventorySystem.mdb"
    Private adapter As OleDbDataAdapter
    Private dt As New DataTable()

    Private Sub AddProductBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AddProductBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.KSJMartInventorySystemDataSet)

    End Sub

    Private Sub ManageProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KSJMartInventorySystemDataSet.OrderProduct' table. You can move, or remove it, as needed.
        Me.OrderProductTableAdapter.Fill(Me.KSJMartInventorySystemDataSet.OrderProduct)
        'TODO: This line of code loads data into the 'KSJMartInventorySystemDataSet.OrderProduct' table. You can move, or remove it, as needed.
        Me.OrderProductTableAdapter.Fill(Me.KSJMartInventorySystemDataSet.OrderProduct)
        'TODO: This line of code loads data into the 'KSJMartInventorySystemDataSet.AddProduct' table. You can move, or remove it, as needed.
        Me.AddProductTableAdapter.Fill(Me.KSJMartInventorySystemDataSet.AddProduct)
        LoadProducts()

    End Sub

    Public Sub LoadProducts()
        Try
            Using connection As New OleDbConnection(connectionString)
                Dim query As String = "SELECT * FROM AddProduct"
                adapter = New OleDbDataAdapter(query, connection)
                dt = New DataTable()
                adapter.Fill(dt)
                AddProductDataGridView.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading products :" & ex.Message)
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


End Class