<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomePage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomePage))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ManageStockButton = New System.Windows.Forms.Button()
        Me.ManageProductsButton = New System.Windows.Forms.Button()
        Me.ManageStockPicture = New System.Windows.Forms.PictureBox()
        Me.ManageProductPicture = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.ManageStockPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ManageProductPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Orange
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(800, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "KSJ Mart Inventory Management System"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ManageStockButton
        '
        Me.ManageStockButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ManageStockButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ManageStockButton.BackColor = System.Drawing.Color.Honeydew
        Me.ManageStockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ManageStockButton.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManageStockButton.ForeColor = System.Drawing.Color.DarkGreen
        Me.ManageStockButton.Location = New System.Drawing.Point(84, 150)
        Me.ManageStockButton.Name = "ManageStockButton"
        Me.ManageStockButton.Padding = New System.Windows.Forms.Padding(0, 0, 0, 25)
        Me.ManageStockButton.Size = New System.Drawing.Size(285, 172)
        Me.ManageStockButton.TabIndex = 1
        Me.ManageStockButton.Text = "Manage Stock"
        Me.ManageStockButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ManageStockButton.UseVisualStyleBackColor = False
        '
        'ManageProductsButton
        '
        Me.ManageProductsButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ManageProductsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ManageProductsButton.BackColor = System.Drawing.Color.MistyRose
        Me.ManageProductsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ManageProductsButton.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManageProductsButton.ForeColor = System.Drawing.Color.Maroon
        Me.ManageProductsButton.Location = New System.Drawing.Point(446, 150)
        Me.ManageProductsButton.Name = "ManageProductsButton"
        Me.ManageProductsButton.Padding = New System.Windows.Forms.Padding(0, 0, 0, 25)
        Me.ManageProductsButton.Size = New System.Drawing.Size(285, 172)
        Me.ManageProductsButton.TabIndex = 2
        Me.ManageProductsButton.Text = "Manage Products"
        Me.ManageProductsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ManageProductsButton.UseVisualStyleBackColor = False
        '
        'ManageStockPicture
        '
        Me.ManageStockPicture.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ManageStockPicture.BackColor = System.Drawing.Color.Honeydew
        Me.ManageStockPicture.Image = CType(resources.GetObject("ManageStockPicture.Image"), System.Drawing.Image)
        Me.ManageStockPicture.Location = New System.Drawing.Point(172, 179)
        Me.ManageStockPicture.Name = "ManageStockPicture"
        Me.ManageStockPicture.Size = New System.Drawing.Size(106, 77)
        Me.ManageStockPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ManageStockPicture.TabIndex = 3
        Me.ManageStockPicture.TabStop = False
        '
        'ManageProductPicture
        '
        Me.ManageProductPicture.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ManageProductPicture.BackColor = System.Drawing.Color.MistyRose
        Me.ManageProductPicture.Image = CType(resources.GetObject("ManageProductPicture.Image"), System.Drawing.Image)
        Me.ManageProductPicture.Location = New System.Drawing.Point(538, 191)
        Me.ManageProductPicture.Name = "ManageProductPicture"
        Me.ManageProductPicture.Size = New System.Drawing.Size(94, 65)
        Me.ManageProductPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ManageProductPicture.TabIndex = 4
        Me.ManageProductPicture.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.BackColor = System.Drawing.Color.Orange
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(761, 10)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(25, 30)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.NavajoWhite
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LinkLabel1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 373)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(800, 77)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Contact Us"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.LightGray
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Leelawadee UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel1.Location = New System.Drawing.Point(403, 38)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(39, 13)
        Me.LinkLabel1.TabIndex = 3
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "About"
        Me.LinkLabel1.VisitedLinkColor = System.Drawing.Color.LightGray
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(165, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Phone Number : +6012-333-4545"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Email : InventorySystem@vbddwd.com"
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Leelawadee UI", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(0, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(800, 97)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Welcome Back [User]!"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.ManageProductPicture)
        Me.Controls.Add(Me.ManageStockPicture)
        Me.Controls.Add(Me.ManageProductsButton)
        Me.Controls.Add(Me.ManageStockButton)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "HomePage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        CType(Me.ManageStockPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ManageProductPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ManageStockButton As Button
    Friend WithEvents ManageProductsButton As Button
    Friend WithEvents ManageStockPicture As PictureBox
    Friend WithEvents ManageProductPicture As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label5 As Label
End Class
