private:
   void MyEventCollection()
   {
      // Creates a new collection and assigns it the events for button1.
      EventDescriptorCollection^ events = TypeDescriptor::GetEvents( button1 );
      
      // Displays each event in the collection in a text box.
      for each ( EventDescriptor^ myEvent in events )
      {
         textBox1->Text = String::Concat( textBox1->Text, myEvent->Name, "\n" );
      }
   }