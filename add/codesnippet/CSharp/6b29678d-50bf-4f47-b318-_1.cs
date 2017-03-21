        private void DrawArcRectangle(PaintEventArgs e)
        {
           // Create pen.
            Pen blackPen= new Pen(Color.Black, 3);
                     
            // Create rectangle to bound ellipse.
            Rectangle rect = new Rectangle(0, 0, 100, 200);
                     
            // Create start and sweep angles on ellipse.
            float startAngle =  45.0F;
            float sweepAngle = 270.0F;
                     
            // Draw arc to screen.
            e.Graphics.DrawArc(blackPen, rect, startAngle, sweepAngle);
        }