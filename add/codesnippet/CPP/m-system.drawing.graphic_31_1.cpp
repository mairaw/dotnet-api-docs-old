public:
   void FromHdcHdc( PaintEventArgs^ e )
   {
      // Get handle to device context.
      IntPtr hdc = e->Graphics->GetHdc();

      // Create new graphics object using handle to device context.
      Graphics^ newGraphics = Graphics::FromHdc( hdc );

      // Draw rectangle to screen.
      newGraphics->DrawRectangle( gcnew Pen( Color::Red,3.0f ), 0, 0, 200, 100 );

      // Release handle to device context and dispose of the      // Graphics object
      e->Graphics->ReleaseHdc( hdc );
      delete newGraphics;
   }