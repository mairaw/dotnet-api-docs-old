        public void DrawStringPointFFormat(PaintEventArgs e)
        {
                     
            // Create string to draw.
            String drawString = "Sample Text";
                     
            // Create font and brush.
            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
                     
            // Create point for upper-left corner of drawing.
            PointF drawPoint = new PointF(150.0F, 50.0F);
                     
            // Set format of string.
            StringFormat drawFormat = new StringFormat();
            drawFormat.FormatFlags = StringFormatFlags.DirectionVertical;
                     
            // Draw string to screen.
            e.Graphics.DrawString(drawString, drawFont, drawBrush, drawPoint, drawFormat);
        }