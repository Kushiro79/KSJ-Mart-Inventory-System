Public NotInheritable Class AboutMart

    Private Sub AboutMart_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set the title of the form.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("About {0}", ApplicationTitle)
        ' Initialize all of the text displayed on the About Box.
        ' TODO: Customize the application's assembly information in the "Application" pane of the project 
        '    properties dialog (under the "Project" menu).
        Me.LabelProductName.Text = My.Application.Info.ProductName
        Me.LabelVersion.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
        Me.LabelCopyright.Text = My.Application.Info.Copyright
        Me.LabelCompanyName.Text = "UTM Sdn Bhd"
        Me.TextBoxDescription.Text = "Description :The KSJ Mart Inventory Management System is designed to streamline and simplify inventory control for KSJ Mart. Built to meet the specific needs of the owner and staff, the system helps efficiently track product quantities, monitor stock levels, and automate reordering processes. With user-friendly features, the system ensures accurate record-keeping, minimizes errors, and enhances the day-to-day management of the mart's inventory. Whether adding new items, updating stock, or reviewing reports, our inventory system empowers KSJ Mart to run smoothly and stay well-stocked."
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Hide()
        HomePage.Show()


    End Sub


End Class
