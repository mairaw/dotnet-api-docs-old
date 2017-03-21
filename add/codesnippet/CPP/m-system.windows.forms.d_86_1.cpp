   // Select the first row.
private:
   void button7_Click( Object^ /*sender*/, EventArgs^ /*e*/ )
   {
      myDataGrid->Select(0);
   }

   // Check if the first row is selected.
private:
   void button8_Click( Object^ /*sender*/, EventArgs^ /*e*/ )
   {
      if ( myDataGrid->IsSelected( 0 ) )
      {
         MessageBox::Show( "Row selected", "Message", MessageBoxButtons::OK, MessageBoxIcon::Exclamation );
      }
      else
      {
         MessageBox::Show( "Row not selected", "Message", MessageBoxButtons::OK, MessageBoxIcon::Exclamation );
      }
   }

   // Deselect the first row.
   void button11_Click( Object^ /*sender*/, EventArgs^ /*e*/ )
   {
      myDataGrid->UnSelect( 0 );
   }