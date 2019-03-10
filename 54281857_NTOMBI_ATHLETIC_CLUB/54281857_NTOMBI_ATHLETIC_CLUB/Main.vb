Public Class Main

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        ' code to exit the application
        Me.Close()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        ' code to exit the application
        Me.Close()
    End Sub

    Private Sub BtnManageEvents_Click(sender As Object, e As EventArgs) Handles BtnManageEvents.Click
        ' code to show the manage event form
        Me.Hide()
        AthleEvents.Visible = True
    End Sub

    Private Sub EventsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EventsToolStripMenuItem.Click
        ' code to show the manage event form
        Me.Hide()
        AthleEvents.Visible = True
    End Sub

    Private Sub BtnManageAthlete_Click(sender As Object, e As EventArgs) Handles BtnManageAthlete.Click
        ' code to show the manage athlete form
        Me.Hide()
        Member.Visible = True
    End Sub

    Private Sub AthletesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AthletesToolStripMenuItem.Click
        ' code to show the manage athlete form
        Me.Hide()
        Member.Visible = True
    End Sub

    Private Sub BtnPerformance_Click(sender As Object, e As EventArgs) Handles BtnPerformance.Click
        ' code to show the performance form
        Me.Hide()
        Results.Visible = True
    End Sub

    Private Sub PerformanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PerformanceToolStripMenuItem.Click
        ' code to show the performance form
        Me.Hide()
        Results.Visible = True
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
