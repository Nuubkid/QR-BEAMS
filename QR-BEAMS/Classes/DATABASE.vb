Imports MySql.Data.MySqlClient
Public Class DATABASE
    Public Function NETWORK() As Boolean
        Try
            _CONNECTION.open()
            If _CONNECTION.state = ConnectionState.Open Then
                Return True
            End If
            Return False
        Catch ex As Exception
            Return False
        Finally
            _CONNECTION.close()
        End Try
    End Function

End Class
