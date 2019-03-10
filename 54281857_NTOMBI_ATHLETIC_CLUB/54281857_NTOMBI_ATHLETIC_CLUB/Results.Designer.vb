<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Results
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Results))
        Me.BtnNo = New System.Windows.Forms.Button()
        Me.BtnYes = New System.Windows.Forms.Button()
        Me.ListBoxDisplayEvent = New System.Windows.Forms.ListBox()
        Me.ListBoxDisplayMembers = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.resultsDataGridView = New System.Windows.Forms.DataGridView()
        Me.eventComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.resultsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnNo
        '
        Me.BtnNo.Location = New System.Drawing.Point(445, 360)
        Me.BtnNo.Name = "BtnNo"
        Me.BtnNo.Size = New System.Drawing.Size(51, 23)
        Me.BtnNo.TabIndex = 7
        Me.BtnNo.Text = "No"
        Me.BtnNo.UseVisualStyleBackColor = True
        '
        'BtnYes
        '
        Me.BtnYes.Location = New System.Drawing.Point(209, 360)
        Me.BtnYes.Name = "BtnYes"
        Me.BtnYes.Size = New System.Drawing.Size(50, 23)
        Me.BtnYes.TabIndex = 6
        Me.BtnYes.Text = "Yes"
        Me.BtnYes.UseVisualStyleBackColor = True
        '
        'ListBoxDisplayEvent
        '
        Me.ListBoxDisplayEvent.FormattingEnabled = True
        Me.ListBoxDisplayEvent.Location = New System.Drawing.Point(394, 12)
        Me.ListBoxDisplayEvent.Name = "ListBoxDisplayEvent"
        Me.ListBoxDisplayEvent.Size = New System.Drawing.Size(354, 342)
        Me.ListBoxDisplayEvent.TabIndex = 5
        '
        'ListBoxDisplayMembers
        '
        Me.ListBoxDisplayMembers.FormattingEnabled = True
        Me.ListBoxDisplayMembers.Location = New System.Drawing.Point(12, 12)
        Me.ListBoxDisplayMembers.Name = "ListBoxDisplayMembers"
        Me.ListBoxDisplayMembers.Size = New System.Drawing.Size(376, 342)
        Me.ListBoxDisplayMembers.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnExcel)
        Me.GroupBox1.Controls.Add(Me.resultsDataGridView)
        Me.GroupBox1.Controls.Add(Me.eventComboBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 389)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(580, 299)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "View Event Results"
        '
        'btnExcel
        '
        Me.btnExcel.Location = New System.Drawing.Point(458, 369)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(103, 30)
        Me.btnExcel.TabIndex = 13
        Me.btnExcel.Text = "&Excel"
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'resultsDataGridView
        '
        Me.resultsDataGridView.AllowUserToAddRows = False
        Me.resultsDataGridView.AllowUserToDeleteRows = False
        Me.resultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.resultsDataGridView.Location = New System.Drawing.Point(6, 86)
        Me.resultsDataGridView.Name = "resultsDataGridView"
        Me.resultsDataGridView.ReadOnly = True
        Me.resultsDataGridView.Size = New System.Drawing.Size(542, 190)
        Me.resultsDataGridView.TabIndex = 11
        '
        'eventComboBox
        '
        Me.eventComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.eventComboBox.FormattingEnabled = True
        Me.eventComboBox.Location = New System.Drawing.Point(175, 41)
        Me.eventComboBox.Name = "eventComboBox"
        Me.eventComboBox.Size = New System.Drawing.Size(386, 28)
        Me.eventComboBox.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Event Name"
        '
        'Results
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(760, 749)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnNo)
        Me.Controls.Add(Me.BtnYes)
        Me.Controls.Add(Me.ListBoxDisplayEvent)
        Me.Controls.Add(Me.ListBoxDisplayMembers)
        Me.Name = "Results"
        Me.Text = "Results"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.resultsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnNo As System.Windows.Forms.Button
    Friend WithEvents BtnYes As System.Windows.Forms.Button
    Friend WithEvents ListBoxDisplayEvent As System.Windows.Forms.ListBox
    Friend WithEvents ListBoxDisplayMembers As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents resultsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents eventComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
