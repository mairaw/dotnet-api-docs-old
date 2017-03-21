    Public Sub RotateTransform_Example2(ByVal e As PaintEventArgs)

        ' Create a Pen object.
        Dim rotatePen As New Pen(Color.Black, 5)

        ' Scale rotatePen by 2X in the x-direction.
        rotatePen.ScaleTransform(2, 1)

        ' Draw a rectangle with rotatePen.
        e.Graphics.DrawRectangle(rotatePen, 10, 10, 100, 100)

        ' Rotate rotatePen 90 degrees clockwise.
        rotatePen.RotateTransform(90, MatrixOrder.Append)

        ' Draw a second rectangle with rotatePen.
        e.Graphics.DrawRectangle(rotatePen, 120, 10, 100, 100)
    End Sub