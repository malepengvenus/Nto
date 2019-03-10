Public Class Member
    'declaring of public variables
    Public number As Integer = 54281857 'first six digits of student number
    Public MemNumber As Integer
    Public c As Integer = number
    Private Sub BtnGenerate_Click(sender As Object, e As EventArgs) Handles BtnGenerate.Click

        'Generate Member NR using a while loop
        c += 1
        While (c > 0)
            MemNumber += (c Mod 10)
            c /= 10
        End While
        MemNumber = 10 - (MemNumber Mod 8)
        MemNumber = CInt(Number.ToString & MemNumber.ToString)
        Number += 1
        'outputting it on a message box and a label
        MsgBox("Your member number is " & MemNumber)
        Me.LabelMemNumber.Text = "Your member number is " & MemNumber
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        ' clearing the form
        With Me
            .TextBoxName.Text = " "
            .TextBoxSurname.Text = " "
            .TextBoxOutFee.Text = " "
            .LabelMemNumber.Text = " "
        End With
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        'declaring variables to be used in text-file
        Dim writer As IO.StreamWriter
        Dim membReg As String
        Dim name, surname, memNumb, joinDate, birthDate, outFee, extra As String

        writer = IO.File.CreateText("membReg.txt")

        name = TextBoxName.Text
        surname = TextBoxSurname.Text
        joinDate = DateTimePicker2.Text
        birthDate = DateTimePicker1.Text
        outFee = TextBoxOutFee.Text
        'extra = lbExtra.Text
        memNumb = MemNumber

        'start the text file
        membReg = "=========================MEMBER DETAIAL REPORT================================"

        Dim BookButton As Integer
        BookButton = MessageBox.Show("Create new membReg.txt?", "membReg File", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        'create new information if neccesary
        writer.WriteLine(membReg)
        writer.WriteLine()
        writer.WriteLine()
        writer.WriteLine("======================================================================")
        writer.WriteLine("Member's Number               :" & memNumb)
        writer.WriteLine("======================================================================")
        writer.WriteLine("Member's Name                 :" & name)
        writer.WriteLine("======================================================================")
        writer.WriteLine("Member's Surname              :" & surname)
        writer.WriteLine("======================================================================")
        writer.WriteLine("Member's Join date            :" & joinDate)
        writer.WriteLine("======================================================================")
        writer.WriteLine("Member's Outstanding Fee      :" & outFee)
        writer.WriteLine("======================================================================")
        writer.WriteLine("Member's Extra Detials        :" & extra)
        writer.WriteLine("======================================================================")
        writer.WriteLine("Member's Date of Birth        :" & birthDate)
        writer.WriteLine("======================================================================")

        writer.Close()
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        ' code to go back to the main form 
        Me.Hide()
        Main.Visible = True
    End Sub

    Private Sub GenerateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerateToolStripMenuItem.Click
        'Generate Member NR using a while loop
        c += 1
        While (c > 0)
            MemNumber += (c Mod 10)
            c /= 10
        End While
        MemNumber = 10 - (MemNumber Mod 8)
        MemNumber = CInt(number.ToString & MemNumber.ToString)
        number += 1
        'outputting it on a message box and a label
        MsgBox("Your member number is " & MemNumber)
        Me.LabelMemNumber.Text = "Your member number is " & MemNumber
    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        ' clearing the form
        With Me
            .TextBoxName.Text = " "
            .TextBoxSurname.Text = " "
            .TextBoxOutFee.Text = " "
            .LabelMemNumber.Text = " "
        End With
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        'declaring variables to be used in text-file
        Dim writer As IO.StreamWriter
        Dim membReg As String
        Dim name, surname, memNumb, joinDate, birthDate, outFee, extra As String

        writer = IO.File.CreateText("membReg.txt")

        name = TextBoxName.Text
        surname = TextBoxSurname.Text
        joinDate = DateTimePicker2.Text
        birthDate = DateTimePicker1.Text
        outFee = TextBoxOutFee.Text
        'extra = lbExtra.Text
        memNumb = MemNumber

        'start the text file
        membReg = "=========================MEMBER DETAIAL REPORT================================"

        Dim BookButton As Integer
        BookButton = MessageBox.Show("Create new membReg.txt?", "membReg File", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        'create new information if neccesary
        writer.WriteLine(membReg)
        writer.WriteLine()
        writer.WriteLine()
        writer.WriteLine("======================================================================")
        writer.WriteLine("Member's Number               :" & memNumb)
        writer.WriteLine("======================================================================")
        writer.WriteLine("Member's Name                 :" & name)
        writer.WriteLine("======================================================================")
        writer.WriteLine("Member's Surname              :" & surname)
        writer.WriteLine("======================================================================")
        writer.WriteLine("Member's Join date            :" & joinDate)
        writer.WriteLine("======================================================================")
        writer.WriteLine("Member's Outstanding Fee      :" & outFee)
        writer.WriteLine("======================================================================")
        writer.WriteLine("Member's Extra Detials        :" & extra)
        writer.WriteLine("======================================================================")
        writer.WriteLine("Member's Date of Birth        :" & birthDate)
        writer.WriteLine("======================================================================")

        writer.Close()
    End Sub

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click

    End Sub

    Private Sub Member_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class