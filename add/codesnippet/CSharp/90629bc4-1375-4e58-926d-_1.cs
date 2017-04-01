        private void RotateColors(PaintEventArgs e)
        {
            Bitmap image = new Bitmap("RotationInput.bmp");
            ImageAttributes imageAttributes = new ImageAttributes();
            int width = image.Width;
            int height = image.Height;
            float degrees = 60f;
            double r = degrees * System.Math.PI / 180; // degrees to radians

            float[][] colorMatrixElements = { 
                new float[] {(float)System.Math.Cos(r),  (float)System.Math.Sin(r),  0,  0, 0},
                new float[] {(float)-System.Math.Sin(r),  (float)-System.Math.Cos(r),  0,  0, 0},
                new float[] {0,  0,  2,  0, 0},
                new float[] {0,  0,  0,  1, 0},
                new float[] {0, 0, 0, 0, 1}};

            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);

            imageAttributes.SetColorMatrix(
               colorMatrix,
               ColorMatrixFlag.Default,
               ColorAdjustType.Bitmap);

            e.Graphics.DrawImage(image, 10, 10, width, height);

            e.Graphics.DrawImage(
               image,
               new Rectangle(150, 10, width, height),  // destination rectangle 
                0, 0,        // upper-left corner of source rectangle 
                width,       // width of source rectangle
                height,      // height of source rectangle
                GraphicsUnit.Pixel,
               imageAttributes);

        }