    Private Sub DrawImageParaF(ByVal e As PaintEventArgs)

        ' Create image.
        Dim newImage As Image = Image.FromFile("SampImag.jpg")

        ' Create parallelogram for drawing image.
        Dim ulCorner As New PointF(100.0F, 100.0F)
        Dim urCorner As New PointF(550.0F, 100.0F)
        Dim llCorner As New PointF(150.0F, 250.0F)
        Dim destPara As PointF() = {ulCorner, urCorner, llCorner}

        ' Draw image to screen.
        e.Graphics.DrawImage(newImage, destPara)
    End Sub