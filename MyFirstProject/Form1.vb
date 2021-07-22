'Project:       Hello World (Form1.vb / MyFirstProject.sln)
'Programmer:    KeShaun Pearson
'Date:          7/21/2021
'Description:   This project will display a "Hello World" message in two different languages and print the form


Public Class Form1

    Public Shared Sub Main()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'Exit the project

        Me.Close()
    End Sub

    Private Sub EnglishButton_Click(sender As Object, e As EventArgs) Handles EnglishButton.Click
        'Display the Hello World Message // comment 

        MessageLabel.Text = "Hello World"
    End Sub

    Private Sub SpanishButton_Click(sender As Object, e As EventArgs) Handles SpanishButton.Click
        'Display the Hello World Message in Spanish // comment 

        MessageLabel.Text = "Hola Mundo"
    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        'Print the form

        'PrintForm PowerPack Unavailable 




    End Sub
End Class
