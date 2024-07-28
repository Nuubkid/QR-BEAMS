Public Class EVENTS_FORM
    Sub LoadColors()
        Register_btn.BaseColor = _BUTTONCOLOR
        Update_btn.BaseColor = _BUTTONCOLOR
        Delete_btn.BaseColor = _BUTTONCOLOR
        Clear_btn.BaseColor = _BUTTONCOLOR

    End Sub
    Private Sub EVENTS_FORM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadColors()
    End Sub
End Class