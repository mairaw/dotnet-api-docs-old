        public void Exclude_RectF_Example(PaintEventArgs e)
        {
                     
            // Create the first rectangle and draw it to the screen in black.
            Rectangle regionRect = new Rectangle(20, 20, 100, 100);
            e.Graphics.DrawRectangle(Pens.Black, regionRect);
                     
            // Create the second rectangle and draw it to the screen in red.
            RectangleF complementRect = new RectangleF(90, 30, 100, 100);
            e.Graphics.DrawRectangle(Pens.Red,
                Rectangle.Round(complementRect));
                     
            // Create a region using the first rectangle.
            Region myRegion = new Region(regionRect);
                     
            // Get the nonexcluded area of myRegion when combined with
                     
            // complementRect.
            myRegion.Exclude(complementRect);
                     
            // Fill the nonexcluded area of myRegion with blue.
            SolidBrush myBrush = new SolidBrush(Color.Blue);
            e.Graphics.FillRegion(myBrush, myRegion);
        }