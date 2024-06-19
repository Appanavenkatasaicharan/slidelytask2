<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissionForm
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
        btnStopwatch = New Button()
        lblName = New Label()
        btnSubmit = New Button()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtGithubLink = New TextBox()
        txtStopwatchTime = New TextBox()
        lblEmail = New Label()
        lblPhone = New Label()
        lblGithubLink = New Label()
        SuspendLayout()
        ' 
        ' btnStopwatch
        ' 
        btnStopwatch.Location = New Point(117, 254)
        btnStopwatch.Name = "btnStopwatch"
        btnStopwatch.Size = New Size(207, 38)
        btnStopwatch.TabIndex = 0
        btnStopwatch.Text = "Toggle Stopwatch (Ctrl + T)"
        btnStopwatch.UseVisualStyleBackColor = True
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
        ' btnSubmit
        ' 
        btnSubmit.Location = New Point(117, 330)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(555, 58)
        btnSubmit.TabIndex = 2
        btnSubmit.Text = "Submit (Ctrl + S)"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(452, 30)
        txtName.Name = "txtName"
        txtName.Size = New Size(220, 27)
        txtName.TabIndex = 3
        txtName.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(452, 89)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(220, 27)
        txtEmail.TabIndex = 4
        txtEmail.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(452, 146)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(220, 27)
        txtPhone.TabIndex = 5
        txtPhone.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.Location = New Point(452, 204)
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.Size = New Size(220, 27)
        txtGithubLink.TabIndex = 6
        txtGithubLink.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtStopwatchTime
        ' 
        txtStopwatchTime.Location = New Point(452, 260)
        txtStopwatchTime.Name = "txtStopwatchTime"
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
        ' CreateSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblGithubLink)
        Controls.Add(lblPhone)
        Controls.Add(lblEmail)
        Controls.Add(txtStopwatchTime)
        Controls.Add(txtGithubLink)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(btnSubmit)
        Controls.Add(lblName)
        Controls.Add(btnStopwatch)
        Name = "CreateSubmissionForm"
        Text = "Sai Charan, Slidely Task 2 - Create Submission"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnStopwatch As Button
    Friend WithEvents lblName As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents txtStopwatchTime As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblGithubLink As Label
End Class
