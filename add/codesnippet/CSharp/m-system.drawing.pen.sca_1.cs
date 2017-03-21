        public void ScaleTransform_Example1(PaintEventArgs e)
        {
                     
            // Create a Pen object.
            Pen scalePen = new Pen(Color.Black, 5);
                     
            // Draw a rectangle with scalePen.
            e.Graphics.DrawRectangle(scalePen, 10, 10, 100, 100);
                     
            // Scale scalePen by 2X in the x-direction.
            scalePen.ScaleTransform(2, 1);
                     
            // Draw a second rectangle with rotatePen.
            e.Graphics.DrawRectangle(scalePen, 120, 10, 100, 100);
        }