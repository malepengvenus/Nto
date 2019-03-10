Imports System.IO
Public Class Evnt


    'The hardcoded events file name
    Private Const fileName As String = "EventReg.txt"

    Public Shared Sub RemoveEventfile()
        'This will remove the current event file so that we can replace it with a new one
        Dim myDocuments As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments.ToString()
        Dim dirPath = myDocuments
        Dim filePath = dirPath & "\" & fileName

        Try
            If System.IO.File.Exists(filePath) = True Then
                System.IO.File.Delete(filePath)
            End If

        Catch ex As FileNotFoundException
            MessageBox.Show(filePath & " not found.", "File not Found")
        Catch ex As DirectoryNotFoundException
            MessageBox.Show(dirPath & " not found.", "Directory not Found")
        Catch ex As IOException
            MessageBox.Show(ex.Message, "IOException")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Unknown exception")
        End Try

    End Sub

    Public Shared Function readFile() As List(Of TraceEventType)
        'This function will read the contents of the events file into a list of my RaceEvent objects and return the list
        Dim myDocuments As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments.ToString()
        Dim fileLines As List(Of TraceEventType) = New List(Of TraceEventType)
        Dim dirPath = myDocuments
        Dim filePath = dirPath & "\" & fileName
        Dim fs As FileStream = Nothing

        Try
            fs = New FileStream(filePath, FileMode.OpenOrCreate)
            Dim textIn As New StreamReader(fs)

           

            textIn.Close()

        Catch ex As FileNotFoundException
            MessageBox.Show(filePath & " not found.", "File not Found")
        Catch ex As DirectoryNotFoundException
            MessageBox.Show(dirPath & " not found.", "Directory not Found")
        Catch ex As IOException
            MessageBox.Show(ex.Message, "IOException")
        Finally
            If fs IsNot Nothing Then
                fs.Close()
            End If
        End Try

        Return fileLines
    End Function

    Public Shared Sub writeFile(raceEvents As List(Of TraceEventType))
        'This will take the contents of a list of RaceEvent objects and write them to a text file
        Dim myDocuments As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments.ToString()
        Dim dirPath = myDocuments
        Dim filePath = dirPath & "\" & fileName
        Dim fs As FileStream = Nothing

        Try
            fs = New FileStream(filePath, FileMode.Append)
            Dim textOut = New StreamWriter(fs)

            For Each RaceEvent As TraceEventType In raceEvents

            Next

            textOut.Close()

        Catch ex As FileNotFoundException
            MessageBox.Show(filePath & " not found.", "File not Found")
        Catch ex As DirectoryNotFoundException
            MessageBox.Show(dirPath & " not found.", "Directory not Found")
        Catch ex As IOException
            MessageBox.Show(ex.Message, "IOException")
        Finally
            If fs IsNot Nothing Then
                fs.Close()
            End If
        End Try

    End Sub
End Class
