Imports WebCam_Capture
Imports MessagingToolkit.QRCode.Codec
Imports MessagingToolkit.QRCode.Codec.Data

Public Class Form1
    WithEvents mywebcam As WebCamCapture
    Dim reader As QRCodeDecoder

    Public Sub Startwebcam()
        Try
            Stopwebcam()
            mywebcam = New WebCamCapture
            mywebcam.Start(0)

        Catch ex As Exception
            MsgBox("Error starting webcam: " & ex.ToString)
        End Try
    End Sub

    Public Sub Stopwebcam()
        Try
            If mywebcam IsNot Nothing Then
                mywebcam.Stop()
                mywebcam.Dispose()
            End If
        Catch ex As Exception
            MsgBox("Error stopping webcam: " & ex.ToString)
        End Try
    End Sub

    Public Sub DetectQR()
        Try
            If PictureBox1.Image IsNot Nothing Then
                reader = New QRCodeDecoder
                TextBox1.Text = reader.decode(New QRCodeBitmapImage(New Bitmap(PictureBox1.Image)))
            Else
                Console.WriteLine("No image in PictureBox1 to decode.")
            End If
        Catch ex As Exception
            '   MsgBox("Error decoding QR code: " & ex.ToString)
        End Try
    End Sub

    Private Sub mywebcam_ImageCaptured(source As Object, e As WebcamEventArgs) Handles mywebcam.ImageCaptured
        PictureBox1.Image = e.WebCamImage
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Startwebcam()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DetectQR()
    End Sub
End Class
