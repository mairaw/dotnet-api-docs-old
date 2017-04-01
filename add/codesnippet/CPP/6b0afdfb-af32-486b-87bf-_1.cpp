   void DrawImageParaFRectFAttrib( PaintEventArgs^ e )
   {
      // Create image.
      Image^ newImage = Image::FromFile( "SampImag.jpg" );

      // Create parallelogram for drawing original image.
      PointF ulCorner1 = PointF(100.0F,100.0F);
      PointF urCorner1 = PointF(325.0F,100.0F);
      PointF llCorner1 = PointF(150.0F,250.0F);
      array<PointF>^ destPara1 = {ulCorner1,urCorner1,llCorner1};

      // Create rectangle for source image.
      RectangleF srcRect = RectangleF(50.0F,50.0F,150.0F,150.0F);
      GraphicsUnit units = GraphicsUnit::Pixel;

      // Create parallelogram for drawing adjusted image.
      PointF ulCorner2 = PointF(325.0F,100.0F);
      PointF urCorner2 = PointF(550.0F,100.0F);
      PointF llCorner2 = PointF(375.0F,250.0F);
      array<PointF>^ destPara2 = {ulCorner2,urCorner2,llCorner2};

      // Draw original image to screen.
      e->Graphics->DrawImage( newImage, destPara1, srcRect, units );

      // Create image attributes and set large gamma.
      ImageAttributes^ imageAttr = gcnew ImageAttributes;
      imageAttr->SetGamma( 4.0F );

      // Draw adjusted image to screen.
      e->Graphics->DrawImage( newImage, destPara2, srcRect, units, imageAttr );
   }