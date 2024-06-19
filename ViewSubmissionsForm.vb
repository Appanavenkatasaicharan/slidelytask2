Imports System.Net.Http
Imports System.Text
Imports System.Threading.Tasks
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class ViewSubmissionsForm
    Private currentIndex As Integer = 0
    Private ReadOnly httpHelper As New HttpHelper()
    Public Sub New()
        InitializeComponent()
        Me.Text = "John Doe, Slidely Task 2 - View Submissions"
        Me.KeyPreview = True
        LoadSubmission(currentIndex)

    End Sub
    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            btnPrevious.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnNext.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.E Then
            btnEdit.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.D Then
            btnDelete.PerformClick()
        End If
    End Sub
    Private Async Sub LoadSubmission(index As Integer)
        Try
            Dim response = Await httpHelper.ReadAsync(index)
            Dim submission = JObject.Parse(response)
            txtName.Text = submission("name").ToString()
            txtEmail.Text = submission("email").ToString()
            txtPhone.Text = submission("phone").ToString()
            txtGithubLink.Text = submission("github_link").ToString()
            txtStopwatchTime.Text = submission("stopwatch_time").ToString()

        Catch ex As Exception
            If currentIndex > 0 Then
                currentIndex -= 1
            End If
            MessageBox.Show("No more submissions available")
        End Try
    End Sub
    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            LoadSubmission(currentIndex)
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        currentIndex += 1
        LoadSubmission(currentIndex)
    End Sub

    Private Async Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim success = Await httpHelper.DeleteAsync(currentIndex)
            If success Then
                MessageBox.Show("Submission deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If currentIndex > 0 Then currentIndex -= 1
                LoadSubmission(currentIndex)
            Else
                MessageBox.Show("Failed to delete submission.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show($"An error occurred while deleting submission: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim editForm As New EditSubmissionForm(currentIndex, txtName.Text, txtEmail.Text, txtPhone.Text, txtGithubLink.Text, txtStopwatchTime.Text)
        editForm.ShowDialog()
        LoadSubmission(currentIndex)
    End Sub

End Class

