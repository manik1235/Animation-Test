Public Class Form1
    ' This project will be used to test the animation functions in Visual Basic

    Dim PaintCounter As Integer


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PaintCounter = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        PaintCounter += 1
        Debug.WriteLine("Form1_Paint #" & PaintCounter)
    End Sub
End Class
