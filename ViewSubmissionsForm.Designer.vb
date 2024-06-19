<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionsForm
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnPrevious = New Button()
        btnNext = New Button()
        lblStopwatchTime = New Label()
        lblName = New Label()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtGithubLink = New TextBox()
        txtStopwatchTime = New TextBox()
        lblEmail = New Label()
        lblPhone = New Label()
        lblGithubLink = New Label()
        btnEdit = New Button()
        btnDelete = New Button()
        SuspendLayout()
        ' 
        ' btnPrevious
        ' 
        btnPrevious.Location = New Point(70, 391)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(215, 47)
        btnPrevious.TabIndex = 0
        btnPrevious.Text = "Previous (Ctrl + P)"
        btnPrevious.UseVisualStyleBackColor = True
        ' 
        ' btnNext
        ' 
        btnNext.Location = New Point(457, 391)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(215, 47)
        btnNext.TabIndex = 1
        btnNext.Text = "Next (Ctrl + N)"
        btnNext.UseVisualStyleBackColor = True
        ' 
        ' lblStopwatchTime
        ' 
        lblStopwatchTime.AutoSize = True
        lblStopwatchTime.Location = New Point(117, 267)
        lblStopwatchTime.Name = "lblStopwatchTime"
        lblStopwatchTime.Size = New Size(113, 20)
        lblStopwatchTime.TabIndex = 2
        lblStopwatchTime.Text = "Stopwatch time"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(117, 37)
        lblName.Name = "lblName"
        lblName.Size = New Size(49, 20)
        lblName.TabIndex = 1
        lblName.Text = "Name"
        ' 
        ' txtName
        ' 
        txtName.BackColor = SystemColors.ActiveBorder
        txtName.Location = New Point(452, 30)
        txtName.Name = "txtName"
        txtName.ReadOnly = True
        txtName.Size = New Size(220, 27)
        txtName.TabIndex = 3
        txtName.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = SystemColors.ActiveBorder
        txtEmail.Location = New Point(452, 89)
        txtEmail.Name = "txtEmail"
        txtEmail.ReadOnly = True
        txtEmail.Size = New Size(220, 27)
        txtEmail.TabIndex = 4
        txtEmail.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtPhone
        ' 
        txtPhone.BackColor = SystemColors.ActiveBorder
        txtPhone.Location = New Point(452, 146)
        txtPhone.Name = "txtPhone"
        txtPhone.ReadOnly = True
        txtPhone.Size = New Size(220, 27)
        txtPhone.TabIndex = 5
        txtPhone.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.BackColor = SystemColors.ActiveBorder
        txtGithubLink.Location = New Point(452, 204)
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.ReadOnly = True
        txtGithubLink.Size = New Size(220, 27)
        txtGithubLink.TabIndex = 6
        txtGithubLink.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtStopwatchTime
        ' 
        txtStopwatchTime.BackColor = SystemColors.ActiveBorder
        txtStopwatchTime.Location = New Point(452, 260)
        txtStopwatchTime.Name = "txtStopwatchTime"
        txtStopwatchTime.ReadOnly = True
        txtStopwatchTime.Size = New Size(220, 27)
        txtStopwatchTime.TabIndex = 7
        txtStopwatchTime.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(117, 89)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(46, 20)
        lblEmail.TabIndex = 8
        lblEmail.Text = "Email"
        lblEmail.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.Location = New Point(117, 146)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(50, 20)
        lblPhone.TabIndex = 9
        lblPhone.Text = "Phone"
        lblPhone.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblGithubLink
        ' 
        lblGithubLink.AutoSize = True
        lblGithubLink.Location = New Point(117, 204)
        lblGithubLink.Name = "lblGithubLink"
        lblGithubLink.Size = New Size(83, 20)
        lblGithubLink.TabIndex = 10
        lblGithubLink.Text = "Github Link"
        lblGithubLink.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' btnEdit
        ' 
        btnEdit.Location = New Point(69, 323)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(131, 42)
        btnEdit.TabIndex = 11
        btnEdit.Text = "Edit (Ctrl+E)"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(237, 323)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(123, 42)
        btnDelete.TabIndex = 12
        btnDelete.Text = "Delete (Ctrl+D)"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnDelete)
        Controls.Add(btnEdit)
        Controls.Add(lblStopwatchTime)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(lblGithubLink)
        Controls.Add(lblPhone)
        Controls.Add(lblEmail)
        Controls.Add(txtStopwatchTime)
        Controls.Add(txtGithubLink)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(lblName)
        Name = "ViewSubmissionsForm"
        Text = "Sai Charan, Slidely Task 2 - View Submissions"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents txtStopwatchTime As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblGithubLink As Label
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents lblStopwatchTime As Label
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
End Class
