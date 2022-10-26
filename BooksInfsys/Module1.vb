Imports System.Data.SQLite

Module Module1

    Public cn As SQLiteConnection
    Public cmd As SQLiteCommand
    Public dr As SQLiteDataReader
    Public sql As String

    Public Sub openCon()
        cn = New SQLiteConnection("Data Source=C:\Users\jolly\source\repos\BooksInfsys\BooksInfsys\BooksInformationDB.db")

        If cn.State = ConnectionState.Closed Then
            cn.Open()
        End If
    End Sub

End Module
