<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManageStock
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim SKULabel As System.Windows.Forms.Label
        Dim ProductNameLabel As System.Windows.Forms.Label
        Dim MinQuantityLabel As System.Windows.Forms.Label
        Dim QuantityLabel As System.Windows.Forms.Label
        Dim ArrivalDateLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageStock))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.KSJMartInventorySystemDataSet = New KSJMartInventorySystem.KSJMartInventorySystemDataSet()
        Me.OrderProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderProductTableAdapter = New KSJMartInventorySystem.KSJMartInventorySystemDataSetTableAdapters.OrderProductTableAdapter()
        Me.TableAdapterManager = New KSJMartInventorySystem.KSJMartInventorySystemDataSetTableAdapters.TableAdapterManager()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.PreviousButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OrderProductBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderProductDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SKUTextBox = New System.Windows.Forms.TextBox()
        Me.ProductNameTextBox = New System.Windows.Forms.TextBox()
        Me.MinQuantityTextBox = New System.Windows.Forms.TextBox()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.ArrivalDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.StatusTextBox = New System.Windows.Forms.TextBox()
        Me.DeleteButton = New System.Windows.Forms.Button()
        SKULabel = New System.Windows.Forms.Label()
        ProductNameLabel = New System.Windows.Forms.Label()
        MinQuantityLabel = New System.Windows.Forms.Label()
        QuantityLabel = New System.Windows.Forms.Label()
        ArrivalDateLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        CType(Me.KSJMartInventorySystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderProductBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderProductDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SKULabel
        '
        SKULabel.AutoSize = True
        SKULabel.Location = New System.Drawing.Point(948, 117)
        SKULabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SKULabel.Name = "SKULabel"
        SKULabel.Size = New System.Drawing.Size(37, 16)
        SKULabel.TabIndex = 41
        SKULabel.Text = "SKU:"
        '
        'ProductNameLabel
        '
        ProductNameLabel.AutoSize = True
        ProductNameLabel.Location = New System.Drawing.Point(948, 149)
        ProductNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ProductNameLabel.Name = "ProductNameLabel"
        ProductNameLabel.Size = New System.Drawing.Size(96, 16)
        ProductNameLabel.TabIndex = 43
        ProductNameLabel.Text = "Product Name:"
        '
        'MinQuantityLabel
        '
        MinQuantityLabel.AutoSize = True
        MinQuantityLabel.Location = New System.Drawing.Point(948, 181)
        MinQuantityLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        MinQuantityLabel.Name = "MinQuantityLabel"
        MinQuantityLabel.Size = New System.Drawing.Size(82, 16)
        MinQuantityLabel.TabIndex = 45
        MinQuantityLabel.Text = "Min Quantity:"
        '
        'QuantityLabel
        '
        QuantityLabel.AutoSize = True
        QuantityLabel.Location = New System.Drawing.Point(948, 213)
        QuantityLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Size = New System.Drawing.Size(58, 16)
        QuantityLabel.TabIndex = 47
        QuantityLabel.Text = "Quantity:"
        '
        'ArrivalDateLabel
        '
        ArrivalDateLabel.AutoSize = True
        ArrivalDateLabel.Location = New System.Drawing.Point(948, 246)
        ArrivalDateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ArrivalDateLabel.Name = "ArrivalDateLabel"
        ArrivalDateLabel.Size = New System.Drawing.Size(80, 16)
        ArrivalDateLabel.TabIndex = 49
        ArrivalDateLabel.Text = "Arrival Date:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(948, 277)
        StatusLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(47, 16)
        StatusLabel.TabIndex = 51
        StatusLabel.Text = "Status:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Leelawadee UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(16, 66)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Stock Manager"
        '
        'KSJMartInventorySystemDataSet
        '
        Me.KSJMartInventorySystemDataSet.DataSetName = "KSJMartInventorySystemDataSet"
        Me.KSJMartInventorySystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrderProductBindingSource
        '
        Me.OrderProductBindingSource.DataMember = "OrderProduct"
        Me.OrderProductBindingSource.DataSource = Me.KSJMartInventorySystemDataSet
        '
        'OrderProductTableAdapter
        '
        Me.OrderProductTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AddProductTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.OrderProductTableAdapter = Nothing
        Me.TableAdapterManager.StaffTableAdapter = Nothing
        Me.TableAdapterManager.SupplierTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = KSJMartInventorySystem.KSJMartInventorySystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Orange
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1459, 61)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "KSJ Mart Inventory Management System"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.BackColor = System.Drawing.Color.Orange
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(1409, 15)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(33, 37)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Orange
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(16, 15)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(33, 37)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'NextButton
        '
        Me.NextButton.BackColor = System.Drawing.Color.Orange
        Me.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NextButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NextButton.ForeColor = System.Drawing.Color.Maroon
        Me.NextButton.Location = New System.Drawing.Point(1059, 347)
        Me.NextButton.Margin = New System.Windows.Forms.Padding(4)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(100, 28)
        Me.NextButton.TabIndex = 27
        Me.NextButton.Text = "Next"
        Me.NextButton.UseVisualStyleBackColor = False
        '
        'PreviousButton
        '
        Me.PreviousButton.BackColor = System.Drawing.Color.Orange
        Me.PreviousButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PreviousButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PreviousButton.ForeColor = System.Drawing.Color.Maroon
        Me.PreviousButton.Location = New System.Drawing.Point(951, 347)
        Me.PreviousButton.Margin = New System.Windows.Forms.Padding(4)
        Me.PreviousButton.Name = "PreviousButton"
        Me.PreviousButton.Size = New System.Drawing.Size(100, 28)
        Me.PreviousButton.TabIndex = 28
        Me.PreviousButton.Text = "Previous"
        Me.PreviousButton.UseVisualStyleBackColor = False
        '
        'SaveButton
        '
        Me.SaveButton.BackColor = System.Drawing.Color.Orange
        Me.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.ForeColor = System.Drawing.Color.Maroon
        Me.SaveButton.Location = New System.Drawing.Point(1167, 347)
        Me.SaveButton.Margin = New System.Windows.Forms.Padding(4)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(100, 28)
        Me.SaveButton.TabIndex = 29
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'OrderProductBindingSource1
        '
        Me.OrderProductBindingSource1.DataMember = "OrderProduct"
        Me.OrderProductBindingSource1.DataSource = Me.KSJMartInventorySystemDataSet
        '
        'OrderProductDataGridView
        '
        Me.OrderProductDataGridView.AutoGenerateColumns = False
        Me.OrderProductDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.OrderProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OrderProductDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.OrderProductDataGridView.DataSource = Me.OrderProductBindingSource
        Me.OrderProductDataGridView.Location = New System.Drawing.Point(16, 107)
        Me.OrderProductDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.OrderProductDataGridView.Name = "OrderProductDataGridView"
        Me.OrderProductDataGridView.RowHeadersWidth = 51
        Me.OrderProductDataGridView.Size = New System.Drawing.Size(851, 496)
        Me.OrderProductDataGridView.TabIndex = 41
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "SKU"
        Me.DataGridViewTextBoxColumn1.HeaderText = "SKU"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ProductName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ProductName"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "MinQuantity"
        Me.DataGridViewTextBoxColumn3.HeaderText = "MinQuantity"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Quantity"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ArrivalDate"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ArrivalDate"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'SKUTextBox
        '
        Me.SKUTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderProductBindingSource, "SKU", True))
        Me.SKUTextBox.Location = New System.Drawing.Point(1060, 113)
        Me.SKUTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SKUTextBox.Name = "SKUTextBox"
        Me.SKUTextBox.Size = New System.Drawing.Size(265, 22)
        Me.SKUTextBox.TabIndex = 42
        '
        'ProductNameTextBox
        '
        Me.ProductNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderProductBindingSource, "ProductName", True))
        Me.ProductNameTextBox.Location = New System.Drawing.Point(1060, 145)
        Me.ProductNameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ProductNameTextBox.Name = "ProductNameTextBox"
        Me.ProductNameTextBox.Size = New System.Drawing.Size(265, 22)
        Me.ProductNameTextBox.TabIndex = 44
        '
        'MinQuantityTextBox
        '
        Me.MinQuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderProductBindingSource, "MinQuantity", True))
        Me.MinQuantityTextBox.Location = New System.Drawing.Point(1060, 177)
        Me.MinQuantityTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.MinQuantityTextBox.Name = "MinQuantityTextBox"
        Me.MinQuantityTextBox.Size = New System.Drawing.Size(265, 22)
        Me.MinQuantityTextBox.TabIndex = 46
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderProductBindingSource, "Quantity", True))
        Me.QuantityTextBox.Location = New System.Drawing.Point(1060, 209)
        Me.QuantityTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(265, 22)
        Me.QuantityTextBox.TabIndex = 48
        '
        'ArrivalDateDateTimePicker
        '
        Me.ArrivalDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OrderProductBindingSource, "ArrivalDate", True))
        Me.ArrivalDateDateTimePicker.Location = New System.Drawing.Point(1060, 241)
        Me.ArrivalDateDateTimePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.ArrivalDateDateTimePicker.Name = "ArrivalDateDateTimePicker"
        Me.ArrivalDateDateTimePicker.Size = New System.Drawing.Size(265, 22)
        Me.ArrivalDateDateTimePicker.TabIndex = 50
        '
        'StatusTextBox
        '
        Me.StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderProductBindingSource, "Status", True))
        Me.StatusTextBox.Location = New System.Drawing.Point(1060, 273)
        Me.StatusTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.Size = New System.Drawing.Size(265, 22)
        Me.StatusTextBox.TabIndex = 52
        '
        'DeleteButton
        '
        Me.DeleteButton.BackColor = System.Drawing.Color.Orange
        Me.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButton.ForeColor = System.Drawing.Color.Maroon
        Me.DeleteButton.Location = New System.Drawing.Point(1275, 347)
        Me.DeleteButton.Margin = New System.Windows.Forms.Padding(4)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(100, 28)
        Me.DeleteButton.TabIndex = 53
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = False
        '
        'ManageStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(1459, 666)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(SKULabel)
        Me.Controls.Add(Me.SKUTextBox)
        Me.Controls.Add(ProductNameLabel)
        Me.Controls.Add(Me.ProductNameTextBox)
        Me.Controls.Add(MinQuantityLabel)
        Me.Controls.Add(Me.MinQuantityTextBox)
        Me.Controls.Add(QuantityLabel)
        Me.Controls.Add(Me.QuantityTextBox)
        Me.Controls.Add(ArrivalDateLabel)
        Me.Controls.Add(Me.ArrivalDateDateTimePicker)
        Me.Controls.Add(StatusLabel)
        Me.Controls.Add(Me.StatusTextBox)
        Me.Controls.Add(Me.OrderProductDataGridView)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.PreviousButton)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ManageStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ManageStock"
        CType(Me.KSJMartInventorySystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderProductBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderProductDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents KSJMartInventorySystemDataSet As KSJMartInventorySystemDataSet
    Friend WithEvents OrderProductBindingSource As BindingSource
    Friend WithEvents OrderProductTableAdapter As KSJMartInventorySystemDataSetTableAdapters.OrderProductTableAdapter
    Friend WithEvents TableAdapterManager As KSJMartInventorySystemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents NextButton As Button
    Friend WithEvents PreviousButton As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents OrderProductBindingSource1 As BindingSource
    Friend WithEvents OrderProductDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents SKUTextBox As TextBox
    Friend WithEvents ProductNameTextBox As TextBox
    Friend WithEvents MinQuantityTextBox As TextBox
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents ArrivalDateDateTimePicker As DateTimePicker
    Friend WithEvents StatusTextBox As TextBox
    Friend WithEvents DeleteButton As Button
End Class
