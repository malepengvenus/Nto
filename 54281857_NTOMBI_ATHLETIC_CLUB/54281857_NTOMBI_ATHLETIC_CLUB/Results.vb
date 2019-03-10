Imports System.IO
Public Class Results

    Private Sub BtnYes_Click(sender As Object, e As EventArgs) Handles BtnYes.Click
        Dim result As Integer = MessageBox.Show("Completed Proccess, Please keep your membership no",
                                                "Athlete enrolment", MessageBoxButtons.OK)
        If result = DialogResult.OK Then
            'closes the proogram without printing
            Application.Exit()
        End If
    End Sub

    Private Sub BtnNo_Click(sender As Object, e As EventArgs) Handles BtnNo.Click
        'moving back to the previous form
        Me.Hide()
        Main.Visible = True
    End Sub

    Private Sub PerformanceFeed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Create a StreamReader class instance called "reader"
        Dim reader1 As StreamReader = New StreamReader(New FileStream("membReg.txt", FileMode.Open))
        ' Keep reading a line until we hit the end of the file
        Do While Not reader1.EndOfStream
            ' Read a line and add to listbox1
            ListBoxDisplayMembers.Items.Add(reader1.ReadLine())
        Loop
        reader1.Close()
        '''''''''''''''''''''''''''''''''''''''''''''
        ' Create a StreamReader class instance called "reader"
        Dim reader2 As StreamReader = New StreamReader(New FileStream("evntsReg.txt", FileMode.Open))
        ' Keep reading a line until we hit the end of the file
        Do While Not reader2.EndOfStream
            ' Read a line and add to listbox1
            ListBoxDisplayEvent.Items.Add(reader2.ReadLine())
        Loop
        reader2.Close()
        '''''''''''''''''''''''''''''''''''''''''''''
    End Sub
End Class