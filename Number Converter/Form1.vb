Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim input As String = TextBox1.Text
            Dim number As Integer = Convert.ToInt32(input)

            Label1.Text = "You entered the number: " & number.ToString()
            Label1.ForeColor = Color.Green

        Catch ex As FormatException
            Label1.Text = "Error: Please enter a valid number!"
            Label1.ForeColor = Color.Red

        Catch ex As Exception
            Label1.Text = "An unexpected error occurred."
            Label1.ForeColor = Color.Red
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = ""
    End Sub
End Class
