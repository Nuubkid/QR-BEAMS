Imports ZXing
Public Class QrGen
    '--FUnction generates qr code of student--'
    Public Function GenerateQRCode(data As String) As Bitmap
        Dim writer As New BarcodeWriter()
        writer.Format = BarcodeFormat.QR_CODE
        writer.Options = New ZXing.Common.EncodingOptions() With {
            .Width = 300,
            .Height = 300
        }
        Return writer.Write(data)
    End Function

End Class
