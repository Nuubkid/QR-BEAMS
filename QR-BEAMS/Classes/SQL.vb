Imports System.Diagnostics.Eventing
Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text
Public Class SQL

    Public Function LoginUser(User As String, Pass As String) As Boolean
        Try
            Dim reader As MySqlDataReader = Nothing
            _CONNECTION.open()
            Dim LogSQL As String = "SELECT * FROM tbl_account where username=@User AND password=@Pass"
            Dim LogCMD As New MySqlCommand(LogSQL, _CONNECTION)
            LogCMD.Parameters.AddWithValue("@User", User)
            LogCMD.Parameters.AddWithValue("@Pass", Pass)
            reader = LogCMD.ExecuteReader()
            If reader.HasRows Then
                Return True
            Else
                Return False
            End If
            Console.WriteLine(reader.ToString)
        Catch ex As Exception
            Return False
        Finally
            If _CONNECTION.state = ConnectionState.Open Then
                _CONNECTION.close()
            End If
        End Try
    End Function
    'Insert Student Info


    Public Function InsertStudent(StudentID As Integer, firstname As String, middlename As String, lastname As String, yearlvl As String, course As String, studpic As Image, ByRef errorMsg As String) As Boolean

        Try
            _CONNECTION.Open()
            Dim InsertSql As String = "INSERT INTO tbl_students (student_id, student_name, student_middlename, student_lastname, student_yearlvl, student_course, student_image) " &
                                  "VALUES (@student_id, @student_name, @student_middlename, @student_lastname, @student_yearlvl, @student_course, @student_image)"

            Using RegisterCMD As New MySqlCommand(InsertSql, _CONNECTION)
                RegisterCMD.Parameters.AddWithValue("@student_id", StudentID)
                RegisterCMD.Parameters.AddWithValue("@student_name", firstname)
                RegisterCMD.Parameters.AddWithValue("@student_middlename", middlename)
                RegisterCMD.Parameters.AddWithValue("@student_lastname", lastname)
                RegisterCMD.Parameters.AddWithValue("@student_yearlvl", yearlvl)
                RegisterCMD.Parameters.AddWithValue("@student_course", course)
                RegisterCMD.Parameters.AddWithValue("@student_image", ImageToBase64(studpic, System.Drawing.Imaging.ImageFormat.Png))

                Dim rowsAffected As Integer = RegisterCMD.ExecuteNonQuery()
                Return rowsAffected > 0
            End Using

        Catch ex As Exception
            errorMsg = ex.Message
            Return False

        Finally
            If _CONNECTION.State = ConnectionState.Open Then
                _CONNECTION.Close()
            End If
        End Try
    End Function


    '----IMAGE CONTROLS----'

    Function ImageToBase64(ByVal image As Image, ByVal format As System.Drawing.Imaging.ImageFormat) As String
        Dim ms As New MemoryStream
        image.Save(ms, format)
        Dim ImageByte() As Byte = ms.ToArray
        Dim base64String As String = Convert.ToBase64String(ImageByte)
        Return base64String
    End Function

    Function Base64ToImageLoad(ByVal base64String As String) As Image
        Try
            Dim imageBytes() As Byte = Convert.FromBase64String(base64String)
            If imageBytes.Length > 0 Then
                Using ms As New MemoryStream(imageBytes)
                    Dim image As Image = Image.FromStream(ms)
                    Return image
                End Using
            Else
                Console.WriteLine("Error loading image from Base64: Invalid image data")
                Return Nothing
            End If
        Catch ex As Exception
            Console.WriteLine("Error loading image from Base64: " & ex.Message)
            Return Nothing
        End Try
    End Function

    '--Load Student Data to Datagridview--'

    Public Sub LoadData(dgv As DataGridView)
        Dim dr As MySqlDataReader
        Dim qrgen As New QrGen
        Dim Usr As New USERS
        Try

            dgv.Rows.Clear()

            _CONNECTION.open()
            Dim sqlload As String = "SELECT * FROM tbl_students"
            Dim LoadData As New MySqlCommand(sqlload, _CONNECTION)

            dr = LoadData.ExecuteReader

            While dr.Read()
                Dim fullName As String = $"{dr.Item("student_name")} {dr.Item("student_middlename")} {dr.Item("student_lastname")}"
                Dim yearLevel As String = dr.Item("student_yearlvl").ToString()
                Dim course As String = dr.Item("student_course").ToString()
                Dim qrData As String = $"{fullName}, {yearLevel}, {course}"

                ' Generate QR code

                Dim qrImage As Bitmap = qrgen.GenerateQRCode(qrData)
                Usr.qrCodeImage = qrImage
                ' Add data to DataGridView
                dgv.Rows.Add(dr.Item("student_id"),
                         dr.Item("student_name"),
                         dr.Item("student_middlename"),
                         dr.Item("student_lastname"),
                         dr.Item("student_yearlvl"),
                         dr.Item("student_course")
                        ) ' Assuming qrImage is the QR code image
            End While
            dr.Dispose()
        Catch ex As Exception
            Console.WriteLine("Error Retireving Data" & ex.Message)
        Finally
            If _CONNECTION.State = ConnectionState.Open Then
                _CONNECTION.Close()
            End If
        End Try
    End Sub

    '---Load Student Image---'

    Public Sub LoadStudImage(studid As Integer, photobox As PictureBox)
        Try
            _CONNECTION.open()
            Dim dr As MySqlDataReader
            Dim sql As String = "SELECT student_image FROM tbl_students WHERE student_id =@studid"
            Dim command As New MySqlCommand(sql, _CONNECTION)
            command.Parameters.AddWithValue("@studid", studid)
            dr = command.ExecuteReader
            While dr.Read
                photobox.Image = Base64ToImageLoad(dr.Item("student_image").ToString)
            End While

        Catch ex As Exception
            Console.WriteLine("Error loading image of Student: " & ex.Message)
        Finally
            If _CONNECTION.State = ConnectionState.Open Then
                _CONNECTION.Close()
            End If
        End Try
    End Sub
End Class
