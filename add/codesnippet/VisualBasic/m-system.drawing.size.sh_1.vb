    Private Sub InitializeLabel1()

        ' Set a border.
        Label1.BorderStyle = BorderStyle.FixedSingle

        ' Set the size, constructing a size from two integers.
        Label1.Size = New Size(100, 50)

        ' Set the location, constructing a point from a 32-bit integer
        ' (using hexadecimal).
        Label1.Location = New Point(&H280028)

        ' Set and align the text on the lower-right side of the label.
        Label1.TextAlign = ContentAlignment.BottomRight
        Label1.Text = "Bottom Right Alignment"
    End Sub