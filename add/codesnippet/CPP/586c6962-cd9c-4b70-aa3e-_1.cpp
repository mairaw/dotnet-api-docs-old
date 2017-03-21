         // Example for creating a NetworkStreams
         mySocket->Connect( myIpEndPoint );

         // Create the NetworkStream for communicating with the remote host.
         NetworkStream^ myNetworkStream;
         if ( networkStreamOwnsSocket )
         {
            myNetworkStream = gcnew NetworkStream( mySocket,FileAccess::ReadWrite,true );
         }
         else
         {
            myNetworkStream = gcnew NetworkStream( mySocket,FileAccess::ReadWrite );
         }