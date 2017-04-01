      private void ToggleBold()
      {
         if (richTextBox1.SelectionFont != null)
         {
            System.Drawing.Font currentFont = richTextBox1.SelectionFont;
            System.Drawing.FontStyle newFontStyle;

            if (richTextBox1.SelectionFont.Bold == true)
            {
               newFontStyle = FontStyle.Regular;
            }
            else
            {
               newFontStyle = FontStyle.Bold;
            }

            richTextBox1.SelectionFont = new Font(
               currentFont.FontFamily, 
               currentFont.Size, 
               newFontStyle
            );
         }
      }