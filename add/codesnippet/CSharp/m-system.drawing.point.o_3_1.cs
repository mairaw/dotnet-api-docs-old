    private void ShowPointConverter(PaintEventArgs e)
    {

        // Create the PointConverter.
        System.ComponentModel.TypeConverter converter = 
            System.ComponentModel.TypeDescriptor.GetConverter(typeof(Point));

        Point point1 = (Point) converter.ConvertFromString("200, 200");

        // Use the subtraction operator to get a second point.
        Point point2 = point1 - new Size(190, 190);

        // Draw a line between the two points.
        e.Graphics.DrawLine(Pens.Black, point1, point2);
    }