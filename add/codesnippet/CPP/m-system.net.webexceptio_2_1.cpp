      try
      {
         // A 'Socket' object has been created.
         Socket^ httpSocket = gcnew Socket( AddressFamily::InterNetwork, SocketType::Stream, ProtocolType::Tcp );
         
         // The IPaddress of the unknown uri is resolved using the 'Dns::Resolve' method.
         IPHostEntry^ hostEntry = Dns::Resolve( connectUri );

         IPAddress^ serverAddress = hostEntry->AddressList[ 0 ];
         IPEndPoint^ endPoint = gcnew IPEndPoint( serverAddress, 80 );
         httpSocket->Connect( endPoint );
         Console::WriteLine( "Connection created successfully" );
         httpSocket->Close();
      }
      catch ( SocketException^ e ) 
      {
         Console::WriteLine( "\nException thrown.\nThe Original Message is: {0}", e->Message );
         
         // Throw the 'WebException' object with a message string specific to the situation.
         throw gcnew WebException( "Unable to locate the Server with 'www.contoso.com' Uri." );
      }