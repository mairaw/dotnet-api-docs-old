      // Create the 'InputBinding' object.
      InputBinding^ myInputBinding = gcnew InputBinding;
      MimeTextBinding^ myMimeTextBinding = gcnew MimeTextBinding;
      MimeTextMatchCollection^ myMimeTextMatchCollection;

      // Get an array instance of 'MimeTextMatch' class.
      array<MimeTextMatch^>^myMimeTextMatch = gcnew array<MimeTextMatch^>(4);
      myMimeTextMatchCollection = myMimeTextBinding->Matches;

      // Initialize properties of 'MimeTextMatch' class.
      for ( myInt = 0; myInt < 4; myInt++ )
      {
         // Create the 'MimeTextMatch' instance.
         myMimeTextMatch[ myInt ] = gcnew MimeTextMatch;
         myMimeTextMatch[ myInt ]->Name = "Title";
         myMimeTextMatch[ myInt ]->Type = "*/*";
         myMimeTextMatch[ myInt ]->IgnoreCase = true;
         if ( true == myMimeTextMatchCollection->Contains( myMimeTextMatch[ 0 ] ) )
         {
            myMimeTextMatch[ myInt ]->Name = String::Format( "Title{0}", Convert::ToString( myInt ) );
            myMimeTextMatch[ myInt ]->Capture = 2;
            myMimeTextMatch[ myInt ]->Group = 2;
            myMimeTextMatchCollection->Add( myMimeTextMatch[ myInt ] );
         }
         else
         {
            myMimeTextMatchCollection->Add( myMimeTextMatch[ myInt ] );
            myMimeTextMatchCollection[ myInt ]->RepeatsString = "2";
         }
      }
      myMimeTextMatchCollection = myMimeTextBinding->Matches;
      
      // Copy collection to 'MimeTextMatch' array instance.
      myMimeTextMatchCollection->CopyTo( myMimeTextMatch, 0 );

      myInputBinding->Extensions->Add( myMimeTextBinding );

      // Add the 'InputBinding' to 'OperationBinding'.
      myOperationBinding->Input = myInputBinding;

      // Create the 'OutputBinding' instance.
      OutputBinding^ myOutputBinding = gcnew OutputBinding;

      // Create the 'MimeTextBinding' instance.
      MimeTextBinding^ myMimeTextBinding1 = gcnew MimeTextBinding;

      // Get an instance of 'MimeTextMatchCollection'.
      MimeTextMatchCollection^ myMimeTextMatchCollection1 = gcnew MimeTextMatchCollection;
      array<MimeTextMatch^>^myMimeTextMatch1 = gcnew array<MimeTextMatch^>(5);
      myMimeTextMatchCollection1 = myMimeTextBinding1->Matches;
      for ( myInt = 0; myInt < 4; myInt++ )
      {
         myMimeTextMatch1[ myInt ] = gcnew MimeTextMatch;
         myMimeTextMatch1[ myInt ]->Name = String::Format( "Title{0}", Convert::ToString( myInt ) );
         if ( myInt != 0 )
         {
            myMimeTextMatch1[ myInt ]->RepeatsString = "7";
         }
         myMimeTextMatchCollection1->Add( myMimeTextMatch1[ myInt ] );
      }
      myMimeTextMatch1[ 4 ] = gcnew MimeTextMatch;
      
      // Remove 'MimeTextMatch' instance from collection.
      myMimeTextMatchCollection1->Remove( myMimeTextMatch1[ 1 ] );
      
      // Using MimeTextMatchCollection.Item indexer to comapre. 
      if ( myMimeTextMatch1[ 2 ] == myMimeTextMatchCollection1[ 1 ] )
      {
         // Check whether 'MimeTextMatch' instance exists. 
         myInt = myMimeTextMatchCollection1->IndexOf( myMimeTextMatch1[ 2 ] );

         // Insert 'MimeTextMatch' instance at a desired position.
         myMimeTextMatchCollection1->Insert( 1, myMimeTextMatch1[ myInt ] );
         myMimeTextMatchCollection1[ 1 ]->RepeatsString = "5";
         myMimeTextMatchCollection1->Insert( 4, myMimeTextMatch1[ myInt ] );
      }