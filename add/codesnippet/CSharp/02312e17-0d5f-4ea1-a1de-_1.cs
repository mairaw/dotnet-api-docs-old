        public void DrawRectangleFloat(PaintEventArgs e)
        {
                     
            // Create pen.
            Pen blackPen = new Pen(Color.Black, 3);
                     
            // Create location and size of rectangle.
            float x = 0.0F;
            float y = 0.0F;
            float width = 200.0F;
            float height = 200.0F;
                     
            // Draw rectangle to screen.
            e.Graphics.DrawRectangle(blackPen, x, y, width, height);
        }