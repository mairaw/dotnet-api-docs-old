         // Get an array instance of 'MimeTextMatch' class.
         MimeTextMatch[] myMimeTextMatch = new MimeTextMatch[4];
         myMimeTextMatchCollection = myMimeTextBinding.Matches;
         // Initialize properties of 'MimeTextMatch' class.
         for( myInt = 0 ; myInt < 4 ; myInt++ )
         {
            // Create the 'MimeTextMatch' instance.
            myMimeTextMatch[ myInt ]  = new MimeTextMatch();
            myMimeTextMatch[ myInt ].Name = "Title";
            myMimeTextMatch[ myInt ].Type = "*/*";
            myMimeTextMatch[ myInt ].IgnoreCase = true;

            if(  true == myMimeTextMatchCollection.Contains( myMimeTextMatch[ 0 ] ) )
            {
               myMimeTextMatch[ myInt ].Name = "Title" + Convert.ToString( myInt );
               myMimeTextMatch[ myInt ].Capture = 2;
               myMimeTextMatch[ myInt ].Group = 2;
               myMimeTextMatchCollection.Add( myMimeTextMatch[ myInt ] );
            }
            else
            {
               myMimeTextMatchCollection.Add( myMimeTextMatch[ myInt ] );
               myMimeTextMatchCollection[ myInt ].RepeatsString = "2";
            }
         }
         myMimeTextMatchCollection = myMimeTextBinding.Matches;
         // Copy collection to 'MimeTextMatch' array instance.
         myMimeTextMatchCollection.CopyTo( myMimeTextMatch, 0 );