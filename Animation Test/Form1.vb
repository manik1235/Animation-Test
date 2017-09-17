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

        'DrawingStuff()
        'BeginContainerVoid(e)
        'FillPieRectangle(e)

        DrawBezierPoint(e)
    End Sub

    Private Sub DrawBezierPoint(ByVal e As PaintEventArgs)

        Dim randompt As New Random

        Dim pt As Integer = randompt.Next(200)

        ' Create pen.
        Dim blackPen As New Pen(Color.Black, 3)

        ' Create points for curve.
        Dim start As New Point(100, 100)
        Dim control1 As New Point(pt, 10)
        Dim control2 As New Point(350, 50)
        Dim [end] As New Point(500, 100)

        ' Draw arc to screen.
        e.Graphics.DrawBezier(blackPen, start, control1, control2, [end])
    End Sub

    Sub DrawingStuff()

        Dim PictureBox2Graphic As Graphics

        PictureBox2Graphic = PictureBox2.CreateGraphics()

        PictureBox2Graphic.DrawImage(PictureBox1.Image, New Point(10, 10))

        PictureBox2Graphic.RotateTransform(90)

        Dim PictureBox2DrawingMatrix As Drawing2D.Matrix
        PictureBox2DrawingMatrix = PictureBox2Graphic.Transform

        'PictureBox2DrawingMatrix.
        'System.Drawing.Drawing2D.GraphicsContainer
        'Dim AGraphicsContainer As New Drawing2D.GraphicsContainer
        'AGraphicsContainer = PictureBox2Graphic.BeginContainer(PictureBox2.Bounds, PictureBox1.Bounds, GraphicsUnit.Pixel)
        'PictureBox2Graphic.EndContainer()


    End Sub

    Private Sub BeginContainerVoid(ByVal e As PaintEventArgs)

        ' Begin graphics container.
        Dim containerState As Drawing2D.GraphicsContainer = e.Graphics.BeginContainer()

        ' Translate world transformation.
        e.Graphics.TranslateTransform(100.0F, 100.0F)

        ' Fill translated rectangle in container with red.
        '        e.Graphics.FillRectangle(New Drawing.TextureBrush(PictureBox1.Image, Drawing2D.WrapMode.TileFlipXY), 0, 0, 200, 300)

        'Dim containerState1 As Drawing2D.GraphicsContainer = e.Graphics.BeginContainer()

        '' Translate world transformation again
        'e.Graphics.TranslateTransform(200.0F, 50.0F)

        '' Fill translated rectangle in container1 with blue
        'e.Graphics.FillRectangle(New Drawing.SolidBrush(Color.Blue), New Rectangle(10, 0, 30, 50))

        'e.Graphics.EndContainer(containerState1)

        'e.Graphics.FillRectangle(New Drawing.SolidBrush(Color.Aqua), New Rectangle(10, 0, 70, 70))

        e.Graphics.FillPie(New Drawing.SolidBrush(Color.Purple), New Rectangle(0, 0, 20, 20), 10, 45)


        ' End graphics container.
        e.Graphics.EndContainer(containerState)

        ' Fill untransformed rectangle with green.
        e.Graphics.FillRectangle(New SolidBrush(Color.Green), 0, 0, 200, 200)

    End Sub

    Public Sub FillPieRectangle(ByVal e As PaintEventArgs)

        ' Create solid brush.
        Dim redBrush As New SolidBrush(Color.Red)

        ' Create rectangle for ellipse.
        Dim rect As New Rectangle(0, 0, 200, 100)

        ' Create start and sweep angles.
        Dim startAngle As Single = 0.0F
        Dim sweepAngle As Single = 45.0F

        ' Fill pie to screen.
        e.Graphics.FillPie(redBrush, rect, startAngle, sweepAngle)
    End Sub

End Class
