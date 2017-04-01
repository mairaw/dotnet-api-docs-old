      String^ uriString;
      Console::Write( "\nPlease enter the URI to post data to: " );
      uriString = Console::ReadLine();
      Console::WriteLine( "\nPlease enter the data to be posted to the URI {0}:", uriString );
      String^ postData = Console::ReadLine();
      // Apply ASCII encoding to obtain an array of bytes .
      array<Byte>^ postArray = Encoding::ASCII->GetBytes( postData );
      
      // Create a new WebClient instance.
      WebClient^ myWebClient = gcnew WebClient;

      Console::WriteLine( "Uploading to {0} ...", uriString );
      Stream^ postStream = myWebClient->OpenWrite( uriString, "POST" );
      postStream->Write( postArray, 0, postArray->Length );
      
      // Close the stream and release resources.
      postStream->Close();
      Console::WriteLine( "\nSuccessfully posted the data." );