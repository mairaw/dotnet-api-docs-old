      // sets the amount of time to linger after closing, using the LingerOption public property.
      LingerOption^ lingerOption = gcnew LingerOption( true,10 );
      tcpClient->LingerState = lingerOption;
      
      // gets the amount of linger time set, using the LingerOption public property.
      if ( tcpClient->LingerState->LingerTime == 10 )
            Console::WriteLine( "The linger state setting was successfully set to {0}", tcpClient->LingerState->LingerTime );

      