public:
   void FillClosedCurvePointF( PaintEventArgs^ e )
   {
      // Create solid brush.
      SolidBrush^ redBrush = gcnew SolidBrush( Color::Red );

      //Create array of points for curve.
      PointF point1 = PointF(100.0F,100.0F);
      PointF point2 = PointF(200.0F,50.0F);
      PointF point3 = PointF(250.0F,200.0F);
      PointF point4 = PointF(50.0F,150.0F);
      array<PointF>^ points = {point1,point2,point3,point4};

      // Fill curve on screen.
      e->Graphics->FillClosedCurve( redBrush, points );
   }