Public Class DASHBOARD

    Private Sub DASHBOARD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoundedCornerHelper.SetRoundedCorners(Me, 30)
        Side_pnl.BackColor = _PANELCOLOR
        header_pnl.BackColor = _HEADERCOLOR
        Switcher_pnl.BackColor = _PANELCOLOR
    End Sub
    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        Dim message = "Are you sure you want to sign out?"
        Dim result As DialogResult = MessageBox.Show(message, "SIGN OUT", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Me.Hide()
            Login_frm.Show()
        Else

        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        'Dashboard button ni mate
        F_Changer(Switcher_pnl, DASH)
    End Sub

    Public Sub F_Changer(P As Panel, panel As Form)
        P.Controls.Clear()
        panel.TopLevel = False
        P.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        F_Changer(Switcher_pnl, EVENTS_FORM)
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        F_Changer(Switcher_pnl, USERS)
    End Sub

    Private Sub Switcher_pnl_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Switcher_pnl_Paint_1(sender As Object, e As PaintEventArgs) Handles Switcher_pnl.Paint

    End Sub
End Class