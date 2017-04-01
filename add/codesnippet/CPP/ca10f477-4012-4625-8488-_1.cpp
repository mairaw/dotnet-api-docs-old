public:
   void SetBlendTriangularShapeExample( PaintEventArgs^ e )
   {
      // Create a graphics path and add a rectangle.
      GraphicsPath^ myPath = gcnew GraphicsPath;
      Rectangle rect = Rectangle(100,20,100,50);
      myPath->AddRectangle( rect );

      // Get the path's array of points.
      array<PointF>^myPathPointArray = myPath->PathPoints;

      // Create a path gradient brush.
      PathGradientBrush^ myPGBrush = gcnew PathGradientBrush( myPathPointArray );

      // Set the color span.
      myPGBrush->CenterColor = Color::Red;
      array<Color>^ mySurroundColor = {Color::Blue};
      myPGBrush->SurroundColors = mySurroundColor;

      // Draw the brush to the screen prior to the blend.
      e->Graphics->FillRectangle( myPGBrush, 10, 10, 200, 200 );

      // Set the Blend factors.
      myPGBrush->SetBlendTriangularShape( 0.5f, 1.0f );

      // Move the brush down by 100 by Applying the translate
      // transform to the brush.
      myPGBrush->TranslateTransform( 0, 100, MatrixOrder::Append );

      // Draw the brush to the screen again after applying the
      // transforms.
      e->Graphics->FillRectangle( myPGBrush, 10, 10, 300, 300 );
   }