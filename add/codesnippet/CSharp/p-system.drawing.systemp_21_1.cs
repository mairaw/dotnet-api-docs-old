        private void DrawWithMenuHighlightPen(PaintEventArgs e)
        {
            Rectangle rectangle1 = new Rectangle(10, 10, 100, 100);
            e.Graphics.DrawRectangle(SystemPens.MenuHighlight, rectangle1);
        }