Imports System.IO
Public Class AthMember





    'The hardcoded members file name
    Private Const fileName As String = "memReg.txt"

    Private Property birthdate As Date

    Private Property feeOutstanding As Decimal

    Private Property firstName As String

    Private Property gender As String

    Private Property joinDate As Date

    Private Property lastName As String

    Private Property memberNumber As Long

    Public Shared Sub RemoveMemberfile()
        'This will remove the current members file so that we can replace it with a new one
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

    Public Shared Function readFile() As List(Of Member)
        'This function will read the contents of the members file into a list of my Member objects and return the list
        Dim myDocuments As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments.ToString()
        Dim fileLines As List(Of Member) = New List(Of Member)
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

    Public Shared Sub writeFile(aMember As List(Of Member))
        'This will take the contents of a list of Member objects and write them to a text file
        Dim myDocuments As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments.ToString()
        Dim dirPath = myDocuments
        Dim filePath = dirPath & "\" & fileName
        Dim fs As FileStream = Nothing

        Try
            fs = New FileStream(filePath, FileMode.Append)
            Dim textOut = New StreamWriter(fs)

            For Each theMember As Member In aMember

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

    Public Shared Sub saveMembers(members As List(Of Member))
        'A simple sub to call the write file sub. Possibly redundant at this stage
        writeFile(members)
    End Sub






End Class
