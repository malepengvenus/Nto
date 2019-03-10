Public Class AthleEvents

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        ' clearing the input on the form'
        With Me
            TxtEvents.Clear()
            TxtRegFee.Clear()
            TxtEventLocation.Clear()
            TxtDistance.Clear()
        End With
    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        ' clearing the input on the form'
        With Me
            TxtEvents.Clear()
            TxtRegFee.Clear()
            TxtEventLocation.Clear()
            TxtDistance.Clear()
        End With
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        ' code to go back to the main form
        Me.Hide()
        Main.Visible = True
    End Sub

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        ' code to go back to the main form
        Me.Hide()
        Main.Visible = True
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim writer As IO.StreamWriter
        Dim eventsReg As String
        Dim eventTitle, eventDate, regFee, locationEvent, disEvents As String

        writer = IO.File.CreateText("evntsReg.txt")

        eventTitle = TxtEvents.Text
        eventDate = DateTimePicker1.Text
        regFee = TxtRegFee.Text
        locationEvent = TxtEventLocation.Text
        disEvents = TxtDistance.Text

        'start the text file
        eventsReg = "=========================EVENTS INFORMATION================================"

        Dim BookButton As Integer
        BookButton = MessageBox.Show("Create new eventsReg.txt?", "eventsReg File", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        'create new information if neccesary
        writer.WriteLine(eventsReg)
        writer.WriteLine()
        writer.WriteLine()
        writer.WriteLine("======================================================================")
        writer.WriteLine("Event's Title:                " & eventTitle)
        writer.WriteLine("======================================================================")
        writer.WriteLine("Event's Date:                 " & eventDate)
        writer.WriteLine("======================================================================")
        writer.WriteLine("Event's Registration Fee:     " & regFee)
        writer.WriteLine("======================================================================")
        writer.WriteLine("Event's Location:             " & locationEvent)
        writer.WriteLine("======================================================================")
        writer.WriteLine("Event's Distance:             " & disEvents)
        writer.WriteLine("======================================================================")

        writer.Close()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim writer As IO.StreamWriter
        Dim eventsReg As String
        Dim eventTitle, eventDate, regFee, locationEvent, disEvents As String

        writer = IO.File.CreateText("evntsReg.txt")

        eventTitle = TxtEvents.Text
        eventDate = DateTimePicker1.Text
        regFee = TxtRegFee.Text
        locationEvent = TxtEventLocation.Text
        disEvents = TxtDistance.Text

        'start the text file
        eventsReg = "=========================EVENTS INFORMATION================================"

        Dim BookButton As Integer
        BookButton = MessageBox.Show("Create new eventsReg.txt?", "eventsReg File", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        'create new information if neccesary
        writer.WriteLine(eventsReg)
        writer.WriteLine()
        writer.WriteLine()
        writer.WriteLine("======================================================================")
        writer.WriteLine("Event's Title:                " & eventTitle)
        writer.WriteLine("======================================================================")
        writer.WriteLine("Event's Date:                 " & eventDate)
        writer.WriteLine("======================================================================")
        writer.WriteLine("Event's Registration Fee:     " & regFee)
        writer.WriteLine("======================================================================")
        writer.WriteLine("Event's Location:             " & locationEvent)
        writer.WriteLine("======================================================================")
        writer.WriteLine("Event's Distance:             " & disEvents)
        writer.WriteLine("======================================================================")

        writer.Close()
    End Sub
End Class