<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dialog1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProductNameTextBox = New System.Windows.Forms.TextBox()
        Me.ProductNameLabel = New System.Windows.Forms.Label()
        Me.SKUTextBox = New System.Windows.Forms.TextBox()
        Me.SupplierTextBox = New System.Windows.Forms.TextBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.BrandTextBox = New System.Windows.Forms.TextBox()
        Me.SKULabel = New System.Windows.Forms.Label()
        Me.SupplierLabel = New System.Windows.Forms.Label()
        Me.PriceLabel = New System.Windows.Forms.Label()
        Me.BrandLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(423, 274)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.BackColor = System.Drawing.Color.Orange
        Me.OK_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OK_Button.ForeColor = System.Drawing.Color.Maroon
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        Me.OK_Button.UseVisualStyleBackColor = False
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.BackColor = System.Drawing.Color.Orange
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel_Button.ForeColor = System.Drawing.Color.Maroon
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        Me.Cancel_Button.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Leelawadee UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(211, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Add Product"
        '
        'ProductNameTextBox
        '
        Me.ProductNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProductNameTextBox.Location = New System.Drawing.Point(60, 91)
        Me.ProductNameTextBox.Name = "ProductNameTextBox"
        Me.ProductNameTextBox.Size = New System.Drawing.Size(152, 20)
        Me.ProductNameTextBox.TabIndex = 2
        '
        'ProductNameLabel
        '
        Me.ProductNameLabel.AutoSize = True
        Me.ProductNameLabel.Location = New System.Drawing.Point(57, 75)
        Me.ProductNameLabel.Name = "ProductNameLabel"
        Me.ProductNameLabel.Size = New System.Drawing.Size(75, 13)
        Me.ProductNameLabel.TabIndex = 7
        Me.ProductNameLabel.Text = "Product Name"
        '
        'SKUTextBox
        '
        Me.SKUTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SKUTextBox.ForeColor = System.Drawing.Color.Maroon
        Me.SKUTextBox.Location = New System.Drawing.Point(60, 154)
        Me.SKUTextBox.Name = "SKUTextBox"
        Me.SKUTextBox.Size = New System.Drawing.Size(152, 20)
        Me.SKUTextBox.TabIndex = 8
        '
        'SupplierTextBox
        '
        Me.SupplierTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SupplierTextBox.Location = New System.Drawing.Point(60, 214)
        Me.SupplierTextBox.Name = "SupplierTextBox"
        Me.SupplierTextBox.Size = New System.Drawing.Size(152, 20)
        Me.SupplierTextBox.TabIndex = 9
        '
        'PriceTextBox
        '
        Me.PriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PriceTextBox.Location = New System.Drawing.Point(287, 91)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(152, 20)
        Me.PriceTextBox.TabIndex = 10
        '
        'BrandTextBox
        '
        Me.BrandTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BrandTextBox.Location = New System.Drawing.Point(287, 154)
        Me.BrandTextBox.Name = "BrandTextBox"
        Me.BrandTextBox.Size = New System.Drawing.Size(152, 20)
        Me.BrandTextBox.TabIndex = 11
        '
        'SKULabel
        '
        Me.SKULabel.AutoSize = True
        Me.SKULabel.Location = New System.Drawing.Point(57, 138)
        Me.SKULabel.Name = "SKULabel"
        Me.SKULabel.Size = New System.Drawing.Size(29, 13)
        Me.SKULabel.TabIndex = 12
        Me.SKULabel.Text = "SKU"
        '
        'SupplierLabel
        '
        Me.SupplierLabel.AutoSize = True
        Me.SupplierLabel.Location = New System.Drawing.Point(57, 198)
        Me.SupplierLabel.Name = "SupplierLabel"
        Me.SupplierLabel.Size = New System.Drawing.Size(45, 13)
        Me.SupplierLabel.TabIndex = 13
        Me.SupplierLabel.Text = "Supplier"
        '
        'PriceLabel
        '
        Me.PriceLabel.AutoSize = True
        Me.PriceLabel.Location = New System.Drawing.Point(284, 75)
        Me.PriceLabel.Name = "PriceLabel"
        Me.PriceLabel.Size = New System.Drawing.Size(31, 13)
        Me.PriceLabel.TabIndex = 14
        Me.PriceLabel.Text = "Price"
        '
        'BrandLabel
        '
        Me.BrandLabel.AutoSize = True
        Me.BrandLabel.Location = New System.Drawing.Point(284, 138)
        Me.BrandLabel.Name = "BrandLabel"
        Me.BrandLabel.Size = New System.Drawing.Size(35, 13)
        Me.BrandLabel.TabIndex = 15
        Me.BrandLabel.Text = "Brand"
        '
        'Dialog1
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(581, 315)
        Me.Controls.Add(Me.BrandLabel)
        Me.Controls.Add(Me.PriceLabel)
        Me.Controls.Add(Me.SupplierLabel)
        Me.Controls.Add(Me.SKULabel)
        Me.Controls.Add(Me.BrandTextBox)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Controls.Add(Me.SupplierTextBox)
        Me.Controls.Add(Me.SKUTextBox)
        Me.Controls.Add(Me.ProductNameLabel)
        Me.Controls.Add(Me.ProductNameTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Dialog1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Dialog1"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ProductNameTextBox As TextBox
    Friend WithEvents ProductNameLabel As Label
    Friend WithEvents SKUTextBox As TextBox
    Friend WithEvents SupplierTextBox As TextBox
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents BrandTextBox As TextBox
    Friend WithEvents SKULabel As Label
    Friend WithEvents SupplierLabel As Label
    Friend WithEvents PriceLabel As Label
    Friend WithEvents BrandLabel As Label
End Class
