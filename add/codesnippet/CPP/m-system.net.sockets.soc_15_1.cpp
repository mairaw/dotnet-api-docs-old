   static void ReceiveFrom1()
   {
      IPHostEntry^ hostEntry = Dns::Resolve( Dns::GetHostName() );
      IPEndPoint^ endPoint = gcnew IPEndPoint( hostEntry->AddressList[ 0 ],11000 );

      Socket^ s = gcnew Socket( endPoint->Address->AddressFamily,
         SocketType::Dgram,
         ProtocolType::Udp );
      
      // Creates an IPEndPoint to capture the identity of the sending host.
      IPEndPoint^ sender = gcnew IPEndPoint( IPAddress::Any,0 );
      EndPoint^ senderRemote = safe_cast<EndPoint^>(sender);
      
      // Binding is required with ReceiveFrom calls.
      s->Bind( endPoint );

      array<Byte>^ msg = gcnew array<Byte>(256);
      Console::WriteLine( "Waiting to receive datagrams from client..." );
      
      // This call blocks. 
      s->ReceiveFrom( msg, senderRemote );
      s->Close();
   }