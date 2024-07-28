Public Class USERS
    Dim imgpath As String = String.Empty
    Dim db As New SQL
    Dim errorMsg As String = String.Empty
    Dim yr As String = String.Empty
    Dim ln As String = String.Empty
    Public qrCodeImage As Bitmap
    Private Sub USERS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadColors()


        'load datagridview
        db.LoadData(GunaDataGridView1)
    End Sub
    Sub LoadColors()
        Register_btn.BaseColor = _BUTTONCOLOR
        Update_btn.BaseColor = _BUTTONCOLOR
        Delete_btn.BaseColor = _BUTTONCOLOR
        Clear_btn.BaseColor = _BUTTONCOLOR
        Search_btn.BaseColor = _BUTTONCOLOR
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim opendialog As New OpenFileDialog
        opendialog.Filter = "Images Files| *.jpg;*.jpeg;*.png;*"
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Try
            If opendialog.ShowDialog = DialogResult.OK Then
                imgpath = opendialog.FileName
                PictureBox1.ImageLocation = imgpath
            End If
            opendialog = Nothing

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Image", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Register_btn_Click(sender As Object, e As EventArgs) Handles Register_btn.Click

        If String.IsNullOrWhiteSpace(GunaTextBox1.Text) OrElse
            String.IsNullOrWhiteSpace(GunaTextBox2.Text) OrElse
            String.IsNullOrWhiteSpace(GunaTextBox3.Text) OrElse
            String.IsNullOrWhiteSpace(GunaTextBox4.Text) OrElse
              GunaComboBox1.SelectedItem Is Nothing OrElse
              GunaComboBox2.SelectedItem Is Nothing OrElse
              PictureBox1.Image Is Nothing Then

            MessageBox.Show("Check Empty Inputs", "MISSING INPUTS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If db.InsertStudent(GunaTextBox1.Text, GunaTextBox2.Text, GunaTextBox3.Text, GunaTextBox4.Text, GunaComboBox1.SelectedItem, GunaComboBox2.SelectedItem, PictureBox1.Image, errorMsg) Then
            MessageBox.Show("Inserted Succesfull", "ADDED SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            db.LoadData(GunaDataGridView1)
        Else
            MessageBox.Show(errorMsg, "ADDED FAILED", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub



    Private Function GetQRCodeFolderPath() As String
        Dim desktopPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        Dim qrBeamsPath As String = System.IO.Path.Combine(desktopPath, "QRBEAMS")

        ' Create the folder if it does not exist
        If Not System.IO.Directory.Exists(qrBeamsPath) Then
            System.IO.Directory.CreateDirectory(qrBeamsPath)
        End If

        Return qrBeamsPath
    End Function
    Private Sub SaveQRCodeImage(image As Bitmap, lastName As String, yearLevel As String)
        Dim qrBeamsPath As String = GetQRCodeFolderPath()

        ' Create a filename based on last name and year level
        Dim fileName As String = $"{lastName}-{yearLevel}.png"
        Dim filePath As String = System.IO.Path.Combine(qrBeamsPath, fileName)

        Try
            image.Save(filePath, Imaging.ImageFormat.Png)
            MessageBox.Show("QR Code saved successfully at " & filePath, "Save Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error saving QR Code: " & ex.Message, "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Try
            SaveQRCodeImage(PictureBox2.Image, ln, yr)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub GunaDataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GunaDataGridView1.CellClick
        Try
            ' Ensure the click is within a valid row and column index
            If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                ' Check if the clicked cell is the button column
                If GunaDataGridView1.Columns(e.ColumnIndex).Name = "DownloadQR" Then
                    ' Retrieve data from the selected row
                    GunaTextBox1.Text = GunaDataGridView1.CurrentRow.Cells(0).Value
                    GunaTextBox2.Text = GunaDataGridView1.CurrentRow.Cells(1).Value
                    GunaTextBox3.Text = GunaDataGridView1.CurrentRow.Cells(2).Value
                    GunaTextBox4.Text = GunaDataGridView1.CurrentRow.Cells(3).Value
                    GunaComboBox1.Text = GunaDataGridView1.CurrentRow.Cells(4).Value
                    GunaComboBox2.Text = GunaDataGridView1.CurrentRow.Cells(5).Value
                    db.LoadStudImage(GunaTextBox1.Text, PictureBox1)

                    ' Retrieve last name and year level for QR code
                    Dim studid As String = GunaDataGridView1.CurrentRow.Cells(0).Value
                    Dim lastName As String = GunaDataGridView1.CurrentRow.Cells(3).Value
                    Dim yearLevel As String = GunaDataGridView1.CurrentRow.Cells(4).Value
                    Dim qrgen As New QrGen


                    Dim qrCodeImage As Image = qrgen.GenerateQRCode(studid & " " & lastName & " " & yearLevel)

                    ' Display QR code in PictureBox2
                    PictureBox2.Image = qrCodeImage

                    ' Save QR code image to file
                    SaveQRCodeImage(qrCodeImage, lastName, yearLevel)
                Else
                    GunaTextBox1.Text = GunaDataGridView1.CurrentRow.Cells(0).Value
                    GunaTextBox2.Text = GunaDataGridView1.CurrentRow.Cells(1).Value
                    GunaTextBox3.Text = GunaDataGridView1.CurrentRow.Cells(2).Value
                    GunaTextBox4.Text = GunaDataGridView1.CurrentRow.Cells(3).Value
                    GunaComboBox1.Text = GunaDataGridView1.CurrentRow.Cells(4).Value
                    GunaComboBox2.Text = GunaDataGridView1.CurrentRow.Cells(5).Value
                    db.LoadStudImage(GunaTextBox1.Text, PictureBox1)
                    Dim lastName As String = GunaDataGridView1.CurrentRow.Cells(3).Value.ToString()
                    Dim yearLevel As String = GunaDataGridView1.CurrentRow.Cells(4).Value
                    Dim qrgen As New QrGen
                    ' Generate QR code (assuming qrCodeImage is the QR code for the student)
                    Dim qrCodeImage As Image = qrgen.GenerateQRCode(lastName & " " & yearLevel)

                    ' Display QR code in PictureBox2
                    PictureBox2.Image = qrCodeImage
                End If
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub GunaDataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GunaDataGridView1.CellContentClick

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class