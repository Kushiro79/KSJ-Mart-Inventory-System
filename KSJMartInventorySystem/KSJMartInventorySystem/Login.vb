﻿Imports System.Drawing.Drawing2D

Public Class Login
    Private DGP As GraphicsPath
    Private Const CornerRadius As Integer = 40 ' Define a constant for corner radius

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        roundCorners(Me)
        ' Set label properties
        Label1.BorderStyle = BorderStyle.None ' Remove the default 
    End Sub

    Private Sub roundCorners(obj As Form)
        obj.FormBorderStyle = FormBorderStyle.None
        obj.BackColor = Color.PaleGoldenrod

        DGP = New GraphicsPath()
        DGP.StartFigure()

        ' Top left corner
        DGP.AddArc(New Rectangle(0, 0, CornerRadius, CornerRadius), 180, 90)
        DGP.AddLine(CornerRadius, 0, obj.Width - CornerRadius, 0)

        ' Top right corner
        DGP.AddArc(New Rectangle(obj.Width - CornerRadius, 0, CornerRadius, CornerRadius), -90, 90)
        DGP.AddLine(obj.Width, CornerRadius, obj.Width, obj.Height - CornerRadius)

        ' Bottom right corner
        DGP.AddArc(New Rectangle(obj.Width - CornerRadius, obj.Height - CornerRadius, CornerRadius, CornerRadius), 0, 90)
        DGP.AddLine(obj.Width - CornerRadius, obj.Height, CornerRadius, obj.Height)

        ' Bottom left corner
        DGP.AddArc(New Rectangle(0, obj.Height - CornerRadius, CornerRadius, CornerRadius), 90, 90)
        DGP.CloseFigure()

        obj.Region = New Region(DGP)
        AddBorder(obj)
    End Sub

    Private Sub AddBorder(obj As Form)
        ' Handle the Paint event to draw the border
        AddHandler obj.Paint, Sub(sender, e)
                                  Dim g As Graphics = e.Graphics

                                  Dim padding As Integer = 2 ' Adjust padding as needed
                                  Dim roundedRect As GraphicsPath = GetRoundedRect(New Rectangle(padding, padding, obj.ClientRectangle.Width - padding * 2, obj.ClientRectangle.Height - padding * 2), CornerRadius)

                                  ' Create a pen for the border
                                  Dim myPen As New Pen(Color.Maroon, 4)

                                  ' Set the smoothing mode to anti-alias the corners
                                  g.SmoothingMode = SmoothingMode.HighQuality

                                  ' Fill the background of the form
                                  g.FillRectangle(New SolidBrush(obj.BackColor), obj.ClientRectangle)

                                  ' Draw the rounded rectangle
                                  g.DrawPath(myPen, roundedRect)

                                  ' Dispose of the pen
                                  myPen.Dispose()
                              End Sub
    End Sub

    ' Handle the Paint event of the label
    Private Sub Label1_Paint(sender As Object, e As PaintEventArgs) Handles Label1.Paint
        ' Get the Graphics object
        Dim g As Graphics = e.Graphics

        Dim padding As Integer = 2 ' Adjust padding as needed

        Dim roundedRect As GraphicsPath = GetRoundedRect(New Rectangle(padding, padding, Label1.ClientRectangle.Width - padding * 2, Label1.ClientRectangle.Height - padding * 2), CornerRadius)

        ' Create a pen for the border
        Dim myPen As New Pen(Color.Maroon, 1.5)

        ' Set the smoothing mode to anti-alias the corners
        g.SmoothingMode = SmoothingMode.HighQuality

        ' Fill the background of the label
        g.FillRectangle(New SolidBrush(Label1.BackColor), Label1.ClientRectangle)

        ' Draw the rounded rectangle
        g.DrawPath(myPen, roundedRect)

        ' Dispose of the pen
        myPen.Dispose()
    End Sub

    ' Function to create a rounded rectangle
    Private Function GetRoundedRect(rect As Rectangle, radius As Integer) As GraphicsPath
        Dim path As New GraphicsPath()

        ' Create rounded rectangle path
        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90) ' Top-left corner
        path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90) ' Top-right corner
        path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90) ' Bottom-right corner
        path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90) ' Bottom-left corner
        path.CloseFigure()

        Return path
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

End Class