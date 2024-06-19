Imports System.Net.Http
Imports System.Text
Imports System.Threading.Tasks
Imports Newtonsoft.Json

Public Class HttpHelper
    Private ReadOnly client As HttpClient

    Public Sub New()
        client = New HttpClient()
        client.BaseAddress = New Uri("http://localhost:3000/")
    End Sub

    Public Async Function PingAsync() As Task(Of Boolean)
        Dim response = Await client.GetAsync("ping")
        response.EnsureSuccessStatusCode()
        Return Await response.Content.ReadAsStringAsync() = "true"
    End Function

    Public Async Function SubmitAsync(name As String, email As String, phone As String, githubLink As String, stopwatchTime As String) As Task(Of Boolean)
        Dim payload = New With {
            .name = name,
            .email = email,
            .phone = phone,
            .github_link = githubLink,
            .stopwatch_time = stopwatchTime
        }

        Dim json = JsonConvert.SerializeObject(payload)
        Dim content = New StringContent(json, Encoding.UTF8, "application/json")
        Dim response = Await client.PostAsync("submit", content)
        Return response.IsSuccessStatusCode
    End Function

    Public Async Function ReadAsync(index As Integer) As Task(Of String)
        Dim response = Await client.GetAsync($"read?index={index}")
        response.EnsureSuccessStatusCode()
        Return Await response.Content.ReadAsStringAsync()
    End Function
    Public Async Function DeleteAsync(index As Integer) As Task(Of Boolean)
        Dim response = Await client.DeleteAsync($"delete?index={index}")
        Return response.IsSuccessStatusCode
    End Function

    Public Async Function UpdateAsync(index As Integer, name As String, email As String, phone As String, githubLink As String, stopwatchTime As String) As Task(Of Boolean)
        Dim payload = New With {
            .name = name,
            .email = email,
            .phone = phone,
            .github_link = githubLink,
            .stopwatch_time = stopwatchTime
        }

        Dim json = JsonConvert.SerializeObject(payload)
        Dim content = New StringContent(json, Encoding.UTF8, "application/json")

        Dim response = Await client.PutAsync($"update?index={index}", content)
        Return response.IsSuccessStatusCode
    End Function
End Class
