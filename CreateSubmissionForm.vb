Imports System.Diagnostics

Public Class CreateSubmissionForm
    Private stopwatch As New Stopwatch()
    Private WithEvents timer As New Timer()
    Private ReadOnly httpHelper As New HttpHelper()

    Public Sub New()

        InitializeComponent()
        Me.Text = "Sai Charan, Slidely Task 2 - Create Submission"
        Me.KeyPreview = True
        timer.Interval = 100

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

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        txtStopwatchTime.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Gather data from text boxes
        Dim name As String = txtName.Text
        Dim email As String = txtEmail.Text
        Dim phone As String = txtPhone.Text
        Dim githubLink As String = txtGithubLink.Text
        Dim stopwatchTime As String = txtStopwatchTime.Text

        ' Validate the data (optional but recommended)
        If String.IsNullOrWhiteSpace(name) OrElse
       String.IsNullOrWhiteSpace(email) OrElse
       String.IsNullOrWhiteSpace(phone) OrElse
       String.IsNullOrWhiteSpace(githubLink) Then
            MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Submit the data to the backend
        Try
            Dim success = Await httpHelper.SubmitAsync(name, email, phone, githubLink, stopwatchTime)
            If success Then
                MessageBox.Show("Submission successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Submission failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub UpdateStopwatchLabel()
        lblName.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit.PerformClick()
        End If
        If e.Control AndAlso e.KeyCode = Keys.T Then
            btnStopwatch.PerformClick()
        End If
    End Sub

    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
