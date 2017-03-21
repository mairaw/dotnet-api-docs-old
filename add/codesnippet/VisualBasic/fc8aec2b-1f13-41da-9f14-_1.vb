    Public Sub RotateAtExample(ByVal e As PaintEventArgs)
        Dim myPen As New Pen(Color.Blue, 1)
        Dim myPen2 As New Pen(Color.Red, 1)
        Dim rotatePoint As New PointF(150.0F, 50.0F)

        ' Draw the rectangle to the screen before applying the
        ' transform.
        e.Graphics.DrawRectangle(myPen, 150, 50, 200, 100)

        ' Create a matrix and rotate it 45 degrees.
        Dim myMatrix As New Matrix
        myMatrix.RotateAt(45, rotatePoint, MatrixOrder.Append)

        ' Draw the rectangle to the screen again after applying the
        ' transform.
        e.Graphics.Transform = myMatrix
        e.Graphics.DrawRectangle(myPen2, 150, 50, 200, 100)
    End Sub