<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PerformanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AthletesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EventsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnPerformance = New System.Windows.Forms.Button()
        Me.BtnManageAthlete = New System.Windows.Forms.Button()
        Me.BtnManageEvents = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(499, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.ManageToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PerformanceToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'PerformanceToolStripMenuItem
        '
        Me.PerformanceToolStripMenuItem.Name = "PerformanceToolStripMenuItem"
        Me.PerformanceToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.PerformanceToolStripMenuItem.Text = "Performance"
        '
        'ManageToolStripMenuItem
        '
        Me.ManageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AthletesToolStripMenuItem, Me.EventsToolStripMenuItem})
        Me.ManageToolStripMenuItem.Name = "ManageToolStripMenuItem"
        Me.ManageToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.ManageToolStripMenuItem.Text = "Manage"
        '
        'AthletesToolStripMenuItem
        '
        Me.AthletesToolStripMenuItem.Name = "AthletesToolStripMenuItem"
        Me.AthletesToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.AthletesToolStripMenuItem.Text = "Athletes"
        '
        'EventsToolStripMenuItem
        '
        Me.EventsToolStripMenuItem.Name = "EventsToolStripMenuItem"
        Me.EventsToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EventsToolStripMenuItem.Text = "Events"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(125, 252)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(194, 48)
        Me.BtnExit.TabIndex = 7
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'BtnPerformance
        '
        Me.BtnPerformance.Location = New System.Drawing.Point(125, 198)
        Me.BtnPerformance.Name = "BtnPerformance"
        Me.BtnPerformance.Size = New System.Drawing.Size(194, 48)
        Me.BtnPerformance.TabIndex = 6
        Me.BtnPerformance.Text = "Athlete Performance"
        Me.BtnPerformance.UseVisualStyleBackColor = True
        '
        'BtnManageAthlete
        '
        Me.BtnManageAthlete.Location = New System.Drawing.Point(125, 144)
        Me.BtnManageAthlete.Name = "BtnManageAthlete"
        Me.BtnManageAthlete.Size = New System.Drawing.Size(194, 48)
        Me.BtnManageAthlete.TabIndex = 5
        Me.BtnManageAthlete.Text = "Manage Athletes"
        Me.BtnManageAthlete.UseVisualStyleBackColor = True
        '
        'BtnManageEvents
        '
        Me.BtnManageEvents.Location = New System.Drawing.Point(125, 90)
        Me.BtnManageEvents.Name = "BtnManageEvents"
        Me.BtnManageEvents.Size = New System.Drawing.Size(194, 48)
        Me.BtnManageEvents.TabIndex = 4
        Me.BtnManageEvents.Text = "Manage Events"
        Me.BtnManageEvents.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(499, 450)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnPerformance)
        Me.Controls.Add(Me.BtnManageAthlete)
        Me.Controls.Add(Me.BtnManageEvents)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main"
        Me.Text = "Main Page"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PerformanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AthletesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EventsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents BtnPerformance As System.Windows.Forms.Button
    Friend WithEvents BtnManageAthlete As System.Windows.Forms.Button
    Friend WithEvents BtnManageEvents As System.Windows.Forms.Button

End Class
