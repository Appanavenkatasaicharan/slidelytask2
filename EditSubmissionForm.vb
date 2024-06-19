Partial Public Class EditSubmissionForm
    Inherits System.Windows.Forms.Form
    Private ReadOnly httpHelper As New HttpHelper()
    Private ReadOnly currentIndex As Integer
    Private stopwatch As New Stopwatch()
    Private WithEvents timer As New Timer()
    Private initialTime As TimeSpan
    Public Sub New(index As Integer, name As String, email As String, phone As String, githubLink As String, stopwatchTime As String)
        InitializeComponent()
        Me.currentIndex = index
        Me.Text = "Edit Submission"

        ' Initialize controls
        txtName.Text = name
        txtEmail.Text = email
        txtPhone.Text = phone
        txtGithubLink.Text = githubLink
        txtStopwatchTime.Text = stopwatchTime
        TimeSpan.TryParse(stopwatchTime, initialTime)
        timer.Interval = 100

    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        Dim time = initialTime + stopwatch.Elapsed
        txtStopwatchTime.Text = time.ToString("hh\:mm\:ss")
    End Sub
    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try
            Dim success = Await httpHelper.UpdateAsync(currentIndex, txtName.Text, txtEmail.Text, txtPhone.Text, txtGithubLink.Text, txtStopwatchTime.Text)
            If success Then
                MessageBox.Show("Submission updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("Failed to update submission.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show($"An error occurred while updating submission: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnStopwatch_Click(sender As Object, e As EventArgs) Handles btnStopwatch.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
            timer.Stop()
        Else
            stopwatch.Start()
            timer.Start()
        End If
    End Sub

    Private Sub EditSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class