Public Class Login_frm
    Dim db As New SQL
    Private Sub Login_frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelHelper.SetRoundedCorners(GunaPanel1, 30)
        RoundedCornerHelper.SetRoundedCorners(Me, 30)
        GunaPanel1.BackColor = _PANELCOLOR
        signin_btn.BackColor = _BUTTONCOLOR
        Dim db As New DATABASE
        If db.NETWORK() Then
            connect_dot.Visible = True
            error_dot.Visible = False
        Else
            connect_dot.Visible = False
            error_dot.Visible = True
        End If
    End Sub
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Application.Exit()
    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles signin_btn.Click
        If db.LoginUser(Username.Text, Password.Text) Then
            MessageBox.Show($"Login Succesfully {Username.Text}", "LOGIN USER", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DASHBOARD.Show()
            Me.Hide()
        Else
            MessageBox.Show($"Login Failed {Username.Text} Check your inputs", "FAILED TO LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
