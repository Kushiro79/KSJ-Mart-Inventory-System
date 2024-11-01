Imports System.Drawing.Drawing2D

Public Class CustomMessageBox
    ' Constructor to initialize the message and title
    Public Sub New(message As String, title As String)
        InitializeComponent()

        ' Set the message and title
        lblMessage.Text = message
        Me.Text = title
        lblMessage.ForeColor = Color.Maroon
        btnOK.BackColor = Color.Orange
        btnOK.ForeColor = Color.White
    End Sub

    Private Sub CustomMessageBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(250, 235, 215) ' Beige background color
        Me.FormBorderStyle = FormBorderStyle.None
        Me.Region = New Region(CreateRoundedRectangle(Me.ClientRectangle, 30)) ' Rounded corners
        Me.TopMost = True ' Ensure the message box is always on top

        ' Center the label horizontally and vertically
        lblMessage.Left = (Me.ClientSize.Width - lblMessage.Width) \ 2
        lblMessage.Top = (Me.ClientSize.Height - lblMessage.Height - btnOK.Height) \ 2
    End Sub

    Private Sub CustomMessageBox_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Dim borderWidth As Integer = 5 ' Thickness of the red border
        Dim borderColor As Color = Color.Maroon ' Red color for the border

        ' Create a rectangle slightly smaller than the form dimensions to draw the border
        Dim borderRect As New Rectangle(0, 0, Me.ClientSize.Width - 1, Me.ClientSize.Height - 1)

        ' Create a pen for drawing the border
        Using borderPen As New Pen(borderColor, borderWidth)
            borderPen.Alignment = PenAlignment.Inset ' Ensures the border is drawn inside the form bounds
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias ' Smooth edges
            e.Graphics.DrawRectangle(borderPen, borderRect)
        End Using
    End Sub

    ' Create a rounded rectangle region for the form border
    Private Function CreateRoundedRectangle(rect As Rectangle, radius As Integer) As GraphicsPath
        Dim path As New GraphicsPath()
        path.StartFigure()
        path.AddArc(New Rectangle(rect.X, rect.Y, radius, radius), 180, 90)
        path.AddLine(rect.X + radius, rect.Y, rect.Right - radius, rect.Y)
        path.AddArc(New Rectangle(rect.Right - radius, rect.Y, radius, radius), -90, 90)
        path.AddLine(rect.Right, rect.Y + radius, rect.Right, rect.Bottom - radius)
        path.AddArc(New Rectangle(rect.Right - radius, rect.Bottom - radius, radius, radius), 0, 90)
        path.AddLine(rect.Right - radius, rect.Bottom, rect.X + radius, rect.Bottom)
        path.AddArc(New Rectangle(rect.X, rect.Bottom - radius, radius, radius), 90, 90)
        path.CloseFigure()
        Return path
    End Function

    ' OK button click event to close the form
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class
