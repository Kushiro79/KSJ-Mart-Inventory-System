Imports System.Data.Common
Imports System.Data.OleDb
Imports KSJMartInventorySystem.KSJMartInventorySystemDataSetTableAdapters
Public Class ManageStock
    Private connectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\Users\User\Documents\GitHub\KSJ-Mart-Inventory-System\KSJMartInventorySystem\KSJMartInventorySystem\KSJMartInventorySystem.mdb"
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
        If String.IsNullOrWhiteSpace(ProductNameTextBox.Text) Or
        String.IsNullOrWhiteSpace(MinQuantityTextBox.Text) Or
        String.IsNullOrWhiteSpace(QuantityTextBox.Text) Or
        String.IsNullOrWhiteSpace(StatusTextBox.Text) Or
        String.IsNullOrWhiteSpace(SKUTextBox.Text) Then

            MessageBox.Show("Please fill all fields.")
            Return
        End If

        ' Call the UpdateQuery method with parameters to update Access database
        Dim rowsAffected As Integer = UpdateQuery(
            ProductNameTextBox.Text,
            Convert.ToInt32(MinQuantityTextBox.Text),
            Convert.ToInt32(QuantityTextBox.Text),
            ArrivalDateDateTimePicker.Value,
            StatusTextBox.Text,
            SKUTextBox.Text
        )

        ' Confirm that rows were updated in the Access database
        If rowsAffected > 0 Then
            MessageBox.Show("Update Successful")
            ' Reload data to show the update in DataGrid
            Me.OrderProductTableAdapter.Fill(Me.KSJMartInventorySystemDataSet.OrderProduct)
        Else
            MessageBox.Show("No records updated.")
        End If
    End Sub

    Public Function UpdateQuery(
      ProductName As String,
     MinQuantity As Integer,
     Quantity As Integer,
     ArrivalDate As Date,
     Status As String,
     SKU As String) As Integer

        Dim rowsAffected As Integer = 0  ' Declare rowsAffected

        Dim sqlCommand As String = "UPDATE OrderProduct " &
                                   "SET ProductName = ?, MinQuantity = ?, Quantity = ?, ArrivalDate = ?, Status = ? " &
                                   "WHERE SKU = ?"

        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()

                Using command As New OleDbCommand(sqlCommand, connection)
                    command.Parameters.AddWithValue("@ProductName", ProductName)
                    command.Parameters.AddWithValue("@MinQuantity", MinQuantity)
                    command.Parameters.AddWithValue("@Quantity", Quantity)
                    command.Parameters.AddWithValue("@ArrivalDate", ArrivalDate)
                    command.Parameters.AddWithValue("@Status", Status)
                    command.Parameters.AddWithValue("@SKU", SKU)

                    rowsAffected = command.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

        Return rowsAffected  ' Return the affected rows count
    End Function


End Class