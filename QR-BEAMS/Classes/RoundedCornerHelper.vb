Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports Guna.UI.WinForms ' Adjust this according to the actual namespace of Guna UI

Public Class RoundedCornerHelper
    Public Shared Sub SetRoundedCorners(panel As GunaPanel, cornerRadius As Integer)
        ' Add handler to draw rounded corners
        AddHandler panel.Paint, Sub(sender, e)
                                    DrawRoundedCorners(panel, e.Graphics, cornerRadius)
                                End Sub
        ' Set the region of the panel to be a rounded rectangle
        SetPanelRegion(panel, cornerRadius)
        panel.Invalidate() ' Force the panel to repaint with the new rounded corners
    End Sub

    Public Shared Sub SetRoundedCorners(form As Form, cornerRadius As Integer)
        ' Set the region of the form to be a rounded rectangle
        SetFormRegion(form, cornerRadius)
        form.Invalidate() ' Force the form to repaint with the new rounded corners
    End Sub

    Private Shared Sub DrawRoundedCorners(panel As GunaPanel, graphics As Graphics, cornerRadius As Integer)
        ' Create a path with rounded corners
        Dim path As GraphicsPath = GetRoundedRectanglePath(panel.ClientRectangle, cornerRadius)

        ' Set smoothing mode for better rendering
        graphics.SmoothingMode = SmoothingMode.AntiAlias

        ' Fill the panel with the background color
        graphics.FillPath(New SolidBrush(panel.BackColor), path)

        ' Draw the border if desired
        Dim pen As New Pen(panel.ForeColor, 1)
        graphics.DrawPath(pen, path)
    End Sub

    Private Shared Sub SetPanelRegion(panel As GunaPanel, cornerRadius As Integer)
        Dim path As GraphicsPath = GetRoundedRectanglePath(panel.ClientRectangle, cornerRadius)
        panel.Region = New Region(path)
    End Sub

    Private Shared Sub SetFormRegion(form As Form, cornerRadius As Integer)
        Dim path As GraphicsPath = GetRoundedRectanglePath(New Rectangle(0, 0, form.Width, form.Height), cornerRadius)
        form.Region = New Region(path)
    End Sub

    Private Shared Function GetRoundedRectanglePath(rect As Rectangle, radius As Integer) As GraphicsPath
        Dim path As New GraphicsPath()

        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
        path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90)
        path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90)
        path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90)
        path.CloseAllFigures()

        Return path
    End Function
End Class
