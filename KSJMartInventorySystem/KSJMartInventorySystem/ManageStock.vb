Imports System.Data.Common
Imports System.Data.OleDb
Imports KSJMartInventorySystem.KSJMartInventorySystemDataSetTableAdapters
Public Class ManageStock
    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\masri\OneDrive\Documents\GitHub\KSJ-Mart-Inventory-System\KSJMartInventorySystem\KSJMartInventorySystem\KSJMartInventorySystem.mdb"
    Private adapter As OleDbDataAdapter
    Private dt As New DataTable()
    Dim command As String

    Private Sub ManageStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.OrderProductTableAdapter.Fill(Me.KSJMartInventorySystemDataSet.OrderProduct)
        RefreshOrderProductDataGridView()
        AddHandler OrderProductDataGridView.CellFormatting, AddressOf OrderProductDataGridView_CellFormatting

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
       String.IsNullOrWhiteSpace(SKUTextBox.Text) Then

            Dim customMessageBox As New CustomMessageBox("Please fill all fields.", "Warning")
            customMessageBox.ShowDialog()
            Return
        End If

        ' Update the status and reflect it in the StatusTextBox
        UpdateStatus(SKUTextBox.Text)

        ' Now, call the UpdateQuery method to update the database with the updated status
        Dim rowsAffected As Integer = UpdateQuery(
        ProductNameTextBox.Text,
        Convert.ToInt32(MinQuantityTextBox.Text),
        Convert.ToInt32(QuantityTextBox.Text),
        ArrivalDateDateTimePicker.Value,
        StatusTextBox.Text, ' Use the updated StatusTextBox value
        SKUTextBox.Text
    )

        ' Check if the update was successful
        If rowsAffected > 0 Then
            Dim customMessageBox As New CustomMessageBox("Update Successful", "Success")
            customMessageBox.ShowDialog()

            ' Save changes to the database using TableAdapter
            Try
                Me.Validate() ' Validate the input controls
                Me.OrderProductBindingSource.EndEdit() ' End editing
                Me.OrderProductTableAdapter.Update(KSJMartInventorySystemDataSet.OrderProduct)
                KSJMartInventorySystemDataSet.AcceptChanges() ' Commit the changes
            Catch ex As Exception
                Dim customMessageBoxs As New CustomMessageBox("Error saving to database: " & ex.Message, "Error")
                customMessageBoxs.ShowDialog()
            End Try
        Else
            Dim customMessageBox As New CustomMessageBox("No records updated.", "Information")
            customMessageBox.ShowDialog()
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
            Dim customMessageBoxs As New CustomMessageBox("Error loading data: " & ex.Message, "Error")
            customMessageBoxs.ShowDialog()
        End Try

        Return rowsAffected  ' Return the affected rows count
    End Function



    Private Sub OrderProductDataGridView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles OrderProductDataGridView.CellFormatting
        ' Check if the current column is DataGridViewTextBoxColumn6 (Status column)
        If OrderProductDataGridView.Columns(e.ColumnIndex).Name = "DataGridViewTextBoxColumn6" AndAlso e.Value IsNot Nothing Then
            Dim status As String = e.Value.ToString()

            ' Apply colors based on status value
            Select Case status
                Case "In Stock"
                    e.CellStyle.BackColor = Color.LightGreen
                    e.CellStyle.ForeColor = Color.Black
                Case "Low Stock"
                    e.CellStyle.BackColor = Color.Yellow
                    e.CellStyle.ForeColor = Color.Black
                Case "No Stock"
                    e.CellStyle.BackColor = Color.LightCoral
                    e.CellStyle.ForeColor = Color.Black
                Case Else
                    e.CellStyle.BackColor = Color.White
                    e.CellStyle.ForeColor = Color.Black
            End Select
        End If
    End Sub

    Private Sub UpdateStatus(updatedSKU As String)
        For Each row As DataGridViewRow In OrderProductDataGridView.Rows
            If Not row.IsNewRow AndAlso row.Cells("DataGridViewTextBoxColumn1").Value IsNot Nothing AndAlso row.Cells("DataGridViewTextBoxColumn1").Value.ToString() = updatedSKU Then
                Dim quantity As Integer = Convert.ToInt32(row.Cells("DataGridViewTextBoxColumn4").Value)
                Dim minQuantity As Integer = Convert.ToInt32(row.Cells("DataGridViewTextBoxColumn3").Value)
                Dim newStatus As String

                ' Determine the new status based on quantity and min quantity
                If quantity = 0 Then
                    newStatus = "No Stock"
                ElseIf quantity < minQuantity Then
                    newStatus = "Low Stock"
                Else
                    newStatus = "In Stock"
                End If

                ' Update the DataGridView and StatusTextBox with the new status
                row.Cells("DataGridViewTextBoxColumn6").Value = newStatus
                StatusTextBox.Text = newStatus
                Exit For ' Exit loop after finding the updated row
            End If
        Next
    End Sub


    Public Sub RefreshOrderProductDataGridView()
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()

                ' Fetch all necessary columns from OrderProduct
                Dim query As String = "SELECT SKU, ProductName, MinQuantity, Quantity, ArrivalDate, Status FROM OrderProduct"
                Dim adapter As New OleDbDataAdapter(query, connection)
                Dim dt As New DataTable()
                adapter.Fill(dt)

                ' Set the DataTable as the data source for the DataGridView
                OrderProductDataGridView.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub












End Class