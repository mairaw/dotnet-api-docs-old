    public void DrawVisualStyleElementWindowSmallCaption3(PaintEventArgs e)
    {
        if (VisualStyleRenderer.IsElementDefined(
            VisualStyleElement.Window.SmallCaption.Disabled))
        {
            VisualStyleRenderer renderer =
                 new VisualStyleRenderer(VisualStyleElement.Window.SmallCaption.Disabled);
            Rectangle rectangle1 = new Rectangle(10, 50, 50, 50);
            renderer.DrawBackground(e.Graphics, rectangle1);
            e.Graphics.DrawString("VisualStyleElement.Window.SmallCaption.Disabled",
                 this.Font, Brushes.Black, new Point(10, 10));
        }
        else
            e.Graphics.DrawString("This element is not defined in the current visual style.",
                 this.Font, Brushes.Black, new Point(10, 10));
    }