public:
   static void AsynchronousFileSendWithBuffers()
   {
      // Send a file asynchronously to the remote device. Send a buffer before the file and a buffer afterwards.
      // Establish the remote endpoint for the socket.
      IPHostEntry^ ipHostInfo = Dns::GetHostEntry( Dns::GetHostName() );
      IPAddress^ ipAddress = ipHostInfo->AddressList[ 0 ];
      IPEndPoint^ remoteEP = gcnew IPEndPoint( ipAddress,11000 );

      // Create a TCP/IP socket.
      Socket^ client = gcnew Socket( AddressFamily::InterNetwork,SocketType::Stream,ProtocolType::Tcp );

      // Connect to the remote endpoint.
      client->BeginConnect( remoteEP, gcnew AsyncCallback( ConnectCallback ), client );

      // Wait for connect.
      connectDone->WaitOne();

      // Send a file fileName to the remote device with preBuffer and postBuffer data.
      // Create the preBuffer data.
      String^ string1 = String::Format( "This is text data that precedes the file.{0}", Environment::NewLine );
      array<Byte>^preBuf = Encoding::ASCII->GetBytes( string1 );

      // Create the postBuffer data.
      String^ string2 = String::Format( "This is text data that will follow the file.{0}", Environment::NewLine );
      array<Byte>^postBuf = Encoding::ASCII->GetBytes( string2 );

      // There is a file test.txt in the root directory.
      String^ fileName = "C:\\test.txt";

      //Send file fileName with buffers and default flags to the remote device.
      Console::WriteLine( fileName );
      client->BeginSendFile( fileName, preBuf, postBuf, static_cast<TransmitFileOptions>(0), gcnew AsyncCallback( AsynchronousFileSendCallback ), client );

      // Release the socket.
      client->Shutdown( SocketShutdown::Both );
      client->Close();
   }


private:
   static void AsynchronousFileSendCallback( IAsyncResult^ ar )
   {
      // Retrieve the socket from the state object.
      Socket^ client = dynamic_cast<Socket^>(ar->AsyncState);

      // Complete sending the data to the remote device.
      client->EndSendFile( ar );
      sendDone->Set();
   }