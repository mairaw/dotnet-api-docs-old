   //Create a byte array for binary data to associate with the entry.
   array<Byte>^myByte = gcnew array<Byte>(10);
   //Populate the byte array with simulated data.
   for ( int i = 0; i < 10; i++ )
   {
      myByte[ i ] = (Byte)(i % 2);
   }
   //Write an entry to the event log that includes associated binary data.
   Console::WriteLine( "Write from second source " );
   EventLog::WriteEntry( "SecondSource", "Writing warning to event log.",
      EventLogEntryType::Error, myEventID, myCategory, myByte );